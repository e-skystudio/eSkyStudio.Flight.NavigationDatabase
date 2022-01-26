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

        public override string ToString()
        {
            return $"{Latitude:00.0000}°N, {Longitude:000.00000}";
        }
    }
}
