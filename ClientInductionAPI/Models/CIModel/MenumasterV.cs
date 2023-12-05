using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ClientInductionAPI.Models.CIModel
{
    [Keyless]
    public partial class MenumasterV
    {
        [Required]
        [Column("MENUMASTERGUID")]
        [StringLength(36)]
        public string Menumasterguid { get; set; }
        [Required]
        [Column("MENUNAME")]
        [StringLength(200)]
        public string Menuname { get; set; }
        [Column("PARENTMENUGUID")]
        [StringLength(36)]
        public string Parentmenuguid { get; set; }
        [Column("APPLICATIONPAGEMASTERGUID")]
        [StringLength(36)]
        public string Applicationpagemasterguid { get; set; }
        [Column("MENUDESCRIPTION")]
        [StringLength(200)]
        public string Menudescription { get; set; }
        [Column("MENUQUICKACCESSCODE")]
        [StringLength(200)]
        public string Menuquickaccesscode { get; set; }
        [Column("MENUCOMMENTS")]
        [StringLength(200)]
        public string Menucomments { get; set; }
        [Column("MENUDISABLED")]
        public bool? Menudisabled { get; set; }
        [Column("MENUEFFECTIVESTARTDATE", TypeName = "DATE")]
        public DateTime Menueffectivestartdate { get; set; }
        [Column("MENUEFFECTIVEENDDATE", TypeName = "DATE")]
        public DateTime? Menueffectiveenddate { get; set; }
        [Column("MENUORACLEENTITYNAME")]
        [StringLength(100)]
        public string Menuoracleentityname { get; set; }
        [Column("MENUORACLEENTITYID")]
        [StringLength(1000)]
        public string Menuoracleentityid { get; set; }
        [Column("MENUOBJECTVERSIONNO")]
        public int? Menuobjectversionno { get; set; }
        [Column("ORDERNO")]
        public int? Orderno { get; set; }
        [Column("PKGUID")]
        [StringLength(36)]
        public string Pkguid { get; set; }
        [Column("APP_PAGE_EFFECTIVESTARTDATE", TypeName = "DATE")]
        public DateTime AppPageEffectivestartdate { get; set; }
        [Column("APP_PAGE_EFFECTIVEENDDATE", TypeName = "DATE")]
        public DateTime AppPageEffectiveenddate { get; set; }
        [Required]
        [Column("APP_PAGE_NAME")]
        [StringLength(200)]
        public string AppPageName { get; set; }
        [Column("APP_PAGE_DESCRIPTION")]
        [StringLength(1000)]
        public string AppPageDescription { get; set; }
        [Column("APP_PAGE_QUICKACCESSCODE")]
        [StringLength(100)]
        public string AppPageQuickaccesscode { get; set; }
        [Column("APP_PAGE_COMMENTS")]
        [StringLength(1000)]
        public string AppPageComments { get; set; }
        [Column("APP_PAGE_DISABLED")]
        public bool? AppPageDisabled { get; set; }
        [Column("APP_PAGE_ORACLEENTITYNAME")]
        [StringLength(100)]
        public string AppPageOracleentityname { get; set; }
        [Column("APP_PAGE_ORACLEENTITYID")]
        [StringLength(1000)]
        public string AppPageOracleentityid { get; set; }
        [Column("APP_PAGE_OBJECTVERSIONNO")]
        public int? AppPageObjectversionno { get; set; }
        [Column("APP_PAGE_PKGUID")]
        [StringLength(36)]
        public string AppPagePkguid { get; set; }
    }
}
