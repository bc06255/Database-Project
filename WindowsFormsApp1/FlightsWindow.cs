using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FlightsWindow : Form
    {

        DatabaseConnection dbConnection = new DatabaseConnection();
        DataSet ds = new DataSet();
        String select = "SELECT * FROM FLIGHT";
        

        public FlightsWindow()
        {
            InitializeComponent();
        }

        private void FlightsWindow_Load(object sender, EventArgs e)
        {
            flightDateBox.Format = DateTimePickerFormat.Custom;
            flightDateBox.CustomFormat = "yyyy-MM-dd";
            SqlConnection connection = new SqlConnection(dbConnection.getConnection());
            SqlDataAdapter dataadapter = new SqlDataAdapter(select, connection);

            connection.Open();

            dataadapter.Fill(ds, "Flight");
            connection.Close();
            flightsGridView.DataSource = ds.Tables[0];
            flightsGridView.Columns[1].DefaultCellStyle.Format = "yyyy-MM-dd";
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

        private void addBtn_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection connection = new SqlConnection(dbConnection.getConnection());
                connection.Open();
                String insert = "INSERT INTO FLIGHT VALUES(@FlightID, @FlightDate, @SourceAirport, @DestAirport, @PlaneID, @CrewID)";
                SqlCommand command = new SqlCommand(insert, connection);
                command.Parameters.AddWithValue("@FlightID", flightIDBox.Text);
                command.Parameters.AddWithValue("@FlightDate", flightDateBox.Text);
                command.Parameters.AddWithValue("@SourceAirport", sourceBox.Text);
                command.Parameters.AddWithValue("@DestAirport", destBox.Text);
                command.Parameters.AddWithValue("@PlaneID", planeIDBox.Text);
                command.Parameters.AddWithValue("@CrewID", crewIDBox.Text);

                command.ExecuteNonQuery();

                SqlDataAdapter dataadapter = new SqlDataAdapter(select, connection);
                ds.Tables[0].Clear();
                dataadapter.Fill(ds, "Flight");
                connection.Close();
                flightsGridView.DataSource = ds.Tables[0];
            }
            catch (SqlException)
            {
            }
        }

        private void flightsGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            
            flightIDBox.Text = flightsGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
            flightDateBox.Text = flightsGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
            sourceBox.Text = flightsGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
            destBox.Text = flightsGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
            planeIDBox.Text = flightsGridView.Rows[e.RowIndex].Cells[4].Value.ToString();
            crewIDBox.Text = flightsGridView.Rows[e.RowIndex].Cells[5].FormattedValue.ToString();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            
                SqlConnection connection = new SqlConnection(dbConnection.getConnection());
                connection.Open();
                String delete = "DELETE FROM FLIGHT WHERE FlightID = " + flightIDBox.Text;
                SqlCommand command = new SqlCommand(delete, connection);

                command.ExecuteNonQuery();

                SqlDataAdapter dataadapter = new SqlDataAdapter(select, connection);
                ds.Tables[0].Clear();
                dataadapter.Fill(ds, "Flight");
                connection.Close();
                flightsGridView.DataSource = ds.Tables[0];
            

        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection connection = new SqlConnection(dbConnection.getConnection());
                connection.Open();
                String update = "UPDATE FLIGHT SET FlightDate = @FlightDate, SourceAirportID = @Source, DestAirportID = @Dest, PlaneID = @PlaneID, CrewID = @CrewID WHERE FlightID = @FlightID";
                SqlCommand command = new SqlCommand(update, connection);
                command.Parameters.AddWithValue("@FlightID", flightIDBox.Text);
                command.Parameters.AddWithValue("@FlightDate", flightDateBox.Text);
                command.Parameters.AddWithValue("@Source", sourceBox.Text);
                command.Parameters.AddWithValue("@Dest", destBox.Text);
                command.Parameters.AddWithValue("@PlaneID", planeIDBox.Text);
                command.Parameters.AddWithValue("@CrewID", crewIDBox.Text);

                command.ExecuteNonQuery();

                SqlDataAdapter dataadapter = new SqlDataAdapter(select, connection);
                ds.Tables[0].Clear();
                dataadapter.Fill(ds, "Flight");
                connection.Close();
                flightsGridView.DataSource = ds.Tables[0];

            }
            catch (SqlException) { }
        }
    }
}
