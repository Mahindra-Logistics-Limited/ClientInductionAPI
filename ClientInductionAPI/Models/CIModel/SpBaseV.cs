using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ClientInductionAPI.Models.CIModel
{
    [Keyless]
    public partial class SpBaseV
    {
        [Required]
        [Column("GUID")]
        [StringLength(36)]
        public string Guid { get; set; }
        [Required]
        [Column("PERSONGUID")]
        [StringLength(36)]
        public string Personguid { get; set; }
        [Required]
        [Column("SPID")]
        [StringLength(1000)]
        public string Spid { get; set; }
        [Column("SP_DEFRRED_DOC_CHECK_FLAG")]
        [StringLength(1)]
        public string SpDefrredDocCheckFlag { get; set; }
        [Required]
        [Column("SP_FNAME")]
        [StringLength(255)]
        public string SpFname { get; set; }
        [Column("SP_MNAME")]
        [StringLength(255)]
        public string SpMname { get; set; }
        [Required]
        [Column("SP_LNAME")]
        [StringLength(255)]
        public string SpLname { get; set; }
        [Column("SP_FULLNAME")]
        [StringLength(767)]
        public string SpFullname { get; set; }
        [Required]
        [Column("SP_BIOID")]
        [StringLength(255)]
        public string SpBioid { get; set; }
        [Column("DSEFLAG")]
        public bool? Dseflag { get; set; }
        [Column("SPFLAG")]
        public bool? Spflag { get; set; }
        [Column("DRIVERFLAG")]
        public bool? Driverflag { get; set; }
        [Column("SP_OBJ_VER_NO")]
        public int? SpObjVerNo { get; set; }
        [Column("TDSCODE")]
        [StringLength(36)]
        public string Tdscode { get; set; }
        [Required]
        [Column("PERSONTYPE")]
        [StringLength(255)]
        public string Persontype { get; set; }
        [Column("CUST_ID")]
        [StringLength(255)]
        public string CustId { get; set; }
        [Column("SP_PKGUID")]
        [StringLength(36)]
        public string SpPkguid { get; set; }
        [Column("SP_STATUS")]
        [StringLength(25)]
        public string SpStatus { get; set; }
        [Column("PERS_STATUS")]
        [StringLength(25)]
        public string PersStatus { get; set; }
        [Column("ISSENDTOMONROE")]
        public short Issendtomonroe { get; set; }
        [Column("SPCLIENTMAPGUID")]
        [StringLength(36)]
        public string Spclientmapguid { get; set; }
    }
}
