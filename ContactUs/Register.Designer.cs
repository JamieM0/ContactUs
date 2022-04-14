namespace ContactUs
{
    partial class Register
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
            this.btnRegister = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lbPassword = new System.Windows.Forms.Label();
            this.lbUsername = new System.Windows.Forms.Label();
            this.lbRegister = new System.Windows.Forms.Label();
            this.txtConfirmPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbColour = new System.Windows.Forms.ComboBox();
            this.btnRegisterInstead = new System.Windows.Forms.Button();
            this.progressPasswordStrengthBarTest = new System.Windows.Forms.ProgressBar();
            this.lbPWStrength = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnRegister
            // 
            this.btnRegister.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister.Location = new System.Drawing.Point(392, 510);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(483, 69);
            this.btnRegister.TabIndex = 5;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(599, 228);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(276, 43);
            this.txtPassword.TabIndex = 2;
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            // 
            // txtUsername
            // 
            this.txtUsername.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Location = new System.Drawing.Point(599, 151);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(276, 43);
            this.txtUsername.TabIndex = 1;
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPassword.Location = new System.Drawing.Point(394, 225);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(160, 45);
            this.lbPassword.TabIndex = 8;
            this.lbPassword.Text = "Password:";
            // 
            // lbUsername
            // 
            this.lbUsername.AutoSize = true;
            this.lbUsername.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUsername.Location = new System.Drawing.Point(384, 148);
            this.lbUsername.Name = "lbUsername";
            this.lbUsername.Size = new System.Drawing.Size(170, 45);
            this.lbUsername.TabIndex = 7;
            this.lbUsername.Text = "Username:";
            // 
            // lbRegister
            // 
            this.lbRegister.AutoSize = true;
            this.lbRegister.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRegister.Location = new System.Drawing.Point(573, 9);
            this.lbRegister.Name = "lbRegister";
            this.lbRegister.Size = new System.Drawing.Size(199, 65);
            this.lbRegister.TabIndex = 6;
            this.lbRegister.Text = "Register";
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfirmPassword.Location = new System.Drawing.Point(599, 316);
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.Size = new System.Drawing.Size(276, 43);
            this.txtConfirmPassword.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(271, 314);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(283, 45);
            this.label1.TabIndex = 12;
            this.label1.Text = "Confirm Password:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(187, 404);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(367, 45);
            this.label2.TabIndex = 14;
            this.label2.Text = "Favourite Accent Colour:";
            // 
            // cmbColour
            // 
            this.cmbColour.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbColour.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbColour.FormattingEnabled = true;
            this.cmbColour.Items.AddRange(new object[] {
            "Red",
            "Yellow",
            "Blue",
            "Green",
            "Pink",
            "Purple"});
            this.cmbColour.Location = new System.Drawing.Point(599, 404);
            this.cmbColour.Name = "cmbColour";
            this.cmbColour.Size = new System.Drawing.Size(276, 45);
            this.cmbColour.TabIndex = 4;
            // 
            // btnRegisterInstead
            // 
            this.btnRegisterInstead.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegisterInstead.Location = new System.Drawing.Point(392, 608);
            this.btnRegisterInstead.Name = "btnRegisterInstead";
            this.btnRegisterInstead.Size = new System.Drawing.Size(483, 41);
            this.btnRegisterInstead.TabIndex = 15;
            this.btnRegisterInstead.Text = "Login instead";
            this.btnRegisterInstead.UseVisualStyleBackColor = true;
            this.btnRegisterInstead.Click += new System.EventHandler(this.btnRegisterInstead_Click);
            // 
            // progressPasswordStrengthBarTest
            // 
            this.progressPasswordStrengthBarTest.Location = new System.Drawing.Point(599, 277);
            this.progressPasswordStrengthBarTest.Name = "progressPasswordStrengthBarTest";
            this.progressPasswordStrengthBarTest.Size = new System.Drawing.Size(276, 20);
            this.progressPasswordStrengthBarTest.TabIndex = 16;
            // 
            // lbPWStrength
            // 
            this.lbPWStrength.AutoSize = true;
            this.lbPWStrength.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPWStrength.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbPWStrength.Location = new System.Drawing.Point(792, 272);
            this.lbPWStrength.Name = "lbPWStrength";
            this.lbPWStrength.Size = new System.Drawing.Size(83, 25);
            this.lbPWStrength.TabIndex = 17;
            this.lbPWStrength.Text = "Strength";
            this.lbPWStrength.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1234, 711);
            this.Controls.Add(this.lbPWStrength);
            this.Controls.Add(this.progressPasswordStrengthBarTest);
            this.Controls.Add(this.btnRegisterInstead);
            this.Controls.Add(this.cmbColour);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtConfirmPassword);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.lbPassword);
            this.Controls.Add(this.lbUsername);
            this.Controls.Add(this.lbRegister);
            this.Name = "Register";
            this.Text = "Register";
            this.Load += new System.EventHandler(this.Register_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.Label lbUsername;
        private System.Windows.Forms.Label lbRegister;
        private System.Windows.Forms.TextBox txtConfirmPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbColour;
        private System.Windows.Forms.Button btnRegisterInstead;
        private System.Windows.Forms.ProgressBar progressPasswordStrengthBarTest;
        private System.Windows.Forms.Label lbPWStrength;
    }
}