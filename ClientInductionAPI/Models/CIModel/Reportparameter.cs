using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ClientInductionAPI.Models.CIModel
{
    [Keyless]
    [Table("REPORTPARAMETERS")]
    public partial class Reportparameter
    {
        [Column("REP_PARAM_GUID")]
        [StringLength(36)]
        public string RepParamGuid { get; set; }
        [Column("REP_ID")]
        [StringLength(36)]
        public string RepId { get; set; }
        [Column("PARAM_COL_NAME")]
        [StringLength(100)]
        public string ParamColName { get; set; }
        [Column("PARAM_COL_DISPLAY_NAME")]
        [StringLength(100)]
        public string ParamColDisplayName { get; set; }
        [Column("PARAM_COL_DEFAULT_VALUE")]
        [StringLength(100)]
        public string ParamColDefaultValue { get; set; }
        [Column("PARAM_TYPE")]
        [StringLength(100)]
        public string ParamType { get; set; }
        [Column("PARAM_VALIDATION_VIEWNAME")]
        [StringLength(1000)]
        public string ParamValidationViewname { get; set; }
        [Column("PARAM_MASTER_ID", TypeName = "NUMBER(38)")]
        public decimal? ParamMasterId { get; set; }
        [Column("DISPLAY_DATATYPE")]
        [StringLength(100)]
        public string DisplayDatatype { get; set; }
        [Column("PARAMETER_SEQUENCE", TypeName = "NUMBER")]
        public decimal? ParameterSequence { get; set; }
        [Column("USERCREATED")]
        [StringLength(36)]
        public string Usercreated { get; set; }
        [Column("DATECREATED", TypeName = "DATE")]
        public DateTime? Datecreated { get; set; }
        [Column("USERUPDATED")]
        [StringLength(36)]
        public string Userupdated { get; set; }
        [Column("DATEUPDATED", TypeName = "DATE")]
        public DateTime? Dateupdated { get; set; }
    }
}
