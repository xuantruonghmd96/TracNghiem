using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace OnThiTracNghiem
{
    public class DapAn
    {
        private int m_soCau;
        private List<string> m_dapAn;
        private string subjectFolder;

        public DapAn(string subjectFolder)
        {
            this.subjectFolder = subjectFolder;
        }

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
            if (!File.Exists(Contents.sourcesPath + subjectFolder + @"/" + Contents.studyDataFilePath))
                Contents.TaoMacDinhDuLieuSources(subjectFolder);

            List<string> lines = File.ReadAllLines(Contents.sourcesPath + subjectFolder + @"/" + Contents.answerFilePath).ToList();
            SoCau = Int32.Parse(lines[0]);

            m_dapAn = new List<string>();
            for (int i = 1; i < lines.Count(); i++)
                m_dapAn.Add(lines[i]);
        }

        public void SaveFile()
        {
            StreamWriter file = new StreamWriter(Contents.sourcesPath + subjectFolder + @"/" + Contents.answerFilePath);
            file.WriteLine(SoCau);
            for (int i = 0; i < SoCau; i++)
                file.WriteLine(DapAns[i]);
            file.Close();
            file.Dispose();
        }

        public static void SaveFileMacDinh(string subjectFolder, int soCauMacDinh)
        {
            StreamWriter file = new StreamWriter(Contents.sourcesPath + subjectFolder + @"/" + Contents.answerFilePath);
            file.WriteLine(soCauMacDinh);
            for (int i = 0; i < soCauMacDinh; i++)
                file.WriteLine("");
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

        public void CanChinhDapAn()
        {
            for (int i = 0; i < m_soCau; i++)
            {
                m_dapAn[i] = new string(m_dapAn[i].ToCharArray().Distinct().ToArray());
                char[] temp = m_dapAn[i].ToCharArray();
                Array.Sort(temp);
                m_dapAn[i] = new string(temp);
            }
        }

        public static string ConvertSoToChu(string s)
        {
            if (s == "")
                return "0";
            string res = "";
            if (s[0] >= '0' && s[0] <= '9')
            {
                char temp;
                for (int i = 0; i < s.Length; i++)
                {
                    temp = (char)(s[i] + 'A' - '1');
                    res += temp;
                }
            }
            else res = s;
            return res;
        }
    }
}
