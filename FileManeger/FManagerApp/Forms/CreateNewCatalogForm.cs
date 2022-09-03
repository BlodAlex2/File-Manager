using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FManagerApp.Forms
{
    public partial class CreateNewCatalogForm : Form
    {
        private List<FileSystemInfo> FilesAndDirectories;
        public CreateNewCatalogForm()
        {
            InitializeComponent();
        }//Инициализация формы
        public void SetParametres(List<FileSystemInfo> filesAndDirs)
        {
            this.FilesAndDirectories = filesAndDirs;
        }//Установка параметров
        private void CreateNewCatalogForm_Load(object sender, EventArgs e)
        {
            btnCancel.Enabled = true;
        }//Загрузка формы
        private CancellationTokenSource cts = new CancellationTokenSource();//Сигнал отмены
        private void btnOK_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (FileSystemInfo fsi in FilesAndDirectories)
                {
                        cts.Token.ThrowIfCancellationRequested();
                        DirectoryInfo dir = fsi as DirectoryInfo;
                        if (!dir.Exists)
                        {
                            dir.Create();
                        }
                        else
                        {
                            dir.CreateSubdirectory(textBoxNameCatalog.Text);
                        }
                }
                MessageBox.Show("Каталог создан!");
            }
            catch (OperationCanceledException)
            {
                MessageBox.Show("Операция отменена!");
            }
            finally
            {
                this.Close();
            }
        }//Кнопка ОК
        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (cts != null)
                cts.Cancel();
        }//Кнопка отмена
    }
}
