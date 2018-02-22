using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Measurement_System
{
    public partial class Login : Form
    {
        private OleDbConnection conn = new OleDbConnection();
        public Login()
        {
            InitializeComponent();
            conn.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\SONY\Desktop\S project\UserDB.accdb;
Persist Security Info=False;";
        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void EXIT_Click(object sender, EventArgs e)
        {
            this.Dispose();
           this.Close();
        
        }



        private void LG_BUT_Click(object sender, EventArgs e)
        {
           
            conn.Open();

            OleDbCommand command = new OleDbCommand();
            command.Connection = conn;
            command.CommandText = "Select UserType from userTable where username ='" + UserBox.Text + "'and Password ='" + PassBox.Text + "' ";

            OleDbDataReader reader = command.ExecuteReader();
            String type = "";
            while (reader.Read())
            {
                type = reader["UserType"].ToString();
            }

            if (type.Equals("A"))
            {
                this.Hide();
                AdminMain AD = new AdminMain();
                AD.Show();

            }
            else if (type.Equals("E"))
            {

                this.Hide();
                UserMain1 us = new UserMain1();
                us.Show();

            }
            else {
                MessageBox.Show("WRONG USERNAME OR PASSWORD");

            } 


            conn.Close();







            var db = this.userTableTableAdapter.Fill(this.userDBDataSet.UserTable);
            // this.Hide();

            //  US.Show();

        }

        private void userTableBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.userTableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.userDBDataSet);

        }

        private void PassBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void UserBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void usernameTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
