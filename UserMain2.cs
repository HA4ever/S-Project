using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Measurement_System
{
    public partial class UserMain2 : Form
    {
        public UserMain2()
        {
            InitializeComponent();
        }

        private void ViewState_Click(object sender, EventArgs e)
        {

        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login lg = new Login();
            lg.Show();
        }

        private void SendRequst_Click(object sender, EventArgs e)
        {

        }
    }
}
