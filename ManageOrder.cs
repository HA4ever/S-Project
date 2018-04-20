using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Measurement_System
{
    public partial class ManageOrder : Form
    {
        private SqlDataAdapter DataAdapter;
        private SqlCommandBuilder Builder;
        private DataTable table;

        public ManageOrder()
        {
            InitializeComponent();
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
            DataAdapter = new SqlDataAdapter(@"SELECT ID, Name,[T-size], [P-size],State FROM orders ", conn);
            table = new DataTable();
            DataAdapter.Fill(table);
            dataGridView1.DataSource = table;

        }

        private void ChangeStateBut_Click(object sender, EventArgs e)
        {
            try
            {
                Builder = new SqlCommandBuilder(DataAdapter);
                DataAdapter.Update(table);
                MessageBox.Show("Update successful");

            }
            catch (System.Data.SqlClient.SqlException)
            {
                MessageBox.Show("Wrong state !!! ");
            }


        }
    }
}
