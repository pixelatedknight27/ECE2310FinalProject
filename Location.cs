using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Final
{
    internal class Location
    {
        private double? _x;
        public double? X { get { return _x; } set { _x = value; } }

        
        private double? _y;
        public double? Y { get { return _y; } set { _y = value; } }

        public Location(double? x = null, double? y = null)
        {
            _x = x;
            _y = y;
        }
        

        public new string ToString()
        {
            string myString = "location (" + _x + ", " + _y + ") in the xy grid";
            return (myString);
        }
        ~Location() { }
    }
}
