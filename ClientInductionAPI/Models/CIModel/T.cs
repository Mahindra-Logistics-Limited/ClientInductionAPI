using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ClientInductionAPI.Models.CIModel
{
    [Keyless]
    [Table("T")]
    public partial class T
    {
        [Required]
        [Column("OWNER")]
        [StringLength(128)]
        public string Owner { get; set; }
        [Required]
        [Column("OBJECT_NAME")]
        [StringLength(128)]
        public string ObjectName { get; set; }
        [Column("SUBOBJECT_NAME")]
        [StringLength(128)]
        public string SubobjectName { get; set; }
        [Column("OBJECT_ID", TypeName = "NUMBER")]
        public decimal ObjectId { get; set; }
        [Column("DATA_OBJECT_ID", TypeName = "NUMBER")]
        public decimal? DataObjectId { get; set; }
        [Column("OBJECT_TYPE")]
        [StringLength(23)]
        public string ObjectType { get; set; }
        [Column("CREATED", TypeName = "DATE")]
        public DateTime Created { get; set; }
        [Column("LAST_DDL_TIME", TypeName = "DATE")]
        public DateTime LastDdlTime { get; set; }
        [Column("TIMESTAMP")]
        [StringLength(19)]
        public string Timestamp { get; set; }
        [Column("STATUS")]
        [StringLength(7)]
        public string Status { get; set; }
        [Column("TEMPORARY")]
        [StringLength(1)]
        public string Temporary { get; set; }
        [Column("GENERATED")]
        [StringLength(1)]
        public string Generated { get; set; }
        [Column("SECONDARY")]
        [StringLength(1)]
        public string Secondary { get; set; }
        [Column("NAMESPACE", TypeName = "NUMBER")]
        public decimal Namespace { get; set; }
        [Column("EDITION_NAME")]
        [StringLength(128)]
        public string EditionName { get; set; }
        [Column("SHARING")]
        [StringLength(18)]
        public string Sharing { get; set; }
        [Column("EDITIONABLE")]
        [StringLength(1)]
        public string Editionable { get; set; }
        [Column("ORACLE_MAINTAINED")]
        [StringLength(1)]
        public string OracleMaintained { get; set; }
        [Column("APPLICATION")]
        [StringLength(1)]
        public string Application { get; set; }
        [Column("DEFAULT_COLLATION")]
        [StringLength(100)]
        public string DefaultCollation { get; set; }
        [Column("DUPLICATED")]
        [StringLength(1)]
        public string Duplicated { get; set; }
        [Column("SHARDED")]
        [StringLength(1)]
        public string Sharded { get; set; }
        [Column("CREATED_APPID", TypeName = "NUMBER")]
        public decimal? CreatedAppid { get; set; }
        [Column("CREATED_VSNID", TypeName = "NUMBER")]
        public decimal? CreatedVsnid { get; set; }
        [Column("MODIFIED_APPID", TypeName = "NUMBER")]
        public decimal? ModifiedAppid { get; set; }
        [Column("MODIFIED_VSNID", TypeName = "NUMBER")]
        public decimal? ModifiedVsnid { get; set; }
    }
}
