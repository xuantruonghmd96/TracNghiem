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
    public partial class FormKetThucThi : Form
    {
        int soCauDung;
        int soCauThi;
        List<string> cacCauSai;

        public FormKetThucThi()
        {
            InitializeComponent();
            lblSoCauDung.Text = soCauDung.ToString() + " / " + soCauThi + " câu";
            for (int i = 0; i < cacCauSai.Count; i++)
                tbxCacCauSai.Text += cacCauSai[i] + Environment.NewLine;
        }

        public FormKetThucThi(int soCauDung, int soCauThi, List<string> cacCauSai)
        {
            this.soCauDung = soCauDung;
            this.soCauThi = soCauThi;
            this.cacCauSai = cacCauSai;
            InitializeComponent();
            lblSoCauDung.Text = soCauDung.ToString() + " / " + soCauThi + " câu";
            for (int i = 0; i < cacCauSai.Count; i++)
                tbxCacCauSai.Text += cacCauSai[i] + Environment.NewLine;
        }
    }
}
