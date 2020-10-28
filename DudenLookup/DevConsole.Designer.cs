namespace DudenLookup
{
    partial class DevConsole
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
            this.rtbDevLog = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // rtbDevLog
            // 
            this.rtbDevLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbDevLog.Location = new System.Drawing.Point(0, 0);
            this.rtbDevLog.Name = "rtbDevLog";
            this.rtbDevLog.ReadOnly = true;
            this.rtbDevLog.Size = new System.Drawing.Size(559, 483);
            this.rtbDevLog.TabIndex = 0;
            this.rtbDevLog.Text = "";
            // 
            // DevConsole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 483);
            this.ControlBox = false;
            this.Controls.Add(this.rtbDevLog);
            this.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "DevConsole";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DevConsole";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbDevLog;
    }
}