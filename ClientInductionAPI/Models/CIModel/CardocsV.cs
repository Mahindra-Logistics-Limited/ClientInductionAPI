using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ClientInductionAPI.Models.CIModel
{
    [Keyless]
    public partial class CardocsV
    {
        [Column("DOC_GUID")]
        [StringLength(36)]
        public string DocGuid { get; set; }
        [Column("DOC_NO")]
        [StringLength(255)]
        public string DocNo { get; set; }
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
        [Column("DOC_TYPE_CODE")]
        [StringLength(25)]
        public string DocTypeCode { get; set; }
        [Column("DOC_TYPE")]
        [StringLength(255)]
        public string DocType { get; set; }
        [Column("CAR_GUID")]
        [StringLength(36)]
        public string CarGuid { get; set; }
        [Column("CAR_REGN_NO")]
        [StringLength(255)]
        public string CarRegnNo { get; set; }
        [Column("CAR_STATUS")]
        [StringLength(25)]
        public string CarStatus { get; set; }
        [Column("CAR_SEC_GUID")]
        [StringLength(36)]
        public string CarSecGuid { get; set; }
        [Column("CAR_LE_BRANCH_GUID")]
        [StringLength(36)]
        public string CarLeBranchGuid { get; set; }
        [Column("RENEWALDAYS")]
        public int? Renewaldays { get; set; }
        [Column("ESCALATIONDAYS")]
        public int? Escalationdays { get; set; }
        [Column("DOCUMENTTYPEENTITYGUID")]
        [StringLength(36)]
        public string Documenttypeentityguid { get; set; }
        [Column("STATUSENTITYGUID")]
        [StringLength(36)]
        public string Statusentityguid { get; set; }
        [Column("DOCUMENTTYPECATEGORYGUID")]
        [StringLength(36)]
        public string Documenttypecategoryguid { get; set; }
    }
}
