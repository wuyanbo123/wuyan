using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jieye
{
   public class FreeTicket
    {
        public FreeTicket() { }
        private string customerName;

        public string CustomerName
        {
            get { return customerName; }
            set { customerName = value; }
        }
        public FreeTicket(Scheduleltem scheduleItem, Seat seat, string customerName)
            :base()
        {
            this.CustomerName = customerName;
        }
        //public override void Calcprice()
        //{
        //    //this.price = 0;
        //}
    }
}
