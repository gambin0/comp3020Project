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
    public partial class ViewReviews : Form
    {
        private Movie currMovie;
        private int reviewCount;

        public ViewReviews(Movie inMovie)
        {
            InitializeComponent();

            this.MinimizeBox = false;
            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.currMovie = inMovie;
            this.reviewCount = loadReviews();
            loadHeader();

            this.Visible = true;
        }

        //get total reviews for this movie and load all reviews for this movie to view 
        private int loadReviews()
        {
            int count = 0;
            String review = "";
            foreach (MovieReview rev in Logic.reviews)
            {
                if (rev.movie.Equals(currMovie))
                {
                    review = review + formatReview(rev) + "\r\n\r\n\r\n";
                    count += 1;
                }
                    
            }
            this.reviewBox.Text = review;
            return count;
        }

        private void loadHeader()
        {
            TextInfo myTI = new CultureInfo("en-US", false).TextInfo;
            switch (reviewCount)
            {
                case 0:
                    headerReviews.Text =  "No reviews for " + myTI.ToTitleCase(currMovie.title);
                    break;
                case 1:
                    headerReviews.Text = reviewCount.ToString() + " review for " + myTI.ToTitleCase(currMovie.title);
                    break;
                default:
                    headerReviews.Text = reviewCount.ToString() + " reviews for " + myTI.ToTitleCase(currMovie.title);
                    break;
            }
            
        }

        private String formatReview(MovieReview review)
        {
            String formatRev = review.owner.username + "  " + review.rating + " Stars" + "\r\n\r\n" + review.comments;
            return formatRev;
        }

        private void reviewButton_Click(object sender, EventArgs e)
        {
            if (Logic.CurrentUser != null)
            {
                ReviewWindow review = new ReviewWindow(currMovie);

                review.FormClosing += new FormClosingEventHandler(this.ReviewWindow_FormClosing);

                //review.Activate();
                review.Show();
                
            }
            else
            {
                MessageBox.Show("Please create an account or login to write a review");
                Login log = new Login();
                log.Activate();
            }
        }

        private void ReviewWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.reviewCount = loadReviews();
            this.loadHeader();
            this.Refresh();
            //this.reviewBox.Refresh();
        }
    }

     
}
