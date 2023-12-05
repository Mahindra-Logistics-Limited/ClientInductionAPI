using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ClientInductionAPI.Models.CIModel
{
    [Keyless]
    public partial class SchparameterValuesV
    {
        [Column("PARAMETERGUID")]
        [StringLength(36)]
        public string Parameterguid { get; set; }
        [Column("PROGRAMGUID")]
        [StringLength(36)]
        public string Programguid { get; set; }
        [Column("PARAMETERNAME")]
        [StringLength(100)]
        public string Parametername { get; set; }
        [Column("DATATYPE")]
        [StringLength(100)]
        public string Datatype { get; set; }
        [Column("PAR_OPTIONAL", TypeName = "NUMBER")]
        public decimal? ParOptional { get; set; }
        [Column("VALUESETTYPE")]
        [StringLength(1000)]
        public string Valuesettype { get; set; }
        [Column("PAR_SEQUENCE", TypeName = "NUMBER")]
        public decimal? ParSequence { get; set; }
        [Column("PAR_DIRECTION")]
        [StringLength(10)]
        public string ParDirection { get; set; }
        [Column("VALUESETGUID")]
        [StringLength(36)]
        public string Valuesetguid { get; set; }
        [Column("VALUSETVALUE")]
        public string Valusetvalue { get; set; }
    }
}
