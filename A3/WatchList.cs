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
        int maxPosters = 5;


        public WatchList()
        {
            InitializeComponent();
            loadUser();
            loadPosters();

            this.MinimizeBox = false;
            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
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
            
            
            

            if ( sizeWatchlist < maxPosters) //do initial load
            {
                switch (sizeWatchlist)
                {
                    case 0:
                        
                        break;
                    case 1:
                        label1.Visible = true;
                        label2.Visible = false;
                        label3.Visible = false;
                        label4.Visible = false;
                        label5.Visible = false;
                        label1.Text = myTI.ToTitleCase(currUser.getMovie(posters[0]).title);
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
                        
                        break;
                }
                
                
            }
            else
            {
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
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (posters[0] - 5 >= 0 )
            {
                for (int i = 0; i < 5; i++)
                {
                    posters[i] -= 5;
                }
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

                loadUser();
                this.Refresh();
                //reloadPage();
                //Application.DoEvents();


            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int length = posters.Length;
            int last = 4;


            if(sizeWatchlist > 5 )
            {

                

                
                if (posters[4] + 5  < sizeWatchlist )
                {

                    //increase poster indexes
                    for (int i = 0; i < length; i++)
                    {
                        posters[i] += 5;
                    }

                    //change all 5 posters
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
                }
                else if (posters[0] + 5 <= sizeWatchlist-1) //change what is required.
                {
                    int posterMod = sizeWatchlist % maxPosters;

                    //increase poster indexes
                    for (int i = 0; i < length; i++)
                    {
                        posters[i] += 5;
                    }

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
                            label1.Text = myTI.ToTitleCase(currUser.getMovie(posters[0]).title);
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
                }//end if

                //valid to refresh
                loadUser();
                this.Refresh();

               // reloadPage();
            }
            
            
            
           // Application.DoEvents();
        }

        private void reloadPage()
        {
            loadUser();
            loadPosters();

            this.Refresh();
        }

        private void linkLabelFacebook_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("You're watchlist has been shared on your facebook news feed!");
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Email em = new Email();
            em.Activate();
        }
    }
}
