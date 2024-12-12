using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reisedauer
{
    public class Mondreise
    {
        double speedKmh;
        double weg = 384400;
        double zeit;

        public double SpeedKmh
        {
            get { return speedKmh; }
            
        }
        public double Weg
        {
            get { return weg; }
        }
        public double Zeit
        {
            get { return zeit; }
        }

        public Mondreise(double speed)
        {
            speedKmh = speed;
        }

        public double GetTravelDurationDays(double speedKmh, double weg, double zeit)
        {
            zeit = weg / speedKmh /24;
            return zeit;
        }
        public double GetTravelDurationHours(double speedKmh, double weg, double zeit)
        {
            zeit = weg/speedKmh;
            return zeit;
        }

    }
}
