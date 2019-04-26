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
    public partial class SearchWindow : Form
    {

        static DatabaseConnection dbConnection = new DatabaseConnection();
        DataSet ds = new DataSet();
        SqlConnection connection = new SqlConnection(dbConnection.getConnection());
        SqlDataAdapter dataadapter = new SqlDataAdapter();
        

        public SearchWindow()
        {
            InitializeComponent();
        }

        private void SearchWindow_Load(object sender, EventArgs e)
        {
            
           
            String[] searchTables = { "CREW_EMPLOYEE", "EMPLOYEE_JOB", "FLIGHT_CREW", "JOB", "MANUFACTURER", "MODEL", "PLANE", "SEAT", "TICKET_SEAT" };
            int i = 0;
            while (i < searchTables.Length)
            {
                searchBox.Items.Add(searchTables[i]);
                connection.Open();
                String select = "SELECT * FROM " + searchTables[i];
                SqlCommand command = new SqlCommand(select, connection);

                command.ExecuteNonQuery();
                connection.Close();
                dataadapter = new SqlDataAdapter(select, connection);
                switch (i)
                {
                    case 0:
                        dataadapter.Fill(ds, "CREW_EMPLOYEE");
                        
                        break;
                    case 1:
                        dataadapter.Fill(ds, "EMPLOYEE_JOB");
                        
                        break;
                    case 2:
                        dataadapter.Fill(ds, "FLIGHT_CREW");
                        
                        break;
                    case 3:
                        dataadapter.Fill(ds, "JOB");
                        
                        break;
                    case 4:
                        dataadapter.Fill(ds, "MANUFACTURER");
                        
                        break;
                    case 5:
                        dataadapter.Fill(ds, "MODEL");
                        
                        break;
                    case 6:
                        dataadapter.Fill(ds, "PLANE");
                       
                        break;
                    case 7:
                        dataadapter.Fill(ds, "SEAT");
                        
                        break;
                    case 8:
                        dataadapter.Fill(ds, "TICKET_SEAT");
                        
                        break;
                }
                i++;
            }
   

            
        }

        private void searchBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            searchGridView.DataSource = null;
            switch (searchBox.SelectedIndex)
            {
                case 0:
                    
                    searchGridView.DataSource = ds.Tables[0];
                    break;
                case 1:
                   
                    searchGridView.DataSource = ds.Tables[1];
                    break;
                case 2:
                    
                    searchGridView.DataSource = ds.Tables[2];
                    break;
                case 3:
                    
                    searchGridView.DataSource = ds.Tables[3];
                    break;
                case 4:
                    
                    searchGridView.DataSource = ds.Tables[4];
                    break;
                case 5:
                    
                    searchGridView.DataSource = ds.Tables[5];
                    break;
                case 6:
                    
                    searchGridView.DataSource = ds.Tables[6];
                    break;
                case 7:
                   
                    searchGridView.DataSource = ds.Tables[7];
                    break;
                case 8:
                    
                    searchGridView.DataSource = ds.Tables[8];
                    break;
            }

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
    }
}
