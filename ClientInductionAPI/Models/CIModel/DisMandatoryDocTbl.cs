using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ClientInductionAPI.Models.CIModel
{
    [Keyless]
    [Table("DIS_MANDATORY_DOC_TBL")]
    [Index(nameof(Documenttypeentityguid), Name = "MAD_DOC_IND")]
    public partial class DisMandatoryDocTbl
    {
        [Required]
        [Column("DOCUMENTTYPEENTITYGUID")]
        [StringLength(36)]
        public string Documenttypeentityguid { get; set; }
        [Required]
        [Column("DOCUMENTTYPEMASTERNAME")]
        [StringLength(255)]
        public string Documenttypemastername { get; set; }
        [Column("QUICKACCESSCODE")]
        [StringLength(50)]
        public string Quickaccesscode { get; set; }
        [Column("ENTITY")]
        [StringLength(20)]
        public string Entity { get; set; }
        [Column("MANDATORY")]
        [StringLength(20)]
        public string Mandatory { get; set; }
        [Column("DISPLAYNAME")]
        [StringLength(255)]
        public string Displayname { get; set; }
    }
}
