using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace A3
{
    public partial class WatchList : Form
    {
        User currUser = Logic.CurrentUser;
        int sizeWatchlist;
        TextInfo myTI = new CultureInfo("en-US", false).TextInfo;
        int[] posters =  new int[5] { 0, 1, 2, 3, 4 };

        public WatchList()
        {
            InitializeComponent();
            loadUser();
            loadPosters();
            this.Visible = true;
            
        }

        private void loadUser()
        {
            header.Text = currUser.username + "'s Watchlist";
            sizeWatchlist = currUser.sizeWatchlist();
            labelTitles.Text = sizeWatchlist.ToString() + " Titles" ;

        }

        private void loadPosters()
        {
            
            
            int posterMod = sizeWatchlist % 5;

            if (sizeWatchlist == 0)
                posterMod = -1;//no posters

            switch (posterMod)
            {
                case 0:
                    label1.Visible = true;
                    label2.Visible = true;
                    label3.Visible = true;
                    label4.Visible = true;
                    label5.Visible = true;
                    label1.Text = myTI.ToTitleCase(currUser.getMovie(posters[0]).title);
                    label2.Text = myTI.ToTitleCase(currUser.getMovie(posters[1]).title);
                    label3.Text = myTI.ToTitleCase(currUser.getMovie(posters[2]).title);
                    label4.Text = myTI.ToTitleCase(currUser.getMovie(posters[3]).title);
                    label5.Text = myTI.ToTitleCase(currUser.getMovie(posters[4]).title);
                    break;
                case 1:
                    label1.Visible = true;
                    label2.Visible = false;
                    label3.Visible = false;
                    label4.Visible = false;
                    label5.Visible = false;
                    label1.Text = myTI.ToTitleCase( currUser.getMovie(posters[0]).title );
                    break;
                case 2:
                    label1.Visible = true;
                    label2.Visible = true;
                    label3.Visible = false;
                    label4.Visible = false;
                    label5.Visible = false;
                    label1.Text = myTI.ToTitleCase(currUser.getMovie(posters[0]).title);
                    label2.Text = myTI.ToTitleCase(currUser.getMovie(posters[1]).title);
                    break;
                case 3:
                    label1.Visible = true;
                    label2.Visible = true;
                    label3.Visible = true;
                    label4.Visible = false;
                    label5.Visible = false;
                    label1.Text = myTI.ToTitleCase(currUser.getMovie(posters[0]).title);
                    label2.Text = myTI.ToTitleCase(currUser.getMovie(posters[1]).title);
                    label3.Text = myTI.ToTitleCase(currUser.getMovie(posters[2]).title);
                    
                    break;
                case 4:
                    label1.Visible = true;
                    label2.Visible = true;
                    label3.Visible = true;
                    label4.Visible = true;
                    label5.Visible = false;
                    label1.Text = myTI.ToTitleCase(currUser.getMovie(posters[0]).title);
                    label2.Text = myTI.ToTitleCase(currUser.getMovie(posters[1]).title);
                    label3.Text = myTI.ToTitleCase(currUser.getMovie(posters[2]).title);
                    label4.Text = myTI.ToTitleCase(currUser.getMovie(posters[3]).title);
                    break;
                default:
                    //do nothing 
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 5; i++)
            {
                posters[i] -= 5;
            }
            loadPosters();
            this.Refresh();
            //Application.DoEvents();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int max = sizeWatchlist;
            if (max == 0)
                max = 5;
            for (int i=0; i<max; i++)
            {
                posters[i] += 5;
            }
            loadPosters();
            this.Refresh();
            
           // Application.DoEvents();
        }
    }
}
