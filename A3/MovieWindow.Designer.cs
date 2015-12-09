namespace A3
{
    partial class MovieWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.movieTitle = new System.Windows.Forms.Label();
            this.labelRating = new System.Windows.Forms.Label();
            this.watchList = new System.Windows.Forms.Label();
            this.Starring = new System.Windows.Forms.Label();
            this.Director = new System.Windows.Forms.Label();
            this.nameActors = new System.Windows.Forms.Label();
            this.nameDirector = new System.Windows.Forms.Label();
            this.linkAmazon = new System.Windows.Forms.LinkLabel();
            this.linkAppStore = new System.Windows.Forms.LinkLabel();
            this.linkPlayStore = new System.Windows.Forms.LinkLabel();
            this.reviewButton = new System.Windows.Forms.Button();
            this.labelReviews = new System.Windows.Forms.Label();
            this.labelYear = new System.Windows.Forms.Label();
            this.labelCert = new System.Windows.Forms.Label();
            this.labelTime = new System.Windows.Forms.Label();
            this.linkAllReviews = new System.Windows.Forms.LinkLabel();
            this.topReviews = new System.Windows.Forms.TextBox();
            this.addToWatchList = new System.Windows.Forms.Button();
            this.buttonWatchlist = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // movieTitle
            // 
            this.movieTitle.AutoSize = true;
            this.movieTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.movieTitle.Location = new System.Drawing.Point(22, 18);
            this.movieTitle.Name = "movieTitle";
            this.movieTitle.Size = new System.Drawing.Size(145, 31);
            this.movieTitle.TabIndex = 0;
            this.movieTitle.Text = "Movie Title";
            // 
            // labelRating
            // 
            this.labelRating.AutoSize = true;
            this.labelRating.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRating.Location = new System.Drawing.Point(43, 60);
            this.labelRating.Name = "labelRating";
            this.labelRating.Size = new System.Drawing.Size(83, 16);
            this.labelRating.TabIndex = 1;
            this.labelRating.Text = "star rating ";
            // 
            // watchList
            // 
            this.watchList.AutoSize = true;
            this.watchList.Location = new System.Drawing.Point(86, 107);
            this.watchList.Name = "watchList";
            this.watchList.Size = new System.Drawing.Size(67, 13);
            this.watchList.TabIndex = 3;
            this.watchList.Text = "To Watchlist";
            // 
            // Starring
            // 
            this.Starring.AutoSize = true;
            this.Starring.Location = new System.Drawing.Point(189, 83);
            this.Starring.Name = "Starring";
            this.Starring.Size = new System.Drawing.Size(46, 13);
            this.Starring.TabIndex = 4;
            this.Starring.Text = "Starring:";
            // 
            // Director
            // 
            this.Director.AutoSize = true;
            this.Director.Location = new System.Drawing.Point(189, 107);
            this.Director.Name = "Director";
            this.Director.Size = new System.Drawing.Size(47, 13);
            this.Director.TabIndex = 5;
            this.Director.Text = "Director:";
            // 
            // nameActors
            // 
            this.nameActors.AutoSize = true;
            this.nameActors.Location = new System.Drawing.Point(243, 83);
            this.nameActors.Name = "nameActors";
            this.nameActors.Size = new System.Drawing.Size(37, 13);
            this.nameActors.TabIndex = 6;
            this.nameActors.Text = "Actors";
            // 
            // nameDirector
            // 
            this.nameDirector.AutoSize = true;
            this.nameDirector.Location = new System.Drawing.Point(243, 107);
            this.nameDirector.Name = "nameDirector";
            this.nameDirector.Size = new System.Drawing.Size(44, 13);
            this.nameDirector.TabIndex = 7;
            this.nameDirector.Text = "Director";
            // 
            // linkAmazon
            // 
            this.linkAmazon.AutoSize = true;
            this.linkAmazon.Location = new System.Drawing.Point(28, 421);
            this.linkAmazon.Name = "linkAmazon";
            this.linkAmazon.Size = new System.Drawing.Size(45, 13);
            this.linkAmazon.TabIndex = 8;
            this.linkAmazon.TabStop = true;
            this.linkAmazon.Text = "Amazon";
            // 
            // linkAppStore
            // 
            this.linkAppStore.AutoSize = true;
            this.linkAppStore.Location = new System.Drawing.Point(89, 421);
            this.linkAppStore.Name = "linkAppStore";
            this.linkAppStore.Size = new System.Drawing.Size(51, 13);
            this.linkAppStore.TabIndex = 9;
            this.linkAppStore.TabStop = true;
            this.linkAppStore.Text = "AppStore";
            // 
            // linkPlayStore
            // 
            this.linkPlayStore.AutoSize = true;
            this.linkPlayStore.Location = new System.Drawing.Point(150, 421);
            this.linkPlayStore.Name = "linkPlayStore";
            this.linkPlayStore.Size = new System.Drawing.Size(51, 13);
            this.linkPlayStore.TabIndex = 10;
            this.linkPlayStore.TabStop = true;
            this.linkPlayStore.Text = "playStore";
            // 
            // reviewButton
            // 
            this.reviewButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reviewButton.Location = new System.Drawing.Point(501, 361);
            this.reviewButton.Name = "reviewButton";
            this.reviewButton.Size = new System.Drawing.Size(114, 29);
            this.reviewButton.TabIndex = 11;
            this.reviewButton.Text = "Write Review";
            this.reviewButton.UseVisualStyleBackColor = true;
            this.reviewButton.Click += new System.EventHandler(this.reviewButton_Click);
            // 
            // labelReviews
            // 
            this.labelReviews.AutoSize = true;
            this.labelReviews.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelReviews.Location = new System.Drawing.Point(24, 150);
            this.labelReviews.Name = "labelReviews";
            this.labelReviews.Size = new System.Drawing.Size(122, 24);
            this.labelReviews.TabIndex = 12;
            this.labelReviews.Text = "Best Reviews";
            // 
            // labelYear
            // 
            this.labelYear.AutoSize = true;
            this.labelYear.Location = new System.Drawing.Point(252, 60);
            this.labelYear.Name = "labelYear";
            this.labelYear.Size = new System.Drawing.Size(31, 13);
            this.labelYear.TabIndex = 14;
            this.labelYear.Text = "2015";
            // 
            // labelCert
            // 
            this.labelCert.AutoSize = true;
            this.labelCert.Location = new System.Drawing.Point(231, 60);
            this.labelCert.Name = "labelCert";
            this.labelCert.Size = new System.Drawing.Size(15, 13);
            this.labelCert.TabIndex = 15;
            this.labelCert.Text = "R";
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Location = new System.Drawing.Point(189, 60);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(36, 13);
            this.labelTime.TabIndex = 16;
            this.labelTime.Text = "102 m";
            // 
            // linkAllReviews
            // 
            this.linkAllReviews.AutoSize = true;
            this.linkAllReviews.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkAllReviews.Location = new System.Drawing.Point(27, 361);
            this.linkAllReviews.Name = "linkAllReviews";
            this.linkAllReviews.Size = new System.Drawing.Size(146, 24);
            this.linkAllReviews.TabIndex = 18;
            this.linkAllReviews.TabStop = true;
            this.linkAllReviews.Text = "See All Reviews";
            this.linkAllReviews.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkAllReviews_LinkClicked);
            // 
            // topReviews
            // 
            this.topReviews.BackColor = System.Drawing.SystemColors.Menu;
            this.topReviews.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.topReviews.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.topReviews.Location = new System.Drawing.Point(28, 186);
            this.topReviews.Multiline = true;
            this.topReviews.Name = "topReviews";
            this.topReviews.ReadOnly = true;
            this.topReviews.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.topReviews.Size = new System.Drawing.Size(587, 159);
            this.topReviews.TabIndex = 19;
            // 
            // addToWatchList
            // 
            this.addToWatchList.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addToWatchList.Image = global::A3.Properties.Resources.plus2;
            this.addToWatchList.Location = new System.Drawing.Point(46, 92);
            this.addToWatchList.Name = "addToWatchList";
            this.addToWatchList.Size = new System.Drawing.Size(34, 34);
            this.addToWatchList.TabIndex = 2;
            this.addToWatchList.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.addToWatchList.UseVisualStyleBackColor = true;
            this.addToWatchList.Click += new System.EventHandler(this.addToWatchList_Click);
            // 
            // buttonWatchlist
            // 
            this.buttonWatchlist.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonWatchlist.Location = new System.Drawing.Point(501, 107);
            this.buttonWatchlist.Name = "buttonWatchlist";
            this.buttonWatchlist.Size = new System.Drawing.Size(114, 28);
            this.buttonWatchlist.TabIndex = 20;
            this.buttonWatchlist.Text = "My Watchlist";
            this.buttonWatchlist.UseVisualStyleBackColor = true;
            this.buttonWatchlist.Click += new System.EventHandler(this.buttonWatchlist_Click);
            // 
            // MovieWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 444);
            this.Controls.Add(this.buttonWatchlist);
            this.Controls.Add(this.topReviews);
            this.Controls.Add(this.linkAllReviews);
            this.Controls.Add(this.labelTime);
            this.Controls.Add(this.labelCert);
            this.Controls.Add(this.labelYear);
            this.Controls.Add(this.labelReviews);
            this.Controls.Add(this.reviewButton);
            this.Controls.Add(this.linkPlayStore);
            this.Controls.Add(this.linkAppStore);
            this.Controls.Add(this.linkAmazon);
            this.Controls.Add(this.nameDirector);
            this.Controls.Add(this.nameActors);
            this.Controls.Add(this.Director);
            this.Controls.Add(this.Starring);
            this.Controls.Add(this.watchList);
            this.Controls.Add(this.addToWatchList);
            this.Controls.Add(this.labelRating);
            this.Controls.Add(this.movieTitle);
            this.Name = "MovieWindow";
            this.Text = "MovieWindow";
            this.Load += new System.EventHandler(this.MovieWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label movieTitle;
        private System.Windows.Forms.Label labelRating;
        private System.Windows.Forms.Button addToWatchList;
        private System.Windows.Forms.Label watchList;
        private System.Windows.Forms.Label Starring;
        private System.Windows.Forms.Label Director;
        private System.Windows.Forms.Label nameActors;
        private System.Windows.Forms.Label nameDirector;
        private System.Windows.Forms.LinkLabel linkAmazon;
        private System.Windows.Forms.LinkLabel linkAppStore;
        private System.Windows.Forms.LinkLabel linkPlayStore;
        private System.Windows.Forms.Button reviewButton;
        private System.Windows.Forms.Label labelReviews;
        private System.Windows.Forms.Label labelYear;
        private System.Windows.Forms.Label labelCert;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.LinkLabel linkAllReviews;
        private System.Windows.Forms.TextBox topReviews;
        private System.Windows.Forms.Button buttonWatchlist;
    }
}