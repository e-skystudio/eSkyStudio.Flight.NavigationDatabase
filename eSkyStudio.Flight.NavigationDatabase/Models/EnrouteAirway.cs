using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace NavigationDatabase.Models
{
    [Keyless]
    [Table("tbl_enroute_airways")]
    public partial class EnrouteAirway
    {
        [Column("area_code", TypeName = "TEXT(3)")]
        public string? AreaCode { get; set; }
        [Column("route_identifier", TypeName = "TEXT(6)")]
        public string? RouteIdentifier { get; set; }
        [Column("seqno", TypeName = "INTEGER(4)")]
        public long? Seqno { get; set; }
        [Column("icao_code", TypeName = "TEXT(2)")]
        public string? IcaoCode { get; set; }
        [Column("waypoint_identifier", TypeName = "TEXT(5)")]
        public string? WaypointIdentifier { get; set; }
        [Column("waypoint_latitude", TypeName = "DOUBLE(9)")]
        public double? WaypointLatitude { get; set; }
        [Column("waypoint_longitude", TypeName = "DOUBLE(10)")]
        public double? WaypointLongitude { get; set; }
        [Column("waypoint_description_code", TypeName = "TEXT(4)")]
        public string? WaypointDescriptionCode { get; set; }
        [Column("route_type", TypeName = "TEXT(1)")]
        public string? RouteType { get; set; }
        [Column("flightlevel", TypeName = "TEXT(1)")]
        public string? Flightlevel { get; set; }
        [Column("direction_restriction", TypeName = "TEXT(1)")]
        public string? DirectionRestriction { get; set; }
        [Column("crusing_table_identifier", TypeName = "TEXT(2)")]
        public string? CrusingTableIdentifier { get; set; }
        [Column("minimum_altitude1", TypeName = "INTEGER(5)")]
        public long? MinimumAltitude1 { get; set; }
        [Column("minimum_altitude2", TypeName = "INTEGER(5)")]
        public long? MinimumAltitude2 { get; set; }
        [Column("maximum_altitude", TypeName = "INTEGER(5)")]
        public long? MaximumAltitude { get; set; }
        [Column("outbound_course", TypeName = "DOUBLE(5)")]
        public double? OutboundCourse { get; set; }
        [Column("inbound_course", TypeName = "DOUBLE(5)")]
        public double? InboundCourse { get; set; }
        [Column("inbound_distance", TypeName = "DOUBLE(5)")]
        public double? InboundDistance { get; set; }
    }
}
