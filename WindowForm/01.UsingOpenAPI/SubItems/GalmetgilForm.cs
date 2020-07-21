using MetroFramework.Forms;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace _01.UsingOpenAPI.SubItems
{
	public partial class GalmetgilForm : MetroForm
	{
		public GalmetgilForm()
		{
			InitializeComponent();
		}

		private void MtlBack_Click(object sender, EventArgs e)
		{
			this.Visible = false;

			// Back button을 누르면 메인 폼을 띄운다.
			MainForm main = new MainForm();
			main.Location = this.Location;
			main.ShowDialog();

			this.Close();
		}

		private void Galmetgil_Load(object sender, EventArgs e)
		{
			DgvSeachItems.Font = new Font("NanumGothic", 10, FontStyle.Regular);
		}

		// 검색 버튼을 클릭한 경우
		private void BtnSearch_Click(object sender, EventArgs e)
		{
			// Open API에서 정보 가져옴
			WebClient wc = new WebClient { Encoding = Encoding.UTF8 };

			// Open API 에서 정보 가져오기
			StringBuilder str = new StringBuilder();
			str.Append("http://apis.data.go.kr/6260000/BusanGalmaetGilService/getGalmaetGilInfo");														   // Open API 기본 URL
			str.Append("?serviceKey=YQl80LabfUEqstQzXuRsm8e1y4l2GLxdDuRImC44RnQWAkaBYaS8R0dbQQ%2B0DiKFPdue3Nc4M%2F4BqI%2FLt6srOA%3D%3D");  // 인증키
			str.Append("&pageNo=1");									// 페이지 번호
			str.Append("&numOfRows=10");								// 읽어올 데이터 수
			str.Append("&resultType=json");                             // json 형식의 데이터 값 가져오기

			// 가져온 정보 폼에 저장
			string json = wc.DownloadString(str.ToString());
			JObject obj = JObject.Parse(json);
			JArray Items = JArray.Parse(obj.SelectToken("getGalmaetGilInfo.item").ToString());

			DgvSeachItems.Rows.Clear();

			foreach(var item in Items)
			{
				DgvSeachItems.Rows.Add(
					$"{item.SelectToken("kosNm")}",
					$"{item.SelectToken("kosType")}",
					$"{item.SelectToken("kosTxt")}",
					$"{item.SelectToken("img")}",
					$"{item.SelectToken("txt1")}",
					$"{item.SelectToken("title")}",
					$"{item.SelectToken("txt2")}"
					);
			}
			try
			{
				

			}
			catch (NullReferenceException ex)
			{
				MessageBox.Show($"에러발생 : {ex.Message}", "에러",
					MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

			// 데이터 크기에 맞춰 크기 조정
			DgvSeachItems.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
		}

		// 텍스트박스에서 엔터 적용
		private void TxtSerachItem_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar == 13)
			{
				// 버튼의 Click 이벤트 발생
				BtnSearch_Click(sender, new EventArgs());
			}
		}

		private void DgvSeachItems_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			var selvalue = DgvSeachItems.Rows[e.RowIndex].Cells[3].Value.ToString();
			DownloadForm form = new DownloadForm();
			// DownloadForm에서 선언한 ParentUrl에 setvalue값을 전달한다.
			form.ParentUrl = selvalue;
			form.ShowDialog();
		}
	}
}
