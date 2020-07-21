﻿namespace _01.UsingOpenAPI.SubItems
{
	partial class SerachItem
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SerachItem));
			this.MtlBack = new MetroFramework.Controls.MetroTile();
			this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
			this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.TxtSerachItem = new MetroFramework.Controls.MetroTextBox();
			this.BtnSearch = new MetroFramework.Controls.MetroButton();
			this.DgvSeachItems = new System.Windows.Forms.DataGridView();
			this.ISIN = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ISSUDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.KORSECNNM = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.SECMKACDNM = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.SHOTNISIN = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
			this.metroTabControl1.SuspendLayout();
			this.metroTabPage1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.DgvSeachItems)).BeginInit();
			this.SuspendLayout();
			// 
			// MtlBack
			// 
			this.MtlBack.Location = new System.Drawing.Point(1187, 657);
			this.MtlBack.Name = "MtlBack";
			this.MtlBack.Size = new System.Drawing.Size(70, 40);
			this.MtlBack.Style = MetroFramework.MetroColorStyle.Blue;
			this.MtlBack.TabIndex = 1;
			this.MtlBack.TileImage = global::_01.UsingOpenAPI.Properties.Resources.back2;
			this.MtlBack.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.MtlBack.UseTileImage = true;
			this.MtlBack.Click += new System.EventHandler(this.MtlBack_Click);
			// 
			// metroTabControl1
			// 
			this.metroTabControl1.Controls.Add(this.metroTabPage1);
			this.metroTabControl1.Controls.Add(this.metroTabPage2);
			this.metroTabControl1.Location = new System.Drawing.Point(23, 54);
			this.metroTabControl1.Name = "metroTabControl1";
			this.metroTabControl1.SelectedIndex = 0;
			this.metroTabControl1.Size = new System.Drawing.Size(1234, 597);
			this.metroTabControl1.TabIndex = 2;
			// 
			// metroTabPage1
			// 
			this.metroTabPage1.Controls.Add(this.splitContainer1);
			this.metroTabPage1.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.metroTabPage1.HorizontalScrollbarBarColor = true;
			this.metroTabPage1.Location = new System.Drawing.Point(4, 36);
			this.metroTabPage1.Name = "metroTabPage1";
			this.metroTabPage1.Size = new System.Drawing.Size(1226, 557);
			this.metroTabPage1.TabIndex = 0;
			this.metroTabPage1.Text = "주식기초정보수집";
			this.metroTabPage1.VerticalScrollbarBarColor = true;
			// 
			// splitContainer1
			// 
			this.splitContainer1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
			this.splitContainer1.Location = new System.Drawing.Point(0, 0);
			this.splitContainer1.Name = "splitContainer1";
			this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this.TxtSerachItem);
			this.splitContainer1.Panel1.Controls.Add(this.BtnSearch);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
			this.splitContainer1.Panel2.Controls.Add(this.DgvSeachItems);
			this.splitContainer1.Panel2.Cursor = System.Windows.Forms.Cursors.Default;
			this.splitContainer1.Size = new System.Drawing.Size(1226, 557);
			this.splitContainer1.TabIndex = 2;
			// 
			// TxtSerachItem
			// 
			this.TxtSerachItem.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
			this.TxtSerachItem.Location = new System.Drawing.Point(800, 3);
			this.TxtSerachItem.Name = "TxtSerachItem";
			this.TxtSerachItem.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.TxtSerachItem.Size = new System.Drawing.Size(342, 44);
			this.TxtSerachItem.TabIndex = 1;
			this.TxtSerachItem.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.TxtSerachItem.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtSerachItem_KeyPress);
			// 
			// BtnSearch
			// 
			this.BtnSearch.Location = new System.Drawing.Point(1148, 3);
			this.BtnSearch.Name = "BtnSearch";
			this.BtnSearch.Size = new System.Drawing.Size(75, 44);
			this.BtnSearch.TabIndex = 0;
			this.BtnSearch.Text = "검색";
			this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
			// 
			// DgvSeachItems
			// 
			this.DgvSeachItems.AllowUserToAddRows = false;
			this.DgvSeachItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.DgvSeachItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ISIN,
            this.ISSUDT,
            this.KORSECNNM,
            this.SECMKACDNM,
            this.SHOTNISIN});
			this.DgvSeachItems.Dock = System.Windows.Forms.DockStyle.Fill;
			this.DgvSeachItems.Location = new System.Drawing.Point(0, 0);
			this.DgvSeachItems.Name = "DgvSeachItems";
			this.DgvSeachItems.RowTemplate.Height = 23;
			this.DgvSeachItems.Size = new System.Drawing.Size(1226, 503);
			this.DgvSeachItems.TabIndex = 0;
			this.DgvSeachItems.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvSeachItems_CellContentClick);
			// 
			// ISIN
			// 
			this.ISIN.HeaderText = "표준코드";
			this.ISIN.Name = "ISIN";
			this.ISIN.Width = 150;
			// 
			// ISSUDT
			// 
			this.ISSUDT.HeaderText = "주식 발행일자";
			this.ISSUDT.Name = "ISSUDT";
			this.ISSUDT.Width = 200;
			// 
			// KORSECNNM
			// 
			this.KORSECNNM.HeaderText = "한글 종목명";
			this.KORSECNNM.Name = "KORSECNNM";
			this.KORSECNNM.Width = 250;
			// 
			// SECMKACDNM
			// 
			this.SECMKACDNM.HeaderText = "보통주/우선주";
			this.SECMKACDNM.Name = "SECMKACDNM";
			this.SECMKACDNM.Width = 200;
			// 
			// SHOTNISIN
			// 
			this.SHOTNISIN.HeaderText = "단축코드";
			this.SHOTNISIN.Name = "SHOTNISIN";
			this.SHOTNISIN.Width = 150;
			// 
			// metroTabPage2
			// 
			this.metroTabPage2.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.metroTabPage2.HorizontalScrollbarBarColor = true;
			this.metroTabPage2.Location = new System.Drawing.Point(4, 36);
			this.metroTabPage2.Name = "metroTabPage2";
			this.metroTabPage2.Size = new System.Drawing.Size(1226, 557);
			this.metroTabPage2.TabIndex = 1;
			this.metroTabPage2.Text = "해당정보수집";
			this.metroTabPage2.VerticalScrollbarBarColor = true;
			// 
			// SerachItem
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1280, 720);
			this.Controls.Add(this.metroTabControl1);
			this.Controls.Add(this.MtlBack);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "SerachItem";
			this.Resizable = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
			this.Text = "종목 검색";
			this.Load += new System.EventHandler(this.SerachItem_Load);
			this.metroTabControl1.ResumeLayout(false);
			this.metroTabPage1.ResumeLayout(false);
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.DgvSeachItems)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private MetroFramework.Controls.MetroTile MtlBack;
		private MetroFramework.Controls.MetroTabControl metroTabControl1;
		private MetroFramework.Controls.MetroTabPage metroTabPage1;
		private MetroFramework.Controls.MetroTabPage metroTabPage2;
		private System.Windows.Forms.SplitContainer splitContainer1;
		private MetroFramework.Controls.MetroTextBox TxtSerachItem;
		private MetroFramework.Controls.MetroButton BtnSearch;
		private System.Windows.Forms.DataGridView DgvSeachItems;
		private System.Windows.Forms.DataGridViewTextBoxColumn ISIN;
		private System.Windows.Forms.DataGridViewTextBoxColumn ISSUDT;
		private System.Windows.Forms.DataGridViewTextBoxColumn KORSECNNM;
		private System.Windows.Forms.DataGridViewTextBoxColumn SECMKACDNM;
		private System.Windows.Forms.DataGridViewTextBoxColumn SHOTNISIN;
	}
}