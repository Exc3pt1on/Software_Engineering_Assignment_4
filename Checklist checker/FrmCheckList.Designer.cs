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
            this.components = new System.ComponentModel.Container();
            this.lblHeader = new System.Windows.Forms.Label();
            this.flowLayoutPanelChecklist = new System.Windows.Forms.FlowLayoutPanel();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.txtSign = new System.Windows.Forms.TextBox();
            this.lblSign = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.lblComment = new System.Windows.Forms.Label();
            this.txtComment = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblHeader
            // 
            this.lblHeader.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.lblHeader.Location = new System.Drawing.Point(729, 37);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(93, 29);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "Header";
            // 
            // flowLayoutPanelChecklist
            // 
            this.flowLayoutPanelChecklist.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.flowLayoutPanelChecklist.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanelChecklist.Location = new System.Drawing.Point(331, 110);
            this.flowLayoutPanelChecklist.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.flowLayoutPanelChecklist.Name = "flowLayoutPanelChecklist";
            this.flowLayoutPanelChecklist.Size = new System.Drawing.Size(872, 507);
            this.flowLayoutPanelChecklist.TabIndex = 1;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSubmit.Location = new System.Drawing.Point(1452, 749);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(100, 23);
            this.btnSubmit.TabIndex = 2;
            this.btnSubmit.Text = "Fullfør";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // txtSign
            // 
            this.txtSign.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSign.Location = new System.Drawing.Point(1452, 723);
            this.txtSign.Name = "txtSign";
            this.txtSign.Size = new System.Drawing.Size(100, 20);
            this.txtSign.TabIndex = 3;
            // 
            // lblSign
            // 
            this.lblSign.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSign.AutoSize = true;
            this.lblSign.Location = new System.Drawing.Point(1403, 726);
            this.lblSign.Name = "lblSign";
            this.lblSign.Size = new System.Drawing.Size(43, 13);
            this.lblSign.TabIndex = 4;
            this.lblSign.Text = "Signer: ";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // lblComment
            // 
            this.lblComment.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblComment.AutoSize = true;
            this.lblComment.Location = new System.Drawing.Point(1350, 495);
            this.lblComment.Name = "lblComment";
            this.lblComment.Size = new System.Drawing.Size(63, 13);
            this.lblComment.TabIndex = 7;
            this.lblComment.Text = "Kommentar:";
            // 
            // txtComment
            // 
            this.txtComment.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtComment.Location = new System.Drawing.Point(1353, 511);
            this.txtComment.Multiline = true;
            this.txtComment.Name = "txtComment";
            this.txtComment.Size = new System.Drawing.Size(199, 187);
            this.txtComment.TabIndex = 6;
            // 
            // FrmCheckList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1592, 826);
            this.Controls.Add(this.lblComment);
            this.Controls.Add(this.txtComment);
            this.Controls.Add(this.lblSign);
            this.Controls.Add(this.txtSign);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.flowLayoutPanelChecklist);
            this.Controls.Add(this.lblHeader);
            this.Name = "FrmCheckList";
            this.Text = "Sjekkliste";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelChecklist;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.TextBox txtSign;
        private System.Windows.Forms.Label lblSign;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label lblComment;
        private System.Windows.Forms.TextBox txtComment;
    }
}