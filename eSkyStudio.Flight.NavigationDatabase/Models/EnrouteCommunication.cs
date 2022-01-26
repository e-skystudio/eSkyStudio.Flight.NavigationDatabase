using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace eSkyStudio.Flight.NavigationDatabase.Models
{
    [Keyless]
    [Table("tbl_enroute_communication")]
    public partial class EnrouteCommunication
    {
        [Column("area_code", TypeName = "TEXT(3)")]
        public string AreaCode { get; set; }
        [Column("fir_rdo_ident", TypeName = "TEXT(4)")]
        public string FirRdoIdent { get; set; }
        [Column("fir_uir_indicator", TypeName = "TEXT(1)")]
        public string FirUirIndicator { get; set; }
        [Column("communication_type", TypeName = "TEXT(3)")]
        public string CommunicationType { get; set; }
        [Column("communication_frequency", TypeName = "DOUBLE(5)")]
        public double? CommunicationFrequency { get; set; }
        [Column("frequency_units", TypeName = "TEXT(1)")]
        public string FrequencyUnits { get; set; }
        [Column("service_indicator", TypeName = "TEXT(3)")]
        public string ServiceIndicator { get; set; }
        [Column("remote_name", TypeName = "TEXT(25)")]
        public string RemoteName { get; set; }
        [Column("callsign", TypeName = "TEXT(30)")]
        public string Callsign { get; set; }
        [Column("latitude", TypeName = "DOUBLE(9)")]
        public double Latitude { get; set; }
        [Column("longitude", TypeName = "DOUBLE(10)")]
        public double Longitude { get; set; }
    }
}
