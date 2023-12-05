using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ClientInductionAPI.Models.CIModel
{
    [Keyless]
    [Table("MANUAL_LOCK_DETAILS")]
    [Index(nameof(ExecutionGuid), nameof(SrNo), Name = "XMERU_EXC_SR_NO_IND", IsUnique = true)]
    [Index(nameof(Siteguid), Name = "XMERU_SITE_IND")]
    public partial class ManualLockDetail
    {
        [Column("EXECUTION_GUID")]
        [StringLength(36)]
        public string ExecutionGuid { get; set; }
        [Column("SR_NO", TypeName = "NUMBER")]
        public decimal? SrNo { get; set; }
        [Column("SPID")]
        [StringLength(20)]
        public string Spid { get; set; }
        [Column("SITENAME")]
        [StringLength(30)]
        public string Sitename { get; set; }
        [Column("UNLOCK_AMOUNT", TypeName = "NUMBER")]
        public decimal? UnlockAmount { get; set; }
        [Column("TOTAL_REMAINING_AMOUNT", TypeName = "NUMBER")]
        public decimal? TotalRemainingAmount { get; set; }
        [Column("SITEGUID")]
        [StringLength(36)]
        public string Siteguid { get; set; }
        [Column("CARGUID")]
        [StringLength(36)]
        public string Carguid { get; set; }
        [Column("USERGUID")]
        [StringLength(36)]
        public string Userguid { get; set; }
        [Column("ROLEGUID")]
        [StringLength(36)]
        public string Roleguid { get; set; }
        [Column("SEC_GUID")]
        [StringLength(36)]
        public string SecGuid { get; set; }
        [Column("STATUS")]
        [StringLength(50)]
        public string Status { get; set; }
        [Column("DATECREATED", TypeName = "DATE")]
        public DateTime? Datecreated { get; set; }
        [Column("DATEUPDATED", TypeName = "DATE")]
        public DateTime? Dateupdated { get; set; }
        [Column("USERCREATED")]
        [StringLength(36)]
        public string Usercreated { get; set; }
        [Column("ENABLEFLAG")]
        [StringLength(30)]
        public string Enableflag { get; set; }
        [Column("AMOUNTDATEUPDATED", TypeName = "DATE")]
        public DateTime? Amountdateupdated { get; set; }
        [Column("TODAYPAIDAMOUNT", TypeName = "NUMBER")]
        public decimal? Todaypaidamount { get; set; }
        [Column("ASONDATELOCKSTATUS", TypeName = "NUMBER")]
        public decimal? Asondatelockstatus { get; set; }
        [Column("BRANCHGUID")]
        [StringLength(36)]
        public string Branchguid { get; set; }
        [Column("CARBRANCH")]
        [StringLength(36)]
        public string Carbranch { get; set; }
        [Column("USERLEGUID")]
        [StringLength(36)]
        public string Userleguid { get; set; }
        [Column("CARLEGUID")]
        [StringLength(36)]
        public string Carleguid { get; set; }
        [Column("OSAMOUNT", TypeName = "NUMBER")]
        public decimal? Osamount { get; set; }
        [Column("TDPAMOUNT", TypeName = "NUMBER")]
        public decimal? Tdpamount { get; set; }
    }
}
