using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _01.UsingOpenAPI.SubItems
{
	public partial class DownloadForm : MetroForm
	{
		// 폼간 변수 교환
		public string ParentUrl { get; set; }
		WebClient client;

		public DownloadForm()
		{
			InitializeComponent();
		}

		private void DownloadForm_Load(object sender, EventArgs e)
		{
			client = new WebClient();
			// 대리자
			client.DownloadProgressChanged += Client_DownloadProgressChanged;
			client.DownloadFileCompleted += Client_DownloadFileCompleted;
		}

		// 다운이 완료되었을 때
		private void Client_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
		{
			string fileName = ParentUrl.Substring(ParentUrl.IndexOf('=') + 1);
			pictureBox1.Load(Environment.CurrentDirectory + $"\\{fileName}");
			pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
		}

		// 프로그래스바가 변경 될 때
		private void Client_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
		{
			Invoke(new MethodInvoker(delegate()
			{
				progressBar1.Value = e.ProgressPercentage;

				if (e.BytesReceived == e.TotalBytesToReceive)
					Client_DownloadFileCompleted(sender, null);
			}));
		}

		private void DownloadForm_Shown(object sender, EventArgs e)
		{
			Thread thread = new Thread(new ThreadStart(StartDownload));
			thread.Start();
		}

		private void StartDownload()
		{
			Uri uri = new Uri(ParentUrl);
			string fileName = ParentUrl.Substring(ParentUrl.IndexOf('=') + 1);
			// '\'는 특수문자이므로 \\로 표현한다
			client.DownloadFileAsync(uri, Environment.CurrentDirectory + $"\\{fileName}");

		}
	}
}
