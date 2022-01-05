using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace NavigationDatabase.Models
{
    [Keyless]
    [Table("tbl_fir_uir")]
    public partial class TblFirUir
    {
        [Column("area_code", TypeName = "TEXT(3)")]
        public string? AreaCode { get; set; }
        [Column("fir_uir_identifier", TypeName = "TEXT(4)")]
        public string? FirUirIdentifier { get; set; }
        [Column("fir_uir_address", TypeName = "TEXT(4)")]
        public string? FirUirAddress { get; set; }
        [Column("fir_uir_name", TypeName = "TEXT(25)")]
        public string? FirUirName { get; set; }
        [Column("fir_uir_indicator", TypeName = "TEXT(1)")]
        public string? FirUirIndicator { get; set; }
        [Column("seqno", TypeName = "INTEGER(3)")]
        public long? Seqno { get; set; }
        [Column("boundary_via", TypeName = "TEXT(2)")]
        public string? BoundaryVia { get; set; }
        [Column("adjacent_fir_identifier", TypeName = "TEXT(4)")]
        public string? AdjacentFirIdentifier { get; set; }
        [Column("adjacent_uir_identifier", TypeName = "TEXT(4)")]
        public string? AdjacentUirIdentifier { get; set; }
        [Column("reporting_units_speed", TypeName = "INTEGER(1)")]
        public long? ReportingUnitsSpeed { get; set; }
        [Column("reporting_units_altitude", TypeName = "INTEGER(1)")]
        public long? ReportingUnitsAltitude { get; set; }
        [Column("fir_uir_latitude", TypeName = "DOUBLE(9)")]
        public double? FirUirLatitude { get; set; }
        [Column("fir_uir_longitude", TypeName = "DOUBLE(10)")]
        public double? FirUirLongitude { get; set; }
        [Column("arc_origin_latitude", TypeName = "DOUBLE(9)")]
        public double? ArcOriginLatitude { get; set; }
        [Column("arc_origin_longitude", TypeName = "DOUBLE(10)")]
        public double? ArcOriginLongitude { get; set; }
        [Column("arc_distance", TypeName = "DOUBLE(5)")]
        public double? ArcDistance { get; set; }
        [Column("arc_bearing", TypeName = "DOUBLE(5)")]
        public double? ArcBearing { get; set; }
        [Column("fir_upper_limit", TypeName = "TEXT(5)")]
        public string? FirUpperLimit { get; set; }
        [Column("uir_lower_limit", TypeName = "TEXT(5)")]
        public string? UirLowerLimit { get; set; }
        [Column("uir_upper_limit", TypeName = "TEXT(5)")]
        public string? UirUpperLimit { get; set; }
        [Column("cruise_table_identifier", TypeName = "TEXT(2)")]
        public string? CruiseTableIdentifier { get; set; }
    }
}
