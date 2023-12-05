using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ClientInductionAPI.Models.CIModel
{
    [Keyless]
    public partial class SearchtemplatemasterV
    {
        [Column("SEARCHTEMPLATEMASTERGUID")]
        [StringLength(36)]
        public string Searchtemplatemasterguid { get; set; }
        [Column("TEMPLATENAME")]
        [StringLength(100)]
        public string Templatename { get; set; }
        [Column("TEMPLATEDESCRIPTION")]
        [StringLength(1000)]
        public string Templatedescription { get; set; }
        [Column("STATUSENTITYGUID")]
        [StringLength(36)]
        public string Statusentityguid { get; set; }
        [Column("APPROVALENABLED")]
        [StringLength(1)]
        public string Approvalenabled { get; set; }
        [Column("APPROVALHIERARCHYID", TypeName = "NUMBER")]
        public decimal? Approvalhierarchyid { get; set; }
        [Column("TEMPLATETYPE")]
        [StringLength(20)]
        public string Templatetype { get; set; }
        [Column("TEMPLATETRANSACTIONTYPEID")]
        [StringLength(36)]
        public string Templatetransactiontypeid { get; set; }
        [Column("TRANSACTIONRESULTFORMULA")]
        [StringLength(500)]
        public string Transactionresultformula { get; set; }
        [Column("SUMMARYVIEWNAME")]
        [StringLength(200)]
        public string Summaryviewname { get; set; }
        [Column("SUMMARYVIEWTEXT")]
        [StringLength(2000)]
        public string Summaryviewtext { get; set; }
        [Column("VIEWNAME")]
        [StringLength(100)]
        public string Viewname { get; set; }
        [Column("VIEWTEXT")]
        public string Viewtext { get; set; }
        [Column("TYPENAME")]
        [StringLength(255)]
        public string Typename { get; set; }
        [Column("TYPE_CODE")]
        [StringLength(60)]
        public string TypeCode { get; set; }
        [Column("CLASS_CODE")]
        [StringLength(25)]
        public string ClassCode { get; set; }
    }
}
