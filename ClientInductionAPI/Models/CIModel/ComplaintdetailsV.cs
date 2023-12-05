using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ClientInductionAPI.Models.CIModel
{
    [Keyless]
    public partial class ComplaintdetailsV
    {
        [Required]
        [Column("COMPLAINTPRAGATIGUID")]
        [StringLength(36)]
        public string Complaintpragatiguid { get; set; }
        [Required]
        [Column("COMPLAINTID")]
        [StringLength(11)]
        public string Complaintid { get; set; }
        [Required]
        [Column("COMPLAINTTYPE")]
        [StringLength(30)]
        public string Complainttype { get; set; }
        [Column("COMPLAINTDATE", TypeName = "DATE")]
        public DateTime Complaintdate { get; set; }
        [Column("COMPLAINTSUBJECT")]
        [StringLength(250)]
        public string Complaintsubject { get; set; }
        [Column("COMPLAINTBODY")]
        public string Complaintbody { get; set; }
        [Column("CUSTOMERMOBILE")]
        [StringLength(100)]
        public string Customermobile { get; set; }
        [Column("CUSTOMEREMAILID")]
        [StringLength(100)]
        public string Customeremailid { get; set; }
        [Required]
        [Column("COMPLAINTINCOMMINGCATEGORY")]
        [StringLength(255)]
        public string Complaintincommingcategory { get; set; }
        [Column("COMPLAINTSOURCE")]
        [StringLength(255)]
        public string Complaintsource { get; set; }
        [Column("STATUS")]
        [StringLength(255)]
        public string Status { get; set; }
        [Column("SPID")]
        [StringLength(1000)]
        public string Spid { get; set; }
        [Column("SP_FULLNAME")]
        [StringLength(767)]
        public string SpFullname { get; set; }
        [Column("SP_STATUS")]
        [StringLength(9)]
        public string SpStatus { get; set; }
        [Column("DRIVERID")]
        [StringLength(1000)]
        public string Driverid { get; set; }
        [Column("DRIVER_NAME")]
        [StringLength(767)]
        public string DriverName { get; set; }
        [Column("USERGUID")]
        [StringLength(36)]
        public string Userguid { get; set; }
        [Column("USER_ID")]
        [StringLength(2000)]
        public string UserId { get; set; }
        [Column("CARMASTERGUID")]
        [StringLength(36)]
        public string Carmasterguid { get; set; }
        [Column("SERVICEPROVIDERGUID")]
        [StringLength(36)]
        public string Serviceproviderguid { get; set; }
        [Column("DRIVERMASTERGUID")]
        [StringLength(36)]
        public string Drivermasterguid { get; set; }
        [Column("COMPLAINTINCOMMINGCATEGORYGUID")]
        [StringLength(36)]
        public string Complaintincommingcategoryguid { get; set; }
        [Column("COMPLAINTCATEGORYMASTERGUID")]
        [StringLength(36)]
        public string Complaintcategorymasterguid { get; set; }
        [Column("JOBID")]
        [StringLength(15)]
        public string Jobid { get; set; }
        [Column("ASSIGNEDTOPERSONID")]
        public int? Assignedtopersonid { get; set; }
        [Column("DRIVERRATING", TypeName = "NUMBER(2,1)")]
        public decimal? Driverrating { get; set; }
        [Required]
        [Column("SUGGESTEDACTIONGUID")]
        [StringLength(36)]
        public string Suggestedactionguid { get; set; }
        [Column("ACTUALACTIONGUID")]
        [StringLength(36)]
        public string Actualactionguid { get; set; }
        [Column("ACTIONSTATUSGUID")]
        [StringLength(36)]
        public string Actionstatusguid { get; set; }
        [Column("COMMENTS")]
        [StringLength(2000)]
        public string Comments { get; set; }
        [Column("COMPLAINTSOURCEGUID")]
        [StringLength(36)]
        public string Complaintsourceguid { get; set; }
        [Required]
        [Column("COMPLAINTNAME")]
        [StringLength(255)]
        public string Complaintname { get; set; }
        [Required]
        [Column("COMPLAINTLEVEL")]
        [StringLength(25)]
        public string Complaintlevel { get; set; }
        [Column("COMPLAINTDESCRIPTION")]
        [StringLength(2000)]
        public string Complaintdescription { get; set; }
        [Column("COMPLAINTQUICKACCESSCODE")]
        [StringLength(25)]
        public string Complaintquickaccesscode { get; set; }
        [Column("CARREGISTRATIONNO")]
        [StringLength(255)]
        public string Carregistrationno { get; set; }
        [Column("CAR_SEC_GUID")]
        [StringLength(36)]
        public string CarSecGuid { get; set; }
        [Required]
        [Column("LE_GUID")]
        [StringLength(36)]
        public string LeGuid { get; set; }
        [Column("LE_CODE")]
        [StringLength(200)]
        public string LeCode { get; set; }
        [Required]
        [Column("LE_NAME")]
        [StringLength(200)]
        public string LeName { get; set; }
        [Required]
        [Column("CITY_GUID")]
        [StringLength(36)]
        public string CityGuid { get; set; }
        [Column("CITY_CODE")]
        [StringLength(100)]
        public string CityCode { get; set; }
        [Required]
        [Column("CITY_NAME")]
        [StringLength(200)]
        public string CityName { get; set; }
        [Column("BRAND_GUID")]
        [StringLength(36)]
        public string BrandGuid { get; set; }
        [Column("BRAND_CODE")]
        [StringLength(200)]
        public string BrandCode { get; set; }
        [Column("BRAND_NAME")]
        [StringLength(200)]
        public string BrandName { get; set; }
        [Column("MODEL_GUID")]
        [StringLength(36)]
        public string ModelGuid { get; set; }
        [Column("MODEL_CODE")]
        [StringLength(200)]
        public string ModelCode { get; set; }
        [Column("MODEL_NAME")]
        [StringLength(200)]
        public string ModelName { get; set; }
        [Column("ADDITIONALDEBITAMOUNT", TypeName = "NUMBER")]
        public decimal? Additionaldebitamount { get; set; }
        [Column("ADDITIONALDEBITCOMMENTS")]
        [StringLength(2000)]
        public string Additionaldebitcomments { get; set; }
        [Required]
        [Column("COMPLAINT_PKGUID")]
        [StringLength(36)]
        public string ComplaintPkguid { get; set; }
        [Column("COMPLAINT_DATECREATED", TypeName = "DATE")]
        public DateTime ComplaintDatecreated { get; set; }
        [Column("PYTHONSERVERDATA")]
        public string Pythonserverdata { get; set; }
    }
}
