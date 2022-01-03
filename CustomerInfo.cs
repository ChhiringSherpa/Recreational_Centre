using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recreational_Centre
{
    [Serializable]
    public class CustomerInfo
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public DateTime Date { get; set; }
        public int Total_People { get; set; }
        public string Visitor_Type { get; set; }
        public DateTime Check_In { get; set; }
        public DateTime Check_Out { get; set; }
        public string Days { get; set; }
        public double Price { get; set; }

        public CustomerInfo(){

        }

        public List<String> ToStringArray(){
            List<string> ret = new List<string> {ID.ToString(), Name, Age.ToString(), 
            Date.ToShortDateString(), Total_People.ToString(), Visitor_Type, Check_In.ToShortTimeString(), Check_Out.ToShortTimeString(), Days, Price.ToString() };
           return ret;
        }
    }
}
