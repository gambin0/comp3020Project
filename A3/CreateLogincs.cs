using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.IO;

namespace A3
{
    public partial class CreateLogincs : Form
    {
        public CreateLogincs()
        {
            InitializeComponent();
            this.Visible = true;
        }

        private void CreateLogincs_Load(object sender, EventArgs e)
        {

        }

        private void btnCreateUser_Click(object sender, EventArgs e)
        {
            String username = txtUserName.Text;
            String password = txtPassword.Text;

            if (username.Equals(""))
            {
                lblError.Text = "Cannot Use an Empty Username!";
            }
            else if (password.Equals(""))
            {
                lblError.Text = "Cannot Use an Empty Password!";
            }
            else if (username.Length < 6)
            {
                lblError.Text = "Username Must be at Least 6 Characters Long";
            }
            else if (password.Length < 6)
            {
                lblError.Text = "Password Must be at Least 6 Characters Long";
            }

            else
            {
                Boolean userFound = false;
                for (int i = 0; i < Logic.users.Count && !userFound; i++)
                {
                    if (Logic.users.ElementAt(i).username.Equals(username))
                    {
                        userFound = true;
                        lblError.Text = "Username Already in Use!";
                    }
                }

                if (!userFound)
                {
                    User newUser = new User();
                    newUser.setVars(username, password);
                    Logic.users.Add(newUser);
                    Logic.CurrentUser = newUser;
                    Form1.user.Text = username;
                    Logic.saveUsers();
                    

                    this.Close();
                }
            }

        }
    }
}
