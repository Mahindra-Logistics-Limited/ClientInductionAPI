﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ClientInductionAPI.Models.CIModel
{
    [Keyless]
    [Table("DOCUMENTTYPECATEGORY")]
    [Index(nameof(Guid), nameof(Objectversionno), Name = "DOCUMENTTYPECATEGORY_GUID_OVN", IsUnique = true)]
    [Index(nameof(Pkguid), Name = "XMERU_DOCUMENTTYPECATE_PK", IsUnique = true)]
    public partial class Documenttypecategory
    {
        [Required]
        [Column("GUID")]
        [StringLength(36)]
        public string Guid { get; set; }
        [Required]
        [Column("DOCUMENTTYPEMASTERGUID")]
        [StringLength(36)]
        public string Documenttypemasterguid { get; set; }
        [Column("DOCUMENTCATEGORYMASTERGUID")]
        [StringLength(36)]
        public string Documentcategorymasterguid { get; set; }
        [Required]
        [Column("QUICKACCESSCODE")]
        [StringLength(25)]
        public string Quickaccesscode { get; set; }
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
        [StringLength(1000)]
        public string Oracleentityname { get; set; }
        [Column("ORACLEENTITYID")]
        [StringLength(100)]
        public string Oracleentityid { get; set; }
        [Column("OBJECTVERSIONNO")]
        public int? Objectversionno { get; set; }
        [Column("PKGUID")]
        [StringLength(36)]
        public string Pkguid { get; set; }
    }
}