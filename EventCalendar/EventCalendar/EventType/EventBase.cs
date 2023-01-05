using Stripe;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Reflection.Metadata;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace EventCalendar.EventType
{


    public class EventBase : IEventInterface
    {
        private int id;
        public int ID
        {

            get { return id; }
            set { id = value; }

        }

        private string eventName;
        public string EventName
        {
            get { return eventName; }
            set { eventName = value; }

        }
        private string eventDescription;
        public string EventDescription
        {
            get { return eventDescription; }
            set { eventDescription = value; }
        }
        private int startDate;
        public int StartDate
        {
            get
            {
                return startDate;
            }
            set
            {
                startDate = value;
            }
        }
        private int endDate;
        public int EndDate
        {
            get
            {
                return endDate;
            }
            set
            {
                endDate = value;
            }
        }
        public EventBase()
        {

        }
        public EventBase(int id, string eventName, string eventDescription, int startDate, int endDate)
        {
            ID = id;
            EventName = eventName;
            EventDescription = eventDescription;
            StartDate = startDate;
            EndDate = endDate;
        }
    
        

       


        public void Holiday()
        {
           
            
            Console.WriteLine("Type Of Event:");
            string HolidayType = Console.ReadLine();

            Console.WriteLine("Name Of Event:");
            string HolidayName = Console.ReadLine();
            



            Console.WriteLine("Date Of Event: ");
          
            var startDate = Console.ReadLine().ToString();

            Console.WriteLine("End Date OF Event");
          
            var endDate = Console.ReadLine().ToString();


            Console.WriteLine("Please Enter Event Idetification Code:");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Job Done: Event Type:{HolidayType} ,Event name: {HolidayName}, Event Start:{startDate},Even End:{endDate}, id:{id}    " +
                $" 1.Yes .2.No", HolidayType, HolidayName, startDate,endDate,id);
            var Choice = Convert.ToInt32(Console.ReadLine());
            if (Choice == 1)
            {

                Console.WriteLine("Your Event Is Saved");
            }
            else if (Choice == 2)
            {
                Console.WriteLine("Please Reply Your Data ");
                var newMeeting = new Meeting();
                newMeeting.Holiday();
            }
            
        }
        public void Meeting()
        {
            Console.WriteLine("Enter Name For Meeting");

            string MeetingType = Console.ReadLine();

           


            Console.WriteLine("Date Of Meeting: ");
            var startDate = Console.ReadLine().ToString();



            Console.WriteLine("Enter 3 number For Idetification:");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" Add Names For Meeting: 1.Yes 2.No");
            int MeetName = Convert.ToInt32(Console.ReadLine());
            if (MeetName == 1)
            {
                Console.WriteLine("Enter Names:");
                string PersonName = Console.ReadLine();

                Console.WriteLine("Event Is Saved");

            }
            else if (MeetName == 2)
            {

                Console.WriteLine("Event Is Saved");
            }


        }
        public void GeneralEvent()
        {
            Console.WriteLine("Type Of Event:");
            string EventType = Console.ReadLine();

            Console.WriteLine("Name OF EvenT:");
            string EventDate = Console.ReadLine();
          


            Console.WriteLine("Date Of Event: ");
            var startDate = Console.ReadLine().ToString();

            Console.WriteLine("End Date Of Event:");
            var endDate = Console.ReadLine().ToString();

            Console.WriteLine("Enter 3 Number For Idetification:");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Job Done:{EventType} , {EventDate} , {startDate} , {endDate} da {id}", EventType, EventDate, startDate, endDate, id );


            Console.WriteLine("Event Is Saved");

        
    }
        public void OnlineMeeting()
        {

            Console.WriteLine("Type Of Event:");
            string Mtype = Console.ReadLine();

            Console.WriteLine("Name Of Online Meeting:");
            string Mname = Console.ReadLine();



            Console.WriteLine("Date Of Event: ");
            var startDate = Console.ReadLine().ToString();

            Console.WriteLine("End OF Event:");
            var endDate = Console.ReadLine().ToString();



            Console.WriteLine("Enter 3 Number For Idetification::");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Job Done:{Mtype} , {Mtype} ,{startDate} ,{endDate} da {id}", Mtype, Mtype,startDate,endDate,id);


            Console.WriteLine("Event Is Saved");


        }


        public void AddEvent(EventBase newEvent)
        {
          throw new NotImplementedException();
        }

        public void RemoveEvent()
        {
            throw new NotImplementedException();
        }

        public void RemoveAllEvents()
        {
            throw new NotImplementedException();
        }

        public void ChangeEvent()
        {
            throw new NotImplementedException();
        }

       

        public void SeeAllEvents()
        {
            throw new NotImplementedException();
        }

        public void AddEvent()
        {
            throw new NotImplementedException();
        }

        public void RemoveAll()
        {
            throw new NotImplementedException();
        }
    }
}

