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
        DatabaseConnection dbConnection = new DatabaseConnection();
        DataSet ds = new DataSet();
        String select = "SELECT AirlineID, AirlineName, PlanesInService " +
                        "FROM AIRLINE";
        private String[] modelArray;
        private int temp = 0;
        private String tempString = "";

        public AirlinesWindow()
        {
            InitializeComponent();
        }


        private void AirlinesWindow_Load(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(dbConnection.getConnection());
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
            try
            {
                SqlConnection connection = new SqlConnection(dbConnection.getConnection());
                connection.Open();
                String insert = "INSERT INTO Airline(AirlineID, AirlineName, PlanesInService) VALUES(@AirlineID, @AirlineName, @PlanesInService)";
                SqlCommand command = new SqlCommand(insert, connection);
                command.Parameters.AddWithValue("@AirlineID", airlineIDBox.Text);
                command.Parameters.AddWithValue("@AirlineName", airlineBox.Text);
                command.Parameters.AddWithValue("@PlanesInService", planesBox.Text);

                command.ExecuteNonQuery();

                SqlDataAdapter dataadapter = new SqlDataAdapter(select, connection);
                ds.Tables[0].Clear();
                dataadapter.Fill(ds, "Airline");
                connection.Close();
                airlinesGridView.DataSource = ds.Tables[0];
            }
            catch (SqlException)
            {
            }
        }

        private void airlinesGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            airlineIDBox.Text = airlinesGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
            airlineBox.Text = airlinesGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
            planesBox.Text = airlinesGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
        }
    }
}
