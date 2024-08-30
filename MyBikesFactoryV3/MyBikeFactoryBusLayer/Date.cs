using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBikeFactoryBusLayer
{
    // Date class to represent a date with month, day, and year
    public class Date
    {
        // Private fields for month, day, and year
        private int month;
        private int day;
        private int year;


        //properties
        public int Month { get { return month; } set { month = value; } }
        public int Day { get { return day; } set { day = value; } }
        public int Year { get { return year; } set { year = value; } }


        //get/set methhods
        // Default constructor initializing the fields to 0
        public Date()
        {
            month = 0;
            day = 0;
            year = 0;
        }

        // Constructor with parameters to initialize the fields
        public Date(int month, int day, int year)
        {
            this.month = month;
            this.day = day;
            this.year = year;
        }

        // Method to get the date as a formatted string (MM/DD/YYYY)
        public string GetDateState()
        {
            string state;
            state = month + "/" + day + "/" + year;
            return state;
        }
    }
}
