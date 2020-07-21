﻿namespace _01.UsingOpenAPI
{
	partial class MainForm
	{
		/// <summary>
		/// 필수 디자이너 변수입니다.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 사용 중인 모든 리소스를 정리합니다.
		/// </summary>
		/// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form 디자이너에서 생성한 코드

		/// <summary>
		/// 디자이너 지원에 필요한 메서드입니다. 
		/// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.MtlGalmetgil = new MetroFramework.Controls.MetroTile();
			this.MtlInvestSimul = new MetroFramework.Controls.MetroTile();
			this.MtlStockAnals = new MetroFramework.Controls.MetroTile();
			this.MtlSearchItem = new MetroFramework.Controls.MetroTile();
			this.SuspendLayout();
			// 
			// MtlGalmetgil
			// 
			this.MtlGalmetgil.Location = new System.Drawing.Point(568, 114);
			this.MtlGalmetgil.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.MtlGalmetgil.Name = "MtlGalmetgil";
			this.MtlGalmetgil.Size = new System.Drawing.Size(300, 150);
			this.MtlGalmetgil.Style = MetroFramework.MetroColorStyle.Purple;
			this.MtlGalmetgil.TabIndex = 1;
			this.MtlGalmetgil.Text = "갈멧길코스정보";
			this.MtlGalmetgil.TileImage = global::_01.UsingOpenAPI.Properties.Resources.seagull2;
			this.MtlGalmetgil.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.MtlGalmetgil.UseTileImage = true;
			this.MtlGalmetgil.Click += new System.EventHandler(this.MtlGalmetgil_Click);
			// 
			// MtlInvestSimul
			// 
			this.MtlInvestSimul.Location = new System.Drawing.Point(412, 272);
			this.MtlInvestSimul.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.MtlInvestSimul.Name = "MtlInvestSimul";
			this.MtlInvestSimul.Size = new System.Drawing.Size(300, 150);
			this.MtlInvestSimul.Style = MetroFramework.MetroColorStyle.Green;
			this.MtlInvestSimul.TabIndex = 1;
			this.MtlInvestSimul.Text = "투자시뮬레이션";
			this.MtlInvestSimul.TileImage = global::_01.UsingOpenAPI.Properties.Resources.simulator2;
			this.MtlInvestSimul.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.MtlInvestSimul.UseTileImage = true;
			// 
			// MtlStockAnals
			// 
			this.MtlStockAnals.Location = new System.Drawing.Point(412, 114);
			this.MtlStockAnals.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.MtlStockAnals.Name = "MtlStockAnals";
			this.MtlStockAnals.Size = new System.Drawing.Size(150, 150);
			this.MtlStockAnals.Style = MetroFramework.MetroColorStyle.Orange;
			this.MtlStockAnals.TabIndex = 0;
			this.MtlStockAnals.Text = "주식정보분석";
			this.MtlStockAnals.TileImage = global::_01.UsingOpenAPI.Properties.Resources.analysis2;
			this.MtlStockAnals.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.MtlStockAnals.UseTileImage = true;
			// 
			// MtlSearchItem
			// 
			this.MtlSearchItem.Location = new System.Drawing.Point(106, 114);
			this.MtlSearchItem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.MtlSearchItem.Name = "MtlSearchItem";
			this.MtlSearchItem.Size = new System.Drawing.Size(300, 150);
			this.MtlSearchItem.Style = MetroFramework.MetroColorStyle.Blue;
			this.MtlSearchItem.TabIndex = 0;
			this.MtlSearchItem.Text = "주식정보검색";
			this.MtlSearchItem.TileImage = global::_01.UsingOpenAPI.Properties.Resources.marketing2;
			this.MtlSearchItem.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.MtlSearchItem.UseTileImage = true;
			this.MtlSearchItem.Click += new System.EventHandler(this.MtlSearchItem_Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1280, 720);
			this.Controls.Add(this.MtlGalmetgil);
			this.Controls.Add(this.MtlInvestSimul);
			this.Controls.Add(this.MtlStockAnals);
			this.Controls.Add(this.MtlSearchItem);
			this.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.MaximizeBox = false;
			this.Name = "MainForm";
			this.Padding = new System.Windows.Forms.Padding(23, 75, 23, 25);
			this.Resizable = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
			this.Text = "주식분석시스템";
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.ResumeLayout(false);

		}

		#endregion

		private MetroFramework.Controls.MetroTile MtlSearchItem;
		private MetroFramework.Controls.MetroTile MtlStockAnals;
		private MetroFramework.Controls.MetroTile MtlInvestSimul;
		private MetroFramework.Controls.MetroTile MtlGalmetgil;
	}
}

