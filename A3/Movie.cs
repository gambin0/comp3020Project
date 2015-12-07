using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A3
{
    public class Movie : IEquatable<Movie>
    {
        public string title;
        public string year;
        public string length;
        public string certification;
        public string director;
        public string rating;
        public int id;
        public List<String> genre;
        public List<String> actor;
        public void setVars(string title, string year, string length, string certification, string director, string rating, List<String> genre, List<String> actor)
        {
            this.title = title.Trim();
            this.year = year;
            this.length = length.Trim();
            this.certification = certification.Trim();
            this.director = director.Trim();
            this.rating = rating;
            this.genre = genre;
            this.actor = actor;
            this.id = title.GetHashCode();
        }


        public static bool operator ==(Movie one, Movie two)
        {
            return one.id == two.id;
        }

        public static bool operator !=(Movie one, Movie two)
        {
            return !(one == two);
        }

        public bool Equals(Movie other)
        {
            return this == other;
        }

        public override int GetHashCode()
        {
            return id;
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as Movie);
        }

        public String print()
        {
            String temp = "";

            foreach (String s in genre)
            {
                temp += s + " ";
            }
            foreach (String s in actor)
            {
                temp += s + " ";
            }
            return "" + title + " " + year + " " + length + " " + certification + " " + director + " " + rating + " " + temp;
        }
    }
}
