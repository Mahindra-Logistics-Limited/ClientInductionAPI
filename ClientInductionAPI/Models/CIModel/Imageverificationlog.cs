using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ClientInductionAPI.Models.CIModel
{
    [Keyless]
    [Table("IMAGEVERIFICATIONLOG")]
    public partial class Imageverificationlog
    {
        [Required]
        [Column("GUID")]
        [StringLength(36)]
        public string Guid { get; set; }
        [Column("APINAME")]
        [StringLength(100)]
        public string Apiname { get; set; }
        [Required]
        [Column("PERSONID")]
        [StringLength(100)]
        public string Personid { get; set; }
        [Column("DOCTYPENAME")]
        [StringLength(100)]
        public string Doctypename { get; set; }
        [Column("IMAGENAME")]
        [StringLength(100)]
        public string Imagename { get; set; }
        [Column("SALESDOCINTERFACEGUID")]
        [StringLength(36)]
        public string Salesdocinterfaceguid { get; set; }
        [Column("DATECREATED", TypeName = "DATE")]
        public DateTime Datecreated { get; set; }
        [Column("RESPONSE", TypeName = "LONG")]
        public string Response { get; set; }
    }
}
