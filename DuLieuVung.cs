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

        public List<int> DuLieu
        {
            get
            {
                return duLieu;
            }

            set
            {
                duLieu = value;
            }
        }

        public int SoCauChuaVung
        {
            get
            {
                return soCauChuaVung;
            }

            set
            {
                soCauChuaVung = value;
            }
        }

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

            lblSoCauChuaVung.Text = SoCauChuaVung.ToString();
            numSoLanVung.Value = soLanVung;

            DuLieu = new List<int>();
            for (int i=1; i<lines.Count(); i++)
                DuLieu.Add(Int32.Parse(lines[i]));
        }

        public void SaveFile()
        {
            StreamWriter file = new StreamWriter(Contents.fileNameDuLieuVung);
            file.WriteLine("{0} {1} {2}", soCau, soLanVung, SoCauChuaVung);
            for (int i=0; i<soCau; i++)
                file.WriteLine(DuLieu[i]);
            file.Close();
            file.Dispose();
        }

        public void Tang1LanTraLoiDung(int cau)
        {
            duLieu[cau]++;
            if (duLieu[cau] == soLanVung)
            {
                soCauChuaVung--;
                lblSoCauChuaVung.Text = soCauChuaVung.ToString();
            }
        }

        public void ThayDoiSoLanVung(int numericSoLanVung)
        {
            soLanVung = numericSoLanVung;
            SoCauChuaVung = 0;
            for (int i=0; i<soCau; i++)
            {
                if (DuLieu[i] < soLanVung)
                    SoCauChuaVung++;
            }
            numSoLanVung.Value = soLanVung;
            lblSoCauChuaVung.Text = SoCauChuaVung.ToString();
            SaveFile();
        }

        public bool CoThayDoiSoLanVung(int numericSoLanVung)
        {
            return numericSoLanVung != soLanVung;
        }

        public void ResetAll()
        {
            SoCauChuaVung = soCau;
            for (int i = 0; i < soCau; i++)
                DuLieu[i] = 0;
            lblSoCauChuaVung.Text = SoCauChuaVung.ToString();
        }

        public void ResetCau(int cau)
        {
            if (DuLieu[cau] >= soLanVung)
                SoCauChuaVung++;
            DuLieu[cau] = 0;
            lblSoCauChuaVung.Text = SoCauChuaVung.ToString();
        }
    }
}
