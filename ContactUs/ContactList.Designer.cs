namespace ContactUs
{
    partial class ContactList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ContactList));
            this.pnlContact_0 = new System.Windows.Forms.Panel();
            this.phoneNumber_0 = new System.Windows.Forms.Label();
            this.emailAddress_0 = new System.Windows.Forms.Label();
            this.lName0 = new System.Windows.Forms.Label();
            this.fName_0 = new System.Windows.Forms.Label();
            this.pb_0 = new System.Windows.Forms.PictureBox();
            this.pnlContactList = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddContact = new System.Windows.Forms.Button();
            this.btnDeleteAllContacts = new System.Windows.Forms.Button();
            this.btnRemoveContacts = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnFunctions = new System.Windows.Forms.Button();
            this.pnlFunctionChecker = new System.Windows.Forms.Panel();
            this.pnlContact_0.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_0)).BeginInit();
            this.pnlContactList.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlContact_0
            // 
            this.pnlContact_0.Controls.Add(this.phoneNumber_0);
            this.pnlContact_0.Controls.Add(this.emailAddress_0);
            this.pnlContact_0.Controls.Add(this.lName0);
            this.pnlContact_0.Controls.Add(this.fName_0);
            this.pnlContact_0.Controls.Add(this.pb_0);
            this.pnlContact_0.Location = new System.Drawing.Point(3, 3);
            this.pnlContact_0.Name = "pnlContact_0";
            this.pnlContact_0.Size = new System.Drawing.Size(580, 149);
            this.pnlContact_0.TabIndex = 0;
            this.pnlContact_0.Click += new System.EventHandler(this.pnlContact0_Click);
            this.pnlContact_0.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlContact0_Paint);
            // 
            // phoneNumber_0
            // 
            this.phoneNumber_0.AutoSize = true;
            this.phoneNumber_0.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneNumber_0.Location = new System.Drawing.Point(151, 97);
            this.phoneNumber_0.Name = "phoneNumber_0";
            this.phoneNumber_0.Size = new System.Drawing.Size(122, 25);
            this.phoneNumber_0.TabIndex = 4;
            this.phoneNumber_0.Text = "01111111111";
            this.phoneNumber_0.Click += new System.EventHandler(this.phoneNumber0_Click);
            // 
            // emailAddress_0
            // 
            this.emailAddress_0.AutoSize = true;
            this.emailAddress_0.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailAddress_0.Location = new System.Drawing.Point(151, 58);
            this.emailAddress_0.Name = "emailAddress_0";
            this.emailAddress_0.Size = new System.Drawing.Size(295, 25);
            this.emailAddress_0.TabIndex = 3;
            this.emailAddress_0.Text = "contactsemailhere@example.com";
            this.emailAddress_0.Click += new System.EventHandler(this.emailAddress0_Click);
            // 
            // lName0
            // 
            this.lName0.AutoSize = true;
            this.lName0.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lName0.Location = new System.Drawing.Point(316, 3);
            this.lName0.Name = "lName0";
            this.lName0.Size = new System.Drawing.Size(167, 45);
            this.lName0.TabIndex = 2;
            this.lName0.Text = "LastName";
            // 
            // fName_0
            // 
            this.fName_0.AutoSize = true;
            this.fName_0.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fName_0.Location = new System.Drawing.Point(148, 3);
            this.fName_0.Name = "fName_0";
            this.fName_0.Size = new System.Drawing.Size(173, 45);
            this.fName_0.TabIndex = 1;
            this.fName_0.Text = "FirstName";
            this.fName_0.Click += new System.EventHandler(this.fName0_Click);
            // 
            // pb_0
            // 
            this.pb_0.Image = ((System.Drawing.Image)(resources.GetObject("pb_0.Image")));
            this.pb_0.Location = new System.Drawing.Point(0, 3);
            this.pb_0.Name = "pb_0";
            this.pb_0.Size = new System.Drawing.Size(142, 140);
            this.pb_0.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_0.TabIndex = 0;
            this.pb_0.TabStop = false;
            this.pb_0.Click += new System.EventHandler(this.pb0_Click);
            // 
            // pnlContactList
            // 
            this.pnlContactList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlContactList.Controls.Add(this.pnlContact_0);
            this.pnlContactList.Location = new System.Drawing.Point(12, 47);
            this.pnlContactList.Name = "pnlContactList";
            this.pnlContactList.Size = new System.Drawing.Size(1210, 652);
            this.pnlContactList.TabIndex = 1;
            this.pnlContactList.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlContactList_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 37);
            this.label1.TabIndex = 2;
            this.label1.Text = "Contacts";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAddContact
            // 
            this.btnAddContact.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddContact.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddContact.Location = new System.Drawing.Point(1080, 9);
            this.btnAddContact.Name = "btnAddContact";
            this.btnAddContact.Size = new System.Drawing.Size(142, 32);
            this.btnAddContact.TabIndex = 3;
            this.btnAddContact.Text = "Add Contact +";
            this.btnAddContact.UseVisualStyleBackColor = true;
            this.btnAddContact.Click += new System.EventHandler(this.btnAddContact_Click);
            // 
            // btnDeleteAllContacts
            // 
            this.btnDeleteAllContacts.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteAllContacts.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteAllContacts.Location = new System.Drawing.Point(885, 68);
            this.btnDeleteAllContacts.Name = "btnDeleteAllContacts";
            this.btnDeleteAllContacts.Size = new System.Drawing.Size(189, 31);
            this.btnDeleteAllContacts.TabIndex = 4;
            this.btnDeleteAllContacts.Text = "Delete all contacts";
            this.btnDeleteAllContacts.UseVisualStyleBackColor = true;
            this.btnDeleteAllContacts.Click += new System.EventHandler(this.btnDeleteAllContacts_Click);
            this.btnDeleteAllContacts.MouseEnter += new System.EventHandler(this.btnDeleteAllContacts_MouseEnter);
            this.btnDeleteAllContacts.MouseLeave += new System.EventHandler(this.btnDeleteAllContacts_MouseLeave);
            // 
            // btnRemoveContacts
            // 
            this.btnRemoveContacts.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemoveContacts.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveContacts.Location = new System.Drawing.Point(885, 39);
            this.btnRemoveContacts.Name = "btnRemoveContacts";
            this.btnRemoveContacts.Size = new System.Drawing.Size(189, 31);
            this.btnRemoveContacts.TabIndex = 5;
            this.btnRemoveContacts.Text = "Remove contacts";
            this.btnRemoveContacts.UseVisualStyleBackColor = true;
            this.btnRemoveContacts.Click += new System.EventHandler(this.btnRemoveContacts_Click);
            this.btnRemoveContacts.MouseEnter += new System.EventHandler(this.btnRemoveContacts_MouseEnter);
            this.btnRemoveContacts.MouseLeave += new System.EventHandler(this.btnRemoveContacts_MouseLeave);
            // 
            // btnLogout
            // 
            this.btnLogout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.Location = new System.Drawing.Point(733, 10);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(146, 31);
            this.btnLogout.TabIndex = 28;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnFunctions
            // 
            this.btnFunctions.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFunctions.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFunctions.Location = new System.Drawing.Point(885, 9);
            this.btnFunctions.Name = "btnFunctions";
            this.btnFunctions.Size = new System.Drawing.Size(189, 32);
            this.btnFunctions.TabIndex = 29;
            this.btnFunctions.Text = "Functions V";
            this.btnFunctions.UseVisualStyleBackColor = true;
            this.btnFunctions.Click += new System.EventHandler(this.btnFunctions_Click);
            this.btnFunctions.MouseEnter += new System.EventHandler(this.btnFunctions_MouseEnter);
            this.btnFunctions.MouseLeave += new System.EventHandler(this.btnFunctions_MouseLeave);
            // 
            // pnlFunctionChecker
            // 
            this.pnlFunctionChecker.Location = new System.Drawing.Point(885, 9);
            this.pnlFunctionChecker.Name = "pnlFunctionChecker";
            this.pnlFunctionChecker.Size = new System.Drawing.Size(189, 90);
            this.pnlFunctionChecker.TabIndex = 30;
            this.pnlFunctionChecker.Enter += new System.EventHandler(this.pnlFunctionChecker_Enter);
            // 
            // ContactList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1234, 711);
            this.Controls.Add(this.btnFunctions);
            this.Controls.Add(this.btnDeleteAllContacts);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnRemoveContacts);
            this.Controls.Add(this.btnAddContact);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pnlContactList);
            this.Controls.Add(this.pnlFunctionChecker);
            this.Name = "ContactList";
            this.Text = "Contact List";
            this.Load += new System.EventHandler(this.ContactList_Load);
            this.MouseEnter += new System.EventHandler(this.ContactList_MouseEnter);
            this.pnlContact_0.ResumeLayout(false);
            this.pnlContact_0.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_0)).EndInit();
            this.pnlContactList.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlContact_0;
        private System.Windows.Forms.Label phoneNumber_0;
        private System.Windows.Forms.Label emailAddress_0;
        private System.Windows.Forms.Label fName_0;
        private System.Windows.Forms.PictureBox pb_0;
        private System.Windows.Forms.Panel pnlContactList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddContact;
        private System.Windows.Forms.Label lName0;
        private System.Windows.Forms.Button btnDeleteAllContacts;
        private System.Windows.Forms.Button btnRemoveContacts;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnFunctions;
        private System.Windows.Forms.Panel pnlFunctionChecker;
    }
}