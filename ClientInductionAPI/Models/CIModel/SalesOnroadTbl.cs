using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ClientInductionAPI.Models.CIModel
{
    [Keyless]
    [Table("SALES_ONROAD_TBL")]
    public partial class SalesOnroadTbl
    {
        [Column("OWNERGUID")]
        [StringLength(36)]
        public string Ownerguid { get; set; }
        [Column("SPID")]
        [StringLength(36)]
        public string Spid { get; set; }
        [Column("CARNO")]
        [StringLength(36)]
        public string Carno { get; set; }
        [Column("DRIVERID")]
        [StringLength(36)]
        public string Driverid { get; set; }
        [Required]
        [Column("USERCREATED")]
        [StringLength(36)]
        public string Usercreated { get; set; }
        [Column("DATECREATED", TypeName = "DATE")]
        public DateTime Datecreated { get; set; }
        [Column("LAT")]
        [StringLength(100)]
        public string Lat { get; set; }
        [Column("LOG")]
        [StringLength(100)]
        public string Log { get; set; }
        [Column("BUSINESSCATEGORYMASTERGUID")]
        [StringLength(36)]
        public string Businesscategorymasterguid { get; set; }
    }
}
