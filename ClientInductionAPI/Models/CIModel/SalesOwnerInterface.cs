using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ClientInductionAPI.Models.CIModel
{
    [Table("SALES_OWNER_INTERFACE")]
    [Index(nameof(Mobilenumber), Name = "SALES_OWNERMOBILE_UK", IsUnique = true)]
    public partial class SalesOwnerInterface
    {
        public SalesOwnerInterface()
        {
            SalesCabqcInterfaces = new HashSet<SalesCabqcInterface>();
            SalesCarInterfaces = new HashSet<SalesCarInterface>();
            SalesDriverInterfaces = new HashSet<SalesDriverInterface>();
        }

        [Key]
        [Column("GUID")]
        [StringLength(36)]
        public string Guid { get; set; }
        [Column("PERSONFLAG")]
        [StringLength(10)]
        public string Personflag { get; set; }
        [Required]
        [Column("OWNERNAME")]
        [StringLength(100)]
        public string Ownername { get; set; }
        [Column("MOBILENUMBER", TypeName = "NUMBER")]
        public decimal Mobilenumber { get; set; }
        [Column("ADDRESS")]
        [StringLength(2000)]
        public string Address { get; set; }
        [Column("ORASTATUS")]
        [StringLength(100)]
        public string Orastatus { get; set; }
        [Column("STATUS")]
        [StringLength(100)]
        public string Status { get; set; }
        [Required]
        [Column("USERCREATED")]
        [StringLength(36)]
        public string Usercreated { get; set; }
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
        [Column("APIHITDATE", TypeName = "DATE")]
        public DateTime? Apihitdate { get; set; }
        [Column("AADHARCARDNO")]
        [StringLength(20)]
        public string Aadharcardno { get; set; }
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
        [Column("PANNO")]
        [StringLength(20)]
        public string Panno { get; set; }
        [Column("ACCNO")]
        [StringLength(100)]
        public string Accno { get; set; }
        [Column("IFSCCODE")]
        [StringLength(20)]
        public string Ifsccode { get; set; }
        [Column("BANKNAME")]
        [StringLength(50)]
        public string Bankname { get; set; }
        [Column("SPCLIENTMAPGUID")]
        [StringLength(36)]
        public string Spclientmapguid { get; set; }
        [Column("BUSINESSCATEGORYMASTERGUID")]
        [StringLength(36)]
        public string Businesscategorymasterguid { get; set; }

        [InverseProperty(nameof(SalesCabqcInterface.Ownergu))]
        public virtual ICollection<SalesCabqcInterface> SalesCabqcInterfaces { get; set; }
        [InverseProperty(nameof(SalesCarInterface.Ownergu))]
        public virtual ICollection<SalesCarInterface> SalesCarInterfaces { get; set; }
        [InverseProperty(nameof(SalesDriverInterface.Ownergu))]
        public virtual ICollection<SalesDriverInterface> SalesDriverInterfaces { get; set; }
    }
}
