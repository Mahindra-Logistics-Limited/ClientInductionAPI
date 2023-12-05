using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ClientInductionAPI.Models.CIModel
{
    [Keyless]
    [Table("TRIPRATING")]
    [Index(nameof(Createddate), Name = "TRIPRATING_CR_DT")]
    [Index(nameof(Tripid), Name = "XMERU_RATING_TRIPID")]
    public partial class Triprating
    {
        [Column("TRIPID")]
        [StringLength(36)]
        public string Tripid { get; set; }
        [Column("BOOKINGREFERENCENO")]
        [StringLength(36)]
        public string Bookingreferenceno { get; set; }
        [Column("CHAUFFEURRATING", TypeName = "NUMBER")]
        public decimal? Chauffeurrating { get; set; }
        [Column("CABCONDITION", TypeName = "NUMBER")]
        public decimal? Cabcondition { get; set; }
        [Column("TIMELINESS", TypeName = "NUMBER")]
        public decimal? Timeliness { get; set; }
        [Column("OVERALLRATING", TypeName = "NUMBER")]
        public decimal? Overallrating { get; set; }
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
