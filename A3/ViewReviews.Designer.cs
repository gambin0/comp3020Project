﻿namespace A3
{
    partial class ViewReviews
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
            this.headerReviews = new System.Windows.Forms.Label();
            this.reviewButton = new System.Windows.Forms.Button();
            this.reviewBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // headerReviews
            // 
            this.headerReviews.AutoSize = true;
            this.headerReviews.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerReviews.Location = new System.Drawing.Point(24, 27);
            this.headerReviews.Name = "headerReviews";
            this.headerReviews.Size = new System.Drawing.Size(257, 25);
            this.headerReviews.TabIndex = 0;
            this.headerReviews.Text = "69 reviews for Movie Title";
            // 
            // reviewButton
            // 
            this.reviewButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reviewButton.Location = new System.Drawing.Point(29, 64);
            this.reviewButton.Name = "reviewButton";
            this.reviewButton.Size = new System.Drawing.Size(111, 30);
            this.reviewButton.TabIndex = 1;
            this.reviewButton.Text = "Write Review";
            this.reviewButton.UseVisualStyleBackColor = true;
            this.reviewButton.Click += new System.EventHandler(this.reviewButton_Click);
            // 
            // reviewBox
            // 
            this.reviewBox.BackColor = System.Drawing.SystemColors.Menu;
            this.reviewBox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.reviewBox.Location = new System.Drawing.Point(29, 125);
            this.reviewBox.Multiline = true;
            this.reviewBox.Name = "reviewBox";
            this.reviewBox.ReadOnly = true;
            this.reviewBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.reviewBox.Size = new System.Drawing.Size(454, 210);
            this.reviewBox.TabIndex = 2;
            // 
            // ViewReviews
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 363);
            this.Controls.Add(this.reviewBox);
            this.Controls.Add(this.reviewButton);
            this.Controls.Add(this.headerReviews);
            this.Name = "ViewReviews";
            this.Text = "ViewReviews";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label headerReviews;
        private System.Windows.Forms.Button reviewButton;
        private System.Windows.Forms.TextBox reviewBox;
    }
}