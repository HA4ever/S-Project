using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Measurement_System

{
    public partial class Login : Form
    {
      
        private static String type = "";
      
     

        string  connectionString = "Data Source=AHC-5-2-2017\\sqlexpress;Initial Catalog=SProject;Integrated Security=True";

        

        public Login()
        {

            InitializeComponent();

           
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

            SqlConnection conn = new SqlConnection(connectionString);
            
            SqlCommand command = new SqlCommand();
            command.Connection = conn;
            conn.Open();
            command.CommandText = "Select UserType from emp where username ='" + UserBox.Text + "'and Password ='" + PassBox.Text + "' ; ";
            SqlDataReader reader = command.ExecuteReader();
            
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
                        UserMain2 us = new UserMain2(UserBox.Text);
                        us.Show();

                    
                
               
            }
            else
            {
                MessageBox.Show("WRONG USERNAME OR PASSWORD");

            }




            conn.Close();




 

        }

        private void userTableBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {

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
