using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventCalendar
{
    public interface IEventInterface
    {
        public void AddEvent();

        public void RemoveEvent();

        public void RemoveAll();

        public void RemoveAllEvents();

        public void ChangeEvent();

        public void SeeAllEvents();

   

    }

}
