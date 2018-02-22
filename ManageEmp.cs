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
    public partial class ManageEmp : Form
    {
        public ManageEmp()
        {
            InitializeComponent();
        }

       

        
        private void numTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void iDTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void numLabel_Click(object sender, EventArgs e)
        {

        }

        private void ManageEmp_Load_1(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'userDBDataSet1.UserTable' table. You can move, or remove it, as needed.
            this.userTableTableAdapter1.Fill(this.userDBDataSet1.UserTable);

        }

        private void BACK_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminMain ad = new AdminMain();
            ad.Show();
        }

        private void userTableBindingSource1BindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.userTableBindingSource1.EndEdit();
            this.tableAdapterManager1.UpdateAll(this.userDBDataSet1);

        }
    }
}
