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
            this.label1 = new System.Windows.Forms.Label();
            this.SensivityUpDown = new System.Windows.Forms.NumericUpDown();
            this.HorizUpDown = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.VertUpDown = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.SensivityUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HorizUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VertUpDown)).BeginInit();
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
            this.LabelQuit.Location = new System.Drawing.Point(169, 64);
            this.LabelQuit.Name = "LabelQuit";
            this.LabelQuit.ReadOnly = true;
            this.LabelQuit.Size = new System.Drawing.Size(114, 20);
            this.LabelQuit.TabIndex = 99;
            // 
            // LabelSelect
            // 
            this.LabelSelect.Location = new System.Drawing.Point(169, 93);
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
            this.LabelForwards.Location = new System.Drawing.Point(169, 151);
            this.LabelForwards.Name = "LabelForwards";
            this.LabelForwards.ReadOnly = true;
            this.LabelForwards.Size = new System.Drawing.Size(114, 20);
            this.LabelForwards.TabIndex = 102;
            // 
            // LabelReverse
            // 
            this.LabelReverse.Location = new System.Drawing.Point(169, 122);
            this.LabelReverse.Name = "LabelReverse";
            this.LabelReverse.ReadOnly = true;
            this.LabelReverse.Size = new System.Drawing.Size(114, 20);
            this.LabelReverse.TabIndex = 103;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 182);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 13);
            this.label1.TabIndex = 104;
            this.label1.Text = "Sensivity (higher = less sensitive)";
            // 
            // SensivityUpDown
            // 
            this.SensivityUpDown.Location = new System.Drawing.Point(169, 180);
            this.SensivityUpDown.Name = "SensivityUpDown";
            this.SensivityUpDown.Size = new System.Drawing.Size(114, 20);
            this.SensivityUpDown.TabIndex = 105;
            // 
            // HorizUpDown
            // 
            this.HorizUpDown.Location = new System.Drawing.Point(169, 206);
            this.HorizUpDown.Name = "HorizUpDown";
            this.HorizUpDown.Size = new System.Drawing.Size(114, 20);
            this.HorizUpDown.TabIndex = 107;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 208);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 106;
            this.label2.Text = "Items per line";
            // 
            // VertUpDown
            // 
            this.VertUpDown.Location = new System.Drawing.Point(169, 232);
            this.VertUpDown.Name = "VertUpDown";
            this.VertUpDown.Size = new System.Drawing.Size(114, 20);
            this.VertUpDown.TabIndex = 109;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(2, 234);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 13);
            this.label3.TabIndex = 108;
            this.label3.Text = "Max number of lines";
            // 
            // Options
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 450);
            this.Controls.Add(this.VertUpDown);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.HorizUpDown);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SensivityUpDown);
            this.Controls.Add(this.label1);
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
            ((System.ComponentModel.ISupportInitialize)(this.SensivityUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HorizUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VertUpDown)).EndInit();
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown SensivityUpDown;
        private System.Windows.Forms.NumericUpDown HorizUpDown;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown VertUpDown;
        private System.Windows.Forms.Label label3;
    }
}