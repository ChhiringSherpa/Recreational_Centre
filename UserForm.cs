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
using Newtonsoft.Json;
using System.Xml.Serialization;

namespace Recreational_Centre
{
    public partial class UserForm : Form
    {
        List<CustomerInfo> customers;
        public UserForm()
        {
            InitializeComponent();
            StartTimer();

            init();
            DisplayCutsomerInfoCSV();
            VisitorType_ComboBox.SelectedIndex = 0;

        }
        System.Windows.Forms.Timer timer = null;

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
        }
        private void StartTimer()
        {

            timer = new System.Windows.Forms.Timer();
            timer.Interval = 1000;
            timer.Tick += new EventHandler(dateTime);
            timer.Enabled = true;


            DayOfWeek days = DateTime.Today.DayOfWeek;

            if (days.ToString() == "Sunday" || days.ToString() == "Saturday")
            {
                Day_TextBox.Text = "Holidays";
            }
            else
            {
                Day_TextBox.Text = "Weekdays";

            }
        }
        public void dateTime(object sender, EventArgs e)
        {
            CheckIn.Value = DateTime.Now;
        }

        private void Save_Button_Click(object sender, EventArgs e)
        {
            /*
            if (ID_TextBox.Text.Trim().Length == 0)
            {
                validLabel.Visible = true;
            }

            else if (Name_TextBox.Text.Trim().Length == 0)
            {
                validLabel.Visible = true;
            }
            else if (Price_TextBox.Text.Trim().Length == 0)
            {
                validLabel.Visible = true;
            }
            else if (TotalPeople_TextBox.Text.Trim().Length == 0)
            {
                validLabel.Visible = true;
            }

            else if (VisitorType_ComboBox.SelectedIndex == -1)
            {
                validLabel.Visible = true;
            }
            else if (Price_TextBox.Text.Trim().Length == 0)
            {
                validLabel.Visible = true;
            }
            */

            CustomerInfo ci = new CustomerInfo();

            ci.ID   = (int)(ID_TextBox.Value);
            ci.Name = Name_TextBox.Text;
            ci.Age  = (int)Age_TextBox.Value;
            ci.Date = dateTimePicker1.Value.Date;
            ci.Total_People =(int) TotalPeople_TextBox.Value;
            ci.Visitor_Type = VisitorType_ComboBox.Text;
            ci.Check_In = CheckIn.Value.Date;
            ci.Check_Out = CheckOut.Value.Date;
            ci.Price = double.Parse(Price_TextBox.Text);

            customers.Add(ci);

            DisplayCutsomerInfoCSV();
            SaveInfo();
        }

        private void SaveInfo()
        {
            try
            {
                Stream stream = new FileStream("../../SavedCustomerData.xml", FileMode.Create, FileAccess.Write);
                XmlSerializer formatter = new XmlSerializer(typeof(List<CustomerInfo>));
                formatter.Serialize(stream, customers);
                stream.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("Couldn't open or serealize the customers data .xml your your Menu is not being saved.\n" + e.Message,
                    "Close Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

/*
            using (StreamWriter sw = File.AppendText(@"C:\Users\user\OneDrive\Desktop\Recreational_Centre\bin\Debug\CustomerInfo.csv"))
            {
                sw.WriteLine(ID_TextBox.Text + ", " + Name_TextBox.Text + "," + Age_TextBox.Text + "," + dateTimePicker1.Text + "," + TotalPeople_TextBox.Text + "," + VisitorType_ComboBox.Text + "," + CheckIn.Text + "," + CheckOut.Text + "," + Day_TextBox.Text + "," + Price_TextBox.Text);
                MessageBox.Show("Customer Information Saved.");
                ClearData();
          
            }
            */
        }


        private void DisplayCutsomerInfoCSV()
        {
            /*
            var lines = File.ReadAllLines(@"C:\Users\user\OneDrive\Desktop\Recreational_Centre\bin\Debug\CustomerInfo.csv");
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

            dataGridView1.Rows.Clear();
            foreach(CustomerInfo cs in customers){
                dataGridView1.Rows.Add(cs.ToStringArray().ToArray());
            }

            //dataGridView1.DataSource = customers;
        }

        private void ClearData()
        {
            Name_TextBox.Clear();
            Price_TextBox.Clear();
            VisitorType_ComboBox.SelectedIndex = 0;
            CheckIn.Value = DateTime.Now;
            CheckOut.Value = DateTime.Now;
            Day_TextBox.Clear();
            Price_TextBox.Clear();
           
        }

        private void UserForm_Load(object sender, EventArgs e)
        {

        }

        private void LogOut_Button_Click(object sender, EventArgs e)
        {
            (new Login()).Show();
            this.Hide();
        }
    }
}
