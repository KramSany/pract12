using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace pract12
{
    class CircleWithTwoRadius
    {
        private double _radius;


        public double Radius { get { return _radius; } set { _radius = value; } }


        public CircleWithTwoRadius(double radius)
        {
            if (radius < 0) throw new ArgumentException("You are input value less 0");
            _radius = radius;
        }
        public string AreaAllRinga(CircleWithTwoRadius circle2)
        {
            if (_radius < circle2._radius) throw new ArgumentException("First radius was above second");
            double ring1 = 3.14 * Radius * Radius;
            double ring2 = 3.14 * circle2.Radius * circle2.Radius;
            double ringGlobal = ring1 - ring2;
            return ($"S1 = {ring1}\nS2 = {ring2}\nS3 = {ringGlobal}");


        }
        public override string ToString()
        {
            return $"{Radius}";
        }
    }
}
// S1 = PI*(R1)^2 