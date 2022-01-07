using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eSkyStudio.Flight.NavigationDatabase.Models.Abstract;
public interface INavigable
{
    public string? AreaCode { get; set; }
    public string? IcaoRegion { get; set; }
    public double Latitude { get; set; }
    public double Longitude { get; set; }
    public string Identifier { get; set; }
    public BearingDistance GetBDTo(INavigable point);
}