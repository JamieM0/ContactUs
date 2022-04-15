namespace ContactUs
{
    partial class Test
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
            this.btnContactView = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnContactView
            // 
            this.btnContactView.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContactView.Location = new System.Drawing.Point(201, 121);
            this.btnContactView.Name = "btnContactView";
            this.btnContactView.Size = new System.Drawing.Size(211, 73);
            this.btnContactView.TabIndex = 0;
            this.btnContactView.Text = "Go to ContactView";
            this.btnContactView.UseVisualStyleBackColor = true;
            this.btnContactView.Click += new System.EventHandler(this.btnContactView_Click);
            // 
            // Test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnContactView);
            this.Name = "Test";
            this.Text = "Test";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnContactView;
    }
}