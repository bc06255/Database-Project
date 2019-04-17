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
using System.Text.RegularExpressions;

namespace WindowsFormsApp1
{
    
    public partial class userSelectWindow : Form
    {
        MapWindow mw;
        public String statenum = "";
        SqlDataReader reader;
        SqlCommand cmd;
        SqlConnection connection;
        int airportSize = 0;
        DatabaseConnection dbConnection = new DatabaseConnection();

        String[] airports = new string[25];
        public userSelectWindow()
        {
            InitializeComponent();            
            searchLbl.Visible = false;
            airportBtn.Visible = false;
            airlineBtn.Visible = false;
            flightBtn.Visible = false;
            planeModelBtn.Visible = false;
            searchBox.Visible = false;
            searchBtn.Visible = false;
            airportCodeLbl.Visible = false;
            airportCodeBox.Visible = false;
            cityLbl.Visible = false;
            cityBox.Visible = false;
            passengersBox.Visible = false;
            passengersLbl.Visible = false;
            errorLbl.Visible = false;

        }
        
        private void customerbtn_Click(object sender, EventArgs e)
        {
            customerbtn.Visible = false;
            employeebtn.Visible = false;
            searchLbl.Visible = true;
            airportBtn.Visible = true;
            airlineBtn.Visible = true;
            flightBtn.Visible = true;
            planeModelBtn.Visible = true;
            backBtn.Visible = true;
        }

        private void searchLbl_Click(object sender, EventArgs e)
        {
            
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            if (customerbtn.Visible == true)
            {
                this.Visible = false;
            }
            else if (airportBtn.Visible == true)
            {
                searchLbl.Visible = false;
                airportBtn.Visible = false;
                airlineBtn.Visible = false;
                flightBtn.Visible = false;
                planeModelBtn.Visible = false;
                customerbtn.Visible = true;
                employeebtn.Visible = true;
            }
            else if (searchBox.Visible == true)
            {
                searchBox.Visible = false;
                airportBtn.Visible = true;
                airlineBtn.Visible = true;
                flightBtn.Visible = true;
                planeModelBtn.Visible = true;
                searchBtn.Visible = false;
                airportCodeLbl.Visible = false;
                airportCodeBox.Visible = false;
                cityLbl.Visible = false;
                cityBox.Visible = false;
                passengersBox.Visible = false;
                passengersLbl.Visible = false;
                errorLbl.Visible = false;
            }
        }

        private void airportBtn_Click(object sender, EventArgs e)
        {
            searchBox.Items.Clear();
            searchBox.Visible = true;
            searchBtn.Visible = true;
            airportBtn.Visible = false;
            airlineBtn.Visible = false;
            flightBtn.Visible = false;
            planeModelBtn.Visible = false;
            int i = 0;
            String temp;
            using (connection = new SqlConnection(dbConnection.getConnection()))
            {
                connection.Open();
                using (cmd = new SqlCommand("SELECT COUNT(*) AS NumAirports FROM Airport WHERE StateID = '" + statenum + "'", connection))
                {
                    reader = cmd.ExecuteReader();
                    reader.Read();

                    temp = String.Format("{0}", reader["NumAirports"]);
                    airportSize = int.Parse(temp);
                    reader.Close();
                    airports = new string[airportSize];
                }

                using (cmd = new SqlCommand("SELECT * FROM Airport WHERE StateID = '" + statenum + "'" + " ORDER BY AirportName", connection))
                {
                    reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        airports[i] = String.Format("{0}", reader["AirportName"]);
                        i++;
                    }
                    for (i = 0; i < airportSize; i++)
                    {
                        searchBox.Items.Add(airports[i]);
                    }
                    reader.Close();
                }
            }            
        }

        public void SetState(String num)
        {
            statenum = num;
        }

        public String getState()
        {
            return statenum;
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            airportCodeLbl.Visible = true;
            airportCodeBox.Visible = true;
            cityLbl.Visible = true;
            cityBox.Visible = true;
            passengersBox.Visible = true;
            passengersLbl.Visible = true;
            errorLbl.Visible = false;
            
            String temp = "SELECT * FROM Airport WHERE AirportName = '" + searchBox.Text + "'";
            temp = Regex.Replace(temp, "O'H", "O''H");
            int num = 0;
            
            using (connection = new SqlConnection(dbConnection.getConnection()))
            {
                
                connection.Open();
                
                using (cmd = new SqlCommand(temp, connection))
                {
                    reader = cmd.ExecuteReader();
                    reader.Read();
                    try
                    {
                        airportCodeBox.Text = String.Format("{0}", reader["AirportID"]);
                        cityBox.Text = String.Format("{0}", reader["AirportCity"]);
                        temp = String.Format("{0}", reader["PassengersPerYear"]);
                        num = int.Parse(temp);
                        passengersBox.Text = Convert.ToDecimal(num).ToString("#,##0");
                    }
                    catch (InvalidOperationException)
                    {
                        errorLbl.Visible = true;
                    }
                    
                }
            }
            
        }
    }

    
}
