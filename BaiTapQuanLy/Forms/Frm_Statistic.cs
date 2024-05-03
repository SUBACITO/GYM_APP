using BaiTapQuanLy.BussinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace BaiTapQuanLy.Forms
{
    public partial class Frm_Statistic : Form
    {
        Bll_ThongKe bll_thongke;

        DataTable dt, dt2;
        string err = string.Empty;

        public Frm_Statistic()
        {
            InitializeComponent();
        }

        private void Frm_Statistic_Load(object sender, EventArgs e)
        {
            bll_thongke = new Bll_ThongKe(clsMain.path);
            // Optionally initialize the date pickers to a default range, e.g., current month
            dtpFromDate.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            dtpToDate.Value = DateTime.Now;

            LoadDataToStats(dtpFromDate.Value, dtpToDate.Value);
            fillChart();
            LoadGenderStats();
            LoadDataDetailPackages();
            LoadDataPackages();
        }

 
        private void LoadDataDetailPackages()
        {
            DataTable dt3 = new DataTable();
            DataTable dt4 = new DataTable();

            dt3 = bll_thongke.GetDetailPackage(ref err);
            dgvDetailPackage.DataSource = dt3.DefaultView;
            lbTotalPackagesBought.Text = dt3.Rows.Count.ToString();

            dt4 = bll_thongke.GetMembersListToDGV(ref err);
           
            lbTotalMembers.Text = dt4.Rows.Count.ToString();


        }

        private void LoadDataPackages()
        {
            DataTable dt4 = new DataTable();
            dt4 = bll_thongke.GetPackage(ref err);
          
        }

        private void LoadDataToStats(DateTime fromDate, DateTime toDate)
        {
            dt = bll_thongke.GetPackageStats(ref err, fromDate, toDate);
            fillChart();
            if (!string.IsNullOrEmpty(err))
            {
                MessageBox.Show("Error loading data: " + err);
                return;
            }

            if (dt == null || dt.Rows.Count == 0)
            {
                MessageBox.Show("No data available for the selected date range.");
                return;
            }
        }

    

        private void dtpToDate_ValueChanged(object sender, EventArgs e)
        {
            LoadDataToStats(dtpFromDate.Value, dtpToDate.Value);
        }

        private void LoadGenderStats()
        {
            string err = string.Empty;
            dt2 = bll_thongke.GetMembersByGender(ref err);
            if (!string.IsNullOrEmpty(err))
            {
                MessageBox.Show("Error retrieving data: " + err);
                return;
            }

            MyChart_Genders.Series.Clear();
            Series series = MyChart_Genders.Series.Add("Gender Stats");
            series.ChartType = SeriesChartType.Pie; // Using a pie chart for representation

            // Configure labels to display the number of members alongside the gender
            series.IsValueShownAsLabel = true;
            series.Label = "#VALX: #VAL (#PERCENT{P0})"; // Customize the label to show gender, count, and percentage
            series.LabelForeColor = Color.Black;  // Set the color of the label text if needed

            // Populate the series with data
            foreach (DataRow row in dt2.Rows)
            {
                int count = (int)row["NumberOfMembers"];
                string label = row["Gender"].ToString() + ": " + count.ToString();
                series.Points.AddXY(row["Gender"], count);
            }

            // Enhance the chart appearance with additional styles if desired
            MyChart_Genders.ChartAreas[0].Area3DStyle.Enable3D = true; // Optional: Enable 3D style
            MyChart_Genders.Legends[0].Enabled = true; // Optional: Enable legend if needed

            MyChart_Genders.Invalidate(); // Refresh the chart
        }

        private void btnLoadGenderStats_Click(object sender, EventArgs e)
        {
            LoadGenderStats();
        }

        private void btnGetHistoryBoughPackages_Click(object sender, EventArgs e)
        {
            LoadDataDetailPackages();
        }

        private void fillChart()
        {
            MyChart_Packages.Series.Clear(); // Clear existing series

            // Group data by PackageName to create a series for each package
            var packageGroups = dt.AsEnumerable()
                .GroupBy(row => row.Field<string>("PackageName"))
                .ToList();

            foreach (var packageGroup in packageGroups)
            {
                string packageName = packageGroup.Key;
                Series series = MyChart_Packages.Series.Add(packageName); // Create a series for each package
                series.ChartType = SeriesChartType.Column; // Assuming a column chart is appropriate

                foreach (DataRow row in packageGroup)
                {
                    int month = row.Field<int>("Month");
                    int year = row.Field<int>("Year");
                    int numberOfMembers = row.Field<int>("NumberOfMembers");
                    string xValue = $"{month} / {year}"; // Constructing the X-axis label as Month / Year

                    series.Points.AddXY(xValue, numberOfMembers);
                }
            }

            // Configure axis labels and title
            MyChart_Packages.ChartAreas[0].AxisX.Title = "Month / Year";
            MyChart_Packages.ChartAreas[0].AxisY.Title = "Number of Members";
            MyChart_Packages.Titles.Clear();
            MyChart_Packages.Titles.Add("Membership Usage Statistics by Package");
            MyChart_Packages.Invalidate(); // Refresh the chart
        }
    }
}
