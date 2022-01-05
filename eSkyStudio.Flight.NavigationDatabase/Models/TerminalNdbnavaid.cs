using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace NavigationDatabase.Models
{
    [Keyless]
    [Table("tbl_terminal_ndbnavaids")]
    public partial class TerminalNdbnavaid
    {
        [Column("area_code", TypeName = "TEXT(3)")]
        public string? AreaCode { get; set; }
        [Column("airport_identifier", TypeName = "TEXT(4)")]
        public string AirportIdentifier { get; set; } = null!;
        [Column("icao_code", TypeName = "TEXT(2)")]
        public string IcaoCode { get; set; } = null!;
        [Column("ndb_identifier", TypeName = "TEXT(4)")]
        public string NdbIdentifier { get; set; } = null!;
        [Column("ndb_name", TypeName = "TEXT(30)")]
        public string? NdbName { get; set; }
        [Column("ndb_frequency", TypeName = "DOUBLE(5)")]
        public double? NdbFrequency { get; set; }
        [Column("navaid_class", TypeName = "TEXT(5)")]
        public string? NavaidClass { get; set; }
        [Column("ndb_latitude", TypeName = "DOUBLE(9)")]
        public double? NdbLatitude { get; set; }
        [Column("ndb_longitude", TypeName = "DOUBLE(10)")]
        public double? NdbLongitude { get; set; }
        [Column("range", TypeName = "INTEGER(3)")]
        public long? Range { get; set; }
    }
}
