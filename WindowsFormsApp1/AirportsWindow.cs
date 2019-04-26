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
    
    public partial class AirportsWindow : Form
    {
        DataSet ds = new DataSet();
        DatabaseConnection dbConnection = new DatabaseConnection();
        public AirportsWindow()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
 
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            airportIDBox.Text = airportsGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
            airportStateBox.Text = airportsGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
            airportCityBox.Text = airportsGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
            airportNameBox.Text = airportsGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
            passPerYearBox.Text = airportsGridView.Rows[e.RowIndex].Cells[4].Value.ToString();
        }

        private void AirportsWindow_Load(object sender, EventArgs e)
        {
            String sql = "SELECT * FROM Airport";
            SqlConnection connection = new SqlConnection(dbConnection.getConnection());
            SqlDataAdapter dataadapter = new SqlDataAdapter(sql, connection);
            connection.Open();
            dataadapter.Fill(ds, "Airport");
            connection.Close();
            airportsGridView.DataSource = ds.Tables[0];
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

        protected override void OnFormClosing(FormClosingEventArgs e)
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

        private void addBtn_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection connection = new SqlConnection(dbConnection.getConnection());
                connection.Open();
                String insert = "INSERT INTO AIRPORT(AirportID, StateID, AirportCity, AirportName, PassengersPerYear) VALUES(@AirportID, @StateID, @AirportCity, @AirportName, @Pass)";
                SqlCommand command = new SqlCommand(insert, connection);
                command.Parameters.AddWithValue("@AirportID", airportIDBox.Text);
                command.Parameters.AddWithValue("@StateID", airportStateBox.Text);
                command.Parameters.AddWithValue("@AirportCity", airportCityBox.Text);
                command.Parameters.AddWithValue("@AirportName", airportNameBox.Text);
                command.Parameters.AddWithValue("@Pass", passPerYearBox.Text);

                command.ExecuteNonQuery();

                SqlDataAdapter dataadapter = new SqlDataAdapter(insert, connection);
                ds.Tables[0].Clear();
                dataadapter.Fill(ds, "Airport");
                connection.Close();
                
                airportsGridView.DataSource = ds.Tables[0];
            }
            catch (SqlException)
            {
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection connection = new SqlConnection(dbConnection.getConnection());
                connection.Open();
                String delete = "DELETE FROM AIRPORT WHERE AirportID = @AirportID";
                SqlCommand command = new SqlCommand(delete, connection);

                command.Parameters.AddWithValue("@AirportID", airportIDBox.Text);

                command.ExecuteNonQuery();

                SqlDataAdapter dataadapter = new SqlDataAdapter(delete, connection);
                dataadapter.Fill(ds, "Airport");
                connection.Close();
                airportsGridView.DataSource = ds.Tables[0];
            }
            catch (SqlException) { }
            
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            try
            {

                SqlConnection connection = new SqlConnection(dbConnection.getConnection());
                connection.Open();
                String update = "UPDATE AIRPORT SET StateID = @StateID, AirportCity = @AirportCity, AirportName = @AirportName, PassengersPerYear = @Pass WHERE AirportID = @AirportID";
                SqlCommand command = new SqlCommand(update, connection);
                command.Parameters.AddWithValue("@StateID", airportStateBox.Text);
                command.Parameters.AddWithValue("@AirportCity", airportCityBox.Text);
                command.Parameters.AddWithValue("@AirportName", airportNameBox.Text);
                command.Parameters.AddWithValue("@Pass", passPerYearBox.Text);
                command.Parameters.AddWithValue("@AirportID", airportIDBox.Text);

                command.ExecuteNonQuery();

                SqlDataAdapter dataadapter = new SqlDataAdapter(update, connection);
                ds.Tables[0].Clear();
                dataadapter.Fill(ds, "Airport");
                connection.Close();
                airportsGridView.DataSource = ds.Tables[0];

            }
            catch (SqlException) { }
        }
    }
}
