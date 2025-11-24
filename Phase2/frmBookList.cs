using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Phase2
{
    public partial class frmBookList : Form
    {
        private string connString = @"Server=(localdb)\MSSQLLocalDB;
      Database=BookCollectionDB;
      Trusted_Connection=True;";

        public frmBookList()
        {
            InitializeComponent();
            LoadBooks();
            dgvBooks.CellContentClick += dgvBooks_CellContentClick;
            searchBtn.Click += searchBtn_Click;
            addBookBtn.Click += addBookBtn_Click;
        }

        private void LoadBooks()
        {
            using (SqlConnection conn = new SqlConnection(connString))
            using (SqlCommand cmd = new SqlCommand("sp_GetAllBooks", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                conn.Open();

                DataTable dt = new DataTable();
                dt.Load(cmd.ExecuteReader());

                dgvBooks.Rows.Clear();
                foreach (DataRow row in dt.Rows)
                {
                    dgvBooks.Rows.Add(
                        row["Title"].ToString(),
                        row["AuthorID"].ToString(),
                        row["Genre"].ToString(),
                        row["PublicationYear"].ToString(),
                        "Edit",
                        "Delete"
                    );
                }
            }
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            SearchBooks(txtSearchTitle.Text.Trim());
        }

        private void SearchBooks(string title)
        {
            using (SqlConnection conn = new SqlConnection(connString))
            using (SqlCommand cmd = new SqlCommand("SELECT * FROM Books WHERE Title LIKE @t", conn))
            {
                cmd.Parameters.AddWithValue("@t", "%" + title + "%");
                conn.Open();

                DataTable dt = new DataTable();
                dt.Load(cmd.ExecuteReader());

                dgvBooks.Rows.Clear();
                foreach (DataRow row in dt.Rows)
                {
                    dgvBooks.Rows.Add(
                        row["Title"].ToString(),
                        row["AuthorID"].ToString(),
                        row["Genre"].ToString(),
                        row["PublicationYear"].ToString(),
                        "Edit",
                        "Delete"
                    );
                }
            }
        }

        private void dgvBooks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            string selectedTitle = dgvBooks.Rows[e.RowIndex].Cells["Title"].Value.ToString();

            if (dgvBooks.Columns[e.ColumnIndex].Name == "Edit")
            {
                int bookID = GetBookIDByTitle(selectedTitle);
                frmBookEdit editForm = new frmBookEdit(bookID);
                editForm.ShowDialog();
                LoadBooks();
            }

            if (dgvBooks.Columns[e.ColumnIndex].Name == "Delete")
            {
                int bookID = GetBookIDByTitle(selectedTitle);
                DeleteBook(bookID);
                LoadBooks();
            }
        }

        private int GetBookIDByTitle(string title)
        {
            using (SqlConnection conn = new SqlConnection(connString))
            using (SqlCommand cmd = new SqlCommand("SELECT BookID FROM Books WHERE Title = @t", conn))
            {
                cmd.Parameters.AddWithValue("@t", title);
                conn.Open();
                return Convert.ToInt32(cmd.ExecuteScalar());
            }
        }

        private void DeleteBook(int id)
        {
            using (SqlConnection conn = new SqlConnection(connString))
            using (SqlCommand cmd = new SqlCommand("sp_DeleteBook", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@BookID", id);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        private void addBookBtn_Click(object sender, EventArgs e)
        {
            frmBookEdit f = new frmBookEdit(); // open in Add mode
            f.ShowDialog();
            LoadBooks(); // refresh after adding
        }

    }
}
