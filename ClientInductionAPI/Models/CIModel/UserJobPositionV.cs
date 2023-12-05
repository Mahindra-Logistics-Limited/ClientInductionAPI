using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ClientInductionAPI.Models.CIModel
{
    [Keyless]
    public partial class UserJobPositionV
    {
        [Required]
        [Column("USERGUID")]
        [StringLength(36)]
        public string Userguid { get; set; }
        [Required]
        [Column("EMAIL")]
        [StringLength(2000)]
        public string Email { get; set; }
        [Column("LOGIN_FULLNAME")]
        public string LoginFullname { get; set; }
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
        [Column("PERSON_FULL_NAME")]
        public string PersonFullName { get; set; }
        [Column("PERSON_TYPE")]
        [StringLength(8)]
        public string PersonType { get; set; }
        [Column("ID")]
        [StringLength(2000)]
        public string Id { get; set; }
        [Column("EMPLOYEE_NUMBER")]
        [StringLength(2000)]
        public string EmployeeNumber { get; set; }
        [Column("NPW_NUMBER")]
        [StringLength(2000)]
        public string NpwNumber { get; set; }
        [Column("FULL_NAME")]
        public string FullName { get; set; }
        [Column("ORGANIZATION_ID")]
        [StringLength(2000)]
        public string OrganizationId { get; set; }
        [Column("POSITION_NAME")]
        [StringLength(2000)]
        public string PositionName { get; set; }
        [Column("POSITION_ID")]
        [StringLength(2000)]
        public string PositionId { get; set; }
        [Column("JOB_NAME")]
        [StringLength(2000)]
        public string JobName { get; set; }
        [Column("JOB_ID")]
        [StringLength(2000)]
        public string JobId { get; set; }
        [Required]
        [Column("LEBRANCH_GUID")]
        [StringLength(36)]
        public string LebranchGuid { get; set; }
        [Required]
        [Column("LE_GUID")]
        [StringLength(36)]
        public string LeGuid { get; set; }
        [Required]
        [Column("LE_NAME")]
        [StringLength(200)]
        public string LeName { get; set; }
        [Column("LE_CODE")]
        [StringLength(200)]
        public string LeCode { get; set; }
        [Required]
        [Column("BRANCH_GUID")]
        [StringLength(36)]
        public string BranchGuid { get; set; }
        [Required]
        [Column("BRANCH_NAME")]
        [StringLength(200)]
        public string BranchName { get; set; }
        [Column("BRANCH_CODE")]
        [StringLength(100)]
        public string BranchCode { get; set; }
        [Column("ORG_ID")]
        public byte? OrgId { get; set; }
        [Column("GL_SEGMENT1")]
        [StringLength(1000)]
        public string GlSegment1 { get; set; }
        [Column("LEB_OBJ_VER_NO")]
        public int? LebObjVerNo { get; set; }
    }
}
