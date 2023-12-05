using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ClientInductionAPI.Models.CIModel
{
    [Keyless]
    public partial class DeviceDocActionV
    {
        [Column("DEVICEMASTERGUID")]
        [StringLength(36)]
        public string Devicemasterguid { get; set; }
        [Column("DEVICEID")]
        [StringLength(50)]
        public string Deviceid { get; set; }
        [Column("SERIALNO")]
        [StringLength(255)]
        public string Serialno { get; set; }
        [Column("SERVICEPROVIDERGUID")]
        [StringLength(36)]
        public string Serviceproviderguid { get; set; }
        [Column("LEBRANCHSECURITYGUID")]
        [StringLength(36)]
        public string Lebranchsecurityguid { get; set; }
        [Column("MOBILENO")]
        [StringLength(20)]
        public string Mobileno { get; set; }
        [Required]
        [Column("DOCUMENTNO")]
        [StringLength(255)]
        public string Documentno { get; set; }
        [Column("DOC_GUID")]
        [StringLength(36)]
        public string DocGuid { get; set; }
        [Column("DOC_VALIDITYENDDATE", TypeName = "DATE")]
        public DateTime? DocValidityenddate { get; set; }
        [Column("ACTION_CODE")]
        [StringLength(36)]
        public string ActionCode { get; set; }
        [Column("DOC_ACTION_DATECREATED", TypeName = "DATE")]
        public DateTime? DocActionDatecreated { get; set; }
        [Column("DOC_ACTION_PKGUID")]
        [StringLength(36)]
        public string DocActionPkguid { get; set; }
        [Column("DOC_TYPE")]
        [StringLength(50)]
        public string DocType { get; set; }
        [Column("ACTION_NUMBER", TypeName = "NUMBER")]
        public decimal? ActionNumber { get; set; }
        [Column("ACTION_NAME")]
        [StringLength(50)]
        public string ActionName { get; set; }
        [Column("ACTION_DESCRIPTION")]
        [StringLength(500)]
        public string ActionDescription { get; set; }
    }
}
