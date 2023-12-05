using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ClientInductionAPI.Models.CIModel
{
    [Table("SALES_OWNER_INTERFACE_V3")]
    [Index(nameof(Mobilenumber), Name = "SALES_OWNER_INTERFACE_V3_MOBILENUMBER")]
    public partial class SalesOwnerInterfaceV3
    {
        [Key]
        [Column("GUID")]
        [StringLength(36)]
        public string Guid { get; set; }
        [Column("PERSONFLAG")]
        [StringLength(10)]
        public string Personflag { get; set; }
        [Column("FLEETOWNERFLAG")]
        [StringLength(10)]
        public string Fleetownerflag { get; set; }
        [Required]
        [Column("OWNERNAME")]
        [StringLength(100)]
        public string Ownername { get; set; }
        [Column("ADDRESS")]
        [StringLength(2000)]
        public string Address { get; set; }
        [Column("STATUS")]
        [StringLength(100)]
        public string Status { get; set; }
        [Column("OWNERID")]
        [StringLength(36)]
        public string Ownerid { get; set; }
        [Column("DATECREATED", TypeName = "DATE")]
        public DateTime Datecreated { get; set; }
        [Column("USERUPDATED")]
        [StringLength(36)]
        public string Userupdated { get; set; }
        [Column("DATEUPDATED", TypeName = "DATE")]
        public DateTime? Dateupdated { get; set; }
        [Column("EMAIL_ID")]
        [StringLength(100)]
        public string EmailId { get; set; }
        [Column("DATASUBMITTED")]
        public bool? Datasubmitted { get; set; }
        [Column("STARTDATE", TypeName = "DATE")]
        public DateTime? Startdate { get; set; }
        [Column("ENDDATE", TypeName = "DATE")]
        public DateTime? Enddate { get; set; }
        [Column("DATEOFBIRTH", TypeName = "DATE")]
        public DateTime? Dateofbirth { get; set; }
        [Column("ADDRESSLINE1")]
        [StringLength(255)]
        public string Addressline1 { get; set; }
        [Column("ADDRESSLINE2")]
        [StringLength(255)]
        public string Addressline2 { get; set; }
        [Column("MOBILENUMBER")]
        [StringLength(20)]
        public string Mobilenumber { get; set; }
    }
}
