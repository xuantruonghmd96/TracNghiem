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
        public static Color colorOn = System.Drawing.ColorTranslator.FromHtml("#E87E04");
        public static Color colorOff = System.Drawing.ColorTranslator.FromHtml("#E9D460");
        public static string fileNameDapAn = @"Sources/ans.ini";
        public static string fileNameDuLieuVung = @"Sources/dat.ini";
        public static string fileNameThietDat = @"Sources/set.ini";
        public static Color[] colorCheckBoxChonDapAn = { SystemColors.ActiveCaption, Color.FromArgb(249, 105, 14) };
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
                Width = 240,
                Height = 180,
                FormBorderStyle = FormBorderStyle.FixedToolWindow,
                Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))),
                Text = caption,
                StartPosition = FormStartPosition.CenterScreen
            };
            Label textLabel = new Label() { Left = 50, Top = 20, Text = text };
            TextBox textBox = new TextBox() { Left = 20, Top = 50, Width = 80 };
            Button confirmation = new Button() { Text = "Ok", Left = 50, AutoSize = true, Top = 80, DialogResult = DialogResult.OK };
            confirmation.Click += (sender, e) => { prompt.Close(); };

            textLabel.Left = (prompt.Width - textLabel.Width) / 2;
            textBox.Left = (prompt.Width - textBox.Width) / 2;
            confirmation.Left = (prompt.Width - confirmation.Width) / 2;
            prompt.Controls.Add(textBox);
            prompt.Controls.Add(confirmation);
            prompt.Controls.Add(textLabel);
            prompt.AcceptButton = confirmation;
            

            return prompt.ShowDialog() == DialogResult.OK ? textBox.Text : "-1";
        }
    }

    public static class PromptNumericUpDown
    {
        public static int ShowDialog(string text, string caption, int minimum, int maximum)
        {
            Form prompt = new Form()
            {
                Width = 240,
                Height = 180,
                FormBorderStyle = FormBorderStyle.FixedToolWindow,
                Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))),
                Text = caption,
                StartPosition = FormStartPosition.CenterScreen
            };
            Label textLabel = new Label() { Left = 50, Top = 20, Text = text };
            NumericUpDown num = new NumericUpDown() { Left = 20, Top = 50, Width = 80, Minimum = minimum, Maximum = maximum };
            Button confirmation = new Button() { Text = "Ok", Left = 50, AutoSize = true, Top = 80, DialogResult = DialogResult.OK };
            confirmation.Click += (sender, e) => { prompt.Close(); };

            textLabel.Left = (prompt.Width - textLabel.Width) / 2;
            num.Left = (prompt.Width - num.Width) / 2;
            confirmation.Left = (prompt.Width - confirmation.Width) / 2;
            prompt.Controls.Add(num);
            prompt.Controls.Add(confirmation);
            prompt.Controls.Add(textLabel);
            prompt.AcceptButton = confirmation;

            return (int)(prompt.ShowDialog() == DialogResult.OK ? num.Value : -1);
        }
    }
}
