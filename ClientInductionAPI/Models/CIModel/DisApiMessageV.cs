using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ClientInductionAPI.Models.CIModel
{
    [Keyless]
    public partial class DisApiMessageV
    {
        [Required]
        [Column("APIMASTERGUID")]
        [StringLength(36)]
        public string Apimasterguid { get; set; }
        [Required]
        [Column("APINAME")]
        [StringLength(255)]
        public string Apiname { get; set; }
        [Column("APIDESCRIPTION")]
        [StringLength(2000)]
        public string Apidescription { get; set; }
        [Column("APIQUICKACCESSCODE")]
        [StringLength(255)]
        public string Apiquickaccesscode { get; set; }
        [Column("DISAPIMESSAGEMASTERGUID")]
        [StringLength(36)]
        public string Disapimessagemasterguid { get; set; }
        [Column("STATUSCODE")]
        [StringLength(36)]
        public string Statuscode { get; set; }
        [Column("STATUS")]
        [StringLength(250)]
        public string Status { get; set; }
        [Column("MESSAGENUMBER")]
        [StringLength(36)]
        public string Messagenumber { get; set; }
        [Column("MESSAGE")]
        public string Message { get; set; }
    }
}
