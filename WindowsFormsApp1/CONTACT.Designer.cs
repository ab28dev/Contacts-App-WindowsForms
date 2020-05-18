namespace WindowsFormsApp1
{
    partial class CONTACT
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CONTACT));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.ContactID = new System.Windows.Forms.Label();
            this.IContactID = new System.Windows.Forms.TextBox();
            this.FirstName = new System.Windows.Forms.Label();
            this.IFirstName = new System.Windows.Forms.TextBox();
            this.LastName = new System.Windows.Forms.Label();
            this.ILastName = new System.Windows.Forms.TextBox();
            this.ContactNo = new System.Windows.Forms.Label();
            this.IContactNo = new System.Windows.Forms.TextBox();
            this.Gender = new System.Windows.Forms.Label();
            this.Address = new System.Windows.Forms.Label();
            this.IAddress = new System.Windows.Forms.TextBox();
            this.SGender = new System.Windows.Forms.ComboBox();
            this.dgvContactList = new System.Windows.Forms.DataGridView();
            this.Search = new System.Windows.Forms.Label();
            this.ISearch = new System.Windows.Forms.TextBox();
            this.Exit = new System.Windows.Forms.PictureBox();
            this.btnAdd_onclk = new System.Windows.Forms.Button();
            this.btnDelete_onclk = new System.Windows.Forms.Button();
            this.btnUpdate_onclk = new System.Windows.Forms.Button();
            this.btnClear_onclk = new System.Windows.Forms.Button();
            this.hScrollBar1 = new System.Windows.Forms.HScrollBar();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContactList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Exit)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Cursor = System.Windows.Forms.Cursors.No;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(425, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(156, 31);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "E-Contacts";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // ContactID
            // 
            this.ContactID.AutoSize = true;
            this.ContactID.BackColor = System.Drawing.Color.Transparent;
            this.ContactID.Cursor = System.Windows.Forms.Cursors.No;
            this.ContactID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContactID.Location = new System.Drawing.Point(16, 69);
            this.ContactID.Name = "ContactID";
            this.ContactID.Size = new System.Drawing.Size(112, 25);
            this.ContactID.TabIndex = 1;
            this.ContactID.Text = "Contact ID";
            this.ContactID.Click += new System.EventHandler(this.label1_Click);
            // 
            // IContactID
            // 
            this.IContactID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IContactID.Location = new System.Drawing.Point(189, 63);
            this.IContactID.Name = "IContactID";
            this.IContactID.ReadOnly = true;
            this.IContactID.Size = new System.Drawing.Size(179, 31);
            this.IContactID.TabIndex = 2;
            // 
            // FirstName
            // 
            this.FirstName.AutoSize = true;
            this.FirstName.BackColor = System.Drawing.Color.Transparent;
            this.FirstName.Cursor = System.Windows.Forms.Cursors.No;
            this.FirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstName.Location = new System.Drawing.Point(12, 117);
            this.FirstName.Name = "FirstName";
            this.FirstName.Size = new System.Drawing.Size(116, 25);
            this.FirstName.TabIndex = 1;
            this.FirstName.Text = "First Name";
            this.FirstName.Click += new System.EventHandler(this.label1_Click);
            // 
            // IFirstName
            // 
            this.IFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IFirstName.Location = new System.Drawing.Point(189, 111);
            this.IFirstName.Name = "IFirstName";
            this.IFirstName.Size = new System.Drawing.Size(179, 31);
            this.IFirstName.TabIndex = 2;
            this.IFirstName.Text = "\r\n";
            // 
            // LastName
            // 
            this.LastName.AutoSize = true;
            this.LastName.BackColor = System.Drawing.Color.Transparent;
            this.LastName.Cursor = System.Windows.Forms.Cursors.No;
            this.LastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastName.Location = new System.Drawing.Point(12, 164);
            this.LastName.Name = "LastName";
            this.LastName.Size = new System.Drawing.Size(115, 25);
            this.LastName.TabIndex = 1;
            this.LastName.Text = "Last Name";
            this.LastName.Click += new System.EventHandler(this.label1_Click);
            // 
            // ILastName
            // 
            this.ILastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ILastName.Location = new System.Drawing.Point(189, 158);
            this.ILastName.Name = "ILastName";
            this.ILastName.Size = new System.Drawing.Size(179, 31);
            this.ILastName.TabIndex = 2;
            // 
            // ContactNo
            // 
            this.ContactNo.AutoSize = true;
            this.ContactNo.BackColor = System.Drawing.Color.Transparent;
            this.ContactNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContactNo.Location = new System.Drawing.Point(12, 217);
            this.ContactNo.Name = "ContactNo";
            this.ContactNo.Size = new System.Drawing.Size(125, 25);
            this.ContactNo.TabIndex = 1;
            this.ContactNo.Text = "Contact No.";
            this.ContactNo.Click += new System.EventHandler(this.label1_Click);
            // 
            // IContactNo
            // 
            this.IContactNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IContactNo.Location = new System.Drawing.Point(189, 211);
            this.IContactNo.Name = "IContactNo";
            this.IContactNo.Size = new System.Drawing.Size(179, 31);
            this.IContactNo.TabIndex = 2;
            // 
            // Gender
            // 
            this.Gender.AutoSize = true;
            this.Gender.BackColor = System.Drawing.Color.Transparent;
            this.Gender.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gender.Location = new System.Drawing.Point(12, 374);
            this.Gender.Name = "Gender";
            this.Gender.Size = new System.Drawing.Size(83, 25);
            this.Gender.TabIndex = 1;
            this.Gender.Text = "Gender";
            this.Gender.Click += new System.EventHandler(this.label1_Click);
            // 
            // Address
            // 
            this.Address.AutoSize = true;
            this.Address.BackColor = System.Drawing.Color.Transparent;
            this.Address.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Address.Location = new System.Drawing.Point(12, 264);
            this.Address.Name = "Address";
            this.Address.Size = new System.Drawing.Size(91, 25);
            this.Address.TabIndex = 1;
            this.Address.Text = "Address";
            this.Address.Click += new System.EventHandler(this.label1_Click);
            // 
            // IAddress
            // 
            this.IAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IAddress.Location = new System.Drawing.Point(189, 258);
            this.IAddress.Multiline = true;
            this.IAddress.Name = "IAddress";
            this.IAddress.Size = new System.Drawing.Size(179, 96);
            this.IAddress.TabIndex = 2;
            // 
            // SGender
            // 
            this.SGender.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SGender.FormattingEnabled = true;
            this.SGender.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Others"});
            this.SGender.Location = new System.Drawing.Point(189, 374);
            this.SGender.Name = "SGender";
            this.SGender.Size = new System.Drawing.Size(179, 28);
            this.SGender.TabIndex = 3;
            this.SGender.SelectedIndexChanged += new System.EventHandler(this.SGender_SelectedIndexChanged);
            // 
            // dgvContactList
            // 
            this.dgvContactList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvContactList.Location = new System.Drawing.Point(392, 111);
            this.dgvContactList.Name = "dgvContactList";
            this.dgvContactList.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dgvContactList.Size = new System.Drawing.Size(587, 339);
            this.dgvContactList.StandardTab = true;
            this.dgvContactList.TabIndex = 5;
            this.dgvContactList.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvContactList_RowHeaderMouseClick);
            // 
            // Search
            // 
            this.Search.AutoSize = true;
            this.Search.BackColor = System.Drawing.Color.Transparent;
            this.Search.Cursor = System.Windows.Forms.Cursors.No;
            this.Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search.Location = new System.Drawing.Point(420, 69);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(80, 25);
            this.Search.TabIndex = 1;
            this.Search.Text = "Search";
            this.Search.Click += new System.EventHandler(this.label1_Click);
            // 
            // ISearch
            // 
            this.ISearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ISearch.Location = new System.Drawing.Point(555, 63);
            this.ISearch.Name = "ISearch";
            this.ISearch.Size = new System.Drawing.Size(179, 31);
            this.ISearch.TabIndex = 2;
            // 
            // Exit
            // 
            this.Exit.Image = ((System.Drawing.Image)(resources.GetObject("Exit.Image")));
            this.Exit.Location = new System.Drawing.Point(789, 506);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(44, 43);
            this.Exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Exit.TabIndex = 6;
            this.Exit.TabStop = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // btnAdd_onclk
            // 
            this.btnAdd_onclk.BackColor = System.Drawing.Color.LimeGreen;
            this.btnAdd_onclk.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd_onclk.ForeColor = System.Drawing.Color.White;
            this.btnAdd_onclk.Location = new System.Drawing.Point(189, 506);
            this.btnAdd_onclk.Name = "btnAdd_onclk";
            this.btnAdd_onclk.Size = new System.Drawing.Size(108, 47);
            this.btnAdd_onclk.TabIndex = 7;
            this.btnAdd_onclk.Text = "Add";
            this.btnAdd_onclk.UseVisualStyleBackColor = false;
            this.btnAdd_onclk.Click += new System.EventHandler(this.btnAdd_onclk_Click);
            // 
            // btnDelete_onclk
            // 
            this.btnDelete_onclk.BackColor = System.Drawing.Color.Red;
            this.btnDelete_onclk.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete_onclk.ForeColor = System.Drawing.Color.White;
            this.btnDelete_onclk.Location = new System.Drawing.Point(481, 506);
            this.btnDelete_onclk.Name = "btnDelete_onclk";
            this.btnDelete_onclk.Size = new System.Drawing.Size(108, 47);
            this.btnDelete_onclk.TabIndex = 7;
            this.btnDelete_onclk.Text = "Delete";
            this.btnDelete_onclk.UseVisualStyleBackColor = false;
            this.btnDelete_onclk.Click += new System.EventHandler(this.btnDelete_onclk_Click);
            // 
            // btnUpdate_onclk
            // 
            this.btnUpdate_onclk.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnUpdate_onclk.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate_onclk.ForeColor = System.Drawing.Color.White;
            this.btnUpdate_onclk.Location = new System.Drawing.Point(334, 506);
            this.btnUpdate_onclk.Name = "btnUpdate_onclk";
            this.btnUpdate_onclk.Size = new System.Drawing.Size(108, 47);
            this.btnUpdate_onclk.TabIndex = 7;
            this.btnUpdate_onclk.Text = "Update";
            this.btnUpdate_onclk.UseVisualStyleBackColor = false;
            this.btnUpdate_onclk.Click += new System.EventHandler(this.btnUpdate_onclk_Click);
            // 
            // btnClear_onclk
            // 
            this.btnClear_onclk.BackColor = System.Drawing.Color.Orange;
            this.btnClear_onclk.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear_onclk.ForeColor = System.Drawing.Color.White;
            this.btnClear_onclk.Location = new System.Drawing.Point(626, 506);
            this.btnClear_onclk.Name = "btnClear_onclk";
            this.btnClear_onclk.Size = new System.Drawing.Size(108, 47);
            this.btnClear_onclk.TabIndex = 7;
            this.btnClear_onclk.Text = "Clear";
            this.btnClear_onclk.UseVisualStyleBackColor = false;
            this.btnClear_onclk.Click += new System.EventHandler(this.btnClear_onclk_Click);
            // 
            // hScrollBar1
            // 
            this.hScrollBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.hScrollBar1.Location = new System.Drawing.Point(0, 580);
            this.hScrollBar1.Name = "hScrollBar1";
            this.hScrollBar1.Size = new System.Drawing.Size(989, 17);
            this.hScrollBar1.TabIndex = 9;
            // 
            // CONTACT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(993, 606);
            this.Controls.Add(this.hScrollBar1);
            this.Controls.Add(this.btnClear_onclk);
            this.Controls.Add(this.btnUpdate_onclk);
            this.Controls.Add(this.btnDelete_onclk);
            this.Controls.Add(this.btnAdd_onclk);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.dgvContactList);
            this.Controls.Add(this.SGender);
            this.Controls.Add(this.IContactNo);
            this.Controls.Add(this.IAddress);
            this.Controls.Add(this.ILastName);
            this.Controls.Add(this.IFirstName);
            this.Controls.Add(this.ISearch);
            this.Controls.Add(this.IContactID);
            this.Controls.Add(this.ContactNo);
            this.Controls.Add(this.Gender);
            this.Controls.Add(this.Address);
            this.Controls.Add(this.LastName);
            this.Controls.Add(this.FirstName);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.ContactID);
            this.Controls.Add(this.textBox1);
            this.Name = "CONTACT";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "CONTACT";
            this.Load += new System.EventHandler(this.CONTACT_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvContactList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Exit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label ContactID;
        private System.Windows.Forms.TextBox IContactID;
        private System.Windows.Forms.Label FirstName;
        private System.Windows.Forms.TextBox IFirstName;
        private System.Windows.Forms.Label LastName;
        private System.Windows.Forms.TextBox ILastName;
        private System.Windows.Forms.Label ContactNo;
        private System.Windows.Forms.TextBox IContactNo;
        private System.Windows.Forms.Label Gender;
        private System.Windows.Forms.Label Address;
        private System.Windows.Forms.TextBox IAddress;
        private System.Windows.Forms.ComboBox SGender;
        private System.Windows.Forms.DataGridView dgvContactList;
        private System.Windows.Forms.Label Search;
        private System.Windows.Forms.TextBox ISearch;
        private System.Windows.Forms.PictureBox Exit;
        private System.Windows.Forms.Button btnAdd_onclk;
        private System.Windows.Forms.Button btnDelete_onclk;
        private System.Windows.Forms.Button btnUpdate_onclk;
        private System.Windows.Forms.Button btnClear_onclk;
        private System.Windows.Forms.HScrollBar hScrollBar1;
    }
}

