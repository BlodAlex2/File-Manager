using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FileManager
{
    public partial class Rename : Form
    {
        string newName;
        public Rename()
        {
            InitializeComponent();
        }
        private void btnApply_Click(object sender, EventArgs e)
        {
            newName = textNewNameFile.Text;
            this.Close();
        }//Применение
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }//Отмена
        
    }
}
