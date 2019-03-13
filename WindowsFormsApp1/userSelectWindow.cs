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
    
    public partial class userSelectWindow : Form
    {
        MapWindow mw;
        public int statenum = 50;
        SqlDataReader reader;
        SqlCommand cmd;
        SqlConnection connection;

        String[] airports = new string[25];
        public userSelectWindow()
        {
            InitializeComponent();            
            searchLbl.Visible = false;
            airportBtn.Visible = false;
            airlineBtn.Visible = false;
            flightBtn.Visible = false;
            planeModelBtn.Visible = false;            
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
            if(customerbtn.Visible == true)
            {
                this.Visible = false;
            }
            else
            {
                searchLbl.Visible = false;
                airportBtn.Visible = false;
                airlineBtn.Visible = false;
                flightBtn.Visible = false;
                planeModelBtn.Visible = false;
                customerbtn.Visible = true;
                employeebtn.Visible = true;
            }                      
        }

        private void airportBtn_Click(object sender, EventArgs e)
        {            
            int i = 0;
            using (connection = new SqlConnection("Data Source=DESKTOP-PG47RQQ;Initial Catalog=US_Airports;Integrated Security=True;Connect Timeout=30;" +
                                                                "Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False;"))
            {
                connection.Open();
                switch (statenum)
                {
                    case 0:
                        {
                            using (cmd = new SqlCommand("SELECT * FROM Airport WHERE AirportState = 'AK' ORDER BY AirportCity", connection))
                            {
                                reader = cmd.ExecuteReader();
                                while (reader.Read())
                                {
                                    airports[i] = String.Format("{0}", reader["AirportName"]);
                                    i++;
                                }
                                for (i = 0; i < 25; i++)
                                {
                                    Console.WriteLine(airports[i]);
                                }
                            }

                            break;
                        }
                }
            }
        }

        public void SetState(int num)
        {
            statenum = num;
        }

        public int getState()
        {
            return statenum;
        }
    }

    
}
