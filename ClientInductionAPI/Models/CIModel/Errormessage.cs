using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ClientInductionAPI.Models.CIModel
{
    [Keyless]
    [Table("ERRORMESSAGE")]
    public partial class Errormessage
    {
        [Column("ERRORMESSAGETEXT")]
        [StringLength(2000)]
        public string Errormessagetext { get; set; }
        [Column("ERRORDATETIME", TypeName = "DATE")]
        public DateTime? Errordatetime { get; set; }
        [Column("METHODNAME")]
        [StringLength(2000)]
        public string Methodname { get; set; }
        [Column("CLASSNAME")]
        [StringLength(2000)]
        public string Classname { get; set; }
    }
}
