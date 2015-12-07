using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A3
{
    public class MovieReview
    {
        public User owner;
        public Movie movie;
        public int rating;
        public String comments;

        public void setVar(User owner, Movie movie, int rating, String comments)
        {
            this.owner = owner;
            this.movie = movie;
            this.rating = rating;
            this.comments = comments;
        }

    }
}
