using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using eSkyStudio.Flight.NavigationDatabase.Models.Abstract;
using Microsoft.EntityFrameworkCore;

namespace eSkyStudio.Flight.NavigationDatabase.Models
{
    [Keyless]
    [Table("tbl_enroute_ndbnavaids")]
    public partial class EnrouteNdbnavaid : Navigable
    {
        [Column("ndb_identifier", TypeName = "TEXT(4)")]
        public override string Identifier { get; set; } = null!;
        [Column("ndb_name", TypeName = "TEXT(30)")]
        public string? NdbName { get; set; }
        [Column("ndb_frequency", TypeName = "DOUBLE(5)")]
        public double? NdbFrequency { get; set; }
        [Column("navaid_class", TypeName = "TEXT(5)")]
        public string? NavaidClass { get; set; }
        [Column("ndb_latitude", TypeName = "DOUBLE(9)")]
        public override double Latitude { get; set; }
        [Column("ndb_longitude", TypeName = "DOUBLE(10)")]
        public override double Longitude { get; set; }
        [Column("range", TypeName = "INTEGER(3)")]
        public long? Range { get; set; }
    }
}
