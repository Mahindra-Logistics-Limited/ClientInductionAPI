using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ClientInductionAPI.Models.CIModel
{
    [Keyless]
    public partial class AllDocV
    {
        [Column("DOCUMENTTYPEMASTERNAME")]
        [StringLength(255)]
        public string Documenttypemastername { get; set; }
        [Column("DOCUMENTNO")]
        [StringLength(255)]
        public string Documentno { get; set; }
        [Column("VALIDITYSTARTDATE", TypeName = "DATE")]
        public DateTime? Validitystartdate { get; set; }
        [Column("VALIDITYENDDATE", TypeName = "DATE")]
        public DateTime? Validityenddate { get; set; }
        [Column("DOCUMENTTYPE")]
        [StringLength(6)]
        public string Documenttype { get; set; }
        [Column("OWNERGUID")]
        [StringLength(36)]
        public string Ownerguid { get; set; }
    }
}
