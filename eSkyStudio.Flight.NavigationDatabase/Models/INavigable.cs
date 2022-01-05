using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eSkyStudio.Flight.NavigationDatabase.Models
{
    public interface INavigable
    {
        public string? AreaCode { get; set; }
        public string? IcaoRegion { get; set; }
        public double? Latitude { get; set; }
        public double? Longitude { get; set; }
    }
}
