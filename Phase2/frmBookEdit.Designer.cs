namespace Phase2
{
    partial class frmBookEdit
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
            this.titleLbl = new System.Windows.Forms.Label();
            this.authorLbl = new System.Windows.Forms.Label();
            this.genreLbl = new System.Windows.Forms.Label();
            this.isbnLbl = new System.Windows.Forms.Label();
            this.publicationYearLbl = new System.Windows.Forms.Label();
            this.physicalBookFieldslbl = new System.Windows.Forms.Label();
            this.shelflocationLbl = new System.Windows.Forms.Label();
            this.conditionLbl = new System.Windows.Forms.Label();
            this.isHardcoverLbl = new System.Windows.Forms.Label();
            this.eBookFieldsLbl = new System.Windows.Forms.Label();
            this.fileFormatLbl = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.filePathSlashLinkLbl = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.cboAuthor = new System.Windows.Forms.ComboBox();
            this.txtGenre = new System.Windows.Forms.TextBox();
            this.txtISBN = new System.Windows.Forms.TextBox();
            this.txtPublicationYear = new System.Windows.Forms.TextBox();
            this.txtShelfLocation = new System.Windows.Forms.TextBox();
            this.txtCondition = new System.Windows.Forms.TextBox();
            this.isReadLbl = new System.Windows.Forms.Label();
            this.chkIsRead = new System.Windows.Forms.CheckBox();
            this.chkIsHardcover = new System.Windows.Forms.CheckBox();
            this.txtFileFormat = new System.Windows.Forms.TextBox();
            this.txtFileSizeMB = new System.Windows.Forms.TextBox();
            this.txtFilePathOrLink = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // titleLbl
            // 
            this.titleLbl.AutoSize = true;
            this.titleLbl.Location = new System.Drawing.Point(86, 20);
            this.titleLbl.Name = "titleLbl";
            this.titleLbl.Size = new System.Drawing.Size(30, 13);
            this.titleLbl.TabIndex = 0;
            this.titleLbl.Text = "Title:";
            // 
            // authorLbl
            // 
            this.authorLbl.AutoSize = true;
            this.authorLbl.Location = new System.Drawing.Point(86, 51);
            this.authorLbl.Name = "authorLbl";
            this.authorLbl.Size = new System.Drawing.Size(41, 13);
            this.authorLbl.TabIndex = 1;
            this.authorLbl.Text = "Author:";
            // 
            // genreLbl
            // 
            this.genreLbl.AutoSize = true;
            this.genreLbl.Location = new System.Drawing.Point(86, 92);
            this.genreLbl.Name = "genreLbl";
            this.genreLbl.Size = new System.Drawing.Size(39, 13);
            this.genreLbl.TabIndex = 2;
            this.genreLbl.Text = "Genre:";
            // 
            // isbnLbl
            // 
            this.isbnLbl.AutoSize = true;
            this.isbnLbl.Location = new System.Drawing.Point(86, 125);
            this.isbnLbl.Name = "isbnLbl";
            this.isbnLbl.Size = new System.Drawing.Size(35, 13);
            this.isbnLbl.TabIndex = 3;
            this.isbnLbl.Text = "ISBN:";
            // 
            // publicationYearLbl
            // 
            this.publicationYearLbl.AutoSize = true;
            this.publicationYearLbl.Location = new System.Drawing.Point(86, 154);
            this.publicationYearLbl.Name = "publicationYearLbl";
            this.publicationYearLbl.Size = new System.Drawing.Size(87, 13);
            this.publicationYearLbl.TabIndex = 4;
            this.publicationYearLbl.Text = "Publication Year:";
            // 
            // physicalBookFieldslbl
            // 
            this.physicalBookFieldslbl.AutoSize = true;
            this.physicalBookFieldslbl.Location = new System.Drawing.Point(86, 200);
            this.physicalBookFieldslbl.Name = "physicalBookFieldslbl";
            this.physicalBookFieldslbl.Size = new System.Drawing.Size(107, 13);
            this.physicalBookFieldslbl.TabIndex = 5;
            this.physicalBookFieldslbl.Text = "Physical Book Fields:";
            // 
            // shelflocationLbl
            // 
            this.shelflocationLbl.AutoSize = true;
            this.shelflocationLbl.Location = new System.Drawing.Point(86, 223);
            this.shelflocationLbl.Name = "shelflocationLbl";
            this.shelflocationLbl.Size = new System.Drawing.Size(78, 13);
            this.shelflocationLbl.TabIndex = 6;
            this.shelflocationLbl.Text = "Shelf Location:";
            // 
            // conditionLbl
            // 
            this.conditionLbl.AutoSize = true;
            this.conditionLbl.Location = new System.Drawing.Point(86, 250);
            this.conditionLbl.Name = "conditionLbl";
            this.conditionLbl.Size = new System.Drawing.Size(54, 13);
            this.conditionLbl.TabIndex = 7;
            this.conditionLbl.Text = "Condition:";
            // 
            // isHardcoverLbl
            // 
            this.isHardcoverLbl.AutoSize = true;
            this.isHardcoverLbl.Location = new System.Drawing.Point(86, 278);
            this.isHardcoverLbl.Name = "isHardcoverLbl";
            this.isHardcoverLbl.Size = new System.Drawing.Size(68, 13);
            this.isHardcoverLbl.TabIndex = 8;
            this.isHardcoverLbl.Text = "Is Hardcover";
            // 
            // eBookFieldsLbl
            // 
            this.eBookFieldsLbl.AutoSize = true;
            this.eBookFieldsLbl.Location = new System.Drawing.Point(86, 305);
            this.eBookFieldsLbl.Name = "eBookFieldsLbl";
            this.eBookFieldsLbl.Size = new System.Drawing.Size(72, 13);
            this.eBookFieldsLbl.TabIndex = 9;
            this.eBookFieldsLbl.Text = "E-Book Fields";
            // 
            // fileFormatLbl
            // 
            this.fileFormatLbl.AutoSize = true;
            this.fileFormatLbl.Location = new System.Drawing.Point(86, 331);
            this.fileFormatLbl.Name = "fileFormatLbl";
            this.fileFormatLbl.Size = new System.Drawing.Size(61, 13);
            this.fileFormatLbl.TabIndex = 10;
            this.fileFormatLbl.Text = "File Format:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(86, 359);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(49, 13);
            this.label12.TabIndex = 11;
            this.label12.Text = "File Size:";
            // 
            // filePathSlashLinkLbl
            // 
            this.filePathSlashLinkLbl.AutoSize = true;
            this.filePathSlashLinkLbl.Location = new System.Drawing.Point(86, 387);
            this.filePathSlashLinkLbl.Name = "filePathSlashLinkLbl";
            this.filePathSlashLinkLbl.Size = new System.Drawing.Size(78, 13);
            this.filePathSlashLinkLbl.TabIndex = 12;
            this.filePathSlashLinkLbl.Text = "File Path/Links";
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(123, 20);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(100, 20);
            this.txtTitle.TabIndex = 13;
            // 
            // cboAuthor
            // 
            this.cboAuthor.FormattingEnabled = true;
            this.cboAuthor.Location = new System.Drawing.Point(134, 51);
            this.cboAuthor.Name = "cboAuthor";
            this.cboAuthor.Size = new System.Drawing.Size(121, 21);
            this.cboAuthor.TabIndex = 14;
            // 
            // txtGenre
            // 
            this.txtGenre.Location = new System.Drawing.Point(131, 89);
            this.txtGenre.Name = "txtGenre";
            this.txtGenre.Size = new System.Drawing.Size(100, 20);
            this.txtGenre.TabIndex = 15;
            // 
            // txtISBN
            // 
            this.txtISBN.Location = new System.Drawing.Point(128, 125);
            this.txtISBN.Name = "txtISBN";
            this.txtISBN.Size = new System.Drawing.Size(100, 20);
            this.txtISBN.TabIndex = 16;
            // 
            // txtPublicationYear
            // 
            this.txtPublicationYear.Location = new System.Drawing.Point(179, 151);
            this.txtPublicationYear.Name = "txtPublicationYear";
            this.txtPublicationYear.Size = new System.Drawing.Size(100, 20);
            this.txtPublicationYear.TabIndex = 17;
            // 
            // txtShelfLocation
            // 
            this.txtShelfLocation.Location = new System.Drawing.Point(170, 223);
            this.txtShelfLocation.Name = "txtShelfLocation";
            this.txtShelfLocation.Size = new System.Drawing.Size(100, 20);
            this.txtShelfLocation.TabIndex = 18;
            // 
            // txtCondition
            // 
            this.txtCondition.Location = new System.Drawing.Point(146, 247);
            this.txtCondition.Name = "txtCondition";
            this.txtCondition.Size = new System.Drawing.Size(100, 20);
            this.txtCondition.TabIndex = 19;
            // 
            // isReadLbl
            // 
            this.isReadLbl.AutoSize = true;
            this.isReadLbl.Location = new System.Drawing.Point(90, 178);
            this.isReadLbl.Name = "isReadLbl";
            this.isReadLbl.Size = new System.Drawing.Size(44, 13);
            this.isReadLbl.TabIndex = 20;
            this.isReadLbl.Text = "Is Read";
            // 
            // chkIsRead
            // 
            this.chkIsRead.AutoSize = true;
            this.chkIsRead.Location = new System.Drawing.Point(140, 177);
            this.chkIsRead.Name = "chkIsRead";
            this.chkIsRead.Size = new System.Drawing.Size(63, 17);
            this.chkIsRead.TabIndex = 21;
            this.chkIsRead.Text = "Yes/No";
            this.chkIsRead.UseVisualStyleBackColor = true;
            // 
            // chkIsHardcover
            // 
            this.chkIsHardcover.AutoSize = true;
            this.chkIsHardcover.Location = new System.Drawing.Point(160, 277);
            this.chkIsHardcover.Name = "chkIsHardcover";
            this.chkIsHardcover.Size = new System.Drawing.Size(63, 17);
            this.chkIsHardcover.TabIndex = 22;
            this.chkIsHardcover.Text = "Yes/No";
            this.chkIsHardcover.UseVisualStyleBackColor = true;
            // 
            // txtFileFormat
            // 
            this.txtFileFormat.Location = new System.Drawing.Point(153, 328);
            this.txtFileFormat.Name = "txtFileFormat";
            this.txtFileFormat.Size = new System.Drawing.Size(100, 20);
            this.txtFileFormat.TabIndex = 23;
            // 
            // txtFileSizeMB
            // 
            this.txtFileSizeMB.Location = new System.Drawing.Point(131, 356);
            this.txtFileSizeMB.Name = "txtFileSizeMB";
            this.txtFileSizeMB.Size = new System.Drawing.Size(100, 20);
            this.txtFileSizeMB.TabIndex = 24;
            // 
            // txtFilePathOrLink
            // 
            this.txtFilePathOrLink.Location = new System.Drawing.Point(170, 387);
            this.txtFilePathOrLink.Name = "txtFilePathOrLink";
            this.txtFilePathOrLink.Size = new System.Drawing.Size(100, 20);
            this.txtFilePathOrLink.TabIndex = 25;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(373, 385);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 26;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(454, 385);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 27;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // frmBookEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 450);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtFilePathOrLink);
            this.Controls.Add(this.txtFileSizeMB);
            this.Controls.Add(this.txtFileFormat);
            this.Controls.Add(this.chkIsHardcover);
            this.Controls.Add(this.chkIsRead);
            this.Controls.Add(this.isReadLbl);
            this.Controls.Add(this.txtCondition);
            this.Controls.Add(this.txtShelfLocation);
            this.Controls.Add(this.txtPublicationYear);
            this.Controls.Add(this.txtISBN);
            this.Controls.Add(this.txtGenre);
            this.Controls.Add(this.cboAuthor);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.filePathSlashLinkLbl);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.fileFormatLbl);
            this.Controls.Add(this.eBookFieldsLbl);
            this.Controls.Add(this.isHardcoverLbl);
            this.Controls.Add(this.conditionLbl);
            this.Controls.Add(this.shelflocationLbl);
            this.Controls.Add(this.physicalBookFieldslbl);
            this.Controls.Add(this.publicationYearLbl);
            this.Controls.Add(this.isbnLbl);
            this.Controls.Add(this.genreLbl);
            this.Controls.Add(this.authorLbl);
            this.Controls.Add(this.titleLbl);
            this.Name = "frmBookEdit";
            this.Text = "Add/Edit Book";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLbl;
        private System.Windows.Forms.Label authorLbl;
        private System.Windows.Forms.Label genreLbl;
        private System.Windows.Forms.Label isbnLbl;
        private System.Windows.Forms.Label publicationYearLbl;
        private System.Windows.Forms.Label physicalBookFieldslbl;
        private System.Windows.Forms.Label shelflocationLbl;
        private System.Windows.Forms.Label conditionLbl;
        private System.Windows.Forms.Label isHardcoverLbl;
        private System.Windows.Forms.Label eBookFieldsLbl;
        private System.Windows.Forms.Label fileFormatLbl;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label filePathSlashLinkLbl;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.ComboBox cboAuthor;
        private System.Windows.Forms.TextBox txtGenre;
        private System.Windows.Forms.TextBox txtISBN;
        private System.Windows.Forms.TextBox txtPublicationYear;
        private System.Windows.Forms.TextBox txtShelfLocation;
        private System.Windows.Forms.TextBox txtCondition;
        private System.Windows.Forms.Label isReadLbl;
        private System.Windows.Forms.CheckBox chkIsRead;
        private System.Windows.Forms.CheckBox chkIsHardcover;
        private System.Windows.Forms.TextBox txtFileFormat;
        private System.Windows.Forms.TextBox txtFileSizeMB;
        private System.Windows.Forms.TextBox txtFilePathOrLink;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
    }
}