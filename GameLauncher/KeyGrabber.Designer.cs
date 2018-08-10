namespace GameLauncher
{
    partial class KeyGrabber
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
            this.Message = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Message
            // 
            this.Message.AutoSize = true;
            this.Message.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Message.Location = new System.Drawing.Point(12, 62);
            this.Message.Name = "Message";
            this.Message.Size = new System.Drawing.Size(209, 24);
            this.Message.TabIndex = 0;
            this.Message.Text = "Please press a key..";
            this.Message.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // KeyGrabber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(241, 166);
            this.Controls.Add(this.Message);
            this.Name = "KeyGrabber";
            this.Text = "KeyGrabber";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyGrabber_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Message;
    }
}