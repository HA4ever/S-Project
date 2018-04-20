using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace Measurement_System
{
    public partial class ManageEmp : Form
    {
      private  SqlDataAdapter DataAdapter;
      private  SqlCommandBuilder Builder;
        private DataTable table;

        public ManageEmp()
        {
            InitializeComponent();
        }

       

        
        

        private void ManageEmp_Load_1(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sProjectDataSet.emp' table. You can move, or remove it, as needed.
           



        }

        private void BACK_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminMain ad = new AdminMain();
            ad.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string connectionString;
            connectionString = "Data Source=AHC-5-2-2017\\sqlexpress;Initial Catalog=SProject;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connectionString);
            DataAdapter = new SqlDataAdapter(@"SELECT ID, Name, username, password, [P-number], [T-size], [P-size], UserType FROM dbo.emp ",conn);
            table = new DataTable();
            DataAdapter.Fill(table);
            dataGridView1.DataSource = table;
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Builder = new SqlCommandBuilder(DataAdapter);
                DataAdapter.Update(table);
                MessageBox.Show("Update successful");
              
            }
            catch(System.Data.SqlClient.SqlException)
            {
                MessageBox.Show("The Id is used or empty ");
            }

           
        }
    }
}
