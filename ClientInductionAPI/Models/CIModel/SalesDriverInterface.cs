using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ClientInductionAPI.Models.CIModel
{
    [Table("SALES_DRIVER_INTERFACE")]
    public partial class SalesDriverInterface
    {
        public SalesDriverInterface()
        {
            SalesCardrivermappings = new HashSet<SalesCardrivermapping>();
        }

        [Key]
        [Column("GUID")]
        [StringLength(36)]
        public string Guid { get; set; }
        [Column("OWNERGUID")]
        [StringLength(36)]
        public string Ownerguid { get; set; }
        [Column("DRIVERNAME")]
        [StringLength(200)]
        public string Drivername { get; set; }
        [Column("MOBILENUMBER", TypeName = "NUMBER")]
        public decimal Mobilenumber { get; set; }
        [Required]
        [Column("USERCREATED")]
        [StringLength(36)]
        public string Usercreated { get; set; }
        [Column("DATECREATED", TypeName = "DATE")]
        public DateTime Datecreated { get; set; }
        [Column("USERUPDATED")]
        [StringLength(36)]
        public string Userupdated { get; set; }
        [Column("DATEUPDATED", TypeName = "DATE")]
        public DateTime? Dateupdated { get; set; }
        [Column("STATUS")]
        [StringLength(200)]
        public string Status { get; set; }
        [Column("DRIVERID")]
        [StringLength(36)]
        public string Driverid { get; set; }
        [Column("DEVICEHARDWAREID")]
        [StringLength(36)]
        public string Devicehardwareid { get; set; }
        [Column("ISSPCUMDRIVER", TypeName = "NUMBER")]
        public decimal? Isspcumdriver { get; set; }
        [Column("AADHARCARDNO")]
        [StringLength(20)]
        public string Aadharcardno { get; set; }
        [Column("ADDRESS")]
        [StringLength(2000)]
        public string Address { get; set; }
        [Column("AREA")]
        [StringLength(100)]
        public string Area { get; set; }
        [Column("DISTRICT")]
        [StringLength(50)]
        public string District { get; set; }
        [Column("STATE")]
        [StringLength(50)]
        public string State { get; set; }
        [Column("PINCODE")]
        [StringLength(100)]
        public string Pincode { get; set; }
        [Column("EMAILID")]
        [StringLength(100)]
        public string Emailid { get; set; }

        [ForeignKey(nameof(Ownerguid))]
        [InverseProperty(nameof(SalesOwnerInterface.SalesDriverInterfaces))]
        public virtual SalesOwnerInterface Ownergu { get; set; }
        [InverseProperty(nameof(SalesCardrivermapping.Drivergu))]
        public virtual ICollection<SalesCardrivermapping> SalesCardrivermappings { get; set; }
    }
}
