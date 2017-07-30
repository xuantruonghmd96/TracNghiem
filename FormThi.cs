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
    public partial class FormThi : Form
    {
        private List<int> m_dsCauHoi;
        private DuLieuVung m_duLieuVung;
        private ThietDat m_thietDat;
        private DapAn m_dapAn;
        private int cauHienTai = 1;
        private List<string> dsPhuongAnDaChon = new List<string>();

        public FormThi()
        {
            InitializeComponent();
            DrawNutChonPhuongAn();
            LoadCauVaoThi();
        }

        public FormThi(List<int> m_dsCauHoi, DuLieuVung m_duLieuVung, ThietDat m_thietDat, DapAn m_dapAn)
        {
            this.m_dsCauHoi = m_dsCauHoi;
            this.m_duLieuVung = m_duLieuVung;
            this.m_thietDat = m_thietDat;
            this.m_dapAn = m_dapAn;
            InitializeComponent();
            DrawNutChonPhuongAn();
            LoadCauVaoThi();
        }

        public string LayFilePathImage(int i)
        {
            string imageFilePath = Contents.dauFileImage;
            if (i < 10)
                imageFilePath += "00";
            else if (i < 100)
                imageFilePath += "0";
            imageFilePath += i.ToString();
            imageFilePath += Contents.duoiFileImage;
            return imageFilePath;
        }

        private void LoadImage(string imageFilePath)
        {
            pbxCauHoi.Image = Image.FromFile(imageFilePath);
            if (pbxCauHoi.Image.Width > pbxCauHoi.Width || pbxCauHoi.Image.Height > pbxCauHoi.Height)
                pbxCauHoi.SizeMode = PictureBoxSizeMode.Zoom;
            else pbxCauHoi.SizeMode = PictureBoxSizeMode.CenterImage;
        }

        public void LoadCauVaoThi()
        {
            string imageFilePath = LayFilePathImage(cauHienTai);
            LoadImage(imageFilePath);
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
                btnOK.Hide();
        }

        private void ResetSangCauMoi()
        {
            checkBox1.BackColor = Contents.colorCheckBoxChonDapAn[0];
            checkBox2.BackColor = Contents.colorCheckBoxChonDapAn[0];
            checkBox3.BackColor = Contents.colorCheckBoxChonDapAn[0];
            checkBox4.BackColor = Contents.colorCheckBoxChonDapAn[0];
            checkBox5.BackColor = Contents.colorCheckBoxChonDapAn[0];
        }

        private void KetThucThi()
        {
            MessageBox.Show("KetThuc THI");
        }

        private void KetThucCau(string dapAn)
        {
            dsPhuongAnDaChon.Add(dapAn);
            ResetSangCauMoi();
            if (cauHienTai <= m_dsCauHoi.Count)
                LoadCauVaoThi();
            else KetThucThi();
        }

        private Color GetColorCheckBoxChonPhuongAn(Color color)
        {
            if (color == Contents.colorCheckBoxChonDapAn[0])
                return Contents.colorCheckBoxChonDapAn[1];
            else return Contents.colorCheckBoxChonDapAn[0];
        }

        private void CheckBoxChonPhuongAnCheckedChanged(CheckBox chbx)
        {
            chbx.BackColor = GetColorCheckBoxChonPhuongAn(chbx.BackColor);
            if (m_thietDat.BoolSoDapAnDuocChon == false)
                KetThucCau((chbx.Text[0] - 48).ToString());
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            CheckBoxChonPhuongAnCheckedChanged(sender as CheckBox);
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            CheckBoxChonPhuongAnCheckedChanged(sender as CheckBox);
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            CheckBoxChonPhuongAnCheckedChanged(sender as CheckBox);
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            CheckBoxChonPhuongAnCheckedChanged(sender as CheckBox);
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            CheckBoxChonPhuongAnCheckedChanged(sender as CheckBox);
        }

        private void btnOK_Click(object sender, EventArgs e)
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
