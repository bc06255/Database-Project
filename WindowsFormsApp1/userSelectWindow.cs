using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class userSelectWindow : Form
    {
        public userSelectWindow()
        {
            InitializeComponent();
            searchLbl.Visible = false;
            airportBtn.Visible = false;
            airlineBtn.Visible = false;
            flightBtn.Visible = false;
            planeModelBtn.Visible = false;
            backBtn.Visible = false;
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
            searchLbl.Visible = false;
            airportBtn.Visible = false;
            airlineBtn.Visible = false;
            flightBtn.Visible = false;
            planeModelBtn.Visible = false;
            backBtn.Visible = false;
            customerbtn.Visible = true;
            employeebtn.Visible = true;
        }
    }

    
}
