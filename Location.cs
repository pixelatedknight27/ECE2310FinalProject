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


        public Location()
        {
            _x = 0;
            _y = 0;
        }
        public Location(int x, int y)
        {
            _x = x;
            _y = y;
        }

        public double FindDistance(int x1, int y1, int x2, int y2)
        {
            double d = (y2 - y1) / (x2 - x1);
            return d;
        }

        public new string ToString()
        {
            // to be implimented
            string myString = "Pool" + //name?/letter?
                                     "is located at" + "("+_x+","+_y+")");
            return (myString);
        }
    }
}
