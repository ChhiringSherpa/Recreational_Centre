using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recreational_Centre
{
    class Price
    {

        public string Visitor_Type { get; set; }
        public int One_Hour { get; set; }
        public int Two_Hour { get; set; }
        public int Three_Hour { get; set; }
        public int Four_Hour { get; set; }
        public int Whole_Day { get; set; }
    }

    class PriceException
    {
        public string WeekDayPrice { get; set; }
        public string HolidayPrice { get; set; }
    }
}

