using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ClientInductionAPI.Models.CIModel
{
    [Keyless]
    public partial class PersonExpiryDocV
    {
        [Required]
        [Column("PM_PERSONID")]
        [StringLength(1000)]
        public string PmPersonid { get; set; }
        [Column("PM_FULLNAME")]
        [StringLength(511)]
        public string PmFullname { get; set; }
        [Column("PM_DSEFLAG")]
        [StringLength(3)]
        public string PmDseflag { get; set; }
        [Column("PM_SPFLAG")]
        [StringLength(2)]
        public string PmSpflag { get; set; }
        [Column("PM_DRIVERFLAG")]
        [StringLength(6)]
        public string PmDriverflag { get; set; }
        [Column("ST_STATUS_NAME")]
        [StringLength(200)]
        public string StStatusName { get; set; }
        [Column("MOB_CONTACTNO")]
        [StringLength(255)]
        public string MobContactno { get; set; }
        [Column("CIT_ADDRESS")]
        [StringLength(511)]
        public string CitAddress { get; set; }
        [Column("CIT_CITYNAME")]
        [StringLength(255)]
        public string CitCityname { get; set; }
        [Column("BADGE_QUICKACCESSCODE")]
        [StringLength(25)]
        public string BadgeQuickaccesscode { get; set; }
        [Column("BADGE_DOCUMENTNO")]
        [StringLength(255)]
        public string BadgeDocumentno { get; set; }
        [Column("BADGE_VALIDITYENDDATE", TypeName = "DATE")]
        public DateTime? BadgeValidityenddate { get; set; }
        [Column("DL_QUICKACCESSCODE")]
        [StringLength(25)]
        public string DlQuickaccesscode { get; set; }
        [Column("DL_DOCUMENTNO")]
        [StringLength(255)]
        public string DlDocumentno { get; set; }
        [Column("DL_VALIDITYENDDATE", TypeName = "DATE")]
        public DateTime? DlValidityenddate { get; set; }
        [Column("PAN_QUICKACCESSCODE")]
        [StringLength(25)]
        public string PanQuickaccesscode { get; set; }
        [Column("PAN_DOCUMENTNO")]
        [StringLength(255)]
        public string PanDocumentno { get; set; }
    }
}
