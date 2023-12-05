using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ClientInductionAPI.Models.CIModel
{
    [Keyless]
    [Table("XMERU_CUST_LOG_TABLE")]
    public partial class XmeruCustLogTable
    {
        [Column("PKG_NAME")]
        [StringLength(50)]
        public string PkgName { get; set; }
        [Column("PROC_NAME")]
        [StringLength(50)]
        public string ProcName { get; set; }
        [Column("LOC")]
        [StringLength(20)]
        public string Loc { get; set; }
        [Column("MESSAGE")]
        [StringLength(2000)]
        public string Message { get; set; }
        [Column("API_STATUS")]
        [StringLength(1)]
        public string ApiStatus { get; set; }
        [Column("API_MSG")]
        [StringLength(2000)]
        public string ApiMsg { get; set; }
    }
}
