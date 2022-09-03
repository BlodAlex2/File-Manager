namespace FileManager.Forms
{
    partial class CopyForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CopyForm));
            this.label1 = new System.Windows.Forms.Label();
            this.fileNameLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.sourceLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.destinationLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.allFilesLabel = new System.Windows.Forms.Label();
            this.CurrentFileProgressBar = new System.Windows.Forms.ProgressBar();
            this.AllFilesProgressBar = new System.Windows.Forms.ProgressBar();
            this.StartButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Файл:";
            // 
            // fileNameLabel
            // 
            this.fileNameLabel.AutoSize = true;
            this.fileNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fileNameLabel.Location = new System.Drawing.Point(60, 9);
            this.fileNameLabel.Name = "fileNameLabel";
            this.fileNameLabel.Size = new System.Drawing.Size(56, 13);
            this.fileNameLabel.TabIndex = 1;
            this.fileNameLabel.Text = "fileName";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Из:";
            // 
            // sourceLabel
            // 
            this.sourceLabel.AutoSize = true;
            this.sourceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sourceLabel.Location = new System.Drawing.Point(60, 22);
            this.sourceLabel.Name = "sourceLabel";
            this.sourceLabel.Size = new System.Drawing.Size(45, 13);
            this.sourceLabel.TabIndex = 3;
            this.sourceLabel.Text = "source";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(12, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(19, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "В:";
            // 
            // destinationLabel
            // 
            this.destinationLabel.AutoSize = true;
            this.destinationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.destinationLabel.Location = new System.Drawing.Point(60, 35);
            this.destinationLabel.Name = "destinationLabel";
            this.destinationLabel.Size = new System.Drawing.Size(69, 13);
            this.destinationLabel.TabIndex = 5;
            this.destinationLabel.Text = "destination";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(12, 48);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Всего:";
            // 
            // allFilesLabel
            // 
            this.allFilesLabel.AutoSize = true;
            this.allFilesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.allFilesLabel.Location = new System.Drawing.Point(60, 48);
            this.allFilesLabel.Name = "allFilesLabel";
            this.allFilesLabel.Size = new System.Drawing.Size(34, 13);
            this.allFilesLabel.TabIndex = 7;
            this.allFilesLabel.Text = "3/90";
            // 
            // CurrentFileProgressBar
            // 
            this.CurrentFileProgressBar.Location = new System.Drawing.Point(15, 65);
            this.CurrentFileProgressBar.Name = "CurrentFileProgressBar";
            this.CurrentFileProgressBar.Size = new System.Drawing.Size(374, 23);
            this.CurrentFileProgressBar.Step = 1;
            this.CurrentFileProgressBar.TabIndex = 8;
            // 
            // AllFilesProgressBar
            // 
            this.AllFilesProgressBar.Location = new System.Drawing.Point(15, 95);
            this.AllFilesProgressBar.Name = "AllFilesProgressBar";
            this.AllFilesProgressBar.Size = new System.Drawing.Size(374, 23);
            this.AllFilesProgressBar.Step = 1;
            this.AllFilesProgressBar.TabIndex = 9;
            // 
            // StartButton
            // 
            this.StartButton.BackColor = System.Drawing.Color.SkyBlue;
            this.StartButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StartButton.Location = new System.Drawing.Point(63, 124);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(112, 33);
            this.StartButton.TabIndex = 10;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = false;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.BackColor = System.Drawing.Color.IndianRed;
            this.CancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CancelButton.Location = new System.Drawing.Point(208, 124);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(112, 33);
            this.CancelButton.TabIndex = 11;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = false;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // CopyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(401, 166);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.AllFilesProgressBar);
            this.Controls.Add(this.CurrentFileProgressBar);
            this.Controls.Add(this.allFilesLabel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.destinationLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.sourceLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.fileNameLabel);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(417, 205);
            this.MinimumSize = new System.Drawing.Size(417, 205);
            this.Name = "CopyForm";
            this.Text = "Копирование файла";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CopyForm_FormClosing);
            this.Load += new System.EventHandler(this.CopyForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label fileNameLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label sourceLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label destinationLabel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label allFilesLabel;
        private System.Windows.Forms.ProgressBar CurrentFileProgressBar;
        private System.Windows.Forms.ProgressBar AllFilesProgressBar;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Button CancelButton;
    }
}