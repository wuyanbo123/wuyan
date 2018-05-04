using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jieye
{
   public class Movie
    {
       public enum MovieType
       {
           //喜剧
           Comedy,
           //战争
           war,
           //爱情
           Romance,
           //动作
           Action,
           //卡通
           Cartoon,
           //恐怖
           Thriler,
           //冒险
           Adventure
       }
        private string poster;

        public string Poster
        {
            get { return poster; }
            set { poster = value; }
        }
        public Movie() { }
        public Movie(string movieName, string poster, string director, string actor, MovieType moieType,
            string  price)
        {
            this.MovieName = movieName;
            this.poster = poster;
            this.Director = director;
            this.Actor = actor;
            this.Price = price.ToString();
        }
        public string MovieName { get; set; }//电影名
        
        public string Director { get; set; }//导演名
        
        public string Actor { get; set; }//主演
       
        public string  Price { get; set; }//定价
         
        public MovieType movieType { get; set; }//电影类型

        public string Time { get; set; }//放映时间
    }
}
