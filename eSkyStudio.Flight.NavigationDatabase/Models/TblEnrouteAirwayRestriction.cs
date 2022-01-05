using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace NavigationDatabase.Models
{
    [Keyless]
    [Table("tbl_enroute_airway_restriction")]
    public partial class TblEnrouteAirwayRestriction
    {
        [Column("area_code", TypeName = "TEXT(3)")]
        public string? AreaCode { get; set; }
        [Column("route_identifier", TypeName = "TEXT(5)")]
        public string? RouteIdentifier { get; set; }
        [Column("restriction_identifier", TypeName = "INTEGER(3)")]
        public long? RestrictionIdentifier { get; set; }
        [Column("restriction_type", TypeName = "TEXT(2)")]
        public string? RestrictionType { get; set; }
        [Column("start_waypoint_identifier", TypeName = "TEXT(5)")]
        public string? StartWaypointIdentifier { get; set; }
        [Column("start_waypoint_latitude", TypeName = "DOUBLE(9)")]
        public double? StartWaypointLatitude { get; set; }
        [Column("start_waypoint_longitude", TypeName = "DOUBLE(10)")]
        public double? StartWaypointLongitude { get; set; }
        [Column("end_waypoint_identifier", TypeName = "TEXT(5)")]
        public string? EndWaypointIdentifier { get; set; }
        [Column("end_waypoint_latitude", TypeName = "DOUBLE(9)")]
        public double? EndWaypointLatitude { get; set; }
        [Column("end_waypoint_longitude", TypeName = "DOUBLE(10)")]
        public double? EndWaypointLongitude { get; set; }
        [Column("start_date", TypeName = "TEXT(7)")]
        public string? StartDate { get; set; }
        [Column("end_date", TypeName = "TEXT(7)")]
        public string? EndDate { get; set; }
        [Column("units_of_altitude", TypeName = "TEXT(1)")]
        public string? UnitsOfAltitude { get; set; }
        [Column("restriction_altitude1", TypeName = "INTEGER(3)")]
        public long? RestrictionAltitude1 { get; set; }
        [Column("block_indicator1", TypeName = "TEXT(1)")]
        public string? BlockIndicator1 { get; set; }
        [Column("restriction_altitude2", TypeName = "INTEGER(3)")]
        public long? RestrictionAltitude2 { get; set; }
        [Column("block_indicator2", TypeName = "TEXT(1)")]
        public string? BlockIndicator2 { get; set; }
        [Column("restriction_altitude3", TypeName = "INTEGER(3)")]
        public long? RestrictionAltitude3 { get; set; }
        [Column("block_indicator3", TypeName = "TEXT(1)")]
        public string? BlockIndicator3 { get; set; }
        [Column("restriction_altitude4", TypeName = "INTEGER(3)")]
        public long? RestrictionAltitude4 { get; set; }
        [Column("block_indicator4", TypeName = "TEXT(1)")]
        public string? BlockIndicator4 { get; set; }
        [Column("restriction_altitude5", TypeName = "INTEGER(3)")]
        public long? RestrictionAltitude5 { get; set; }
        [Column("block_indicator5", TypeName = "TEXT(1)")]
        public string? BlockIndicator5 { get; set; }
        [Column("restriction_altitude6", TypeName = "INTEGER(3)")]
        public long? RestrictionAltitude6 { get; set; }
        [Column("block_indicator6", TypeName = "TEXT(1)")]
        public string? BlockIndicator6 { get; set; }
        [Column("restriction_altitude7", TypeName = "INTEGER(3)")]
        public long? RestrictionAltitude7 { get; set; }
        [Column("block_indicator7", TypeName = "TEXT(1)")]
        public string? BlockIndicator7 { get; set; }
        [Column("restriction_notes", TypeName = "TEXT(69)")]
        public string? RestrictionNotes { get; set; }
    }
}
