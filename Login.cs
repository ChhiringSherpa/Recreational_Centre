using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.Xml.Serialization;

namespace Recreational_Centre
{
    public partial class Login : Form
    {
        public List<Users> Users;
        public Login()
        {
            InitializeComponent();
            Type_comboBox.SelectedIndex = 0;
            Users = new List<Users>();
        }



        private void LoginBtn_Click(object sender, EventArgs e)
        {
            if (Username_Txt.Text == "" || Password_Txt.Text == "")
            {
                MessageBox.Show("Username or password in empty.",
                "Close Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (Type_comboBox.SelectedIndex == 0)
            {
                var xmlSerializer = new XmlSerializer(typeof(Users));
                FileStream fileStream = new FileStream(@"C:\Users\user\OneDrive\Desktop\Recreational_Centre\AdminForm.xml", FileMode.OpenOrCreate, FileAccess.Read);
                {
                    Users admin = (Users)xmlSerializer.Deserialize(fileStream);

                    if (Password_Txt.Text == admin.Password && Username_Txt.Text == admin.UserName)
                    {
                        (new AdminForm()).Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Wrong username or password please try again.",
                        "Close Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        fileStream.Close();
                        Password_Txt.Clear();
                        Username_Txt.Clear();

                    }
                }


            }
            else
            {
                var xmlSerializer = new XmlSerializer(typeof(List<Users>));
                FileStream fileStream = new FileStream(@"C:\Users\user\OneDrive\Desktop\Recreational_Centre\Login.xml", FileMode.OpenOrCreate, FileAccess.Read);
                {
                    List<Users> staff = (List<Users>)xmlSerializer.Deserialize(fileStream);
                    foreach (Users s in staff)
                    {

                        if (s.Password == Password_Txt.Text && Username_Txt.Text == s.UserName)
                        {
                            (new UserForm()).Show();
                            this.Hide();
                            return;
                        }
                    }
                    MessageBox.Show("Wrong username or password please try again.",
                    "Close Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    fileStream.Close();
                    Password_Txt.Clear();
                    Username_Txt.Clear();
                }

            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
    [Serializable()]
    public class Users
    {
        public string UserName { get; set; }
        public string Password { get; set; }

        public Users(string _userName, string _password)
        {
            this.UserName = _userName;
            this.Password = _password;
        }
        public Users()
        {
        }
    }
}
