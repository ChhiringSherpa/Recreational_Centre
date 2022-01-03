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
using Newtonsoft.Json;

namespace Recreational_Centre
{
    public partial class AdminForm : Form
    {
        private static string _filePath = @"C:\Users\user\OneDrive\Desktop\Recreational_Center\bin\Debug\Prices.csv";
        int selectedRow;


        public AdminForm()
        {
            InitializeComponent();

        }



        private void ViewPrice_Button_Click(object sender, EventArgs e)
        {
            List<Price> AllPrice = new List<Price>();

            try
            {
                string[] data = File.ReadAllLines(@"C:\Users\user\OneDrive\Desktop\Recreational_Centre\bin\Debug\Prices.csv");
                if (data != null)
                {
                    for (int i = 0; i < data.Length - 1; i++)
                    {
                        string[] rowData = data[i].Split(',');
                        var Prices = new Price
                        {
                            Visitor_Type = rowData[0].ToString(),
                            One_Hour = int.Parse(rowData[1]),
                            Two_Hour = int.Parse(rowData[2]),
                            Three_Hour = int.Parse(rowData[3]),
                            Four_Hour = int.Parse(rowData[4]),
                            Whole_Day = int.Parse(rowData[5]),
                        };
                        AllPrice.Add(Prices);
                    }
                }
            }
            catch (Exception excep)
            {
                Console.WriteLine(excep);
            }
            var bindingList = new BindingList<Price>(AllPrice);
            var source = new BindingSource(bindingList, null);
            PriceDataGridView.DataSource = source;
        }

        private void Save_Button_Click(object sender, EventArgs e)
        {
            List<Price> AllPrice = new List<Price>();

            if (PriceDataGridView.Rows != null)
            {
                for (int rows = 0; rows < PriceDataGridView.Rows.Count - 1; rows++)
                {
                    var Prices = new Price
                    {
                        Visitor_Type = PriceDataGridView.Rows[rows].Cells[0].Value.ToString(),
                        One_Hour = int.Parse(PriceDataGridView.Rows[rows].Cells[1].Value.ToString()),
                        Two_Hour = int.Parse(PriceDataGridView.Rows[rows].Cells[2].Value.ToString()),
                        Three_Hour = int.Parse(PriceDataGridView.Rows[rows].Cells[3].Value.ToString()),
                        Four_Hour = int.Parse(PriceDataGridView.Rows[rows].Cells[4].Value.ToString()),
                        Whole_Day = int.Parse(PriceDataGridView.Rows[rows].Cells[5].Value.ToString()),
                    };
                    AllPrice.Add(Prices);

                }
            }
            try
            {
                string str = "";
                foreach (var c in AllPrice)
                {
                    str += $"{c.Visitor_Type},{c.One_Hour},{c.Two_Hour},{c.Three_Hour},{c.Four_Hour},{c.Whole_Day}\n";
                }
                Utility.WriteToCSV(str, _filePath);
                MessageBox.Show("Saved Sucessfully.");
            }
            catch (Exception expe)
            {
                Console.WriteLine(expe);
            }

        }






        private void Delete_Button_Click(object sender, EventArgs e)
        {
            selectedRow = PriceDataGridView.CurrentCell.RowIndex;
            PriceDataGridView.Rows.RemoveAt(selectedRow);
        }

        private void ReportButton_Click(object sender, EventArgs e)
        {
            (new Report()).Show();
            this.Hide();
        }

        private void LogOut_Button_Click(object sender, EventArgs e)
        {
            (new Login()).Show();
            this.Hide();
        }

        private void LoadExceptionButton_Click(object sender, EventArgs e)
        {
            List<PriceException> lstHolidayAndWeekDay = new List<PriceException>();

            try
            {
                string data = Utility.ReadFromTXT(@"C:\Users\user\OneDrive\Desktop\Recreational_Centre\bin\Debug\HolidayAndWeekDayRate.txt");
                if (data != null && data != "")
                {
                    lstHolidayAndWeekDay = JsonConvert.DeserializeObject<List<PriceException>>(data);
                }
            }
            catch (Exception excep)
            {
                Console.WriteLine(excep);
            }
            var bindingList = new BindingList<PriceException>(lstHolidayAndWeekDay);
            var source = new BindingSource(bindingList, null);
            holidayandweekdayGridView.DataSource = source;
        }

        private void SaveExceptionButton_Click(object sender, EventArgs e)
        {

            try
            {
                List<PriceException> lstHolidayAndWeekDay = new List<PriceException>();

                if (PriceDataGridView.Rows != null)
                {
                    var ticketException = new PriceException
                    {
                        WeekDayPrice = holidayandweekdayGridView.Rows[0].Cells[0].Value.ToString(),
                        HolidayPrice = holidayandweekdayGridView.Rows[0].Cells[1].Value.ToString()
                    };
                    lstHolidayAndWeekDay.Add(ticketException);
                }
                string str = JsonConvert.SerializeObject(lstHolidayAndWeekDay);
                Utility.WriteToCSV(str, @"C: \Users\user\OneDrive\Desktop\Recreational_Centre\bin\Debug\HolidayAndWeekDayRate.txt");
            }
            catch (Exception excep)
            {
                Console.WriteLine(excep);
            }
        }
    }
}
