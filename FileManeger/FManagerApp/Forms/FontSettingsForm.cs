using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization;
using System.Xml;
using System.IO;

namespace FileManager.Forms
{
    public partial class FontSettingsForm : Form
    {
        public Settings fontSettings
        { get; private set; }
        public FontSettingsForm()
        {
            InitializeComponent();
        }//Инициализация формы
        private void FontColorButton_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            dialog.AllowFullOpen = true;
            dialog.FullOpen = true;
            dialog.Color = FontColorButton.BackColor;//Возвращает или задает цвет фона элемента управления
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                FontColorButton.BackColor = dialog.Color;
            }
        }//Кнопка смены цвета фрифта
        private void OKButton_Click(object sender, EventArgs e) 
        {
            short fontSize;
            if (!Int16.TryParse(FontSizeTextBox.Text, out fontSize))
            {
                MessageBox.Show("Введено неверное значение размера шрифта!");
                return;
            }
            else if (fontSize < 8 || fontSize > 20)
            {
                MessageBox.Show("Неверное значение размера шрифта!\nМиниально возможное 8, максимальное 20.");
                return;
            }

            fontSettings = new Settings(fontSize,FontColorButton.BackColor);

            FileStream writer = new FileStream("settings.xml", FileMode.Create, FileAccess.Write);
            DataContractSerializer ser =
                new DataContractSerializer(typeof(Settings));
            ser.WriteObject(writer, fontSettings);
            writer.Close();
            this.Close();
        }//Кнопка OK и смены размера шрифта
    }
}
