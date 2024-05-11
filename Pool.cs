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

        public Pool(int count = 0, Temperature temp = null, Location location = null)
        {
            // to be implimented
            // - if temp is null, initialize new Temperature(double.NaN, "F")
            // - call this.toString()

            Pool.count++;
        }

        public new string ToString()
        {
            // to be implimented
            string myString = "The " + _location.ToString() + " has a " + _temp.ToString();
            return myString;
        }

        public double FindDistance(Location location)
        {
            // to be implimented
            // use this._location as reference

            double distance = 0;
            return (distance);
        }
        ~Pool() { }
    }
}
