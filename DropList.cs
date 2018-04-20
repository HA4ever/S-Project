using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Measurement_System
{
    public partial class DropList : Form
    {

        String username = "";

        public DropList()
        {
           
        }
        public DropList(String user)
        {
            InitializeComponent();
            username = user;
        }

        private void Done_Click(object sender, EventArgs e)
        {
            if (TBox.Text.Equals("") || PBox.Text.Equals(""))
            {
                MessageBox.Show("You should Choose all the sizes first !!!");
            }
            else
            {

                string connectionString;
                connectionString = "Data Source=AHC-5-2-2017\\sqlexpress;Initial Catalog=SProject;Integrated Security=True";
                SqlConnection conn = new SqlConnection(connectionString);

                conn.Open();
                SqlCommand command = new SqlCommand("update emp  set [T-size] ='" + TBox.Text + "' , [P-size] = '" + PBox.Text + "'  where username = '" + username + "' ;", conn);

                command.ExecuteNonQuery();

                MessageBox.Show("Sizes added");


                this.Hide();
                UserMain2 us = new UserMain2(username);
                us.Show();
            }
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Choosing ch = new Choosing(username);
            ch.Show();
        }

        private void DropList_Load(object sender, EventArgs e)
        {

        }

        private void TBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
