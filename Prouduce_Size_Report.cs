using DGVPrinterHelper;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;


namespace Measurement_System

{
    public partial class Prouduce_Size_Report : Form
    {
        private SqlDataAdapter DataAdapter;
        private SqlCommandBuilder Builder;
        private System.Data.DataTable table;
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
           
        

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void ViewSizesBut_Click(object sender, EventArgs e)
        {

            string connectionString;
            connectionString = "Data Source=AHC-5-2-2017\\sqlexpress;Initial Catalog=SProject;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connectionString);
            DataAdapter = new SqlDataAdapter(@"SELECT ID, Name,[T-size],[P-size] FROM dbo.emp ", conn);
            table = new DataTable();
            DataAdapter.Fill(table);
           
            dataGridView1.DataSource = table;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
           

            DGVPrinter printer = new DGVPrinter();
            printer.Title="Sizes Report";
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.HeaderCellAlignment = StringAlignment.Near;
           
          
            printer.PrintDataGridView(dataGridView1);

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
           
        }
    }
}
