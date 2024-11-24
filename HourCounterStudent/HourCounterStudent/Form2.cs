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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public static DateTime Login = DateTime.Now;
        //access login time in form1 after the signout
        public static string logintime;
        //access time spent in form1 after the signout
        public static string timespent;
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Signintimer_Tick(object sender, EventArgs e)
        {
            //setting the current time to lbl_ct
            lbl_ct.Text = DateTime.Now.ToString();
            lbl_ct.Invalidate();
            //calculate the time spent and storing in variable time spent
            TimeSpan t= TimeSpan.FromMilliseconds((DateTime.Now-Login).TotalMilliseconds);
            timespent = string.Format("{0:D2}h:{1:D2}m:{2:D2}s:{3:D2}ms",
                t.Hours,
                t.Minutes,
                t.Seconds,
                t.Milliseconds);
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            //storing login date and time in logintime
            logintime=Login.ToString();
        }

        private void btn_singout_Click(object sender, EventArgs e)
        {
            //this should display form1 after signout
            Form1 f = new Form1();
            f.Show();
            this.Hide();
        }
    }
}
