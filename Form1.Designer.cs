﻿using System.Drawing;
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
            this.tabPage1 = new System.Windows.Forms.TabPage();
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
            this.tctrlMainMenu.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSoCauThi)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTongSoCauHoi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSoLanVung)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSoPhuongAn)).BeginInit();
            this.SuspendLayout();
            // 
            // tctrlMainMenu
            // 
            this.tctrlMainMenu.Controls.Add(this.tabPage1);
            this.tctrlMainMenu.Controls.Add(this.tabPage2);
            this.tctrlMainMenu.Controls.Add(this.tabPage3);
            this.tctrlMainMenu.Controls.Add(this.tabPage4);
            this.tctrlMainMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tctrlMainMenu.Location = new System.Drawing.Point(0, 0);
            this.tctrlMainMenu.Margin = new System.Windows.Forms.Padding(4);
            this.tctrlMainMenu.Name = "tctrlMainMenu";
            this.tctrlMainMenu.Padding = new System.Drawing.Point(10, 3);
            this.tctrlMainMenu.SelectedIndex = 0;
            this.tctrlMainMenu.Size = new System.Drawing.Size(400, 300);
            this.tctrlMainMenu.TabIndex = 0;
            this.tctrlMainMenu.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tctrlMainMenu_MouseClick);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(227)))), ((int)(((byte)(167)))));
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
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(392, 271);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Học";
            // 
            // lblMode4
            // 
            this.lblMode4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblMode4.AutoSize = true;
            this.lblMode4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMode4.Location = new System.Drawing.Point(145, 192);
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
            this.lblMode3.Location = new System.Drawing.Point(186, 156);
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
            this.lblMode2.Location = new System.Drawing.Point(145, 120);
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
            this.lblMode1.Location = new System.Drawing.Point(145, 83);
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
            this.btnMode4.Location = new System.Drawing.Point(66, 186);
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
            this.btnMode3.Location = new System.Drawing.Point(66, 150);
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
            this.btnMode2.Location = new System.Drawing.Point(66, 114);
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
            this.btnMode1.Location = new System.Drawing.Point(66, 77);
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
            this.lblModeSelect.Location = new System.Drawing.Point(63, 43);
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
            this.lblSoCauChuaVung.Location = new System.Drawing.Point(145, 154);
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
            this.tabPage2.Controls.Add(this.btnThi);
            this.tabPage2.Controls.Add(this.numSoCauThi);
            this.tabPage2.Controls.Add(this.lblThi);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage2.Size = new System.Drawing.Size(392, 271);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Thi";
            // 
            // btnThi
            // 
            this.btnThi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnThi.BackColor = System.Drawing.Color.Orange;
            this.btnThi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThi.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnThi.Location = new System.Drawing.Point(140, 135);
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
            this.numSoCauThi.Location = new System.Drawing.Point(164, 78);
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
            this.lblThi.Location = new System.Drawing.Point(92, 45);
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
            this.tabPage3.Size = new System.Drawing.Size(392, 271);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Sửa đáp án";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(119, 165);
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
            this.btnModeDapAn3.Location = new System.Drawing.Point(40, 159);
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
            this.btnModeDapAn1Classic.Location = new System.Drawing.Point(231, 86);
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
            this.label1.Location = new System.Drawing.Point(119, 129);
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
            this.label2.Location = new System.Drawing.Point(119, 92);
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
            this.btnModeDapAn2.Location = new System.Drawing.Point(40, 123);
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
            this.btnModeDapAn1.Location = new System.Drawing.Point(40, 86);
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
            this.lblSuaDapAn.Location = new System.Drawing.Point(37, 45);
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
            this.tabPage4.Size = new System.Drawing.Size(392, 271);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Thiết đặt";
            // 
            // btnResetDuLieuVung
            // 
            this.btnResetDuLieuVung.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnResetDuLieuVung.BackColor = System.Drawing.Color.Orange;
            this.btnResetDuLieuVung.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResetDuLieuVung.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResetDuLieuVung.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnResetDuLieuVung.Location = new System.Drawing.Point(241, 18);
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
            this.numTongSoCauHoi.Location = new System.Drawing.Point(141, 83);
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
            this.label5.Location = new System.Drawing.Point(23, 88);
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
            this.numSoLanVung.Location = new System.Drawing.Point(133, 28);
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
            // 
            // lblSoLanVung
            // 
            this.lblSoLanVung.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSoLanVung.AutoSize = true;
            this.lblSoLanVung.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoLanVung.Location = new System.Drawing.Point(23, 32);
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
            this.btnMotDapAn.Location = new System.Drawing.Point(34, 217);
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
            this.btnNhieuDapAn.Location = new System.Drawing.Point(241, 217);
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
            this.numSoPhuongAn.Location = new System.Drawing.Point(198, 132);
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
            this.label4.Location = new System.Drawing.Point(23, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(213, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Số đáp án được chọn của mỗi câu:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 136);
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
            this.chbxSoDapAnDuocChon.Location = new System.Drawing.Point(158, 215);
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
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(227)))), ((int)(((byte)(167)))));
            this.ClientSize = new System.Drawing.Size(400, 300);
            this.Controls.Add(this.tctrlMainMenu);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(400, 300);
            this.Name = "FormMain";
            this.Text = "Giúp anh trả lời những câu hỏi!";
            this.tctrlMainMenu.ResumeLayout(false);
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
            this.ResumeLayout(false);

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
    }
}

