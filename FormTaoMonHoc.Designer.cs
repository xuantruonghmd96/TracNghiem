namespace OnThiTracNghiem
{
    partial class FormTaoMonHoc
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbxSubjectName = new System.Windows.Forms.TextBox();
            this.tbxSubjectFolderName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxFolderQuestions = new System.Windows.Forms.TextBox();
            this.btnFolderQuestions = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên môn học:";
            // 
            // tbxSubjectName
            // 
            this.tbxSubjectName.Location = new System.Drawing.Point(155, 31);
            this.tbxSubjectName.Name = "tbxSubjectName";
            this.tbxSubjectName.Size = new System.Drawing.Size(199, 26);
            this.tbxSubjectName.TabIndex = 1;
            // 
            // tbxSubjectFolderName
            // 
            this.tbxSubjectFolderName.Location = new System.Drawing.Point(155, 96);
            this.tbxSubjectFolderName.Name = "tbxSubjectFolderName";
            this.tbxSubjectFolderName.Size = new System.Drawing.Size(199, 26);
            this.tbxSubjectFolderName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên folder:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Bộ ảnh câu hỏi:";
            // 
            // tbxFolderQuestions
            // 
            this.tbxFolderQuestions.Location = new System.Drawing.Point(155, 161);
            this.tbxFolderQuestions.Name = "tbxFolderQuestions";
            this.tbxFolderQuestions.ReadOnly = true;
            this.tbxFolderQuestions.Size = new System.Drawing.Size(121, 26);
            this.tbxFolderQuestions.TabIndex = 5;
            this.tbxFolderQuestions.TabStop = false;
            // 
            // btnFolderQuestions
            // 
            this.btnFolderQuestions.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnFolderQuestions.BackColor = System.Drawing.Color.Orange;
            this.btnFolderQuestions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFolderQuestions.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFolderQuestions.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnFolderQuestions.Location = new System.Drawing.Point(283, 159);
            this.btnFolderQuestions.Margin = new System.Windows.Forms.Padding(4);
            this.btnFolderQuestions.Name = "btnFolderQuestions";
            this.btnFolderQuestions.Size = new System.Drawing.Size(71, 28);
            this.btnFolderQuestions.TabIndex = 6;
            this.btnFolderQuestions.Text = "Browse";
            this.btnFolderQuestions.UseVisualStyleBackColor = false;
            this.btnFolderQuestions.Click += new System.EventHandler(this.btnFolderQuestions_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCreate.AutoSize = true;
            this.btnCreate.BackColor = System.Drawing.Color.Orange;
            this.btnCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCreate.Location = new System.Drawing.Point(155, 211);
            this.btnCreate.Margin = new System.Windows.Forms.Padding(4);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(77, 28);
            this.btnCreate.TabIndex = 7;
            this.btnCreate.Text = "Tạo mới";
            this.btnCreate.UseVisualStyleBackColor = false;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // FormTaoMonHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(227)))), ((int)(((byte)(167)))));
            this.ClientSize = new System.Drawing.Size(384, 261);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.btnFolderQuestions);
            this.Controls.Add(this.tbxFolderQuestions);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbxSubjectFolderName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbxSubjectName);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormTaoMonHoc";
            this.Text = "Cùng anh tạo nên những kỷ niệm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxSubjectName;
        private System.Windows.Forms.TextBox tbxSubjectFolderName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxFolderQuestions;
        private System.Windows.Forms.Button btnFolderQuestions;
        private System.Windows.Forms.Button btnCreate;
    }
}