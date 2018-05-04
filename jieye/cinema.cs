using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jieye
{
   public class cinema
    {
       public Dictionary<string, Seat> Seats = new Dictionary<string, Seat>();
       private Schedule Schedule;

       public Schedule Schedule1
       {
           get { return Schedule; }
           set { Schedule = value; }
       }
       List<Ticket> SoldTickets = new List<Ticket>();
    }
}
