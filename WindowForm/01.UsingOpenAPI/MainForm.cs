using _01.UsingOpenAPI.SubItems;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _01.UsingOpenAPI
{
	public partial class MainForm : MetroForm	//Form
	{
		public MainForm()
		{
			InitializeComponent();
			// 폼을 화면(모니터) 정 중앙에 띄우기
			this.Location = new Point(Screen.PrimaryScreen.Bounds.Width / 2 - this.Size.Width / 2
				, Screen.PrimaryScreen.Bounds.Height / 2 - this.Size.Height / 2);
		}

		private void MainForm_Load(object sender, EventArgs e)
		{
			
		}

		private void MtlSearchItem_Click(object sender, EventArgs e)
		{
			// 창을 전환하며 보이지 않게하고
			this.Visible = false;

			// 주식정보검색을 누르면 SearchItem 폼을 띄운다.
			SerachItem searchItem = new SerachItem();
			// serchItem 폼의 위치를 현재 폼의 위치에 띄운다
			searchItem.Location = this.Location;
			searchItem.ShowDialog();

			// SerachItem 폼을 띄운 후 자신의 창을 닫는다.
			this.Close();
		}

		private void MtlGalmetgil_Click(object sender, EventArgs e)
		{
			this.Visible = false;

			GalmetgilForm form = new GalmetgilForm();
			form.Location = this.Location;
			form.ShowDialog();

			this.Close();
		}
	}
}
