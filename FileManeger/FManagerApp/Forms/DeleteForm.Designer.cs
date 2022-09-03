namespace FileManager.Forms
{
    partial class DeleteForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeleteForm));
            this.CurrentFileProgressBar = new System.Windows.Forms.ProgressBar();
            this.StartButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CurrentFileProgressBar
            // 
            this.CurrentFileProgressBar.Location = new System.Drawing.Point(15, 12);
            this.CurrentFileProgressBar.Name = "CurrentFileProgressBar";
            this.CurrentFileProgressBar.Size = new System.Drawing.Size(374, 23);
            this.CurrentFileProgressBar.Step = 1;
            this.CurrentFileProgressBar.TabIndex = 10;
            // 
            // StartButton
            // 
            this.StartButton.BackColor = System.Drawing.Color.SkyBlue;
            this.StartButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StartButton.Location = new System.Drawing.Point(69, 41);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(112, 33);
            this.StartButton.TabIndex = 12;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = false;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.BackColor = System.Drawing.Color.IndianRed;
            this.CancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CancelButton.Location = new System.Drawing.Point(204, 41);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(112, 33);
            this.CancelButton.TabIndex = 13;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = false;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // DeleteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(401, 81);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.CurrentFileProgressBar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(417, 120);
            this.MinimumSize = new System.Drawing.Size(417, 120);
            this.Name = "DeleteForm";
            this.Text = "Удаление файлов";
            this.TransparencyKey = System.Drawing.Color.Red;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DeleteForm_FormClosing);
            this.Load += new System.EventHandler(this.DeleteForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ProgressBar CurrentFileProgressBar;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Button CancelButton;
    }
}