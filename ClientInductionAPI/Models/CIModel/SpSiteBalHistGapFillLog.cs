using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ClientInductionAPI.Models.CIModel
{
    [Keyless]
    [Table("SP_SITE_BAL_HIST_GAP_FILL_LOG")]
    public partial class SpSiteBalHistGapFillLog
    {
        [Column("SP_SITE_GUID")]
        [StringLength(36)]
        public string SpSiteGuid { get; set; }
        [Column("BALANCE_DT", TypeName = "DATE")]
        public DateTime? BalanceDt { get; set; }
        [Column("CREATED_DATE", TypeName = "DATE")]
        public DateTime? CreatedDate { get; set; }
    }
}
