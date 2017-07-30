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
        DuLieuVung duLieuVung;
        ThietDat thietDat;
        DapAn dapAn;

        public FormMain()
        {
            InitializeComponent();
            if (Screen.PrimaryScreen.WorkingArea.Width == 1366)
            {
                this.Width = 400;
                this.Height = 300;
            }
            else
            {
                this.Width = Screen.PrimaryScreen.WorkingArea.Width / 3;
                this.Height = this.Width / 4 * 3;
            }

            duLieuVung = new DuLieuVung(numSoLanVung, lblSoCauChuaVung);
            duLieuVung.LoadFile();

            thietDat = new ThietDat(numSoPhuongAn, chbxSoDapAnDuocChon, btnMotDapAn, btnNhieuDapAn);
            thietDat.LoadFile();

            dapAn = new DapAn();
            dapAn.LoadFile();
            if (dapAn.SoCau < 40)
                this.numSoCauThi.Value = dapAn.SoCau;
            else this.numSoCauThi.Value = 40;
            this.numSoCauThi.Maximum = dapAn.SoCau;
        }

        private void ChonNhieuDapAn()
        {
            chbxSoDapAnDuocChon.Checked = true;
            btnMotDapAn.BackColor = Color.Transparent;
            btnNhieuDapAn.BackColor = Color.Orange;
        }

        private void ChonMotDapAn()
        {
            chbxSoDapAnDuocChon.Checked = false;
            btnMotDapAn.BackColor = Color.Orange;
            btnNhieuDapAn.BackColor = Color.Transparent;
        }

        private void chbxSoDapAnDuocChon_CheckedChanged(object sender, EventArgs e)
        {
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
        }

        private void btnModeDapAn1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
