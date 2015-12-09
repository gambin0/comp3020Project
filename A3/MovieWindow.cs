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
    public partial class MovieWindow : Form
    {
        public static Movie currMovie = Logic.list.ElementAt(0);
        TextInfo myTI = new CultureInfo("en-US", false).TextInfo;

        public MovieWindow()
        {
            InitializeComponent();

            this.MinimizeBox = false;
            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            //fill movie window vars
            loadMovie();
            //  this.nameActors.Text = currMovie.actor.ElementAt(0);

            initActors();
            //loadTopReviews();
            this.Visible = true;
        }
        public void loadMovie(){
            movieTitle.Text     = myTI.ToTitleCase(currMovie.title);
            labelTime.Text      = currMovie.length + " min";
            labelCert.Text      = currMovie.certification.ToUpper();
            labelYear.Text      = currMovie.year;
            labelRating.Text    = currMovie.rating + " stars";
            nameDirector.Text   = myTI.ToTitleCase(currMovie.director);
        }

        private void reviewButton_Click(object sender, EventArgs e)
        {
            String action = "write a review";
            if (validLogin(action))
            {
                ReviewWindow review = new ReviewWindow(currMovie);
                review.Activate();
                this.Refresh();
            }           
            
        }

        private Boolean validLogin(String action)
        {
            Boolean valid = true;

            if (Logic.CurrentUser == null)
            {
                MessageBox.Show("Please create an account or login to " + action);
                Login log = new Login();
                log.Activate();
                valid = false;
            }

            return valid;
        }

        private void initActors()
        {
            String actors;
            int numActors = currMovie.actor.Count;

            switch (numActors)
            {
                case 1:
                    actors = myTI.ToTitleCase(currMovie.actor.ElementAt(0));
                    break;
                case 2:
                    actors = myTI.ToTitleCase(currMovie.actor.ElementAt(0)) + ", " + myTI.ToTitleCase(currMovie.actor.ElementAt(1));
                    break;
                default:
                    actors = myTI.ToTitleCase(currMovie.actor.ElementAt(0)) + ", " + myTI.ToTitleCase(currMovie.actor.ElementAt(1)) + ", " + myTI.ToTitleCase(currMovie.actor.ElementAt(2));
                    break;
            }

            this.nameActors.Text = actors;
        }

        private void loadTopReviews()
        {
            /*int revCount = 0;
            int count = 0;
            int length = Logic.reviews.Count;
            String review = "";
            MovieReview rev;

            while (revCount < 3 && count != length)
            {
               rev = Logic.reviews.ElementAt(count);
               if ( rev.movie.Equals(currMovie))
                {
                    review = formatReview(rev) + "\r\n\r\n";
                    revCount += 1;
                }
               count += 1;
            }*/

            int count = 0;
            String review = "";
            foreach (MovieReview rev in Logic.reviews)
            {
                if (rev.movie.Equals(currMovie) && count < 3)
                {
                    review = formatReview(rev) + "\r\n\r\n";
                    count += 1;
                }

            }
            this.topReviews.Text = review;
        }

        private String formatReview(MovieReview review)
        {
            String formatRev = review.owner.username + "  " + review.rating + " Stars" + "\r\n\r\n" + review.comments;
            return formatRev;
        }

        private void addToWatchList_Click(object sender, EventArgs e)
        {
            String action = "add movie to Watchlist";

            if (validLogin(action))
            {
                Logic.CurrentUser.addToWatchlist(currMovie);
                //WatchList wlist = new WatchList();
                //wlist.Activate();
               
            }
            
        }

        private void reviewsButton_Click(object sender, EventArgs e)
        {
            
            ViewReviews rev = new ViewReviews(currMovie);
            rev.Activate();
        }

        private void MovieWindow_Load(object sender, EventArgs e)
        {

        }

        private void linkAllReviews_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ViewReviews rev = new ViewReviews(currMovie);
            rev.Activate();
        }

        private void buttonWatchlist_Click(object sender, EventArgs e)
        {
            String action = "view your Watchlist";
            if (validLogin(action))
            {
                WatchList wlist = new WatchList();
                wlist.Activate();
            }
            
        }
    }
}
