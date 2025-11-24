using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Phase2
{
    public partial class frmBookEdit : Form
    {
        private readonly string connString =
            @"Server=(localdb)\MSSQLLocalDB;Database=BookCollectionDB;Trusted_Connection=True;";

        // null = Add, value = Edit
        private readonly int? _bookId;

        public frmBookEdit(int? bookId = null)
        {
            InitializeComponent();

            _bookId = bookId;

            SetControlLimits();
            cboAuthor.DropDownStyle = ComboBoxStyle.DropDownList;

            LoadAuthors();

            btnSave.Click += btnSave_Click;
            btnCancel.Click += (s, e) => this.Close();

            if (_bookId.HasValue)
            {
                LoadBook(_bookId.Value);
            }
        }

        private void SetControlLimits()
        {
            // From SQL definition
            // Title VARCHAR(150)
            txtTitle.MaxLength = 150;

            // ISBN VARCHAR(20)
            txtISBN.MaxLength = 20;

            // Genre VARCHAR(50)
            txtGenre.MaxLength = 50;

            // ShelfLocation VARCHAR(50)
            txtShelfLocation.MaxLength = 50;

            // Condition VARCHAR(50)
            txtCondition.MaxLength = 50;

            // FileFormat VARCHAR(20)
            txtFileFormat.MaxLength = 20;

            // FilePathOrLink VARCHAR(255)
            txtFilePathOrLink.MaxLength = 255;

            // PublicationYear INT, FileSizeMB DECIMAL – length enforced by validation
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

                // Add a FullName column for display
                dt.Columns.Add("FullName", typeof(string));
                foreach (DataRow row in dt.Rows)
                {
                    row["FullName"] = row["FirstName"] + " " + row["LastName"];
                }

                cboAuthor.DataSource = dt;
                cboAuthor.DisplayMember = "FullName";
                cboAuthor.ValueMember = "AuthorID";
                cboAuthor.SelectedIndex = -1;
            }
        }

        private void LoadBook(int bookId)
        {
            using (SqlConnection conn = new SqlConnection(connString))
            using (SqlCommand cmd = new SqlCommand("SELECT * FROM Books WHERE BookID = @id", conn))
            {
                cmd.Parameters.AddWithValue("@id", bookId);
                conn.Open();

                using (SqlDataReader rdr = cmd.ExecuteReader())
                {
                    if (!rdr.Read()) return;

                    txtTitle.Text = rdr["Title"].ToString();
                    txtGenre.Text = rdr["Genre"].ToString();
                    txtISBN.Text = rdr["ISBN"].ToString();
                    txtPublicationYear.Text = rdr["PublicationYear"] == DBNull.Value
                        ? ""
                        : rdr["PublicationYear"].ToString();

                    chkIsRead.Checked = (bool)rdr["IsRead"];

                    txtShelfLocation.Text = rdr["ShelfLocation"].ToString();
                    txtCondition.Text = rdr["Condition"].ToString();
                    chkIsHardcover.Checked = rdr["IsHardcover"] != DBNull.Value && (bool)rdr["IsHardcover"];

                    txtFileFormat.Text = rdr["FileFormat"].ToString();
                    txtFileSizeMB.Text = rdr["FileSizeMB"] == DBNull.Value ? "" : rdr["FileSizeMB"].ToString();
                    txtFilePathOrLink.Text = rdr["FilePathOrLink"].ToString();

                    int authorId = (int)rdr["AuthorID"];
                    cboAuthor.SelectedValue = authorId;
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs())
                return;

            if (_bookId.HasValue)
                UpdateBook();
            else
                AddBook();

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private bool ValidateInputs()
        {
            // basic, clear
            if (string.IsNullOrWhiteSpace(txtTitle.Text))
            {
                MessageBox.Show("Title is required.", "Validation");
                txtTitle.Focus();
                return false;
            }

            if (cboAuthor.SelectedIndex < 0)
            {
                MessageBox.Show("Author is required.", "Validation");
                cboAuthor.Focus();
                return false;
            }

            if (!string.IsNullOrWhiteSpace(txtPublicationYear.Text))
            {
                if (!int.TryParse(txtPublicationYear.Text, out _))
                {
                    MessageBox.Show("Publication Year must be a whole number.", "Validation");
                    txtPublicationYear.Focus();
                    return false;
                }
            }

            if (!string.IsNullOrWhiteSpace(txtFileSizeMB.Text))
            {
                if (!decimal.TryParse(txtFileSizeMB.Text, out _))
                {
                    MessageBox.Show("File Size must be a decimal number.", "Validation");
                    txtFileSizeMB.Focus();
                    return false;
                }
            }

            return true;
        }

        private string DetermineBookType()
        {
            // Simple rule: if it has ebook fields, treat as EBook
            bool hasEBookData =
                !string.IsNullOrWhiteSpace(txtFileFormat.Text) ||
                !string.IsNullOrWhiteSpace(txtFilePathOrLink.Text);

            return hasEBookData ? "EBook" : "Physical";
        }

        private void AddBook()
        {
            using (SqlConnection conn = new SqlConnection(connString))
            using (SqlCommand cmd = new SqlCommand("sp_AddBook", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Title", txtTitle.Text.Trim());
                cmd.Parameters.AddWithValue("@ISBN", (object)txtISBN.Text.Trim() ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@PublicationYear",
                    string.IsNullOrWhiteSpace(txtPublicationYear.Text)
                        ? (object)DBNull.Value
                        : int.Parse(txtPublicationYear.Text.Trim()));
                cmd.Parameters.AddWithValue("@Genre", (object)txtGenre.Text.Trim() ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@AuthorID", (int)cboAuthor.SelectedValue);
                cmd.Parameters.AddWithValue("@IsRead", chkIsRead.Checked);

                cmd.Parameters.AddWithValue("@ShelfLocation",
                    string.IsNullOrWhiteSpace(txtShelfLocation.Text)
                        ? (object)DBNull.Value
                        : txtShelfLocation.Text.Trim());

                cmd.Parameters.AddWithValue("@Condition",
                    string.IsNullOrWhiteSpace(txtCondition.Text)
                        ? (object)DBNull.Value
                        : txtCondition.Text.Trim());

                cmd.Parameters.AddWithValue("@IsHardcover",
                    chkIsHardcover.Checked ? (object)true : (object)DBNull.Value);

                cmd.Parameters.AddWithValue("@FileFormat",
                    string.IsNullOrWhiteSpace(txtFileFormat.Text)
                        ? (object)DBNull.Value
                        : txtFileFormat.Text.Trim());

                cmd.Parameters.AddWithValue("@FileSizeMB",
                    string.IsNullOrWhiteSpace(txtFileSizeMB.Text)
                        ? (object)DBNull.Value
                        : decimal.Parse(txtFileSizeMB.Text.Trim()));

                cmd.Parameters.AddWithValue("@FilePathOrLink",
                    string.IsNullOrWhiteSpace(txtFilePathOrLink.Text)
                        ? (object)DBNull.Value
                        : txtFilePathOrLink.Text.Trim());

                cmd.Parameters.AddWithValue("@BookType", DetermineBookType());

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        private void UpdateBook()
        {
            using (SqlConnection conn = new SqlConnection(connString))
            using (SqlCommand cmd = new SqlCommand("sp_UpdateBook", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@BookID", _bookId.Value);
                cmd.Parameters.AddWithValue("@Title", txtTitle.Text.Trim());
                cmd.Parameters.AddWithValue("@ISBN", (object)txtISBN.Text.Trim() ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@PublicationYear",
                    string.IsNullOrWhiteSpace(txtPublicationYear.Text)
                        ? (object)DBNull.Value
                        : int.Parse(txtPublicationYear.Text.Trim()));
                cmd.Parameters.AddWithValue("@Genre", (object)txtGenre.Text.Trim() ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@AuthorID", (int)cboAuthor.SelectedValue);
                cmd.Parameters.AddWithValue("@IsRead", chkIsRead.Checked);

                cmd.Parameters.AddWithValue("@ShelfLocation",
                    string.IsNullOrWhiteSpace(txtShelfLocation.Text)
                        ? (object)DBNull.Value
                        : txtShelfLocation.Text.Trim());

                cmd.Parameters.AddWithValue("@Condition",
                    string.IsNullOrWhiteSpace(txtCondition.Text)
                        ? (object)DBNull.Value
                        : txtCondition.Text.Trim());

                cmd.Parameters.AddWithValue("@IsHardcover",
                    chkIsHardcover.Checked ? (object)true : (object)DBNull.Value);

                cmd.Parameters.AddWithValue("@FileFormat",
                    string.IsNullOrWhiteSpace(txtFileFormat.Text)
                        ? (object)DBNull.Value
                        : txtFileFormat.Text.Trim());

                cmd.Parameters.AddWithValue("@FileSizeMB",
                    string.IsNullOrWhiteSpace(txtFileSizeMB.Text)
                        ? (object)DBNull.Value
                        : decimal.Parse(txtFileSizeMB.Text.Trim()));

                cmd.Parameters.AddWithValue("@FilePathOrLink",
                    string.IsNullOrWhiteSpace(txtFilePathOrLink.Text)
                        ? (object)DBNull.Value
                        : txtFilePathOrLink.Text.Trim());

                cmd.Parameters.AddWithValue("@BookType", DetermineBookType());

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}
