
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace jieye
{
    public class Schedule
    {
        public Dictionary<string, Scheduleltem> items = new Dictionary<string, Scheduleltem>();//放映场次
        //放映计划列表

        internal Dictionary<string, Scheduleltem> Items
        {
            get { return items; }
            set { items = value; }
        }

        public void LoadItems()
        {
            XmlDocument myXml = new XmlDocument();
            myXml.Load("ShowList.xml");
            XmlNode root = myXml.DocumentElement;
            foreach (XmlNode item in root.ChildNodes)
            {
                Movie movie = new Movie();
                movie.MovieName = item["Name"].InnerText;
                movie.Price = item["Poster"].InnerText;
                movie.Director = item["Director"].InnerText;
                movie.Actor= item["Actor"].InnerText;
                movie.movieType = (jieye.Movie.MovieType)Enum.Parse(typeof(jieye.Movie.MovieType), item["Type"].InnerText);
                movie.Price = item["Price"].InnerText;
                foreach (XmlNode schedule in item["Schedule"].ChildNodes)
                {


                    {
                        Scheduleltem sItem = new Scheduleltem();
                        sItem.Time = schedule.InnerText;
                        sItem.Movie = movie;
                        items.Add(sItem.Time, sItem);

                    }
                }
            }
        }
    }
}
