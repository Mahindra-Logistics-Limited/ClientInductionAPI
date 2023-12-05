using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ClientInductionAPI.Models.CIModel
{
    [Keyless]
    [Table("XMERU_LOG_TBL_BKP3")]
    public partial class XmeruLogTblBkp3
    {
        [Required]
        [Column("PKG_NAME")]
        [StringLength(1000)]
        public string PkgName { get; set; }
        [Column("PROC_NAME")]
        [StringLength(1000)]
        public string ProcName { get; set; }
        [Column("LOC", TypeName = "NUMBER")]
        public decimal? Loc { get; set; }
        [Column("MESSAGE")]
        public string Message { get; set; }
        [Column("API_STATUS")]
        public string ApiStatus { get; set; }
        [Column("API_MSG")]
        public string ApiMsg { get; set; }
        [Column("SEQ_ID", TypeName = "NUMBER")]
        public decimal SeqId { get; set; }
        [Column("CREATED_ON", TypeName = "DATE")]
        public DateTime CreatedOn { get; set; }
    }
}
