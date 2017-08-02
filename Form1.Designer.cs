using System.Drawing;
using System.Windows.Forms;

namespace OnThiTracNghiem
{
    partial class FormMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.tctrlMainMenu = new System.Windows.Forms.TabControl();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.lblMode4 = new System.Windows.Forms.Label();
            this.lblMode3 = new System.Windows.Forms.Label();
            this.lblMode2 = new System.Windows.Forms.Label();
            this.lblMode1 = new System.Windows.Forms.Label();
            this.btnMode4 = new System.Windows.Forms.Button();
            this.btnMode3 = new System.Windows.Forms.Button();
            this.btnMode2 = new System.Windows.Forms.Button();
            this.btnMode1 = new System.Windows.Forms.Button();
            this.lblModeSelect = new System.Windows.Forms.Label();
            this.lblSoCauChuaVung = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.btnThi = new System.Windows.Forms.Button();
            this.numSoCauThi = new System.Windows.Forms.NumericUpDown();
            this.lblThi = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.btnModeDapAn3 = new System.Windows.Forms.Button();
            this.btnModeDapAn1Classic = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnModeDapAn2 = new System.Windows.Forms.Button();
            this.btnModeDapAn1 = new System.Windows.Forms.Button();
            this.lblSuaDapAn = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.btnResetDuLieuVung = new System.Windows.Forms.Button();
            this.numTongSoCauHoi = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.numSoLanVung = new System.Windows.Forms.NumericUpDown();
            this.lblSoLanVung = new System.Windows.Forms.Label();
            this.btnMotDapAn = new System.Windows.Forms.Button();
            this.btnNhieuDapAn = new System.Windows.Forms.Button();
            this.numSoPhuongAn = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.chbxSoDapAnDuocChon = new System.Windows.Forms.CheckBox();
            this.ttpSoLanVung = new System.Windows.Forms.ToolTip(this.components);
            this.ttpMode1DapAnClassic = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mởĐềThiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoátToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoátToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.thiếtLậpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.càiĐặtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tấtCảĐápÁnToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.đápÁnMộtCâuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bắtĐầuTừCâuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.càiĐặtToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.bảnQuyềnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tctrlMainMenu.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSoCauThi)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTongSoCauHoi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSoLanVung)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSoPhuongAn)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tctrlMainMenu
            // 
            this.tctrlMainMenu.Controls.Add(this.tabPage5);
            this.tctrlMainMenu.Controls.Add(this.tabPage1);
            this.tctrlMainMenu.Controls.Add(this.tabPage2);
            this.tctrlMainMenu.Controls.Add(this.tabPage3);
            this.tctrlMainMenu.Controls.Add(this.tabPage4);
            this.tctrlMainMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tctrlMainMenu.Location = new System.Drawing.Point(0, 24);
            this.tctrlMainMenu.Margin = new System.Windows.Forms.Padding(0);
            this.tctrlMainMenu.Name = "tctrlMainMenu";
            this.tctrlMainMenu.Padding = new System.Drawing.Point(0, 0);
            this.tctrlMainMenu.SelectedIndex = 0;
            this.tctrlMainMenu.Size = new System.Drawing.Size(400, 276);
            this.tctrlMainMenu.TabIndex = 1;
            this.tctrlMainMenu.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tctrlMainMenu_MouseClick);
            // 
            // tabPage5
            // 
            this.tabPage5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(227)))), ((int)(((byte)(167)))));
            this.tabPage5.Controls.Add(this.button2);
            this.tabPage5.Controls.Add(this.button1);
            this.tabPage5.Location = new System.Drawing.Point(4, 25);
            this.tabPage5.Margin = new System.Windows.Forms.Padding(0);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(392, 247);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "tabPage5";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Orange;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(210, 72);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(161, 146);
            this.button2.TabIndex = 1;
            this.button2.Text = "Thi";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Orange;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(19, 72);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(165, 146);
            this.button1.TabIndex = 0;
            this.button1.Text = "Học";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(227)))), ((int)(((byte)(167)))));
            this.tabPage1.Controls.Add(this.button4);
            this.tabPage1.Controls.Add(this.button3);
            this.tabPage1.Controls.Add(this.lblMode4);
            this.tabPage1.Controls.Add(this.lblMode3);
            this.tabPage1.Controls.Add(this.lblMode2);
            this.tabPage1.Controls.Add(this.lblMode1);
            this.tabPage1.Controls.Add(this.btnMode4);
            this.tabPage1.Controls.Add(this.btnMode3);
            this.tabPage1.Controls.Add(this.btnMode2);
            this.tabPage1.Controls.Add(this.btnMode1);
            this.tabPage1.Controls.Add(this.lblModeSelect);
            this.tabPage1.Controls.Add(this.lblSoCauChuaVung);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(0);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(392, 247);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Học";
            // 
            // button4
            // 
            this.button4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button4.BackColor = System.Drawing.Color.Orange;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button4.Location = new System.Drawing.Point(321, -12);
            this.button4.Margin = new System.Windows.Forms.Padding(4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(71, 28);
            this.button4.TabIndex = 12;
            this.button4.Text = "Thi";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button3.BackColor = System.Drawing.Color.Orange;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3.Location = new System.Drawing.Point(0, -12);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(71, 28);
            this.button3.TabIndex = 11;
            this.button3.Text = "<";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // lblMode4
            // 
            this.lblMode4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblMode4.AutoSize = true;
            this.lblMode4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMode4.Location = new System.Drawing.Point(145, 180);
            this.lblMode4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMode4.Name = "lblMode4";
            this.lblMode4.Size = new System.Drawing.Size(107, 16);
            this.lblMode4.TabIndex = 9;
            this.lblMode4.Text = "Một câu tùy chọn";
            // 
            // lblMode3
            // 
            this.lblMode3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblMode3.AutoSize = true;
            this.lblMode3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMode3.Location = new System.Drawing.Point(186, 144);
            this.lblMode3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMode3.Name = "lblMode3";
            this.lblMode3.Size = new System.Drawing.Size(94, 16);
            this.lblMode3.TabIndex = 8;
            this.lblMode3.Text = "câu chưa vững";
            // 
            // lblMode2
            // 
            this.lblMode2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblMode2.AutoSize = true;
            this.lblMode2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMode2.Location = new System.Drawing.Point(145, 108);
            this.lblMode2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMode2.Name = "lblMode2";
            this.lblMode2.Size = new System.Drawing.Size(154, 16);
            this.lblMode2.TabIndex = 7;
            this.lblMode2.Text = "Tất cả câu hỏi theo thứ tự";
            // 
            // lblMode1
            // 
            this.lblMode1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblMode1.AutoSize = true;
            this.lblMode1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMode1.Location = new System.Drawing.Point(145, 71);
            this.lblMode1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMode1.Name = "lblMode1";
            this.lblMode1.Size = new System.Drawing.Size(92, 16);
            this.lblMode1.TabIndex = 6;
            this.lblMode1.Text = "Tất cả câu hỏi";
            // 
            // btnMode4
            // 
            this.btnMode4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnMode4.BackColor = System.Drawing.Color.Orange;
            this.btnMode4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMode4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMode4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMode4.Location = new System.Drawing.Point(66, 174);
            this.btnMode4.Margin = new System.Windows.Forms.Padding(4);
            this.btnMode4.Name = "btnMode4";
            this.btnMode4.Size = new System.Drawing.Size(71, 28);
            this.btnMode4.TabIndex = 4;
            this.btnMode4.Text = "4";
            this.btnMode4.UseVisualStyleBackColor = false;
            this.btnMode4.Click += new System.EventHandler(this.btnMode4_Click);
            // 
            // btnMode3
            // 
            this.btnMode3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnMode3.BackColor = System.Drawing.Color.Orange;
            this.btnMode3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMode3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMode3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMode3.Location = new System.Drawing.Point(66, 138);
            this.btnMode3.Margin = new System.Windows.Forms.Padding(4);
            this.btnMode3.Name = "btnMode3";
            this.btnMode3.Size = new System.Drawing.Size(71, 28);
            this.btnMode3.TabIndex = 3;
            this.btnMode3.Text = "3";
            this.btnMode3.UseVisualStyleBackColor = false;
            this.btnMode3.Click += new System.EventHandler(this.btnMode3_Click);
            // 
            // btnMode2
            // 
            this.btnMode2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnMode2.BackColor = System.Drawing.Color.Orange;
            this.btnMode2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMode2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMode2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMode2.Location = new System.Drawing.Point(66, 102);
            this.btnMode2.Margin = new System.Windows.Forms.Padding(4);
            this.btnMode2.Name = "btnMode2";
            this.btnMode2.Size = new System.Drawing.Size(71, 28);
            this.btnMode2.TabIndex = 2;
            this.btnMode2.Text = "2";
            this.btnMode2.UseVisualStyleBackColor = false;
            this.btnMode2.Click += new System.EventHandler(this.btnMode2_Click);
            // 
            // btnMode1
            // 
            this.btnMode1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnMode1.BackColor = System.Drawing.Color.Orange;
            this.btnMode1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMode1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMode1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMode1.Location = new System.Drawing.Point(66, 65);
            this.btnMode1.Margin = new System.Windows.Forms.Padding(4);
            this.btnMode1.Name = "btnMode1";
            this.btnMode1.Size = new System.Drawing.Size(71, 28);
            this.btnMode1.TabIndex = 1;
            this.btnMode1.Text = "1";
            this.btnMode1.UseVisualStyleBackColor = false;
            this.btnMode1.Click += new System.EventHandler(this.btnMode1_Click);
            // 
            // lblModeSelect
            // 
            this.lblModeSelect.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblModeSelect.AutoSize = true;
            this.lblModeSelect.BackColor = System.Drawing.Color.Transparent;
            this.lblModeSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModeSelect.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblModeSelect.Location = new System.Drawing.Point(63, 31);
            this.lblModeSelect.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblModeSelect.Name = "lblModeSelect";
            this.lblModeSelect.Size = new System.Drawing.Size(133, 20);
            this.lblModeSelect.TabIndex = 0;
            this.lblModeSelect.Text = "Chọn cách học:";
            // 
            // lblSoCauChuaVung
            // 
            this.lblSoCauChuaVung.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSoCauChuaVung.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoCauChuaVung.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblSoCauChuaVung.Location = new System.Drawing.Point(145, 142);
            this.lblSoCauChuaVung.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSoCauChuaVung.Name = "lblSoCauChuaVung";
            this.lblSoCauChuaVung.Size = new System.Drawing.Size(39, 16);
            this.lblSoCauChuaVung.TabIndex = 10;
            this.lblSoCauChuaVung.Text = "1";
            this.lblSoCauChuaVung.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(227)))), ((int)(((byte)(167)))));
            this.tabPage2.Controls.Add(this.button6);
            this.tabPage2.Controls.Add(this.button5);
            this.tabPage2.Controls.Add(this.btnThi);
            this.tabPage2.Controls.Add(this.numSoCauThi);
            this.tabPage2.Controls.Add(this.lblThi);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage2.Size = new System.Drawing.Size(392, 247);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Thi";
            // 
            // button6
            // 
            this.button6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button6.BackColor = System.Drawing.Color.Orange;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button6.Location = new System.Drawing.Point(321, -12);
            this.button6.Margin = new System.Windows.Forms.Padding(4);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(71, 28);
            this.button6.TabIndex = 16;
            this.button6.Text = "Học";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button5.BackColor = System.Drawing.Color.Orange;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button5.Location = new System.Drawing.Point(0, -12);
            this.button5.Margin = new System.Windows.Forms.Padding(4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(71, 28);
            this.button5.TabIndex = 15;
            this.button5.Text = "<";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // btnThi
            // 
            this.btnThi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnThi.BackColor = System.Drawing.Color.Orange;
            this.btnThi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThi.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnThi.Location = new System.Drawing.Point(140, 123);
            this.btnThi.Margin = new System.Windows.Forms.Padding(4);
            this.btnThi.Name = "btnThi";
            this.btnThi.Size = new System.Drawing.Size(104, 37);
            this.btnThi.TabIndex = 14;
            this.btnThi.Text = "Bắt đầu thi";
            this.btnThi.UseVisualStyleBackColor = false;
            this.btnThi.Click += new System.EventHandler(this.btnThi_Click);
            // 
            // numSoCauThi
            // 
            this.numSoCauThi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numSoCauThi.AutoSize = true;
            this.numSoCauThi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(227)))), ((int)(((byte)(167)))));
            this.numSoCauThi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numSoCauThi.Location = new System.Drawing.Point(164, 66);
            this.numSoCauThi.Margin = new System.Windows.Forms.Padding(4);
            this.numSoCauThi.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.numSoCauThi.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numSoCauThi.Name = "numSoCauThi";
            this.numSoCauThi.Size = new System.Drawing.Size(60, 26);
            this.numSoCauThi.TabIndex = 13;
            this.numSoCauThi.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblThi
            // 
            this.lblThi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblThi.AutoSize = true;
            this.lblThi.BackColor = System.Drawing.Color.Transparent;
            this.lblThi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblThi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThi.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblThi.Location = new System.Drawing.Point(92, 33);
            this.lblThi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblThi.Name = "lblThi";
            this.lblThi.Size = new System.Drawing.Size(210, 20);
            this.lblThi.TabIndex = 12;
            this.lblThi.Text = "Chọn số câu hỏi trong đề";
            this.lblThi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(227)))), ((int)(((byte)(167)))));
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.btnModeDapAn3);
            this.tabPage3.Controls.Add(this.btnModeDapAn1Classic);
            this.tabPage3.Controls.Add(this.label1);
            this.tabPage3.Controls.Add(this.label2);
            this.tabPage3.Controls.Add(this.btnModeDapAn2);
            this.tabPage3.Controls.Add(this.btnModeDapAn1);
            this.tabPage3.Controls.Add(this.lblSuaDapAn);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage3.Size = new System.Drawing.Size(392, 247);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Sửa đáp án";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(119, 153);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(169, 16);
            this.label6.TabIndex = 15;
            this.label6.Text = "Bắt đầu từ một câu tùy chọn";
            // 
            // btnModeDapAn3
            // 
            this.btnModeDapAn3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnModeDapAn3.BackColor = System.Drawing.Color.Orange;
            this.btnModeDapAn3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModeDapAn3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModeDapAn3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnModeDapAn3.Location = new System.Drawing.Point(40, 147);
            this.btnModeDapAn3.Margin = new System.Windows.Forms.Padding(4);
            this.btnModeDapAn3.Name = "btnModeDapAn3";
            this.btnModeDapAn3.Size = new System.Drawing.Size(71, 28);
            this.btnModeDapAn3.TabIndex = 14;
            this.btnModeDapAn3.Text = "3";
            this.btnModeDapAn3.UseVisualStyleBackColor = false;
            this.btnModeDapAn3.Click += new System.EventHandler(this.btnModeDapAn3_Click);
            // 
            // btnModeDapAn1Classic
            // 
            this.btnModeDapAn1Classic.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnModeDapAn1Classic.BackColor = System.Drawing.Color.Orange;
            this.btnModeDapAn1Classic.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModeDapAn1Classic.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btnModeDapAn1Classic.Location = new System.Drawing.Point(231, 74);
            this.btnModeDapAn1Classic.Margin = new System.Windows.Forms.Padding(4);
            this.btnModeDapAn1Classic.Name = "btnModeDapAn1Classic";
            this.btnModeDapAn1Classic.Size = new System.Drawing.Size(71, 28);
            this.btnModeDapAn1Classic.TabIndex = 13;
            this.btnModeDapAn1Classic.Text = "Classic";
            this.ttpMode1DapAnClassic.SetToolTip(this.btnModeDapAn1Classic, "Kiểu cổ điển nhanh gọn.\r\nNhập lần lượt các đáp án\r\nbằng SỐ, bắt đầu từ 1");
            this.btnModeDapAn1Classic.UseVisualStyleBackColor = false;
            this.btnModeDapAn1Classic.Click += new System.EventHandler(this.btnModeDapAn1Classic_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(119, 117);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 16);
            this.label1.TabIndex = 12;
            this.label1.Text = "Đáp án của một câu tùy chọn";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(119, 80);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "Tất cả đáp án";
            // 
            // btnModeDapAn2
            // 
            this.btnModeDapAn2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnModeDapAn2.BackColor = System.Drawing.Color.Orange;
            this.btnModeDapAn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModeDapAn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModeDapAn2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnModeDapAn2.Location = new System.Drawing.Point(40, 111);
            this.btnModeDapAn2.Margin = new System.Windows.Forms.Padding(4);
            this.btnModeDapAn2.Name = "btnModeDapAn2";
            this.btnModeDapAn2.Size = new System.Drawing.Size(71, 28);
            this.btnModeDapAn2.TabIndex = 10;
            this.btnModeDapAn2.Text = "2";
            this.btnModeDapAn2.UseVisualStyleBackColor = false;
            this.btnModeDapAn2.Click += new System.EventHandler(this.btnModeDapAn2_Click);
            // 
            // btnModeDapAn1
            // 
            this.btnModeDapAn1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnModeDapAn1.BackColor = System.Drawing.Color.Orange;
            this.btnModeDapAn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModeDapAn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModeDapAn1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnModeDapAn1.Location = new System.Drawing.Point(40, 74);
            this.btnModeDapAn1.Margin = new System.Windows.Forms.Padding(4);
            this.btnModeDapAn1.Name = "btnModeDapAn1";
            this.btnModeDapAn1.Size = new System.Drawing.Size(71, 28);
            this.btnModeDapAn1.TabIndex = 9;
            this.btnModeDapAn1.Text = "1";
            this.btnModeDapAn1.UseVisualStyleBackColor = false;
            this.btnModeDapAn1.Click += new System.EventHandler(this.btnModeDapAn1_Click);
            // 
            // lblSuaDapAn
            // 
            this.lblSuaDapAn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSuaDapAn.AutoSize = true;
            this.lblSuaDapAn.BackColor = System.Drawing.Color.Transparent;
            this.lblSuaDapAn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSuaDapAn.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblSuaDapAn.Location = new System.Drawing.Point(37, 33);
            this.lblSuaDapAn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSuaDapAn.Name = "lblSuaDapAn";
            this.lblSuaDapAn.Size = new System.Drawing.Size(133, 20);
            this.lblSuaDapAn.TabIndex = 8;
            this.lblSuaDapAn.Text = "Chọn cách sửa:";
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(227)))), ((int)(((byte)(167)))));
            this.tabPage4.Controls.Add(this.btnResetDuLieuVung);
            this.tabPage4.Controls.Add(this.numTongSoCauHoi);
            this.tabPage4.Controls.Add(this.label5);
            this.tabPage4.Controls.Add(this.numSoLanVung);
            this.tabPage4.Controls.Add(this.lblSoLanVung);
            this.tabPage4.Controls.Add(this.btnMotDapAn);
            this.tabPage4.Controls.Add(this.btnNhieuDapAn);
            this.tabPage4.Controls.Add(this.numSoPhuongAn);
            this.tabPage4.Controls.Add(this.label4);
            this.tabPage4.Controls.Add(this.label3);
            this.tabPage4.Controls.Add(this.chbxSoDapAnDuocChon);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(392, 247);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Thiết đặt";
            this.tabPage4.Click += new System.EventHandler(this.tabPage4_Click);
            // 
            // btnResetDuLieuVung
            // 
            this.btnResetDuLieuVung.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnResetDuLieuVung.BackColor = System.Drawing.Color.Orange;
            this.btnResetDuLieuVung.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResetDuLieuVung.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResetDuLieuVung.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnResetDuLieuVung.Location = new System.Drawing.Point(241, 6);
            this.btnResetDuLieuVung.Margin = new System.Windows.Forms.Padding(4);
            this.btnResetDuLieuVung.Name = "btnResetDuLieuVung";
            this.btnResetDuLieuVung.Size = new System.Drawing.Size(102, 47);
            this.btnResetDuLieuVung.TabIndex = 15;
            this.btnResetDuLieuVung.Text = "Làm mới \r\ndữ liệu vững";
            this.btnResetDuLieuVung.UseVisualStyleBackColor = false;
            this.btnResetDuLieuVung.Click += new System.EventHandler(this.btnResetDuLieuVung_Click);
            // 
            // numTongSoCauHoi
            // 
            this.numTongSoCauHoi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numTongSoCauHoi.AutoSize = true;
            this.numTongSoCauHoi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(227)))), ((int)(((byte)(167)))));
            this.numTongSoCauHoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numTongSoCauHoi.Location = new System.Drawing.Point(141, 71);
            this.numTongSoCauHoi.Margin = new System.Windows.Forms.Padding(4);
            this.numTongSoCauHoi.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.numTongSoCauHoi.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numTongSoCauHoi.Name = "numTongSoCauHoi";
            this.numTongSoCauHoi.Size = new System.Drawing.Size(60, 26);
            this.numTongSoCauHoi.TabIndex = 14;
            this.numTongSoCauHoi.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(23, 76);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 16);
            this.label5.TabIndex = 13;
            this.label5.Text = "Tổng số câu hỏi: ";
            // 
            // numSoLanVung
            // 
            this.numSoLanVung.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numSoLanVung.AutoSize = true;
            this.numSoLanVung.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(227)))), ((int)(((byte)(167)))));
            this.numSoLanVung.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numSoLanVung.Location = new System.Drawing.Point(133, 16);
            this.numSoLanVung.Margin = new System.Windows.Forms.Padding(4);
            this.numSoLanVung.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numSoLanVung.Name = "numSoLanVung";
            this.numSoLanVung.Size = new System.Drawing.Size(60, 26);
            this.numSoLanVung.TabIndex = 1;
            this.ttpSoLanVung.SetToolTip(this.numSoLanVung, "Các câu hỏi có số lần trả lời đúng liên tiếp\r\nquá con số này sẽ được xác định là " +
        "đã vững.");
            this.numSoLanVung.ValueChanged += new System.EventHandler(this.numSoLanVung_ValueChanged);
            // 
            // lblSoLanVung
            // 
            this.lblSoLanVung.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSoLanVung.AutoSize = true;
            this.lblSoLanVung.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoLanVung.Location = new System.Drawing.Point(23, 20);
            this.lblSoLanVung.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSoLanVung.Name = "lblSoLanVung";
            this.lblSoLanVung.Size = new System.Drawing.Size(112, 16);
            this.lblSoLanVung.TabIndex = 12;
            this.lblSoLanVung.Text = "Đặt số lần vững = ";
            // 
            // btnMotDapAn
            // 
            this.btnMotDapAn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnMotDapAn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(126)))), ((int)(((byte)(4)))));
            this.btnMotDapAn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMotDapAn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMotDapAn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMotDapAn.Location = new System.Drawing.Point(34, 205);
            this.btnMotDapAn.Margin = new System.Windows.Forms.Padding(4);
            this.btnMotDapAn.Name = "btnMotDapAn";
            this.btnMotDapAn.Size = new System.Drawing.Size(116, 28);
            this.btnMotDapAn.TabIndex = 4;
            this.btnMotDapAn.Text = "Một đáp án";
            this.btnMotDapAn.UseVisualStyleBackColor = false;
            this.btnMotDapAn.Click += new System.EventHandler(this.btnMotDapAn_Click);
            // 
            // btnNhieuDapAn
            // 
            this.btnNhieuDapAn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnNhieuDapAn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(212)))), ((int)(((byte)(96)))));
            this.btnNhieuDapAn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNhieuDapAn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNhieuDapAn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNhieuDapAn.Location = new System.Drawing.Point(241, 205);
            this.btnNhieuDapAn.Margin = new System.Windows.Forms.Padding(4);
            this.btnNhieuDapAn.Name = "btnNhieuDapAn";
            this.btnNhieuDapAn.Size = new System.Drawing.Size(116, 28);
            this.btnNhieuDapAn.TabIndex = 5;
            this.btnNhieuDapAn.Text = "Nhiều đáp án";
            this.btnNhieuDapAn.UseVisualStyleBackColor = false;
            this.btnNhieuDapAn.Click += new System.EventHandler(this.btnNhieuDapAn_Click);
            // 
            // numSoPhuongAn
            // 
            this.numSoPhuongAn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numSoPhuongAn.AutoSize = true;
            this.numSoPhuongAn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(227)))), ((int)(((byte)(167)))));
            this.numSoPhuongAn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numSoPhuongAn.Location = new System.Drawing.Point(198, 120);
            this.numSoPhuongAn.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numSoPhuongAn.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numSoPhuongAn.Name = "numSoPhuongAn";
            this.numSoPhuongAn.Size = new System.Drawing.Size(60, 26);
            this.numSoPhuongAn.TabIndex = 2;
            this.numSoPhuongAn.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(213, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Số đáp án được chọn của mỗi câu:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(169, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Số phương án của mỗi câu:";
            // 
            // chbxSoDapAnDuocChon
            // 
            this.chbxSoDapAnDuocChon.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.chbxSoDapAnDuocChon.Appearance = System.Windows.Forms.Appearance.Button;
            this.chbxSoDapAnDuocChon.BackColor = System.Drawing.Color.Transparent;
            this.chbxSoDapAnDuocChon.BackgroundImage = global::OnThiTracNghiem.Properties.Resources.switch_button1;
            this.chbxSoDapAnDuocChon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.chbxSoDapAnDuocChon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chbxSoDapAnDuocChon.Location = new System.Drawing.Point(158, 203);
            this.chbxSoDapAnDuocChon.Margin = new System.Windows.Forms.Padding(0);
            this.chbxSoDapAnDuocChon.Name = "chbxSoDapAnDuocChon";
            this.chbxSoDapAnDuocChon.Size = new System.Drawing.Size(74, 32);
            this.chbxSoDapAnDuocChon.TabIndex = 3;
            this.chbxSoDapAnDuocChon.UseVisualStyleBackColor = false;
            this.chbxSoDapAnDuocChon.CheckedChanged += new System.EventHandler(this.chbxSoDapAnDuocChon_CheckedChanged);
            // 
            // ttpSoLanVung
            // 
            this.ttpSoLanVung.AutomaticDelay = 0;
            this.ttpSoLanVung.AutoPopDelay = 8000;
            this.ttpSoLanVung.InitialDelay = 0;
            this.ttpSoLanVung.ReshowDelay = 0;
            this.ttpSoLanVung.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.ttpSoLanVung.ToolTipTitle = "Mô tả";
            // 
            // ttpMode1DapAnClassic
            // 
            this.ttpMode1DapAnClassic.AutomaticDelay = 0;
            this.ttpMode1DapAnClassic.AutoPopDelay = 6000;
            this.ttpMode1DapAnClassic.InitialDelay = 0;
            this.ttpMode1DapAnClassic.ReshowDelay = 0;
            this.ttpMode1DapAnClassic.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.ttpMode1DapAnClassic.ToolTipTitle = "Mô tả";
            this.ttpMode1DapAnClassic.Popup += new System.Windows.Forms.PopupEventHandler(this.ttpMode1DapAnClassic_Popup);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.thiếtLậpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(400, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mởĐềThiToolStripMenuItem,
            this.thoátToolStripMenuItem,
            this.thoátToolStripMenuItem1});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(60, 20);
            this.toolStripMenuItem1.Text = "Câu hỏi";
            // 
            // mởĐềThiToolStripMenuItem
            // 
            this.mởĐềThiToolStripMenuItem.Name = "mởĐềThiToolStripMenuItem";
            this.mởĐềThiToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.mởĐềThiToolStripMenuItem.Text = "Mở bộ câu hỏi";
            // 
            // thoátToolStripMenuItem
            // 
            this.thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            this.thoátToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.thoátToolStripMenuItem.Text = "Lưu bộ câu hỏi";
            // 
            // thoátToolStripMenuItem1
            // 
            this.thoátToolStripMenuItem1.Name = "thoátToolStripMenuItem1";
            this.thoátToolStripMenuItem1.Size = new System.Drawing.Size(153, 22);
            this.thoátToolStripMenuItem1.Text = "Thoát";
            this.thoátToolStripMenuItem1.Click += new System.EventHandler(this.thoátToolStripMenuItem1_Click);
            // 
            // thiếtLậpToolStripMenuItem
            // 
            this.thiếtLậpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.càiĐặtToolStripMenuItem,
            this.càiĐặtToolStripMenuItem1,
            this.bảnQuyềnToolStripMenuItem});
            this.thiếtLậpToolStripMenuItem.Name = "thiếtLậpToolStripMenuItem";
            this.thiếtLậpToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.thiếtLậpToolStripMenuItem.Text = "Công cụ";
            // 
            // càiĐặtToolStripMenuItem
            // 
            this.càiĐặtToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tấtCảĐápÁnToolStripMenuItem1,
            this.đápÁnMộtCâuToolStripMenuItem,
            this.bắtĐầuTừCâuToolStripMenuItem});
            this.càiĐặtToolStripMenuItem.Name = "càiĐặtToolStripMenuItem";
            this.càiĐặtToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.càiĐặtToolStripMenuItem.Text = "Sửa đáp án";
            // 
            // tấtCảĐápÁnToolStripMenuItem1
            // 
            this.tấtCảĐápÁnToolStripMenuItem1.Name = "tấtCảĐápÁnToolStripMenuItem1";
            this.tấtCảĐápÁnToolStripMenuItem1.Size = new System.Drawing.Size(158, 22);
            this.tấtCảĐápÁnToolStripMenuItem1.Text = "Tất cả đáp án";
            this.tấtCảĐápÁnToolStripMenuItem1.Click += new System.EventHandler(this.tấtCảĐápÁnToolStripMenuItem1_Click);
            // 
            // đápÁnMộtCâuToolStripMenuItem
            // 
            this.đápÁnMộtCâuToolStripMenuItem.Name = "đápÁnMộtCâuToolStripMenuItem";
            this.đápÁnMộtCâuToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.đápÁnMộtCâuToolStripMenuItem.Text = "Đáp án một câu";
            this.đápÁnMộtCâuToolStripMenuItem.Click += new System.EventHandler(this.đápÁnMộtCâuToolStripMenuItem_Click);
            // 
            // bắtĐầuTừCâuToolStripMenuItem
            // 
            this.bắtĐầuTừCâuToolStripMenuItem.Name = "bắtĐầuTừCâuToolStripMenuItem";
            this.bắtĐầuTừCâuToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.bắtĐầuTừCâuToolStripMenuItem.Text = "Bắt đầu từ câu";
            this.bắtĐầuTừCâuToolStripMenuItem.Click += new System.EventHandler(this.bắtĐầuTừCâuToolStripMenuItem_Click);
            // 
            // càiĐặtToolStripMenuItem1
            // 
            this.càiĐặtToolStripMenuItem1.Name = "càiĐặtToolStripMenuItem1";
            this.càiĐặtToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.càiĐặtToolStripMenuItem1.Text = "Cài đặt";
            this.càiĐặtToolStripMenuItem1.Click += new System.EventHandler(this.càiĐặtToolStripMenuItem1_Click);
            // 
            // bảnQuyềnToolStripMenuItem
            // 
            this.bảnQuyềnToolStripMenuItem.Name = "bảnQuyềnToolStripMenuItem";
            this.bảnQuyềnToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.bảnQuyềnToolStripMenuItem.Text = "Bản quyền";
            this.bảnQuyềnToolStripMenuItem.Click += new System.EventHandler(this.bảnQuyềnToolStripMenuItem_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(227)))), ((int)(((byte)(167)))));
            this.ClientSize = new System.Drawing.Size(400, 300);
            this.Controls.Add(this.tctrlMainMenu);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(400, 300);
            this.Name = "FormMain";
            this.tctrlMainMenu.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSoCauThi)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTongSoCauHoi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSoLanVung)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSoPhuongAn)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tctrlMainMenu;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label lblModeSelect;
        private System.Windows.Forms.Label lblMode1;
        private System.Windows.Forms.Button btnMode4;
        private System.Windows.Forms.Button btnMode3;
        private System.Windows.Forms.Button btnMode2;
        private System.Windows.Forms.Button btnMode1;
        private System.Windows.Forms.Label lblMode4;
        private System.Windows.Forms.Label lblMode3;
        private System.Windows.Forms.Label lblMode2;
        private System.Windows.Forms.Button btnThi;
        private System.Windows.Forms.NumericUpDown numSoCauThi;
        private System.Windows.Forms.Label lblThi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnModeDapAn2;
        private System.Windows.Forms.Button btnModeDapAn1;
        private System.Windows.Forms.Label lblSuaDapAn;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.CheckBox chbxSoDapAnDuocChon;
        private System.Windows.Forms.NumericUpDown numSoPhuongAn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnMotDapAn;
        private System.Windows.Forms.Button btnNhieuDapAn;
        private System.Windows.Forms.NumericUpDown numSoLanVung;
        private System.Windows.Forms.Label lblSoLanVung;
        private System.Windows.Forms.Label lblSoCauChuaVung;
        private System.Windows.Forms.ToolTip ttpSoLanVung;
        private Button btnModeDapAn1Classic;
        private ToolTip ttpMode1DapAnClassic;
        private NumericUpDown numTongSoCauHoi;
        private Label label5;
        private Button btnResetDuLieuVung;
        private Label label6;
        private Button btnModeDapAn3;
        private TabPage tabPage5;
        private Button button2;
        private Button button1;
        private Button button3;
        private Button button4;
        private Button button6;
        private Button button5;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem mởĐềThiToolStripMenuItem;
        private ToolStripMenuItem thoátToolStripMenuItem;
        private ToolStripMenuItem thiếtLậpToolStripMenuItem;
        private ToolStripMenuItem càiĐặtToolStripMenuItem;
        private ToolStripMenuItem thoátToolStripMenuItem1;
        private ToolStripMenuItem tấtCảĐápÁnToolStripMenuItem1;
        private ToolStripMenuItem đápÁnMộtCâuToolStripMenuItem;
        private ToolStripMenuItem bắtĐầuTừCâuToolStripMenuItem;
        private ToolStripMenuItem càiĐặtToolStripMenuItem1;
        private ToolStripMenuItem bảnQuyềnToolStripMenuItem;
    }
}

