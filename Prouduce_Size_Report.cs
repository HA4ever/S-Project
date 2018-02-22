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
    public partial class Prouduce_Size_Report : Form
    {
        public Prouduce_Size_Report()
        {
            InitializeComponent();
        }

        private void BACK_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminMain ad = new AdminMain();
            ad.Show();
        }

        private void Prouduce_Size_Report_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'userDBDataSet.UserTable' table. You can move, or remove it, as needed.
            this.userTableTableAdapter.Fill(this.userDBDataSet.UserTable);

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
