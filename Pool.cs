using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final
{
    internal class Pool
    {
        private Temperature _temp;
        public Temperature Temp { get { return _temp; } set { _temp = value; } }


        private Location _location;
        public Location Location { get { return _location; } set { _location = value; } }


        public static int count = 0;

        public Pool(Temperature temp = null, Location location = null)
        {
            _temp = temp ?? new Temperature(double.NaN, "F");
            _location = location ?? new Location();
            Console.WriteLine("initialized " + this.ToString()); 
            Pool.count++;
        }

        public new string ToString()
        {

            // format example:
            // "pool at location (2, 7) at temperature 23 °F"
            // call this._location.toString and this._temp.toString

            string myString = "pool at " + _location.ToString() + " with " + _temp.ToString();
            return myString;
        }

        public double FindDistance(Pool pool)
        {
            // to be implimented
            // use this._location as reference

            double distance = 0;
            return (distance);
        }

        ~Pool() { }
    }
}
