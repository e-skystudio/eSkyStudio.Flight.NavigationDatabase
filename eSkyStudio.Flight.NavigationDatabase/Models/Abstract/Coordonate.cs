using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitsNet;
using UnitsNet.Units;

namespace eSkyStudio.Flight.NavigationDatabase.Models.Abstract
{
    public class Coordonate
    {
        public static double DegreeToRadian(double deg)
        {
            return (Math.PI / 180) * deg;
        }
        public static double RadianToDegree(double radians)
        {
            return (180 / Math.PI) * radians;
        }
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

        public Angle GetBearing(Coordonate p2)
        {
            GeographicLib.Geodesic.WGS84.Inverse(Latitude, Longitude, p2.Latitude, p2.Longitude, out double azi1, out double azi2);
            return new Angle(azi1, AngleUnit.Degree);
        }

        public Angle GetBearing2(Coordonate p2)
        {
            GeographicLib.Geodesic.WGS84.Inverse(Latitude, Longitude, p2.Latitude, p2.Longitude, out double azi1, out double azi2);
            return new Angle(azi2, AngleUnit.Degree);
        }

        public Length GetDistance(Coordonate p2)
        {
            GeographicLib.Geodesic.WGS84.Inverse(Latitude, Longitude, p2.Latitude, p2.Longitude, out double distance ,out double azi1, out double azi2);
            return new Length(distance, LengthUnit.Meter);
        }

        public Coordonate PlaceBearingDistance(double bearing, double distance)
        {
            GeographicLib.Geodesic.WGS84.Direct(Latitude, Longitude, bearing, distance, out double lat, out double lon);
            return new Coordonate(lat, lon);
        }

        public Coordonate PlaceBearingDistance(double bearing, Length distance)
        {
            GeographicLib.Geodesic.WGS84.Direct(Latitude, Longitude, bearing, distance.Meters, out double lat, out double lon);
            return new Coordonate(lat, lon);
        }

        public override string ToString()
        {
            return $"{Latitude.ToString("00.0000", CultureInfo.InvariantCulture)}°N, {Longitude.ToString("000.0000", CultureInfo.InvariantCulture)}°E";
        }
    }
}
