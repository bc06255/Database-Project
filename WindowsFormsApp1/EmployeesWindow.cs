using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class EmployeesWindow : Form
    {
        DataSet ds = new DataSet();

        public EmployeesWindow()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void EmployeesWindow_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'uS_AirportsDataSet.Employee' table. You can move, or remove it, as needed.
            
            String connectionString = "Data Source=DESKTOP-PG47RQQ;Initial Catalog=US_Airports;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False;";
            String sql = "SELECT * FROM Employee";
            SqlConnection connection = new SqlConnection(connectionString);
            SqlDataAdapter dataadapter = new SqlDataAdapter(sql, connection);
            connection.Open();
            dataadapter.Fill(ds, "Employee");
            connection.Close();
            employeeGridView.DataSource = ds.Tables[0];
        }                
    }
}
