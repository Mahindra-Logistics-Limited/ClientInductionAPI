using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ClientInductionAPI.Models.CIModel
{
    [Keyless]
    [Table("CAR_MANTHAN")]
    public partial class CarManthan
    {
        [Column("SEQ_ID")]
        public int? SeqId { get; set; }
        [Column("CABREGISTRATIONNO")]
        [StringLength(20)]
        public string Cabregistrationno { get; set; }
        [Column("INSURANCEDOCPATH")]
        [StringLength(350)]
        public string Insurancedocpath { get; set; }
        [Column("INSURANCETYPE")]
        [StringLength(50)]
        public string Insurancetype { get; set; }
        [Column("INSURANCECOMPANY")]
        [StringLength(350)]
        public string Insurancecompany { get; set; }
        [Column("INSURANCEEXPIRYDATE", TypeName = "DATE")]
        public DateTime? Insuranceexpirydate { get; set; }
        [Column("INSURANCESTATUS")]
        [StringLength(10)]
        public string Insurancestatus { get; set; }
        [Column("INSURANCEERROR")]
        [StringLength(2000)]
        public string Insuranceerror { get; set; }
        [Column("INSURANCEFLAG")]
        [StringLength(10)]
        public string Insuranceflag { get; set; }
        [Column("INSURANCEPOLICYNUMBER")]
        [StringLength(50)]
        public string Insurancepolicynumber { get; set; }
        [Column("FITNESSDOCPATH")]
        [StringLength(350)]
        public string Fitnessdocpath { get; set; }
        [Column("FITNESSCERTIFICATENO")]
        [StringLength(150)]
        public string Fitnesscertificateno { get; set; }
        [Column("FITNESSCERTIFICATEEXPIRYDATE", TypeName = "DATE")]
        public DateTime? Fitnesscertificateexpirydate { get; set; }
        [Column("FITNESSSTATUS")]
        [StringLength(10)]
        public string Fitnessstatus { get; set; }
        [Column("FITNESSERROR")]
        [StringLength(2000)]
        public string Fitnesserror { get; set; }
        [Column("FITNESSFLAG")]
        [StringLength(10)]
        public string Fitnessflag { get; set; }
        [Column("ROADTAXDOCPATH")]
        [StringLength(350)]
        public string Roadtaxdocpath { get; set; }
        [Column("ROADTAXEXPIRYDATE", TypeName = "DATE")]
        public DateTime? Roadtaxexpirydate { get; set; }
        [Column("ROADTAXSTATUS")]
        [StringLength(10)]
        public string Roadtaxstatus { get; set; }
        [Column("ROADTAXERROR")]
        [StringLength(2000)]
        public string Roadtaxerror { get; set; }
        [Column("ROADTAXFLAG")]
        [StringLength(10)]
        public string Roadtaxflag { get; set; }
        [Column("RCDOCUMENTPATH")]
        [StringLength(300)]
        public string Rcdocumentpath { get; set; }
        [Column("RCDOCUMENTSTATUS")]
        [StringLength(50)]
        public string Rcdocumentstatus { get; set; }
        [Column("RCDOCUMENTERROR")]
        [StringLength(2000)]
        public string Rcdocumenterror { get; set; }
        [Column("RCDOCUMENTFLAG")]
        [StringLength(10)]
        public string Rcdocumentflag { get; set; }
        [Column("STATEPERMITDOCUMENTPATH")]
        [StringLength(300)]
        public string Statepermitdocumentpath { get; set; }
        [Column("STATEPERMITNO")]
        [StringLength(100)]
        public string Statepermitno { get; set; }
        [Column("STATEPERMITEXPIRYDATE", TypeName = "DATE")]
        public DateTime? Statepermitexpirydate { get; set; }
        [Column("STATEPERMITDOCUMENTSTATUS")]
        [StringLength(50)]
        public string Statepermitdocumentstatus { get; set; }
        [Column("STATEPERMITDOCUMENTERROR")]
        [StringLength(2000)]
        public string Statepermitdocumenterror { get; set; }
        [Column("STATEPERMITDOCUMENTFLAG")]
        [StringLength(10)]
        public string Statepermitdocumentflag { get; set; }
        [Column("NATIONALPERMITDOCUMENTPATH")]
        [StringLength(300)]
        public string Nationalpermitdocumentpath { get; set; }
        [Column("NATIONALPERMITNO")]
        [StringLength(100)]
        public string Nationalpermitno { get; set; }
        [Column("NATIONALPERMITEXPIRYDATE", TypeName = "DATE")]
        public DateTime? Nationalpermitexpirydate { get; set; }
        [Column("NATIONALPERMITDOCUMENTSTATUS")]
        [StringLength(50)]
        public string Nationalpermitdocumentstatus { get; set; }
        [Column("NATIONALPERMITDOCUMENTERROR")]
        [StringLength(2000)]
        public string Nationalpermitdocumenterror { get; set; }
        [Column("NATIONALPERMITDOCUMENTFLAG")]
        [StringLength(10)]
        public string Nationalpermitdocumentflag { get; set; }
        [Column("STATUS")]
        [StringLength(50)]
        public string Status { get; set; }
    }
}
