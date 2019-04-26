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
using System.Threading;

namespace WindowsFormsApp1
{
    public partial class MapWindow : Form
    {
        DatabaseConnection dbConnection = new DatabaseConnection();
        EmployeesWindow employeesWindow = new EmployeesWindow();
        AirportsWindow airportsWindow = new AirportsWindow();
        FlightsWindow flightsWindow = new FlightsWindow();
        public int statenum = 50;




        public MapWindow()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            
            SqlDataReader reader;
            SqlCommand cmd;

            String[] numAirports, mostPopular, stateText;
            String[] totalPassengers;
            numAirports = mostPopular = new String[50];
            totalPassengers = new String[50];
            stateText = new String[50];
            int[] num = new int[50];

                        
            for (int i = 0; i < 50; i++)
            {
                stateText[i] = "Airports:\t\t";
            }

            

            using (SqlConnection connection = new SqlConnection(dbConnection.getConnection()))
            {
                connection.Open();
                using (cmd = new SqlCommand("SELECT StateID, COUNT(*) AS Airports, SUM(PassengersPerYear) AS TotalPassengers FROM Airport GROUP BY StateID ", connection))
                {
                    reader = cmd.ExecuteReader();
                    var totlpssngrs = reader.GetOrdinal("TotalPassengers");
                    int i = 0;
                    while (reader.Read())
                    {
                        numAirports[i] = String.Format("{0}", reader["Airports"]);
                        totalPassengers[i] = String.Format("{0}", reader["TotalPassengers"]);
                        num[i] = int.Parse(totalPassengers[i], System.Globalization.NumberStyles.AllowThousands);
                        totalPassengers[i] = Convert.ToDecimal(num[i]).ToString("#,##0");
                        i++;
                    }

                    for (i = 0; i < 50; i++)
                    {
                        stateText[i] += numAirports[i] + "\n";
                    }
                    stateText[7] = "Airports:\t\t0\n";
                    reader.Close();
                }
                using (cmd = new SqlCommand("SELECT a.StateID, a.AirportName, a.PassengersPerYear FROM(SELECT StateID, MAX(PassengersPerYear) AS MostPopular " +
                                            "FROM Airport GROUP BY StateID) AS b INNER JOIN Airport AS a ON a.StateID = b.StateID " +
                                            "AND a.PassengersPerYear = b.MostPopular ORDER BY StateID", connection))
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
                        stateText[i] += "Most Popular:\t" + mostPopular[i] + "\n";
                        stateText[i] += "Total Passengers:\t" + totalPassengers[i];
                    }
                    reader.Close();

                }


            }
            Label[] labelArray = {alaskaBtn, alabamaBtn, arkansasBtn, arizonaBtn, californiaBtn, coloradoBtn, connecticutBtn, delawareBtn, floridaBtn, georgiaBtn, hawaiiBtn, idahoBtn, illinoisBtn, indianaBtn,
            iowaBtn, kansasBtn, kentuckyBtn, louisianaBtn, massachusettsBtn, marylandBtn, maineBtn,  michiganBtn, minnesotaBtn, missouriBtn, mississippiBtn, montanaBtn, northCarolinaBtn, northDakotaBtn, nebraskaBtn,
            newHampshireBtn, newJerseyBtn, newMexicoBtn, nevadaBtn, newYorkBtn, ohioBtn, oklahomaBtn, oregonBtn, pennsylvaniaBtn, rhodeIslandBtn,
            southCarolinaBtn, southDakotaBtn, tennesseeBtn, texasBtn, utahBtn, virginiaBtn, vermontBtn, washingtonBtn, wisconsinBtn, westVirginiaBtn, wyomingBtn };


            for (int i=0; i<labelArray.Length; i++)
            {
                toolTip1.SetToolTip(labelArray[i], stateText[i]);
            }
            
        }
        


    

        private void button3_Click(object sender, EventArgs e)
        {
            AirlinesWindow window = new AirlinesWindow();

            if (Application.OpenForms.OfType<AirlinesWindow>().Count() == 1)
            {
                Application.OpenForms.OfType<AirlinesWindow>().First().Show();
            }
            else
            {
                window.Show();
            }
            this.Hide();
        }

        private void manageEmployeesBtn_Click(object sender, EventArgs e)
        {            
            employeesWindow.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<AirportsWindow>().Count() == 1)
            {
                Application.OpenForms.OfType<AirportsWindow>().First().Show();
            }
            else
            {
                airportsWindow.Show();
            }    
            this.Hide();  
        }

        private void MapWindow_Load(object sender, EventArgs e)
        {

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

        private void manageFlightsBtn_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<FlightsWindow>().Count() == 1)
            {
                Application.OpenForms.OfType<FlightsWindow>().First().Show();
            }
            else
            {
                flightsWindow.Show();
            }
            this.Hide();
        }
    }

}
