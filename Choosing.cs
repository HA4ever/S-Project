using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Measurement_System
{
    public partial class Choosing : Form
    {
        String username = "";
       
        public Choosing()
        {
            
        }
        public Choosing(String user)
        {
            InitializeComponent();
            username = user;
        }

        private void kin_but_Click(object sender, EventArgs e)
        {
            this.Hide();
            KinectSystem ks = new KinectSystem(username);
            ks.Show();
        }

        private void Drop_Btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            DropList DD = new DropList(username);
            DD.Show();
        }

        private void Back_Click(object sender, EventArgs e)
        {
                this.Hide();
                UserMain2 us = new UserMain2(username);
                us.Show();

            

           
        }

        private void Choosing_Load(object sender, EventArgs e)
        {

        }
    }
}
