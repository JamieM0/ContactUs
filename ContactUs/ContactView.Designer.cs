namespace ContactUs
{
    partial class ContactView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ContactView));
            this.lbFName = new System.Windows.Forms.Label();
            this.pbContactPicture = new System.Windows.Forms.PictureBox();
            this.txtFName = new System.Windows.Forms.TextBox();
            this.lbLName = new System.Windows.Forms.Label();
            this.txtLName = new System.Windows.Forms.TextBox();
            this.lbEmail = new System.Windows.Forms.Label();
            this.btnChangeContactImage = new System.Windows.Forms.Button();
            this.lbEmailNumber = new System.Windows.Forms.Label();
            this.rtxtEmailAddresses = new System.Windows.Forms.RichTextBox();
            this.lbPhoneNumbersNumbers = new System.Windows.Forms.Label();
            this.lbPhoneNumbers = new System.Windows.Forms.Label();
            this.rtxtPhoneNumbers = new System.Windows.Forms.RichTextBox();
            this.pbSendMail = new System.Windows.Forms.PictureBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.lbAddress = new System.Windows.Forms.Label();
            this.lbAddressInfo = new System.Windows.Forms.Label();
            this.rtxtAddress = new System.Windows.Forms.RichTextBox();
            this.lbBirthdate = new System.Windows.Forms.Label();
            this.dtpBirthdate = new System.Windows.Forms.DateTimePicker();
            this.dtpOtherDate = new System.Windows.Forms.DateTimePicker();
            this.lbOtherDate = new System.Windows.Forms.Label();
            this.lbOtherDateLabel = new System.Windows.Forms.Label();
            this.txtOtherDate = new System.Windows.Forms.TextBox();
            this.lbNotes = new System.Windows.Forms.Label();
            this.rtxtNotes = new System.Windows.Forms.RichTextBox();
            this.lbTitle = new System.Windows.Forms.Label();
            this.btnSaveOnly = new System.Windows.Forms.Button();
            this.btnSaveAndReturn = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbContactPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSendMail)).BeginInit();
            this.SuspendLayout();
            // 
            // lbFName
            // 
            this.lbFName.AutoSize = true;
            this.lbFName.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFName.Location = new System.Drawing.Point(12, 185);
            this.lbFName.Name = "lbFName";
            this.lbFName.Size = new System.Drawing.Size(181, 45);
            this.lbFName.TabIndex = 0;
            this.lbFName.Text = "First Name:";
            this.lbFName.Click += new System.EventHandler(this.lbFName_Click);
            // 
            // pbContactPicture
            // 
            this.pbContactPicture.Image = ((System.Drawing.Image)(resources.GetObject("pbContactPicture.Image")));
            this.pbContactPicture.Location = new System.Drawing.Point(20, 13);
            this.pbContactPicture.Name = "pbContactPicture";
            this.pbContactPicture.Size = new System.Drawing.Size(166, 150);
            this.pbContactPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbContactPicture.TabIndex = 1;
            this.pbContactPicture.TabStop = false;
            // 
            // txtFName
            // 
            this.txtFName.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFName.Location = new System.Drawing.Point(211, 188);
            this.txtFName.Name = "txtFName";
            this.txtFName.Size = new System.Drawing.Size(322, 43);
            this.txtFName.TabIndex = 1;
            this.txtFName.TextChanged += new System.EventHandler(this.txtFName_TextChanged);
            this.txtFName.Leave += new System.EventHandler(this.txtFName_Leave);
            // 
            // lbLName
            // 
            this.lbLName.AutoSize = true;
            this.lbLName.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLName.Location = new System.Drawing.Point(12, 265);
            this.lbLName.Name = "lbLName";
            this.lbLName.Size = new System.Drawing.Size(177, 45);
            this.lbLName.TabIndex = 3;
            this.lbLName.Text = "Last Name:";
            this.lbLName.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtLName
            // 
            this.txtLName.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLName.Location = new System.Drawing.Point(211, 268);
            this.txtLName.Name = "txtLName";
            this.txtLName.Size = new System.Drawing.Size(322, 43);
            this.txtLName.TabIndex = 2;
            this.txtLName.TextChanged += new System.EventHandler(this.txtLName_TextChanged);
            this.txtLName.Leave += new System.EventHandler(this.txtLName_Leave);
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEmail.Location = new System.Drawing.Point(12, 365);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(278, 45);
            this.lbEmail.TabIndex = 5;
            this.lbEmail.Text = "Email Address(es):";
            // 
            // btnChangeContactImage
            // 
            this.btnChangeContactImage.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangeContactImage.Location = new System.Drawing.Point(211, 123);
            this.btnChangeContactImage.Name = "btnChangeContactImage";
            this.btnChangeContactImage.Size = new System.Drawing.Size(322, 40);
            this.btnChangeContactImage.TabIndex = 10;
            this.btnChangeContactImage.Text = "Change contact image";
            this.btnChangeContactImage.UseVisualStyleBackColor = true;
            this.btnChangeContactImage.Click += new System.EventHandler(this.btnChangeContactImage_Click);
            // 
            // lbEmailNumber
            // 
            this.lbEmailNumber.AutoSize = true;
            this.lbEmailNumber.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEmailNumber.Location = new System.Drawing.Point(15, 410);
            this.lbEmailNumber.Name = "lbEmailNumber";
            this.lbEmailNumber.Size = new System.Drawing.Size(231, 90);
            this.lbEmailNumber.TabIndex = 8;
            this.lbEmailNumber.Text = "One email per line! \r\nThe email button will \r\nemail the first one only.";
            // 
            // rtxtEmailAddresses
            // 
            this.rtxtEmailAddresses.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxtEmailAddresses.Location = new System.Drawing.Point(288, 365);
            this.rtxtEmailAddresses.Name = "rtxtEmailAddresses";
            this.rtxtEmailAddresses.Size = new System.Drawing.Size(423, 135);
            this.rtxtEmailAddresses.TabIndex = 3;
            this.rtxtEmailAddresses.Text = "";
            this.rtxtEmailAddresses.Leave += new System.EventHandler(this.rtxtEmailAddresses_Leave);
            // 
            // lbPhoneNumbersNumbers
            // 
            this.lbPhoneNumbersNumbers.AutoSize = true;
            this.lbPhoneNumbersNumbers.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPhoneNumbersNumbers.Location = new System.Drawing.Point(15, 576);
            this.lbPhoneNumbersNumbers.Name = "lbPhoneNumbersNumbers";
            this.lbPhoneNumbersNumbers.Size = new System.Drawing.Size(217, 30);
            this.lbPhoneNumbersNumbers.TabIndex = 11;
            this.lbPhoneNumbersNumbers.Text = "One number per line! \r\n";
            // 
            // lbPhoneNumbers
            // 
            this.lbPhoneNumbers.AutoSize = true;
            this.lbPhoneNumbers.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPhoneNumbers.Location = new System.Drawing.Point(12, 531);
            this.lbPhoneNumbers.Name = "lbPhoneNumbers";
            this.lbPhoneNumbers.Size = new System.Drawing.Size(277, 45);
            this.lbPhoneNumbers.TabIndex = 10;
            this.lbPhoneNumbers.Text = "Phone Number(s):";
            // 
            // rtxtPhoneNumbers
            // 
            this.rtxtPhoneNumbers.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxtPhoneNumbers.Location = new System.Drawing.Point(288, 531);
            this.rtxtPhoneNumbers.Name = "rtxtPhoneNumbers";
            this.rtxtPhoneNumbers.Size = new System.Drawing.Size(282, 82);
            this.rtxtPhoneNumbers.TabIndex = 4;
            this.rtxtPhoneNumbers.Text = "";
            this.rtxtPhoneNumbers.TextChanged += new System.EventHandler(this.rtxtPhoneNumbers_TextChanged);
            this.rtxtPhoneNumbers.Leave += new System.EventHandler(this.rtxtPhoneNumbers_Leave);
            // 
            // pbSendMail
            // 
            this.pbSendMail.Image = ((System.Drawing.Image)(resources.GetObject("pbSendMail.Image")));
            this.pbSendMail.Location = new System.Drawing.Point(717, 365);
            this.pbSendMail.Name = "pbSendMail";
            this.pbSendMail.Size = new System.Drawing.Size(49, 135);
            this.pbSendMail.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbSendMail.TabIndex = 13;
            this.pbSendMail.TabStop = false;
            this.pbSendMail.Click += new System.EventHandler(this.pbSendMail_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(1052, 13);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(170, 56);
            this.btnExit.TabIndex = 13;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lbAddress
            // 
            this.lbAddress.AutoSize = true;
            this.lbAddress.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAddress.Location = new System.Drawing.Point(576, 161);
            this.lbAddress.Name = "lbAddress";
            this.lbAddress.Size = new System.Drawing.Size(142, 45);
            this.lbAddress.TabIndex = 15;
            this.lbAddress.Text = "Address:";
            // 
            // lbAddressInfo
            // 
            this.lbAddressInfo.AutoSize = true;
            this.lbAddressInfo.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAddressInfo.Location = new System.Drawing.Point(579, 206);
            this.lbAddressInfo.Name = "lbAddressInfo";
            this.lbAddressInfo.Size = new System.Drawing.Size(145, 60);
            this.lbAddressInfo.TabIndex = 16;
            this.lbAddressInfo.Text = "Use your own \r\nformatting!";
            // 
            // rtxtAddress
            // 
            this.rtxtAddress.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxtAddress.Location = new System.Drawing.Point(739, 161);
            this.rtxtAddress.Name = "rtxtAddress";
            this.rtxtAddress.Size = new System.Drawing.Size(483, 150);
            this.rtxtAddress.TabIndex = 8;
            this.rtxtAddress.Text = "";
            // 
            // lbBirthdate
            // 
            this.lbBirthdate.AutoSize = true;
            this.lbBirthdate.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBirthdate.Location = new System.Drawing.Point(12, 643);
            this.lbBirthdate.Name = "lbBirthdate";
            this.lbBirthdate.Size = new System.Drawing.Size(156, 45);
            this.lbBirthdate.TabIndex = 18;
            this.lbBirthdate.Text = "Birthdate:";
            // 
            // dtpBirthdate
            // 
            this.dtpBirthdate.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpBirthdate.Location = new System.Drawing.Point(174, 645);
            this.dtpBirthdate.Name = "dtpBirthdate";
            this.dtpBirthdate.Size = new System.Drawing.Size(276, 43);
            this.dtpBirthdate.TabIndex = 5;
            // 
            // dtpOtherDate
            // 
            this.dtpOtherDate.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpOtherDate.Location = new System.Drawing.Point(771, 576);
            this.dtpOtherDate.Name = "dtpOtherDate";
            this.dtpOtherDate.Size = new System.Drawing.Size(276, 43);
            this.dtpOtherDate.TabIndex = 6;
            // 
            // lbOtherDate
            // 
            this.lbOtherDate.AutoSize = true;
            this.lbOtherDate.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbOtherDate.Location = new System.Drawing.Point(576, 576);
            this.lbOtherDate.Name = "lbOtherDate";
            this.lbOtherDate.Size = new System.Drawing.Size(180, 45);
            this.lbOtherDate.TabIndex = 20;
            this.lbOtherDate.Text = "Other date:";
            // 
            // lbOtherDateLabel
            // 
            this.lbOtherDateLabel.AutoSize = true;
            this.lbOtherDateLabel.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbOtherDateLabel.Location = new System.Drawing.Point(508, 643);
            this.lbOtherDateLabel.Name = "lbOtherDateLabel";
            this.lbOtherDateLabel.Size = new System.Drawing.Size(257, 45);
            this.lbOtherDateLabel.TabIndex = 22;
            this.lbOtherDateLabel.Text = "Other date label:";
            // 
            // txtOtherDate
            // 
            this.txtOtherDate.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOtherDate.Location = new System.Drawing.Point(771, 649);
            this.txtOtherDate.Name = "txtOtherDate";
            this.txtOtherDate.Size = new System.Drawing.Size(276, 43);
            this.txtOtherDate.TabIndex = 7;
            // 
            // lbNotes
            // 
            this.lbNotes.AutoSize = true;
            this.lbNotes.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNotes.Location = new System.Drawing.Point(803, 347);
            this.lbNotes.Name = "lbNotes";
            this.lbNotes.Size = new System.Drawing.Size(112, 45);
            this.lbNotes.TabIndex = 24;
            this.lbNotes.Text = "Notes:";
            // 
            // rtxtNotes
            // 
            this.rtxtNotes.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxtNotes.Location = new System.Drawing.Point(811, 401);
            this.rtxtNotes.Name = "rtxtNotes";
            this.rtxtNotes.Size = new System.Drawing.Size(411, 142);
            this.rtxtNotes.TabIndex = 9;
            this.rtxtNotes.Text = "";
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.Location = new System.Drawing.Point(200, 13);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(458, 65);
            this.lbTitle.TabIndex = 26;
            this.lbTitle.Text = "Contact Name Here!";
            // 
            // btnSaveOnly
            // 
            this.btnSaveOnly.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveOnly.Location = new System.Drawing.Point(819, 13);
            this.btnSaveOnly.Name = "btnSaveOnly";
            this.btnSaveOnly.Size = new System.Drawing.Size(170, 56);
            this.btnSaveOnly.TabIndex = 11;
            this.btnSaveOnly.Text = "Save";
            this.btnSaveOnly.UseVisualStyleBackColor = true;
            // 
            // btnSaveAndReturn
            // 
            this.btnSaveAndReturn.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveAndReturn.Location = new System.Drawing.Point(819, 86);
            this.btnSaveAndReturn.Name = "btnSaveAndReturn";
            this.btnSaveAndReturn.Size = new System.Drawing.Size(403, 56);
            this.btnSaveAndReturn.TabIndex = 12;
            this.btnSaveAndReturn.Text = "Save and Return to Main Menu";
            this.btnSaveAndReturn.UseVisualStyleBackColor = true;
            // 
            // btnLogout
            // 
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.Location = new System.Drawing.Point(1083, 636);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(139, 56);
            this.btnLogout.TabIndex = 27;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // ContactView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1234, 711);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnSaveAndReturn);
            this.Controls.Add(this.btnSaveOnly);
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.rtxtNotes);
            this.Controls.Add(this.lbNotes);
            this.Controls.Add(this.txtOtherDate);
            this.Controls.Add(this.lbOtherDateLabel);
            this.Controls.Add(this.dtpOtherDate);
            this.Controls.Add(this.lbOtherDate);
            this.Controls.Add(this.dtpBirthdate);
            this.Controls.Add(this.lbBirthdate);
            this.Controls.Add(this.rtxtAddress);
            this.Controls.Add(this.lbAddressInfo);
            this.Controls.Add(this.lbAddress);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.pbSendMail);
            this.Controls.Add(this.rtxtPhoneNumbers);
            this.Controls.Add(this.lbPhoneNumbersNumbers);
            this.Controls.Add(this.lbPhoneNumbers);
            this.Controls.Add(this.rtxtEmailAddresses);
            this.Controls.Add(this.lbEmailNumber);
            this.Controls.Add(this.btnChangeContactImage);
            this.Controls.Add(this.lbEmail);
            this.Controls.Add(this.txtLName);
            this.Controls.Add(this.lbLName);
            this.Controls.Add(this.txtFName);
            this.Controls.Add(this.pbContactPicture);
            this.Controls.Add(this.lbFName);
            this.Name = "ContactView";
            this.Text = "Contact";
            this.Load += new System.EventHandler(this.ContactView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbContactPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSendMail)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbFName;
        private System.Windows.Forms.PictureBox pbContactPicture;
        private System.Windows.Forms.TextBox txtFName;
        private System.Windows.Forms.Label lbLName;
        private System.Windows.Forms.TextBox txtLName;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.Button btnChangeContactImage;
        private System.Windows.Forms.Label lbEmailNumber;
        private System.Windows.Forms.RichTextBox rtxtEmailAddresses;
        private System.Windows.Forms.Label lbPhoneNumbersNumbers;
        private System.Windows.Forms.Label lbPhoneNumbers;
        private System.Windows.Forms.RichTextBox rtxtPhoneNumbers;
        private System.Windows.Forms.PictureBox pbSendMail;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lbAddress;
        private System.Windows.Forms.Label lbAddressInfo;
        private System.Windows.Forms.RichTextBox rtxtAddress;
        private System.Windows.Forms.Label lbBirthdate;
        private System.Windows.Forms.DateTimePicker dtpBirthdate;
        private System.Windows.Forms.DateTimePicker dtpOtherDate;
        private System.Windows.Forms.Label lbOtherDate;
        private System.Windows.Forms.Label lbOtherDateLabel;
        private System.Windows.Forms.TextBox txtOtherDate;
        private System.Windows.Forms.Label lbNotes;
        private System.Windows.Forms.RichTextBox rtxtNotes;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Button btnSaveOnly;
        private System.Windows.Forms.Button btnSaveAndReturn;
        private System.Windows.Forms.Button btnLogout;
    }
}

