using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace CS3280_Assignment6_Part1
{
    public partial class Form1 : Form
    {

        //In the UI, when the app first loads, this new method will get called, take the list that is returned, and bind it to the flight combo box.
        //clsFlight flightDetails;
        clsFlightManager flightManagerDetails;
        List<clsFlight> list;
        BindingList<clsFlight> bindingList;


        public Form1()
        {
            InitializeComponent();
            //flightDetails = new clsFlight();
            flightManagerDetails = new clsFlightManager();
        }

        private void btnAddPassenger_Click(object sender, EventArgs e)
        {
            AddPassengerForm newPassenger = new AddPassengerForm();
            this.Hide();
            newPassenger.ShowDialog();
            this.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            list = flightManagerDetails.getFlights();
            bindingList = new BindingList<clsFlight>(list);
            cbFlightName.DataSource = bindingList;
            //lblFlightName.Text = flightManagerDetails.flightNUM;
        }


        private void cbFlightName_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            lblFlightName.Text = flightManagerDetails.flightNUM;
        }
    }
}
