using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ClientInductionAPI.Models.CIModel
{
    [Keyless]
    [Table("CARMASTER")]
    [Index(nameof(Guid), nameof(Objectversionno), Name = "CARMASTER_GUID_OVN", IsUnique = true)]
    [Index(nameof(Registrationno), Name = "CARREGNNO_IDX")]
    [Index(nameof(Pkguid), Name = "XMERU_CARMASTER_PKGUID", IsUnique = true)]
    [Index(nameof(Registrationno), nameof(Objectversionno), Name = "XMERU_CAR_REGN_OBJ_NO", IsUnique = true)]
    [Index(nameof(Securitycombinationguid), Name = "XMERU_CAR_SEC")]
    public partial class Carmaster
    {
        [Required]
        [Column("GUID")]
        [StringLength(36)]
        public string Guid { get; set; }
        [Column("CARDEVICEMAKEMASTERGUID")]
        [StringLength(36)]
        public string Cardevicemakemasterguid { get; set; }
        [Column("CARDEVICEMODELGUID")]
        [StringLength(36)]
        public string Cardevicemodelguid { get; set; }
        [Column("GROUPVARIANTGUID")]
        [StringLength(36)]
        public string Groupvariantguid { get; set; }
        [Column("STATUSENTITYGUID")]
        [StringLength(36)]
        public string Statusentityguid { get; set; }
        [Column("EFFECTIVESTARTDATE", TypeName = "DATE")]
        public DateTime? Effectivestartdate { get; set; }
        [Column("EFFECTIVEENDDATE", TypeName = "DATE")]
        public DateTime? Effectiveenddate { get; set; }
        [Column("OWNERSHIPTYPE")]
        [StringLength(255)]
        public string Ownershiptype { get; set; }
        [Column("SERVICEPROVIDERGUID")]
        [StringLength(36)]
        public string Serviceproviderguid { get; set; }
        [Column("POOLFLAG")]
        [StringLength(1)]
        public string Poolflag { get; set; }
        [Column("RFIDFLAG")]
        public bool? Rfidflag { get; set; }
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
        [Column("REGISTRATIONDATE", TypeName = "DATE")]
        public DateTime? Registrationdate { get; set; }
        [Column("REGISTRATIONNO")]
        [StringLength(255)]
        public string Registrationno { get; set; }
        [Column("SECURITYCOMBINATIONGUID")]
        [StringLength(36)]
        public string Securitycombinationguid { get; set; }
        [Column("CHASSISNO")]
        [StringLength(255)]
        public string Chassisno { get; set; }
        [Column("ENGINENO")]
        [StringLength(100)]
        public string Engineno { get; set; }
        [Column("WORKSHOPMASTERGUID")]
        [StringLength(36)]
        public string Workshopmasterguid { get; set; }
        [Column("REASONMASTERGUID")]
        [StringLength(36)]
        public string Reasonmasterguid { get; set; }
        [Column("PKGUID")]
        [StringLength(36)]
        public string Pkguid { get; set; }
        [Column("READYFLAG")]
        [StringLength(30)]
        public string Readyflag { get; set; }
        [Column("DEFRRED_DOC_CHECK_FLAG")]
        [StringLength(1)]
        public string DefrredDocCheckFlag { get; set; }
        [Column("LOCATIONWORKSHOPMASTERGUID")]
        [StringLength(36)]
        public string Locationworkshopmasterguid { get; set; }
        [Column("LOCKCOUNT", TypeName = "NUMBER")]
        public decimal? Lockcount { get; set; }
        [Column("COLORSMASTERGUID")]
        [StringLength(36)]
        public string Colorsmasterguid { get; set; }
        [Column("CARMAKEYEAR")]
        [StringLength(10)]
        public string Carmakeyear { get; set; }
        [Column("PAYTMQRCODE")]
        [StringLength(20)]
        public string Paytmqrcode { get; set; }
        [Column("MOBIKQRCODE")]
        [StringLength(20)]
        public string Mobikqrcode { get; set; }
        [Column("ISLBO", TypeName = "NUMBER")]
        public decimal? Islbo { get; set; }
        [Column("ISCMP", TypeName = "NUMBER")]
        public decimal? Iscmp { get; set; }
        [Column("BUSINESSCATEGORYMASTERGUID")]
        [StringLength(36)]
        public string Businesscategorymasterguid { get; set; }
        [Column("ANCHORLOCATIONGUID")]
        [StringLength(36)]
        public string Anchorlocationguid { get; set; }
        [Column("SHIFTMASTERGUID")]
        [StringLength(36)]
        public string Shiftmasterguid { get; set; }
        [Column("GARAGELOCATION")]
        [StringLength(500)]
        public string Garagelocation { get; set; }
        [Column("PERMITTYPE")]
        [StringLength(255)]
        public string Permittype { get; set; }
        [Column("NOOFSEATS", TypeName = "NUMBER(38)")]
        public decimal? Noofseats { get; set; }
        [Column("ISAC")]
        public bool? Isac { get; set; }
        [Column("ACTUALSTATE")]
        [StringLength(255)]
        public string Actualstate { get; set; }
        [Column("ACTUALCITY")]
        [StringLength(255)]
        public string Actualcity { get; set; }
        [Column("ISSENDTOMONROE")]
        public short Issendtomonroe { get; set; }
        [Column("CLIENTMAPGUID")]
        [StringLength(36)]
        public string Clientmapguid { get; set; }
        [Column("ISCABSENTFORINDUCTION")]
        public short? Iscabsentforinduction { get; set; }
    }
}
