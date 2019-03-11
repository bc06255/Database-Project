using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class MapWindow : Form
    {
        public MapWindow()
        {
            InitializeComponent();
            SqlDataReader reader;
            SqlCommand cmd;
            String georgiaTooltipText = "";
            String californiaTooltipText = "";

            using (SqlConnection connection = new SqlConnection("Data Source=DESKTOP-PG47RQQ;Initial Catalog=US_Airports;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False;"))
            {
                connection.Open();
                using (cmd = new SqlCommand("SELECT COUNT(*) AS GeorgiaAirports " +
                                                       "FROM Airport " +
                                                       "WHERE AirportState = 'GA'; ", connection))
                {
                    reader = cmd.ExecuteReader();
                    reader.Read();
                    georgiaTooltipText = "Airports:\t\t" + String.Format("{0}", reader["GeorgiaAirports"]) + "\n";
                    reader.Close();
                }
                using (cmd = new SqlCommand("SELECT TOP 1 AirportName FROM Airport WHERE AirportState = 'GA' ORDER BY PassengersPerYear DESC", connection))
                {
                    reader = cmd.ExecuteReader();
                    reader.Read();
                    georgiaTooltipText += "Most Popular:\t" + String.Format("{0}", reader["AirportName"]);

                }
            }
            toolTip1.SetToolTip(this.georgiaBtn, georgiaTooltipText);
            toolTip1.SetToolTip(this.californiaBtn, californiaTooltipText);
        }

        private void GeorgiaTooltip_Popup(object sender, PopupEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            userSelectWindow window = new userSelectWindow();
            window.Show();

            
            


        }

        private void button34_Click(object sender, EventArgs e)
        {

        }

        private void button46_Click(object sender, EventArgs e)
        {

        }
    }
}
