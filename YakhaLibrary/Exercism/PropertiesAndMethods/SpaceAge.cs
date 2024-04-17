using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YakhaLibrary.Exercism.PropertiesAndMethods
{
    public class SpaceAge
    {
        private double years;
        public SpaceAge(int seconds)
        {
            double minutes = seconds / 60.0d;
            double hours = minutes / 60.0d;
            double days = hours / 24.0d;
            years = days / 365.25d;
        }
        public double OnEarth() => years / 1.0d;

        public double OnMercury() => years / 0.2408467d;

        public double OnVenus() => years / 0.61519726d;

        public double OnMars() => years / 1.8808158d;

        public double OnJupiter() => years / 11.862615d;

        public double OnSaturn() => years / 29.447498d;

        public double OnUranus() => years / 84.016846d;

        public double OnNeptune() => years / 164.79132d;
    }
}
