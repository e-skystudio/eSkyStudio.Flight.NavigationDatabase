using UnitsNet;

namespace eSkyStudio.Flight.NavigationDatabase.Models.Abstract
{
    public struct BearingDistance
    {
        public Length Distance { get; set; }
        public Angle BearingStart { get; set; }
        public Angle BearingEnd { get; set; }

    }
}
