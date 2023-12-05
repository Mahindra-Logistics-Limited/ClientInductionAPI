using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ClientInductionAPI.Models.CIModel
{
    [Keyless]
    public partial class UserBaseV
    {
        [Required]
        [Column("USERGUID")]
        [StringLength(36)]
        public string Userguid { get; set; }
        [Required]
        [Column("USEREMAIL")]
        [StringLength(2000)]
        public string Useremail { get; set; }
        [Column("LOGINFULLNAME")]
        public string Loginfullname { get; set; }
        [Column("USER_PKGUID")]
        [StringLength(36)]
        public string UserPkguid { get; set; }
        [Column("USER_ID")]
        [StringLength(2000)]
        public string UserId { get; set; }
        [Column("USER_NAME")]
        [StringLength(2000)]
        public string UserName { get; set; }
        [Column("EMPLOYEE_ID")]
        [StringLength(2000)]
        public string EmployeeId { get; set; }
        [Required]
        [Column("EMAIL_ADDRESS")]
        [StringLength(2000)]
        public string EmailAddress { get; set; }
        [Column("PERSON_ID", TypeName = "NUMBER")]
        public decimal? PersonId { get; set; }
        [Column("FULL_NAME")]
        public string FullName { get; set; }
    }
}
