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

        public void setVars(String username, String password)
        {
            this.username = username;
            this.password = password;
        }

        public string print()
        {
            return " " + username + " " + password; 
        }
    }
}
