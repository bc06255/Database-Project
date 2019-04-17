﻿using System;
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
        userSelectWindow window = new userSelectWindow();
        EmployeesWindow employeesWindow = new EmployeesWindow();
        AirportsWindow airportsWindow = new AirportsWindow();
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

            Button[] buttonArray = { alaskaBtn, alabamaBtn, arkansasBtn, arizonaBtn, californiaBtn, coloradoBtn, connecticutBtn, delawareBtn, floridaBtn, georgiaBtn, hawaiiBtn, idahoBtn, illinoisBtn, indianaBtn,
            iowaBtn, kansasBtn, kentuckyBtn, louisianaBtn, massachusettsBtn, marylandBtn, maineBtn,  michiganBtn, minnesotaBtn, missouriBtn, mississippiBtn, montanaBtn, northCarolinaBtn, northDakotaBtn, nebraskaBtn,
            newHampshireBtn, newJerseyBtn, newMexicoBtn, nevadaBtn, newYorkBtn, ohioBtn, oklahomaBtn, oregonBtn, pennsylvaniaBtn, rhodeIslandBtn,
            southCarolinaBtn, southDakotaBtn, tennesseeBtn, texasBtn, utahBtn, virginiaBtn, vermontBtn, washingtonBtn, wisconsinBtn, westVirginiaBtn, wyomingBtn };
            for (int i=0; i<buttonArray.Length; i++)
            {
                toolTip1.SetToolTip(buttonArray[i], stateText[i]);
            }
            
        }
        

        private void alaskaBtn_Click(object sender, EventArgs e)
        {
            window.SetState(alaskaBtn.Text);
            window.Show();
        }

        private void alabamaBtn_Click(object sender, EventArgs e)
        {
            window.SetState(alabamaBtn.Text);
            window.Show();
        }

        private void arkansasBtn_Click(object sender, EventArgs e)
        {
            window.SetState(arkansasBtn.Text);
            window.Show();
        }

        private void arizonaBtn_Click(object sender, EventArgs e)
        {
            window.SetState(arizonaBtn.Text);
            window.Show();
        }

        private void californiaBtn_Click(object sender, EventArgs e)
        {
            window.SetState(californiaBtn.Text);
            window.Show();
        }

        private void coloradoBtn_Click(object sender, EventArgs e)
        {
            window.SetState(coloradoBtn.Text);
            window.Show();
        }

        private void connecticutBtn_Click(object sender, EventArgs e)
        {
            window.SetState(connecticutBtn.Text);
            window.Show();
        }

        private void delawareBtn_Click(object sender, EventArgs e)
        {
            window.SetState(delawareBtn.Text);
            window.Show();
        }

        private void floridaBtn_Click(object sender, EventArgs e)
        {
            window.SetState(floridaBtn.Text);
            window.Show();
        }
        
        private void georgiaBtn_Click(object sender, EventArgs e)
        {
            window.SetState(georgiaBtn.Text);
            window.Show();
        }

        private void hawaiiBtn_Click(object sender, EventArgs e)
        {
            window.SetState(hawaiiBtn.Text);
            window.Show();
        }

        private void idahoBtn_Click(object sender, EventArgs e)
        {
            window.SetState(idahoBtn.Text);
            window.Show();
        }

        private void illinoisBtn_Click(object sender, EventArgs e)
        {
            window.SetState(illinoisBtn.Text);
            window.Show();
        }

        private void indianaBtn_Click(object sender, EventArgs e)
        {
            window.SetState(indianaBtn.Text);
            window.Show();
        }

        private void iowaBtn_Click(object sender, EventArgs e)
        {
            window.SetState(iowaBtn.Text);
            window.Show();
        }

        private void kansasBtn_Click(object sender, EventArgs e)
        {
            window.SetState(kansasBtn.Text);
            window.Show();
        }

        private void kentuckyBtn_Click(object sender, EventArgs e)
        {
            window.SetState(kentuckyBtn.Text);
            window.Show();
        }

        private void louisianaBtn_Click(object sender, EventArgs e)
        {
            window.SetState(louisianaBtn.Text);
            window.Show();
        }

        private void massachusettsBtn_Click(object sender, EventArgs e)
        {
            window.SetState(massachusettsBtn.Text);
            window.Show();
        }

        private void marylandBtn_Click(object sender, EventArgs e)
        {
            window.SetState(marylandBtn.Text);
            window.Show();
        }

        private void maineBtn_Click(object sender, EventArgs e)
        {
            window.SetState(maineBtn.Text);
            window.Show();
        }

        private void michiganBtn_Click(object sender, EventArgs e)
        {
            window.SetState(michiganBtn.Text);
            window.Show();
        }

        private void minnesotaBtn_Click(object sender, EventArgs e)
        {
            window.SetState(minnesotaBtn.Text);
            window.Show();
        }

        private void missouriBtn_Click(object sender, EventArgs e)
        {
            window.SetState(missouriBtn.Text);
            window.Show();
        }

        private void mississippiBtn_Click(object sender, EventArgs e)
        {
            window.SetState(missouriBtn.Text);
            window.Show();
        }

        private void montanaBtn_Click(object sender, EventArgs e)
        {
            window.SetState(mississippiBtn.Text);
            window.Show();
        }

        private void northCarolinaBtn_Click(object sender, EventArgs e)
        {
            window.SetState(northCarolinaBtn.Text);
            window.Show();
        }

        private void northDakotaBtn_Click(object sender, EventArgs e)
        {
            window.SetState(northDakotaBtn.Text);
            window.Show();
        }

        private void nebraskaBtn_Click(object sender, EventArgs e)
        {
            window.SetState(nebraskaBtn.Text);
            window.Show();
        }

        private void newHampshireBtn_Click(object sender, EventArgs e)
        {
            window.SetState(newHampshireBtn.Text);
            window.Show();
        }

        private void newJerseyBtn_Click(object sender, EventArgs e)
        {
            window.SetState(newJerseyBtn.Text);
            window.Show();
        }

        private void newMexicoBtn_Click(object sender, EventArgs e)
        {
            window.SetState(newMexicoBtn.Text);
            window.Show();
        }

        private void nevadaBtn_Click(object sender, EventArgs e)
        {
            window.SetState(nevadaBtn.Text);
            window.Show();
        }

        private void newYorkBtn_Click(object sender, EventArgs e)
        {
            window.SetState(newYorkBtn.Text);
            window.Show();
        }

        private void ohioBtn_Click(object sender, EventArgs e)
        {
            window.SetState(ohioBtn.Text);
            window.Show();
        }

        private void oklahomaBtn_Click(object sender, EventArgs e)
        {
            window.SetState(oklahomaBtn.Text);
            window.Show();
        }

        private void oregonBtn_Click(object sender, EventArgs e)
        {
            window.SetState(oregonBtn.Text);
            window.Show();
        }

        private void pennsylvaniaBtn_Click(object sender, EventArgs e)
        {
            window.SetState(pennsylvaniaBtn.Text);
            window.Show();
        }

        private void rhodeIslandBtn_Click(object sender, EventArgs e)
        {
            window.SetState(rhodeIslandBtn.Text);
            window.Show();
        }

        private void southCarolinaBtn_Click(object sender, EventArgs e)
        {
            window.SetState(southCarolinaBtn.Text);
            window.Show();
        }

        private void southDakotaBtn_Click(object sender, EventArgs e)
        {
            window.SetState(southDakotaBtn.Text);
            window.Show();
        }

        private void tennesseeBtn_Click(object sender, EventArgs e)
        {
            window.SetState(tennesseeBtn.Text);
            window.Show();
        }

        private void texasBtn_Click(object sender, EventArgs e)
        {
            window.SetState(texasBtn.Text);
            window.Show();
        }

        private void utahBtn_Click(object sender, EventArgs e)
        {
            window.SetState(utahBtn.Text);
            window.Show();
        }

        private void virginiaBtn_Click(object sender, EventArgs e)
        {
            window.SetState(virginiaBtn.Text);
            window.Show();
        }

        private void vermontBtn_Click(object sender, EventArgs e)
        {
            window.SetState(vermontBtn.Text);
            window.Show();
        }

        private void washingtonBtn_Click(object sender, EventArgs e)
        {
            window.SetState(washingtonBtn.Text);
            window.Show();
        }

        private void wisconsinBtn_Click(object sender, EventArgs e)
        {
            window.SetState(wisconsinBtn.Text);
            window.Show();
        }

        private void westVirginaBtn_Click(object sender, EventArgs e)
        {
            window.SetState(westVirginiaBtn.Text);
            window.Show();
        }

        private void wyomingBtn_Click(object sender, EventArgs e)
        {
            window.SetState(wyomingBtn.Text);
            window.Show();
        }





        private void pictureBox1_Click(object sender, EventArgs e)
        {
            window.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

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

    }

}
