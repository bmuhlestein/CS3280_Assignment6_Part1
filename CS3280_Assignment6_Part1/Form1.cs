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
        /// <summary>
        /// class for Flight Manager
        /// </summary>
        clsFlightManager flightManagerDetails;
        /// <summary>
        /// List for flight details
        /// </summary>
        List<clsFlight> list;
        /// <summary>
        /// List for passenger details
        /// </summary>
        List<clsPassengers> list1;
        /// <summary>
        /// Binding list for the flight details
        /// </summary>
        BindingList<clsFlight> bindingList;
        /// <summary>
        /// Binding list  for passenger details
        /// </summary>
        BindingList<clsPassengers> bindingList1;
        /// <summary>
        /// Boolean for determining if the flight had been loaded or not
        /// </summary>
        private bool initalLoad = false;
        /// <summary>
        /// Boolean for determining if the passengers had been loaded or not
        /// </summary>
        private bool initalLoad1 = false;
        //ucFlight1 flight1;


        public Form1()
        {
            InitializeComponent();
            //flightDetails = new clsFlight();
            
            flightManagerDetails = new clsFlightManager();
            //flight1 = new ucFlight1();
        }

        /// <summary>
        /// Add Passenger Button click method
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddPassenger_Click(object sender, EventArgs e)
        {
            AddPassengerForm newPassenger = new AddPassengerForm();
            this.Hide();
            newPassenger.ShowDialog();
            this.Show();
        }

        /// <summary>
        /// Method called when the Form is initially loaded
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            list = flightManagerDetails.getFlights();
            bindingList = new BindingList<clsFlight>(list);
            cbFlightName.DataSource = bindingList;
            cbFlightName.SelectedIndex = -1;
            //lblFlightName.Text = flightManagerDetails.flightNUM;
        }

        /// <summary>
        /// Called Event when the flight name comboBox gets changed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbFlightName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (initalLoad != false)
            {
                if (cbFlightName.SelectedIndex == 0)
                {
                    lblFlightName.Text = "102";
                    pnlFlight1.Visible = true;
                    //flight1.Visible = true;
                    pnlFlight2.Visible = false;
                    cbPassengerName.Enabled = true;
                    list1 = flightManagerDetails.getPassengers(1);
                    bindingList1 = new BindingList<clsPassengers>(list1);
                    cbPassengerName.DataSource = bindingList1;
                    cbPassengerName.SelectedIndex = -1;
                }
                else if (cbFlightName.SelectedIndex == 1)
                {
                    lblFlightName.Text = "412";
                    pnlFlight2.Visible = true;
                    pnlFlight1.Visible = false;
                    cbPassengerName.Enabled = true;
                    list1 = flightManagerDetails.getPassengers(2);
                    bindingList1 = new BindingList<clsPassengers>(list1);
                    cbPassengerName.DataSource = bindingList1;
                    cbPassengerName.SelectedIndex = -1;
                }
                else
                {
                    lblFlightName.Text = "";
                    pnlFlight1.Visible = false;
                    pnlFlight2.Visible = false;
                    //flight1.Visible = false;
                }
            }
            initalLoad = true;
        }

        /// <summary>
        /// Called Event when the passenger name comboBox gets changed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbPassengerName_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnAddPassenger.Enabled = true;
            btnDeletePassenger.Enabled = true;
        }
    }
}
