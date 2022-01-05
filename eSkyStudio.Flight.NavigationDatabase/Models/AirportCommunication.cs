using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace NavigationDatabase.Models
{
    [Keyless]
    [Table("tbl_airport_communication")]
    public partial class AirportCommunication
    {
        [Column("area_code", TypeName = "TEXT(3)")]
        public string? AreaCode { get; set; }
        [Column("icao_code", TypeName = "TEXT(2)")]
        public string? IcaoCode { get; set; }
        [Column("airport_identifier", TypeName = "TEXT(4)")]
        public string? AirportIdentifier { get; set; }
        [Column("communication_type", TypeName = "TEXT(3)")]
        public string? CommunicationType { get; set; }
        [Column("communication_frequency", TypeName = "DOUBLE(5)")]
        public double? CommunicationFrequency { get; set; }
        [Column("frequency_units", TypeName = "TEXT(1)")]
        public string? FrequencyUnits { get; set; }
        [Column("service_indicator", TypeName = "TEXT(3)")]
        public string? ServiceIndicator { get; set; }
        [Column("callsign", TypeName = "TEXT(25)")]
        public string? Callsign { get; set; }
        [Column("latitude", TypeName = "DOUBLE(9)")]
        public double? Latitude { get; set; }
        [Column("longitude", TypeName = "DOUBLE(10)")]
        public double? Longitude { get; set; }
    }
}
