
namespace Fencrypt
{
    partial class MessageForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MessageForm));
            this.message_text = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // message_text
            // 
            this.message_text.Location = new System.Drawing.Point(12, 12);
            this.message_text.Multiline = true;
            this.message_text.Name = "message_text";
            this.message_text.ReadOnly = true;
            this.message_text.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.message_text.Size = new System.Drawing.Size(381, 368);
            this.message_text.TabIndex = 1;
            // 
            // MessageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 392);
            this.Controls.Add(this.message_text);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MessageForm";
            this.Text = "Fencrypt";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox message_text;
    }
}