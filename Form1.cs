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
    public partial class FormMain : Form
    {
        public DuLieuVung duLieuVung;
        public ThietDat thietDat;
        public DapAn dapAn;
        FormSetting fs;

        public FormMain()
        {
            InitializeComponent();
            //if (Screen.PrimaryScreen.WorkingArea.Width == 1366)
            //{
            //    this.Width = 400;
            //    this.Height = 300;
            //}
            //else
            //{
            //    this.Width = Screen.PrimaryScreen.WorkingArea.Width / 3;
            //    this.Height = this.Width / 4 * 3;
            //}
            tctrlMainMenu.Appearance = TabAppearance.FlatButtons;
            tctrlMainMenu.ItemSize = new Size(0, 1);
            tctrlMainMenu.SizeMode = TabSizeMode.Fixed;
            this.Text = "Giúp anh trả lời những câu hỏi!";

            fs = new FormSetting(this, lblSoCauChuaVung);
            duLieuVung = fs.getDuLieuVung();
            duLieuVung.LoadFile();

            thietDat = fs.getThietDat();
            thietDat.LoadFile();

            dapAn = new DapAn();
            dapAn.LoadFile();
            LoadnumSoCauThi();
            numTongSoCauHoi.Value = dapAn.SoCau;
            duLieuVung.CapNhatSoCau(dapAn.SoCau);
        }

        public void LoadnumSoCauThi()
        {
            this.numSoCauThi.Maximum = dapAn.SoCau;
            if (dapAn.SoCau < 40)
                this.numSoCauThi.Value = dapAn.SoCau;
            else this.numSoCauThi.Value = 40;
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

        private void chbxSoDapAnDuocChon_CheckedChanged(object sender, EventArgs e)
        {
            System.Media.SystemSounds.Hand.Play();
            CheckBox checkBox = sender as CheckBox;
            chbxSoDapAnDuocChon.BackgroundImage.RotateFlip(RotateFlipType.Rotate180FlipY);
            if (checkBox.Checked)   //Nhieu dap an
                ChonNhieuDapAn();
            else
                ChonMotDapAn();
        }

        private void btnMotDapAn_Click(object sender, EventArgs e)
        {
            if (chbxSoDapAnDuocChon.Checked == true)
                chbxSoDapAnDuocChon.BackgroundImage.RotateFlip(RotateFlipType.Rotate180FlipX);
            ChonMotDapAn();
        }

        private void btnNhieuDapAn_Click(object sender, EventArgs e)
        {
            if (chbxSoDapAnDuocChon.Checked == false)
                chbxSoDapAnDuocChon.BackgroundImage.RotateFlip(RotateFlipType.Rotate180FlipX);
            ChonNhieuDapAn();
        }
       
        private void tctrlMainMenu_MouseClick(object sender, MouseEventArgs e)
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
                LoadnumSoCauThi();
                dapAn.SaveFile();
                duLieuVung.CapNhatSoCau(dapAn.SoCau);
            }
        }

        private void btnModeDapAn1_Click(object sender, EventArgs e)
        {
            List<int> DScauHoi = Enumerable.Range(1, dapAn.SoCau).ToList();
            FormSuaDapAn frm = new FormSuaDapAn(DScauHoi, duLieuVung, thietDat, dapAn);
            frm.ShowDialog();
            lblSoCauChuaVung.Text = duLieuVung.SoCauChuaVung.ToString();
        }

        private bool KiemTraDapAnHopLe(string s)
        {
            for (int j = 0; j < s.Length; j++)
                if (s[j] < '1' || s[j] > thietDat.IntSoPhuongAn + 48)
                    return false;
            return true;
        }

        private void btnModeDapAn1Classic_Click(object sender, EventArgs e)
        {
            List<string> lines = new List<string>();
            string s;
            bool broken = false;
            for (int i = 0; i < dapAn.SoCau; i++)
            {
                s = Prompt.ShowDialog("Đáp án câu " + (i + 1).ToString(), "Cho anh sửa chữa những lỗi lầm!");
                if (s == "-1")
                {
                    broken = true;
                    break;
                }
                while (KiemTraDapAnHopLe(s) == false)
                {
                    MessageBox.Show("Mời nhập lại", "Sai định dạng đáp án", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    s = Prompt.ShowDialog("Đáp án câu " + (i + 1).ToString(), "Cho anh sửa chữa những lỗi lầm!");
                    if (s == "-1")
                    {
                        broken = true;
                        break;
                    }
                }
                if (s == "-1")
                {
                    broken = true;
                    break;
                }
                lines.Add(s);
            }
            if (broken)
                return;
            for (int i = 0; i < dapAn.SoCau; i++)
                if (dapAn.DapAns[i] != lines[i])
                    duLieuVung.ResetCau(i);
            duLieuVung.SaveFile();
            dapAn.DapAns = lines;
            dapAn.CanChinhDapAn();
            dapAn.SaveFile();
        }

        private void btnThi_Click(object sender, EventArgs e)
        {
            List<int> DScauThi = Enumerable.Range(1, dapAn.SoCau).ToList();
            var rnd = new Random();
            DScauThi = DScauThi.OrderBy(item => rnd.Next()).ToList();
            int soCauKhongThi = dapAn.SoCau - (int)numSoCauThi.Value;
            DScauThi.RemoveRange(0, soCauKhongThi);

            Form frm = new FormThi(DScauThi, duLieuVung, thietDat, dapAn);
            frm.ShowDialog();
            lblSoCauChuaVung.Text = duLieuVung.SoCauChuaVung.ToString();
        }

        private void btnModeDapAn2_Click(object sender, EventArgs e)
        {
            int cauCanSua;
            cauCanSua = PromptNumericUpDown.ShowDialog("Câu cần sửa: ", "Cho anh sửa chữa những lỗi lầm!", 1, dapAn.SoCau);
            if (cauCanSua == -1)
                return;

            List<int> DScauHoi = new List<int>();
            DScauHoi.Add(cauCanSua);
            FormSuaDapAn frm = new FormSuaDapAn(DScauHoi, duLieuVung, thietDat, dapAn);
            frm.ShowDialog();
            lblSoCauChuaVung.Text = duLieuVung.SoCauChuaVung.ToString();
        }

        private void btnMode1_Click(object sender, EventArgs e)
        {
            List<int> DScauHoi = Enumerable.Range(1, dapAn.SoCau).ToList();
            var rnd = new Random();
            DScauHoi = DScauHoi.OrderBy(item => rnd.Next()).ToList();

            FormHoc frm = new FormHoc(DScauHoi, duLieuVung, thietDat, dapAn);
            frm.ShowDialog();
            lblSoCauChuaVung.Text = duLieuVung.SoCauChuaVung.ToString();
        }

        private void btnMode2_Click(object sender, EventArgs e)
        {
            List<int> DScauHoi = Enumerable.Range(1, dapAn.SoCau).ToList();

            FormHoc frm = new FormHoc(DScauHoi, duLieuVung, thietDat, dapAn);
            frm.ShowDialog();
            lblSoCauChuaVung.Text = duLieuVung.SoCauChuaVung.ToString();
        }

        private void btnMode3_Click(object sender, EventArgs e)
        {
            List<int> DScauHoi = duLieuVung.LayDScauChuaVung();
            for (int i = 0; i < DScauHoi.Count; i++)
                DScauHoi[i]++;
            var rnd = new Random();
            DScauHoi = DScauHoi.OrderBy(item => rnd.Next()).ToList();

            FormHoc frm = new FormHoc(DScauHoi, duLieuVung, thietDat, dapAn);
            frm.ShowDialog();
            lblSoCauChuaVung.Text = duLieuVung.SoCauChuaVung.ToString();
        }

        private void btnMode4_Click(object sender, EventArgs e)
        {
            int cauCanSua;
            cauCanSua = PromptNumericUpDown.ShowDialog("Câu cần học: ", "Giúp anh trả lời những câu hỏi!", 1, dapAn.SoCau);
            if (cauCanSua == -1)
                return;

            List<int> DScauHoi = new List<int>();
            DScauHoi.Add(cauCanSua);

            FormHoc frm = new FormHoc(DScauHoi, duLieuVung, thietDat, dapAn);
            frm.ShowDialog();
            lblSoCauChuaVung.Text = duLieuVung.SoCauChuaVung.ToString();
        }

        private void btnResetDuLieuVung_Click(object sender, EventArgs e)
        {
            duLieuVung.DuLieu = Enumerable.Repeat(0, dapAn.SoCau).ToList();
            duLieuVung.SoCauChuaVung = dapAn.SoCau;
            duLieuVung.SaveFile();
            MessageBox.Show("Đã làm mới dữ liệu vững về 0", "Yêu lại từ đầu", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void btnModeDapAn3_Click(object sender, EventArgs e)
        {
            int cauBatDau;
            cauBatDau = PromptNumericUpDown.ShowDialog("Bắt đầu từ câu: ", "Cho anh sửa chữa những lỗi lầm!", 1, dapAn.SoCau);
            if (cauBatDau == -1)
                return;

            List<int> DScauHoi = Enumerable.Range(1, dapAn.SoCau).ToList();
            DScauHoi.RemoveRange(0, cauBatDau - 1);
            FormSuaDapAn frm = new FormSuaDapAn(DScauHoi, duLieuVung, thietDat, dapAn);
            frm.ShowDialog();
            lblSoCauChuaVung.Text = duLieuVung.SoCauChuaVung.ToString();
        }

        private void ttpMode1DapAnClassic_Popup(object sender, PopupEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            tctrlMainMenu.SelectedTab = tabPage1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tctrlMainMenu.SelectedTab = tabPage2;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tctrlMainMenu.SelectedTab = tabPage5;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            tctrlMainMenu.SelectedTab = tabPage2;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            tctrlMainMenu.SelectedTab = tabPage1;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            tctrlMainMenu.SelectedTab = tabPage5;

        }

        private void tấtCảĐápÁnToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            List<int> DScauHoi = Enumerable.Range(1, dapAn.SoCau).ToList();
            FormSuaDapAn frm = new FormSuaDapAn(DScauHoi, duLieuVung, thietDat, dapAn);
            frm.ShowDialog();
            lblSoCauChuaVung.Text = duLieuVung.SoCauChuaVung.ToString();
        }

        private void đápÁnMộtCâuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int cauCanSua;
            cauCanSua = PromptNumericUpDown.ShowDialog("Câu cần sửa: ", "Cho anh sửa chữa những lỗi lầm!", 1, dapAn.SoCau);
            if (cauCanSua == -1)
                return;

            List<int> DScauHoi = new List<int>();
            DScauHoi.Add(cauCanSua);
            FormSuaDapAn frm = new FormSuaDapAn(DScauHoi, duLieuVung, thietDat, dapAn);
            frm.ShowDialog();
            lblSoCauChuaVung.Text = duLieuVung.SoCauChuaVung.ToString();

        }

        private void bắtĐầuTừCâuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int cauBatDau;
            cauBatDau = PromptNumericUpDown.ShowDialog("Bắt đầu từ câu: ", "Cho anh sửa chữa những lỗi lầm!", 1, dapAn.SoCau);
            if (cauBatDau == -1)
                return;

            List<int> DScauHoi = Enumerable.Range(1, dapAn.SoCau).ToList();
            DScauHoi.RemoveRange(0, cauBatDau - 1);
            FormSuaDapAn frm = new FormSuaDapAn(DScauHoi, duLieuVung, thietDat, dapAn);
            frm.ShowDialog();
            lblSoCauChuaVung.Text = duLieuVung.SoCauChuaVung.ToString();

        }

        private void classicToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            List<string> lines = new List<string>();
            string s;
            bool broken = false;
            for (int i = 0; i < dapAn.SoCau; i++)
            {
                s = Prompt.ShowDialog("Đáp án câu " + (i + 1).ToString(), "Cho anh sửa chữa những lỗi lầm!");
                if (s == "-1")
                {
                    broken = true;
                    break;
                }
                while (KiemTraDapAnHopLe(s) == false)
                {
                    MessageBox.Show("Mời nhập lại", "Sai định dạng đáp án", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    s = Prompt.ShowDialog("Đáp án câu " + (i + 1).ToString(), "Cho anh sửa chữa những lỗi lầm!");
                    if (s == "-1")
                    {
                        broken = true;
                        break;
                    }
                }
                if (s == "-1")
                {
                    broken = true;
                    break;
                }
                lines.Add(s);
            }
            if (broken)
                return;
            for (int i = 0; i < dapAn.SoCau; i++)
                if (dapAn.DapAns[i] != lines[i])
                    duLieuVung.ResetCau(i);
            duLieuVung.SaveFile();
            dapAn.DapAns = lines;
            dapAn.CanChinhDapAn();
            dapAn.SaveFile();
        }

        private void bảnQuyềnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Trường tạc úp" + Environment.NewLine + "Tài u i u ích" + Environment.NewLine + "Vĩnh chỉ biết câm nín nghe tiếng Trường khóc", "Giúp anh trả lời những câu hỏi!");
        }

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }

        private void numSoLanVung_ValueChanged(object sender, EventArgs e)
        {

        }

        private void càiĐặtToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            fs.SetTextOfControls();
            fs.ShowDialog();
        }

        private void thoátToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
