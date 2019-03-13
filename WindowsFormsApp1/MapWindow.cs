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
        userSelectWindow window = new userSelectWindow();
        public int statenum = 50;
        public MapWindow()
        {
            InitializeComponent();
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

            using (SqlConnection connection = new SqlConnection("Data Source=DESKTOP-PG47RQQ;Initial Catalog=US_Airports;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False;"))
            {
                connection.Open();
                using (cmd = new SqlCommand("SELECT AirportState, COUNT(*) AS Airports, SUM(PassengersPerYear) AS TotalPassengers FROM Airport GROUP BY AirportState " , connection))
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
                        stateText[i] += "Most Popular:\t" + mostPopular[i] + "\n";
                        stateText[i] += "Total Passengers:\t" + totalPassengers[i];
                    }
                    reader.Close();

                }
               

            }

            Button[] buttonArray = { alaskaBtn, alabamaBtn, arkansasBtn, arizonaBtn, californiaBtn, coloradoBtn, connecticutBtn, delawareBtn, floridaBtn, georgiaBtn, hawaiiBtn, idahoBtn, illinoisBtn, indianaBtn,
            iowaBtn, kansasBtn, kentuckyBtn, louisianaBtn, massachusettsBtn, marylandBtn, maineBtn,  michiganBtn, minnesotaBtn, missouriBtn, mississippiBtn, montanaBtn, northCarolinaBtn, northDakotaBtn, nebraskaBtn,
            newHampshireBtn, newJerseyBtn, newMexicoBtn, nevadaBtn, newYorkBtn, ohioBtn, oklahomaBtn, oregonBtn, pennsylvaniaBtn, rhodeIslandBtn,
            southCarolinaBtn, southDakotaBtn, tennesseeBtn, texasBtn, utahBtn, virginiaBtn, vermontBtn, washingtonBtn, wisconsinBtn, westVirginaBtn, wyomingBtn };
            for (int i=0; i<buttonArray.Length; i++)
            {
                toolTip1.SetToolTip(buttonArray[i], stateText[i]);
            }
            
        }

        private void alaskaBtn_Click(object sender, EventArgs e)
        {
            window.SetState(0);
            window.Show();
        }

        private void alabamaBtn_Click(object sender, EventArgs e)
        {
            window.SetState(1);
            window.Show();
        }

        private void arkansasBtn_Click(object sender, EventArgs e)
        {
            window.SetState(2);
            window.Show();
        }

        private void arizonaBtn_Click(object sender, EventArgs e)
        {
            window.SetState(3);
            window.Show();
        }

        private void californiaBtn_Click(object sender, EventArgs e)
        {
            window.SetState(4);
            window.Show();
        }

        private void coloradoBtn_Click(object sender, EventArgs e)
        {
            window.SetState(5);
            window.Show();
        }

        private void connecticutBtn_Click(object sender, EventArgs e)
        {
            window.SetState(6);
            window.Show();
        }

        private void delawareBtn_Click(object sender, EventArgs e)
        {
            window.SetState(7);
            window.Show();
        }

        private void floridaBtn_Click(object sender, EventArgs e)
        {
            window.SetState(8);
            window.Show();
        }
        
        private void georgiaBtn_Click(object sender, EventArgs e)
        {
            window.SetState(9);
            window.Show();
        }

        private void hawaiiBtn_Click(object sender, EventArgs e)
        {
            window.Show();
        }

        private void idahoBtn_Click(object sender, EventArgs e)
        {
            window.Show();
        }

        private void illinoisBtn_Click(object sender, EventArgs e)
        {
            window.Show();
        }

        private void indianaBtn_Click(object sender, EventArgs e)
        {
            window.Show();
        }

        private void iowaBtn_Click(object sender, EventArgs e)
        {
            window.Show();
        }

        private void kansasBtn_Click(object sender, EventArgs e)
        {
            window.Show();
        }

        private void kentuckyBtn_Click(object sender, EventArgs e)
        {
            window.Show();
        }

        private void louisianaBtn_Click(object sender, EventArgs e)
        {
            window.Show();
        }

        private void massachusettsBtn_Click(object sender, EventArgs e)
        {
            window.Show();
        }

        private void marylandBtn_Click(object sender, EventArgs e)
        {
            window.Show();
        }

        private void maineBtn_Click(object sender, EventArgs e)
        {
            window.Show();
        }

        private void michiganBtn_Click(object sender, EventArgs e)
        {
            window.Show();
        }

        private void minnesotaBtn_Click(object sender, EventArgs e)
        {
            window.Show();
        }

        private void missouriBtn_Click(object sender, EventArgs e)
        {
            window.Show();
        }

        private void mississippiBtn_Click(object sender, EventArgs e)
        {
            window.Show();
        }

        private void montanaBtn_Click(object sender, EventArgs e)
        {
            window.Show();
        }

        private void northCarolinaBtn_Click(object sender, EventArgs e)
        {
            window.Show();
        }

        private void northDakotaBtn_Click(object sender, EventArgs e)
        {
            window.Show();
        }

        private void nebraskaBtn_Click(object sender, EventArgs e)
        {
            window.Show();
        }

        private void newHampshireBtn_Click(object sender, EventArgs e)
        {
            window.Show();
        }

        private void newJerseyBtn_Click(object sender, EventArgs e)
        {
            window.Show();
        }

        private void newMexicoBtn_Click(object sender, EventArgs e)
        {
            window.Show();
        }

        private void nevadaBtn_Click(object sender, EventArgs e)
        {
            window.Show();
        }

        private void newYorkBtn_Click(object sender, EventArgs e)
        {
            window.Show();
        }

        private void ohioBtn_Click(object sender, EventArgs e)
        {
            window.Show();
        }

        private void oklahomaBtn_Click(object sender, EventArgs e)
        {
            window.Show();
        }

        private void oregonBtn_Click(object sender, EventArgs e)
        {
            window.Show();
        }

        private void pennsylvaniaBtn_Click(object sender, EventArgs e)
        {
            window.Show();
        }

        private void rhodeIslandBtn_Click(object sender, EventArgs e)
        {
            window.Show();
        }

        private void southCarolinaBtn_Click(object sender, EventArgs e)
        {
            window.Show();
        }

        private void southDakotaBtn_Click(object sender, EventArgs e)
        {
            window.Show();
        }

        private void tennesseeBtn_Click(object sender, EventArgs e)
        {
            window.Show();
        }

        private void texasBtn_Click(object sender, EventArgs e)
        {
            window.Show();
        }

        private void utahBtn_Click(object sender, EventArgs e)
        {
            window.Show();
        }

        private void virginiaBtn_Click(object sender, EventArgs e)
        {
            window.Show();
        }

        private void vermontBtn_Click(object sender, EventArgs e)
        {
            window.Show();
        }

        private void washingtonBtn_Click(object sender, EventArgs e)
        {
            window.Show();
        }

        private void wisconsinBtn_Click(object sender, EventArgs e)
        {
            window.Show();
        }

        private void westVirginaBtn_Click(object sender, EventArgs e)
        {
            window.Show();
        }

        private void wyomingBtn_Click(object sender, EventArgs e)
        {
            window.Show();
        }











































        private void pictureBox1_Click(object sender, EventArgs e)
        {
            window.Show();
        }

        

        

        

        

        

        

        

        

        

        

        

        

        

        

        

        
    }

}
