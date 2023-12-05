using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ClientInductionAPI.Models.CIModel
{
    [Keyless]
    public partial class SendcomplaintnoteV
    {
        [Required]
        [Column("COMPLAINT_ID")]
        [StringLength(11)]
        public string ComplaintId { get; set; }
        [Column("COMMENTS")]
        [StringLength(2000)]
        public string Comments { get; set; }
        [Column("COMPLAINT_STATUS", TypeName = "NUMBER")]
        public decimal? ComplaintStatus { get; set; }
        [Required]
        [Column("NAME")]
        [StringLength(255)]
        public string Name { get; set; }
    }
}
