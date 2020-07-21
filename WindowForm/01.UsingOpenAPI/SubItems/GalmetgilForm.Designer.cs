namespace _01.UsingOpenAPI.SubItems
{
	partial class GalmetgilForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GalmetgilForm));
			this.MtlBack = new MetroFramework.Controls.MetroTile();
			this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
			this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.TxtSerachItem = new MetroFramework.Controls.MetroTextBox();
			this.BtnSearch = new MetroFramework.Controls.MetroButton();
			this.DgvSeachItems = new System.Windows.Forms.DataGridView();
			this.Kosnm = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.KosType = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Kostxt = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.img = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.txt1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.title = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.txt2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
			this.metroTabControl1.Location = new System.Drawing.Point(23, 54);
			this.metroTabControl1.Name = "metroTabControl1";
			this.metroTabControl1.SelectedIndex = 0;
			this.metroTabControl1.Size = new System.Drawing.Size(1234, 597);
			this.metroTabControl1.TabIndex = 2;
			// 
			// metroTabPage1
			// 
			this.metroTabPage1.BackColor = System.Drawing.SystemColors.Control;
			this.metroTabPage1.Controls.Add(this.splitContainer1);
			this.metroTabPage1.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.metroTabPage1.HorizontalScrollbarBarColor = true;
			this.metroTabPage1.Location = new System.Drawing.Point(4, 36);
			this.metroTabPage1.Name = "metroTabPage1";
			this.metroTabPage1.Size = new System.Drawing.Size(1226, 557);
			this.metroTabPage1.Style = MetroFramework.MetroColorStyle.White;
			this.metroTabPage1.TabIndex = 0;
			this.metroTabPage1.Text = "정보조회";
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
			this.BtnSearch.Text = "조회";
			this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
			// 
			// DgvSeachItems
			// 
			this.DgvSeachItems.AllowUserToAddRows = false;
			this.DgvSeachItems.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
			this.DgvSeachItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.DgvSeachItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Kosnm,
            this.KosType,
            this.Kostxt,
            this.img,
            this.txt1,
            this.title,
            this.txt2});
			this.DgvSeachItems.Dock = System.Windows.Forms.DockStyle.Fill;
			this.DgvSeachItems.Location = new System.Drawing.Point(0, 0);
			this.DgvSeachItems.Name = "DgvSeachItems";
			this.DgvSeachItems.RowTemplate.Height = 23;
			this.DgvSeachItems.Size = new System.Drawing.Size(1226, 503);
			this.DgvSeachItems.TabIndex = 0;
			this.DgvSeachItems.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvSeachItems_CellDoubleClick);
			// 
			// Kosnm
			// 
			this.Kosnm.HeaderText = "코스명";
			this.Kosnm.Name = "Kosnm";
			this.Kosnm.Width = 150;
			// 
			// KosType
			// 
			this.KosType.HeaderText = "코스타입";
			this.KosType.Name = "KosType";
			this.KosType.Width = 200;
			// 
			// Kostxt
			// 
			this.Kostxt.HeaderText = "코스구간";
			this.Kostxt.Name = "Kostxt";
			this.Kostxt.Width = 250;
			// 
			// img
			// 
			this.img.HeaderText = "이미지";
			this.img.Name = "img";
			this.img.Width = 200;
			// 
			// txt1
			// 
			this.txt1.HeaderText = "코스정보";
			this.txt1.Name = "txt1";
			this.txt1.Width = 150;
			// 
			// title
			// 
			this.title.HeaderText = "코스구간이름";
			this.title.Name = "title";
			// 
			// txt2
			// 
			this.txt2.HeaderText = "코스부가정보";
			this.txt2.Name = "txt2";
			// 
			// GalmetgilForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1280, 720);
			this.Controls.Add(this.metroTabControl1);
			this.Controls.Add(this.MtlBack);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "GalmetgilForm";
			this.Resizable = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
			this.Text = "갈멧길 코스 조회 프로그램";
			this.Load += new System.EventHandler(this.Galmetgil_Load);
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
		private System.Windows.Forms.SplitContainer splitContainer1;
		private MetroFramework.Controls.MetroTextBox TxtSerachItem;
		private MetroFramework.Controls.MetroButton BtnSearch;
		private System.Windows.Forms.DataGridView DgvSeachItems;
		private System.Windows.Forms.DataGridViewTextBoxColumn Kosnm;
		private System.Windows.Forms.DataGridViewTextBoxColumn KosType;
		private System.Windows.Forms.DataGridViewTextBoxColumn Kostxt;
		private System.Windows.Forms.DataGridViewTextBoxColumn img;
		private System.Windows.Forms.DataGridViewTextBoxColumn txt1;
		private System.Windows.Forms.DataGridViewTextBoxColumn title;
		private System.Windows.Forms.DataGridViewTextBoxColumn txt2;
	}
}