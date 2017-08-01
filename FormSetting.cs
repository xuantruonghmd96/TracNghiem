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
        DuLieuVung duLieuVung;
        DapAn dapAn;
        ThietDat thietDat;
        FormMain prevForm;

        public FormSetting()
        {
            InitializeComponent();
        }

        public FormSetting(FormMain pf,DuLieuVung dlv, DapAn da, ThietDat td)
        {
            InitializeComponent();

            prevForm = pf;
            duLieuVung = dlv;
            dapAn = da;
            thietDat = td;
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
            duLieuVung.DuLieu = Enumerable.Repeat(0, dapAn.SoCau).ToList();
            duLieuVung.SoCauChuaVung = dapAn.SoCau;
            duLieuVung.SaveFile();
            MessageBox.Show("Đã làm mới dữ liệu vững về 0", "Yêu lại từ đầu", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void lblSoLanVung_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (duLieuVung.CoThayDoiSoLanVung((int)numSoLanVung.Value))
                duLieuVung.ThayDoiSoLanVung((int)numSoLanVung.Value);
            if (thietDat.CoThayDoiThietDat((int)numSoPhuongAn.Value, chbxSoDapAnDuocChon.Checked))
                thietDat.ThayDoiThietDat((int)numSoPhuongAn.Value, chbxSoDapAnDuocChon.Checked);
            if (dapAn.SoCau != numTongSoCauHoi.Value)
            {
                if (dapAn.SoCau < numTongSoCauHoi.Value)
                {
                    MessageBox.Show("Hãy nhớ nhập thêm đáp án các câu mới", "Cho anh xin những ân cần", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    for (int i = dapAn.SoCau; i < numTongSoCauHoi.Value; i++)
                        dapAn.DapAns.Add("");
                }
                dapAn.SoCau = (int)numTongSoCauHoi.Value;
                prevForm.LoadnumSoCauThi();
                dapAn.SaveFile();
                duLieuVung.CapNhatSoCau(dapAn.SoCau);
            }
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
