using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace A3
{
    public class Logic
    {
        public static List<Movie> list              = new List<Movie>();
        public static List<String> genres           = new List<String>();
        public static List<String> certifications   = new List<String>();
        public static List<Movie> search            = new List<Movie>();
        public static List<User> users              = new List<User>();
        public Logic()
        {
            loadFromxml();

        }
        public static void loadDataToScatterPlot(){
            search = Sort(search);
            System.Windows.Forms.DataVisualization.Charting.Chart chart = Form1.scatter;

            
            chart.ChartAreas["ChartArea1"].AxisY.Name = "Rating";
            chart.ChartAreas["ChartArea1"].AxisX.Name = "Year";
            chart.ChartAreas["ChartArea1"].AxisX.MajorGrid.Enabled = false;
            chart.ChartAreas["ChartArea1"].AxisY.MajorGrid.Enabled = false;
            chart.ChartAreas["ChartArea1"].AxisX.MinorGrid.Enabled = false;
            chart.ChartAreas["ChartArea1"].AxisY.MinorGrid.Enabled = false;
            chart.Series.Clear();


            for (int i = 0; i < search.Count; i++)
            {
                Movie m = search.ElementAt(i);
                int x = Int32.Parse(m.year);
                int y = Int32.Parse(m.rating);
               
                chart.Series.Add(m.title);
                chart.Series[m.title].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
                chart.Series[m.title].MarkerSize = 10;
                chart.Series[m.title].MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Diamond;
                chart.Series[m.title].Points.AddXY(x, y);
                chart.Series[m.title].Label = m.title;
            }

        }

        public static List<Movie> Sort(List<Movie> input)
        {
            return input.OrderBy(o => o.title).ToList();
        }

        public String listToString(List<String> input)
        {
            String result = "";
            foreach (String s in input)
            {
                result += s + ",";
            }
            return result;
        }
        public List<Movie> findTitle(String input)
        {
            List<Movie> results = new List<Movie>();
            if (!input.Equals(""))
            {
                foreach (Movie m in list)
                {
                    if (m.title.Contains(input))
                    {
                        results.Add(m);
                    }

                }
            }
            return results;
        }
        public List<Movie> findYear(String input)
        {
            List<Movie> results = new List<Movie>();
            if (!input.Equals(""))
            {
                foreach (Movie m in list)
                {
                    if (m.year.Equals(input))
                    {
                        results.Add(m);
                    }

                }
            }
            return results;
        }
        public List<Movie> findLength(String input)
        {
            List<Movie> results = new List<Movie>();
            if (!input.Equals(""))
            {
                foreach (Movie m in list)
                {
                    if (m.length.Equals(input))
                    {
                        results.Add(m);
                    }

                }
            }
            return results;
        }
        public List<Movie> findCertification(String input)
        {
            List<Movie> results = new List<Movie>();
            if (!input.Equals(""))
            {
                foreach (Movie m in list)
                {
                    if (m.certification.Equals(input))
                    {
                        results.Add(m);
                    }

                }
            }
            return results;
        }
        public List<Movie> findDirector(String input)
        {
            List<Movie> results = new List<Movie>();
            if (!input.Equals(""))
            {
                foreach (Movie m in list)
                {
                    if (m.director.Equals(input))
                    {
                        results.Add(m);
                    }

                }
            }
            return results;
        }
        public List<Movie> findRating(String input)
        {
            List<Movie> results = new List<Movie>();
            if (!input.Equals(""))
            {
                foreach (Movie m in list)
                {
                    if (m.rating.Equals(input))
                    {
                        results.Add(m);
                    }

                }
            }
            return results;
        }
        public List<Movie> findActor(String input)
        {
            List<Movie> results = new List<Movie>();
            if (!input.Equals(""))
            {
                foreach (Movie m in list)
                {
                    if (m.actor.Contains(input))
                    {
                        results.Add(m);
                    }

                }
            }
            return results;
        }
        public List<Movie> findGenre(String input)
        {
            List<Movie> results = new List<Movie>();
            if (!input.Equals(""))
            {
                foreach (Movie m in list)
                {
                    if (m.genre.Contains(input))
                    {
                        results.Add(m);
                    }

                }
            }
            return results;
        }
        private void loadFromxml()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("movies.xml");
            string title = "";
            string year = "";
            string length = "";
            string certification = "";
            string director = "";
            string rating = "";
            List<String> genre;
            List<String> actor;

            foreach (XmlNode node in doc.GetElementsByTagName("movie"))
            {
                title = "";
                year = "";
                length = "";
                certification = "";
                director = "";
                rating = "";
                genre = new List<String>();
                actor = new List<String>();
                foreach (XmlElement n in node.ChildNodes)
                {
                    String text = n.InnerText;
                    text = text.ToLower();
                    text = text.Trim();

                    if (text.Equals("Music"))
                    {
                        text = "Musical";
                    }
                    if (n.LocalName.Equals("title"))
                    {
                        title = text;
                    }
                    else if (n.LocalName.Equals("year"))
                    {
                        year = text;
                    }
                    else if (n.LocalName.Equals("length"))
                    {
                        String[] val = text.Split(' ');
                        length = val[0];
                    }
                    else if (n.LocalName.Equals("certification"))
                    {
                        if (!certifications.Contains(text))
                        {
                            certifications.Add(text);
                        }
                        certification = text;
                    }
                    else if (n.LocalName.Equals("director"))
                    {
                        director = text;
                    }
                    else if (n.LocalName.Equals("rating"))
                    {
                        rating = text;
                    }
                    else if (n.LocalName.Equals("genre"))
                    {
                        if (!genres.Contains(text))
                        {
                            genres.Add(text);
                        }
                        genre.Add(text);
                    }
                    else if (n.LocalName.Equals("actor"))
                    {
                        actor.Add(text);
                    }
                }
                Movie temp = new Movie(title, year, length, certification, director, rating, genre, actor);
                if (!list.Contains(temp))
                {
                    list.Add(temp);
                }
            }
        }

    }
}
