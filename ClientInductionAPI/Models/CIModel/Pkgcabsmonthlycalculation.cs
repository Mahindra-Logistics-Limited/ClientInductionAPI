using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ClientInductionAPI.Models.CIModel
{
    [Table("PKGCABSMONTHLYCALCULATION")]
    public partial class Pkgcabsmonthlycalculation
    {
        [Key]
        [Column("GUID")]
        [StringLength(36)]
        public string Guid { get; set; }
        [Column("CABNO")]
        [StringLength(255)]
        public string Cabno { get; set; }
        [Column("WORKINGHRS", TypeName = "FLOAT")]
        public decimal? Workinghrs { get; set; }
        [Column("TOTALKMS", TypeName = "FLOAT")]
        public decimal? Totalkms { get; set; }
        [Column("CALCULATEDAMOUNT", TypeName = "NUMBER(12,2)")]
        public decimal? Calculatedamount { get; set; }
        [Column("DATECREATED", TypeName = "DATE")]
        public DateTime? Datecreated { get; set; }
        [Column("QUALIFIED")]
        public bool? Qualified { get; set; }
        [Column("COMMENTS")]
        [StringLength(500)]
        public string Comments { get; set; }
        [Column("STATUS")]
        [StringLength(100)]
        public string Status { get; set; }
        [Column("DATEUPDATED", TypeName = "DATE")]
        public DateTime? Dateupdated { get; set; }
        [Column("SPID")]
        [StringLength(1000)]
        public string Spid { get; set; }
        [Column("TRANSACTIONID", TypeName = "NUMBER")]
        public decimal? Transactionid { get; set; }
        [Column("ACTIVITYDATE", TypeName = "DATE")]
        public DateTime? Activitydate { get; set; }
        [Column("GROUPVARIANTGUID")]
        [StringLength(36)]
        public string Groupvariantguid { get; set; }
        [Column("MINWORKINGHOURSPERDAY", TypeName = "NUMBER")]
        public decimal? Minworkinghoursperday { get; set; }
        [Column("PERDAYPACKAGEAMOUNT", TypeName = "NUMBER")]
        public decimal? Perdaypackageamount { get; set; }
        [Column("PERDAYPACKAGEKM", TypeName = "NUMBER")]
        public decimal? Perdaypackagekm { get; set; }
        [Column("MINWORKINGDAYSFORQUALIFYING", TypeName = "NUMBER")]
        public decimal? Minworkingdaysforqualifying { get; set; }
        [Column("RATEPERKMNONQUALIFIED", TypeName = "NUMBER")]
        public decimal? Rateperkmnonqualified { get; set; }
        [Column("SCHEMEDAYS", TypeName = "NUMBER")]
        public decimal? Schemedays { get; set; }
        [Column("ISPRORATA", TypeName = "NUMBER")]
        public decimal? Isprorata { get; set; }
        [Column("TOTALQALIFYDAYS", TypeName = "NUMBER")]
        public decimal? Totalqalifydays { get; set; }
        [Column("TOTALNONQALIFYDAYS", TypeName = "NUMBER")]
        public decimal? Totalnonqalifydays { get; set; }
        [Column("TOTALWORKINGDAYS", TypeName = "NUMBER")]
        public decimal? Totalworkingdays { get; set; }
        [Column("TOTALEXTRAKM", TypeName = "NUMBER")]
        public decimal? Totalextrakm { get; set; }
        [Column("RATEPEREXTRAKM", TypeName = "NUMBER")]
        public decimal? Rateperextrakm { get; set; }
        [Column("TOTALEXTRAAMOUNTPAID", TypeName = "NUMBER")]
        public decimal? Totalextraamountpaid { get; set; }
        [Column("ACTUALAMTTOPAY", TypeName = "NUMBER")]
        public decimal? Actualamttopay { get; set; }
        [Column("SITESTARTDATE", TypeName = "DATE")]
        public DateTime? Sitestartdate { get; set; }
        [Column("TOTALAMOUNTALREADYPAID", TypeName = "NUMBER")]
        public decimal? Totalamountalreadypaid { get; set; }
        [Column("TOTALQUALIFIEDKMS", TypeName = "NUMBER")]
        public decimal? Totalqualifiedkms { get; set; }
        [Column("TOTALNONQUALIFIEDKMS", TypeName = "NUMBER")]
        public decimal? Totalnonqualifiedkms { get; set; }
        [Column("TOTALQUALIFIEDHRS", TypeName = "NUMBER")]
        public decimal? Totalqualifiedhrs { get; set; }
        [Column("TOTALNONQUALIFIEDHRS", TypeName = "NUMBER")]
        public decimal? Totalnonqualifiedhrs { get; set; }
        [Column("PACKAGEAMOUNT", TypeName = "NUMBER")]
        public decimal? Packageamount { get; set; }
        [Column("KMAMOUNT", TypeName = "NUMBER")]
        public decimal? Kmamount { get; set; }
        [Column("MONTHOFCALCULATION", TypeName = "DATE")]
        public DateTime? Monthofcalculation { get; set; }
    }
}
