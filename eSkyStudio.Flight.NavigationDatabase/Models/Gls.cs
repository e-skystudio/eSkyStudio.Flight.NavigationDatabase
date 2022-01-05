using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace eSkyStudio.Flight.NavigationDatabase.Models
{
    [Keyless]
    [Table("tbl_gls")]
    public partial class Gls
    {
        [Column("area_code", TypeName = "TEXT(3)")]
        public string? AreaCode { get; set; }
        [Column("airport_identifier", TypeName = "TEXT(4)")]
        public string? AirportIdentifier { get; set; }
        [Column("icao_code", TypeName = "TEXT(2)")]
        public string? IcaoRegion { get; set; }
        [Column("gls_ref_path_identifier", TypeName = "TEXT(4)")]
        public string? GlsRefPathIdentifier { get; set; }
        [Column("gls_category", TypeName = "TEXT(1)")]
        public string? GlsCategory { get; set; }
        [Column("gls_channel", TypeName = "INTEGER(5)")]
        public long? GlsChannel { get; set; }
        [Column("runway_identifier", TypeName = "TEXT(5)")]
        public string? RunwayIdentifier { get; set; }
        [Column("gls_approach_bearing", TypeName = "DOUBLE(5)")]
        public double? GlsApproachBearing { get; set; }
        [Column("station_latitude", TypeName = "DOUBLE(9)")]
        public double? StationLatitude { get; set; }
        [Column("station_longitude", TypeName = "DOUBLE(10)")]
        public double? StationLongitude { get; set; }
        [Column("gls_station_ident", TypeName = "TEXT(4)")]
        public string? GlsStationIdent { get; set; }
        [Column("gls_approach_slope", TypeName = "DOUBLE(4)")]
        public double? GlsApproachSlope { get; set; }
        [Column("magentic_variation", TypeName = "DOUBLE(6)")]
        public double? MagenticVariation { get; set; }
        [Column("station_elevation", TypeName = "INTEGER(5)")]
        public long? StationElevation { get; set; }
        [Column("station_type", TypeName = "TEXT(3)")]
        public string? StationType { get; set; }
    }
}
