using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ClientInductionAPI.Models.CIModel
{
    [Keyless]
    public partial class CarReportV
    {
        [Column("CARNUMBER")]
        [StringLength(255)]
        public string Carnumber { get; set; }
        [Column("EFFECTIVESTARTDATE", TypeName = "DATE")]
        public DateTime? Effectivestartdate { get; set; }
        [Column("EFFECTIVEENDDATE", TypeName = "DATE")]
        public DateTime? Effectiveenddate { get; set; }
        [Column("CHASSISNO")]
        [StringLength(255)]
        public string Chassisno { get; set; }
        [Column("ENGINENO")]
        [StringLength(100)]
        public string Engineno { get; set; }
        [Column("CAROWNER")]
        [StringLength(255)]
        public string Carowner { get; set; }
        [Column("GV_NAME")]
        [StringLength(255)]
        public string GvName { get; set; }
        [Required]
        [Column("SPID")]
        [StringLength(1000)]
        public string Spid { get; set; }
        [Column("SPNAME")]
        [StringLength(767)]
        public string Spname { get; set; }
        [Column("CARSTATUS")]
        [StringLength(25)]
        public string Carstatus { get; set; }
        [Required]
        [Column("CARMAKE")]
        [StringLength(255)]
        public string Carmake { get; set; }
        [Column("CARMODEL")]
        [StringLength(25)]
        public string Carmodel { get; set; }
        [Required]
        [Column("LENAME")]
        [StringLength(200)]
        public string Lename { get; set; }
        [Required]
        [Column("CITY")]
        [StringLength(200)]
        public string City { get; set; }
        [Column("BRAND")]
        [StringLength(200)]
        public string Brand { get; set; }
        [Column("MODEL")]
        [StringLength(200)]
        public string Model { get; set; }
        [Column("INS_DOC")]
        [StringLength(255)]
        public string InsDoc { get; set; }
        [Column("FIT_DOC")]
        [StringLength(255)]
        public string FitDoc { get; set; }
        [Column("RC_DOC")]
        [StringLength(255)]
        public string RcDoc { get; set; }
        [Column("PER_DOC")]
        [StringLength(255)]
        public string PerDoc { get; set; }
        [Required]
        [Column("SEC_GUID")]
        [StringLength(36)]
        public string SecGuid { get; set; }
    }
}
