using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ClientInductionAPI.Models.CIModel
{
    [Keyless]
    [Table("XMERU_TEMP_TBL")]
    public partial class XmeruTempTbl
    {
        [StringLength(100)]
        public string F1 { get; set; }
    }
}
