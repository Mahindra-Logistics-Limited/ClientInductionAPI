using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ClientInductionAPI.Models.CIModel
{
    [Keyless]
    public partial class PersonPositionV
    {
        [Column("PERSON_TYPE")]
        [StringLength(8)]
        public string PersonType { get; set; }
        [Column("ID")]
        [StringLength(2000)]
        public string Id { get; set; }
        [Column("PERSON_ID", TypeName = "NUMBER")]
        public decimal? PersonId { get; set; }
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
    }
}
