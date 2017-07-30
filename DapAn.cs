using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace OnThiTracNghiem
{
    class DapAn
    {
        private int m_soCau;
        private List<string> m_dapAn;

        public int SoCau
        {
            get
            {
                return m_soCau;
            }

            set
            {
                m_soCau = value;
            }
        }

        public List<string> DapAns
        {
            get
            {
                return m_dapAn;
            }

            set
            {
                m_dapAn = value;
            }
        }

        public void LoadFile()
        {
            List<string> lines = File.ReadAllLines(Contents.fileNameDapAn).ToList();
            SoCau = Int32.Parse(lines[0]);

            m_dapAn = new List<string>();
            for (int i = 1; i < lines.Count(); i++)
                m_dapAn.Add(lines[i]);
        }

        public void SaveFile()
        {
            StreamWriter file = new StreamWriter(Contents.fileNameDapAn);
            file.WriteLine(SoCau);
            for (int i = 0; i < SoCau; i++)
                file.WriteLine(DapAns[i]);
            file.Close();
            file.Dispose();
        }

        public bool DungDapAnMotCau(int cau, string dapAn)
        {
            return DapAns[cau] == dapAn;
        }

        public void SuaDapAnMotCau(int cau, string dapAn)
        {
            DapAns[cau] = dapAn;
        }

        public void SuaDapAnTatCa(string[] dapAn)
        {
            for (int i=0; i<SoCau; i++)
            {
                DapAns[i] = dapAn[i];
            }
        }
    }
}
