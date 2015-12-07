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
    public partial class Form1 : Form
    {
        public static Logic logic = new Logic();
        public static Label user; 
        public static System.Windows.Forms.DataVisualization.Charting.Chart scatter;
        public Form1()
        {
            InitializeComponent();
            
            user = lblUser;
            scatter = chartScatterplot;
            this.MinimizeBox = false;
            this.MaximizeBox = false;

            this.WindowState = FormWindowState.Maximized;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;

            Logic.search = logic.findCertification("x"); 
            Logic.loadDataToScatterPlot();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click_1(object sender, EventArgs e)
        {
            Search s = new Search();
            s.Activate();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            log.Activate();
        }
    }
}
