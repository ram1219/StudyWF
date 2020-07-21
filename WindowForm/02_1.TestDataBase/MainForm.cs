using _02.UsingDataBase.SubItems;
using MetroFramework;
using MetroFramework.Forms;
using System;
using System.Windows.Forms;

namespace _02_1.TestDataBase
{
	public partial class MainForm : MetroForm
	{
		private bool loginstate = false;			
		public bool Login
		{
			set { loginstate = value; }
			get { return loginstate; }
		}

		public MainForm()
		{
			InitializeComponent();
		}

		private void MainForm_Load(object sender, EventArgs e)
		{

		}

		private void metroTile1_Click(object sender, EventArgs e)
		{
			LoginForm login = new LoginForm(this);
			login.ShowDialog();
		}

		private void metroTile2_Click(object sender, EventArgs e)
		{
			if(loginstate == false)
			{
				MetroMessageBox.Show(this, "로그인을 해주세요.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return;
			}

			MemberMngForm member = new MemberMngForm();
			member.ShowDialog();
		}
	}
}
