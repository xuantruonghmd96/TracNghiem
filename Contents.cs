using System;
using System.Drawing;
using System.Windows.Forms;

namespace OnThiTracNghiem
{
    public class Contents
    {
        public static string sourcesPath = @"data/";
        public static string answerFilePath = @"ans.ini";
        public static string studyDataFilePath = @"dat.ini";
        public static string settingFilePath = @"set.ini";
        public static string subjectsFilePath = @"sub.ini";
        public static Color colorOn = ColorTranslator.FromHtml("#E87E04");
        public static Color colorOff = ColorTranslator.FromHtml("#E9D460");
        public static Color[] colorCheckBoxChonDapAn = { SystemColors.ActiveCaption, Color.FromArgb(249, 105, 14) };
        public static int[] locationYPanelChonDapAn = { 30, 240, 170, 100, 30 };
        public static string dauFileImage = @"question/Cau ";
        public static string duoiFileImageDefault = @".jpg";
        public static int soCauMacDinh = 1;

        public static string GetDuoiFileImage(ThietDat thietDat)
        {
            return thietDat.DuoiFileImage;
        }

        public static Bitmap SetUpPictures(PictureBox pb)
        {
            //create a bitmap to display
            Bitmap bmp1 = new Bitmap(pb.ClientSize.Width, pb.ClientSize.Height);
            Random _rnd = new Random();

            //get the graphics-context
            using (Graphics g = Graphics.FromImage(bmp1))
            {
                //get a random, opaque, color
                Color c = Color.FromArgb(255, _rnd.Next(256), _rnd.Next(256), _rnd.Next(256));
                g.Clear(c);

                //better smoothinmode for round shapes
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

                //draw ten shapes to the bitmap
                for (int i = 0; i < 10; i++)
                {
                    //loaction and size rectangle
                    Rectangle r = new Rectangle(_rnd.Next(pb.ClientSize.Width / 2), _rnd.Next(pb.ClientSize.Height / 2),
                        _rnd.Next(pb.ClientSize.Width / 2), _rnd.Next(pb.ClientSize.Height / 2));

                    //random color
                    Color c2 = Color.FromArgb(_rnd.Next(256), _rnd.Next(256), _rnd.Next(256), _rnd.Next(256));

                    //one color brush
                    using (SolidBrush sb = new SolidBrush(c2))
                    {
                        //check, if i is odd or even and decide on that to draw rectangles or ellipses
                        if ((i & 0x01) == 1)
                            g.FillEllipse(sb, r);
                        else
                            g.FillRectangle(sb, r);
                    }
                }
            }

            //return our artwork
            return bmp1;
        }

        public static void TaoMacDinhDuLieuSources(string subjectFolder)
        {
            //File.Create(Contents.SourcesPath + subjectFolder + @"/" + Contents.fileNameDuLieuVung);
            DuLieuVung.SaveFileMacDinh(Contents.soCauMacDinh, subjectFolder);

            //File.Create(Contents.SourcesPath + subjectFolder + @"/" + Contents.fileNameDapAn);
            DapAn.SaveFileMacDinh(subjectFolder, Contents.soCauMacDinh);

            //File.Create(Contents.SourcesPath + subjectFolder + @"/" + Contents.fileNameThietDat);
            ThietDat.SaveFileMacDinh(subjectFolder);
        }
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
                Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0),
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
                Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0),
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
