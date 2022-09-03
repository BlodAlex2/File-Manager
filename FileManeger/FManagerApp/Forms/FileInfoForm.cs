using FileManager;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FManagerApp.Forms
{
    public partial class FileInfoForm : Form
    {
        public FileInfoForm()
        {
            InitializeComponent();
            btnRename.Enabled = false;
            btnMove.Enabled = false;
            btnCopy.Enabled = false;
            btnInfoTXT.Enabled = false;
            btnDelete.Enabled = false;
        }//Создание формы
        FileInfo fileInfo;
        public bool existence_check(string fname)
        {
            if (File.Exists(fname))
            {
                return true;
            }
            else
            {
                MessageBox.Show("The file being analyzed has been moved or deleted.");
                return false;
            }
        }//Проверка существования файла
        public void updatefileInfo(string fname)
        {
            string tmp_fname = fileInfo.Name;
            if (tmp_fname.Length > 25)
            {
                tmp_fname = tmp_fname.Substring(0, 25);
            }

            textPath.Text = "File name:\n" + tmp_fname;

            if (fileInfo.Extension == ".txt")
            {
                btnInfoTXT.Enabled = true;
            }
            else
            {
                btnInfoTXT.Enabled = false;
            }
        }//Обновление
        private void btnOpen_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                fileInfo = new FileInfo(openFileDialog1.FileName);
                updatefileInfo(fileInfo.Name);
                lblInfo.Visible = true;
                lblInfo.Text = "File information:\n"
                    + "Size: " + fileInfo.Length.ToString() + " byte.\n"
                    + "Time of creation:    " + fileInfo.CreationTime.ToString() + "\n"
                    + "Changed: " + fileInfo.LastWriteTime.ToString() + "\n"
                    + "Open:    " + fileInfo.LastAccessTime.ToString() + "\n"
                    + "Attributes:    " + fileInfo.Attributes.ToString() + "\n"
                    + "Is Read Only:    " + fileInfo.IsReadOnly.ToString() + "\n"
                    + "Extension:    " + fileInfo.Extension.ToString() + "\n"
                    + "FullName:    " + fileInfo.FullName.ToString();
                btnRename.Enabled = true;
                btnMove.Enabled = true;
                btnCopy.Enabled = true;
                btnDelete.Enabled = true;
            }
        }//Открытие файла
        private void btnRename_Click(object sender, EventArgs e)
        {
            if (existence_check(fileInfo.FullName))
            {
                Rename form_rename = new Rename(); //Создаём форму 3 - окно переименования
                form_rename.textNewNameFile.Text = fileInfo.Name;
                form_rename.ShowDialog(); //выводим форму
                try
                {
                    fileInfo.MoveTo(fileInfo.DirectoryName + @"\" + form_rename.textNewNameFile.Text);
                    updatefileInfo(fileInfo.Name); //обновляем в программе название файла
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message.ToString());
                }
            }
        }//Переименование
        private void btnMove_Click(object sender, EventArgs e)
        {
            if (existence_check(fileInfo.FullName))
            {
                if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
                {
                    fileInfo.MoveTo(folderBrowserDialog1.SelectedPath + @"\" + fileInfo.Name);
                    MessageBox.Show("File moved to " + folderBrowserDialog1.SelectedPath.ToString());
                }

            }
        }//Перемещение
        private void btnCopy_Click(object sender, EventArgs e)
        {
            if (existence_check(fileInfo.FullName))
            {
                if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
                {
                    fileInfo.CopyTo(folderBrowserDialog1.SelectedPath + @"\" + fileInfo.Name);
                    MessageBox.Show("File copied to " + folderBrowserDialog1.SelectedPath.ToString());
                }

            }
        }//Копирование
        private void btnInfoTXT_Click(object sender, EventArgs e)
        {
            if (existence_check(fileInfo.FullName))
            {
                int slov = 0; //объявляем переменные для статистики
                int strok = 0;
                int sym = 0;
                int sym_all = 0;
                string cur_line = "";
                bool str_have_sym;

                TextReader reader = new StreamReader(fileInfo.OpenRead()); // создаём объект для чтение содержимого файла
                while (true)
                {
                    cur_line = reader.ReadLine(); //считываем 1 строку

                    if (cur_line != null) //Если строка существует
                    {
                        str_have_sym = false;

                        for (int i = 0; i < cur_line.Length; i++)
                        {
                            sym_all++; //считаем все символы

                            if (cur_line[i] == ' ') // Не является ли текущий символ пробелом?
                            {
                                if (((i + 1) < cur_line.Length) && (cur_line[i + 1] != ' ')) // если символ не является последним и не явл. пробелом
                                {
                                    slov++;
                                }

                            }
                            else
                            {
                                str_have_sym = true; //Строка имеет символы
                                sym++; //Считаем символы, без пробелов
                            }

                        }

                        if (str_have_sym == true)
                        {

                            slov++;
                        }

                        strok++;
                    }
                    {
                        break; //Выход из бесконечного цикла
                    }
                }

                reader.Close(); //Закрываем файл для чтения содержимого
                MessageBox.Show("Rows: " + strok.ToString() + "\n"
                    + "Words: " + slov.ToString() + "\n"
                    + "Characters in all: " + sym_all.ToString() + "\n"
                    + "Characters without spaces: " + sym.ToString() + "\n");

            }
        }//Информация о .txt файле 
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (existence_check(fileInfo.FullName))
            {
                File.Delete(fileInfo.FullName);
                MessageBox.Show("File successfully deleted.");
            }
        }//Удаление
    }
}
