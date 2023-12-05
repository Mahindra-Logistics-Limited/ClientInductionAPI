using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ClientInductionAPI.Models.CIModel
{
    [Keyless]
    [Table("SERVICEPROVIDER")]
    [Index(nameof(Guid), nameof(Objectversionno), Name = "SERVICEPROVIDER_GUID_OVN", IsUnique = true)]
    [Index(nameof(Personmasterguid), nameof(Objectversionno), Name = "SPMST_PERSGUID_OVN", IsUnique = true)]
    [Index(nameof(Pkguid), Name = "XMERU_SERVICEPROVIDER_PKGUID", IsUnique = true)]
    [Index(nameof(Personmasterguid), Name = "XMERU_SP_PERSONGUID")]
    public partial class Serviceprovider
    {
        [Required]
        [Column("GUID")]
        [StringLength(36)]
        public string Guid { get; set; }
        [Required]
        [Column("PERSONMASTERGUID")]
        [StringLength(36)]
        public string Personmasterguid { get; set; }
        [Required]
        [Column("PERSONTYPE")]
        [StringLength(255)]
        public string Persontype { get; set; }
        [Column("LINKTOSUPPLIER")]
        [StringLength(255)]
        public string Linktosupplier { get; set; }
        [Column("CUSTACCID")]
        [StringLength(255)]
        public string Custaccid { get; set; }
        [Column("STATUSENTITYGUID")]
        [StringLength(36)]
        public string Statusentityguid { get; set; }
        [Column("EFFECTIVESTARTDATE", TypeName = "DATE")]
        public DateTime Effectivestartdate { get; set; }
        [Column("EFFECTIVEENDDATE", TypeName = "DATE")]
        public DateTime? Effectiveenddate { get; set; }
        [Column("DISABLED")]
        public bool? Disabled { get; set; }
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
        public int? Objectversionno { get; set; }
        [Column("TDSCODE")]
        [StringLength(36)]
        public string Tdscode { get; set; }
        [Column("PKGUID")]
        [StringLength(36)]
        public string Pkguid { get; set; }
        [Column("READYFLAG")]
        [StringLength(40)]
        public string Readyflag { get; set; }
        [Column("DEFRRED_DOC_CHECK_FLAG")]
        [StringLength(1)]
        public string DefrredDocCheckFlag { get; set; }
        [Column("ISSENDTOMONROE")]
        public short Issendtomonroe { get; set; }
    }
}
