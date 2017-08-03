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
    public partial class FormSetting : Form
    {
        FormMain prevForm;
        DuLieuVung duLieuVung;
        ThietDat thietDat;
        DapAn dapAn;

        public FormSetting()
        {
            InitializeComponent();
        }

        public FormSetting(FormMain pf, Label soCauChuaVung, string subjectFolder)
        {
            InitializeComponent();

            prevForm = pf;
            duLieuVung = new DuLieuVung(numSoLanVung, soCauChuaVung, subjectFolder);
            duLieuVung.LoadFile();

            thietDat = new ThietDat(numSoPhuongAn, chbxSoDapAnDuocChon, btnMotDapAn, btnNhieuDapAn, subjectFolder);
            thietDat.LoadFile();

            dapAn = new DapAn(subjectFolder);
            dapAn.LoadFile();
            numTongSoCauHoi.Value = dapAn.SoCau;
            duLieuVung.CapNhatSoCau(dapAn.SoCau);
        }

        public void SetTextOfControls()
        {
            duLieuVung.LoadFile();
            thietDat.LoadFile();
            dapAn.LoadFile();
            numTongSoCauHoi.Value = dapAn.SoCau;
            duLieuVung.CapNhatSoCau(dapAn.SoCau);
        }

        private void btnResetDuLieuVung_Click(object sender, EventArgs e)
        {

        }

        private void btnMotDapAn_Click(object sender, EventArgs e)
        {

        }

        private void btnNhieuDapAn_Click(object sender, EventArgs e)
        {

        }

        private void chbxSoDapAnDuocChon_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnResetDuLieuVung_Click_1(object sender, EventArgs e)
        {
            prevForm.duLieuVung.DuLieu = Enumerable.Repeat(0, prevForm.dapAn.SoCau).ToList();
            prevForm.duLieuVung.SoCauChuaVung = prevForm.dapAn.SoCau;
            prevForm.duLieuVung.SaveFile();
            MessageBox.Show("Đã làm mới dữ liệu vững về 0.", "Yêu lại từ đầu", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void lblSoLanVung_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (prevForm.duLieuVung.CoThayDoiSoLanVung((int)numSoLanVung.Value))
                prevForm.duLieuVung.ThayDoiSoLanVung((int)numSoLanVung.Value);
            if (prevForm.thietDat.CoThayDoiThietDat((int)numSoPhuongAn.Value, chbxSoDapAnDuocChon.Checked))
                prevForm.thietDat.ThayDoiThietDat((int)numSoPhuongAn.Value, chbxSoDapAnDuocChon.Checked);
            if (prevForm.dapAn.SoCau != numTongSoCauHoi.Value)
            {
                if (prevForm.dapAn.SoCau < numTongSoCauHoi.Value)
                {
                    MessageBox.Show("Hãy nhớ nhập thêm đáp án các câu mới!", "Cho anh xin những ân cần!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    for (int i = prevForm.dapAn.SoCau; i < numTongSoCauHoi.Value; i++)
                        prevForm.dapAn.DapAns.Add("");
                }
                prevForm.dapAn.SoCau = (int)numTongSoCauHoi.Value;
                prevForm.LoadnumSoCauThi();
                prevForm.dapAn.SaveFile();
                prevForm.duLieuVung.CapNhatSoCau(prevForm.dapAn.SoCau);
            }
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ChonNhieuDapAn()
        {
            chbxSoDapAnDuocChon.Checked = true;
            btnMotDapAn.BackColor = Contents.colorOff;
            btnNhieuDapAn.BackColor = Contents.colorOn;
        }

        private void ChonMotDapAn()
        {
            chbxSoDapAnDuocChon.Checked = false;
            btnMotDapAn.BackColor = Contents.colorOn;
            btnNhieuDapAn.BackColor = Contents.colorOff;
        }

        private void chbxSoDapAnDuocChon_CheckedChanged_1(object sender, EventArgs e)
        {
            System.Media.SystemSounds.Hand.Play();
            CheckBox checkBox = sender as CheckBox;
            chbxSoDapAnDuocChon.BackgroundImage.RotateFlip(RotateFlipType.Rotate180FlipY);
            if (checkBox.Checked)   //Nhieu dap an
                ChonNhieuDapAn();
            else
                ChonMotDapAn();
        }

        private void btnMotDapAn_Click_1(object sender, EventArgs e)
        {
            if (chbxSoDapAnDuocChon.Checked == true)
                chbxSoDapAnDuocChon.BackgroundImage.RotateFlip(RotateFlipType.Rotate180FlipX);
            ChonMotDapAn();
        }

        private void btnNhieuDapAn_Click_1(object sender, EventArgs e)
        {
            if (chbxSoDapAnDuocChon.Checked == false)
                chbxSoDapAnDuocChon.BackgroundImage.RotateFlip(RotateFlipType.Rotate180FlipX);
            ChonNhieuDapAn();
        }

        public DuLieuVung getDuLieuVung()
        {
            return duLieuVung;
        }

        public ThietDat getThietDat()
        {
            return thietDat;
        }
    }
}