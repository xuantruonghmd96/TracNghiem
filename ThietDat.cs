using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnThiTracNghiem
{
    class ThietDat
    {
        private int m_intSoPhuongAn;
        private bool m_boolSoDapAnDuocChon;
        private NumericUpDown m_soPhuongAn;
        private CheckBox m_soDapAnDuocChon;
        private Button m_btnMotDapAn;
        private Button m_btnNhieuDapAn;

        public ThietDat(NumericUpDown numSoPhuongAn, CheckBox chbxSoDapAnDuocChon, Button btnMotDapAn, Button btnNhieuDapAn)
        {
            m_soDapAnDuocChon = chbxSoDapAnDuocChon;
            m_soPhuongAn = numSoPhuongAn;
            m_btnMotDapAn = btnMotDapAn;
            m_btnNhieuDapAn = btnNhieuDapAn;
        }

        public void LoadFile()
        {
            List<string> lines = File.ReadAllLines(Contents.fileNameThietDat).ToList();

            m_soPhuongAn.Value = Int32.Parse(lines[0]);
            if (lines[1] == "False")
            {
                if (m_soDapAnDuocChon.Checked == true)
                    m_soDapAnDuocChon.BackgroundImage.RotateFlip(RotateFlipType.Rotate180FlipX);
                m_soDapAnDuocChon.Checked = false;
                m_btnMotDapAn.BackColor = Color.Orange;
                m_btnNhieuDapAn.BackColor = Color.Transparent;
            }
            else
            {
                if (m_soDapAnDuocChon.Checked == false)
                    m_soDapAnDuocChon.BackgroundImage.RotateFlip(RotateFlipType.Rotate180FlipX);
                m_soDapAnDuocChon.Checked = true;
                m_btnNhieuDapAn.BackColor = Color.Orange;
                m_btnMotDapAn.BackColor = Color.Transparent;
            }
            m_intSoPhuongAn = (int)m_soPhuongAn.Value;
            m_boolSoDapAnDuocChon = m_soDapAnDuocChon.Checked;
        }

        public void SaveFile()
        {
            StreamWriter file = new StreamWriter(Contents.fileNameThietDat);
            file.WriteLine(m_soPhuongAn.Value);
            file.WriteLine(m_soDapAnDuocChon.Checked);
            //if (m_soDapAnDuocChon.Checked == false)
            //    file.WriteLine(1);
            //else file.WriteLine(0);
            file.Close();
            file.Dispose();
        }

        public void ThayDoiThietDat(int soPhuongAn, bool soDapAnDuocChon)
        {
            m_intSoPhuongAn = soPhuongAn;
            m_boolSoDapAnDuocChon = soDapAnDuocChon;
            m_soPhuongAn.Value = soPhuongAn;
            m_soDapAnDuocChon.Checked = soDapAnDuocChon;
            SaveFile();
        }

        public bool CoThayDoiThietDat(int soPhuongAn, bool soDapAnDuocChon)
        {
            return (soPhuongAn != m_intSoPhuongAn) || (soDapAnDuocChon != m_boolSoDapAnDuocChon);
        }

    }
}
