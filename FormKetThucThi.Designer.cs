namespace OnThiTracNghiem
{
    partial class FormKetThucThi
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblSoCauDung = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxCacCauSai = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblSoCauDung
            // 
            this.lblSoCauDung.AutoSize = true;
            this.lblSoCauDung.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoCauDung.Location = new System.Drawing.Point(45, 52);
            this.lblSoCauDung.Name = "lblSoCauDung";
            this.lblSoCauDung.Size = new System.Drawing.Size(52, 16);
            this.lblSoCauDung.TabIndex = 0;
            this.lblSoCauDung.Text = "soCau";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Bạn trả lời đúng";
            // 
            // tbxCacCauSai
            // 
            this.tbxCacCauSai.Location = new System.Drawing.Point(35, 133);
            this.tbxCacCauSai.Multiline = true;
            this.tbxCacCauSai.Name = "tbxCacCauSai";
            this.tbxCacCauSai.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbxCacCauSai.Size = new System.Drawing.Size(113, 107);
            this.tbxCacCauSai.TabIndex = 2;
            this.tbxCacCauSai.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Các câu sai";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Câu - Đáp án - Chọn";
            // 
            // FormKetThucThi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(184, 261);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbxCacCauSai);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblSoCauDung);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormKetThucThi";
            this.Text = "Hoàn thành Thi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSoCauDung;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxCacCauSai;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}