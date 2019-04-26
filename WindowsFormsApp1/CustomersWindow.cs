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
    public partial class CustomersWindow : Form
    {
        DatabaseConnection dbConnection = new DatabaseConnection();
        DataSet ds = new DataSet();
        String select = "SELECT * FROM CUSTOMER";

        public CustomersWindow()
        {
            InitializeComponent();
        }

        private void CustomersWindow_Load(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(dbConnection.getConnection());
            SqlDataAdapter dataadapter = new SqlDataAdapter(select, connection);
            connection.Open();
            dataadapter.Fill(ds, "Customer");
            connection.Close();
            customerGridView.DataSource = ds.Tables[0];
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection connection = new SqlConnection(dbConnection.getConnection());
                connection.Open();
                String insert = "INSERT INTO CUSTOMER VALUES(@CustomerID, @FirstName, @LastName, @Email)";
                SqlCommand command = new SqlCommand(insert, connection);
                command.Parameters.AddWithValue("@CustomerID", customerIDBox.Text);
                command.Parameters.AddWithValue("@FirstName", fNameBox.Text);
                command.Parameters.AddWithValue("@LastName", lNameBox.Text);
                command.Parameters.AddWithValue("@Email", emailBox.Text);

                command.ExecuteNonQuery();

                SqlDataAdapter dataadapter = new SqlDataAdapter(select, connection);
                ds.Tables[0].Clear();
                dataadapter.Fill(ds, "Customer");
                connection.Close();
                customerGridView.DataSource = ds.Tables[0];
            }
            catch (SqlException)
            {
            }
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

        private void customerGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            customerIDBox.Text = customerGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
            fNameBox.Text = customerGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
            lNameBox.Text = customerGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
            emailBox.Text = customerGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                SqlConnection connection = new SqlConnection(dbConnection.getConnection());
                connection.Open();
                String update = "UPDATE CUSTOMER SET FirstName = @FirstName, LastName = @LastName, Email = @Email WHERE CustomerID = @CustomerID";
                SqlCommand command = new SqlCommand(update, connection);
                command.Parameters.AddWithValue("@CustomerID", customerIDBox.Text);
                command.Parameters.AddWithValue("@FirstName", fNameBox.Text);
                command.Parameters.AddWithValue("@LastName", lNameBox.Text);
                command.Parameters.AddWithValue("@Email", emailBox.Text);

                command.ExecuteNonQuery();

                SqlDataAdapter dataadapter = new SqlDataAdapter(select, connection);
                ds.Tables[0].Clear();
                dataadapter.Fill(ds, "Customer");
                connection.Close();
                customerGridView.DataSource = ds.Tables[0];

            }
            catch (SqlException) { }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(dbConnection.getConnection());
            connection.Open();
            String delete = "DELETE FROM CUSTOMER WHERE CustomerID = @CustomerID";
            SqlCommand command = new SqlCommand(delete, connection);

            command.Parameters.AddWithValue("@CustomerID", customerIDBox.Text);

            command.ExecuteNonQuery();

            SqlDataAdapter dataadapter = new SqlDataAdapter(select, connection);
            ds.Tables[0].Clear();
            dataadapter.Fill(ds, "Customer");
            connection.Close();
            customerGridView.DataSource = ds.Tables[0];
        }
    }
}
