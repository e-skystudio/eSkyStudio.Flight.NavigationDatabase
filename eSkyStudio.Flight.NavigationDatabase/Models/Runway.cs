using System.ComponentModel.DataAnnotations.Schema;
using eSkyStudio.Flight.NavigationDatabase.Models.Abstract;
using Microsoft.EntityFrameworkCore;

namespace eSkyStudio.Flight.NavigationDatabase.Models
{
    [Keyless]
    [Table("tbl_runways")]
    public partial class Runway : Navigable
    {
        [Column("airport_identifier", TypeName = "TEXT(4)")]
        public string AirportIdentifier { get; set; } = null!;
        [Column("runway_identifier", TypeName = "TEXT(3)")]
        public string RunwayIdentifier { get; set; } = null!;
        [NotMapped]
        public override string Identifier {
            get => $"{AirportIdentifier}{RunwayIdentifier.Substring(2)}";
            set
            {
                AirportIdentifier = value.Substring(0, 4);
                RunwayIdentifier = $"RW{value.Substring(4)}";
            }
        }
        [Column("runway_latitude", TypeName = "DOUBLE(9)")]
        public override double Latitude { get; set; }
        [Column("runway_longitude", TypeName = "DOUBLE(10)")]
        public override double Longitude { get; set; }
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
        public string LlzIdentifier { get; set; }
        [Column("llz_mls_gls_category", TypeName = "TEXT(1)")]
        public string LlzMlsGlsCategory { get; set; }
        [Column("surface_code", TypeName = "INTEGER(3)")]
        public long? SurfaceCode { get; set; }
    }
}
