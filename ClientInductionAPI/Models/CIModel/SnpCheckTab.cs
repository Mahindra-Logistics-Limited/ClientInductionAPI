using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ClientInductionAPI.Models.CIModel
{
    [Keyless]
    [Table("SNP_CHECK_TAB")]
    public partial class SnpCheckTab
    {
        [Column("CATALOG_NAME")]
        [StringLength(100)]
        public string CatalogName { get; set; }
        [Column("SCHEMA_NAME")]
        [StringLength(100)]
        public string SchemaName { get; set; }
        [Column("RESOURCE_NAME")]
        [StringLength(100)]
        public string ResourceName { get; set; }
        [Column("FULL_RES_NAME")]
        [StringLength(100)]
        public string FullResName { get; set; }
        [Column("ERR_TYPE")]
        [StringLength(1)]
        public string ErrType { get; set; }
        [Column("ERR_MESS")]
        [StringLength(250)]
        public string ErrMess { get; set; }
        [Column("CHECK_DATE", TypeName = "DATE")]
        public DateTime? CheckDate { get; set; }
        [Column("ORIGIN")]
        [StringLength(100)]
        public string Origin { get; set; }
        [Column("CONS_NAME")]
        [StringLength(35)]
        public string ConsName { get; set; }
        [Column("CONS_TYPE")]
        [StringLength(2)]
        public string ConsType { get; set; }
        [Column("ERR_COUNT")]
        public int? ErrCount { get; set; }
    }
}
