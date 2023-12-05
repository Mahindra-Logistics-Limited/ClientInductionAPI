using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ClientInductionAPI.Models.CIModel
{
    [Table("TRANSACTIONCATEGORY")]
    public partial class Transactioncategory
    {
        [Key]
        [Column("GUID")]
        [StringLength(36)]
        public string Guid { get; set; }
        [Column("NAME")]
        [StringLength(100)]
        public string Name { get; set; }
        [Column("INCLUDEININVOICERATIOCAL")]
        [StringLength(5)]
        public string Includeininvoiceratiocal { get; set; }
        [Column("DISABLED")]
        public bool? Disabled { get; set; }
        [Column("QUICKACCESSCODE")]
        [StringLength(36)]
        public string Quickaccesscode { get; set; }
        [Column("USERCREATED")]
        [StringLength(36)]
        public string Usercreated { get; set; }
        [Column("DATECREATED", TypeName = "DATE")]
        public DateTime? Datecreated { get; set; }
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
    }
}
