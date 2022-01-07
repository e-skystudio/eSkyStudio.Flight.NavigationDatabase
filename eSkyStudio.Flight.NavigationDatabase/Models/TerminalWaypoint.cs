using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace eSkyStudio.Flight.NavigationDatabase.Models
{
    [Keyless]
    [Table("tbl_terminal_waypoints")]
    public partial class TerminalWaypoint : Waypoint
    {
        [Column("region_code", TypeName = "TEXT(4)")]
        public string? AirportIdentifier { get; set; }
    }
}
