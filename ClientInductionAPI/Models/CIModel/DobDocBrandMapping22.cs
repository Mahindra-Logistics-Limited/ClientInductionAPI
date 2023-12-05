using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ClientInductionAPI.Models.CIModel
{
    [Table("DOB_DOC_BRAND_MAPPING22")]
    public partial class DobDocBrandMapping22
    {
        [Key]
        [Column("GUID")]
        [StringLength(36)]
        public string Guid { get; set; }
        [Required]
        [Column("BRANDMASTERGUID")]
        [StringLength(36)]
        public string Brandmasterguid { get; set; }
        [Required]
        [Column("DOCUMENTTYPEENTITYGUID")]
        [StringLength(36)]
        public string Documenttypeentityguid { get; set; }
        [Column("SETID", TypeName = "NUMBER")]
        public decimal? Setid { get; set; }
        [Column("ISMANDATORY")]
        [StringLength(1)]
        public string Ismandatory { get; set; }
        [Column("CATEGORY")]
        [StringLength(1)]
        public string Category { get; set; }
        [Column("ENTITY")]
        [StringLength(20)]
        public string Entity { get; set; }
        [Column("ONLYFORSECONDOWNER", TypeName = "NUMBER")]
        public decimal? Onlyforsecondowner { get; set; }
        [Required]
        [Column("BRANCHMASTERGUID")]
        [StringLength(36)]
        public string Branchmasterguid { get; set; }
        [Column("BUSINESSCATEGORYMASTERGUID")]
        [StringLength(36)]
        public string Businesscategorymasterguid { get; set; }

        [ForeignKey(nameof(Brandmasterguid))]
        [InverseProperty(nameof(Brandmaster.DobDocBrandMapping22s))]
        public virtual Brandmaster Brandmastergu { get; set; }
        [ForeignKey(nameof(Documenttypeentityguid))]
        [InverseProperty(nameof(Documenttypeentity.DobDocBrandMapping22s))]
        public virtual Documenttypeentity Documenttypeentitygu { get; set; }
    }
}
