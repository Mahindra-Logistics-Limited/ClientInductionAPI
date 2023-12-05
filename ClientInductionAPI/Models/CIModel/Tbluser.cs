using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ClientInductionAPI.Models.CIModel
{
    [Keyless]
    [Table("TBLUSER")]
    public partial class Tbluser
    {
        [Required]
        [Column("FIRST")]
        [StringLength(20)]
        public string First { get; set; }
        [Required]
        [Column("LAST")]
        [StringLength(20)]
        public string Last { get; set; }
        [Required]
        [Column("USERNAME")]
        [StringLength(20)]
        public string Username { get; set; }
        [Required]
        [Column("USER_PASSWORD")]
        [StringLength(20)]
        public string UserPassword { get; set; }
        [Required]
        [Column("EMAIL")]
        [StringLength(20)]
        public string Email { get; set; }
    }
}
