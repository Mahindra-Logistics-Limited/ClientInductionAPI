using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ClientInductionAPI.Models.CIModel
{
    [Keyless]
    public partial class PersonDocActionV
    {
        [Column("PERS_GUID")]
        [StringLength(36)]
        public string PersGuid { get; set; }
        [Column("PERSON_ID")]
        [StringLength(1000)]
        public string PersonId { get; set; }
        [Column("PERS_FNAME")]
        [StringLength(255)]
        public string PersFname { get; set; }
        [Column("PERS_MNAME")]
        [StringLength(255)]
        public string PersMname { get; set; }
        [Column("PERS_LNAME")]
        [StringLength(255)]
        public string PersLname { get; set; }
        [Column("DOC_NO")]
        [StringLength(255)]
        public string DocNo { get; set; }
        [Column("DOC_GUID")]
        [StringLength(36)]
        public string DocGuid { get; set; }
        [Column("DOC_VALIDITYENDDATE", TypeName = "DATE")]
        public DateTime? DocValidityenddate { get; set; }
        [Column("ACTION_CODE")]
        [StringLength(36)]
        public string ActionCode { get; set; }
        [Column("DOC_ACTION_DATECREATED", TypeName = "DATE")]
        public DateTime? DocActionDatecreated { get; set; }
        [Column("DOC_ACTION_PKGUID")]
        [StringLength(36)]
        public string DocActionPkguid { get; set; }
        [Column("DOC_TYPE")]
        [StringLength(50)]
        public string DocType { get; set; }
        [Column("ACTION_NUMBER", TypeName = "NUMBER")]
        public decimal? ActionNumber { get; set; }
        [Column("ACTION_NAME")]
        [StringLength(50)]
        public string ActionName { get; set; }
        [Column("ACTION_DESCRIPTION")]
        [StringLength(500)]
        public string ActionDescription { get; set; }
        [Column("MENTORID")]
        [StringLength(100)]
        public string Mentorid { get; set; }
    }
}
