using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Phase2
{
    public partial class frmAuthors : Form
    {
        private string connString = @"Server=(localdb)\MSSQLLocalDB;Database=BookCollectionDB;Trusted_Connection=True;";

        public frmAuthors()
        {
            InitializeComponent();

            btnAddAuthor.Click += btnAddAuthor_Click;
            dgvAuthors.CellContentClick += dgvAuthors_CellContentClick;

            LoadAuthors();
        }

        private void LoadAuthors()
        {
            using (SqlConnection conn = new SqlConnection(connString))
            using (SqlCommand cmd = new SqlCommand("sp_GetAllAuthors", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                conn.Open();

                DataTable dt = new DataTable();
                dt.Load(cmd.ExecuteReader());

                dgvAuthors.Rows.Clear();

                foreach (DataRow row in dt.Rows)
                {
                    dgvAuthors.Rows.Add(
                        row["FirstName"].ToString(),
                        row["LastName"].ToString(),
                        row["Country"].ToString(),
                        "Edit",
                        "Delete"
                    );
                }
            }
        }

        private void btnAddAuthor_Click(object sender, EventArgs e)
        {
            frmAuthorEdit f = new frmAuthorEdit(); // no ID = add mode
            f.ShowDialog();
            LoadAuthors();
        }

        private void dgvAuthors_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            string firstName = dgvAuthors.Rows[e.RowIndex].Cells["FirstName"].Value.ToString();
            string lastName = dgvAuthors.Rows[e.RowIndex].Cells["LastName"].Value.ToString();
            int authorId = GetAuthorID(firstName, lastName);

            if (dgvAuthors.Columns[e.ColumnIndex].Name == "Edit")
            {
                frmAuthorEdit f = new frmAuthorEdit(authorId);
                f.ShowDialog();
                LoadAuthors();
            }

            if (dgvAuthors.Columns[e.ColumnIndex].Name == "Delete")
            {
                DeleteAuthor(authorId);
                LoadAuthors();
            }
        }

        private int GetAuthorID(string firstName, string lastName)
        {
            using (SqlConnection conn = new SqlConnection(connString))
            using (SqlCommand cmd =
                   new SqlCommand("SELECT AuthorID FROM Authors WHERE FirstName=@fn AND LastName=@ln", conn))
            {
                cmd.Parameters.AddWithValue("@fn", firstName);
                cmd.Parameters.AddWithValue("@ln", lastName);

                conn.Open();
                return Convert.ToInt32(cmd.ExecuteScalar());
            }
        }

        private void DeleteAuthor(int id)
        {
            // No stored procedure, so delete manually
            using (SqlConnection conn = new SqlConnection(connString))
            using (SqlCommand cmd =
                   new SqlCommand("DELETE FROM Authors WHERE AuthorID=@id", conn))
            {
                cmd.Parameters.AddWithValue("@id", id);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}
