using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A3
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            this.Visible = true;
        }

        private void lblUserName_Click(object sender, EventArgs e)
        {
           
        }

        private void btnNewLogin_Click(object sender, EventArgs e)
        {
            CreateLogincs login = new CreateLogincs();
            login.Activate();
            this.Close();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            lblError.Text = "";
            Boolean found = false;
            for (int i = 0; i < Logic.users.Count & !found; i++)
            {
                if (Logic.users.ElementAt(i).username.Equals(txtUserName.Text))
                {
                    User curr = Logic.users.ElementAt(i);
                    found = true;
                    if (curr.password.Equals(txtPassword.Text))
                    {
                        Logic.CurrentUser = curr;
                        Form1.user.Text = curr.username;
                        this.Close();
                    }
                    else
                    {
                        lblError.Text = "Incorrect Password!";
                        break;
                        // wrong password
                    }
                }
  
            }
            if(!found)
            {
                lblError.Text = "Username Not Found!";
                    // user not found
            }


        }

           
    }
}

