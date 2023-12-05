using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ClientInductionAPI.Models.CIModel
{
    [Keyless]
    [Table("TEMPLATEEXECUTIONS")]
    [Index(nameof(Guid), nameof(Objectversionno), Name = "TEMPLATEEXECUTIONS_GUID_OVN", IsUnique = true)]
    public partial class Templateexecution
    {
        [Column("GUID")]
        [StringLength(36)]
        public string Guid { get; set; }
        [Column("SEARCHTEMPLATEMASTERGUID")]
        [StringLength(36)]
        public string Searchtemplatemasterguid { get; set; }
        [Column("PARAMETERTEXTFIELD1")]
        [StringLength(100)]
        public string Parametertextfield1 { get; set; }
        [Column("PARAMETERTEXTFIELD2")]
        [StringLength(100)]
        public string Parametertextfield2 { get; set; }
        [Column("PARAMETERTEXTFIELD3")]
        [StringLength(100)]
        public string Parametertextfield3 { get; set; }
        [Column("PARAMETERTEXTFIELD4")]
        [StringLength(100)]
        public string Parametertextfield4 { get; set; }
        [Column("PARAMETERTEXTFIELD5")]
        [StringLength(100)]
        public string Parametertextfield5 { get; set; }
        [Column("PARAMETERNOFIELD1", TypeName = "NUMBER")]
        public decimal? Parameternofield1 { get; set; }
        [Column("PARAMETERNOFIELD2", TypeName = "NUMBER")]
        public decimal? Parameternofield2 { get; set; }
        [Column("PARAMETERNOFIELD3", TypeName = "NUMBER")]
        public decimal? Parameternofield3 { get; set; }
        [Column("PARAMETERNOFIELD4", TypeName = "NUMBER")]
        public decimal? Parameternofield4 { get; set; }
        [Column("PARAMETERNOFIELD5", TypeName = "NUMBER")]
        public decimal? Parameternofield5 { get; set; }
        [Column("PARAMETERDATEFIELD1", TypeName = "DATE")]
        public DateTime? Parameterdatefield1 { get; set; }
        [Column("PARAMETERDATEFIELD2", TypeName = "DATE")]
        public DateTime? Parameterdatefield2 { get; set; }
        [Column("PARAMETERDATEFIELD3", TypeName = "DATE")]
        public DateTime? Parameterdatefield3 { get; set; }
        [Column("PARAMETERDATEFIELD4", TypeName = "DATE")]
        public DateTime? Parameterdatefield4 { get; set; }
        [Column("PARAMETERDATEFIELD5", TypeName = "DATE")]
        public DateTime? Parameterdatefield5 { get; set; }
        [Column("TEMPLATEEXECUTIONRESULT")]
        [StringLength(100)]
        public string Templateexecutionresult { get; set; }
        [Column("TEMPLATEEXECUTIONMESSAGE")]
        [StringLength(1000)]
        public string Templateexecutionmessage { get; set; }
        [Column("EFFECTIVESTARTDATE", TypeName = "DATE")]
        public DateTime Effectivestartdate { get; set; }
        [Column("EFFECTIVEENDDATE", TypeName = "DATE")]
        public DateTime Effectiveenddate { get; set; }
        [Required]
        [Column("USERCREATED")]
        [StringLength(36)]
        public string Usercreated { get; set; }
        [Column("DATECREATED", TypeName = "DATE")]
        public DateTime Datecreated { get; set; }
        [Column("USERUPDATED")]
        [StringLength(36)]
        public string Userupdated { get; set; }
        [Column("DATEUPDATED", TypeName = "DATE")]
        public DateTime? Dateupdated { get; set; }
        [Column("USERDELETED")]
        [StringLength(36)]
        public string Userdeleted { get; set; }
        [Column("DATEDELETED", TypeName = "DATE")]
        public DateTime? Datedeleted { get; set; }
        [Column("USERARCHIVED")]
        [StringLength(36)]
        public string Userarchived { get; set; }
        [Column("DATEARCHIVED", TypeName = "DATE")]
        public DateTime? Datearchived { get; set; }
        [Column("ORACLEENTITYNAME")]
        [StringLength(100)]
        public string Oracleentityname { get; set; }
        [Column("ORACLEENTITYID")]
        [StringLength(1000)]
        public string Oracleentityid { get; set; }
        [Column("OBJECTVERSIONNO")]
        public byte? Objectversionno { get; set; }
        [Column("WF_URL")]
        [StringLength(1000)]
        public string WfUrl { get; set; }
        [Column("SECURITYCOMBINATIONGUID")]
        [StringLength(36)]
        public string Securitycombinationguid { get; set; }
        [Column("PKGUID")]
        [StringLength(36)]
        public string Pkguid { get; set; }
        [Column("PARAMETERTEXTFIELD6")]
        [StringLength(100)]
        public string Parametertextfield6 { get; set; }
        [Column("PARAMETERTEXTFIELD7")]
        [StringLength(100)]
        public string Parametertextfield7 { get; set; }
        [Column("PARAMETERTEXTFIELD8")]
        [StringLength(100)]
        public string Parametertextfield8 { get; set; }
        [Column("PARAMETERTEXTFIELD9")]
        [StringLength(100)]
        public string Parametertextfield9 { get; set; }
        [Column("PARAMETERTEXTFIELD10")]
        [StringLength(100)]
        public string Parametertextfield10 { get; set; }
        [Column("PARAMETERNOFIELD6", TypeName = "NUMBER")]
        public decimal? Parameternofield6 { get; set; }
        [Column("PARAMETERNOFIELD7", TypeName = "NUMBER")]
        public decimal? Parameternofield7 { get; set; }
        [Column("PARAMETERNOFIELD8", TypeName = "NUMBER")]
        public decimal? Parameternofield8 { get; set; }
        [Column("PARAMETERNOFIELD9", TypeName = "NUMBER")]
        public decimal? Parameternofield9 { get; set; }
        [Column("PARAMETERNOFIELD10", TypeName = "NUMBER")]
        public decimal? Parameternofield10 { get; set; }
        [Column("PARAMETERDATEFIELD6", TypeName = "DATE")]
        public DateTime? Parameterdatefield6 { get; set; }
        [Column("PARAMETERDATEFIELD7", TypeName = "DATE")]
        public DateTime? Parameterdatefield7 { get; set; }
        [Column("PARAMETERDATEFIELD8", TypeName = "DATE")]
        public DateTime? Parameterdatefield8 { get; set; }
        [Column("PARAMETERDATEFIELD9", TypeName = "DATE")]
        public DateTime? Parameterdatefield9 { get; set; }
        [Column("PARAMETERDATEFIELD10", TypeName = "DATE")]
        public DateTime? Parameterdatefield10 { get; set; }
        [Column("STATUSENTITYGUID")]
        [StringLength(36)]
        public string Statusentityguid { get; set; }
        [Column("USERROLE")]
        [StringLength(36)]
        public string Userrole { get; set; }
    }
}
