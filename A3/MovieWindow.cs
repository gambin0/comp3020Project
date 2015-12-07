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
    public partial class MovieWindow : Form
    {
        private Movie currMovie = Logic.list.ElementAt(0);

        public MovieWindow()
        {
            InitializeComponent();

            this.MinimizeBox = false;
            this.MaximizeBox = false;

            //fill movie window vars
            this.movieTitle.Text = currMovie.title;
            this.labelTime.Text = currMovie.length + " min";
            this.labelCert.Text = currMovie.certification;
            this.labelYear.Text = currMovie.year;
            this.labelRating.Text = currMovie.rating + " stars";
            this.nameDirector.Text = currMovie.director;
            //  this.nameActors.Text = currMovie.actor.ElementAt(0);

            initActors();
            this.Visible = true;
        }

        private void reviewButton_Click(object sender, EventArgs e)
        {
            
            if (!Logic.CurrentUser.username.Equals("") )
            {
                ReviewWindow review = new ReviewWindow(this.currMovie);
                review.Activate();
            }
            else
            {
                MessageBox.Show("Please create an account or login to write a review");
                Login log = new Login();
                log.Activate();
            }
            
        }

        private void initActors()
        {
            String actors;
            int numActors = currMovie.actor.Count;

            switch (numActors)
            {
                case 1:
                    actors = currMovie.actor.ElementAt(0);
                    break;
                case 2:
                    actors = currMovie.actor.ElementAt(0) + ", " + currMovie.actor.ElementAt(1);
                    break;
                default:
                    actors = currMovie.actor.ElementAt(0) + ", " + currMovie.actor.ElementAt(1) + ", " + currMovie.actor.ElementAt(2);
                    break;
            }

            

            this.nameActors.Text = actors;
        }

        private void addToWatchList_Click(object sender, EventArgs e)
        {

        }

        private void reviewsButton_Click(object sender, EventArgs e)
        {
            ViewReviews rev = new ViewReviews(this.currMovie);
            rev.Activate();
        }
    }
}
