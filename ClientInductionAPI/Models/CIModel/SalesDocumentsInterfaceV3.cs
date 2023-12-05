using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ClientInductionAPI.Models.CIModel
{
    [Table("SALES_DOCUMENTS_INTERFACE_V3")]
    [Index(nameof(Entityuniqueid), Name = "SALES_DOCUMENTS_INTERFACE_V3_ENTITYUNIQUEID")]
    public partial class SalesDocumentsInterfaceV3
    {
        [Key]
        [Column("GUID")]
        [StringLength(36)]
        public string Guid { get; set; }
        [Column("DOCUMENTTYPE")]
        [StringLength(36)]
        public string Documenttype { get; set; }
        [Column("DOCUMENTTYPEENTITYGUID")]
        [StringLength(36)]
        public string Documenttypeentityguid { get; set; }
        [Column("DOCTYPENAME")]
        [StringLength(100)]
        public string Doctypename { get; set; }
        [Column("IMAGENAME")]
        [StringLength(100)]
        public string Imagename { get; set; }
        [Column("ENTITYUNIQUEID")]
        [StringLength(36)]
        public string Entityuniqueid { get; set; }
        [Column("DATECREATED", TypeName = "DATE")]
        public DateTime Datecreated { get; set; }
        [Column("USERUPDATED")]
        [StringLength(36)]
        public string Userupdated { get; set; }
        [Column("DATEUPDATED", TypeName = "DATE")]
        public DateTime? Dateupdated { get; set; }
        [Column("PAGENUMBER", TypeName = "NUMBER")]
        public decimal? Pagenumber { get; set; }
        [Column("STATUS")]
        [StringLength(2)]
        public string Status { get; set; }
        [Column("IMAGEVERIFIED", TypeName = "NUMBER")]
        public decimal? Imageverified { get; set; }
    }
}
