using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ClientInductionAPI.Models.CIModel
{
    [Table("DIS_POSTEDDOC_TBL")]
    [Index(nameof(Carno), nameof(Doctypename), Name = "DOC_CARNO_IND")]
    [Index(nameof(Personid), nameof(Doctypename), Name = "DOC_PERSONID_IND")]
    public partial class DisPosteddocTbl
    {
        [Key]
        [Column("DOCUMNETSRNO", TypeName = "NUMBER")]
        public decimal Documnetsrno { get; set; }
        [Column("DOCTYPE")]
        [StringLength(36)]
        public string Doctype { get; set; }
        [Column("PERSONID")]
        [StringLength(36)]
        public string Personid { get; set; }
        [Column("CARNO")]
        [StringLength(36)]
        public string Carno { get; set; }
        [Column("DOCTYPENAME")]
        [StringLength(200)]
        public string Doctypename { get; set; }
        [Column("DOCPATH")]
        [StringLength(2000)]
        public string Docpath { get; set; }
        [Column("ATTRIBUTE1")]
        [StringLength(36)]
        public string Attribute1 { get; set; }
        [Column("ATTRIBUTE2")]
        [StringLength(36)]
        public string Attribute2 { get; set; }
        [Column("ATTRIBUTE3")]
        [StringLength(36)]
        public string Attribute3 { get; set; }
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
        [StringLength(36)]
        public string Status { get; set; }
        [Column("MENTOR")]
        [StringLength(36)]
        public string Mentor { get; set; }
        [Column("MENTOROPERATIONSTATUS")]
        [StringLength(36)]
        public string Mentoroperationstatus { get; set; }
        [Column("BANKBENEFICIARYNAME")]
        [StringLength(365)]
        public string Bankbeneficiaryname { get; set; }
        [Column("BANKACCOUNTNO")]
        [StringLength(250)]
        public string Bankaccountno { get; set; }
        [Column("BANKIFSCCODE")]
        [StringLength(250)]
        public string Bankifsccode { get; set; }
    }
}
