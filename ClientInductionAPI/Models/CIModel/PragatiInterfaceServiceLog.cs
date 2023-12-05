using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ClientInductionAPI.Models.CIModel
{
    [Keyless]
    [Table("PRAGATI_INTERFACE_SERVICE_LOG")]
    public partial class PragatiInterfaceServiceLog
    {
        [Column("RESPONSE_ID", TypeName = "NUMBER")]
        public decimal? ResponseId { get; set; }
        [Column("EVENT_ID", TypeName = "NUMBER")]
        public decimal? EventId { get; set; }
        [Column("CREATED_DATE", TypeName = "DATE")]
        public DateTime? CreatedDate { get; set; }
        [Column("RESPONSE_COMMENTS")]
        [StringLength(100)]
        public string ResponseComments { get; set; }
    }
}
