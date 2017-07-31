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
    public partial class FormThongBaoDungSai : Form
    {
        public FormThongBaoDungSai()
        {
            InitializeComponent();
        }

        protected void CanChinhControls()
        {
            label1.Left = (this.Width - label1.Width) / 2;
            label2.Left = (this.Width - label2.Width) / 2;
            button1.Left = (this.Width - button1.Width) / 2;
        }

        protected void InitializeFormDung()
        {
            label1.Text = "Bạn trả lời" + Environment.NewLine + "Đúng!";
            label2.Hide();
            this.BackColor = Color.Orange;
            CanChinhControls();
        }

        protected void InitializeFormSai(string dapAn)
        {
            label1.Text = "Sai!";
            label2.Text = "Đáp án là " + dapAn;
            this.BackColor = Color.Peru;
            CanChinhControls();
        }

        public FormThongBaoDungSai(bool dungSai, int left, int top, string dapAn = "")
        {
            InitializeComponent();
            this.Left = left;
            this.Top = top;
            if (dungSai == true)
                InitializeFormDung();
            else InitializeFormSai(dapAn);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        static public void ShowDialog(bool dungSai, int left, int top, string dapAn = "")
        {
            FormThongBaoDungSai frm = new FormThongBaoDungSai(dungSai, left, top, dapAn);
            frm.ShowDialog();
        }
    }
}
