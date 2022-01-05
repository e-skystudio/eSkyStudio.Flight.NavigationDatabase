using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace NavigationDatabase.Models
{
    [Keyless]
    [Table("tbl_header")]
    public partial class Header
    {
        [Column("version", TypeName = "TEXT(5)")]
        public string Version { get; set; } = null!;
        [Column("arincversion", TypeName = "TEXT(6)")]
        public string Arincversion { get; set; } = null!;
        [Column("record_set", TypeName = "TEXT(8)")]
        public string RecordSet { get; set; } = null!;
        [Column("current_airac", TypeName = "TEXT(4)")]
        public string CurrentAirac { get; set; } = null!;
        [Column("revision", TypeName = "TEXT(3)")]
        public string Revision { get; set; } = null!;
        [Column("effective_fromto", TypeName = "TEXT(10)")]
        public string EffectiveFromto { get; set; } = null!;
        [Column("previous_airac", TypeName = "TEXT(4)")]
        public string PreviousAirac { get; set; } = null!;
        [Column("previous_fromto", TypeName = "TEXT(10)")]
        public string PreviousFromto { get; set; } = null!;
        [Column("parsed_at", TypeName = "TEXT(22)")]
        public string ParsedAt { get; set; } = null!;
    }
}
