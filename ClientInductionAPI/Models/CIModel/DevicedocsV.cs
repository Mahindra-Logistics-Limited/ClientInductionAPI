using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ClientInductionAPI.Models.CIModel
{
    [Keyless]
    public partial class DevicedocsV
    {
        [Required]
        [Column("DOC_GUID")]
        [StringLength(36)]
        public string DocGuid { get; set; }
        [Required]
        [Column("DOCUMENTTYPEENTITYGUID")]
        [StringLength(36)]
        public string Documenttypeentityguid { get; set; }
        [Required]
        [Column("DOCUMENTNO")]
        [StringLength(255)]
        public string Documentno { get; set; }
        [Column("DOC_STATUSENTITYGUID")]
        [StringLength(36)]
        public string DocStatusentityguid { get; set; }
        [Column("DOC_EFFECTIVESTARTDATE", TypeName = "DATE")]
        public DateTime DocEffectivestartdate { get; set; }
        [Column("DOC_EFFECTIVEENDDATE", TypeName = "DATE")]
        public DateTime? DocEffectiveenddate { get; set; }
        [Column("DOC_DISABLED")]
        public bool? DocDisabled { get; set; }
        [Column("DEVICEMASTERGUID")]
        [StringLength(36)]
        public string Devicemasterguid { get; set; }
        [Required]
        [Column("DOCUMENTNAME")]
        [StringLength(255)]
        public string Documentname { get; set; }
        [Column("DOC_VALIDITYSTARTDATE", TypeName = "DATE")]
        public DateTime? DocValiditystartdate { get; set; }
        [Column("DOC_VALIDITYENDDATE", TypeName = "DATE")]
        public DateTime? DocValidityenddate { get; set; }
        [Column("DOCUMENTTYPECATEGORYGUID")]
        [StringLength(36)]
        public string Documenttypecategoryguid { get; set; }
        [Column("DOC_ORACLEENTITYNAME")]
        [StringLength(100)]
        public string DocOracleentityname { get; set; }
        [Column("DOC_ORACLEENTITYID")]
        [StringLength(1000)]
        public string DocOracleentityid { get; set; }
        [Column("DOC_OBJECTVERSIONNO")]
        public int? DocObjectversionno { get; set; }
        [Column("DOC_PKGUID")]
        [StringLength(36)]
        public string DocPkguid { get; set; }
        [Column("DOC_DOCUMENTPATH")]
        public string DocDocumentpath { get; set; }
        [Column("DOC_STATUS_CODE")]
        [StringLength(25)]
        public string DocStatusCode { get; set; }
        [Column("DOC_STATUS_NAME")]
        [StringLength(200)]
        public string DocStatusName { get; set; }
        [Column("DOC_TYPE_CODE")]
        [StringLength(25)]
        public string DocTypeCode { get; set; }
        [Required]
        [Column("DOC_TYPE")]
        [StringLength(255)]
        public string DocType { get; set; }
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
        [Column("DEVICE_STATUSENTITYGUID")]
        [StringLength(36)]
        public string DeviceStatusentityguid { get; set; }
        [Column("DEVICE_CURRENTLOCATION")]
        [StringLength(255)]
        public string DeviceCurrentlocation { get; set; }
        [Column("MOBILENO")]
        [StringLength(20)]
        public string Mobileno { get; set; }
    }
}
