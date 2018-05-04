
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jieye
{
   public class Seat
    {
        public Seat(string seatNum, Color color)
        {
            this.SeatNum = seatNum;
            this.Color = color;
        }
        //座位号
        private string seatNum;

        public string SeatNum
        {
            get { return seatNum; }
            set { seatNum = value; }
        }
        //显示售出与否颜色属性
        private Color color;

        public Color Color
        {
            get { return color; }
            set { color = value; }
        }
    }
}
