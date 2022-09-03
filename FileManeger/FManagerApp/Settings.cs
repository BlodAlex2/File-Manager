using System.Drawing;
using System.Runtime.Serialization;

namespace FileManager
{
    [DataContract(Name = "Settings")]
    public class Settings
    {
        [DataMember(Name = "FontSize")]
        public short FontSize
        { get;  private set; }
        [DataMember(Name = "FontColor")]
        public Color FontColor
        { get; private set; }
        public Settings() { }
        public Settings(short fontSize, Color fontColor)
        {
            FontSize = fontSize;
            FontColor = fontColor;
        }//Настройка шрифтов и цветов
    }
}
