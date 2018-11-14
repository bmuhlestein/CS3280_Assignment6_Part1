using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS3280_Assignment6_Part1
{

    //private clsDataAccess hi;


    class clsFlight
    {

        //which only has attributes and properties, and is used to just hold Flight information.  
        private string flightID;
        private string flightNumber;
        private string aircraftType;

        public string getFlightID
        {
            set
            {
                flightID = value;
            }
            get
            {
                return flightID;
            }
        }

        public string getFlightNumber
        {
            set
            {
                flightNumber = value;
            }
            get
            {
                return flightNumber;
            }
        }

        public string getAircraftType
        {
            set
            {
                aircraftType = value;
            }
            get
            {
                return aircraftType;
            }
        }

        public override string ToString()
        {
            return flightNumber + " - " + aircraftType;
        }


    }

}
