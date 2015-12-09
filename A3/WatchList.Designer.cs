namespace A3
{
    partial class WatchList
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
            this.header = new System.Windows.Forms.Label();
            this.labelPrivacy = new System.Windows.Forms.Label();
            this.labelSort = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.labelShare = new System.Windows.Forms.Label();
            this.labelTitles = new System.Windows.Forms.Label();
            this.buttonAddMovie = new System.Windows.Forms.Button();
            this.buttonRight = new System.Windows.Forms.Button();
            this.buttonLeft = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // header
            // 
            this.header.AutoSize = true;
            this.header.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.header.Location = new System.Drawing.Point(22, 23);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(182, 25);
            this.header.TabIndex = 0;
            this.header.Text = "User\'s Watchlist";
            // 
            // labelPrivacy
            // 
            this.labelPrivacy.AutoSize = true;
            this.labelPrivacy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrivacy.Location = new System.Drawing.Point(231, 57);
            this.labelPrivacy.Name = "labelPrivacy";
            this.labelPrivacy.Size = new System.Drawing.Size(153, 20);
            this.labelPrivacy.TabIndex = 1;
            this.labelPrivacy.Text = "Who can see my list:";
            // 
            // labelSort
            // 
            this.labelSort.AutoSize = true;
            this.labelSort.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSort.Location = new System.Drawing.Point(319, 92);
            this.labelSort.Name = "labelSort";
            this.labelSort.Size = new System.Drawing.Size(65, 20);
            this.labelSort.TabIndex = 2;
            this.labelSort.Text = "Sort By:";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Only me",
            "My Friends",
            "Everyone"});
            this.comboBox1.Location = new System.Drawing.Point(390, 56);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 3;
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Added",
            "Name",
            "Year",
            "Length"});
            this.comboBox2.Location = new System.Drawing.Point(390, 94);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 4;
            // 
            // labelShare
            // 
            this.labelShare.AutoSize = true;
            this.labelShare.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelShare.Location = new System.Drawing.Point(23, 321);
            this.labelShare.Name = "labelShare";
            this.labelShare.Size = new System.Drawing.Size(112, 20);
            this.labelShare.TabIndex = 5;
            this.labelShare.Text = "Share my list";
            // 
            // labelTitles
            // 
            this.labelTitles.AutoSize = true;
            this.labelTitles.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitles.Location = new System.Drawing.Point(48, 106);
            this.labelTitles.Name = "labelTitles";
            this.labelTitles.Size = new System.Drawing.Size(59, 20);
            this.labelTitles.TabIndex = 8;
            this.labelTitles.Text = "# Titles";
            // 
            // buttonAddMovie
            // 
            this.buttonAddMovie.Location = new System.Drawing.Point(52, 61);
            this.buttonAddMovie.Name = "buttonAddMovie";
            this.buttonAddMovie.Size = new System.Drawing.Size(75, 23);
            this.buttonAddMovie.TabIndex = 9;
            this.buttonAddMovie.Text = "Add Movie";
            this.buttonAddMovie.UseVisualStyleBackColor = true;
            // 
            // buttonRight
            // 
            this.buttonRight.Image = global::A3.Properties.Resources.right_arrow1;
            this.buttonRight.Location = new System.Drawing.Point(530, 218);
            this.buttonRight.Name = "buttonRight";
            this.buttonRight.Size = new System.Drawing.Size(34, 34);
            this.buttonRight.TabIndex = 7;
            this.buttonRight.UseVisualStyleBackColor = true;
            this.buttonRight.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonLeft
            // 
            this.buttonLeft.Image = global::A3.Properties.Resources.left_arrow;
            this.buttonLeft.Location = new System.Drawing.Point(12, 218);
            this.buttonLeft.Name = "buttonLeft";
            this.buttonLeft.Size = new System.Drawing.Size(34, 34);
            this.buttonLeft.TabIndex = 6;
            this.buttonLeft.UseVisualStyleBackColor = true;
            this.buttonLeft.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.Info;
            this.label1.Location = new System.Drawing.Point(66, 166);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 127);
            this.label1.TabIndex = 15;
            this.label1.Text = "label1\r\n\r\n\r\n";
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.Info;
            this.label2.Location = new System.Drawing.Point(156, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 127);
            this.label2.TabIndex = 16;
            this.label2.Text = "label1\r\n\r\n\r\n";
            this.label2.Visible = false;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.Info;
            this.label3.Location = new System.Drawing.Point(246, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 127);
            this.label3.TabIndex = 17;
            this.label3.Text = "label1\r\n\r\n\r\n";
            this.label3.Visible = false;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.Info;
            this.label4.Location = new System.Drawing.Point(336, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 127);
            this.label4.TabIndex = 18;
            this.label4.Text = "label1\r\n\r\n\r\n";
            this.label4.Visible = false;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.SystemColors.Info;
            this.label5.Location = new System.Drawing.Point(427, 166);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 127);
            this.label5.TabIndex = 19;
            this.label5.Text = "label1\r\n\r\n\r\n";
            this.label5.Visible = false;
            // 
            // WatchList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(580, 422);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonAddMovie);
            this.Controls.Add(this.labelTitles);
            this.Controls.Add(this.buttonRight);
            this.Controls.Add(this.buttonLeft);
            this.Controls.Add(this.labelShare);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.labelSort);
            this.Controls.Add(this.labelPrivacy);
            this.Controls.Add(this.header);
            this.Name = "WatchList";
            this.Text = "WatchList";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label header;
        private System.Windows.Forms.Label labelPrivacy;
        private System.Windows.Forms.Label labelSort;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label labelShare;
        private System.Windows.Forms.Button buttonLeft;
        private System.Windows.Forms.Button buttonRight;
        private System.Windows.Forms.Label labelTitles;
        private System.Windows.Forms.Button buttonAddMovie;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}