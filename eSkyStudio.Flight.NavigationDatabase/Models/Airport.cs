using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using eSkyStudio.Flight.NavigationDatabase.Models.Abstract;
using Microsoft.EntityFrameworkCore;

namespace eSkyStudio.Flight.NavigationDatabase.Models
{
    [Keyless]
    [Table("tbl_airports")]
    public partial class Airport : Navigable
    {
        [Column("airport_identifier", TypeName = "TEXT(4)")]
        public string Identifier { get; set; } = null!;
        [Column("airport_identifier_3letter", TypeName = "TEXT(3)")]
        public string? AirportIdentifier3letter { get; set; }
        [Column("airport_name", TypeName = "TEXT(3)")]
        public string? AirportName { get; set; }
        [Column("airport_ref_latitude", TypeName = "DOUBLE(9)")]
        public override double Latitude { get; set; }
        [Column("airport_ref_longitude", TypeName = "DOUBLE(10)")]
        public override double Longitude { get; set; }
        [Column("ifr_capability", TypeName = "TEXT(1)")]
        public string? IfrCapability { get; set; }
        [Column("longest_runway_surface_code", TypeName = "TEXT(1)")]
        public string? LongestRunwaySurfaceCode { get; set; }
        [Column("elevation", TypeName = "INTEGER(5)")]
        public long? Elevation { get; set; }
        [Column("transition_altitude", TypeName = "INTEGER(5)")]
        public long? TransitionAltitude { get; set; }
        [Column("transition_level", TypeName = "INTEGER(5)")]
        public long? TransitionLevel { get; set; }
        [Column("speed_limit", TypeName = "INTEGER(3)")]
        public long? SpeedLimit { get; set; }
        [Column("speed_limit_altitude", TypeName = "INTEGER(5)")]
        public long? SpeedLimitAltitude { get; set; }
        [Column("iata_ata_designator", TypeName = "TEXT(3)")]
        public string? IataAtaDesignator { get; set; }
    }
}
