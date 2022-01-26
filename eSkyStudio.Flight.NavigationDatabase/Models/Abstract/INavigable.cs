namespace eSkyStudio.Flight.NavigationDatabase.Models.Abstract
{
    public interface INavigable
    {
        public string AreaCode { get; set; }
        public string IcaoRegion { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public string Identifier { get; set; }
        public BearingDistance GetBDTo(INavigable point);
    }
}