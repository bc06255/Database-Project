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

        public AirportsWindow()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
 
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void AirportsWindow_Load(object sender, EventArgs e)
        {
            String connectionString = "Data Source=DESKTOP-PG47RQQ;Initial Catalog=US_Airports;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False;";
            String sql = "SELECT * FROM Airport";
            SqlConnection connection = new SqlConnection(connectionString);
            SqlDataAdapter dataadapter = new SqlDataAdapter(sql, connection);
            connection.Open();
            dataadapter.Fill(ds, "Airport");
            connection.Close();
            airportsGridView.DataSource = ds.Tables[0];
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void airportCityBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void airportNameBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

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





    }
}
