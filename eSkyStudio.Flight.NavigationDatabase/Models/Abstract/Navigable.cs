using System.ComponentModel.DataAnnotations.Schema;
using GeographicLib;
using UnitsNet;
using UnitsNet.Units;

namespace eSkyStudio.Flight.NavigationDatabase.Models.Abstract
{
    public abstract class Navigable : INavigable
    {
        [Column("area_code", TypeName = "TEXT(3)")]
        public string? AreaCode { get; set; }
        [Column("icao_code", TypeName = "TEXT(2)")]
        public string? IcaoRegion { get; set; }
        public abstract double Latitude { get; set;}
        public abstract double Longitude { get; set;}
        public abstract string Identifier { get; set; }
        public Coordonate GetCoordonate()
        {
            return new Coordonate(Latitude, Longitude);
        }

        public void SetCoordonate(Coordonate c1)
        {
            Latitude = c1.Latitude;
            Longitude = c1.Longitude;
        }

        public Navigable()
        {
        }

        public BearingDistance GetBDTo(INavigable point)
        {

            var result = Geodesic.WGS84.Inverse(Latitude, Longitude, point.Latitude, point.Longitude);
            return new BearingDistance()
            {
                BearingStart = new Angle(result.Azimuth1, AngleUnit.Degree),
                BearingEnd = new Angle(result.Azimuth2, AngleUnit.Degree),
                Distance = new Length(result.Distance, LengthUnit.Meter),
            };
        }
    }
}
