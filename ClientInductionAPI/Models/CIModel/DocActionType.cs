using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ClientInductionAPI.Models.CIModel
{
    [Keyless]
    [Table("DOC_ACTION_TYPE")]
    public partial class DocActionType
    {
        [Column("ACTION", TypeName = "NUMBER")]
        public decimal? Action { get; set; }
        [Column("NAME")]
        [StringLength(50)]
        public string Name { get; set; }
        [Column("QUICKACCESSCODE")]
        [StringLength(500)]
        public string Quickaccesscode { get; set; }
        [Column("DESCRIPTION")]
        [StringLength(500)]
        public string Description { get; set; }
    }
}
