namespace FileManager.Forms
{
    partial class FontSettingsForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.FontSizeTextBox = new System.Windows.Forms.TextBox();
            this.FontColorButton = new System.Windows.Forms.Button();
            this.OKButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(25, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Размер шрифта:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(25, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Цвет шрифта:";
            // 
            // FontSizeTextBox
            // 
            this.FontSizeTextBox.Location = new System.Drawing.Point(160, 28);
            this.FontSizeTextBox.Name = "FontSizeTextBox";
            this.FontSizeTextBox.Size = new System.Drawing.Size(48, 20);
            this.FontSizeTextBox.TabIndex = 2;
            // 
            // FontColorButton
            // 
            this.FontColorButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FontColorButton.Location = new System.Drawing.Point(160, 59);
            this.FontColorButton.Name = "FontColorButton";
            this.FontColorButton.Size = new System.Drawing.Size(48, 23);
            this.FontColorButton.TabIndex = 3;
            this.FontColorButton.UseVisualStyleBackColor = false;
            this.FontColorButton.Click += new System.EventHandler(this.FontColorButton_Click);
            // 
            // OKButton
            // 
            this.OKButton.BackColor = System.Drawing.Color.LimeGreen;
            this.OKButton.Location = new System.Drawing.Point(79, 97);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(75, 22);
            this.OKButton.TabIndex = 4;
            this.OKButton.Text = "OK";
            this.OKButton.UseVisualStyleBackColor = false;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // FontSettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(245, 131);
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this.FontColorButton);
            this.Controls.Add(this.FontSizeTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(261, 170);
            this.MinimumSize = new System.Drawing.Size(261, 170);
            this.Name = "FontSettingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Настройки шрифта";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox FontSizeTextBox;
        private System.Windows.Forms.Button FontColorButton;
        private System.Windows.Forms.Button OKButton;
    }
}