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
    public partial class AdminMain : Form
    {
        public AdminMain()
        {
            InitializeComponent();
        }

        private void EXIT_Click(object sender, EventArgs e)
        {
            Login lg = new Login();
            this.Close();
            lg.Show();
        }

        private void Manage_Employee_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManageEmp me = new ManageEmp();
            me.Show();
        }

        private void Prouduce_Size_Report_Click(object sender, EventArgs e)
        {
            this.Hide();
            Prouduce_Size_Report pr = new Prouduce_Size_Report();
            pr.Show();
        }

        private void Manage_Order_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManageOrder ma = new ManageOrder();
            ma.Show();
        }
    }
}
