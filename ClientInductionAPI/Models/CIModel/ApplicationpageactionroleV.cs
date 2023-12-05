using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ClientInductionAPI.Models.CIModel
{
    [Keyless]
    public partial class ApplicationpageactionroleV
    {
        [Required]
        [Column("APPLICATIONPAGEACTIONROLEGUID")]
        [StringLength(36)]
        public string Applicationpageactionroleguid { get; set; }
        [Required]
        [Column("APPLICATIONPAGEACTIONGUID")]
        [StringLength(36)]
        public string Applicationpageactionguid { get; set; }
        [Required]
        [Column("ROLEGUID")]
        [StringLength(36)]
        public string Roleguid { get; set; }
        [Required]
        [Column("APPLICATIONPAGEMASTERGUID")]
        [StringLength(36)]
        public string Applicationpagemasterguid { get; set; }
        [Required]
        [Column("PAGEACTIONMASTERGUID")]
        [StringLength(36)]
        public string Pageactionmasterguid { get; set; }
        [Required]
        [Column("APPLICATIONPAGEMASTERNAME")]
        [StringLength(200)]
        public string Applicationpagemastername { get; set; }
        [Column("APPLICATIONPAGEMASTER_CODE")]
        [StringLength(100)]
        public string ApplicationpagemasterCode { get; set; }
        [Column("PAGEACTIONMASTER_NAME")]
        [StringLength(200)]
        public string PageactionmasterName { get; set; }
        [Column("PAGEACTIONMASTER_CODE")]
        [StringLength(100)]
        public string PageactionmasterCode { get; set; }
        [Required]
        [Column("ROLEMASTER_NAME")]
        [StringLength(200)]
        public string RolemasterName { get; set; }
        [Required]
        [Column("ROLEMASTER_CODE")]
        [StringLength(100)]
        public string RolemasterCode { get; set; }
    }
}
