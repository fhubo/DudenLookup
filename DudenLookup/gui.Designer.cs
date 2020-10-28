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
            this.txtErrProposal = new System.Windows.Forms.TextBox();
            this.lblProposal = new System.Windows.Forms.Label();
            this.txtErrMessage = new System.Windows.Forms.TextBox();
            this.lblErrMessage = new System.Windows.Forms.Label();
            this.txtErrCode = new System.Windows.Forms.TextBox();
            this.lblErrorCode = new System.Windows.Forms.Label();
            this.menuStripTop = new System.Windows.Forms.MenuStrip();
            this.lookupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.runToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupErrorList = new System.Windows.Forms.GroupBox();
            this.listErrors = new System.Windows.Forms.ListBox();
            this.btnCorrect = new System.Windows.Forms.Button();
            this.groupInputTextbox.SuspendLayout();
            this.groupCurrentError.SuspendLayout();
            this.menuStripTop.SuspendLayout();
            this.groupErrorList.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupInputTextbox
            // 
            this.groupInputTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupInputTextbox.Controls.Add(this.rtbInput);
            this.groupInputTextbox.Location = new System.Drawing.Point(12, 27);
            this.groupInputTextbox.Name = "groupInputTextbox";
            this.groupInputTextbox.Size = new System.Drawing.Size(545, 541);
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
            this.rtbInput.Size = new System.Drawing.Size(539, 520);
            this.rtbInput.TabIndex = 0;
            this.rtbInput.Text = "";
            this.rtbInput.Click += new System.EventHandler(this.rtbInput_Click);
            this.rtbInput.TextChanged += new System.EventHandler(this.rtbInput_TextChanged);
            // 
            // groupCurrentError
            // 
            this.groupCurrentError.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupCurrentError.Controls.Add(this.btnCorrect);
            this.groupCurrentError.Controls.Add(this.txtErrProposal);
            this.groupCurrentError.Controls.Add(this.lblProposal);
            this.groupCurrentError.Controls.Add(this.txtErrMessage);
            this.groupCurrentError.Controls.Add(this.lblErrMessage);
            this.groupCurrentError.Controls.Add(this.txtErrCode);
            this.groupCurrentError.Controls.Add(this.lblErrorCode);
            this.groupCurrentError.Location = new System.Drawing.Point(563, 27);
            this.groupCurrentError.Name = "groupCurrentError";
            this.groupCurrentError.Size = new System.Drawing.Size(372, 212);
            this.groupCurrentError.TabIndex = 1;
            this.groupCurrentError.TabStop = false;
            this.groupCurrentError.Text = "Error";
            // 
            // txtErrProposal
            // 
            this.txtErrProposal.Location = new System.Drawing.Point(6, 116);
            this.txtErrProposal.Name = "txtErrProposal";
            this.txtErrProposal.ReadOnly = true;
            this.txtErrProposal.Size = new System.Drawing.Size(360, 22);
            this.txtErrProposal.TabIndex = 1;
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
            // txtErrMessage
            // 
            this.txtErrMessage.Location = new System.Drawing.Point(6, 75);
            this.txtErrMessage.Name = "txtErrMessage";
            this.txtErrMessage.ReadOnly = true;
            this.txtErrMessage.Size = new System.Drawing.Size(360, 22);
            this.txtErrMessage.TabIndex = 1;
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
            // txtErrCode
            // 
            this.txtErrCode.Location = new System.Drawing.Point(6, 34);
            this.txtErrCode.Name = "txtErrCode";
            this.txtErrCode.ReadOnly = true;
            this.txtErrCode.Size = new System.Drawing.Size(360, 22);
            this.txtErrCode.TabIndex = 1;
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
            // menuStripTop
            // 
            this.menuStripTop.BackColor = System.Drawing.SystemColors.Control;
            this.menuStripTop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.menuStripTop.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lookupToolStripMenuItem});
            this.menuStripTop.Location = new System.Drawing.Point(0, 0);
            this.menuStripTop.Name = "menuStripTop";
            this.menuStripTop.Size = new System.Drawing.Size(947, 24);
            this.menuStripTop.TabIndex = 2;
            this.menuStripTop.Text = "menuStrip1";
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
            this.runToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.runToolStripMenuItem.Text = "Run";
            this.runToolStripMenuItem.Click += new System.EventHandler(this.runToolStripMenuItem_Click);
            // 
            // groupErrorList
            // 
            this.groupErrorList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupErrorList.Controls.Add(this.listErrors);
            this.groupErrorList.Location = new System.Drawing.Point(563, 245);
            this.groupErrorList.Name = "groupErrorList";
            this.groupErrorList.Size = new System.Drawing.Size(372, 323);
            this.groupErrorList.TabIndex = 3;
            this.groupErrorList.TabStop = false;
            this.groupErrorList.Text = "Error List";
            // 
            // listErrors
            // 
            this.listErrors.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listErrors.Location = new System.Drawing.Point(3, 18);
            this.listErrors.Name = "listErrors";
            this.listErrors.Size = new System.Drawing.Size(366, 302);
            this.listErrors.TabIndex = 0;
            this.listErrors.SelectedIndexChanged += new System.EventHandler(this.listErrors_SelectedIndexChanged);
            // 
            // btnCorrect
            // 
            this.btnCorrect.Location = new System.Drawing.Point(291, 183);
            this.btnCorrect.Name = "btnCorrect";
            this.btnCorrect.Size = new System.Drawing.Size(75, 23);
            this.btnCorrect.TabIndex = 2;
            this.btnCorrect.Text = "Correct";
            this.btnCorrect.UseVisualStyleBackColor = true;
            this.btnCorrect.Click += new System.EventHandler(this.btnCorrect_Click);
            // 
            // gui
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(947, 580);
            this.Controls.Add(this.groupErrorList);
            this.Controls.Add(this.groupCurrentError);
            this.Controls.Add(this.groupInputTextbox);
            this.Controls.Add(this.menuStripTop);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStripTop;
            this.MinimumSize = new System.Drawing.Size(963, 619);
            this.Name = "gui";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Duden Lookup";
            this.Load += new System.EventHandler(this.gui_Load);
            this.groupInputTextbox.ResumeLayout(false);
            this.groupCurrentError.ResumeLayout(false);
            this.groupCurrentError.PerformLayout();
            this.menuStripTop.ResumeLayout(false);
            this.menuStripTop.PerformLayout();
            this.groupErrorList.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupInputTextbox;
        private System.Windows.Forms.GroupBox groupCurrentError;
        private System.Windows.Forms.Label lblProposal;
        private System.Windows.Forms.Label lblErrMessage;
        private System.Windows.Forms.Label lblErrorCode;
        private System.Windows.Forms.MenuStrip menuStripTop;
        private System.Windows.Forms.ToolStripMenuItem lookupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem runToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupErrorList;
        public System.Windows.Forms.RichTextBox rtbInput;
        public System.Windows.Forms.TextBox txtErrProposal;
        public System.Windows.Forms.TextBox txtErrMessage;
        public System.Windows.Forms.TextBox txtErrCode;
        public System.Windows.Forms.ListBox listErrors;
        private System.Windows.Forms.Button btnCorrect;
    }
}

