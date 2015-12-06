namespace A3
{
    partial class Search
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.lblYear = new System.Windows.Forms.Label();
            this.txtLength = new System.Windows.Forms.TextBox();
            this.lblLength = new System.Windows.Forms.Label();
            this.lblCertification = new System.Windows.Forms.Label();
            this.txtDirector = new System.Windows.Forms.TextBox();
            this.lblDirector = new System.Windows.Forms.Label();
            this.lblRating = new System.Windows.Forms.Label();
            this.lblGenre = new System.Windows.Forms.Label();
            this.txtActor = new System.Windows.Forms.TextBox();
            this.lblActor = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.cmbCertification = new System.Windows.Forms.ComboBox();
            this.cmbRating = new System.Windows.Forms.ComboBox();
            this.cmbGenre = new System.Windows.Forms.ComboBox();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Location = new System.Drawing.Point(3, 23);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(68, 26);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Title";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtYear
            // 
            this.txtYear.AcceptsTab = true;
            this.txtYear.Location = new System.Drawing.Point(3, 3);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(274, 20);
            this.txtYear.TabIndex = 1;
            this.txtYear.WordWrap = false;
            this.txtYear.TextChanged += new System.EventHandler(this.txtYear_TextChanged);
            // 
            // txtTitle
            // 
            this.txtTitle.AcceptsTab = true;
            this.txtTitle.Location = new System.Drawing.Point(3, 29);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(274, 20);
            this.txtTitle.TabIndex = 3;
            this.txtTitle.WordWrap = false;
            // 
            // lblYear
            // 
            this.lblYear.Location = new System.Drawing.Point(3, 0);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(68, 23);
            this.lblYear.TabIndex = 2;
            this.lblYear.Text = "Year";
            this.lblYear.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtLength
            // 
            this.txtLength.AcceptsTab = true;
            this.txtLength.Location = new System.Drawing.Point(3, 55);
            this.txtLength.Name = "txtLength";
            this.txtLength.Size = new System.Drawing.Size(274, 20);
            this.txtLength.TabIndex = 5;
            this.txtLength.WordWrap = false;
            this.txtLength.TextChanged += new System.EventHandler(this.txtLength_TextChanged);
            // 
            // lblLength
            // 
            this.lblLength.Location = new System.Drawing.Point(3, 49);
            this.lblLength.Name = "lblLength";
            this.lblLength.Size = new System.Drawing.Size(68, 26);
            this.lblLength.TabIndex = 4;
            this.lblLength.Text = "Length";
            this.lblLength.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCertification
            // 
            this.lblCertification.Location = new System.Drawing.Point(3, 75);
            this.lblCertification.Name = "lblCertification";
            this.lblCertification.Size = new System.Drawing.Size(68, 26);
            this.lblCertification.TabIndex = 6;
            this.lblCertification.Text = "Certification";
            this.lblCertification.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtDirector
            // 
            this.txtDirector.AcceptsTab = true;
            this.txtDirector.Location = new System.Drawing.Point(3, 108);
            this.txtDirector.Name = "txtDirector";
            this.txtDirector.Size = new System.Drawing.Size(274, 20);
            this.txtDirector.TabIndex = 9;
            this.txtDirector.WordWrap = false;
            this.txtDirector.TextChanged += new System.EventHandler(this.txtDirector_TextChanged);
            // 
            // lblDirector
            // 
            this.lblDirector.Location = new System.Drawing.Point(3, 101);
            this.lblDirector.Name = "lblDirector";
            this.lblDirector.Size = new System.Drawing.Size(68, 26);
            this.lblDirector.TabIndex = 8;
            this.lblDirector.Text = "Director";
            this.lblDirector.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblRating
            // 
            this.lblRating.Location = new System.Drawing.Point(3, 127);
            this.lblRating.Name = "lblRating";
            this.lblRating.Size = new System.Drawing.Size(68, 26);
            this.lblRating.TabIndex = 10;
            this.lblRating.Text = "Rating";
            this.lblRating.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblGenre
            // 
            this.lblGenre.Location = new System.Drawing.Point(3, 153);
            this.lblGenre.Name = "lblGenre";
            this.lblGenre.Size = new System.Drawing.Size(68, 26);
            this.lblGenre.TabIndex = 12;
            this.lblGenre.Text = "Genre";
            this.lblGenre.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtActor
            // 
            this.txtActor.AcceptsTab = true;
            this.txtActor.Location = new System.Drawing.Point(3, 188);
            this.txtActor.Name = "txtActor";
            this.txtActor.Size = new System.Drawing.Size(274, 20);
            this.txtActor.TabIndex = 15;
            this.txtActor.WordWrap = false;
            this.txtActor.TextChanged += new System.EventHandler(this.txtActor_TextChanged);
            // 
            // lblActor
            // 
            this.lblActor.Location = new System.Drawing.Point(3, 179);
            this.lblActor.Name = "lblActor";
            this.lblActor.Size = new System.Drawing.Size(68, 26);
            this.lblActor.TabIndex = 14;
            this.lblActor.Text = "Actor";
            this.lblActor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(3, 214);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(274, 23);
            this.btnSearch.TabIndex = 16;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.lblYear);
            this.flowLayoutPanel1.Controls.Add(this.lblTitle);
            this.flowLayoutPanel1.Controls.Add(this.lblLength);
            this.flowLayoutPanel1.Controls.Add(this.lblCertification);
            this.flowLayoutPanel1.Controls.Add(this.lblDirector);
            this.flowLayoutPanel1.Controls.Add(this.lblRating);
            this.flowLayoutPanel1.Controls.Add(this.lblGenre);
            this.flowLayoutPanel1.Controls.Add(this.lblActor);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(72, 301);
            this.flowLayoutPanel1.TabIndex = 17;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.txtYear);
            this.flowLayoutPanel2.Controls.Add(this.txtTitle);
            this.flowLayoutPanel2.Controls.Add(this.txtLength);
            this.flowLayoutPanel2.Controls.Add(this.cmbCertification);
            this.flowLayoutPanel2.Controls.Add(this.txtDirector);
            this.flowLayoutPanel2.Controls.Add(this.cmbRating);
            this.flowLayoutPanel2.Controls.Add(this.cmbGenre);
            this.flowLayoutPanel2.Controls.Add(this.txtActor);
            this.flowLayoutPanel2.Controls.Add(this.btnSearch);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(77, 0);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(283, 301);
            this.flowLayoutPanel2.TabIndex = 18;
            // 
            // cmbCertification
            // 
            this.cmbCertification.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCertification.FormattingEnabled = true;
            this.cmbCertification.Location = new System.Drawing.Point(3, 81);
            this.cmbCertification.Name = "cmbCertification";
            this.cmbCertification.Size = new System.Drawing.Size(274, 21);
            this.cmbCertification.TabIndex = 19;
            // 
            // cmbRating
            // 
            this.cmbRating.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRating.FormattingEnabled = true;
            this.cmbRating.Location = new System.Drawing.Point(3, 134);
            this.cmbRating.Name = "cmbRating";
            this.cmbRating.Size = new System.Drawing.Size(274, 21);
            this.cmbRating.TabIndex = 18;
            // 
            // cmbGenre
            // 
            this.cmbGenre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGenre.FormattingEnabled = true;
            this.cmbGenre.Location = new System.Drawing.Point(3, 161);
            this.cmbGenre.Name = "cmbGenre";
            this.cmbGenre.Size = new System.Drawing.Size(274, 21);
            this.cmbGenre.TabIndex = 17;
            // 
            // Search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 301);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "Search";
            this.Text = "Search";
            this.Load += new System.EventHandler(this.Search_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.TextBox txtLength;
        private System.Windows.Forms.Label lblLength;
        private System.Windows.Forms.Label lblCertification;
        private System.Windows.Forms.TextBox txtDirector;
        private System.Windows.Forms.Label lblDirector;
        private System.Windows.Forms.Label lblRating;
        private System.Windows.Forms.Label lblGenre;
        private System.Windows.Forms.TextBox txtActor;
        private System.Windows.Forms.Label lblActor;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.ComboBox cmbGenre;
        private System.Windows.Forms.ComboBox cmbRating;
        private System.Windows.Forms.ComboBox cmbCertification;
    }
}