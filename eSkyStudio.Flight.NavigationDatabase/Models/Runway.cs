using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace NavigationDatabase.Models
{
    [Keyless]
    [Table("tbl_runways")]
    public partial class Runway
    {
        [Column("area_code", TypeName = "TEXT(3)")]
        public string? AreaCode { get; set; }
        [Column("icao_code", TypeName = "TEXT(2)")]
        public string? IcaoCode { get; set; }
        [Column("airport_identifier", TypeName = "TEXT(4)")]
        public string AirportIdentifier { get; set; } = null!;
        [Column("runway_identifier", TypeName = "TEXT(3)")]
        public string RunwayIdentifier { get; set; } = null!;
        [Column("runway_latitude", TypeName = "DOUBLE(9)")]
        public double? RunwayLatitude { get; set; }
        [Column("runway_longitude", TypeName = "DOUBLE(10)")]
        public double? RunwayLongitude { get; set; }
        [Column("runway_gradient", TypeName = "DOUBLE(5)")]
        public double? RunwayGradient { get; set; }
        [Column("runway_magnetic_bearing", TypeName = "DOUBLE(6)")]
        public double? RunwayMagneticBearing { get; set; }
        [Column("runway_true_bearing", TypeName = "DOUBLE(7)")]
        public double? RunwayTrueBearing { get; set; }
        [Column("landing_threshold_elevation", TypeName = "INTEGER(5)")]
        public long? LandingThresholdElevation { get; set; }
        [Column("displaced_threshold_distance", TypeName = "INTEGER(4)")]
        public long? DisplacedThresholdDistance { get; set; }
        [Column("threshold_crossing_height", TypeName = "INTEGER(2)")]
        public long? ThresholdCrossingHeight { get; set; }
        [Column("runway_length", TypeName = "INTEGER(5)")]
        public long? RunwayLength { get; set; }
        [Column("runway_width", TypeName = "INTEGER(3)")]
        public long? RunwayWidth { get; set; }
        [Column("llz_identifier", TypeName = "TEXT(4)")]
        public string? LlzIdentifier { get; set; }
        [Column("llz_mls_gls_category", TypeName = "TEXT(1)")]
        public string? LlzMlsGlsCategory { get; set; }
        [Column("surface_code", TypeName = "INTEGER(3)")]
        public long? SurfaceCode { get; set; }
    }
}
