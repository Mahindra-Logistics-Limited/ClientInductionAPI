using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ClientInductionAPI.Models.CIModel
{
    [Table("COMPLAINTPRAGATI")]
    [Index(nameof(Carmasterguid), Name = "COMP_PRAG_CAR")]
    [Index(nameof(Drivermasterguid), Name = "COMP_PRAG_DRV")]
    [Index(nameof(Serviceproviderguid), Name = "COMP_PRAG_SP")]
    [Index(nameof(Complaintid), Name = "XMERU_PRAGATICOMPLAINTID_IND", IsUnique = true)]
    public partial class Complaintpragati
    {
        [Key]
        [Column("GUID")]
        [StringLength(36)]
        public string Guid { get; set; }
        [Required]
        [Column("COMPLAINTID")]
        [StringLength(11)]
        public string Complaintid { get; set; }
        [Column("CARMASTERGUID")]
        [StringLength(36)]
        public string Carmasterguid { get; set; }
        [Column("SERVICEPROVIDERGUID")]
        [StringLength(36)]
        public string Serviceproviderguid { get; set; }
        [Column("DRIVERMASTERGUID")]
        [StringLength(36)]
        public string Drivermasterguid { get; set; }
        [Column("COMPLAINTINCOMMINGCATEGORYGUID")]
        [StringLength(36)]
        public string Complaintincommingcategoryguid { get; set; }
        [Column("COMPLAINTCATEGORYMASTERGUID")]
        [StringLength(36)]
        public string Complaintcategorymasterguid { get; set; }
        [Column("JOBID")]
        [StringLength(15)]
        public string Jobid { get; set; }
        [Column("ASSIGNEDTOPERSONID")]
        public int? Assignedtopersonid { get; set; }
        [Column("DRIVERRATING", TypeName = "NUMBER(2,1)")]
        public decimal? Driverrating { get; set; }
        [Required]
        [Column("SUGGESTEDACTIONGUID")]
        [StringLength(36)]
        public string Suggestedactionguid { get; set; }
        [Column("ACTUALACTIONGUID")]
        [StringLength(36)]
        public string Actualactionguid { get; set; }
        [Column("ACTIONSTATUSGUID")]
        [StringLength(36)]
        public string Actionstatusguid { get; set; }
        [Column("COMMENTS")]
        [StringLength(2000)]
        public string Comments { get; set; }
        [Required]
        [Column("DISABLED")]
        [StringLength(1)]
        public string Disabled { get; set; }
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
        [StringLength(1000)]
        public string Oracleentityname { get; set; }
        [Column("ORACLEENTITYID")]
        [StringLength(1000)]
        public string Oracleentityid { get; set; }
        [Column("OBJECTVERSIONNO")]
        [StringLength(100)]
        public string Objectversionno { get; set; }
        [Required]
        [Column("PKGUID")]
        [StringLength(36)]
        public string Pkguid { get; set; }
        [Column("COMPLAINTSOURCEGUID")]
        [StringLength(36)]
        public string Complaintsourceguid { get; set; }
        [Column("DEBITTHETRIPAMOUNT")]
        public bool? Debitthetripamount { get; set; }
        [Column("ADDITIONALDEBITAMOUNT", TypeName = "NUMBER")]
        public decimal? Additionaldebitamount { get; set; }
        [Column("ADDITIONALDEBITCOMMENTS")]
        [StringLength(2000)]
        public string Additionaldebitcomments { get; set; }
        [Column("PYTHONSERVERDATA")]
        public string Pythonserverdata { get; set; }
        [Column("PYTHONSERVERSTATUS")]
        [StringLength(1)]
        public string Pythonserverstatus { get; set; }
    }
}
