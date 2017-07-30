using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnThiTracNghiem
{
    public class Contents
    {
        public static string fileNameDapAn = @"Sources/DapAn.txt";
        public static string fileNameDuLieuVung = @"Sources/DuLieuVung.txt";
        public static string fileNameThietDat = @"Sources/ThietDat.txt";
        public static Color[] colorCheckBoxChonDapAn = { SystemColors.ActiveCaption, Color.Orange };
        public static int[] locationYPanelChonDapAn = { 30, 240, 170, 100, 30 };
        public static string dauFileImage = @"Cau hoi/Cau ";
        public static string duoiFileImage = @".bmp";
    }

    public static class Prompt
    {
        public static string ShowDialog(string text, string caption)
        {
            Form prompt = new Form()
            {
                Width = 200,
                Height = 150,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                Text = caption,
                StartPosition = FormStartPosition.CenterScreen
            };
            Label textLabel = new Label() { Left = 50, Top = 20, Text = text };
            TextBox textBox = new TextBox() { Left = 20, Top = 50, Width = 140 };
            Button confirmation = new Button() { Text = "Ok", Left = 50, Width = 80, Top = 80, DialogResult = DialogResult.OK };
            confirmation.Click += (sender, e) => { prompt.Close(); };
            prompt.Controls.Add(textBox);
            prompt.Controls.Add(confirmation);
            prompt.Controls.Add(textLabel);
            prompt.AcceptButton = confirmation;

            return prompt.ShowDialog() == DialogResult.OK ? textBox.Text : "1";
        }
    }
}
