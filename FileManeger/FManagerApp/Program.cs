using System;
using System.Windows.Forms;

namespace FileManager
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1()); 
        }//Запуск главной формы
    }
}
