using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS3280_Assignment6_Part1
{
    class clsFlight
    {
        /// <summary>
        /// String variable for storing flight ID
        /// </summary>
        private string flightID;
        /// <summary>
        /// String variable for storing flight number
        /// </summary>
        private string flightNumber;
        /// <summary>
        /// String variable for storing aircraft type
        /// </summary>
        private string aircraftType;

        /// <summary>
        /// public variable for flight id: get = flightid : set = flightid
        /// </summary>
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

        /// <summary>
        /// public variable for flight number: get = flightNumber : set = flightNumber
        /// </summary>
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

        /// <summary>
        /// public variable for aircraft Type: get = aircraftType : set = aircraftType
        /// </summary>
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

        /// <summary>
        /// Public override of the ToString()
        /// </summary>
        /// <returns>flight number + aircraft type</returns>
        public override string ToString()
        {
            return flightNumber + " - " + aircraftType;
        }

    }
}
