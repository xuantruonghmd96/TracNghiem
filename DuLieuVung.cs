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
        private string subjectFolder;

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

        public int SoCau
        {
            get
            {
                return soCau;
            }

            set
            {
                soCau = value;
            }
        }

        public int SoLanVung
        {
            get
            {
                return soLanVung;
            }

            set
            {
                soLanVung = value;
            }
        }

        public DuLieuVung(NumericUpDown numericSoLanVung, Label labelSoCauChuaVung, string subjectFolder)
        {
            numSoLanVung = numericSoLanVung;
            lblSoCauChuaVung = labelSoCauChuaVung;
            this.subjectFolder = subjectFolder;
        }

        public void LoadFile()
        {
            if (!File.Exists(Contents.SourcesPath + subjectFolder + @"/" + Contents.fileNameDuLieuVung))
                Contents.TaoMacDinhDuLieuSources(subjectFolder);

            List<string> lines = File.ReadAllLines(Contents.SourcesPath + subjectFolder + @"/" + Contents.fileNameDuLieuVung).ToList();
            List<string> a = lines[0].Split(' ').ToList();
            Int32.TryParse(a[0], out soCau);
            Int32.TryParse(a[1], out soLanVung);
            Int32.TryParse(a[2], out soCauChuaVung);

            lblSoCauChuaVung.Text = SoCauChuaVung.ToString();
            numSoLanVung.Value = SoLanVung;

            DuLieu = new List<int>();
            for (int i=1; i<lines.Count(); i++)
                DuLieu.Add(Int32.Parse(lines[i]));
        }

        public void SaveFile()
        {
            StreamWriter file = new StreamWriter(Contents.SourcesPath + subjectFolder + @"/" + Contents.fileNameDuLieuVung);
            file.WriteLine("{0} {1} {2}", SoCau, SoLanVung, SoCauChuaVung);
            for (int i=0; i<SoCau; i++)
                file.WriteLine(DuLieu[i]);
            file.Close();
            file.Dispose();
        }

        public static void SaveFileMacDinh(int soCauMacDinh, string subjectFolder)
        {
            StreamWriter file = new StreamWriter(Contents.SourcesPath + subjectFolder + @"/" + Contents.fileNameDuLieuVung);
            file.WriteLine("{0} {1} {2}", soCauMacDinh, 0, 0);
            for (int i = 0; i < soCauMacDinh; i++)
                file.WriteLine(0);
            file.Close();
            file.Dispose();
        }

        public void Tang1LanTraLoiDung(int cau)
        {
            duLieu[cau]++;
            if (duLieu[cau] == SoLanVung)
            {
                soCauChuaVung--;
                lblSoCauChuaVung.Text = soCauChuaVung.ToString();
            }
        }

        public void ThayDoiSoLanVung(int numericSoLanVung)
        {
            SoLanVung = numericSoLanVung;
            SoCauChuaVung = 0;
            for (int i=0; i<SoCau; i++)
            {
                if (DuLieu[i] < SoLanVung)
                    SoCauChuaVung++;
            }
            numSoLanVung.Value = SoLanVung;
            lblSoCauChuaVung.Text = SoCauChuaVung.ToString();
            SaveFile();
        }

        public bool CoThayDoiSoLanVung(int numericSoLanVung)
        {
            return numericSoLanVung != SoLanVung;
        }

        public void ResetAll()
        {
            SoCauChuaVung = SoCau;
            for (int i = 0; i < SoCau; i++)
                DuLieu[i] = 0;
            lblSoCauChuaVung.Text = SoCauChuaVung.ToString();
        }

        public void ResetCau(int cau)
        {
            if (DuLieu[cau] >= SoLanVung)
                SoCauChuaVung++;
            DuLieu[cau] = 0;
            lblSoCauChuaVung.Text = SoCauChuaVung.ToString();
        }

        public List<int> LayDScauChuaVung()
        {
            List<int> res = new List<int>();
            for (int i = 0; i < SoCau; i++)
                if (duLieu[i] < SoLanVung)
                    res.Add(i);
            return res;
        }

        public void CapNhatSoCau(int tongSoCauHoi)
        { 
            for (int i = SoCau; i < tongSoCauHoi; i++)
                duLieu.Add(0);
            SoCau = tongSoCauHoi;
            ThayDoiSoLanVung(SoLanVung);
        }
    }
}
