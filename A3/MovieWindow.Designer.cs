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
            this.addToWatchList = new System.Windows.Forms.Button();
            this.reviewButton = new System.Windows.Forms.Button();
            this.labelReviews = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.labelYear = new System.Windows.Forms.Label();
            this.labelCert = new System.Windows.Forms.Label();
            this.labelTime = new System.Windows.Forms.Label();
            this.reviewsButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
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
            this.labelRating.Location = new System.Drawing.Point(46, 49);
            this.labelRating.Name = "labelRating";
            this.labelRating.Size = new System.Drawing.Size(103, 13);
            this.labelRating.TabIndex = 1;
            this.labelRating.Text = "star rating goes here";
            // 
            // watchList
            // 
            this.watchList.AutoSize = true;
            this.watchList.Location = new System.Drawing.Point(358, 94);
            this.watchList.Name = "watchList";
            this.watchList.Size = new System.Drawing.Size(67, 13);
            this.watchList.TabIndex = 3;
            this.watchList.Text = "To Watchlist";
            // 
            // Starring
            // 
            this.Starring.AutoSize = true;
            this.Starring.Location = new System.Drawing.Point(46, 79);
            this.Starring.Name = "Starring";
            this.Starring.Size = new System.Drawing.Size(46, 13);
            this.Starring.TabIndex = 4;
            this.Starring.Text = "Starring:";
            // 
            // Director
            // 
            this.Director.AutoSize = true;
            this.Director.Location = new System.Drawing.Point(46, 103);
            this.Director.Name = "Director";
            this.Director.Size = new System.Drawing.Size(47, 13);
            this.Director.TabIndex = 5;
            this.Director.Text = "Director:";
            // 
            // nameActors
            // 
            this.nameActors.AutoSize = true;
            this.nameActors.Location = new System.Drawing.Point(100, 79);
            this.nameActors.Name = "nameActors";
            this.nameActors.Size = new System.Drawing.Size(37, 13);
            this.nameActors.TabIndex = 6;
            this.nameActors.Text = "Actors";
            // 
            // nameDirector
            // 
            this.nameDirector.AutoSize = true;
            this.nameDirector.Location = new System.Drawing.Point(100, 103);
            this.nameDirector.Name = "nameDirector";
            this.nameDirector.Size = new System.Drawing.Size(44, 13);
            this.nameDirector.TabIndex = 7;
            this.nameDirector.Text = "Director";
            // 
            // linkAmazon
            // 
            this.linkAmazon.AutoSize = true;
            this.linkAmazon.Location = new System.Drawing.Point(28, 497);
            this.linkAmazon.Name = "linkAmazon";
            this.linkAmazon.Size = new System.Drawing.Size(45, 13);
            this.linkAmazon.TabIndex = 8;
            this.linkAmazon.TabStop = true;
            this.linkAmazon.Text = "Amazon";
            // 
            // linkAppStore
            // 
            this.linkAppStore.AutoSize = true;
            this.linkAppStore.Location = new System.Drawing.Point(89, 497);
            this.linkAppStore.Name = "linkAppStore";
            this.linkAppStore.Size = new System.Drawing.Size(51, 13);
            this.linkAppStore.TabIndex = 9;
            this.linkAppStore.TabStop = true;
            this.linkAppStore.Text = "AppStore";
            // 
            // linkPlayStore
            // 
            this.linkPlayStore.AutoSize = true;
            this.linkPlayStore.Location = new System.Drawing.Point(150, 497);
            this.linkPlayStore.Name = "linkPlayStore";
            this.linkPlayStore.Size = new System.Drawing.Size(51, 13);
            this.linkPlayStore.TabIndex = 10;
            this.linkPlayStore.TabStop = true;
            this.linkPlayStore.Text = "playStore";
            // 
            // addToWatchList
            // 
            this.addToWatchList.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addToWatchList.Location = new System.Drawing.Point(316, 79);
            this.addToWatchList.Name = "addToWatchList";
            this.addToWatchList.Size = new System.Drawing.Size(36, 37);
            this.addToWatchList.TabIndex = 2;
            this.addToWatchList.Text = "+";
            this.addToWatchList.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.addToWatchList.UseVisualStyleBackColor = true;
            this.addToWatchList.Click += new System.EventHandler(this.addToWatchList_Click);
            // 
            // reviewButton
            // 
            this.reviewButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reviewButton.Location = new System.Drawing.Point(328, 458);
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
            this.labelReviews.Size = new System.Drawing.Size(81, 24);
            this.labelReviews.TabIndex = 12;
            this.labelReviews.Text = "Reviews";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.vScrollBar1);
            this.panel1.Location = new System.Drawing.Point(28, 201);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(414, 251);
            this.panel1.TabIndex = 13;
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Location = new System.Drawing.Point(397, 0);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(17, 251);
            this.vScrollBar1.TabIndex = 0;
            // 
            // labelYear
            // 
            this.labelYear.AutoSize = true;
            this.labelYear.Location = new System.Drawing.Point(235, 49);
            this.labelYear.Name = "labelYear";
            this.labelYear.Size = new System.Drawing.Size(31, 13);
            this.labelYear.TabIndex = 14;
            this.labelYear.Text = "2015";
            // 
            // labelCert
            // 
            this.labelCert.AutoSize = true;
            this.labelCert.Location = new System.Drawing.Point(214, 49);
            this.labelCert.Name = "labelCert";
            this.labelCert.Size = new System.Drawing.Size(15, 13);
            this.labelCert.TabIndex = 15;
            this.labelCert.Text = "R";
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Location = new System.Drawing.Point(172, 49);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(36, 13);
            this.labelTime.TabIndex = 16;
            this.labelTime.Text = "102 m";
            // 
            // reviewsButton
            // 
            this.reviewsButton.Location = new System.Drawing.Point(153, 150);
            this.reviewsButton.Name = "reviewsButton";
            this.reviewsButton.Size = new System.Drawing.Size(75, 23);
            this.reviewsButton.TabIndex = 17;
            this.reviewsButton.Text = "button1";
            this.reviewsButton.UseVisualStyleBackColor = true;
            this.reviewsButton.Click += new System.EventHandler(this.reviewsButton_Click);
            // 
            // MovieWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 534);
            this.Controls.Add(this.reviewsButton);
            this.Controls.Add(this.labelTime);
            this.Controls.Add(this.labelCert);
            this.Controls.Add(this.labelYear);
            this.Controls.Add(this.panel1);
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
            this.panel1.ResumeLayout(false);
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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.VScrollBar vScrollBar1;
        private System.Windows.Forms.Label labelYear;
        private System.Windows.Forms.Label labelCert;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Button reviewsButton;
    }
}