using eSkyStudio.Flight.NavigationDatabase.Models.Abstract;
using System.ComponentModel.DataAnnotations.Schema;

namespace eSkyStudio.Flight.NavigationDatabase.Models
{
    public class Waypoint : Navigable
    {
        [Column("waypoint_identifier", TypeName = "TEXT(5)")]
        public override string Identifier { get; set; } = null!;
        [Column("waypoint_name", TypeName = "TEXT(25)")]
        public string? WaypointName { get; set; }
        [Column("waypoint_type", TypeName = "TEXT(3)")]
        public string? WaypointType { get; set; }
        [Column("waypoint_latitude", TypeName = "DOUBLE(9)")]
        public override double Latitude { get; set; }
        [Column("waypoint_longitude", TypeName = "DOUBLE(10)")]
        public override double Longitude { get; set; }
    }
}
