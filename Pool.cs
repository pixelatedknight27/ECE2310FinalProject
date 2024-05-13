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
            string myString = "pool at " + _location.ToString() + " with " + _temp.ToString();
            return myString;
        }

        public double FindDistance(Pool pool)
        {
            double distx = Convert.ToDouble(this._location.X - pool.Location.X);
            double disty = Convert.ToDouble(this._location.Y - pool.Location.X);
            double distance = Math.Sqrt(Math.Pow(distx, 2) + Math.Pow(disty, 2));
            return (distance);
        }

        ~Pool() { }
    }
}
