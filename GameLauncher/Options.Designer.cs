namespace GameLauncher
{
    partial class Options
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
            this.titleLabel = new System.Windows.Forms.Label();
            this.BtnQuit = new System.Windows.Forms.Button();
            this.BtnSelect = new System.Windows.Forms.Button();
            this.LabelQuit = new System.Windows.Forms.TextBox();
            this.LabelSelect = new System.Windows.Forms.TextBox();
            this.BtnDone = new System.Windows.Forms.Button();
            this.BtnForwards = new System.Windows.Forms.Button();
            this.BtnReverse = new System.Windows.Forms.Button();
            this.LabelForwards = new System.Windows.Forms.TextBox();
            this.LabelReverse = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(0, 0);
            this.titleLabel.Margin = new System.Windows.Forms.Padding(5);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Padding = new System.Windows.Forms.Padding(5);
            this.titleLabel.Size = new System.Drawing.Size(384, 39);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "This is a crude options window";
            // 
            // BtnQuit
            // 
            this.BtnQuit.Location = new System.Drawing.Point(5, 62);
            this.BtnQuit.Name = "BtnQuit";
            this.BtnQuit.Size = new System.Drawing.Size(114, 23);
            this.BtnQuit.TabIndex = 1;
            this.BtnQuit.Text = "Bind Quit Key";
            this.BtnQuit.UseVisualStyleBackColor = true;
            this.BtnQuit.Click += new System.EventHandler(this.BtnQuit_Click);
            // 
            // BtnSelect
            // 
            this.BtnSelect.Location = new System.Drawing.Point(5, 91);
            this.BtnSelect.Name = "BtnSelect";
            this.BtnSelect.Size = new System.Drawing.Size(114, 23);
            this.BtnSelect.TabIndex = 2;
            this.BtnSelect.Text = "Bind Select Key";
            this.BtnSelect.UseVisualStyleBackColor = true;
            this.BtnSelect.Click += new System.EventHandler(this.BtnSelect_Click);
            // 
            // LabelQuit
            // 
            this.LabelQuit.Location = new System.Drawing.Point(156, 64);
            this.LabelQuit.Name = "LabelQuit";
            this.LabelQuit.ReadOnly = true;
            this.LabelQuit.Size = new System.Drawing.Size(114, 20);
            this.LabelQuit.TabIndex = 99;
            // 
            // LabelSelect
            // 
            this.LabelSelect.Location = new System.Drawing.Point(156, 93);
            this.LabelSelect.Name = "LabelSelect";
            this.LabelSelect.ReadOnly = true;
            this.LabelSelect.Size = new System.Drawing.Size(114, 20);
            this.LabelSelect.TabIndex = 99;
            // 
            // BtnDone
            // 
            this.BtnDone.Location = new System.Drawing.Point(5, 415);
            this.BtnDone.Name = "BtnDone";
            this.BtnDone.Size = new System.Drawing.Size(114, 23);
            this.BtnDone.TabIndex = 3;
            this.BtnDone.Text = "Save";
            this.BtnDone.UseVisualStyleBackColor = true;
            this.BtnDone.Click += new System.EventHandler(this.BtnDone_Click);
            // 
            // BtnForwards
            // 
            this.BtnForwards.Location = new System.Drawing.Point(5, 149);
            this.BtnForwards.Name = "BtnForwards";
            this.BtnForwards.Size = new System.Drawing.Size(114, 23);
            this.BtnForwards.TabIndex = 100;
            this.BtnForwards.Text = "Bind Forwards Key";
            this.BtnForwards.UseVisualStyleBackColor = true;
            this.BtnForwards.Click += new System.EventHandler(this.BtnForwards_Click);
            // 
            // BtnReverse
            // 
            this.BtnReverse.Location = new System.Drawing.Point(5, 120);
            this.BtnReverse.Name = "BtnReverse";
            this.BtnReverse.Size = new System.Drawing.Size(114, 23);
            this.BtnReverse.TabIndex = 101;
            this.BtnReverse.Text = "Bind Reverse Key";
            this.BtnReverse.UseVisualStyleBackColor = true;
            this.BtnReverse.Click += new System.EventHandler(this.BtnReverse_Click);
            // 
            // LabelForwards
            // 
            this.LabelForwards.Location = new System.Drawing.Point(156, 151);
            this.LabelForwards.Name = "LabelForwards";
            this.LabelForwards.ReadOnly = true;
            this.LabelForwards.Size = new System.Drawing.Size(114, 20);
            this.LabelForwards.TabIndex = 102;
            // 
            // LabelReverse
            // 
            this.LabelReverse.Location = new System.Drawing.Point(156, 122);
            this.LabelReverse.Name = "LabelReverse";
            this.LabelReverse.ReadOnly = true;
            this.LabelReverse.Size = new System.Drawing.Size(114, 20);
            this.LabelReverse.TabIndex = 103;
            // 
            // Options
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 450);
            this.Controls.Add(this.LabelReverse);
            this.Controls.Add(this.LabelForwards);
            this.Controls.Add(this.BtnReverse);
            this.Controls.Add(this.BtnForwards);
            this.Controls.Add(this.BtnDone);
            this.Controls.Add(this.LabelSelect);
            this.Controls.Add(this.LabelQuit);
            this.Controls.Add(this.BtnSelect);
            this.Controls.Add(this.BtnQuit);
            this.Controls.Add(this.titleLabel);
            this.Name = "Options";
            this.Text = "Options";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Button BtnQuit;
        private System.Windows.Forms.Button BtnSelect;
        private System.Windows.Forms.TextBox LabelQuit;
        private System.Windows.Forms.TextBox LabelSelect;
        private System.Windows.Forms.Button BtnDone;
        private System.Windows.Forms.Button BtnForwards;
        private System.Windows.Forms.Button BtnReverse;
        private System.Windows.Forms.TextBox LabelForwards;
        private System.Windows.Forms.TextBox LabelReverse;
    }
}