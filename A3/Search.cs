using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace A3
{
    public partial class Search : Form
    {
        public Search()
        {
            InitializeComponent();

            Logic.genres.Sort();
            foreach(String genre in Logic.genres)
            {
                cmbGenre.Items.Add(genre);
            }

            Logic.certifications.Sort();
            foreach (String cert in Logic.certifications)
            {
                cmbCertification.Items.Add(cert);
            }

            for (int i = 0; i < 10;i++ ){
                cmbRating.Items.Add(i);
            }


            this.Visible = true;
        }
        private Boolean isNumber(String input)
        {
            try
            {
                int temp = Int32.Parse(input);
                return true;
            }
            catch
            {
                return false;
            }

        }


        private Boolean valid(String input)
        {
            if (!input.Equals(""))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            List<Movie> results = new List<Movie>();
            ArrayList list = new ArrayList();
            if (valid(txtYear.Text))
            {
                List<Movie> year = Form1.logic.findYear(txtYear.Text.Trim().ToLower());
                list.Add(year);
            }

            if (valid(txtTitle.Text))
            {
                List<Movie> title = Form1.logic.findTitle(txtTitle.Text.Trim().ToLower());
                list.Add(title);
            }

            if (valid(txtLength.Text))
            {
                List<Movie> length = Form1.logic.findLength(txtLength.Text.Trim().ToLower());
                list.Add(length);
            }
            if (cmbCertification.SelectedItem != null)
            {
                if (valid(cmbCertification.SelectedItem.ToString()))
                {
                    List<Movie> certification = Form1.logic.findCertification(cmbCertification.SelectedItem.ToString());
                    list.Add(certification);
                }
            }

            if (valid(txtDirector.Text))
            {
                List<Movie> director = Form1.logic.findDirector(txtDirector.Text.Trim().ToLower());
                list.Add(director);
            }

            if (cmbRating.SelectedItem != null)
            {
                if (valid(cmbRating.SelectedItem.ToString()))
                {
                    List<Movie> rating = Form1.logic.findRating(cmbRating.SelectedItem.ToString());
                    list.Add(rating);
                }
            }

            if (cmbGenre.SelectedItem != null)
            {
                if (valid(cmbGenre.SelectedItem.ToString()))
                {
                    List<Movie> genre = Form1.logic.findGenre(cmbGenre.SelectedItem.ToString());
                    list.Add(genre);
                }
            }

            if (valid(txtActor.Text))
            {
                List<Movie> actor = Form1.logic.findActor(txtActor.Text.Trim().ToLower());
                list.Add(actor);
            }

            if (list.Count > 1)
            {
                Boolean add = true;
                foreach (Movie m in Logic.list)
                {
                    add = true;
                    foreach (List<Movie> t in list)
                    {
                        if (!t.Contains(m))
                        {
                            add = false;
                        }
                    }
                    if (add && !results.Contains(m))
                    {
                        results.Add(m);
                    }
                }
            }
            else
            {
                results = (List<Movie>)list[0];
            }

            Logic.search = results;
            Logic.loadDataToScatterPlot();
            this.Close();
        }

        private void Search_Load(object sender, EventArgs e)
        {

        }

        private String onlyNums(String input)
        {
            input = input.Trim();
            for (int i = 0; i < input.Length; i++)
            {
                if (!isNumber("" + input.ElementAt(i)))
                {
                    input = input.Remove(i, 1);
                }
            }
            return input;
        }

        private String onlyText(String input)
        {
            input = input.Trim();
            for (int i = 0; i < input.Length; i++)
            {
                if (isNumber("" + input.ElementAt(i)))
                {
                    input = input.Remove(i, 1);
                }
            }
            return input;
        }

        private void txtLength_TextChanged(object sender, EventArgs e)
        {
            TextBox t = (TextBox)sender;
            t.Text = onlyNums(t.Text);
            if (t.Text.Length > 3)
            {
                t.Text = t.Text.Remove(3, t.Text.Length - 3);
            }
            t.Focus();
            t.Select(t.Text.Length, 0); 
        }

        private void txtYear_TextChanged(object sender, EventArgs e)
        {
            TextBox t = (TextBox)sender;
            t.Text = onlyNums(t.Text);
            if (t.Text.Length > 4)
            {
                t.Text = t.Text.Remove(4, t.Text.Length-4);
            }
            t.Focus();
            t.Select(t.Text.Length, 0); 
        }

        private void txtDirector_TextChanged(object sender, EventArgs e)
        {
            TextBox t = (TextBox)sender;
            t.Text = onlyText(t.Text);
            t.Focus();
            t.Select(t.Text.Length, 0); 
        }

        private void txtActor_TextChanged(object sender, EventArgs e)
        {
            TextBox t = (TextBox)sender;
            t.Text = onlyText(t.Text);
            t.Focus();
            t.Select(t.Text.Length, 0); 
        }  
    }
}
