namespace A3
{
    partial class ReviewWindow
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
            this.reviewText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.submitButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.movieTitle = new System.Windows.Forms.Label();
            this.star5 = new System.Windows.Forms.PictureBox();
            this.star4 = new System.Windows.Forms.PictureBox();
            this.star3 = new System.Windows.Forms.PictureBox();
            this.star2 = new System.Windows.Forms.PictureBox();
            this.star1 = new System.Windows.Forms.PictureBox();
            this.labelRate = new System.Windows.Forms.Label();
            this.labelHint = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.star5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.star4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.star3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.star2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.star1)).BeginInit();
            this.SuspendLayout();
            // 
            // reviewText
            // 
            this.reviewText.Location = new System.Drawing.Point(41, 139);
            this.reviewText.MaxLength = 462;
            this.reviewText.Multiline = true;
            this.reviewText.Name = "reviewText";
            this.reviewText.Size = new System.Drawing.Size(513, 91);
            this.reviewText.TabIndex = 0;
            this.reviewText.Text = "\r\n\r\n\t\t\tWrite your review here, must be at least 60 characters.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Rate this movie:";
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(398, 236);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(75, 23);
            this.submitButton.TabIndex = 3;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(479, 236);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 4;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // movieTitle
            // 
            this.movieTitle.AutoSize = true;
            this.movieTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.movieTitle.Location = new System.Drawing.Point(37, 26);
            this.movieTitle.Name = "movieTitle";
            this.movieTitle.Size = new System.Drawing.Size(117, 25);
            this.movieTitle.TabIndex = 11;
            this.movieTitle.Text = "Movie Title";
            // 
            // star5
            // 
            this.star5.Image = global::A3.Properties.Resources.star2;
            this.star5.Location = new System.Drawing.Point(310, 83);
            this.star5.Name = "star5";
            this.star5.Size = new System.Drawing.Size(25, 22);
            this.star5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.star5.TabIndex = 9;
            this.star5.TabStop = false;
            this.star5.Click += new System.EventHandler(this.star5_Click);
            // 
            // star4
            // 
            this.star4.Image = global::A3.Properties.Resources.star2;
            this.star4.Location = new System.Drawing.Point(279, 83);
            this.star4.Name = "star4";
            this.star4.Size = new System.Drawing.Size(25, 22);
            this.star4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.star4.TabIndex = 8;
            this.star4.TabStop = false;
            this.star4.Click += new System.EventHandler(this.star4_Click);
            // 
            // star3
            // 
            this.star3.Image = global::A3.Properties.Resources.star2;
            this.star3.Location = new System.Drawing.Point(248, 83);
            this.star3.Name = "star3";
            this.star3.Size = new System.Drawing.Size(25, 22);
            this.star3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.star3.TabIndex = 7;
            this.star3.TabStop = false;
            this.star3.Click += new System.EventHandler(this.star3_Click);
            // 
            // star2
            // 
            this.star2.Image = global::A3.Properties.Resources.star2;
            this.star2.Location = new System.Drawing.Point(217, 83);
            this.star2.Name = "star2";
            this.star2.Size = new System.Drawing.Size(25, 22);
            this.star2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.star2.TabIndex = 6;
            this.star2.TabStop = false;
            this.star2.Click += new System.EventHandler(this.star2_Click);
            // 
            // star1
            // 
            this.star1.Image = global::A3.Properties.Resources.star2;
            this.star1.Location = new System.Drawing.Point(186, 83);
            this.star1.Name = "star1";
            this.star1.Size = new System.Drawing.Size(25, 22);
            this.star1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.star1.TabIndex = 5;
            this.star1.TabStop = false;
            this.star1.Click += new System.EventHandler(this.star1_Click);
            // 
            // labelRate
            // 
            this.labelRate.AutoSize = true;
            this.labelRate.Location = new System.Drawing.Point(414, 94);
            this.labelRate.Name = "labelRate";
            this.labelRate.Size = new System.Drawing.Size(71, 13);
            this.labelRate.TabIndex = 12;
            this.labelRate.Text = "Your rating is:";
            // 
            // labelHint
            // 
            this.labelHint.AutoSize = true;
            this.labelHint.Location = new System.Drawing.Point(50, 107);
            this.labelHint.Name = "labelHint";
            this.labelHint.Size = new System.Drawing.Size(104, 13);
            this.labelHint.TabIndex = 13;
            this.labelHint.Text = "( Click a star to rate )";
            // 
            // ReviewWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 283);
            this.Controls.Add(this.labelHint);
            this.Controls.Add(this.labelRate);
            this.Controls.Add(this.movieTitle);
            this.Controls.Add(this.star5);
            this.Controls.Add(this.star4);
            this.Controls.Add(this.star3);
            this.Controls.Add(this.star2);
            this.Controls.Add(this.star1);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.reviewText);
            this.Name = "ReviewWindow";
            this.Text = "ReviewWindow";
            this.Load += new System.EventHandler(this.ReviewWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.star5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.star4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.star3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.star2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.star1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox reviewText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.PictureBox star1;
        private System.Windows.Forms.PictureBox star2;
        private System.Windows.Forms.PictureBox star3;
        private System.Windows.Forms.PictureBox star4;
        private System.Windows.Forms.PictureBox star5;
        private System.Windows.Forms.Label movieTitle;
        private System.Windows.Forms.Label labelRate;
        private System.Windows.Forms.Label labelHint;
    }
}