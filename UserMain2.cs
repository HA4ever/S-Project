using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using System;

namespace Measurement_System
{
    public partial class UserMain2 : Form

    {

        
       static string  connectionString = "Data Source=AHC-5-2-2017\\sqlexpress;Initial Catalog=SProject;Integrated Security=True";

            SqlConnection conn = new SqlConnection(connectionString);

        SqlCommand command = new SqlCommand();

        String username = "";
        public UserMain2()
        {
           
        }
        public UserMain2(String user)
        {
            InitializeComponent();
            username = user;
        }

        private void ViewState_Click(object sender, EventArgs e)
        {
            command.Connection = conn;
            conn.Open();

            

             command.CommandText = "select State from orders where ID = "+ textBox2.Text + ";";
            
            SqlDataReader Reader = command.ExecuteReader();
            if (Reader.HasRows)
            {
                Reader.Read();
                if (Reader["State"].ToString() == "W" || Reader["State"].ToString() == "w")
                {
                    conn.Close();
                    MessageBox.Show("Your order state is : WAITING");
                }
                else if (Reader["State"].ToString() == "A" || Reader["State"].ToString() == "a")
                {
                    conn.Close();
                    MessageBox.Show("Your order state is : ACCEPTED");
                    conn.Close();
                }
                else if (Reader["State"].ToString() == "R" || Reader["State"].ToString() == "r")
                {
                    
                   
                    Reader.Close();
                    command.CommandText = "delete  from orders where ID = " + textBox2.Text + ";";
                    command.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Your order state is : REJECTED");

                }
                else if (Reader["State"].ToString() == "D" || Reader["State"].ToString() == "d") 
                {
                    conn.Close();
                    MessageBox.Show("Your order state is : DELEVERD");
                }
            }
            else
            {
                conn.Close();
                MessageBox.Show("You haven't ordered !");
            }
           
            
               

        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login lg = new Login();
            lg.Show();
        }

        private void SendRequst_Click(object sender, EventArgs e)
        {

            command.Connection = conn;
            conn.Open();
            try
            {
                command.CommandText = "insert into orders (ID,Name,[T-size],[P-size],State) values (" + textBox2.Text + ",'" + textBox1.Text + "', '" + textBox4.Text + "', '" + textBox5.Text + "', 'W' );";

                command.ExecuteNonQuery();
                AdminMain ad = new AdminMain(Convert.ToInt32(textBox2.Text), textBox1.Text, textBox4.Text, textBox5.Text);
                conn.Close();
                MessageBox.Show("Requst sent");
               
            }
            catch (Exception)
            {
                conn.Close();
                MessageBox.Show("You had  ordered already !!!");
              
            }
           


        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            

          

           
            command.Connection = conn;
            conn.Open();
            command.CommandText = "select * from emp where username = '" + username + "' ;";


            SqlDataReader Reader = command.ExecuteReader();

            if (Reader.HasRows)
            {
                Reader.Read();
                textBox1.Text = Reader["Name"].ToString();
                textBox2.Text = Reader["ID"].ToString();
                textBox3.Text = Reader["P-number"].ToString();
                textBox4.Text = Reader["T-size"].ToString();
                textBox5.Text = Reader["P-size"].ToString();
            }
            conn.Close();

        }

        private void Change_S_Click(object sender, EventArgs e)
        {
            this.Close();
            
            Choosing ch = new Choosing(username);
            ch.Show();
        }

        private void UserMain2_Load(object sender, EventArgs e)
        {

        }


        public string testConn(string username)
        {
            string id;

            command.Connection = conn;
            conn.Open();



            command.CommandText = "select ID from emp where username = '" + username + "';";

            SqlDataReader Reader = command.ExecuteReader();
            if (Reader.HasRows)
            {
                Reader.Read();

                id = Reader["ID"].ToString();
                conn.Close();
                return id;
            }
            return null;
        }
    }
}
