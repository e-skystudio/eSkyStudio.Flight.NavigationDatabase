using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace eSkyStudio.Flight.NavigationDatabase.Models
{
    [Keyless]
    [Table("tbl_terminal_waypoints")]
    public partial class TerminalWaypoint :EnrouteWaypoint, INavigable
    {
        [Column("region_code", TypeName = "TEXT(4)")]
        public string? AirportIdentifier { get; set; }
    }
}
