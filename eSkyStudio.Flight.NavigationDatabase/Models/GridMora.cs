using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace NavigationDatabase.Models
{
    [Keyless]
    [Table("tbl_grid_mora")]
    public partial class GridMora
    {
        [Column("starting_latitude", TypeName = "INTEGER(3)")]
        public long? StartingLatitude { get; set; }
        [Column("starting_longitude", TypeName = "INTEGER(4)")]
        public long? StartingLongitude { get; set; }
        [Column("mora01", TypeName = "TEXT(3)")]
        public string? Mora01 { get; set; }
        [Column("mora02", TypeName = "TEXT(3)")]
        public string? Mora02 { get; set; }
        [Column("mora03", TypeName = "TEXT(3)")]
        public string? Mora03 { get; set; }
        [Column("mora04", TypeName = "TEXT(3)")]
        public string? Mora04 { get; set; }
        [Column("mora05", TypeName = "TEXT(3)")]
        public string? Mora05 { get; set; }
        [Column("mora06", TypeName = "TEXT(3)")]
        public string? Mora06 { get; set; }
        [Column("mora07", TypeName = "TEXT(3)")]
        public string? Mora07 { get; set; }
        [Column("mora08", TypeName = "TEXT(3)")]
        public string? Mora08 { get; set; }
        [Column("mora09", TypeName = "TEXT(3)")]
        public string? Mora09 { get; set; }
        [Column("mora10", TypeName = "TEXT(3)")]
        public string? Mora10 { get; set; }
        [Column("mora11", TypeName = "TEXT(3)")]
        public string? Mora11 { get; set; }
        [Column("mora12", TypeName = "TEXT(3)")]
        public string? Mora12 { get; set; }
        [Column("mora13", TypeName = "TEXT(3)")]
        public string? Mora13 { get; set; }
        [Column("mora14", TypeName = "TEXT(3)")]
        public string? Mora14 { get; set; }
        [Column("mora15", TypeName = "TEXT(3)")]
        public string? Mora15 { get; set; }
        [Column("mora16", TypeName = "TEXT(3)")]
        public string? Mora16 { get; set; }
        [Column("mora17", TypeName = "TEXT(3)")]
        public string? Mora17 { get; set; }
        [Column("mora18", TypeName = "TEXT(3)")]
        public string? Mora18 { get; set; }
        [Column("mora19", TypeName = "TEXT(3)")]
        public string? Mora19 { get; set; }
        [Column("mora20", TypeName = "TEXT(3)")]
        public string? Mora20 { get; set; }
        [Column("mora21", TypeName = "TEXT(3)")]
        public string? Mora21 { get; set; }
        [Column("mora22", TypeName = "TEXT(3)")]
        public string? Mora22 { get; set; }
        [Column("mora23", TypeName = "TEXT(3)")]
        public string? Mora23 { get; set; }
        [Column("mora24", TypeName = "TEXT(3)")]
        public string? Mora24 { get; set; }
        [Column("mora25", TypeName = "TEXT(3)")]
        public string? Mora25 { get; set; }
        [Column("mora26", TypeName = "TEXT(3)")]
        public string? Mora26 { get; set; }
        [Column("mora27", TypeName = "TEXT(3)")]
        public string? Mora27 { get; set; }
        [Column("mora28", TypeName = "TEXT(3)")]
        public string? Mora28 { get; set; }
        [Column("mora29", TypeName = "TEXT(3)")]
        public string? Mora29 { get; set; }
        [Column("mora30", TypeName = "TEXT(3)")]
        public string? Mora30 { get; set; }
    }
}
