using System;

namespace IntroTillOOP
{
    internal class Circle
    {
        private int _radius;

        public Circle(int radius)
        {
            _radius = radius;
        }
        public double GetArea() 
        {
            return Math.PI * Math.Pow(_radius, 2); // Arean Cirkel = π * r^2
        }
        public double Circumference()
        {
            return 2 * Math.PI * _radius; // Omkrets Cirkel = 2π * r
        }
        public double Volumme()
        {
            return (4 * Math.PI) * (Math.Pow(_radius, 3)) / 3; // Volym sfär = 4π * r^3 / 3
        }
    }
}
