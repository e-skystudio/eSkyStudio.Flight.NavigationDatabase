using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using eSkyStudio.Flight.NavigationDatabase.Models.Abstract;
using Microsoft.EntityFrameworkCore;

namespace eSkyStudio.Flight.NavigationDatabase.Models
{
    [Keyless]
    [Table("tbl_gate")]
    public partial class Gate : Navigable
    {
        [Column("airport_identifier", TypeName = "TEXT(4)")]
        public string? AirportIdentifier { get; set; }
        [Column("gate_identifier", TypeName = "TEXT(5)")]
        public override string Identifier { get; set; } = null!;
        [Column("gate_latitude", TypeName = "DOUBLE(9)")]
        public override double Latitude { get; set; }
        [Column("gate_longitude", TypeName = "DOUBLE(10)")]
        public override double Longitude { get; set; }
        [Column("name", TypeName = "TEXT(25)")]
        public string? Name { get; set; }
    }
}
