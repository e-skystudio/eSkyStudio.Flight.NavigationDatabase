using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace eSkyStudio.Flight.NavigationDatabase.Models
{
    [Keyless]
    [Table("tbl_restrictive_airspace")]
    public partial class RestrictiveAirspace
    {
        [Column("area_code", TypeName = "TEXT(3)")]
        public string AreaCode { get; set; }
        [Column("icao_code", TypeName = "TEXT(2)")]
        public string IcaoRegion { get; set; }
        [Column("restrictive_airspace_designation", TypeName = "TEXT(10)")]
        public string RestrictiveAirspaceDesignation { get; set; }
        [Column("restrictive_airspace_name", TypeName = "TEXT(30)")]
        public string RestrictiveAirspaceName { get; set; }
        [Column("restrictive_type", TypeName = "TEXT(1)")]
        public string RestrictiveType { get; set; }
        [Column("multiple_code", TypeName = "TEXT(1)")]
        public string MultipleCode { get; set; }
        [Column("seqno", TypeName = "INTEGER(3)")]
        public long? Seqno { get; set; }
        [Column("boundary_via", TypeName = "TEXT(2)")]
        public string BoundaryVia { get; set; }
        [Column("flightlevel", TypeName = "TEXT(1)")]
        public string Flightlevel { get; set; }
        [Column("latitude", TypeName = "DOUBLE(9)")]
        public double Latitude { get; set; }
        [Column("longitude", TypeName = "DOUBLE(10)")]
        public double Longitude { get; set; }
        [Column("arc_origin_latitude", TypeName = "DOUBLE(9)")]
        public double? ArcOriginLatitude { get; set; }
        [Column("arc_origin_longitude", TypeName = "DOUBLE(10)")]
        public double? ArcOriginLongitude { get; set; }
        [Column("arc_distance", TypeName = "DOUBLE(5)")]
        public double? ArcDistance { get; set; }
        [Column("arc_bearing", TypeName = "DOUBLE(5)")]
        public double? ArcBearing { get; set; }
        [Column("unit_indicator_lower_limit", TypeName = "TEXT(1)")]
        public string UnitIndicatorLowerLimit { get; set; }
        [Column("lower_limit", TypeName = "TEXT(5)")]
        public string LowerLimit { get; set; }
        [Column("unit_indicator_upper_limit", TypeName = "TEXT(1)")]
        public string UnitIndicatorUpperLimit { get; set; }
        [Column("upper_limit", TypeName = "TEXT(5)")]
        public string UpperLimit { get; set; }
    }
}
