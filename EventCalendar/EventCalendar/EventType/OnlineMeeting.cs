using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventCalendar.EventType
{
    public  class OnlineMeeting:EventBase
    {
        private string MeetingPlatform;
        public string meetingPlatform
        {
            get { return MeetingPlatform; }
            set { MeetingPlatform = value; }
    
        }
        public OnlineMeeting()
        {

        }
    }


}
