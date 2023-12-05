using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ClientInductionAPI.Models.CIModel
{
    [Keyless]
    [Table("ZIPDIAL_INTERFACE")]
    public partial class ZipdialInterface
    {
        [Column("SR_NO")]
        public byte? SrNo { get; set; }
        [Column("CREATED_DATE", TypeName = "DATE")]
        public DateTime? CreatedDate { get; set; }
        [Column("LEADSTATUS")]
        [StringLength(50)]
        public string Leadstatus { get; set; }
        [Column("ZIPDIALNO", TypeName = "NUMBER")]
        public decimal? Zipdialno { get; set; }
        [Column("USERMOBILENUMBER", TypeName = "NUMBER")]
        public decimal? Usermobilenumber { get; set; }
        [Column("TIMEOFCALL", TypeName = "DATE")]
        public DateTime? Timeofcall { get; set; }
        [Column("CIRCLENAME")]
        [StringLength(100)]
        public string Circlename { get; set; }
        [Column("OPERATORNAME")]
        [StringLength(100)]
        public string Operatorname { get; set; }
        [Column("LEADNAME")]
        [StringLength(100)]
        public string Leadname { get; set; }
        [Column("INTERESTED")]
        [StringLength(100)]
        public string Interested { get; set; }
        [Column("COMMENTS")]
        [StringLength(1000)]
        public string Comments { get; set; }
        [Column("OUTCALLDONE")]
        [StringLength(50)]
        public string Outcalldone { get; set; }
        [Column("LASTUPDATEDATE", TypeName = "DATE")]
        public DateTime? Lastupdatedate { get; set; }
        [Column("LASTUPDATEDBY")]
        public byte? Lastupdatedby { get; set; }
    }
}
