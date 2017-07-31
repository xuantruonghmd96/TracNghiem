using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnThiTracNghiem
{
    public partial class FormSuaDapAn : FormThi
    {
        public FormSuaDapAn()
        {
            InitializeComponent();
        }

        public FormSuaDapAn(List<int> m_dsCauHoi, DuLieuVung m_duLieuVung, ThietDat m_thietDat, DapAn m_dapAn) : base(m_dsCauHoi, m_duLieuVung, m_thietDat, m_dapAn)
        {
            InitializeComponent();
        }

        override protected void KetThucThi()
        {
            this.Close();
            for (int i = 0; i < m_dsCauHoi.Count; i++)
            {
                if (m_dapAn.DapAns[m_dsCauHoi[i] - 1] != dsPhuongAnDaChon[i])
                    m_duLieuVung.ResetCau(i);
            }
            m_duLieuVung.SaveFile();
            if (m_dsCauHoi.Count == m_dapAn.SoCau)
                m_dapAn.DapAns = dsPhuongAnDaChon;
            else
            {
                for (int i = 0; i < m_dsCauHoi.Count; i++)
                    m_dapAn.DapAns[m_dsCauHoi[i] - 1] = dsPhuongAnDaChon[i];
            }
            m_dapAn.CanChinhDapAn();
            m_dapAn.SaveFile();
            MessageBox.Show("Sửa xong!");
        }
    }
}
