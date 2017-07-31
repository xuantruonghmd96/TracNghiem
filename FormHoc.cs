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
    public partial class FormHoc : FormThi
    {
        public FormHoc()
        {
            InitializeComponent();
        }

        public FormHoc(List<int> m_dsCauHoi, DuLieuVung m_duLieuVung, ThietDat m_thietDat, DapAn m_dapAn) : base(m_dsCauHoi, m_duLieuVung, m_thietDat, m_dapAn)
        {
            InitializeComponent();
        }

        override protected void KetThucCau(string dapAn)
        {
            bool checkDapAn = (m_dapAn.DungDapAnMotCau(m_dsCauHoi[cauHienTai - 2] - 1, dapAn));
            FormThongBaoDungSai.ShowDialog(checkDapAn, this.Left + this.Width - 250, this.Top + 200, m_dapAn.DapAns[m_dsCauHoi[cauHienTai - 2] - 1]);
            dsPhuongAnDaChon.Add(dapAn);
            ResetSangCauMoi();
            if (cauHienTai <= m_dsCauHoi.Count)
                LoadCauVaoThi();
            else KetThucThi();
        }
    }
}
