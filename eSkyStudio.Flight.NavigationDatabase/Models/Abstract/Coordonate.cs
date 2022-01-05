using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eSkyStudio.Flight.NavigationDatabase.Models.Abstract
{
    public class Coordonate
    {
        public double Latitude { get; set; }
        public double Longitude { get; set; }

        public Coordonate()
        {
            Latitude = double.NaN;
            Longitude = double.NaN;
        }

        public Coordonate(double lat, double lon)
        {
            Latitude = lat;
            Longitude = lon;
        }
    }
}
