using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace NavigationDatabase.Models
{
    [Keyless]
    [Table("tbl_vhfnavaids")]
    public partial class TblVhfnavaid
    {
        [Column("area_code", TypeName = "TEXT(3)")]
        public string? AreaCode { get; set; }
        [Column("airport_identifier", TypeName = "TEXT(4)")]
        public string? AirportIdentifier { get; set; }
        [Column("icao_code", TypeName = "TEXT(2)")]
        public string IcaoCode { get; set; } = null!;
        [Column("vor_identifier", TypeName = "TEXT(4)")]
        public string VorIdentifier { get; set; } = null!;
        [Column("vor_name", TypeName = "TEXT(30)")]
        public string? VorName { get; set; }
        [Column("vor_frequency", TypeName = "DOUBLE(5)")]
        public double? VorFrequency { get; set; }
        [Column("navaid_class", TypeName = "TEXT(5)")]
        public string? NavaidClass { get; set; }
        [Column("vor_latitude", TypeName = "DOUBLE(9)")]
        public double? VorLatitude { get; set; }
        [Column("vor_longitude", TypeName = "DOUBLE(10)")]
        public double? VorLongitude { get; set; }
        [Column("dme_ident", TypeName = "TEXT(4)")]
        public string? DmeIdent { get; set; }
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
