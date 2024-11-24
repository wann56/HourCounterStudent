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
    public partial class LoginFrm : Form
    {
        public LoginFrm()
        {
            InitializeComponent();
        }

        private void username_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string user = username.Text;
            if ( user == "leeyan")
            {
                MessageBox.Show("Attendance Complete");
            }
            else
            {
                MessageBox.Show("Student isn't part of the section/class");
            }
            Close();
        }
    }
}
