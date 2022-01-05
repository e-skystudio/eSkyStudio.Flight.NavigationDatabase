using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace eSkyStudio.Flight.NavigationDatabase.Models
{
    [Keyless]
    [Table("tbl_gate")]
    public partial class Gate
    {
        [Column("area_code", TypeName = "TEXT(3)")]
        public string? AreaCode { get; set; }
        [Column("airport_identifier", TypeName = "TEXT(4)")]
        public string? AirportIdentifier { get; set; }
        [Column("icao_code", TypeName = "TEXT(2)")]
        public string? IcaoRegion { get; set; }
        [Column("gate_identifier", TypeName = "TEXT(5)")]
        public string? GateIdentifier { get; set; }
        [Column("gate_latitude", TypeName = "DOUBLE(9)")]
        public double? GateLatitude { get; set; }
        [Column("gate_longitude", TypeName = "DOUBLE(10)")]
        public double? GateLongitude { get; set; }
        [Column("name", TypeName = "TEXT(25)")]
        public string? Name { get; set; }
    }
}
