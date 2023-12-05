using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ClientInductionAPI.Models.CIModel
{
    [Keyless]
    public partial class OutstandingHistV
    {
        [Column("SMSTDATE", TypeName = "DATE")]
        public DateTime? Smstdate { get; set; }
        [Column("SMENDDATE", TypeName = "DATE")]
        public DateTime? Smenddate { get; set; }
        [Column("SITENAME")]
        [StringLength(100)]
        public string Sitename { get; set; }
        [Column("SECURITYCOMBINATIONGUID")]
        [StringLength(36)]
        public string Securitycombinationguid { get; set; }
        [Column("SITE_STATUS")]
        [StringLength(200)]
        public string SiteStatus { get; set; }
        [Column("SITEGUID")]
        [StringLength(36)]
        public string Siteguid { get; set; }
        [Column("SPGUID")]
        [StringLength(36)]
        public string Spguid { get; set; }
        [Column("SITESTDATE", TypeName = "DATE")]
        public DateTime? Sitestdate { get; set; }
        [Column("SITEENDDATE", TypeName = "DATE")]
        public DateTime? Siteenddate { get; set; }
        [Column("SPEFSD", TypeName = "DATE")]
        public DateTime? Spefsd { get; set; }
        [Column("SPEFD", TypeName = "DATE")]
        public DateTime? Spefd { get; set; }
        [Column("PMGUID")]
        [StringLength(36)]
        public string Pmguid { get; set; }
        [Column("PMEFS", TypeName = "DATE")]
        public DateTime? Pmefs { get; set; }
        [Column("PMEFD", TypeName = "DATE")]
        public DateTime? Pmefd { get; set; }
        [Column("PERSONID")]
        [StringLength(1000)]
        public string Personid { get; set; }
        [Column("FIRSTNAME")]
        [StringLength(255)]
        public string Firstname { get; set; }
        [Column("LASTNAME")]
        [StringLength(255)]
        public string Lastname { get; set; }
        [Column("DRIVERFLAG")]
        public bool? Driverflag { get; set; }
        [Column("SPFLAG")]
        public bool? Spflag { get; set; }
        [Column("DSEFLAG")]
        public bool? Dseflag { get; set; }
        [Column("LE_NAME")]
        [StringLength(200)]
        public string LeName { get; set; }
        [Column("CITY_NAME")]
        [StringLength(200)]
        public string CityName { get; set; }
        [Column("BRAND_NAME")]
        [StringLength(200)]
        public string BrandName { get; set; }
        [Column("MODEL_NAME")]
        [StringLength(200)]
        public string ModelName { get; set; }
        [Column("CONTACTNO")]
        [StringLength(255)]
        public string Contactno { get; set; }
        [Column("LOCKCOUNT", TypeName = "NUMBER")]
        public decimal? Lockcount { get; set; }
        [Column("CAR_STATUS")]
        [StringLength(200)]
        public string CarStatus { get; set; }
        [Column("REGUID")]
        [StringLength(36)]
        public string Reguid { get; set; }
        [Column("BALANCE_DATE", TypeName = "DATE")]
        public DateTime? BalanceDate { get; set; }
        [Column("UPDATE_DATE", TypeName = "DATE")]
        public DateTime? UpdateDate { get; set; }
        [Column("DEPOSIT_OS", TypeName = "NUMBER")]
        public decimal? DepositOs { get; set; }
        [Column("SUBSCRIPTIO_DM_OS", TypeName = "NUMBER")]
        public decimal? SubscriptioDmOs { get; set; }
        [Column("TOTAL_OS", TypeName = "NUMBER")]
        public decimal? TotalOs { get; set; }
        [Column("DEPOSIT_DUE", TypeName = "NUMBER")]
        public decimal? DepositDue { get; set; }
        [Column("SUBSCRIPTIO_DM_DUE", TypeName = "NUMBER")]
        public decimal? SubscriptioDmDue { get; set; }
        [Column("TOTAL_DUE", TypeName = "NUMBER")]
        public decimal? TotalDue { get; set; }
    }
}
