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
        private int _x;
        public int X { get { return _x; } set { _x = value; } }

        
        private int _y;
        public int Y { get { return _y; } set { _y = value; } }

        public Location(int x = 0, int y = 0)
        {
            _x = x;
            _y = y;
        }
        

        public new string ToString()
        {
            // to be implimented
            // format example:
            // "(5, 20)"

            string myString = "pool location at (" + _x + ", " + _y + ") in the xy grid";

            return (myString);
        }
        ~Location() { }
    }
}
