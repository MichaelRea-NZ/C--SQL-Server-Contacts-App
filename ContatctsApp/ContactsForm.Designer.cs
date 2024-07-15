namespace ContactsApp
{
    partial class NewContactForm
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
            this.lblContact = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelAddress = new System.Windows.Forms.Label();
            this.labelTown = new System.Windows.Forms.Label();
            this.labelPhone = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxPhone = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.comboBoxTowns = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dataGridViewContacts = new System.Windows.Forms.DataGridView();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblSearch = new System.Windows.Forms.Label();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.labelID = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewContacts)).BeginInit();
            this.SuspendLayout();
            // 
            // lblContact
            // 
            this.lblContact.AutoSize = true;
            this.lblContact.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContact.Location = new System.Drawing.Point(408, 9);
            this.lblContact.Name = "lblContact";
            this.lblContact.Size = new System.Drawing.Size(152, 37);
            this.lblContact.TabIndex = 0;
            this.lblContact.Text = "Contacts";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(15, 100);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(55, 20);
            this.labelName.TabIndex = 1;
            this.labelName.Text = "Name";
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAddress.Location = new System.Drawing.Point(15, 250);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(130, 20);
            this.labelAddress.TabIndex = 2;
            this.labelAddress.Text = "Street Address";
            // 
            // labelTown
            // 
            this.labelTown.AutoSize = true;
            this.labelTown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTown.Location = new System.Drawing.Point(15, 300);
            this.labelTown.Name = "labelTown";
            this.labelTown.Size = new System.Drawing.Size(51, 20);
            this.labelTown.TabIndex = 3;
            this.labelTown.Text = "Town";
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPhone.Location = new System.Drawing.Point(15, 150);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(127, 20);
            this.labelPhone.TabIndex = 4;
            this.labelPhone.Text = "Phone Number";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmail.Location = new System.Drawing.Point(15, 200);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(53, 20);
            this.labelEmail.TabIndex = 5;
            this.labelEmail.Text = "Email";
            // 
            // textBoxName
            // 
            this.textBoxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxName.Location = new System.Drawing.Point(180, 100);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(184, 26);
            this.textBoxName.TabIndex = 6;
            // this.textBoxName.TextChanged += new System.EventHandler(this.textBoxName_TextChanged);
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPhone.Location = new System.Drawing.Point(180, 150);
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.Size = new System.Drawing.Size(184, 26);
            this.textBoxPhone.TabIndex = 7;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEmail.Location = new System.Drawing.Point(180, 200);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(184, 26);
            this.textBoxEmail.TabIndex = 8;
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAddress.Location = new System.Drawing.Point(180, 250);
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(184, 26);
            this.textBoxAddress.TabIndex = 9;
            // 
            // comboBoxTowns
            // 
            this.comboBoxTowns.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxTowns.FormattingEnabled = true;
            this.comboBoxTowns.Items.AddRange(new object[] {
            "Christchurch",
            "",
            "Rolleston\t",
            "",
            "Timaru\t",
            "",
            "Ashburton\t",
            "",
            "Rangiora\t",
            "",
            "Kaiapoi\t",
            "",
            "Lincoln\t",
            "",
            "Prebbleton"});
            this.comboBoxTowns.Location = new System.Drawing.Point(180, 300);
            this.comboBoxTowns.Name = "comboBoxTowns";
            this.comboBoxTowns.Size = new System.Drawing.Size(184, 28);
            this.comboBoxTowns.TabIndex = 10;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(115, 428);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(160, 45);
            this.btnAdd.TabIndex = 11;
            this.btnAdd.Text = "Add Contact";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dataGridViewContacts
            // 
            this.dataGridViewContacts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewContacts.Location = new System.Drawing.Point(435, 161);
            this.dataGridViewContacts.Name = "dataGridViewContacts";
            this.dataGridViewContacts.Size = new System.Drawing.Size(662, 466);
            this.dataGridViewContacts.TabIndex = 12;
            this.dataGridViewContacts.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewContacts_RowHeaderMouseClick);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(115, 498);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(160, 45);
            this.btnUpdate.TabIndex = 13;
            this.btnUpdate.Text = "Update Contact";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(115, 568);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(160, 45);
            this.btnDelete.TabIndex = 14;
            this.btnDelete.Text = "Delete Contact";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.Location = new System.Drawing.Point(480, 105);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(149, 20);
            this.lblSearch.TabIndex = 15;
            this.lblSearch.Text = "Search Contatcts";
            this.lblSearch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSearch.Location = new System.Drawing.Point(667, 102);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(184, 26);
            this.textBoxSearch.TabIndex = 16;
            this.textBoxSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // textBoxID
            // 
            this.textBoxID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxID.Location = new System.Drawing.Point(180, 350);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.ReadOnly = true;
            this.textBoxID.Size = new System.Drawing.Size(184, 26);
            this.textBoxID.TabIndex = 18;
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelID.Location = new System.Drawing.Point(15, 350);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(104, 20);
            this.labelID.TabIndex = 17;
            this.labelID.Text = "Selected ID";
            // 
            // NewContactForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1198, 657);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.labelID);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.dataGridViewContacts);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.comboBoxTowns);
            this.Controls.Add(this.textBoxAddress);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.textBoxPhone);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.labelPhone);
            this.Controls.Add(this.labelTown);
            this.Controls.Add(this.labelAddress);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.lblContact);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "NewContactForm";
            this.Text = "Contacts";
            this.Load += new System.EventHandler(this.NewContactForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewContacts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblContact;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.Label labelTown;
        private System.Windows.Forms.Label labelPhone;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxPhone;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.TextBox textBoxAddress;
        private System.Windows.Forms.ComboBox comboBoxTowns;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dataGridViewContacts;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.Label labelID;
    }
}

