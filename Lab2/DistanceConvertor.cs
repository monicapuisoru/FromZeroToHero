using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class DistanceConvertor
    {

        public double convertKmToMiles(double Km){
            return Km / 1609.0;
        }

        public double convertMilesToKm(double miles)
        {
            return miles * 1609.0;
        }
    }
}
