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
    public partial class ReviewWindow : Form
    {
        private int minReviewLength = 60;
        private int userRating;
        private String req;
        private Movie currMovie;// = Logic.list.ElementAt(0);
        TextInfo myTI = new CultureInfo("en-US", false).TextInfo;

        public ReviewWindow(Movie inMovie)
        {
            InitializeComponent();

            this.MinimizeBox = false;
            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            //temp var
            this.currMovie = inMovie;
            this.movieTitle.Text = myTI.ToTitleCase(currMovie.title);

            this.userRating = 3;
            this.req = this.reviewText.Text;

            updateRateMessage();

            this.Visible = true;
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            //Submit review for this movie  and user
            //check length of review
            String userReview = this.reviewText.Text;

            MovieReview currReview = new MovieReview();
            currReview.setVar(Logic.CurrentUser, currMovie, userRating, userReview);

            if (userReview.Length >= minReviewLength && !req.Equals(userReview) )
            {
                //save review
                Logic.reviews.Add(currReview);
                Logic.saveReviews();
                this.Close();
            }
            else
            {
                //
                MessageBox.Show("Review must be at least 60 characters.");
            }
            
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ReviewWindow_Load(object sender, EventArgs e)
        {

        }

        private void star1_Click(object sender, EventArgs e)
        {
            userRating = 1;
            updateRateMessage();
        }

        private void star2_Click(object sender, EventArgs e)
        {
            userRating = 2;
            updateRateMessage();
        }

        private void star3_Click(object sender, EventArgs e)
        {
            userRating = 3;
            updateRateMessage();
        }

        private void star4_Click(object sender, EventArgs e)
        {
            userRating = 4;
            updateRateMessage();
        }

        private void star5_Click(object sender, EventArgs e)
        {
            userRating = 5;
            updateRateMessage();
        }

        private void updateRateMessage()
        {
            if (userRating == 1)
            {
                labelRate.Text = "Your rating is " + userRating.ToString() + " star";
            }
            else
            {
                labelRate.Text = "Your rating is " + userRating.ToString() + " stars";
            }

            
        }
    }
}
