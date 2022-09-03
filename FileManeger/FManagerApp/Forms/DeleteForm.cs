using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Threading;

namespace FileManager.Forms
{
    public partial class DeleteForm : Form
    {
        private List<FileSystemInfo> FilesAndDirectories;
        public DeleteForm()
        {
            InitializeComponent();
        }//Инициализация формы
        public void SetParametres(List<FileSystemInfo> filesAndDirs)
        {
            this.FilesAndDirectories = filesAndDirs;
        }//Установка параметров
        private void DeleteForm_Load(object sender, EventArgs e)
        {
            CancelButton.Enabled = false;
        }//Загрузка формы
        private CancellationTokenSource cts = new CancellationTokenSource();//Сигнал отмены
        private async void StartButton_Click(object sender, EventArgs e)
        {
            StartButton.Enabled = false;
            CancelButton.Enabled = true;
            var progressHandlerForCurrentFile = new Progress<int>(value =>
            {
                CurrentFileProgressBar.Value = value;
            });
            IProgress<int> progressCurrentFile = progressHandlerForCurrentFile as IProgress<int>;

            try
            {
                await Task.Run(() =>
                {
                    int progress = 0;
                    double count = 0;
                    foreach (FileSystemInfo fsi in FilesAndDirectories)
                    {
                        cts.Token.ThrowIfCancellationRequested();
                        DirectoryInfo dir = fsi as DirectoryInfo;
                        if (dir != null)
                        {
                            //удаляем директорию
                            dir.Delete(true);
                        }
                        else
                        {
                            // удаляем файл
                            FileInfo fileInfo = fsi as FileInfo;
                            fileInfo.Delete();
                        }
                        count++;
                        progress = (int)Math.Round(100 *count/FilesAndDirectories.Count);
                        progressCurrentFile.Report(progress);
                    }
                });

                MessageBox.Show("Удаление завершено!");
            }
            catch (OperationCanceledException)
            {
                MessageBox.Show("Операция отменена!");
            }
            finally
            {
                this.Dispose();
                this.Close();
            }
        }//Кнопка начала удаления
        private void CancelButton_Click(object sender, EventArgs e)
        {
            if (cts != null)
                cts.Cancel();
        }//Кнопка отмены удаления
        private void DeleteForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (cts != null)
                cts.Cancel();
        }//Отмена
    }
}
