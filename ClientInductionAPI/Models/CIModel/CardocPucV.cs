using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ClientInductionAPI.Models.CIModel
{
    [Keyless]
    public partial class CardocPucV
    {
        [Required]
        [Column("DOC_GUID")]
        [StringLength(36)]
        public string DocGuid { get; set; }
        [Required]
        [Column("DOC_NO")]
        [StringLength(255)]
        public string DocNo { get; set; }
        [Required]
        [Column("DOC_FILE_NAME")]
        [StringLength(255)]
        public string DocFileName { get; set; }
        [Column("DOC_VALID_FROM", TypeName = "DATE")]
        public DateTime? DocValidFrom { get; set; }
        [Column("DOC_VALID_TILL", TypeName = "DATE")]
        public DateTime? DocValidTill { get; set; }
        [Required]
        [Column("CAR_GUID")]
        [StringLength(36)]
        public string CarGuid { get; set; }
    }
}
