using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ClientInductionAPI.Models.CIModel
{
    [Keyless]
    [Table("TEMPDOCMIGRATION")]
    public partial class Tempdocmigration
    {
        [Column("ENTITYTYPE")]
        [StringLength(20)]
        public string Entitytype { get; set; }
        [Column("ENTITYIDENTIFICATION")]
        [StringLength(20)]
        public string Entityidentification { get; set; }
        [Column("PRAGATIIDENTIFICATION")]
        [StringLength(20)]
        public string Pragatiidentification { get; set; }
        [Column("CREATEDDATE", TypeName = "DATE")]
        public DateTime? Createddate { get; set; }
        [Column("UPDATEDDATE", TypeName = "DATE")]
        public DateTime? Updateddate { get; set; }
    }
}
