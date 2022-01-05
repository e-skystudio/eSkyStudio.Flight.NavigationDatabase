using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using eSkyStudio.Flight.NavigationDatabase.Models.Abstract;
using Microsoft.EntityFrameworkCore;

namespace eSkyStudio.Flight.NavigationDatabase.Models
{
    [Keyless]
    [Table("tbl_localizer_marker")]
    public partial class LocalizerMarker : Navigable
    {
        [Column("airport_identifier", TypeName = "TEXT(4)")]
        public string AirportIdentifier { get; set; } = null!;
        [Column("runway_identifier", TypeName = "TEXT(5)")]
        public string RunwayIdentifier { get; set; } = null!;
        [Column("llz_identifier", TypeName = "TEXT(4)")]
        public string LlzIdentifier { get; set; } = null!;
        [Column("marker_identifier", TypeName = "TEXT(5)")]
        public string? Identifier { get; set; }
        [Column("marker_type", TypeName = "TEXT(3)")]
        public string MarkerType { get; set; } = null!;
        [Column("marker_latitude", TypeName = "DOUBLE(9)")]
        public override double Latitude { get; set; }
        [Column("marker_longitude", TypeName = "DOUBLE(10)")]
        public override double Longitude { get; set; }
    }
}
