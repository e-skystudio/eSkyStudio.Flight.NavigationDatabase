using System.ComponentModel.DataAnnotations.Schema;
using eSkyStudio.Flight.NavigationDatabase.Models.Abstract;
using Microsoft.EntityFrameworkCore;

namespace eSkyStudio.Flight.NavigationDatabase.Models
{
    [Keyless]
    [Table("tbl_vhfnavaids")]
    public partial class Vhfnavaid : Navigable
    {
        [Column("airport_identifier", TypeName = "TEXT(4)")]
        public string AirportIdentifier { get; set; }
        [Column("vor_identifier", TypeName = "TEXT(4)")]
        public override string Identifier { get; set; } = null!;
        [Column("vor_name", TypeName = "TEXT(30)")]
        public string VorName { get; set; }
        [Column("vor_frequency", TypeName = "DOUBLE(5)")]
        public double? VorFrequency { get; set; }
        [Column("navaid_class", TypeName = "TEXT(5)")]
        public string NavaidClass { get; set; }
        [Column("vor_latitude", TypeName = "DOUBLE(9)")]
        public override double Latitude { get; set; }
        [Column("vor_longitude", TypeName = "DOUBLE(10)")]
        public override double Longitude { get; set; }
        [Column("dme_ident", TypeName = "TEXT(4)")]
        public string DmeIdent { get; set; }
        [Column("dme_latitude", TypeName = "DOUBLE(9)")]
        public double? DmeLatitude { get; set; }
        [Column("dme_longitude", TypeName = "DOUBLE(10)")]
        public double? DmeLongitude { get; set; }
        [Column("dme_elevation", TypeName = "INTEGER(5)")]
        public long? DmeElevation { get; set; }
        [Column("ilsdme_bias", TypeName = "DOUBLE(3)")]
        public double? IlsdmeBias { get; set; }
        [Column("range", TypeName = "INTEGER(3)")]
        public long? Range { get; set; }
        [Column("station_declination", TypeName = "DOUBLE(5)")]
        public double? StationDeclination { get; set; }
        [Column("magnetic_variation", TypeName = "DOUBLE(5)")]
        public double? MagneticVariation { get; set; }
    }
}
