namespace FManagerApp.Forms
{
    partial class FileInfoForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FileInfoForm));
            this.lblInfo = new System.Windows.Forms.Label();
            this.gBoxControls = new System.Windows.Forms.GroupBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnMove = new System.Windows.Forms.Button();
            this.btnRename = new System.Windows.Forms.Button();
            this.btnCopy = new System.Windows.Forms.Button();
            this.btnInfoTXT = new System.Windows.Forms.Button();
            this.textPath = new System.Windows.Forms.TextBox();
            this.lblPath = new System.Windows.Forms.Label();
            this.btnOpen = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.gBoxControls.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblInfo.Location = new System.Drawing.Point(135, 36);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(0, 13);
            this.lblInfo.TabIndex = 22;
            // 
            // gBoxControls
            // 
            this.gBoxControls.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gBoxControls.BackColor = System.Drawing.Color.Transparent;
            this.gBoxControls.Controls.Add(this.btnDelete);
            this.gBoxControls.Controls.Add(this.btnMove);
            this.gBoxControls.Controls.Add(this.btnRename);
            this.gBoxControls.Controls.Add(this.btnCopy);
            this.gBoxControls.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.gBoxControls.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gBoxControls.Location = new System.Drawing.Point(19, 234);
            this.gBoxControls.Name = "gBoxControls";
            this.gBoxControls.Size = new System.Drawing.Size(389, 70);
            this.gBoxControls.TabIndex = 21;
            this.gBoxControls.TabStop = false;
            this.gBoxControls.Text = "Controls";
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnDelete.BackColor = System.Drawing.Color.IndianRed;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDelete.Location = new System.Drawing.Point(302, 19);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(81, 39);
            this.btnDelete.TabIndex = 16;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnMove
            // 
            this.btnMove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMove.BackColor = System.Drawing.Color.Aqua;
            this.btnMove.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnMove.Location = new System.Drawing.Point(106, 19);
            this.btnMove.Name = "btnMove";
            this.btnMove.Size = new System.Drawing.Size(83, 39);
            this.btnMove.TabIndex = 8;
            this.btnMove.Text = "Move";
            this.btnMove.UseVisualStyleBackColor = false;
            this.btnMove.Click += new System.EventHandler(this.btnMove_Click);
            // 
            // btnRename
            // 
            this.btnRename.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRename.BackColor = System.Drawing.Color.SpringGreen;
            this.btnRename.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnRename.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnRename.Location = new System.Drawing.Point(6, 19);
            this.btnRename.Name = "btnRename";
            this.btnRename.Size = new System.Drawing.Size(83, 39);
            this.btnRename.TabIndex = 7;
            this.btnRename.Text = "Rename";
            this.btnRename.UseVisualStyleBackColor = false;
            this.btnRename.Click += new System.EventHandler(this.btnRename_Click);
            // 
            // btnCopy
            // 
            this.btnCopy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCopy.BackColor = System.Drawing.Color.Gold;
            this.btnCopy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCopy.Location = new System.Drawing.Point(202, 19);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(83, 39);
            this.btnCopy.TabIndex = 9;
            this.btnCopy.Text = "Copy";
            this.btnCopy.UseVisualStyleBackColor = false;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // btnInfoTXT
            // 
            this.btnInfoTXT.BackColor = System.Drawing.Color.Bisque;
            this.btnInfoTXT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnInfoTXT.Location = new System.Drawing.Point(19, 181);
            this.btnInfoTXT.Name = "btnInfoTXT";
            this.btnInfoTXT.Size = new System.Drawing.Size(164, 37);
            this.btnInfoTXT.TabIndex = 18;
            this.btnInfoTXT.Text = "Information about .txt ";
            this.btnInfoTXT.UseVisualStyleBackColor = false;
            this.btnInfoTXT.Click += new System.EventHandler(this.btnInfoTXT_Click);
            // 
            // textPath
            // 
            this.textPath.BackColor = System.Drawing.Color.Gainsboro;
            this.textPath.Location = new System.Drawing.Point(71, 10);
            this.textPath.Name = "textPath";
            this.textPath.Size = new System.Drawing.Size(335, 20);
            this.textPath.TabIndex = 20;
            // 
            // lblPath
            // 
            this.lblPath.AutoSize = true;
            this.lblPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPath.Location = new System.Drawing.Point(22, 14);
            this.lblPath.Name = "lblPath";
            this.lblPath.Size = new System.Drawing.Size(43, 16);
            this.lblPath.TabIndex = 19;
            this.lblPath.Text = "Path:";
            // 
            // btnOpen
            // 
            this.btnOpen.BackColor = System.Drawing.Color.Gainsboro;
            this.btnOpen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnOpen.Location = new System.Drawing.Point(19, 36);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(110, 37);
            this.btnOpen.TabIndex = 17;
            this.btnOpen.Text = "Open file";
            this.btnOpen.UseVisualStyleBackColor = false;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth16Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Fuchsia;
            // 
            // FileInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(427, 315);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.gBoxControls);
            this.Controls.Add(this.btnInfoTXT);
            this.Controls.Add(this.textPath);
            this.Controls.Add(this.lblPath);
            this.Controls.Add(this.btnOpen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FileInfoForm";
            this.Text = "File Info";
            this.gBoxControls.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.GroupBox gBoxControls;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnMove;
        private System.Windows.Forms.Button btnRename;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.Button btnInfoTXT;
        private System.Windows.Forms.TextBox textPath;
        private System.Windows.Forms.Label lblPath;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}