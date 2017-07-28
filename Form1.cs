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
        public FormMain()
        {
            InitializeComponent();
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
    }
}
