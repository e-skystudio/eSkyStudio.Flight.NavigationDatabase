using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Globalization;
using Microsoft.EntityFrameworkCore;

namespace eSkyStudio.Flight.NavigationDatabase.Models
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
        public DateTime EffectiveFrom
        {
            get
            {
                int day = int.Parse(EffectiveFromto.Substring(0, 2));
                int month = int.Parse(EffectiveFromto.Substring(2, 2));
                int endMonth = int.Parse(EffectiveFromto.Substring(6, 2));
                int year = int.Parse("20" + EffectiveFromto.Substring(8, 2));
                if (endMonth == 1 && month == 12) year -= 1;
                return new DateTime(year, month, day, 00, 00, 00, Calendar.CurrentEra, DateTimeKind.Utc);;
            }
        }

        public DateTime EffectiveTo
        {
            get
            {
                int day = int.Parse(EffectiveFromto.Substring(4, 2));
                int month = int.Parse(EffectiveFromto.Substring(6, 2));
                int year = int.Parse("20" + EffectiveFromto.Substring(8, 2));
                return new DateTime(year, month, day, 23, 59, 59, Calendar.CurrentEra, DateTimeKind.Utc);
            }
        }

        public bool IsAiracValid(DateTime date)
        {
            return date >= EffectiveFrom && date <= EffectiveTo;
        }

        public bool IsAiracValid()
        {
            return IsAiracValid(DateTime.UtcNow);
        }
    }
}
