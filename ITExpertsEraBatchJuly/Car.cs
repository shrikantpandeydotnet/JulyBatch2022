using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITExpertsEraBatchJuly
{
    public class Car
    {
        private string _carType ; // class level variable.

        private int _noOfSeats;

        private string _carName = "Honda Civic";

        // property syntax
        public string CarType
        {
            get
            {
                return _carType;
            }
            set
            {
                _carType = value;
            }
        }

        // write only.. not recommended to use.
        public int NoofSeats2
        {
            set
            {
                _noOfSeats = value;
            }
        }

        public int NoofSeats
        {
            get
            {
                return _noOfSeats;
            }
            set
            {
                _noOfSeats = value;
            }
        }

        // Read only propety
        public string CarName
        {
            get
            {
                return _carName;
            }
        }

        // Automated Property // Newer way of creating property.
        public string Color { get; set; } = "Blue"; // to initialise readonly property.

        // Readonly property. value can be set in the constructor. 
        public int TestProperty { get; } = 100;


    }
}
