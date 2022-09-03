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
    public partial class CopyForm : Form
    {
        private const int BUFFER_LENGTH = 12228;
        private List<FileSystemInfo> FilesAndDirectories;
        private string Source;
        private string Destination;
        private long TotalSize;
        private long TotalFilesCount;
        private long CopiedFilesCount;
        private long CopiedFilesSize;
        public CopyForm()
        {
            InitializeComponent();
        }//Инициализация формы
        public void SetParametres(List<FileSystemInfo> filesAndDirs, string source, string destination)
        {
            this.FilesAndDirectories = filesAndDirs;
            this.Source = source;
            this.Destination = destination;
        }//Установка параметров
        private void CopyForm_Load(object sender, EventArgs e)
        {
            long filesCount = 0;
            TotalSize = GetAllFilesSize(ref filesCount);
            TotalFilesCount = filesCount;
            CopiedFilesCount = 0;
            CopiedFilesSize = 0;
            allFilesLabel.Text = 0 + "/" + TotalFilesCount;
            sourceLabel.Text = Source;
            destinationLabel.Text = Destination;
            fileNameLabel.Text = "";
            CancelButton.Enabled = false;
        }//Загрузка формы
        private long GetAllFilesSize(ref long filesCount)
        {
            long size = 0;
            try
            {
                foreach (FileSystemInfo fsi in FilesAndDirectories)
                {
                    DirectoryInfo dir = fsi as DirectoryInfo;
                    if (dir != null)
                    {
                        size += GetDirSize(dir, ref filesCount);
                    }
                    else
                    {
                        FileInfo fileInfo = fsi as FileInfo;
                        filesCount++;
                        size += fileInfo.Length;//Получение размера текущего файла в байтах
                    }
                }
            }
            catch (UnauthorizedAccessException)
            {
                MessageBox.Show("Отказано в доступе!");
                this.Close();
            }
            return size;
        }//Получение общего размера всех копируемых файлов, и их количества
        private long GetDirSize(DirectoryInfo directory, ref long filesCount)
        {
            long size = 0;
            DirectoryInfo[] dirs = directory.GetDirectories();//Возврящает подкаталоги текущего каталога
            FileInfo[] files = directory.GetFiles();//Возврящает списов файлов текущего каталога
            if (dirs != null)
            {
                foreach (DirectoryInfo dir in dirs)
                {
                    size += GetDirSize(dir, ref filesCount);
                }
            }
            foreach (FileInfo file in files)
            {
                size += file.Length;
                filesCount++;
            }
            return size;
        }//получение размера директории (рекурсивный алгоритм)
        private class ProgressState
        {
            public IProgress<int> progressCurrentFile;
            public IProgress<string> currentFileNameProgress;
            public IProgress<int> progressAllFiles;
        }//Прогресс выполнения копирования
        private CancellationTokenSource _cts;//Сигнал отмены
        private async void StartButton_Click(object sender, EventArgs e)
        {
            ProgressState progressState = new ProgressState();
            StartButton.Enabled = false;
            CancelButton.Enabled = true;
            _cts = new CancellationTokenSource();
            var token = _cts.Token;

            var progressHandlerForCurrentFile = new Progress<int>(value =>{ CurrentFileProgressBar.Value = value; });

            progressState.progressCurrentFile = progressHandlerForCurrentFile as IProgress<int>;

            var fileNameProgressHandler = new Progress<string>(value =>
            {
                CopiedFilesCount++;
                fileNameLabel.Text = value.ToString();
                allFilesLabel.Text = CopiedFilesCount.ToString() + "/" + TotalFilesCount;
            });

            progressState.currentFileNameProgress = fileNameProgressHandler as IProgress<string>;

            var progressHandlerForAllFiles = new Progress<int>(value =>
            {
                CopiedFilesSize += value;
                double progress;
                if (TotalSize != 0)
                {
                    progress = (double)CopiedFilesSize / TotalSize * 100;
                    if (progress > 100) progress = 100;
                }
                else
                {
                    progress = 100;
                    AllFilesProgressBar.Value = (int)Math.Round(progress);
                }  
            });

            progressState.progressAllFiles = progressHandlerForAllFiles as IProgress<int>;

            try
            {
                await Task.Run(() =>
                {
                    foreach (FileSystemInfo fsi in FilesAndDirectories)
                    {
                        token.ThrowIfCancellationRequested();
                        DirectoryInfo dir = fsi as DirectoryInfo;
                        if (dir != null)
                        {
                            //копируем директорию
                            CopyDirectory(dir, Destination, progressState);
                        }
                        else
                        {
                            //копируем файл
                            FileInfo fileInfo = fsi as FileInfo;
                            progressState.currentFileNameProgress.Report(fileInfo.Name);
                            CopyFile(fileInfo.FullName, Path.Combine(Destination, Path.GetFileName(fileInfo.Name)),progressState);
                        }
                    }
                });
                MessageBox.Show("Копирование завершено!");
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

        }//Кнопка начала копирования
        private void CancelButton_Click(object sender, EventArgs e)
        {
            if (_cts != null)
                _cts.Cancel();
        }//Кнопка отмены копирования
        private void CopyForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_cts != null)
                _cts.Cancel();
        }//Отмена
        private void CopyDirectory(DirectoryInfo sourceDir, string destination, ProgressState progressState)
        {
            string path = Path.Combine(destination, sourceDir.Name);//Объединение двух строк в путь
            DirectoryInfo destDir = new DirectoryInfo(path);
            if (Directory.Exists(path))
            {
                var result = MessageBox.Show("Директория с таким именем уже существует. Выполнить слияние файлов и папок?", "", MessageBoxButtons.YesNo);
                if (result == DialogResult.No)
                {
                    _cts.Cancel();
                    _cts.Token.ThrowIfCancellationRequested();
                }
            }
            else
            {
                destDir.Create();
            }
            foreach (DirectoryInfo dir in sourceDir.GetDirectories())
            {
                CopyDirectory(dir, destDir.FullName, progressState);
            }
            foreach (FileInfo file in sourceDir.GetFiles())
            {
                CopyFile(file.FullName, Path.Combine(destDir.FullName, Path.GetFileName(file.Name)), progressState);
            }

        }//Механизм копирования директории
        private void CopyFile(string source, string destination, ProgressState progressState)
        {
            FileStream sourceStream = null;
            FileStream destinationStream = null;
            try
            {
                progressState.currentFileNameProgress.Report(Path.GetFileName(source));

                long totalBytesRead = 0;

                Byte[] streamBuffer = new Byte[BUFFER_LENGTH];

                sourceStream = new FileStream(source, FileMode.Open, FileAccess.Read);
                long fileSize = sourceStream.Length;
                destinationStream = new FileStream(destination, FileMode.Create, FileAccess.Write);
                int progress = 0;
                progressState.progressCurrentFile.Report(progress);
                int bytesRead = 0;
                while (true)
                {
                    _cts.Token.ThrowIfCancellationRequested();
                    bytesRead = sourceStream.Read(streamBuffer, 0, BUFFER_LENGTH);
                    if (fileSize != 0)
                    {
                        progress = (int)Math.Round(100 * (double)totalBytesRead / fileSize);
                        /*if (progress == 101)
                            progress--;*/
                    }
                    else
                    {
                        progress = 100;
                        progressState.progressCurrentFile.Report(progress);
                        progressState.progressAllFiles.Report(0);
                        break;
                    }
                    if (bytesRead == 0)
                    {
                        // если ничего не считали
                        progressState.progressCurrentFile.Report(progress);
                        break;
                    }
                    destinationStream.Write(streamBuffer, 0, bytesRead);
                    progressState.progressCurrentFile.Report(progress);
                    progressState.progressAllFiles.Report(bytesRead);
                    totalBytesRead += bytesRead;

                    if (bytesRead < BUFFER_LENGTH)
                    {
                        // конец
                        progressState.progressCurrentFile.Report(100);
                        progressState.progressAllFiles.Report(bytesRead);
                        break;
                    }
                }

            }
            catch (OperationCanceledException)
            {
                _cts.Cancel();
                _cts.Token.ThrowIfCancellationRequested();
            }
            catch (Exception e)
            {
                MessageBox.Show("Ошибка при копировании файла:\n" + e.Message);
                _cts.Cancel();
                _cts.Token.ThrowIfCancellationRequested();
            }
            finally
            {
                if (sourceStream != null) sourceStream.Close();
                if (destinationStream != null) destinationStream.Close();
            }
        }//Механизм копирования файла
    }
}
