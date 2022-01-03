using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Globalization;
using System.Xml.Serialization;

namespace Recreational_Centre
{
    public partial class Report : Form
    {
        public string customerFile = @"C:\Users\user\OneDrive\Desktop\Recreational_Centre\bin\Debug\CustomerInfo.csv";
        List<CustomerInfo> customers;
        public Report()
        {
            InitializeComponent();
            init();
        }

        void init(){
            XmlSerializer serializer = new XmlSerializer(typeof(List<CustomerInfo>));
            try
            {
                using (Stream reader = new FileStream("../../SavedCustomerData.xml", FileMode.Open, FileAccess.Read))
                {
                    this.customers= (List<CustomerInfo>)serializer.Deserialize(reader);
                }
            }
            catch (Exception err)
            {
                MessageBox.Show("Couldn't open or deserealize the file SavedCustomerData.xml .\n" + err.Message,
                    "Close Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            /*
            var lines = File.ReadAllLines(customerFile);
            customers = new List<CustomerInfo>();
            foreach (var line in lines)
            {
                var values = line.Split(',');
                if (values.Length == 10)
                {
                    var customerInfo = new CustomerInfo() { ID = values[0], Name = values[1], Age = values[2], Date = values[3], Total_People = values[4], Visitor_Type = values[5], Check_In = values[6], Check_Out = values[7], Days = values[8], Price = values[9] };
                    customers.Add(customerInfo);
                }
            }
            */
        }
        private void BubbleSort()
        {
            /*
            DateTime date = DateTime.Now; //get current datetime 
                                          //get year from the date
            int year = date.Date.Year;
            //set the first day of the year
            DateTime firstDay = new DateTime(year, 1, 1);
            //get Day of the week 
            DayOfWeek day = date.DayOfWeek;
            CultureInfo cul = CultureInfo.CurrentCulture;
            //get no of week for the date
            int weekNo = cul.Calendar.GetWeekOfYear(date, CalendarWeekRule.FirstDay, DayOfWeek.Sunday);
            //get no of day
            int days = (weekNo - 1) * 7;
            DateTime dt1 = firstDay.AddDays(days);
            DayOfWeek dow = dt1.DayOfWeek;
            DateTime startDateOfWeek = dt1.AddDays(-(int)dow);
            DateTime endDateOfWeek = startDateOfWeek.AddDays(6);
            List<CustomerInfo> lstVisitor = new List<CustomerInfo>();
            string[] data = Utility.ReadFromFile("CustomerIndfo.csv");
            if (data != null)
            {
                for (int i = 0; i < data.Length - 1; i++)
                {
                    string[] rowData = data[i].Split(',');
                    var customer = new CustomerInfo
                    {

                        ID = rowData[0].ToString(),
                        Name = rowData[1].ToString(),
                        Age = rowData[2].ToString(),
                        Date = rowData[3].ToString(),
                        Total_People = rowData[4].ToString(),
                        Visitor_Type = rowData[5].ToString(),
                        Check_In = rowData[6].ToString(),
                        Check_Out = rowData[7].ToString(),
                        Days = rowData[8].ToString(),
                        Price = rowData[9].ToString(),
                    };
                    lstVisitor.Add(customer);
                }
            }
            DateTime current = DateTime.Now;
            var weekList = lstVisitor.Where(x => startDateOfWeek <= DateTime.ParseExact(x.Date, "dd/MM/yy", cul) && endDateOfWeek >= DateTime.ParseExact(x.Date, "dd/MM/yy", cul))
                                                                    .GroupBy(x => DateTime.ParseExact(x.Date, "dd/MM/yy", cul).DayOfWeek)
                                                                    .Select(grp => new
                                                                    {
                                                                        Day = grp.Key,
                                                                        Total_Visitors = grp.Sum(sum => sum.(int.Parse(Total_People))),
                                                                    })
                                                                    .ToArray();

            try
            {

                for (int a = 0; a < weekList.Length - 1; a++)
                {
                    int left = (weekList.Length - 1) - a;
                    for (int b = 0; b < left; b++)
                    {
                        if (weekList[b + 1] == null)
                        {
                            break;
                        }
                        else if (weekList[b].Total_Earnings > weekList[b + 1].Total_Earnings)
                        {
                            var tempArr = weekList[b];
                            weekList[b] = weekList[b + 1];
                            weekList[b + 1] = tempArr;
                        }
                    }
                }
                WeeklyReportGridView.DataSource = weekList;
            }
            catch (Exception excep)
            {
                Console.WriteLine($"Exception : {excep}");
            }
            */
        }

        private void Report_Load(object sender, EventArgs e)
        {
            /*
            bool sort = false;
            try
            {
                DateTime date = DateTime.Now; //get current datetime 
                                              //get year from the date
                int year = date.Date.Year;
                //set the first day of the year
                DateTime firstDay = new DateTime(year, 1, 1);
                //get Day of the week 
                DayOfWeek day = date.DayOfWeek;
                CultureInfo cul = CultureInfo.CurrentCulture;
                //get no of week for the date
                int weekNo = cul.Calendar.GetWeekOfYear(date, CalendarWeekRule.FirstDay, DayOfWeek.Sunday);
                //get no of day
                int days = (weekNo - 1) * 7;

                DateTime dt1 = firstDay.AddDays(days);
                DayOfWeek dow = dt1.DayOfWeek;
                DateTime startDateOfWeek = dt1.AddDays(-(int)dow);
                DateTime endDateOfWeek = startDateOfWeek.AddDays(6);
                List<CustomerInfo> lstVisitor = new List<CustomerInfo>();
                string[] data = Utility.ReadFromFile("CustomerIndfo.csv");
                if (data != null)
                {
                    for (int i = 0; i < data.Length - 1; i++)
                    {
                        string[] rowData = data[i].Split(',');
                        var customer = new CustomerInfo
                        {

                            ID = rowData[0].ToString(),
                            Name = rowData[1].ToString(),
                            Age = rowData[2].ToString(),
                            Date = rowData[3].ToString(),
                            Total_People = rowData[4].ToString(),
                            Visitor_Type = rowData[5].ToString(),
                            Check_In = rowData[6].ToString(),
                            Check_Out = rowData[7].ToString(),
                            Days = rowData[8].ToString(),
                            Price = rowData[9].ToString(),
                        };
                        lstVisitor.Add(customer);
                    }
                }
                DateTime current = DateTime.Now;
                var weeklyList = lstVisitor.Where(x => startDateOfWeek <= DateTime.ParseExact(x.Date, "dd/MM/yy", cul) && endDateOfWeek >= DateTime.ParseExact(x.Date, "dd/MM/yy", cul))
                                                                        .GroupBy(x => DateTime.ParseExact(x.Date, "dd/MM/yy", cul).DayOfWeek)
                                                                        .Select(grp => new
                                                                        {
                                                                            Day = grp.Key,
                                                                            Total_Visitors = grp.Sum(sum => sum.(int.Parse(Total_People))),
                                                                            Total_Earnings = grp.Sum(sum => sum.(decimal.Parse(Price)))
                                                                        })
                                                                        .ToList();
                WeeklyReportGridView.DataSource = weeklyList;
            }
            catch (Exception)
            {
                MessageBox.Show("No Data to view");
            }
            if (sort == true) {
                BubbleSort();
           
        }
            */
    }

        private void ReportDayPicker_ValueChanged(object sender, EventArgs e)
        {
            DailyChart.Series.Clear();
            DailyChart.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            DailyChart.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
            DailyChart.Padding = new Padding(3, 3, 3, 3);
            DailyChart.ChartAreas[0].AxisY.IsMarginVisible = false;
            DailyChart.ChartAreas[0].AxisX.IsMarginVisible = false;
            double totalIncomeDouble = 0;
            /*
            foreach (Visitor v in visitors) if (v.Date == dateTimePicker1.Value.Date)
                {
                    totalIncomeDouble += v.TotalFee;
                }

            int max = 1;
            foreach (CustomerInfo cs in customers)
            {
                Series series = this.DailyChart.Series.Add(cs.Visitor_Type);
                series["PixelPointWidth"] = "400";
                int count = 0;
                foreach (Visitor v in visitors)
                {
                    if (v.Visitor_Type == gr.Age && v.Date.Date.ToShortDateString() == dateTimePicker1.Value.Date.ToShortDateString())
                    {
                        count += 1;
                    }
                }
                if (count >= max)
                {
                    max = count;
                }
                series.Points.Add(count);
            }
            //chart1.ChartAreas[0].AxisX.Maximum = menuArr.groupArr.Count;
            chart1.ChartAreas[0].AxisX.Minimum = 0;
            chart1.ChartAreas[0].AxisY.Maximum = max;
            chart1.ChartAreas[0].AxisY.Minimum = 0;
            TotalIncome.Text = totalIncomeDouble.ToString();
            */


        }
    }
}
    
       

