namespace Checklist_checker
{
    partial class FrmLogin
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
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtEmployeeNr = new System.Windows.Forms.TextBox();
            this.lblEmployee_nr = new System.Windows.Forms.Label();
            this.lblSignInHeader = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(119, 138);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(89, 42);
            this.btnLogin.TabIndex = 0;
            this.btnLogin.Text = "Log inn";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtEmployeeNr
            // 
            this.txtEmployeeNr.Location = new System.Drawing.Point(159, 96);
            this.txtEmployeeNr.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtEmployeeNr.MaxLength = 7;
            this.txtEmployeeNr.Name = "txtEmployeeNr";
            this.txtEmployeeNr.Size = new System.Drawing.Size(76, 20);
            this.txtEmployeeNr.TabIndex = 1;
            this.txtEmployeeNr.Tag = "";
            // 
            // lblEmployee_nr
            // 
            this.lblEmployee_nr.AutoSize = true;
            this.lblEmployee_nr.Location = new System.Drawing.Point(73, 101);
            this.lblEmployee_nr.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmployee_nr.Name = "lblEmployee_nr";
            this.lblEmployee_nr.Size = new System.Drawing.Size(77, 13);
            this.lblEmployee_nr.TabIndex = 2;
            this.lblEmployee_nr.Text = "Ansattnummer:";
            // 
            // lblSignInHeader
            // 
            this.lblSignInHeader.AutoSize = true;
            this.lblSignInHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.lblSignInHeader.Location = new System.Drawing.Point(101, 7);
            this.lblSignInHeader.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSignInHeader.Name = "lblSignInHeader";
            this.lblSignInHeader.Size = new System.Drawing.Size(123, 29);
            this.lblSignInHeader.TabIndex = 3;
            this.lblSignInHeader.Text = "Pålogging";
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 287);
            this.Controls.Add(this.lblSignInHeader);
            this.Controls.Add(this.lblEmployee_nr);
            this.Controls.Add(this.txtEmployeeNr);
            this.Controls.Add(this.btnLogin);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmLogin";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox txtEmployeeNr;
        private System.Windows.Forms.Label lblEmployee_nr;
        private System.Windows.Forms.Label lblSignInHeader;
    }
}