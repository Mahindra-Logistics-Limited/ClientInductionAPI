using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ClientInductionAPI.Models.CIModel
{
    [Keyless]
    [Table("COMPLAINTAPIEVENT")]
    public partial class Complaintapievent
    {
        [Column("SEQID", TypeName = "NUMBER")]
        public decimal Seqid { get; set; }
        [Required]
        [Column("COMPLAINT_ID")]
        [StringLength(30)]
        public string ComplaintId { get; set; }
        [Column("COMMENTS")]
        [StringLength(2000)]
        public string Comments { get; set; }
        [Column("COMPLAINT_STATUS")]
        [StringLength(50)]
        public string ComplaintStatus { get; set; }
        [Column("CREATEDDATE", TypeName = "DATE")]
        public DateTime? Createddate { get; set; }
        [Column("PROCESSEDDATE", TypeName = "DATE")]
        public DateTime? Processeddate { get; set; }
        [Column("PROCESSEDSTATUS")]
        [StringLength(50)]
        public string Processedstatus { get; set; }
    }
}
