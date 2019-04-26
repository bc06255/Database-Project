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
        String select = "SELECT EmployeeID, FirstName, LastName, EMPLOYEE.AirlineID, AirlineName, Email FROM EMPLOYEE JOIN AIRLINE ON Employee.AirlineID = AIRLINE.AirlineID";

        public EmployeesWindow()
        {
            InitializeComponent();
        }

        

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void EmployeesWindow_Load(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(dbConnection.getConnection());
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

        private void employeeGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            employeeIDBox.Text = employeeGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
            airlineIDBox.Text = employeeGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
            fNameBox.Text = employeeGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
            lNameBox.Text = employeeGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
            emailBox.Text = employeeGridView.Rows[e.RowIndex].Cells[5].Value.ToString();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection connection = new SqlConnection(dbConnection.getConnection());
                connection.Open();
                String insert = "INSERT INTO EMPLOYEE(EmployeeID, AirlineID, FirstName, LastName, Email) VALUES(@EmployeeID, @AirlineID, @FirstName, @LastName, @Email)";
                SqlCommand command = new SqlCommand(insert, connection);
                command.Parameters.AddWithValue("@EmployeeID", employeeIDBox.Text);
                command.Parameters.AddWithValue("@AirlineID", airlineIDBox.Text);
                command.Parameters.AddWithValue("@FirstName", fNameBox.Text);
                command.Parameters.AddWithValue("@LastName", lNameBox.Text);
                command.Parameters.AddWithValue("@Email", emailBox.Text);

                command.ExecuteNonQuery();

                SqlDataAdapter dataadapter = new SqlDataAdapter(select, connection);
                ds.Tables[0].Clear();
                dataadapter.Fill(ds, "Employee");
                connection.Close();
                employeeGridView.DataSource = ds.Tables[0];
            }
            catch (SqlException)
            {
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                SqlConnection connection = new SqlConnection(dbConnection.getConnection());
                connection.Open();
                String update = "UPDATE EMPLOYEE SET AirlineID = @AirlineID, FirstName = @FirstName, LastName = @LastName, Email = @Email WHERE EmployeeID = @EmployeeID";
                SqlCommand command = new SqlCommand(update, connection);
                command.Parameters.AddWithValue("@EmployeeID", employeeIDBox.Text);
                command.Parameters.AddWithValue("@AirlineID", airlineIDBox.Text);
                command.Parameters.AddWithValue("@FirstName", fNameBox.Text);
                command.Parameters.AddWithValue("@LastName", lNameBox.Text);
                command.Parameters.AddWithValue("@Email", emailBox.Text);

                command.ExecuteNonQuery();

                SqlDataAdapter dataadapter = new SqlDataAdapter(select, connection);
                ds.Tables[0].Clear();
                dataadapter.Fill(ds, "Employee");
                connection.Close();
                employeeGridView.DataSource = ds.Tables[0];

            }
            catch (SqlException) { }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(dbConnection.getConnection());
            connection.Open();
            String delete = "DELETE FROM EMPLOYEE WHERE EmployeeID = @EmployeeID";
            SqlCommand command = new SqlCommand(delete, connection);

            command.Parameters.AddWithValue("EmployeeID", employeeIDBox.Text);

            command.ExecuteNonQuery();

            SqlDataAdapter dataadapter = new SqlDataAdapter(select, connection);
            ds.Tables[0].Clear();
            dataadapter.Fill(ds, "Employee");
            connection.Close();
            employeeGridView.DataSource = ds.Tables[0];

            
        }
    }
}
