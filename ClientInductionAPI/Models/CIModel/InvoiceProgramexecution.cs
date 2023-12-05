using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ClientInductionAPI.Models.CIModel
{
    [Table("INVOICE_PROGRAMEXECUTION")]
    public partial class InvoiceProgramexecution
    {
        [Key]
        [Column("GUID")]
        [StringLength(36)]
        public string Guid { get; set; }
        [Column("CALC_START_DATE", TypeName = "DATE")]
        public DateTime? CalcStartDate { get; set; }
        [Column("CALC_END_DATE", TypeName = "DATE")]
        public DateTime? CalcEndDate { get; set; }
        [Column("USERCREATED")]
        [StringLength(36)]
        public string Usercreated { get; set; }
        [Column("DATECREATED", TypeName = "DATE")]
        public DateTime? Datecreated { get; set; }
        [Column("EXECRUNSTARTDATE", TypeName = "DATE")]
        public DateTime? Execrunstartdate { get; set; }
        [Column("EXECRUNENDDATE", TypeName = "DATE")]
        public DateTime? Execrunenddate { get; set; }
        [Column("STATUS")]
        [StringLength(15)]
        public string Status { get; set; }
        [Column("ERRORDESCRIPTION")]
        [StringLength(2000)]
        public string Errordescription { get; set; }
    }
}
