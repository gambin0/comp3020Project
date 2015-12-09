using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A3
{
    public class User 
    {
        public String username;
        public String password;
        private List<Movie> watchList = new List<Movie>();

        public void setVars(String username, String password)
        {
            this.username = username;
            this.password = password;
        }

        public string print()
        {
            return " " + username + " " + password; 
        }

        public void addToWatchlist(Movie newMovie)
        {
            watchList.Add(newMovie);
        }
        public int sizeWatchlist()
        {
            return watchList.Count;
        }
        public Movie getMovie(int num)
        {
            return watchList.ElementAt(num);
        }


    }
}
