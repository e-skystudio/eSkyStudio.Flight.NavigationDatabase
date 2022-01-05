using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace NavigationDatabase.Models
{
    [Keyless]
    [Table("tbl_localizer_marker")]
    public partial class TblLocalizerMarker
    {
        [Column("area_code", TypeName = "TEXT(3)")]
        public string AreaCode { get; set; } = null!;
        [Column("icao_code", TypeName = "TEXT(2)")]
        public string IcaoCode { get; set; } = null!;
        [Column("airport_identifier", TypeName = "TEXT(4)")]
        public string AirportIdentifier { get; set; } = null!;
        [Column("runway_identifier", TypeName = "TEXT(5)")]
        public string RunwayIdentifier { get; set; } = null!;
        [Column("llz_identifier", TypeName = "TEXT(4)")]
        public string LlzIdentifier { get; set; } = null!;
        [Column("marker_identifier", TypeName = "TEXT(5)")]
        public string MarkerIdentifier { get; set; } = null!;
        [Column("marker_type", TypeName = "TEXT(3)")]
        public string MarkerType { get; set; } = null!;
        [Column("marker_latitude", TypeName = "DOUBLE(9)")]
        public double MarkerLatitude { get; set; }
        [Column("marker_longitude", TypeName = "DOUBLE(10)")]
        public double MarkerLongitude { get; set; }
    }
}
