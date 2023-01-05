using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventCalendar.EventType
{
    public  class holiday:EventBase
    {
      private string HolidayName;
        public string holidayname
        {
            get
            {
                return HolidayName;
            }
            set
            {
               HolidayName = value;
            }

        }
        private string HolidayType;
        public string holidaytype
        {
            get { return HolidayType; }
            set { HolidayType= value; } 
        }
       public holiday()
        {
            

        }
    }
}
