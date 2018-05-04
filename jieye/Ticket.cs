using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jieye
{
   public class Ticket
    {
        public Ticket() { }
       public Ticket(Scheduleltem scheduleItem,Seat seat) {
           this.ScheduleItem = scheduleItem;
           this.Seat = seat;
       }//座位对象
       private Seat seat;

       public Seat Seat
       {
           get { return seat; }
           set { seat = value; }
       }
       //票价
       private int price;

       public int Price
       {
           get { return price; }
           set { price = value; }
       }
       //所属的放映场次
       private  Scheduleltem scheduleItem;

       public Scheduleltem ScheduleItem
       {
           get { return scheduleItem; }
           set { scheduleItem = value; }
       }
       public virtual void Calcprice()
       {
           //this.price = this.ScheduleItem.Movie.price;
       }
       public virtual void print()
       {
           //string fileName = this.ScheduleItem.Time.Replace(":", "-") + "" + this.Seat.SeatNum + ".txt";
           //FileS;
       }
       public virtual void show() { 
  
       }
    
    }
}
