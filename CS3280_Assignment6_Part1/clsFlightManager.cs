using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS3280_Assignment6_Part1
{
    class clsFlightManager
    {

        clsDataAccess db = new clsDataAccess();
        clsFlight FlightDetails;
        private string flightID;
        private string flightNum;


        //will have a method that queries the DB for the flights, loops through them, and for each flight creates an object of clsFlight and adds it to a generic list of clsFlight objects.  This list will then be returned by this method.

        public List<clsFlight> getFlights()
        {
            List<clsFlight> flights = new List<clsFlight>();
            try
            {
                //Create a DataSet to hold the data
                DataSet ds = new DataSet();
                

                //Number of return values
                int iRet = 0;

                //Get all the values from the Authors table
                ds = db.ExecuteSQLStatement("SELECT * FROM flight", ref iRet);

                //Loop through all the values returned
                // for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                //{
                //Add the first and last name to the list box
                //cbFlightName.Items.Add(ds.Tables[0].Rows[i][1].ToString() + " " + ds.Tables[0].Rows[i].ItemArray[2].ToString());
                //}
                

                for (int i = 0; i < iRet; i++)
                {
                    FlightDetails = new clsFlight();
                    FlightDetails.getFlightNumber = ds.Tables[0].Rows[i][0].ToString();
                    FlightDetails.getFlightNumber = ds.Tables[0].Rows[i][1].ToString();
                    FlightDetails.getAircraftType = ds.Tables[0].Rows[i]["Aircraft_Type"].ToString();

                    
                    flights.Add(FlightDetails);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(MethodInfo.GetCurrentMethod().DeclaringType.Name + "." + MethodInfo.GetCurrentMethod().Name + " -> " + ex.Message);
                //return false;
            }
            return flights.Cast<clsFlight>().ToList();
        }


        public string flightid
        {
            set
            {
                flightID = FlightDetails.getFlightID;
            }
            get
            {
                return FlightDetails.getFlightID;
            }
        }

        public string flightNUM
        {
            set
            {
                flightNum = FlightDetails.getFlightNumber;
            }
            get
            {
                return FlightDetails.getFlightNumber;
            }
        }

    }
}
