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
            if (cauHienTai <= m_dsCauHoi.Count)
                LoadCauVaoThi();
            else KetThucThi();
        }

        public FormThi(List<int> m_dsCauHoi, DuLieuVung m_duLieuVung, ThietDat m_thietDat, DapAn m_dapAn)
        {
            this.m_dsCauHoi = m_dsCauHoi;
            this.m_duLieuVung = m_duLieuVung;
            this.m_thietDat = m_thietDat;
            this.m_dapAn = m_dapAn;
            InitializeComponent();
            DrawNutChonPhuongAn();
            if (cauHienTai <= m_dsCauHoi.Count)
                LoadCauVaoThi();
            else KetThucThi();
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
            string imageFilePath = LayFilePathImage(m_dsCauHoi[cauHienTai - 1]);
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

        private void InitializeKetThuc()
        {
            Label lblSoCauDung = new System.Windows.Forms.Label();
            Label label1 = new System.Windows.Forms.Label();
            TextBox tbxCacCauSai = new System.Windows.Forms.TextBox();
            Label label2 = new System.Windows.Forms.Label();
            Label label3 = new System.Windows.Forms.Label();
            this.Controls.Clear();
            this.Controls.Add(lblSoCauDung);
            this.Controls.Add(label1);
            this.Controls.Add(tbxCacCauSai);
            this.Controls.Add(label2);
            this.Controls.Add(label3);
            this.SuspendLayout();
            // 
            // lblSoCauDung
            // 
            lblSoCauDung.AutoSize = true;
            lblSoCauDung.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblSoCauDung.Location = new System.Drawing.Point(45, 52);
            lblSoCauDung.Name = "lblSoCauDung";
            lblSoCauDung.Size = new System.Drawing.Size(52, 16);
            lblSoCauDung.TabIndex = 0;
            List<string> cacCauSai;
            lblSoCauDung.Text = TinhSoCauDung(out cacCauSai).ToString() + " / " + m_dsCauHoi.Count + " cau";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.Location = new System.Drawing.Point(32, 21);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(116, 16);
            label1.TabIndex = 1;
            label1.Text = "Bạn trả lời đúng";
            // 
            // tbxCacCauSai
            // 
            tbxCacCauSai.Location = new System.Drawing.Point(35, 133);
            tbxCacCauSai.Multiline = true;
            tbxCacCauSai.Name = "tbxCacCauSai";
            tbxCacCauSai.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            tbxCacCauSai.Size = new System.Drawing.Size(113, 107);
            tbxCacCauSai.TabIndex = 2;
            tbxCacCauSai.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            tbxCacCauSai.ReadOnly = true;
            for (int i = 0; i < cacCauSai.Count; i++)
                tbxCacCauSai.Text += cacCauSai[i] + Environment.NewLine;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(54, 91);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(78, 16);
            label2.TabIndex = 3;
            label2.Text = "Các câu sai";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(30, 114);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(126, 16);
            label3.TabIndex = 4;
            label3.Text = "Câu - Đáp án - Chọn";
            // 
            // FormKetThucThi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(184, 261);
            this.Controls.Add(label3);
            this.Controls.Add(label2);
            this.Controls.Add(tbxCacCauSai);
            this.Controls.Add(label1);
            this.Controls.Add(lblSoCauDung);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormKetThucThi";
            this.Text = "Hoàn thành Thi";
            this.ResumeLayout(false);
            this.PerformLayout();
            this.MinimumSize = new Size(200, 300);
            this.Width = 200;
            this.Height = 300;

        }

        private int TinhSoCauDung(out List<string> cacCauSai)
        {
            int res = 0;
            cacCauSai = new List<string>();
            for (int i = 0; i < m_dsCauHoi.Count; i++)
            {
                if (m_dapAn.DungDapAnMotCau(m_dsCauHoi[i] - 1, dsPhuongAnDaChon[i]))
                    res++;
                else
                {
                    string s;
                    if (m_dsCauHoi[i] - 1 < 10)
                        s = "Câu   ";
                    else if (m_dsCauHoi[i] - 1 < 100)
                        s = "Câu  ";
                    else s = "Câu ";
                    s += (m_dsCauHoi[i]).ToString();
                    s += " - " + m_dapAn.DapAns[m_dsCauHoi[i]-1] + " - " + dsPhuongAnDaChon[i];
                    cacCauSai.Add(s);
                }
            }

            return res;
        }

        private void KetThucThi()
        {
            InitializeKetThuc();
            //MessageBox.Show("KetThuc THI");
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
                KetThucCau((chbx.Text[0] - 'A' + 1).ToString());
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
