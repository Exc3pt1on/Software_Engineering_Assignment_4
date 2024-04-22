namespace Checklist_checker
{
    partial class FrmCheckList
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
            this.lblHeader = new System.Windows.Forms.Label();
            this.flowLayoutPanelChecklist = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // lblHeader
            // 
            this.lblHeader.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.lblHeader.Location = new System.Drawing.Point(545, 45);
            this.lblHeader.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(111, 36);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "Header";
            // 
            // flowLayoutPanelChecklist
            // 
            this.flowLayoutPanelChecklist.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.flowLayoutPanelChecklist.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanelChecklist.Location = new System.Drawing.Point(94, 130);
            this.flowLayoutPanelChecklist.Name = "flowLayoutPanelChecklist";
            this.flowLayoutPanelChecklist.Size = new System.Drawing.Size(1500, 629);
            this.flowLayoutPanelChecklist.TabIndex = 1;
            // 
            // FrmCheckList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1270, 759);
            this.Controls.Add(this.flowLayoutPanelChecklist);
            this.Controls.Add(this.lblHeader);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmCheckList";
            this.Text = "Sjekkliste";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelChecklist;
    }
}