using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ClientInductionAPI.Models.CIModel
{
    [Keyless]
    public partial class CargvV
    {
        [Column("GVC_VALUE")]
        public string GvcValue { get; set; }
        [Required]
        [Column("TXN_TYPE_GUID")]
        [StringLength(36)]
        public string TxnTypeGuid { get; set; }
        [Column("T_CLASS")]
        [StringLength(25)]
        public string TClass { get; set; }
        [Column("CAR_GVGUID")]
        [StringLength(36)]
        public string CarGvguid { get; set; }
        [Column("QUICKACCESSCODE")]
        [StringLength(50)]
        public string Quickaccesscode { get; set; }
        [Required]
        [Column("CARGUID")]
        [StringLength(36)]
        public string Carguid { get; set; }
    }
}
