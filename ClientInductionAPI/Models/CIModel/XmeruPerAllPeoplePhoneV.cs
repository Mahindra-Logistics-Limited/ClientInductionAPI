using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ClientInductionAPI.Models.CIModel
{
    [Keyless]
    public partial class XmeruPerAllPeoplePhoneV
    {
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
        [Required]
        [Column("PHONE_NUMBER")]
        [StringLength(2000)]
        public string PhoneNumber { get; set; }
    }
}
