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
        public static Movie currMovie = Logic.list.ElementAt(0);

        public MovieWindow()
        {
            InitializeComponent();

            this.MinimizeBox = false;
            this.MaximizeBox = false;
            //fill movie window vars
            loadMovie();
            //  this.nameActors.Text = currMovie.actor.ElementAt(0);

            initActors();
            this.Visible = true;
        }
        public void loadMovie(){
            movieTitle.Text     = currMovie.title;
            labelTime.Text      = currMovie.length + " min";
            labelCert.Text      = currMovie.certification;
            labelYear.Text      = currMovie.year;
            labelRating.Text    = currMovie.rating + " stars";
            nameDirector.Text   = currMovie.director;
        }

        private void reviewButton_Click(object sender, EventArgs e)
        {
            
            if (Logic.CurrentUser != null )
            {
                ReviewWindow review = new ReviewWindow(currMovie);
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
            ViewReviews rev = new ViewReviews(currMovie);
            rev.Activate();
        }

        private void MovieWindow_Load(object sender, EventArgs e)
        {

        }
    }
}
