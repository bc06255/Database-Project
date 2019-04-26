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
        DatabaseConnection dbConnection = new DatabaseConnection();
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
            SqlConnection connection = new SqlConnection(dbConnection.getConnection());
            String select = "SELECT EmployeeID, AirlineID, FirstName, LastName, Email FROM EMPLOYEE";
            SqlDataAdapter dataadapter = new SqlDataAdapter(select, connection);
            connection.Open();
            dataadapter.Fill(ds, "Employee1");
            connection.Close();
            employeeGridView.DataSource = ds.Tables[0];
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<MapWindow>().Count() == 1)
            {
                Application.OpenForms.OfType<MapWindow>().First().Show();
                this.Hide();
            }
            else if (Application.OpenForms.OfType<MapWindow>().Count() > 1)
            {
                Application.OpenForms.OfType<MapWindow>().First().Close();
            }
        }
    }
}
