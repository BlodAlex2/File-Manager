namespace FileManager
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.LeftPanel = new System.Windows.Forms.Panel();
            this.LeftDrivesPanel = new System.Windows.Forms.Panel();
            this.textBoxLeftPath = new System.Windows.Forms.TextBox();
            this.LeftListView = new System.Windows.Forms.ListView();
            this.NameHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TypeHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SizeHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DateHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.IconsImageList = new System.Windows.Forms.ImageList(this.components);
            this.LeftPathTextBox = new System.Windows.Forms.TextBox();
            this.ShowButton = new System.Windows.Forms.Button();
            this.CopyButton = new System.Windows.Forms.Button();
            this.MoveButton = new System.Windows.Forms.Button();
            this.RenameButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.RightPanel = new System.Windows.Forms.Panel();
            this.RightListView = new System.Windows.Forms.ListView();
            this.NameHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TypeHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SizeHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DateHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.RightPathTextBox = new System.Windows.Forms.TextBox();
            this.BottomPanel = new System.Windows.Forms.Panel();
            this.RightDrivesPanel = new System.Windows.Forms.Panel();
            this.textBoxRightPath = new System.Windows.Forms.TextBox();
            this.MainMenu = new System.Windows.Forms.MenuStrip();
            this.настройкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FontSettingsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCreateCatalog = new System.Windows.Forms.Button();
            this.LeftPanel.SuspendLayout();
            this.LeftDrivesPanel.SuspendLayout();
            this.RightPanel.SuspendLayout();
            this.BottomPanel.SuspendLayout();
            this.RightDrivesPanel.SuspendLayout();
            this.MainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // LeftPanel
            // 
            this.LeftPanel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LeftPanel.Controls.Add(this.LeftDrivesPanel);
            this.LeftPanel.Controls.Add(this.LeftListView);
            this.LeftPanel.Controls.Add(this.LeftPathTextBox);
            this.LeftPanel.Location = new System.Drawing.Point(12, 33);
            this.LeftPanel.Name = "LeftPanel";
            this.LeftPanel.Size = new System.Drawing.Size(456, 495);
            this.LeftPanel.TabIndex = 0;
            // 
            // LeftDrivesPanel
            // 
            this.LeftDrivesPanel.BackColor = System.Drawing.Color.Black;
            this.LeftDrivesPanel.Controls.Add(this.textBoxLeftPath);
            this.LeftDrivesPanel.Location = new System.Drawing.Point(0, 0);
            this.LeftDrivesPanel.Name = "LeftDrivesPanel";
            this.LeftDrivesPanel.Size = new System.Drawing.Size(456, 33);
            this.LeftDrivesPanel.TabIndex = 6;
            // 
            // textBoxLeftPath
            // 
            this.textBoxLeftPath.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBoxLeftPath.Location = new System.Drawing.Point(190, 7);
            this.textBoxLeftPath.Name = "textBoxLeftPath";
            this.textBoxLeftPath.Size = new System.Drawing.Size(261, 20);
            this.textBoxLeftPath.TabIndex = 0;
            // 
            // LeftListView
            // 
            this.LeftListView.BackColor = System.Drawing.Color.White;
            this.LeftListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.NameHeader,
            this.TypeHeader,
            this.SizeHeader,
            this.DateHeader});
            this.LeftListView.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LeftListView.FullRowSelect = true;
            this.LeftListView.GridLines = true;
            this.LeftListView.HideSelection = false;
            this.LeftListView.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LeftListView.Location = new System.Drawing.Point(3, 60);
            this.LeftListView.Name = "LeftListView";
            this.LeftListView.Size = new System.Drawing.Size(448, 432);
            this.LeftListView.SmallImageList = this.IconsImageList;
            this.LeftListView.TabIndex = 5;
            this.LeftListView.UseCompatibleStateImageBehavior = false;
            this.LeftListView.View = System.Windows.Forms.View.Details;
            this.LeftListView.Enter += new System.EventHandler(this.LeftListView_Enter);
            this.LeftListView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.LeftListView_MouseDoubleClick);
            // 
            // NameHeader
            // 
            this.NameHeader.Text = "Имя";
            this.NameHeader.Width = 130;
            // 
            // TypeHeader
            // 
            this.TypeHeader.Text = "Тип";
            this.TypeHeader.Width = 66;
            // 
            // SizeHeader
            // 
            this.SizeHeader.Text = "Размер";
            this.SizeHeader.Width = 76;
            // 
            // DateHeader
            // 
            this.DateHeader.Text = "Дата";
            this.DateHeader.Width = 172;
            // 
            // IconsImageList
            // 
            this.IconsImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("IconsImageList.ImageStream")));
            this.IconsImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.IconsImageList.Images.SetKeyName(0, "folder.ico");
            this.IconsImageList.Images.SetKeyName(1, "file (1).ico");
            this.IconsImageList.Images.SetKeyName(2, "folder.png");
            // 
            // LeftPathTextBox
            // 
            this.LeftPathTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LeftPathTextBox.Location = new System.Drawing.Point(3, 33);
            this.LeftPathTextBox.Name = "LeftPathTextBox";
            this.LeftPathTextBox.Size = new System.Drawing.Size(448, 20);
            this.LeftPathTextBox.TabIndex = 1;
            this.LeftPathTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.LeftPathTextBox_KeyDown);
            // 
            // ShowButton
            // 
            this.ShowButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ShowButton.Font = new System.Drawing.Font("Rockwell", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowButton.Location = new System.Drawing.Point(4, 4);
            this.ShowButton.Name = "ShowButton";
            this.ShowButton.Size = new System.Drawing.Size(148, 45);
            this.ShowButton.TabIndex = 2;
            this.ShowButton.Text = "F3 Детальная информация о  файлах";
            this.ShowButton.UseVisualStyleBackColor = false;
            this.ShowButton.Click += new System.EventHandler(this.FileInfoFormButton_Click);
            // 
            // CopyButton
            // 
            this.CopyButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.CopyButton.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CopyButton.Location = new System.Drawing.Point(312, 4);
            this.CopyButton.Name = "CopyButton";
            this.CopyButton.Size = new System.Drawing.Size(148, 45);
            this.CopyButton.TabIndex = 3;
            this.CopyButton.Text = "F5 Копирование";
            this.CopyButton.UseVisualStyleBackColor = false;
            this.CopyButton.Click += new System.EventHandler(this.CopyButton_Click);
            // 
            // MoveButton
            // 
            this.MoveButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.MoveButton.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MoveButton.Location = new System.Drawing.Point(466, 4);
            this.MoveButton.Name = "MoveButton";
            this.MoveButton.Size = new System.Drawing.Size(148, 45);
            this.MoveButton.TabIndex = 4;
            this.MoveButton.Text = "F6 Перемещение";
            this.MoveButton.UseVisualStyleBackColor = false;
            this.MoveButton.Click += new System.EventHandler(this.MoveButton_Click);
            // 
            // RenameButton
            // 
            this.RenameButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.RenameButton.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RenameButton.Location = new System.Drawing.Point(158, 4);
            this.RenameButton.Name = "RenameButton";
            this.RenameButton.Size = new System.Drawing.Size(148, 45);
            this.RenameButton.TabIndex = 5;
            this.RenameButton.Text = "F4 Переименование";
            this.RenameButton.UseVisualStyleBackColor = false;
            this.RenameButton.Click += new System.EventHandler(this.RenameButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.DeleteButton.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteButton.Location = new System.Drawing.Point(774, 4);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(148, 45);
            this.DeleteButton.TabIndex = 6;
            this.DeleteButton.Text = "F8 Удаление";
            this.DeleteButton.UseVisualStyleBackColor = false;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // RightPanel
            // 
            this.RightPanel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.RightPanel.Controls.Add(this.RightListView);
            this.RightPanel.Controls.Add(this.RightPathTextBox);
            this.RightPanel.Location = new System.Drawing.Point(484, 33);
            this.RightPanel.Name = "RightPanel";
            this.RightPanel.Size = new System.Drawing.Size(457, 495);
            this.RightPanel.TabIndex = 7;
            // 
            // RightListView
            // 
            this.RightListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.NameHeader1,
            this.TypeHeader2,
            this.SizeHeader3,
            this.DateHeader4});
            this.RightListView.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RightListView.FullRowSelect = true;
            this.RightListView.GridLines = true;
            this.RightListView.HideSelection = false;
            this.RightListView.Location = new System.Drawing.Point(5, 60);
            this.RightListView.Name = "RightListView";
            this.RightListView.Size = new System.Drawing.Size(449, 432);
            this.RightListView.SmallImageList = this.IconsImageList;
            this.RightListView.TabIndex = 7;
            this.RightListView.UseCompatibleStateImageBehavior = false;
            this.RightListView.View = System.Windows.Forms.View.Details;
            this.RightListView.Enter += new System.EventHandler(this.RightListView_Enter);
            this.RightListView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.RightListView_MouseDoubleClick);
            // 
            // NameHeader1
            // 
            this.NameHeader1.Text = "Имя";
            this.NameHeader1.Width = 186;
            // 
            // TypeHeader2
            // 
            this.TypeHeader2.Text = "Тип";
            this.TypeHeader2.Width = 66;
            // 
            // SizeHeader3
            // 
            this.SizeHeader3.Text = "Размер";
            this.SizeHeader3.Width = 91;
            // 
            // DateHeader4
            // 
            this.DateHeader4.Text = "Дата";
            this.DateHeader4.Width = 100;
            // 
            // RightPathTextBox
            // 
            this.RightPathTextBox.Location = new System.Drawing.Point(5, 33);
            this.RightPathTextBox.Name = "RightPathTextBox";
            this.RightPathTextBox.Size = new System.Drawing.Size(449, 20);
            this.RightPathTextBox.TabIndex = 2;
            this.RightPathTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.RightPathTextBox_KeyDown);
            // 
            // BottomPanel
            // 
            this.BottomPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BottomPanel.AutoSize = true;
            this.BottomPanel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BottomPanel.Controls.Add(this.btnCreateCatalog);
            this.BottomPanel.Controls.Add(this.ShowButton);
            this.BottomPanel.Controls.Add(this.DeleteButton);
            this.BottomPanel.Controls.Add(this.CopyButton);
            this.BottomPanel.Controls.Add(this.RenameButton);
            this.BottomPanel.Controls.Add(this.MoveButton);
            this.BottomPanel.Location = new System.Drawing.Point(12, 536);
            this.BottomPanel.Name = "BottomPanel";
            this.BottomPanel.Size = new System.Drawing.Size(926, 53);
            this.BottomPanel.TabIndex = 8;
            // 
            // RightDrivesPanel
            // 
            this.RightDrivesPanel.BackColor = System.Drawing.Color.Black;
            this.RightDrivesPanel.Controls.Add(this.textBoxRightPath);
            this.RightDrivesPanel.Location = new System.Drawing.Point(484, 33);
            this.RightDrivesPanel.Name = "RightDrivesPanel";
            this.RightDrivesPanel.Size = new System.Drawing.Size(457, 33);
            this.RightDrivesPanel.TabIndex = 8;
            // 
            // textBoxRightPath
            // 
            this.textBoxRightPath.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBoxRightPath.Location = new System.Drawing.Point(193, 7);
            this.textBoxRightPath.Name = "textBoxRightPath";
            this.textBoxRightPath.Size = new System.Drawing.Size(261, 20);
            this.textBoxRightPath.TabIndex = 10;
            // 
            // MainMenu
            // 
            this.MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.настройкиToolStripMenuItem});
            this.MainMenu.Location = new System.Drawing.Point(0, 0);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.MainMenu.Size = new System.Drawing.Size(954, 24);
            this.MainMenu.TabIndex = 9;
            this.MainMenu.Text = "menuStrip1";
            // 
            // настройкиToolStripMenuItem
            // 
            this.настройкиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FontSettingsMenuItem});
            this.настройкиToolStripMenuItem.Name = "настройкиToolStripMenuItem";
            this.настройкиToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.настройкиToolStripMenuItem.Text = "Настройки";
            // 
            // FontSettingsMenuItem
            // 
            this.FontSettingsMenuItem.Name = "FontSettingsMenuItem";
            this.FontSettingsMenuItem.Size = new System.Drawing.Size(182, 22);
            this.FontSettingsMenuItem.Text = "Настройки шрифта";
            this.FontSettingsMenuItem.Click += new System.EventHandler(this.FontSettingsMenuItem_Click);
            // 
            // btnCreateCatalog
            // 
            this.btnCreateCatalog.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateCatalog.Location = new System.Drawing.Point(620, 4);
            this.btnCreateCatalog.Name = "btnCreateCatalog";
            this.btnCreateCatalog.Size = new System.Drawing.Size(148, 45);
            this.btnCreateCatalog.TabIndex = 10;
            this.btnCreateCatalog.Text = "F7 Каталог";
            this.btnCreateCatalog.UseVisualStyleBackColor = true;
            this.btnCreateCatalog.Click += new System.EventHandler(this.btnCreateCatalog_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.ClientSize = new System.Drawing.Size(954, 594);
            this.Controls.Add(this.RightDrivesPanel);
            this.Controls.Add(this.RightPanel);
            this.Controls.Add(this.LeftPanel);
            this.Controls.Add(this.BottomPanel);
            this.Controls.Add(this.MainMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MainMenuStrip = this.MainMenu;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "File Manager";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.LeftPanel.ResumeLayout(false);
            this.LeftPanel.PerformLayout();
            this.LeftDrivesPanel.ResumeLayout(false);
            this.LeftDrivesPanel.PerformLayout();
            this.RightPanel.ResumeLayout(false);
            this.RightPanel.PerformLayout();
            this.BottomPanel.ResumeLayout(false);
            this.RightDrivesPanel.ResumeLayout(false);
            this.RightDrivesPanel.PerformLayout();
            this.MainMenu.ResumeLayout(false);
            this.MainMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel LeftPanel;
        private System.Windows.Forms.Button ShowButton;
        private System.Windows.Forms.Button CopyButton;
        private System.Windows.Forms.Button MoveButton;
        private System.Windows.Forms.Button RenameButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Panel RightPanel;
        private System.Windows.Forms.TextBox LeftPathTextBox;
        private System.Windows.Forms.TextBox RightPathTextBox;
        private System.Windows.Forms.Panel BottomPanel;
        private System.Windows.Forms.ListView LeftListView;
        private System.Windows.Forms.ColumnHeader NameHeader;
        private System.Windows.Forms.ColumnHeader TypeHeader;
        private System.Windows.Forms.ColumnHeader SizeHeader;
        private System.Windows.Forms.ColumnHeader DateHeader;
        private System.Windows.Forms.ListView RightListView;
        private System.Windows.Forms.ColumnHeader NameHeader1;
        private System.Windows.Forms.ColumnHeader TypeHeader2;
        private System.Windows.Forms.ColumnHeader SizeHeader3;
        private System.Windows.Forms.ColumnHeader DateHeader4;
        private System.Windows.Forms.Panel LeftDrivesPanel;
        private System.Windows.Forms.Panel RightDrivesPanel;
        private System.Windows.Forms.MenuStrip MainMenu;
        private System.Windows.Forms.ToolStripMenuItem настройкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem FontSettingsMenuItem;
        private System.Windows.Forms.ImageList IconsImageList;
        private System.Windows.Forms.TextBox textBoxLeftPath;
        private System.Windows.Forms.TextBox textBoxRightPath;
        private System.Windows.Forms.Button btnCreateCatalog;
    }
}

