using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jieye
{//学生票价
   public class StudentTicket:Ticket
    {
        public StudentTicket() { }
       public StudentTicket(Scheduleltem scheduleItem, Seat seat, int disconut) : base(scheduleItem, seat) {
           this.Discount = disconut;
       }
       private int discnut;

       public int Discnut
       {
           get { return discnut; }
           set { discnut = value; }
       }
       //public override void Calcprice() {
       //    this.Price = this.ScheduleItem.Movie.price * Discnut / 10;
       //}

       public int Discount { get; set; }
    }
    }

