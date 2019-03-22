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
    public partial class AirlinesWindow : Form
    {
        
        DataSet ds = new DataSet();
        String connectionString = "Data Source=DESKTOP-PG47RQQ;Initial Catalog=US_Airports;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False;";
        String select = "SELECT AirlineID, AirlineName, Plane.PlaneID, ModelCompany, Model, PlanesInService " +
                        "FROM Plane LEFT JOIN Airline " +
                        "ON Plane.PlaneID = Airline.PlaneID " +
                        "ORDER BY AirlineID, PlaneID";
        private String[] modelArray;
        private int temp = 0;
        private String tempString = "";

        public AirlinesWindow()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void AirlinesWindow_Load(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            SqlDataAdapter dataadapter = new SqlDataAdapter(select, connection);
            
            connection.Open();
                                 
            dataadapter.Fill(ds, "Airline");
            connection.Close();
            airlinesGridView.DataSource = ds.Tables[0];
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

        private void addAirlineBtn_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            String insert = "INSERT INTO Airline(AirlineID, AirlineName, PlaneID, PlanesInService) VALUES(@AirlineID, @AirlineName, @PlaneID, @PlanesInService)";
            SqlCommand command = new SqlCommand(insert, connection);
            command.Parameters.AddWithValue("@AirlineID", airlineIDBox.Text);
            command.Parameters.AddWithValue("@AirlineName", airlineBox.Text);
            command.Parameters.AddWithValue("@PlaneID", planeIDBox.Text);
            command.Parameters.AddWithValue("@PlanesInService", planesBox.Text);

            command.ExecuteNonQuery();

            SqlDataAdapter dataadapter = new SqlDataAdapter(select, connection);
            dataadapter.Fill(ds, "Airline");
            connection.Close();
            airlinesGridView.DataSource = ds.Tables[0];
        }
    }
}
