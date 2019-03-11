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
            String[] stateText = new String[50];
            for (int i = 0; i< 50; i++)
            {
                stateText[i] = "Airports:\t\t";
            }
            String alaskaText, alabamaText, arkansasText, arizonaText, californiaText, coloradoText, connecticutText, delawareText, floridaText, georgiaText;
            alaskaText = alabamaText = arkansasText = arizonaText = georgiaText = californiaText = coloradoText = connecticutText = delawareText = floridaText = "Airports:\t\t";
            String[] numAirports, mostPopular;
            numAirports = mostPopular = new string[50];

            using (SqlConnection connection = new SqlConnection("Data Source=DESKTOP-PG47RQQ;Initial Catalog=US_Airports;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False;"))
            {
                connection.Open();
                using (cmd = new SqlCommand("SELECT AirportState, COUNT(*) AS Airports FROM Airport GROUP BY AirportState " , connection))
                {
                    reader = cmd.ExecuteReader();

                    int i = 0;
                    while (reader.Read())
                    {
                        numAirports[i] = String.Format("{0}", reader["Airports"]);
                        i++;
                    }

                    for(i=0; i<50; i++)
                    {
                        stateText[i] += numAirports[i] + "\n";
                    }
                    stateText[7] = "Airports:\t\t0\n";
                    reader.Close();
                }
                using (cmd = new SqlCommand("SELECT a.AirportState, a.AirportName, a.PassengersPerYear FROM(SELECT AirportState, MAX(PassengersPerYear) AS MostPopular " +
                                            "FROM Airport GROUP BY AirportState) AS b INNER JOIN Airport AS a ON a.AirportState = b.AirportState " +
                                            "AND a.PassengersPerYear = b.MostPopular ORDER BY AirportState", connection))
                {
                    reader = cmd.ExecuteReader();
                    int i = 0;

                    while (reader.Read())
                    {
                        mostPopular[i] = String.Format("{0}", reader["AirportName"]);
                        i++;
                    }

                    for (i = 0; i < 50; i++)
                    {
                        stateText[i] += "Most Popular:\t" + mostPopular[i];
                    }
                    reader.Close();

                }
               

            }
           
            toolTip1.SetToolTip(this.alabamaBtn, stateText[1]);
            toolTip1.SetToolTip(this.arkansasBtn, stateText[2]);
            toolTip1.SetToolTip(this.arizonaBtn, stateText[3]);
            toolTip1.SetToolTip(this.californiaBtn, stateText[4]);
            toolTip1.SetToolTip(this.coloradoBtn, stateText[5]);
            toolTip1.SetToolTip(this.connecticutBtn, stateText[6]);
            toolTip1.SetToolTip(this.delawareBtn, stateText[7]);
            toolTip1.SetToolTip(this.floridaBtn, stateText[8]);
            toolTip1.SetToolTip(this.georgiaBtn, stateText[9]);
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
