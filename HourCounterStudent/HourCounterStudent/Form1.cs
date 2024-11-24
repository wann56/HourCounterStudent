using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HourCounterStudent
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //displaying the login time accessed from form2 logintime
            lbl_lt.Text = Form2.logintime;
            //displaying the time spent from form 2 logintime again
            lbl_ts.Text= Form2.timespent;
        }
    }
}
