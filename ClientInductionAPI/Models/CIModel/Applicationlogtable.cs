using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ClientInductionAPI.Models.CIModel
{
    [Keyless]
    [Table("APPLICATIONLOGTABLE")]
    public partial class Applicationlogtable
    {
        [Column("SEQ_NUM", TypeName = "NUMBER(38)")]
        public decimal? SeqNum { get; set; }
        [Column("TIMEELAPSED", TypeName = "NUMBER(38)")]
        public decimal? Timeelapsed { get; set; }
        [Column("MESSAGE")]
        public string Message { get; set; }
        [Column("DATETIME", TypeName = "DATE")]
        public DateTime? Datetime { get; set; }
        [Column("CONTROLLERNAME")]
        [StringLength(50)]
        public string Controllername { get; set; }
        [Column("ACTIONMETHODNAME")]
        [StringLength(50)]
        public string Actionmethodname { get; set; }
        [Column("USERNAME")]
        [StringLength(50)]
        public string Username { get; set; }
        [Column("FILENAME")]
        public string Filename { get; set; }
        [Column("FILECOLUMNNUMBER", TypeName = "NUMBER(38)")]
        public decimal? Filecolumnnumber { get; set; }
        [Column("FILELINENUMBER", TypeName = "NUMBER(38)")]
        public decimal? Filelinenumber { get; set; }
        [Column("EXECUTIONGUID")]
        [StringLength(36)]
        public string Executionguid { get; set; }
        [Column("SESSIONID")]
        [StringLength(1000)]
        public string Sessionid { get; set; }
    }
}
