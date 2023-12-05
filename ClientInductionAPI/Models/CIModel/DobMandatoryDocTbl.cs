using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ClientInductionAPI.Models.CIModel
{
    [Table("DOB_MANDATORY_DOC_TBL")]
    public partial class DobMandatoryDocTbl
    {
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
        [Column("DISPLAYNAME")]
        [StringLength(100)]
        public string Displayname { get; set; }
        [Column("SHORTNAME")]
        [StringLength(36)]
        public string Shortname { get; set; }
        [Column("NOOFPAGES", TypeName = "NUMBER")]
        public decimal? Noofpages { get; set; }
        [Column("REMARKS")]
        [StringLength(256)]
        public string Remarks { get; set; }
        [Column("SEQUENCENO", TypeName = "NUMBER")]
        public decimal? Sequenceno { get; set; }
        [Key]
        [Column("GUID")]
        [StringLength(36)]
        public string Guid { get; set; }

        [ForeignKey(nameof(Documenttypeentityguid))]
        [InverseProperty(nameof(Documenttypeentity.DobMandatoryDocTbls))]
        public virtual Documenttypeentity Documenttypeentitygu { get; set; }
    }
}
