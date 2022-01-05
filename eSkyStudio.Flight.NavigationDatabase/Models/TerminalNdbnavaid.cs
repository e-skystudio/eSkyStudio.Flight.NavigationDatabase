using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using eSkyStudio.Flight.NavigationDatabase.Models.Abstract;
using Microsoft.EntityFrameworkCore;

namespace eSkyStudio.Flight.NavigationDatabase.Models
{
    [Keyless]
    [Table("tbl_terminal_ndbnavaids")]
    public partial class TerminalNdbnavaid : EnrouteNdbnavaid
    {
        [Column("airport_identifier", TypeName = "TEXT(4)")]
        public string AirportIdentifier { get; set; } = null!;
    }
}
