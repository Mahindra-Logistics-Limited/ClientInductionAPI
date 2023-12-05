using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ClientInductionAPI.Models.CIModel
{
    [Keyless]
    public partial class RatingV
    {
        [Column("TRIPGUID")]
        [StringLength(36)]
        public string Tripguid { get; set; }
        [Required]
        [Column("TRIPID")]
        [StringLength(36)]
        public string Tripid { get; set; }
        [Column("ENDTRIPDATE", TypeName = "DATE")]
        public DateTime? Endtripdate { get; set; }
        [Column("OVERALLRATING", TypeName = "NUMBER")]
        public decimal? Overallrating { get; set; }
        [Column("SERVICEPROVIDERGUID")]
        [StringLength(36)]
        public string Serviceproviderguid { get; set; }
        [Column("CARREGISTRATIONNO")]
        [StringLength(36)]
        public string Carregistrationno { get; set; }
        [Column("CARMASTERGUID")]
        [StringLength(36)]
        public string Carmasterguid { get; set; }
        [Column("SECURITYCOMBINATIONGUID")]
        [StringLength(36)]
        public string Securitycombinationguid { get; set; }
        [Column("DRIVERMASTERGUID")]
        [StringLength(36)]
        public string Drivermasterguid { get; set; }
        [Column("PKGUID")]
        [StringLength(36)]
        public string Pkguid { get; set; }
        [Column("SP_ID", TypeName = "NUMBER")]
        public decimal? SpId { get; set; }
        [Column("SITEGUID")]
        [StringLength(36)]
        public string Siteguid { get; set; }
        [Column("BOOKINGREFERENCENO")]
        [StringLength(36)]
        public string Bookingreferenceno { get; set; }
        [Column("CHAUFFEURRATING", TypeName = "NUMBER")]
        public decimal? Chauffeurrating { get; set; }
        [Column("CABCONDITION", TypeName = "NUMBER")]
        public decimal? Cabcondition { get; set; }
        [Column("TIMELINESS", TypeName = "NUMBER")]
        public decimal? Timeliness { get; set; }
        [Column("FEEDBACKDETAILS")]
        [StringLength(2000)]
        public string Feedbackdetails { get; set; }
        [Column("CREATEDDATE", TypeName = "DATE")]
        public DateTime? Createddate { get; set; }
        [Column("COMPLAINTTAKENUSER")]
        [StringLength(36)]
        public string Complainttakenuser { get; set; }
        [Column("COMPLAINTSTATUSID", TypeName = "NUMBER")]
        public decimal? Complaintstatusid { get; set; }
        [Column("SOURCECHANNELID", TypeName = "NUMBER")]
        public decimal? Sourcechannelid { get; set; }
        [Column("ACTIONTAKENUSERID", TypeName = "NUMBER(36)")]
        public decimal? Actiontakenuserid { get; set; }
        [Column("ACTIONTAKENID", TypeName = "NUMBER")]
        public decimal? Actiontakenid { get; set; }
        [Column("REMARKS")]
        [StringLength(100)]
        public string Remarks { get; set; }
        [Column("ACTIONTAKENDATE", TypeName = "DATE")]
        public DateTime? Actiontakendate { get; set; }
        [Column("STATUSENTITYGUID")]
        [StringLength(36)]
        public string Statusentityguid { get; set; }
    }
}
