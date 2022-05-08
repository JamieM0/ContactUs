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
            this.pnlContact0 = new System.Windows.Forms.Panel();
            this.phoneNumber0 = new System.Windows.Forms.Label();
            this.emailAddress0 = new System.Windows.Forms.Label();
            this.lName0 = new System.Windows.Forms.Label();
            this.fName0 = new System.Windows.Forms.Label();
            this.pb0 = new System.Windows.Forms.PictureBox();
            this.pnlContactList = new System.Windows.Forms.Panel();
            this.pnlContact0.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb0)).BeginInit();
            this.pnlContactList.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlContact0
            // 
            this.pnlContact0.Controls.Add(this.phoneNumber0);
            this.pnlContact0.Controls.Add(this.emailAddress0);
            this.pnlContact0.Controls.Add(this.lName0);
            this.pnlContact0.Controls.Add(this.fName0);
            this.pnlContact0.Controls.Add(this.pb0);
            this.pnlContact0.Location = new System.Drawing.Point(3, 3);
            this.pnlContact0.Name = "pnlContact0";
            this.pnlContact0.Size = new System.Drawing.Size(580, 149);
            this.pnlContact0.TabIndex = 0;
            this.pnlContact0.Click += new System.EventHandler(this.pnlContact0_Click);
            this.pnlContact0.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlContact0_Paint);
            // 
            // phoneNumber0
            // 
            this.phoneNumber0.AutoSize = true;
            this.phoneNumber0.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneNumber0.Location = new System.Drawing.Point(151, 97);
            this.phoneNumber0.Name = "phoneNumber0";
            this.phoneNumber0.Size = new System.Drawing.Size(122, 25);
            this.phoneNumber0.TabIndex = 4;
            this.phoneNumber0.Text = "01111111111";
            // 
            // emailAddress0
            // 
            this.emailAddress0.AutoSize = true;
            this.emailAddress0.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailAddress0.Location = new System.Drawing.Point(151, 58);
            this.emailAddress0.Name = "emailAddress0";
            this.emailAddress0.Size = new System.Drawing.Size(295, 25);
            this.emailAddress0.TabIndex = 3;
            this.emailAddress0.Text = "contactsemailhere@example.com";
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
            // fName0
            // 
            this.fName0.AutoSize = true;
            this.fName0.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fName0.Location = new System.Drawing.Point(148, 3);
            this.fName0.Name = "fName0";
            this.fName0.Size = new System.Drawing.Size(173, 45);
            this.fName0.TabIndex = 1;
            this.fName0.Text = "FirstName";
            // 
            // pb0
            // 
            this.pb0.Image = ((System.Drawing.Image)(resources.GetObject("pb0.Image")));
            this.pb0.Location = new System.Drawing.Point(0, 3);
            this.pb0.Name = "pb0";
            this.pb0.Size = new System.Drawing.Size(142, 140);
            this.pb0.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb0.TabIndex = 0;
            this.pb0.TabStop = false;
            // 
            // pnlContactList
            // 
            this.pnlContactList.Controls.Add(this.pnlContact0);
            this.pnlContactList.Location = new System.Drawing.Point(12, 70);
            this.pnlContactList.Name = "pnlContactList";
            this.pnlContactList.Size = new System.Drawing.Size(1210, 629);
            this.pnlContactList.TabIndex = 1;
            // 
            // ContactList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1234, 711);
            this.Controls.Add(this.pnlContactList);
            this.Name = "ContactList";
            this.Text = "Contact List";
            this.Load += new System.EventHandler(this.ContactList_Load);
            this.pnlContact0.ResumeLayout(false);
            this.pnlContact0.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb0)).EndInit();
            this.pnlContactList.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlContact0;
        private System.Windows.Forms.Label phoneNumber0;
        private System.Windows.Forms.Label emailAddress0;
        private System.Windows.Forms.Label lName0;
        private System.Windows.Forms.Label fName0;
        private System.Windows.Forms.PictureBox pb0;
        private System.Windows.Forms.Panel pnlContactList;
    }
}