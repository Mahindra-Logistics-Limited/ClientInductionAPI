using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ClientInductionAPI.Models.CIModel
{
    [Keyless]
    public partial class CarDevicelistBaseV
    {
        [Required]
        [Column("CARGUID")]
        [StringLength(36)]
        public string Carguid { get; set; }
        [Required]
        [Column("CARDEVICEGUID")]
        [StringLength(36)]
        public string Cardeviceguid { get; set; }
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
        [Required]
        [Column("DEVICEMASTERGUID")]
        [StringLength(36)]
        public string Devicemasterguid { get; set; }
        [Column("DEVICEID")]
        [StringLength(50)]
        public string Deviceid { get; set; }
        [Column("DEVICESERIALNO")]
        [StringLength(255)]
        public string Deviceserialno { get; set; }
        [Column("DEVICEOWNERSHIPTYPE")]
        [StringLength(255)]
        public string Deviceownershiptype { get; set; }
        [Column("DEVICELEBRANCHSECURITYGUID")]
        [StringLength(36)]
        public string Devicelebranchsecurityguid { get; set; }
        [Column("DEVICEEFFECTIVESTARTDATE", TypeName = "DATE")]
        public DateTime? Deviceeffectivestartdate { get; set; }
        [Column("DEVICEEFFECTIVEENDDATE", TypeName = "DATE")]
        public DateTime? Deviceeffectiveenddate { get; set; }
        [Column("DEVICECURRENTLOCATION")]
        [StringLength(255)]
        public string Devicecurrentlocation { get; set; }
        [Column("DEVICEMOBILENO")]
        [StringLength(20)]
        public string Devicemobileno { get; set; }
        [Column("DEVICEORACLEENTITYNAME")]
        [StringLength(100)]
        public string Deviceoracleentityname { get; set; }
        [Column("DEVICEORACLEENTITYID")]
        [StringLength(1000)]
        public string Deviceoracleentityid { get; set; }
        [Column("DEVICEOBJECTVERSIONNO")]
        public int? Deviceobjectversionno { get; set; }
        [Column("DEVICEPKGUID")]
        [StringLength(36)]
        public string Devicepkguid { get; set; }
        [Required]
        [Column("DEV_TYPE_CODE")]
        [StringLength(25)]
        public string DevTypeCode { get; set; }
        [Required]
        [Column("DEV_TYPE_NAME")]
        [StringLength(255)]
        public string DevTypeName { get; set; }
        [Column("DEV_STATUS_CODE")]
        [StringLength(25)]
        public string DevStatusCode { get; set; }
        [Column("DEV_STATUS_NAME")]
        [StringLength(200)]
        public string DevStatusName { get; set; }
        [Required]
        [Column("MAKEMASTERGUID")]
        [StringLength(36)]
        public string Makemasterguid { get; set; }
        [Required]
        [Column("MAKEMASTERNAME")]
        [StringLength(255)]
        public string Makemastername { get; set; }
        [Column("MAKEMASTERDESCRIPTION")]
        [StringLength(2000)]
        public string Makemasterdescription { get; set; }
        [Column("MAKEMASTERQUICKACCESSCODE")]
        [StringLength(25)]
        public string Makemasterquickaccesscode { get; set; }
        [Column("MAKEMASTERCOMMENTS")]
        [StringLength(2000)]
        public string Makemastercomments { get; set; }
        [Column("MAKEMASTERDISABLED")]
        public bool? Makemasterdisabled { get; set; }
        [Column("MAKEMASTERORACLEENTITYNAME")]
        [StringLength(100)]
        public string Makemasteroracleentityname { get; set; }
        [Column("MAKEMASTERORACLEENTITYID")]
        [StringLength(1000)]
        public string Makemasteroracleentityid { get; set; }
        [Column("MAKEMASTEROBJECTVERSIONNO")]
        public int? Makemasterobjectversionno { get; set; }
        [Column("MAKEMASTERPKGUID")]
        [StringLength(36)]
        public string Makemasterpkguid { get; set; }
        [Required]
        [Column("DEVICETYPEMASTERGUID")]
        [StringLength(36)]
        public string Devicetypemasterguid { get; set; }
        [Required]
        [Column("DEVICETYPENAME")]
        [StringLength(255)]
        public string Devicetypename { get; set; }
        [Column("DEVICETYPEDESCRIPTION")]
        [StringLength(2000)]
        public string Devicetypedescription { get; set; }
        [Required]
        [Column("DEVICETYPEQUICKACCESSCODE")]
        [StringLength(25)]
        public string Devicetypequickaccesscode { get; set; }
        [Column("DEVICETYPECOMMENTS")]
        [StringLength(2000)]
        public string Devicetypecomments { get; set; }
        [Column("DEVICETYPEDISABLED")]
        public bool? Devicetypedisabled { get; set; }
        [Column("DEVICETYPEORACLEENTITYNAME")]
        [StringLength(100)]
        public string Devicetypeoracleentityname { get; set; }
        [Column("DEVICETYPEORACLEENTITYID")]
        [StringLength(1000)]
        public string Devicetypeoracleentityid { get; set; }
        [Column("DEVICETYPEOBJECTVERSIONNO")]
        public int? Devicetypeobjectversionno { get; set; }
        [Column("DEVICETYPEREGULAREXPRESSION")]
        [StringLength(100)]
        public string Devicetyperegularexpression { get; set; }
        [Column("DEVICETYPEPKGUID")]
        [StringLength(36)]
        public string Devicetypepkguid { get; set; }
        [Required]
        [Column("MODELGUID")]
        [StringLength(36)]
        public string Modelguid { get; set; }
        [Column("MODELNAME")]
        [StringLength(255)]
        public string Modelname { get; set; }
        [Column("MODELDESCRIPTION")]
        [StringLength(2000)]
        public string Modeldescription { get; set; }
        [Column("MODELQUICKACCESSCODE")]
        [StringLength(25)]
        public string Modelquickaccesscode { get; set; }
        [Column("MODELCOMMENTS")]
        [StringLength(2000)]
        public string Modelcomments { get; set; }
        [Column("MODELDISABLED")]
        public bool? Modeldisabled { get; set; }
        [Column("MODELORACLEENTITYNAME")]
        [StringLength(100)]
        public string Modeloracleentityname { get; set; }
        [Column("MODELORACLEENTITYID")]
        [StringLength(1000)]
        public string Modeloracleentityid { get; set; }
        [Column("MODELOBJECTVERSIONNO")]
        public int? Modelobjectversionno { get; set; }
        [Column("MODELPKGUID")]
        [StringLength(36)]
        public string Modelpkguid { get; set; }
        [Column("CAR_DEV_STATUSENTITYGUID")]
        [StringLength(36)]
        public string CarDevStatusentityguid { get; set; }
        [Column("CAR_DEV_STATUS_CODE")]
        [StringLength(25)]
        public string CarDevStatusCode { get; set; }
    }
}
