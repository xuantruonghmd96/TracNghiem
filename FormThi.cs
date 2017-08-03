using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace OnThiTracNghiem
{
    public partial class FormThi : Form
    {
        protected List<int> m_dsCauHoi;
        protected DuLieuVung m_duLieuVung;
        protected ThietDat m_thietDat;
        protected DapAn m_dapAn;
        protected int cauHienTai = 1;
        protected List<string> dsPhuongAnDaChon = new List<string>();
        protected string _subjectFolder;

        public FormThi()
        {
            InitializeComponent();
            DrawNutChonPhuongAn();
            if (cauHienTai <= m_dsCauHoi.Count)
                LoadCauVaoThi();
            else KetThucThi();
        }

        public FormThi(List<int> m_dsCauHoi, DuLieuVung m_duLieuVung, ThietDat m_thietDat, DapAn m_dapAn, string subjectFolder)
        {
            this.m_dsCauHoi = m_dsCauHoi;
            this.m_duLieuVung = m_duLieuVung;
            this.m_thietDat = m_thietDat;
            this.m_dapAn = m_dapAn;
            this._subjectFolder = subjectFolder;
            InitializeComponent();
            DrawNutChonPhuongAn();
            if (cauHienTai <= m_dsCauHoi.Count)
                LoadCauVaoThi();
            else KetThucThi();
        }
        
        public string LayFilePathImage(int i)
        {
            string imageFilePath = Contents.sourcesPath + _subjectFolder + @"/" + Contents.dauFileImage;
            if (i < 10)
                imageFilePath += "00";
            else if (i < 100)
                imageFilePath += "0";
            imageFilePath += i.ToString();
            Contents.duoiFileImage = m_thietDat.DuoiFileImage;
            imageFilePath += Contents.duoiFileImage;
            return imageFilePath;
        }

        protected void LoadImage(string imageFilePath)
        {
            if (!File.Exists(imageFilePath))
            {
                pbxCauHoi.Image = Contents.SetUpPictures(pbxCauHoi); 
                return;
            }

            pbxCauHoi.Image = Image.FromFile(imageFilePath);
            if (pbxCauHoi.Image.Width > pbxCauHoi.Width || pbxCauHoi.Image.Height > pbxCauHoi.Height)
                pbxCauHoi.SizeMode = PictureBoxSizeMode.Zoom;
            else pbxCauHoi.SizeMode = PictureBoxSizeMode.CenterImage;
        }

        public void LoadCauVaoThi()
        {
            string imageFilePath = LayFilePathImage(m_dsCauHoi[cauHienTai - 1]);
            LoadImage(imageFilePath);
            lblDemCau.Text = "Câu " + cauHienTai + " / " + m_dsCauHoi.Count;
            cauHienTai++;
        }

        void DrawNutChonPhuongAn()
        {
            pnlNutChonPhuongAn.Location = new Point(pnlNutChonPhuongAn.Location.X, Contents.locationYPanelChonDapAn[m_thietDat.IntSoPhuongAn - 1]);
            if (m_thietDat.IntSoPhuongAn <5)
                pnlNutChonPhuongAn.Controls.Remove(checkBox5);
            if (m_thietDat.IntSoPhuongAn < 4)
                pnlNutChonPhuongAn.Controls.Remove(checkBox4);
            if (m_thietDat.IntSoPhuongAn < 3)
                pnlNutChonPhuongAn.Controls.Remove(checkBox3);
            if (m_thietDat.BoolSoDapAnDuocChon == false)
            {
                btnOK.Hide();
                checkBox1.BackColor = Contents.colorCheckBoxChonDapAn[1];
                checkBox2.BackColor = Contents.colorCheckBoxChonDapAn[1];
                checkBox3.BackColor = Contents.colorCheckBoxChonDapAn[1];
                checkBox4.BackColor = Contents.colorCheckBoxChonDapAn[1];
                checkBox5.BackColor = Contents.colorCheckBoxChonDapAn[1];
            }
        }

        protected void ResetSangCauMoi()
        {
            if (m_thietDat.BoolSoDapAnDuocChon == true)
            {
                checkBox1.Checked = false;
                checkBox2.Checked = false;
                checkBox3.Checked = false;
                checkBox4.Checked = false;
                checkBox5.Checked = false;
            }
        }

        private int TinhSoCauDung(out List<string> cacCauSai)
        {
            int res = 0;
            cacCauSai = new List<string>();
            for (int i = 0; i < m_dsCauHoi.Count; i++)
            {
                if (m_dapAn.DungDapAnMotCau(m_dsCauHoi[i] - 1, dsPhuongAnDaChon[i]))
                {
                    res++;
                    m_duLieuVung.Tang1LanTraLoiDung(m_dsCauHoi[i] - 1);
                }
                else
                {
                    m_duLieuVung.ResetCau(m_dsCauHoi[i] - 1);
                    string s;
                    if (m_dsCauHoi[i] - 1 < 10)
                        s = "Câu   ";
                    else if (m_dsCauHoi[i] - 1 < 100)
                        s = "Câu  ";
                    else s = "Câu ";
                    s += (m_dsCauHoi[i]).ToString();

                    s += " - " + DapAn.ConvertSoToChu(m_dapAn.DapAns[m_dsCauHoi[i] - 1]) + " - " + DapAn.ConvertSoToChu(dsPhuongAnDaChon[i]);
                    cacCauSai.Add(s);
                }
            }

            return res;
        }

        virtual protected void KetThucThi()
        {
            this.Close();
            List<string> cacCauSai;
            FormKetThucThi frm = new FormKetThucThi(TinhSoCauDung(out cacCauSai), m_dsCauHoi.Count, cacCauSai);
            frm.ShowDialog();
            m_duLieuVung.SaveFile();
            //MessageBox.Show("KetThuc THI");
        }

        virtual protected void KetThucCau(string dapAn)
        {
            dsPhuongAnDaChon.Add(dapAn);
            ResetSangCauMoi();
            if (cauHienTai <= m_dsCauHoi.Count)
                LoadCauVaoThi();
            else KetThucThi();
        }

        protected Color GetColorCheckBoxChonPhuongAn(Color color)
        {
            if (color == Contents.colorCheckBoxChonDapAn[0])
                return Contents.colorCheckBoxChonDapAn[1];
            else return Contents.colorCheckBoxChonDapAn[0];
        }

        protected void CheckBoxChonPhuongAnCheckedChanged(CheckBox chbx)
        {
            if (m_thietDat.BoolSoDapAnDuocChon == false)
                KetThucCau((chbx.Text[0] - 'A' + 1).ToString());
            else chbx.BackColor = GetColorCheckBoxChonPhuongAn(chbx.BackColor);
        }

        protected void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            CheckBoxChonPhuongAnCheckedChanged(sender as CheckBox);
        }

        protected void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            CheckBoxChonPhuongAnCheckedChanged(sender as CheckBox);
        }

        protected void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            CheckBoxChonPhuongAnCheckedChanged(sender as CheckBox);
        }

        protected void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            CheckBoxChonPhuongAnCheckedChanged(sender as CheckBox);
        }

        protected void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            CheckBoxChonPhuongAnCheckedChanged(sender as CheckBox);
        }

        protected void btnOK_Click(object sender, EventArgs e)
        {
            string dapAn = "";
            if (checkBox1.Checked)
                dapAn += "1";
            if (checkBox2.Checked)
                dapAn += "2";
            if (checkBox3.Checked)
                dapAn += "3";
            if (checkBox4.Checked)
                dapAn += "4";
            if (checkBox5.Checked)
                dapAn += "5";
            KetThucCau(dapAn);
        }
    }
}
