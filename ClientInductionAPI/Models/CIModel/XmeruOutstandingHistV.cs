using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ClientInductionAPI.Models.CIModel
{
    [Keyless]
    public partial class XmeruOutstandingHistV
    {
        [Column("CM_SECURITYCOMBINATIONGUID")]
        [StringLength(36)]
        public string CmSecuritycombinationguid { get; set; }
        [Column("SITENAME")]
        [StringLength(255)]
        public string Sitename { get; set; }
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
        [Column("SPID")]
        [StringLength(1000)]
        public string Spid { get; set; }
        [Column("NAME_OF_DSE")]
        [StringLength(511)]
        public string NameOfDse { get; set; }
        [Column("MOBILE_NO")]
        [StringLength(255)]
        public string MobileNo { get; set; }
        [Column("STATUS_OF_SITE")]
        [StringLength(200)]
        public string StatusOfSite { get; set; }
        [Column("ALLOCATION_DATE", TypeName = "DATE")]
        public DateTime? AllocationDate { get; set; }
        [Column("ALLOCATION_END_DATE", TypeName = "DATE")]
        public DateTime? AllocationEndDate { get; set; }
        [Column("LOCK_STATUS")]
        [StringLength(6)]
        public string LockStatus { get; set; }
        [Column("CAR_STATUS")]
        [StringLength(25)]
        public string CarStatus { get; set; }
        [Column("DSE")]
        [StringLength(3)]
        public string Dse { get; set; }
        [Column("SP")]
        [StringLength(2)]
        public string Sp { get; set; }
        [Column("DRIVER")]
        [StringLength(6)]
        public string Driver { get; set; }
        [Column("BALANCE_DATE", TypeName = "DATE")]
        public DateTime? BalanceDate { get; set; }
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
        [Column("CM_EFFECTIVESTARTDATE", TypeName = "DATE")]
        public DateTime? CmEffectivestartdate { get; set; }
        [Column("CM_EFFECTIVEENDDATE", TypeName = "DATE")]
        public DateTime? CmEffectiveenddate { get; set; }
        [Column("PM_EFFECTIVESTARTDATE", TypeName = "DATE")]
        public DateTime? PmEffectivestartdate { get; set; }
        [Column("PM_EFFECTIVEENDDATE", TypeName = "DATE")]
        public DateTime? PmEffectiveenddate { get; set; }
        [Column("SP_EFFECTIVESTARTDATE", TypeName = "DATE")]
        public DateTime? SpEffectivestartdate { get; set; }
        [Column("SP_EFFECTIVEENDDATE", TypeName = "DATE")]
        public DateTime? SpEffectiveenddate { get; set; }
        [Column("PC1_EFFECTIVESTARTDATE", TypeName = "DATE")]
        public DateTime? Pc1Effectivestartdate { get; set; }
        [Column("PC1_EFFECTIVEENDDATE", TypeName = "DATE")]
        public DateTime? Pc1Effectiveenddate { get; set; }
        [Column("SMSTDATE", TypeName = "DATE")]
        public DateTime? Smstdate { get; set; }
        [Column("SMENDDATE", TypeName = "DATE")]
        public DateTime? Smenddate { get; set; }
        [Column("LAST_TRANSACTION_DATE", TypeName = "DATE")]
        public DateTime? LastTransactionDate { get; set; }
    }
}
