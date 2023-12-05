﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ClientInductionAPI.Models.CIModel
{
    [Table("COMPLAINTCATEGORYMAPPING")]
    public partial class Complaintcategorymapping
    {
        [Key]
        [Column("GUID")]
        [StringLength(36)]
        public string Guid { get; set; }
        [Required]
        [Column("COMPLAINTCATEGORYMASTERGUID")]
        [StringLength(36)]
        public string Complaintcategorymasterguid { get; set; }
        [Required]
        [Column("COMPLAINTINCOMINGCATEGORYGUID")]
        [StringLength(36)]
        public string Complaintincomingcategoryguid { get; set; }
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
        [Column("DATECREATED")]
        public DateTime Datecreated { get; set; }
        [Column("USERUPDATED")]
        [StringLength(36)]
        public string Userupdated { get; set; }
        [Column("DATEUPDATED")]
        public DateTime? Dateupdated { get; set; }
        [Column("USERDELETED")]
        [StringLength(36)]
        public string Userdeleted { get; set; }
        [Column("DATEDELETED")]
        public DateTime? Datedeleted { get; set; }
        [Column("USERARCHIVED")]
        [StringLength(36)]
        public string Userarchived { get; set; }
        [Column("DATEARCHIVED")]
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
    }
}
