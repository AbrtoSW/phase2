using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Phase2
{
    public partial class frmAuthorEdit : Form
    {
        private string connString = @"Server=(localdb)\MSSQLLocalDB;Database=BookCollectionDB;Trusted_Connection=True;";
        private int? _authorId;

        public frmAuthorEdit(int? authorId = null)
        {
            InitializeComponent();
            _authorId = authorId;

            btnSave.Click += btnSave_Click;
            btnCancel.Click += (s, e) => this.Close();

            if (_authorId.HasValue)
                LoadAuthor(_authorId.Value);

            ApplyMaxLengths();
        }

        private void ApplyMaxLengths()
        {
            txtFirstName.MaxLength = 50;
            txtLastName.MaxLength = 50;
            txtCountry.MaxLength = 50;
        }

        private void LoadAuthor(int id)
        {
            using (SqlConnection conn = new SqlConnection(connString))
            using (SqlCommand cmd = new SqlCommand("SELECT * FROM Authors WHERE AuthorID=@id", conn))
            {
                cmd.Parameters.AddWithValue("@id", id);
                conn.Open();

                using (SqlDataReader r = cmd.ExecuteReader())
                {
                    if (r.Read())
                    {
                        txtFirstName.Text = r["FirstName"].ToString();
                        txtLastName.Text = r["LastName"].ToString();
                        txtCountry.Text = r["Country"].ToString();
                    }
                }
            }
        }

        private bool ValidateInputs()
        {
            if (string.IsNullOrWhiteSpace(txtFirstName.Text))
            {
                MessageBox.Show("First Name is required.");
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtLastName.Text))
            {
                MessageBox.Show("Last Name is required.");
                return false;
            }
            return true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs())
                return;

            if (_authorId.HasValue)
                UpdateAuthor();
            else
                AddAuthor();

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void AddAuthor()
        {
            using (SqlConnection conn = new SqlConnection(connString))
            using (SqlCommand cmd = new SqlCommand("sp_AddAuthor", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@FirstName", txtFirstName.Text.Trim());
                cmd.Parameters.AddWithValue("@LastName", txtLastName.Text.Trim());
                cmd.Parameters.AddWithValue("@Country",
                    string.IsNullOrWhiteSpace(txtCountry.Text) ? (object)DBNull.Value : txtCountry.Text.Trim());

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        private void UpdateAuthor()
        {
            using (SqlConnection conn = new SqlConnection(connString))
            using (SqlCommand cmd = new SqlCommand("sp_UpdateAuthor", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@AuthorID", _authorId.Value);
                cmd.Parameters.AddWithValue("@FirstName", txtFirstName.Text.Trim());
                cmd.Parameters.AddWithValue("@LastName", txtLastName.Text.Trim());
                cmd.Parameters.AddWithValue("@Country",
                    string.IsNullOrWhiteSpace(txtCountry.Text) ? (object)DBNull.Value : txtCountry.Text.Trim());

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}
