using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ClientInductionAPI.Models.CIModel
{
    [Keyless]
    public partial class PersonExpiryDocV1
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
        [Column("ADDRE_QUICKACCESSCODE")]
        [StringLength(25)]
        public string AddreQuickaccesscode { get; set; }
        [Column("ADDRE_VALIDITYENDDATE", TypeName = "DATE")]
        public DateTime? AddreValidityenddate { get; set; }
        [Column("AGREE_QUICKACCESSCODE")]
        [StringLength(25)]
        public string AgreeQuickaccesscode { get; set; }
        [Column("AGREE_DOCUMENTNO")]
        [StringLength(255)]
        public string AgreeDocumentno { get; set; }
        [Column("AGREE_VALIDITYENDDATE", TypeName = "DATE")]
        public DateTime? AgreeValidityenddate { get; set; }
        [Column("PHOTO_QUICKACCESSCODE")]
        [StringLength(25)]
        public string PhotoQuickaccesscode { get; set; }
        [Column("PHOTO_VALIDITYENDDATE", TypeName = "DATE")]
        public DateTime? PhotoValidityenddate { get; set; }
        [Column("PVC_QUICKACCESSCODE")]
        [StringLength(25)]
        public string PvcQuickaccesscode { get; set; }
        [Column("PVC_VALIDITYENDDATE", TypeName = "DATE")]
        public DateTime? PvcValidityenddate { get; set; }
    }
}
