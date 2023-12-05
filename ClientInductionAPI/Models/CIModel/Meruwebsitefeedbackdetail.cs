using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ClientInductionAPI.Models.CIModel
{
    [Keyless]
    [Table("MERUWEBSITEFEEDBACKDETAILS")]
    [Index(nameof(Guid), Name = "MERUWEBSITEFEEDBACKDE_GUID_OVN", IsUnique = true)]
    public partial class Meruwebsitefeedbackdetail
    {
        [Required]
        [Column("GUID")]
        [StringLength(36)]
        public string Guid { get; set; }
        [Required]
        [Column("BOOKINGREFERENCENO")]
        [StringLength(20)]
        public string Bookingreferenceno { get; set; }
        [Column("CHAUFFEURRATING", TypeName = "NUMBER")]
        public decimal Chauffeurrating { get; set; }
        [Column("CABCONDITION", TypeName = "NUMBER")]
        public decimal Cabcondition { get; set; }
        [Column("TIMELINESS", TypeName = "NUMBER")]
        public decimal Timeliness { get; set; }
        [Column("OVERALLRATING", TypeName = "NUMBER")]
        public decimal Overallrating { get; set; }
        [Column("FEEDBACKDETAILS")]
        [StringLength(500)]
        public string Feedbackdetails { get; set; }
        [Column("CREATEDDATE")]
        public DateTime Createddate { get; set; }
        [Column("COMPLAINTTAKENUSER")]
        [StringLength(25)]
        public string Complainttakenuser { get; set; }
        [Column("COMPLAINTSTATUSID", TypeName = "NUMBER")]
        public decimal? Complaintstatusid { get; set; }
        [Column("SOURCECHANNELID", TypeName = "NUMBER")]
        public decimal? Sourcechannelid { get; set; }
        [Column("ACTIONTAKENUSERID", TypeName = "NUMBER")]
        public decimal? Actiontakenuserid { get; set; }
        [Column("ACTIONTAKENID", TypeName = "NUMBER")]
        public decimal? Actiontakenid { get; set; }
        [Column("REMARKS")]
        [StringLength(50)]
        public string Remarks { get; set; }
        [Column("ACTIONTAKENDATETIME")]
        public DateTime? Actiontakendatetime { get; set; }
    }
}
