namespace DudenLookup
{
    partial class gui
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupInputTextbox = new System.Windows.Forms.GroupBox();
            this.rtbInput = new System.Windows.Forms.RichTextBox();
            this.groupCurrentError = new System.Windows.Forms.GroupBox();
            this.lblErrorCode = new System.Windows.Forms.Label();
            this.txtErrCode = new System.Windows.Forms.TextBox();
            this.lblErrMessage = new System.Windows.Forms.Label();
            this.txtErrMessage = new System.Windows.Forms.TextBox();
            this.lblProposal = new System.Windows.Forms.Label();
            this.txtErrProposal = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.lookupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.runToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupInputTextbox.SuspendLayout();
            this.groupCurrentError.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupInputTextbox
            // 
            this.groupInputTextbox.Controls.Add(this.rtbInput);
            this.groupInputTextbox.Location = new System.Drawing.Point(12, 27);
            this.groupInputTextbox.Name = "groupInputTextbox";
            this.groupInputTextbox.Size = new System.Drawing.Size(545, 492);
            this.groupInputTextbox.TabIndex = 0;
            this.groupInputTextbox.TabStop = false;
            this.groupInputTextbox.Text = "Text";
            // 
            // rtbInput
            // 
            this.rtbInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbInput.Location = new System.Drawing.Point(3, 18);
            this.rtbInput.Name = "rtbInput";
            this.rtbInput.Size = new System.Drawing.Size(539, 471);
            this.rtbInput.TabIndex = 0;
            this.rtbInput.Text = "";
            this.rtbInput.Click += new System.EventHandler(this.rtbInput_Click);
            // 
            // groupCurrentError
            // 
            this.groupCurrentError.Controls.Add(this.txtErrProposal);
            this.groupCurrentError.Controls.Add(this.lblProposal);
            this.groupCurrentError.Controls.Add(this.txtErrMessage);
            this.groupCurrentError.Controls.Add(this.lblErrMessage);
            this.groupCurrentError.Controls.Add(this.txtErrCode);
            this.groupCurrentError.Controls.Add(this.lblErrorCode);
            this.groupCurrentError.Location = new System.Drawing.Point(563, 27);
            this.groupCurrentError.Name = "groupCurrentError";
            this.groupCurrentError.Size = new System.Drawing.Size(366, 212);
            this.groupCurrentError.TabIndex = 1;
            this.groupCurrentError.TabStop = false;
            this.groupCurrentError.Text = "Error";
            // 
            // lblErrorCode
            // 
            this.lblErrorCode.AutoSize = true;
            this.lblErrorCode.Location = new System.Drawing.Point(6, 18);
            this.lblErrorCode.Name = "lblErrorCode";
            this.lblErrorCode.Size = new System.Drawing.Size(34, 13);
            this.lblErrorCode.TabIndex = 0;
            this.lblErrorCode.Text = "Code";
            // 
            // txtErrCode
            // 
            this.txtErrCode.Location = new System.Drawing.Point(6, 34);
            this.txtErrCode.Name = "txtErrCode";
            this.txtErrCode.ReadOnly = true;
            this.txtErrCode.Size = new System.Drawing.Size(354, 22);
            this.txtErrCode.TabIndex = 1;
            // 
            // lblErrMessage
            // 
            this.lblErrMessage.AutoSize = true;
            this.lblErrMessage.Location = new System.Drawing.Point(6, 59);
            this.lblErrMessage.Name = "lblErrMessage";
            this.lblErrMessage.Size = new System.Drawing.Size(52, 13);
            this.lblErrMessage.TabIndex = 0;
            this.lblErrMessage.Text = "Message";
            // 
            // txtErrMessage
            // 
            this.txtErrMessage.Location = new System.Drawing.Point(6, 75);
            this.txtErrMessage.Name = "txtErrMessage";
            this.txtErrMessage.ReadOnly = true;
            this.txtErrMessage.Size = new System.Drawing.Size(354, 22);
            this.txtErrMessage.TabIndex = 1;
            // 
            // lblProposal
            // 
            this.lblProposal.AutoSize = true;
            this.lblProposal.Location = new System.Drawing.Point(6, 100);
            this.lblProposal.Name = "lblProposal";
            this.lblProposal.Size = new System.Drawing.Size(52, 13);
            this.lblProposal.TabIndex = 0;
            this.lblProposal.Text = "Proposal";
            // 
            // txtErrProposal
            // 
            this.txtErrProposal.Location = new System.Drawing.Point(6, 116);
            this.txtErrProposal.Name = "txtErrProposal";
            this.txtErrProposal.ReadOnly = true;
            this.txtErrProposal.Size = new System.Drawing.Size(354, 22);
            this.txtErrProposal.TabIndex = 1;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lookupToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1047, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // lookupToolStripMenuItem
            // 
            this.lookupToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.runToolStripMenuItem});
            this.lookupToolStripMenuItem.Name = "lookupToolStripMenuItem";
            this.lookupToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.lookupToolStripMenuItem.Text = "Lookup";
            // 
            // runToolStripMenuItem
            // 
            this.runToolStripMenuItem.Name = "runToolStripMenuItem";
            this.runToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.runToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.runToolStripMenuItem.Text = "Run";
            this.runToolStripMenuItem.Click += new System.EventHandler(this.runToolStripMenuItem_Click);
            // 
            // gui
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1047, 580);
            this.Controls.Add(this.groupCurrentError);
            this.Controls.Add(this.groupInputTextbox);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "gui";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Duden Lookup";
            this.Load += new System.EventHandler(this.gui_Load);
            this.groupInputTextbox.ResumeLayout(false);
            this.groupCurrentError.ResumeLayout(false);
            this.groupCurrentError.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupInputTextbox;
        private System.Windows.Forms.RichTextBox rtbInput;
        private System.Windows.Forms.GroupBox groupCurrentError;
        private System.Windows.Forms.TextBox txtErrProposal;
        private System.Windows.Forms.Label lblProposal;
        private System.Windows.Forms.TextBox txtErrMessage;
        private System.Windows.Forms.Label lblErrMessage;
        private System.Windows.Forms.TextBox txtErrCode;
        private System.Windows.Forms.Label lblErrorCode;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem lookupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem runToolStripMenuItem;
    }
}

