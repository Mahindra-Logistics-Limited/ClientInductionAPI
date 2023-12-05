using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ClientInductionAPI.Models.CIModel
{
    [Table("COMPLAINTDETAILS")]
    [Index(nameof(Carregnno), nameof(Complaintdate), Name = "COMPL_CAR_DT")]
    [Index(nameof(Driverid), nameof(Complaintdate), Name = "COMPL_DRV_DT")]
    [Index(nameof(Complaintid), nameof(Complainttype), Name = "XMERU_COMPIDTYPE_IND", IsUnique = true)]
    public partial class Complaintdetail
    {
        [Key]
        [Column("GUID")]
        [StringLength(36)]
        public string Guid { get; set; }
        [Required]
        [Column("COMPLAINTID")]
        [StringLength(11)]
        public string Complaintid { get; set; }
        [Required]
        [Column("COMPLAINTTYPE")]
        [StringLength(30)]
        public string Complainttype { get; set; }
        [Column("COMPLAINTDATE", TypeName = "DATE")]
        public DateTime Complaintdate { get; set; }
        [Column("COMPLAINTSUBJECT")]
        [StringLength(250)]
        public string Complaintsubject { get; set; }
        [Column("COMPLAINTBODY")]
        public string Complaintbody { get; set; }
        [Column("CUSTOMERMOBILE")]
        [StringLength(100)]
        public string Customermobile { get; set; }
        [Column("CUSTOMEREMAILID")]
        [StringLength(100)]
        public string Customeremailid { get; set; }
        [Column("CARREGNNO")]
        [StringLength(255)]
        public string Carregnno { get; set; }
        [Column("DRIVERID")]
        [StringLength(1000)]
        public string Driverid { get; set; }
        [Column("JOBID")]
        [StringLength(20)]
        public string Jobid { get; set; }
        [Required]
        [Column("COMPLAINTINCOMMINGCATEGORY")]
        [StringLength(255)]
        public string Complaintincommingcategory { get; set; }
        [Column("COMPLAINTSOURCE")]
        [StringLength(255)]
        public string Complaintsource { get; set; }
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
        [Column("ORACLEENTITYNAME")]
        [StringLength(1000)]
        public string Oracleentityname { get; set; }
        [Column("STATUS")]
        [StringLength(50)]
        public string Status { get; set; }
    }
}
