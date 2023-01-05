 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventCalendar.EventType
{
    public class Meeting:EventBase
    {
       private string PersonName;
        public string personName
        {
          get { return PersonName; }
            set { PersonName = value; }
        }
        public Meeting()
        {

        }
    }
    
}
