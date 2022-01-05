using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace NavigationDatabase.Models
{
    [Keyless]
    [Table("tbl_localizers_glideslopes")]
    public partial class TblLocalizersGlideslope
    {
        [Column("area_code", TypeName = "TEXT(3)")]
        public string? AreaCode { get; set; }
        [Column("icao_code", TypeName = "TEXT(2)")]
        public string? IcaoCode { get; set; }
        [Column("airport_identifier", TypeName = "TEXT(4)")]
        public string AirportIdentifier { get; set; } = null!;
        [Column("runway_identifier", TypeName = "TEXT(3)")]
        public string? RunwayIdentifier { get; set; }
        [Column("llz_identifier", TypeName = "TEXT(4)")]
        public string LlzIdentifier { get; set; } = null!;
        [Column("llz_latitude", TypeName = "DOUBLE(9)")]
        public double? LlzLatitude { get; set; }
        [Column("llz_longitude", TypeName = "DOUBLE(10)")]
        public double? LlzLongitude { get; set; }
        [Column("llz_frequency", TypeName = "DOUBLE(6)")]
        public double? LlzFrequency { get; set; }
        [Column("llz_bearing", TypeName = "DOUBLE(6)")]
        public double? LlzBearing { get; set; }
        [Column("llz_width", TypeName = "DOUBLE(6)")]
        public double? LlzWidth { get; set; }
        [Column("ils_mls_gls_category", TypeName = "TEXT(1)")]
        public string? IlsMlsGlsCategory { get; set; }
        [Column("gs_latitude", TypeName = "DOUBLE(9)")]
        public double? GsLatitude { get; set; }
        [Column("gs_longitude", TypeName = "DOUBLE(10)")]
        public double? GsLongitude { get; set; }
        [Column("gs_angle", TypeName = "DOUBLE(4)")]
        public double? GsAngle { get; set; }
        [Column("gs_elevation", TypeName = "INTEGER(5)")]
        public long? GsElevation { get; set; }
        [Column("station_declination", TypeName = "DOUBLE(5)")]
        public double? StationDeclination { get; set; }
    }
}
