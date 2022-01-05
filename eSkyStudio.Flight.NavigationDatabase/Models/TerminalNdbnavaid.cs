using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace eSkyStudio.Flight.NavigationDatabase.Models
{
    [Keyless]
    [Table("tbl_terminal_ndbnavaids")]
    public partial class TerminalNdbnavaid : EnrouteNdbnavaid, INavigable
    {
        [Column("airport_identifier", TypeName = "TEXT(4)")]
        public string AirportIdentifier { get; set; } = null!;
        [Column("icao_code", TypeName = "TEXT(2)")]
    }
}
