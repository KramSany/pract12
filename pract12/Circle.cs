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
        private double _radius1;
        private double _radius2;
        private double _midle;
        public double Midle { get { return _midle; } set { _midle = value; } }
        public double Radius1 { get { return _radius1; } set { _radius1 = value; } }

        public double Radius2 { get { return _radius2; } set { _radius2 = value; } }
        public CircleWithTwoRadius(double midle, double radius1, double radius2)
        {
            if (radius1 < radius2) throw new ArgumentException("First radius wasn't the biggest than second");
            _midle = midle;
            _radius1 = radius1;
            _radius2 = radius2;
        }
        public void AreaAllRinga(CircleWithTwoRadius circle2)
        {
            double[] ringa = new double[3];
            double ring1 = 3.14 * Radius1 * Radius1;
            double ring2 = 3.14 * circle2.Radius2 * circle2.Radius2;
            double ringGlobal = ring1 - ring2;
            ringa =  new[] { ring1, ring2, ringGlobal };
            MessageBox.Show($"S1 = {ring1}\n S2 = {ring2}\n S3 = {ringGlobal}");

            
        }
        public override string ToString()
        {
            return $"{Midle},{Radius1},{Radius2}";
        }
    }
}
// S1 = PI*(R1)^2 