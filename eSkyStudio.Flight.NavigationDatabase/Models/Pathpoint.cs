using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace eSkyStudio.Flight.NavigationDatabase.Models
{
    [Keyless]
    [Table("tbl_pathpoints")]
    public partial class Pathpoint
    {
        [Column("area_code", TypeName = "TEXT(3)")]
        public string? AreaCode { get; set; }
        [Column("airport_identifier", TypeName = "TEXT(4)")]
        public string? AirportIdentifier { get; set; }
        [Column("icao_code", TypeName = "TEXT(2)")]
        public string? IcaoRegion { get; set; }
        [Column("approach_procedure_ident", TypeName = "TEXT(6)")]
        public string? ApproachProcedureIdent { get; set; }
        [Column("runway_identifier", TypeName = "TEXT(5)")]
        public string? RunwayIdentifier { get; set; }
        [Column("sbas_service_provider_identifier", TypeName = "INTEGER(2)")]
        public long? SbasServiceProviderIdentifier { get; set; }
        [Column("reference_path_identifier", TypeName = "TEXT(2)")]
        public string? ReferencePathIdentifier { get; set; }
        [Column("landing_threshold_latitude", TypeName = "DOUBLE(9)")]
        public double? LandingThresholdLatitude { get; set; }
        [Column("landing_threshold_longitude", TypeName = "DOUBLE(10)")]
        public double? LandingThresholdLongitude { get; set; }
        [Column("ltp_ellipsoid_height", TypeName = "DOUBLE(6)")]
        public double? LtpEllipsoidHeight { get; set; }
        [Column("glidepath_angle", TypeName = "DOUBLE(4)")]
        public double? GlidepathAngle { get; set; }
        [Column("flightpath_alignment_latitude", TypeName = "DOUBLE(9)")]
        public double? FlightpathAlignmentLatitude { get; set; }
        [Column("flightpath_alignment_longitude", TypeName = "DOUBLE(10)")]
        public double? FlightpathAlignmentLongitude { get; set; }
        [Column("course_width_at_threshold", TypeName = "DOUBLE(5)")]
        public double? CourseWidthAtThreshold { get; set; }
        [Column("length_offset", TypeName = "INTEGER(4)")]
        public long? LengthOffset { get; set; }
        [Column("path_point_tch", TypeName = "INTEGER(6)")]
        public long? PathPointTch { get; set; }
        [Column("tch_units_indicator", TypeName = "TEXT(1)")]
        public string? TchUnitsIndicator { get; set; }
        [Column("hal", TypeName = "INTEGER(3)")]
        public long? Hal { get; set; }
        [Column("val", TypeName = "INTEGER(3)")]
        public long? Val { get; set; }
        [Column("fpap_ellipsoid_height", TypeName = "DOUBLE(6)")]
        public double? FpapEllipsoidHeight { get; set; }
        [Column("fpap_orthometric_height", TypeName = "DOUBLE(6)")]
        public double? FpapOrthometricHeight { get; set; }
        [Column("ltp_orthometric_height", TypeName = "DOUBLE(6)")]
        public double? LtpOrthometricHeight { get; set; }
        [Column("approach_type_identifier", TypeName = "TEXT(10)")]
        public string? ApproachTypeIdentifier { get; set; }
        [Column("gnss_channel_number", TypeName = "INTEGER(5)")]
        public long? GnssChannelNumber { get; set; }
    }
}
