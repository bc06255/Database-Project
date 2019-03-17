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
    public partial class AirportsWindow : Form
    {       
        public AirportsWindow()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void AirportsWindow_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'uS_AirportsDataSet1.Airport' table. You can move, or remove it, as needed.
            this.airportTableAdapter.Fill(this.uS_AirportsDataSet1.Airport);

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
            
        }
    }
}
