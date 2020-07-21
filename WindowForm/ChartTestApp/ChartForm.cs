using MetroFramework.Forms;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace ChartTestApp
{
	public partial class ChartForm : MetroForm
	{
		public readonly string strConstring = "Data Source=127.0.0.1;Port=3306;Database=employees;UID=root;Password=mysql_p@ssw0rd";
		public readonly string strQuery = @"SELECT CONCAT(em.first_name,' ',em.last_name) AS emp_name,
												em.gender,
												em.hire_date,
												dp.dept_no,
												dt.dept_name,
												MAX(sl.salary) AS max_salary
											FROM employees AS em
											INNER JOIN dept_emp AS dp
												ON em.emp_no = dp.emp_no
											INNER JOIN departments AS dt
												ON dp.dept_no = dt.dept_no
											INNER JOIN salaries AS sl
												ON em.emp_no = sl.emp_no
											WHERE em.hire_date >= '2000-01-01'
											GROUP BY em.first_name, em.last_name, em.gender, em.hire_date, dt.dept_name
											ORDER BY em.first_name ASC ";
		public ChartForm()
		{
			InitializeComponent();
		}

		private void BtnYValues_Click(object sender, EventArgs e)
		{
			// 초기화
			chart1.Series[0].Points.Clear();
			chart1.Series[0].Points.Add(98);
			chart1.Series[0].Points.Add(72);
			chart1.Series[0].Points.Add(50);
			chart1.Series[0].Points.Add(100);
			chart1.Series[0].Points.Add(88);
			chart1.Series[0].Points.Add(95);
			chart1.Series[0].Points.Add(83);

			chart1.Series[0].IsValueShownAsLabel = true;
			chart1.Series[0].ChartType = SeriesChartType.Spline;
		}

		private void BtnXYValues_Click(object sender, EventArgs e)
		{
			// 초기화
			chart1.Series[0].Points.Clear();
			chart1.Series[0].Points.AddXY("성명건", 98);
			chart1.Series[0].Points.AddXY("김가람", 72);
			chart1.Series[0].Points.AddXY("그르미", 50);
			chart1.Series[0].Points.AddXY("이하영", 100);
			chart1.Series[0].Points.AddXY("오타영", 88);
			chart1.Series[0].Points.AddXY("여예지", 95);
			chart1.Series[0].Points.AddXY("아깽이", 83);

			chart1.Series[0].IsValueShownAsLabel = true;

			chart1.Series[0].ChartType = SeriesChartType.Line;
		}

		private void BtnDataBind_Click(object sender, EventArgs e)
		{
			List<Students> students = new List<Students>();
			students.Add(new Students("성명건", 98.4));
			students.Add(new Students("김가람", 85.5));
			students.Add(new Students("그르미", 99.9));
			students.Add(new Students("이하영", 100.0));
			students.Add(new Students("여예지", 95.5));
			students.Add(new Students("아깽이", 87.5));

			chart1.Series[0].Points.DataBind(students, "Name", "Score", null);
			chart1.Series[0].ChartType = SeriesChartType.Bar;
			chart1.Series[0].IsValueShownAsLabel = true;
			chart1.Series[0].Color = Color.AliceBlue;
		}

		private class Students
		{
			public string Name { get; set; }
			public double Score { get; set; }

			public Students(string name, double score)
			{
				Name = name;
				Score = score;
			}
		}

		private void BtnMultiChart_Click(object sender, EventArgs e)
		{
			chart1.ChartAreas.Clear();
			chart1.Series.Clear();
			chart1.ChartAreas.Add("area1");
			chart1.ChartAreas.Add("area2");

			chart1.Series.Add("series1");
			chart1.Series.Add("series2");
			chart1.Series.Add("series3");

			chart1.Series["series1"].ChartArea = "area1";
			chart1.Series["series2"].ChartArea = "area2";
			chart1.Series["series3"].ChartArea = "area2";

			chart1.Series["series1"].ChartType = SeriesChartType.Spline;
			chart1.Series["series2"].ChartType = SeriesChartType.Line;
			chart1.Series["series3"].ChartType = SeriesChartType.Bubble;

			chart1.Series["series1"].Color = Color.Red;
			chart1.Series["series2"].Color = Color.Blue;
			chart1.Series["series3"].Color = Color.Green;

			chart1.Series["series1"].Points.AddXY(1, 100);
			chart1.Series["series1"].Points.AddXY(2, 400);
			chart1.Series["series1"].Points.AddXY(3, 200);
			chart1.Series["series1"].Points.AddXY(4, 300);
			chart1.Series["series1"].Points.AddXY(5, 500);

			chart1.Series["series2"].Points.AddXY(1, 120);
			chart1.Series["series2"].Points.AddXY(2, 300);
			chart1.Series["series2"].Points.AddXY(3, 250);
			chart1.Series["series2"].Points.AddXY(4, 410);
			chart1.Series["series2"].Points.AddXY(5, 530);

			chart1.Series["series3"].Points.AddXY(1, 560);
			chart1.Series["series3"].Points.AddXY(2, 130);
			chart1.Series["series3"].Points.AddXY(3, 220);
			chart1.Series["series3"].Points.AddXY(4, 70);
			chart1.Series["series3"].Points.AddXY(5, 340);

			chart1.Series["series2"].Points[3].Color = Color.HotPink;                                                                                                                            
		}

		private void BtnDBBind_Click(object sender, EventArgs e)
		{
			using (MySqlConnection conn = new MySqlConnection(strConstring))
			{
				conn.Open();
				MySqlCommand cmd = new MySqlCommand(strQuery, conn);
				MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
				DataSet db = new DataSet();
				adapter.Fill(db);

				chart1.DataSource = db.Tables[0];
				chart1.Series[0].XValueMember = "emp_name";
				chart1.Series[0].YValueMembers = "max_salary";
				chart1.DataBind();

				chart1.ChartAreas[0].AxisX.LabelStyle.Interval = 1;
				chart1.ChartAreas[0].AxisX.Title = "Employees";
				chart1.ChartAreas[0].AxisY.Title = "Salaies";
				chart1.ChartAreas[0].AxisY.LabelStyle.Format = "${0,0}";

				chart1.Series[0].IsValueShownAsLabel = true;
				chart1.Series[0].Name = "salay";
				chart1.Series[0].LabelFormat = "{0,0}";
				chart1.Series[0].Color = Color.Aqua;
			}
		}
	}

}
