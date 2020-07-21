using MetroFramework.Forms;
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
	public partial class SerachItem : MetroForm
	{
		public SerachItem()
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

		private void SerachItem_Load(object sender, EventArgs e)
		{
			DgvSeachItems.Font = new Font("NanumGothic", 10, FontStyle.Regular);
		}

		// 검색 버튼을 클릭한 경우
		private void BtnSearch_Click(object sender, EventArgs e)
		{
			// Open API에서 가져온 정보 저장 공간
			WebClient wc = new WebClient { Encoding = Encoding.UTF8 };
			XmlDocument doc = new XmlDocument();

			// Open API 에서 정보 가져오기
			StringBuilder str = new StringBuilder();
			str.Append("http://api.seibro.or.kr/openapi/service/StockSvc/getStkIsinByNmN1");											   // Open API 기본 URL
			str.Append("?serviceKey=YQl80LabfUEqstQzXuRsm8e1y4l2GLxdDuRImC44RnQWAkaBYaS8R0dbQQ%2B0DiKFPdue3Nc4M%2F4BqI%2FLt6srOA%3D%3D");  // 인증키
			str.Append($"&secnNm={TxtSerachItem.Text}");				// 검색어
			str.Append("&numOfRows=200");								// 읽어올 데이터 수
			str.Append("&pageNo=1");									// 페이지 번호
			str.Append("&martTpcd=11");                                 // 주식시장 종류 11 유가증권시장

			// 가져온 정보 폼에 저장
			string xml = wc.DownloadString(str.ToString());
			doc.LoadXml(xml);

			XmlElement root = doc.DocumentElement;
			XmlNodeList items = doc.GetElementsByTagName("item");

			DgvSeachItems.Rows.Clear();

			try
			{
				// xmlnode -> xmlnodelist의 데이터 하나
				foreach (XmlNode item in items)
				{
					DgvSeachItems.Rows.Add(item["isin"]?.InnerText,  //isin 표준코드
																	// issuDt가 null 일 경우 Empty, 아닐 경우 텍스트로 저장 
						item["issuDt"] == null ? string.Empty : item["issuDt"].InnerText,
						item["korSecnNm"]?.InnerText,                //korSecnNm 한글 종목명
						item["secnKacdNm"]?.InnerText,               //secnKacdNm 보통주/우선주
						item["shotnIsin"]?.InnerText);               //shotnIsin 단축코드

				}

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

		private void DgvSeachItems_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}
	}
}
