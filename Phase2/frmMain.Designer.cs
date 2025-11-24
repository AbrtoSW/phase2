namespace Phase2
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnViewAllBooks = new System.Windows.Forms.Button();
            this.btnAddBook = new System.Windows.Forms.Button();
            this.btnManageAuthors = new System.Windows.Forms.Button();
            this.txtSearchTitle = new System.Windows.Forms.TextBox();
            this.searchLbl = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnViewAllBooks
            // 
            this.btnViewAllBooks.Location = new System.Drawing.Point(43, 107);
            this.btnViewAllBooks.Name = "btnViewAllBooks";
            this.btnViewAllBooks.Size = new System.Drawing.Size(109, 23);
            this.btnViewAllBooks.TabIndex = 0;
            this.btnViewAllBooks.Text = "View ALL Books";
            this.btnViewAllBooks.UseVisualStyleBackColor = true;
            // 
            // btnAddBook
            // 
            this.btnAddBook.Location = new System.Drawing.Point(43, 161);
            this.btnAddBook.Name = "btnAddBook";
            this.btnAddBook.Size = new System.Drawing.Size(109, 23);
            this.btnAddBook.TabIndex = 1;
            this.btnAddBook.Text = "Add Book";
            this.btnAddBook.UseVisualStyleBackColor = true;
            // 
            // btnManageAuthors
            // 
            this.btnManageAuthors.Location = new System.Drawing.Point(43, 216);
            this.btnManageAuthors.Name = "btnManageAuthors";
            this.btnManageAuthors.Size = new System.Drawing.Size(109, 23);
            this.btnManageAuthors.TabIndex = 2;
            this.btnManageAuthors.Text = "Manage Authors";
            this.btnManageAuthors.UseVisualStyleBackColor = true;
            // 
            // txtSearchTitle
            // 
            this.txtSearchTitle.Location = new System.Drawing.Point(96, 292);
            this.txtSearchTitle.Name = "txtSearchTitle";
            this.txtSearchTitle.Size = new System.Drawing.Size(249, 20);
            this.txtSearchTitle.TabIndex = 3;
            // 
            // searchLbl
            // 
            this.searchLbl.AutoSize = true;
            this.searchLbl.Location = new System.Drawing.Point(49, 295);
            this.searchLbl.Name = "searchLbl";
            this.searchLbl.Size = new System.Drawing.Size(41, 13);
            this.searchLbl.TabIndex = 4;
            this.searchLbl.Text = "Search";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(96, 327);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Book Collection App";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.searchLbl);
            this.Controls.Add(this.txtSearchTitle);
            this.Controls.Add(this.btnManageAuthors);
            this.Controls.Add(this.btnAddBook);
            this.Controls.Add(this.btnViewAllBooks);
            this.Name = "frmMain";
            this.Text = "Book Collection App";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnViewAllBooks;
        private System.Windows.Forms.Button btnAddBook;
        private System.Windows.Forms.Button btnManageAuthors;
        private System.Windows.Forms.TextBox txtSearchTitle;
        private System.Windows.Forms.Label searchLbl;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label1;
    }
}

