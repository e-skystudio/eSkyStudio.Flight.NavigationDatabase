using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace NavigationDatabase.Models
{
    [Keyless]
    [Table("tbl_controlled_airspace")]
    public partial class TblControlledAirspace
    {
        [Column("area_code", TypeName = "TEXT(3)")]
        public string? AreaCode { get; set; }
        [Column("icao_code", TypeName = "TEXT(2)")]
        public string? IcaoCode { get; set; }
        [Column("airspace_center", TypeName = "TEXT(5)")]
        public string? AirspaceCenter { get; set; }
        [Column("controlled_airspace_name", TypeName = "TEXT(30)")]
        public string? ControlledAirspaceName { get; set; }
        [Column("airspace_type", TypeName = "TEXT(1)")]
        public string? AirspaceType { get; set; }
        [Column("airspace_classification", TypeName = "TEXT(1)")]
        public string? AirspaceClassification { get; set; }
        [Column("multiple_code", TypeName = "TEXT(1)")]
        public string? MultipleCode { get; set; }
        [Column("time_code", TypeName = "TEXT(1)")]
        public string? TimeCode { get; set; }
        [Column("seqno", TypeName = "INTEGER(3)")]
        public long? Seqno { get; set; }
        [Column("flightlevel", TypeName = "TEXT(1)")]
        public string? Flightlevel { get; set; }
        [Column("boundary_via", TypeName = "TEXT(2)")]
        public string? BoundaryVia { get; set; }
        [Column("latitude", TypeName = "DOUBLE(9)")]
        public double? Latitude { get; set; }
        [Column("longitude", TypeName = "DOUBLE(10)")]
        public double? Longitude { get; set; }
        [Column("arc_origin_latitude", TypeName = "DOUBLE(9)")]
        public double? ArcOriginLatitude { get; set; }
        [Column("arc_origin_longitude", TypeName = "DOUBLE(10)")]
        public double? ArcOriginLongitude { get; set; }
        [Column("arc_distance", TypeName = "DOUBLE(5)")]
        public double? ArcDistance { get; set; }
        [Column("arc_bearing", TypeName = "DOUBLE(5)")]
        public double? ArcBearing { get; set; }
        [Column("unit_indicator_lower_limit", TypeName = "TEXT(1)")]
        public string? UnitIndicatorLowerLimit { get; set; }
        [Column("lower_limit", TypeName = "TEXT(5)")]
        public string? LowerLimit { get; set; }
        [Column("unit_indicator_upper_limit", TypeName = "TEXT(1)")]
        public string? UnitIndicatorUpperLimit { get; set; }
        [Column("upper_limit", TypeName = "TEXT(5)")]
        public string? UpperLimit { get; set; }
    }
}
