using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ClientInductionAPI.Models.CIModel
{
    [Keyless]
    public partial class DisStatmentTxntypeV
    {
        [Column("TXNTYPE")]
        [StringLength(14)]
        public string Txntype { get; set; }
    }
}
