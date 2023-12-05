using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ClientInductionAPI.Models.CIModel
{
    [Keyless]
    [Table("DEVICEMASTER")]
    [Index(nameof(Guid), nameof(Objectversionno), Name = "DEVICEMASTER_GUID_OVN", IsUnique = true)]
    [Index(nameof(Serialno), nameof(Deviceid), Name = "DEV_MAST_SRL_NO_DEV_ID")]
    [Index(nameof(Pkguid), Name = "XMERU_DEVICEMASTER_PKGUID", IsUnique = true)]
    [Index(nameof(Deviceid), Name = "XMERU_DEVICEMST_ID")]
    [Index(nameof(Serialno), Name = "XMERU_DEVICEMST_SERIALNO")]
    public partial class Devicemaster
    {
        [Required]
        [Column("GUID")]
        [StringLength(36)]
        public string Guid { get; set; }
        [Column("DEVICETYPEMASTERGUID")]
        [StringLength(36)]
        public string Devicetypemasterguid { get; set; }
        [Column("DEVICEID")]
        [StringLength(50)]
        public string Deviceid { get; set; }
        [Column("SERIALNO")]
        [StringLength(255)]
        public string Serialno { get; set; }
        [Column("CARDEVICEMAKEMASTERGUID")]
        [StringLength(36)]
        public string Cardevicemakemasterguid { get; set; }
        [Column("CARDEVICEMODELGUID")]
        [StringLength(36)]
        public string Cardevicemodelguid { get; set; }
        [Column("OWNERSHIPTYPE")]
        [StringLength(255)]
        public string Ownershiptype { get; set; }
        [Column("SERVICEPROVIDERGUID")]
        [StringLength(36)]
        public string Serviceproviderguid { get; set; }
        [Column("LEBRANCHSECURITYGUID")]
        [StringLength(36)]
        public string Lebranchsecurityguid { get; set; }
        [Column("EFFECTIVESTARTDATE", TypeName = "DATE")]
        public DateTime? Effectivestartdate { get; set; }
        [Column("EFFECTIVEENDDATE", TypeName = "DATE")]
        public DateTime? Effectiveenddate { get; set; }
        [Column("STATUSENTITYGUID")]
        [StringLength(36)]
        public string Statusentityguid { get; set; }
        [Column("CURRENTLOCATION")]
        [StringLength(255)]
        public string Currentlocation { get; set; }
        [Column("MOBILENO")]
        [StringLength(20)]
        public string Mobileno { get; set; }
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
        [Column("PKGUID")]
        [StringLength(36)]
        public string Pkguid { get; set; }
        [Column("READYFLAG")]
        [StringLength(30)]
        public string Readyflag { get; set; }
        [Column("SECURITYCOMBINATIONGUID")]
        [StringLength(36)]
        public string Securitycombinationguid { get; set; }
    }
}
