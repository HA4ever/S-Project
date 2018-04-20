using System;
using System.Windows.Forms;

namespace Measurement_System
{
    public partial class AdminMain : Form
    {
        int id = 0 ;
        string TSize = "";
        string PSize = "";
        string name = "";

        public AdminMain()
        {
            InitializeComponent();
        }
        public AdminMain(int id1,string name1 ,string TSize1,string PSize1)
        {
            InitializeComponent();
            id = id1;
            TSize = TSize1;
            PSize = PSize1;
            name = name1;
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
