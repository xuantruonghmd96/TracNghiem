using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnThiTracNghiem
{
    public class DuLieuVung
    {
        private int soCau;
        private int soLanVung;
        private int soCauChuaVung;
        private List<int> duLieu;

        private NumericUpDown numSoLanVung;
        private Label lblSoCauChuaVung;

        public DuLieuVung(NumericUpDown numericSoLanVung, Label labelSoCauChuaVung)
        {
            numSoLanVung = numericSoLanVung;
            lblSoCauChuaVung = labelSoCauChuaVung;
        }

        public void LoadFile()
        {
            List<string> lines = File.ReadAllLines(Contents.fileNameDuLieuVung).ToList();
            List<string> a = lines[0].Split(' ').ToList();
            Int32.TryParse(a[0], out soCau);
            Int32.TryParse(a[1], out soLanVung);
            Int32.TryParse(a[2], out soCauChuaVung);

            lblSoCauChuaVung.Text = soCauChuaVung.ToString();
            numSoLanVung.Value = soLanVung;

            duLieu = new List<int>();
            for (int i=1; i<lines.Count(); i++)
                duLieu.Add(Int32.Parse(lines[i]));
        }

        public void SaveFile()
        {
            StreamWriter file = new StreamWriter(Contents.fileNameDuLieuVung);
            file.WriteLine("{0} {1} {2}", soCau, soLanVung, soCauChuaVung);
            for (int i=0; i<soCau; i++)
                file.WriteLine(duLieu[i]);
            file.Close();
            file.Dispose();
        }

        public void ThayDoiSoLanVung(int numericSoLanVung)
        {
            soLanVung = numericSoLanVung;
            soCauChuaVung = 0;
            for (int i=0; i<soCau; i++)
            {
                if (duLieu[i] < soLanVung)
                    soCauChuaVung++;
            }
            numSoLanVung.Value = soLanVung;
            lblSoCauChuaVung.Text = soCauChuaVung.ToString();
            SaveFile();
        }

        public bool CoThayDoiSoLanVung(int numericSoLanVung)
        {
            return numericSoLanVung != soLanVung;
        }
    }
}
