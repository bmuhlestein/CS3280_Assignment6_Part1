using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS3280_Assignment6_Part1
{
    class clsPassengers
    {
        /// <summary>
        /// String variable for storing passenger ID
        /// </summary>
        private string PassengerID;
        /// <summary>
        /// String variable for storing passenger first name
        /// </summary>
        private string FirstName;
        /// <summary>
        /// String variable for storing passenger last name
        /// </summary>
        private string LastName;
        /// <summary>
        /// string variable for storing passenger seat number
        /// </summary>
        private string SeatNum;

        /// <summary>
        /// public variable for Passenger ID: get = passengerID : set = passengerID
        /// </summary>
        public string getPassengerID
        {
            set
            {
                PassengerID = value;
            }
            get
            {
                return PassengerID;
            }
        }

        /// <summary>
        /// public variable for First Name: get = FirstName : set = FirstName
        /// </summary>
        public string getFirstName
        {
            set
            {
                FirstName = value;
            }
            get
            {
                return FirstName;
            }
        }

        /// <summary>
        /// public variable for last Name: get = LastName : set = LastName
        /// </summary>
        public string getLastName
        {
            set
            {
                LastName = value;
            }
            get
            {
                return LastName;
            }
        }

        /// <summary>
        /// public variable for Seat Number: get = SeatNum : set = SeatNum
        /// </summary>
        public string getSeatNum
        {
            set
            {
                SeatNum = value;
            }
            get
            {
                return SeatNum;
            }
        }

        /// <summary>
        /// Public override of the ToString()
        /// </summary>
        /// <returns>passengerID + FirstName + LastName</returns>
        public override string ToString()
        {
            return PassengerID + " - " + FirstName + " " + LastName;
        }
    }
}
