using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using eSkyStudio.Flight.NavigationDatabase.Models.Abstract;
using Microsoft.EntityFrameworkCore;

namespace eSkyStudio.Flight.NavigationDatabase.Models
{
    [Keyless]
    [Table("tbl_holdings")]
    public partial class Holding : Navigable
    {
        [Column("region_code", TypeName = "TEXT(4)")]
        public string? RegionCode { get; set; }
        [Column("waypoint_identifier", TypeName = "TEXT(5)")]
        public string? Identifier { get; set; }
        [Column("holding_name", TypeName = "TEXT(25)")]
        public string? HoldingName { get; set; }
        [Column("waypoint_latitude", TypeName = "DOUBLE(9)")]
        public override double Latitude { get; set; }
        [Column("waypoint_longitude", TypeName = "DOUBLE(10)")]
        public override double Longitude { get; set; }
        [Column("duplicate_identifier", TypeName = "INTEGER(2)")]
        public long? DuplicateIdentifier { get; set; }
        [Column("inbound_holding_course", TypeName = "DOUBLE(5)")]
        public double? InboundHoldingCourse { get; set; }
        [Column("turn_direction", TypeName = "TEXT(1)")]
        public string? TurnDirection { get; set; }
        [Column("leg_length", TypeName = "DOUBLE(4)")]
        public double? LegLength { get; set; }
        [Column("leg_time", TypeName = "DOUBLE(3)")]
        public double? LegTime { get; set; }
        [Column("minimum_altitude", TypeName = "INTEGER(5)")]
        public long? MinimumAltitude { get; set; }
        [Column("maximum_altitude", TypeName = "INTEGER(5)")]
        public long? MaximumAltitude { get; set; }
        [Column("holding_speed", TypeName = "INTEGER(3)")]
        public long? HoldingSpeed { get; set; }
    }
}
