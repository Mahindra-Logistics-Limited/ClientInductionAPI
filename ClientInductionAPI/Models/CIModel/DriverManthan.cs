using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ClientInductionAPI.Models.CIModel
{
    [Keyless]
    [Table("DRIVER_MANTHAN")]
    public partial class DriverManthan
    {
        [Column("SEQ_ID")]
        public byte? SeqId { get; set; }
        [Column("VERIFICATIONID")]
        public int? Verificationid { get; set; }
        [Column("ASSOCIATEDRIVERID")]
        public int? Associatedriverid { get; set; }
        [Column("SUBSCRIBERID")]
        public int? Subscriberid { get; set; }
        [Column("VERIFIEDPROOF")]
        [StringLength(5)]
        public string Verifiedproof { get; set; }
        [Column("ADDRESSPROOFPATH")]
        [StringLength(250)]
        public string Addressproofpath { get; set; }
        [Column("ADDRESSSTATUS")]
        [StringLength(50)]
        public string Addressstatus { get; set; }
        [Column("ADDRESSERROR")]
        [StringLength(2000)]
        public string Addresserror { get; set; }
        [Column("AGEPROOFPATH")]
        [StringLength(250)]
        public string Ageproofpath { get; set; }
        [Column("AGESTATUS")]
        [StringLength(50)]
        public string Agestatus { get; set; }
        [Column("AGEERROR")]
        [StringLength(2000)]
        public string Ageerror { get; set; }
        [Column("PHOTOIDPROOFPATH")]
        [StringLength(250)]
        public string Photoidproofpath { get; set; }
        [Column("PHOTOIDSTATUS")]
        [StringLength(50)]
        public string Photoidstatus { get; set; }
        [Column("PHOTOIDERROR")]
        [StringLength(2000)]
        public string Photoiderror { get; set; }
        [Column("DRIVINGLICENSEPATH")]
        [StringLength(250)]
        public string Drivinglicensepath { get; set; }
        [Column("DRIVINGSTATUS")]
        [StringLength(50)]
        public string Drivingstatus { get; set; }
        [Column("DRIVINGERROR")]
        [StringLength(2000)]
        public string Drivingerror { get; set; }
        [Column("MEDICALTEST")]
        [StringLength(5)]
        public string Medicaltest { get; set; }
        [Column("POLICEVERIFICATION")]
        [StringLength(5)]
        public string Policeverification { get; set; }
        [Column("RECORDEDDATE", TypeName = "DATE")]
        public DateTime? Recordeddate { get; set; }
        [Column("RECORDER")]
        public byte? Recorder { get; set; }
        [Column("LASTUPDATEDDATE", TypeName = "DATE")]
        public DateTime? Lastupdateddate { get; set; }
        [Column("LASTUPDATEDBY")]
        public byte? Lastupdatedby { get; set; }
        [Column("ISDELETED")]
        public bool? Isdeleted { get; set; }
        [Column("DRIVINGLICENSEVALIDITY", TypeName = "DATE")]
        public DateTime? Drivinglicensevalidity { get; set; }
        [Column("POLICEVARIFICATIONPATH")]
        [StringLength(300)]
        public string Policevarificationpath { get; set; }
        [Column("POLICESTATUS")]
        [StringLength(50)]
        public string Policestatus { get; set; }
        [Column("POLICEERROR")]
        [StringLength(2000)]
        public string Policeerror { get; set; }
        [Column("POLICEVARIFICATIONDATE", TypeName = "DATE")]
        public DateTime? Policevarificationdate { get; set; }
        [Column("BEDGENO")]
        [StringLength(100)]
        public string Bedgeno { get; set; }
        [Column("BEDGEPATH")]
        [StringLength(300)]
        public string Bedgepath { get; set; }
        [Column("BEDGESTATUS")]
        [StringLength(50)]
        public string Bedgestatus { get; set; }
        [Column("BEDGEERROR")]
        [StringLength(2000)]
        public string Bedgeerror { get; set; }
        [Column("BEDGEVALIDITY", TypeName = "DATE")]
        public DateTime? Bedgevalidity { get; set; }
        [Column("PAN")]
        [StringLength(10)]
        public string Pan { get; set; }
        [Column("PANPATH")]
        [StringLength(300)]
        public string Panpath { get; set; }
        [Column("PANSTATUS")]
        [StringLength(50)]
        public string Panstatus { get; set; }
        [Column("PANERROR")]
        [StringLength(2000)]
        public string Panerror { get; set; }
        [Column("STATUS")]
        [StringLength(1)]
        public string Status { get; set; }
        [Column("DRIVERID")]
        [StringLength(30)]
        public string Driverid { get; set; }
        [Column("DRIVINGLICENSENO")]
        [StringLength(20)]
        public string Drivinglicenseno { get; set; }
        [Column("DLEXPIRYDATE", TypeName = "DATE")]
        public DateTime? Dlexpirydate { get; set; }
    }
}
