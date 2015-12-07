using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A3
{
    public class User : IEquatable<User>
    {
        public String username;
        public String password;
        public List<MovieReview> reviews;
        public int id;

        public void setVars(String username, String password)
        {
            this.username = username;
            this.password = password;
            this.reviews = new List<MovieReview>();
            this.id = username.GetHashCode();
        }


        public static bool operator ==(User one, User two)
        {
            return one.id == two.id;
        }

        public static bool operator !=(User one, User two)
        {
            return !(one == two);
        }

        public bool Equals(User other)
        {
            return this == other;
        }

        public override int GetHashCode()
        {
            return id;
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as User);
        }

        public void AddReview(MovieReview review)
        {
            reviews.Add(review);
        }
        public string print()
        {
            return " " + username + " " + password + " " + id; 
        }
    }
}
