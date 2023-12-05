using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ClientInductionAPI.Models.CIModel
{
    [Keyless]
    public partial class SpbreakBaseV
    {
        [Column("SPBREAKGUID")]
        [StringLength(36)]
        public string Spbreakguid { get; set; }
        [Column("CARALLOCATIONGUID")]
        [StringLength(36)]
        public string Carallocationguid { get; set; }
        [Column("SERVICEPROVIDERGUID")]
        [StringLength(36)]
        public string Serviceproviderguid { get; set; }
        [Column("BREAKSTARTDATE", TypeName = "DATE")]
        public DateTime? Breakstartdate { get; set; }
        [Column("PROPOSEDBREAKENDDATE", TypeName = "DATE")]
        public DateTime? Proposedbreakenddate { get; set; }
        [Column("ACTUALBREAKENDDATE", TypeName = "DATE")]
        public DateTime? Actualbreakenddate { get; set; }
        [Column("STATUSENTITYGUID")]
        [StringLength(36)]
        public string Statusentityguid { get; set; }
        [Column("ISAPPROVALREQUIRED")]
        [StringLength(1)]
        public string Isapprovalrequired { get; set; }
        [Column("SPBREAKDISABLED")]
        public bool? Spbreakdisabled { get; set; }
        [Column("SPBREAKORACLEENTITYNAME")]
        [StringLength(100)]
        public string Spbreakoracleentityname { get; set; }
        [Column("SPBREAKORACLEENTITYID")]
        [StringLength(1000)]
        public string Spbreakoracleentityid { get; set; }
        [Column("SPBREAKOBJECTVERSIONNO")]
        public int? Spbreakobjectversionno { get; set; }
        [Column("SPBREAKPKGUID")]
        [StringLength(36)]
        public string Spbreakpkguid { get; set; }
        [Column("PROCESSEDFLAG")]
        [StringLength(2)]
        public string Processedflag { get; set; }
        [Column("COMMENTS")]
        [StringLength(500)]
        public string Comments { get; set; }
        [Column("PERSONGUID")]
        [StringLength(36)]
        public string Personguid { get; set; }
        [Column("SPID")]
        [StringLength(1000)]
        public string Spid { get; set; }
        [Column("SP_FNAME")]
        [StringLength(255)]
        public string SpFname { get; set; }
        [Column("SP_MNAME")]
        [StringLength(255)]
        public string SpMname { get; set; }
        [Column("SP_LNAME")]
        [StringLength(255)]
        public string SpLname { get; set; }
        [Column("SP_BIOID")]
        [StringLength(255)]
        public string SpBioid { get; set; }
        [Column("SP_OBJ_VER_NO")]
        public int? SpObjVerNo { get; set; }
        [Column("CUST_ID")]
        [StringLength(255)]
        public string CustId { get; set; }
        [Column("SP_STATUS")]
        [StringLength(25)]
        public string SpStatus { get; set; }
        [Column("PERS_STATUS")]
        [StringLength(25)]
        public string PersStatus { get; set; }
        [Column("DSEFLAG")]
        public bool? Dseflag { get; set; }
        [Column("SPFLAG")]
        public bool? Spflag { get; set; }
        [Column("DRIVERFLAG")]
        public bool? Driverflag { get; set; }
        [Required]
        [Column("STATUS_ENT_STSGUID")]
        [StringLength(36)]
        public string StatusEntStsguid { get; set; }
        [Column("STATUS_ENT_ENTGUID")]
        [StringLength(36)]
        public string StatusEntEntguid { get; set; }
        [Column("STATUS_ENT_OBJ_VER_NO")]
        public int? StatusEntObjVerNo { get; set; }
        [Column("STATUS_CODE")]
        [StringLength(25)]
        public string StatusCode { get; set; }
        [Column("STATUS_NAME")]
        [StringLength(200)]
        public string StatusName { get; set; }
        [Column("STATUS_DESC")]
        [StringLength(1000)]
        public string StatusDesc { get; set; }
        [Column("ENTITY_CODE")]
        [StringLength(50)]
        public string EntityCode { get; set; }
        [Column("SECURITYCOMBINATIONGUID")]
        [StringLength(36)]
        public string Securitycombinationguid { get; set; }
        [Column("CARREGISTRATIONNO")]
        [StringLength(255)]
        public string Carregistrationno { get; set; }
    }
}
