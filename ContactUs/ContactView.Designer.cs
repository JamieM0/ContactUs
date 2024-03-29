﻿namespace ContactUs
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
            this.lbEmailNumber = new System.Windows.Forms.Label();
            this.rtxtEmailAddresses = new System.Windows.Forms.RichTextBox();
            this.lbPhoneNumbersNumbers = new System.Windows.Forms.Label();
            this.lbPhoneNumbers = new System.Windows.Forms.Label();
            this.rtxtPhoneNumbers = new System.Windows.Forms.RichTextBox();
            this.pbSendMail = new System.Windows.Forms.PictureBox();
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
            this.btnExit = new System.Windows.Forms.Button();
            this.pbDeleteContact = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbContactPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSendMail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDeleteContact)).BeginInit();
            this.SuspendLayout();
            // 
            // lbFName
            // 
            this.lbFName.AutoSize = true;
            this.lbFName.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFName.Location = new System.Drawing.Point(12, 178);
            this.lbFName.Name = "lbFName";
            this.lbFName.Size = new System.Drawing.Size(150, 37);
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
            this.pbContactPicture.Click += new System.EventHandler(this.pbContactPicture_Click);
            // 
            // txtFName
            // 
            this.txtFName.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFName.Location = new System.Drawing.Point(174, 181);
            this.txtFName.Name = "txtFName";
            this.txtFName.Size = new System.Drawing.Size(455, 35);
            this.txtFName.TabIndex = 1;
            this.txtFName.TextChanged += new System.EventHandler(this.txtFName_TextChanged);
            this.txtFName.Leave += new System.EventHandler(this.txtFName_Leave);
            // 
            // lbLName
            // 
            this.lbLName.AutoSize = true;
            this.lbLName.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLName.Location = new System.Drawing.Point(12, 257);
            this.lbLName.Name = "lbLName";
            this.lbLName.Size = new System.Drawing.Size(148, 37);
            this.lbLName.TabIndex = 3;
            this.lbLName.Text = "Last Name:";
            this.lbLName.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtLName
            // 
            this.txtLName.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLName.Location = new System.Drawing.Point(174, 260);
            this.txtLName.Name = "txtLName";
            this.txtLName.Size = new System.Drawing.Size(455, 35);
            this.txtLName.TabIndex = 2;
            this.txtLName.TextChanged += new System.EventHandler(this.txtLName_TextChanged);
            this.txtLName.Leave += new System.EventHandler(this.txtLName_Leave);
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEmail.Location = new System.Drawing.Point(11, 317);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(230, 37);
            this.lbEmail.TabIndex = 5;
            this.lbEmail.Text = "Email Address(es):";
            // 
            // lbEmailNumber
            // 
            this.lbEmailNumber.AutoSize = true;
            this.lbEmailNumber.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEmailNumber.Location = new System.Drawing.Point(15, 353);
            this.lbEmailNumber.Name = "lbEmailNumber";
            this.lbEmailNumber.Size = new System.Drawing.Size(227, 63);
            this.lbEmailNumber.TabIndex = 8;
            this.lbEmailNumber.Text = "One email per line! \r\nThe email button will email the \r\nfirst one only.";
            // 
            // rtxtEmailAddresses
            // 
            this.rtxtEmailAddresses.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxtEmailAddresses.Location = new System.Drawing.Point(247, 327);
            this.rtxtEmailAddresses.Name = "rtxtEmailAddresses";
            this.rtxtEmailAddresses.Size = new System.Drawing.Size(381, 112);
            this.rtxtEmailAddresses.TabIndex = 3;
            this.rtxtEmailAddresses.Text = "";
            this.rtxtEmailAddresses.TextChanged += new System.EventHandler(this.rtxtEmailAddresses_TextChanged);
            this.rtxtEmailAddresses.Leave += new System.EventHandler(this.rtxtEmailAddresses_Leave);
            // 
            // lbPhoneNumbersNumbers
            // 
            this.lbPhoneNumbersNumbers.AutoSize = true;
            this.lbPhoneNumbersNumbers.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPhoneNumbersNumbers.Location = new System.Drawing.Point(16, 505);
            this.lbPhoneNumbersNumbers.Name = "lbPhoneNumbersNumbers";
            this.lbPhoneNumbersNumbers.Size = new System.Drawing.Size(163, 21);
            this.lbPhoneNumbersNumbers.TabIndex = 11;
            this.lbPhoneNumbersNumbers.Text = "One number per line! \r\n";
            // 
            // lbPhoneNumbers
            // 
            this.lbPhoneNumbers.AutoSize = true;
            this.lbPhoneNumbers.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPhoneNumbers.Location = new System.Drawing.Point(13, 468);
            this.lbPhoneNumbers.Name = "lbPhoneNumbers";
            this.lbPhoneNumbers.Size = new System.Drawing.Size(229, 37);
            this.lbPhoneNumbers.TabIndex = 10;
            this.lbPhoneNumbers.Text = "Phone Number(s):";
            // 
            // rtxtPhoneNumbers
            // 
            this.rtxtPhoneNumbers.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxtPhoneNumbers.Location = new System.Drawing.Point(248, 468);
            this.rtxtPhoneNumbers.Name = "rtxtPhoneNumbers";
            this.rtxtPhoneNumbers.Size = new System.Drawing.Size(332, 118);
            this.rtxtPhoneNumbers.TabIndex = 4;
            this.rtxtPhoneNumbers.Text = "";
            this.rtxtPhoneNumbers.TextChanged += new System.EventHandler(this.rtxtPhoneNumbers_TextChanged);
            this.rtxtPhoneNumbers.Leave += new System.EventHandler(this.rtxtPhoneNumbers_Leave);
            // 
            // pbSendMail
            // 
            this.pbSendMail.Image = ((System.Drawing.Image)(resources.GetObject("pbSendMail.Image")));
            this.pbSendMail.Location = new System.Drawing.Point(634, 327);
            this.pbSendMail.Name = "pbSendMail";
            this.pbSendMail.Size = new System.Drawing.Size(49, 112);
            this.pbSendMail.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbSendMail.TabIndex = 13;
            this.pbSendMail.TabStop = false;
            this.pbSendMail.Click += new System.EventHandler(this.pbSendMail_Click);
            // 
            // lbAddress
            // 
            this.lbAddress.AutoSize = true;
            this.lbAddress.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAddress.Location = new System.Drawing.Point(688, 178);
            this.lbAddress.Name = "lbAddress";
            this.lbAddress.Size = new System.Drawing.Size(117, 37);
            this.lbAddress.TabIndex = 15;
            this.lbAddress.Text = "Address:";
            // 
            // lbAddressInfo
            // 
            this.lbAddressInfo.AutoSize = true;
            this.lbAddressInfo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAddressInfo.Location = new System.Drawing.Point(691, 223);
            this.lbAddressInfo.Name = "lbAddressInfo";
            this.lbAddressInfo.Size = new System.Drawing.Size(110, 42);
            this.lbAddressInfo.TabIndex = 16;
            this.lbAddressInfo.Text = "Use your own \r\nformatting!";
            // 
            // rtxtAddress
            // 
            this.rtxtAddress.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxtAddress.Location = new System.Drawing.Point(811, 181);
            this.rtxtAddress.Name = "rtxtAddress";
            this.rtxtAddress.Size = new System.Drawing.Size(411, 113);
            this.rtxtAddress.TabIndex = 8;
            this.rtxtAddress.Text = "";
            this.rtxtAddress.TextChanged += new System.EventHandler(this.rtxtAddress_TextChanged);
            this.rtxtAddress.Leave += new System.EventHandler(this.rtxtAddress_Leave);
            // 
            // lbBirthdate
            // 
            this.lbBirthdate.AutoSize = true;
            this.lbBirthdate.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBirthdate.Location = new System.Drawing.Point(671, 466);
            this.lbBirthdate.Name = "lbBirthdate";
            this.lbBirthdate.Size = new System.Drawing.Size(131, 37);
            this.lbBirthdate.TabIndex = 18;
            this.lbBirthdate.Text = "Birthdate:";
            // 
            // dtpBirthdate
            // 
            this.dtpBirthdate.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpBirthdate.Location = new System.Drawing.Point(811, 468);
            this.dtpBirthdate.Name = "dtpBirthdate";
            this.dtpBirthdate.Size = new System.Drawing.Size(276, 35);
            this.dtpBirthdate.TabIndex = 5;
            this.dtpBirthdate.Leave += new System.EventHandler(this.dtpBirthdate_Leave);
            // 
            // dtpOtherDate
            // 
            this.dtpOtherDate.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpOtherDate.Location = new System.Drawing.Point(811, 509);
            this.dtpOtherDate.Name = "dtpOtherDate";
            this.dtpOtherDate.Size = new System.Drawing.Size(276, 35);
            this.dtpOtherDate.TabIndex = 6;
            this.dtpOtherDate.ValueChanged += new System.EventHandler(this.dtpOtherDate_ValueChanged);
            this.dtpOtherDate.Leave += new System.EventHandler(this.dtpOtherDate_Leave);
            // 
            // lbOtherDate
            // 
            this.lbOtherDate.AutoSize = true;
            this.lbOtherDate.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbOtherDate.Location = new System.Drawing.Point(651, 507);
            this.lbOtherDate.Name = "lbOtherDate";
            this.lbOtherDate.Size = new System.Drawing.Size(150, 37);
            this.lbOtherDate.TabIndex = 20;
            this.lbOtherDate.Text = "Other date:";
            // 
            // lbOtherDateLabel
            // 
            this.lbOtherDateLabel.AutoSize = true;
            this.lbOtherDateLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbOtherDateLabel.Location = new System.Drawing.Point(586, 544);
            this.lbOtherDateLabel.Name = "lbOtherDateLabel";
            this.lbOtherDateLabel.Size = new System.Drawing.Size(215, 37);
            this.lbOtherDateLabel.TabIndex = 22;
            this.lbOtherDateLabel.Text = "Other date label:";
            // 
            // txtOtherDate
            // 
            this.txtOtherDate.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOtherDate.Location = new System.Drawing.Point(811, 551);
            this.txtOtherDate.Name = "txtOtherDate";
            this.txtOtherDate.Size = new System.Drawing.Size(276, 35);
            this.txtOtherDate.TabIndex = 7;
            this.txtOtherDate.TextChanged += new System.EventHandler(this.txtOtherDate_TextChanged);
            this.txtOtherDate.Leave += new System.EventHandler(this.txtOtherDate_Leave);
            // 
            // lbNotes
            // 
            this.lbNotes.AutoSize = true;
            this.lbNotes.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNotes.Location = new System.Drawing.Point(707, 330);
            this.lbNotes.Name = "lbNotes";
            this.lbNotes.Size = new System.Drawing.Size(93, 37);
            this.lbNotes.TabIndex = 24;
            this.lbNotes.Text = "Notes:";
            // 
            // rtxtNotes
            // 
            this.rtxtNotes.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxtNotes.Location = new System.Drawing.Point(810, 330);
            this.rtxtNotes.Name = "rtxtNotes";
            this.rtxtNotes.Size = new System.Drawing.Size(411, 99);
            this.rtxtNotes.TabIndex = 9;
            this.rtxtNotes.Text = "";
            this.rtxtNotes.TextChanged += new System.EventHandler(this.rtxtNotes_TextChanged);
            this.rtxtNotes.Leave += new System.EventHandler(this.rtxtNotes_Leave);
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
            this.btnSaveOnly.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveOnly.Location = new System.Drawing.Point(846, 37);
            this.btnSaveOnly.Name = "btnSaveOnly";
            this.btnSaveOnly.Size = new System.Drawing.Size(106, 41);
            this.btnSaveOnly.TabIndex = 11;
            this.btnSaveOnly.Text = "Save";
            this.btnSaveOnly.UseVisualStyleBackColor = true;
            this.btnSaveOnly.Click += new System.EventHandler(this.btnSaveOnly_Click);
            // 
            // btnSaveAndReturn
            // 
            this.btnSaveAndReturn.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveAndReturn.Location = new System.Drawing.Point(846, 84);
            this.btnSaveAndReturn.Name = "btnSaveAndReturn";
            this.btnSaveAndReturn.Size = new System.Drawing.Size(376, 40);
            this.btnSaveAndReturn.TabIndex = 12;
            this.btnSaveAndReturn.Text = "Save and Return to Main Menu";
            this.btnSaveAndReturn.UseVisualStyleBackColor = true;
            this.btnSaveAndReturn.Click += new System.EventHandler(this.btnSaveAndReturn_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(958, 37);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(264, 41);
            this.btnExit.TabIndex = 13;
            this.btnExit.Text = "Exit to Main Menu";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // pbDeleteContact
            // 
            this.pbDeleteContact.Image = ((System.Drawing.Image)(resources.GetObject("pbDeleteContact.Image")));
            this.pbDeleteContact.Location = new System.Drawing.Point(1131, 468);
            this.pbDeleteContact.Name = "pbDeleteContact";
            this.pbDeleteContact.Size = new System.Drawing.Size(64, 120);
            this.pbDeleteContact.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbDeleteContact.TabIndex = 27;
            this.pbDeleteContact.TabStop = false;
            this.pbDeleteContact.Click += new System.EventHandler(this.pbDeleteContact_Click);
            // 
            // ContactView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1234, 647);
            this.Controls.Add(this.pbDeleteContact);
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
            ((System.ComponentModel.ISupportInitialize)(this.pbDeleteContact)).EndInit();
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
        private System.Windows.Forms.Label lbEmailNumber;
        private System.Windows.Forms.RichTextBox rtxtEmailAddresses;
        private System.Windows.Forms.Label lbPhoneNumbersNumbers;
        private System.Windows.Forms.Label lbPhoneNumbers;
        private System.Windows.Forms.RichTextBox rtxtPhoneNumbers;
        private System.Windows.Forms.PictureBox pbSendMail;
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
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.PictureBox pbDeleteContact;
    }
}

