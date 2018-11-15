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
        /// <summary>
        /// Instaniates a new dataAccess
        /// </summary>
        clsDataAccess db = new clsDataAccess();
        /// <summary>
        /// Class named flightDetails
        /// </summary>
        clsFlight FlightDetails;
        /// <summary>
        /// Class names PassengerDetails
        /// </summary>
        clsPassengers PassengerDetails;


        //will have a method that queries the DB for the flights, loops through them, and for each flight creates an object of clsFlight and adds it to a generic list of clsFlight objects.  This list will then be returned by this method.

            /// <summary>
            /// Method for generating the flights class and storing them in their own flightdetails class
            /// </summary>
            /// <returns></returns>
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

        /// <summary>
        /// Method for generating the passenger class and storing them in their own passengerdetails class
        /// </summary>
        /// <param name="flightID"></param>
        /// <returns></returns>
        public List<clsPassengers> getPassengers(int flightID)
        {
            List<clsPassengers> Passengers = new List<clsPassengers>();
            try
            {
                //Create a DataSet to hold the data
                DataSet ds = new DataSet();

                //Number of return values
                int iRet = 0;

                //Get all the values from the Authors table
                ds = db.ExecuteSQLStatement("SELECT PASSENGER.Passenger_ID, First_Name, Last_Name, Seat_Number FROM FLIGHT_PASSENGER_LINK, FLIGHT, PASSENGER WHERE FLIGHT.FLIGHT_ID = FLIGHT_PASSENGER_LINK.FLIGHT_ID AND FLIGHT_PASSENGER_LINK.PASSENGER_ID = PASSENGER.PASSENGER_ID AND FLIGHT.FLIGHT_ID = " + flightID, ref iRet);

                for (int i = 0; i < iRet; i++)
                {
                    PassengerDetails = new clsPassengers();
                    PassengerDetails.getPassengerID = ds.Tables[0].Rows[i][0].ToString();
                    PassengerDetails.getFirstName = ds.Tables[0].Rows[i][1].ToString();
                    PassengerDetails.getLastName = ds.Tables[0].Rows[i][2].ToString();

                    Passengers.Add(PassengerDetails);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(MethodInfo.GetCurrentMethod().DeclaringType.Name + "." + MethodInfo.GetCurrentMethod().Name + " -> " + ex.Message);
                //return false;
            }

            return Passengers.Cast<clsPassengers>().ToList();
        }

    }
}
