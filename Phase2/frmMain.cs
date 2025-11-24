using System;
using System.Windows.Forms;

namespace Phase2
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();

            btnViewAllBooks.Click += btnViewAllBooks_Click;
            btnAddBook.Click += btnAddBook_Click;
            btnManageAuthors.Click += btnManageAuthors_Click;
        }

        private void btnViewAllBooks_Click(object sender, EventArgs e)
        {
            frmBookList f = new frmBookList();
            f.ShowDialog();
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            frmBookEdit f = new frmBookEdit();
            f.ShowDialog();
        }

        private void btnManageAuthors_Click(object sender, EventArgs e)
        {
            frmAuthors f = new frmAuthors();
            f.ShowDialog();
        }
    }
}
