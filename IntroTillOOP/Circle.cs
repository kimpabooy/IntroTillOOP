using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace IntroTillOOP
{
    internal class Circle
    {
        private double _pi = Math.PI;
        private int _radius;

        public Circle(int radius)
        {
            _radius = radius;
        }
        public double GetArea() 
        {
            return _pi;
        }
        
    }
}
