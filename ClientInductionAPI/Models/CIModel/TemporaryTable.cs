using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ClientInductionAPI.Models.CIModel
{
    [Keyless]
    [Table("TEMPORARY_TABLE")]
    public partial class TemporaryTable
    {
        [Column("ID")]
        public bool Id { get; set; }
    }
}
