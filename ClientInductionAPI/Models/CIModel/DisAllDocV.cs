using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ClientInductionAPI.Models.CIModel
{
    [Keyless]
    public partial class DisAllDocV
    {
        [Column("DOCUMENTNAME")]
        [StringLength(255)]
        public string Documentname { get; set; }
        [Column("ENTITY")]
        [StringLength(20)]
        public string Entity { get; set; }
        [Column("DOCUMENTNO")]
        [StringLength(255)]
        public string Documentno { get; set; }
        [Column("VALIDITYSTARTDATE", TypeName = "DATE")]
        public DateTime? Validitystartdate { get; set; }
        [Column("VALIDITYENDDATE", TypeName = "DATE")]
        public DateTime? Validityenddate { get; set; }
        [Column("OWNER")]
        public string Owner { get; set; }
        [Column("MANDATORY")]
        [StringLength(20)]
        public string Mandatory { get; set; }
        [Column("STATUS")]
        [StringLength(36)]
        public string Status { get; set; }
        [Column("DISPLAYNAME")]
        [StringLength(255)]
        public string Displayname { get; set; }
        [Column("BENEFICIERYNAME")]
        [StringLength(250)]
        public string Beneficieryname { get; set; }
        [Column("ACCOUNTNO")]
        [StringLength(250)]
        public string Accountno { get; set; }
        [Column("IFSCCODE")]
        [StringLength(250)]
        public string Ifsccode { get; set; }
    }
}
