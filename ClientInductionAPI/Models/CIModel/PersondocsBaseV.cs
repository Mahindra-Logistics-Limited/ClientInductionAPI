﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ClientInductionAPI.Models.CIModel
{
    [Keyless]
    public partial class PersondocsBaseV
    {
        [Required]
        [Column("DOC_GUID")]
        [StringLength(36)]
        public string DocGuid { get; set; }
        [Required]
        [Column("DOC_NO")]
        [StringLength(255)]
        public string DocNo { get; set; }
        [Required]
        [Column("DOC_FILE_NAME")]
        [StringLength(255)]
        public string DocFileName { get; set; }
        [Column("DOC_VALID_FROM", TypeName = "DATE")]
        public DateTime? DocValidFrom { get; set; }
        [Column("DOC_VALID_TILL", TypeName = "DATE")]
        public DateTime? DocValidTill { get; set; }
        [Column("DOC_OBJ_VER_NO")]
        public int? DocObjVerNo { get; set; }
        [Column("DOC_DOCUMENTPATH")]
        public string DocDocumentpath { get; set; }
        [Column("DOC_STATUS_CODE")]
        [StringLength(25)]
        public string DocStatusCode { get; set; }
        [Column("DOC_STATUS_NAME")]
        [StringLength(200)]
        public string DocStatusName { get; set; }
        [Required]
        [Column("DOC_PURPOSE_CODE")]
        [StringLength(25)]
        public string DocPurposeCode { get; set; }
        [Required]
        [Column("DOC_PURPOSE")]
        [StringLength(255)]
        public string DocPurpose { get; set; }
        [Column("DOC_TYPE_CODE")]
        [StringLength(25)]
        public string DocTypeCode { get; set; }
        [Required]
        [Column("DOC_TYPE")]
        [StringLength(255)]
        public string DocType { get; set; }
        [Required]
        [Column("PERS_GUID")]
        [StringLength(36)]
        public string PersGuid { get; set; }
        [Required]
        [Column("PERSON_ID")]
        [StringLength(1000)]
        public string PersonId { get; set; }
        [Required]
        [Column("PERS_FNAME")]
        [StringLength(255)]
        public string PersFname { get; set; }
        [Column("PERS_MNAME")]
        [StringLength(255)]
        public string PersMname { get; set; }
        [Required]
        [Column("PERS_LNAME")]
        [StringLength(255)]
        public string PersLname { get; set; }
        [Column("RENEWALDAYS")]
        public int? Renewaldays { get; set; }
        [Column("ESCALATIONDAYS")]
        public int? Escalationdays { get; set; }
        [Required]
        [Column("DOCUMENTTYPEENTITYGUID")]
        [StringLength(36)]
        public string Documenttypeentityguid { get; set; }
        [Column("STATUSENTITYGUID")]
        [StringLength(36)]
        public string Statusentityguid { get; set; }
        [Column("DOCUMENTTYPEPURPOSEGUID")]
        [StringLength(36)]
        public string Documenttypepurposeguid { get; set; }
    }
}
