using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace eSkyStudio.Flight.NavigationDatabase.Models
{
    [Keyless]
    [Table("tbl_airport_msa")]
    public partial class AirportMsa
    {
        [Column("area_code", TypeName = "TEXT(3)")]
        public string? AreaCode { get; set; }
        [Column("icao_code", TypeName = "TEXT(2)")]
        public string? IcaoRegion { get; set; }
        [Column("airport_identifier", TypeName = "TEXT(4)")]
        public string? AirportIdentifier { get; set; }
        [Column("msa_center", TypeName = "TEXT(5)")]
        public string? MsaCenter { get; set; }
        [Column("msa_center_latitude", TypeName = "DOUBLE(9)")]
        public double? MsaCenterLatitude { get; set; }
        [Column("msa_center_longitude", TypeName = "DOUBLE(10)")]
        public double? MsaCenterLongitude { get; set; }
        [Column("magnetic_true_indicator", TypeName = "TEXT(1)")]
        public string? MagneticTrueIndicator { get; set; }
        [Column("multiple_code", TypeName = "TEXT(1)")]
        public string? MultipleCode { get; set; }
        [Column("radius_limit", TypeName = "INTEGER(2)")]
        public long? RadiusLimit { get; set; }
        [Column("sector_bearing_1", TypeName = "INTEGER(3)")]
        public long? SectorBearing1 { get; set; }
        [Column("sector_altitude_1", TypeName = "INTEGER(3)")]
        public long? SectorAltitude1 { get; set; }
        [Column("sector_bearing_2", TypeName = "INTEGER(3)")]
        public long? SectorBearing2 { get; set; }
        [Column("sector_altitude_2", TypeName = "INTEGER(3)")]
        public long? SectorAltitude2 { get; set; }
        [Column("sector_bearing_3", TypeName = "INTEGER(3)")]
        public long? SectorBearing3 { get; set; }
        [Column("sector_altitude_3", TypeName = "INTEGER(3)")]
        public long? SectorAltitude3 { get; set; }
        [Column("sector_bearing_4", TypeName = "INTEGER(3)")]
        public long? SectorBearing4 { get; set; }
        [Column("sector_altitude_4", TypeName = "INTEGER(3)")]
        public long? SectorAltitude4 { get; set; }
        [Column("sector_bearing_5", TypeName = "INTEGER(3)")]
        public long? SectorBearing5 { get; set; }
        [Column("sector_altitude_5", TypeName = "INTEGER(3)")]
        public long? SectorAltitude5 { get; set; }
    }
}
