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
        public int id;
        public List<MovieReview> reviews = new List<MovieReview>();

        public User(String username, String password)
        {
            // before creating a use make sure theny dont exist.
            this.username = username;
            this.password = password;
            id = username.GetHashCode();
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
    }
}
