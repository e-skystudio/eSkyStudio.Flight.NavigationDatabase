using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace eSkyStudio.Flight.NavigationDatabase.Models
{
    [Keyless]
    [Table("tbl_enroute_waypoints")]
    public partial class EnrouteWaypoint : Waypoint
    {
        [Column("waypoint_usage", TypeName = "TEXT(2)")]
        public string WaypointUsage { get; set; }
    }
}
