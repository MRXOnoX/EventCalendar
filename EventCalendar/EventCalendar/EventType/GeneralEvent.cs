using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventCalendar.EventType
{
    public  class GeneralEvent : EventBase
    {
        private string EventType;
        public string eventType
        {
            get { return eventType; }
            set { eventType = value; }
        }
        public GeneralEvent()
        {

        }
    }
}
