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
    public partial class ViewReviews : Form
    {
        private Movie currMovie;

        public ViewReviews(Movie inMovie)
        {
            InitializeComponent();

            this.MinimizeBox = false;
            this.MaximizeBox = false;
            this.currMovie = inMovie;

            this.Visible = true;
            loadReviews();
        }

        private void loadReviews()
        {
            
            String review = "";
            foreach (MovieReview rev in Logic.reviews)
            {
                review = formatReview(rev) + "\r\n\r\n";
            }
            this.reviewBox.Text = review;
        }

        private String formatReview(MovieReview review)
        {
            String formatRev = review.owner.username + "  " + review.rating + " Stars" + "\r\n\r\n" + review.comments;
            return formatRev;
        }

    }

     
}
