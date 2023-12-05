using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ClientInductionAPI.Models.CIModel
{
    [Keyless]
    public partial class TrainingBatchV
    {
        [Required]
        [Column("TRAININGBATCHMASTERGUID")]
        [StringLength(36)]
        public string Trainingbatchmasterguid { get; set; }
        [Column("TRAININGDATETIME", TypeName = "DATE")]
        public DateTime Trainingdatetime { get; set; }
        [Required]
        [Column("TRAININGTYPEMASTERGUID")]
        [StringLength(36)]
        public string Trainingtypemasterguid { get; set; }
        [Required]
        [Column("TRAININGNAME")]
        [StringLength(500)]
        public string Trainingname { get; set; }
        [Required]
        [Column("TRAINERMASTERGUID")]
        [StringLength(36)]
        public string Trainermasterguid { get; set; }
        [Required]
        [Column("STATUSENTITYGUID")]
        [StringLength(36)]
        public string Statusentityguid { get; set; }
        [Column("TOTALMARKS", TypeName = "NUMBER(38)")]
        public decimal? Totalmarks { get; set; }
        [Column("ATTENDEETYPE")]
        [StringLength(100)]
        public string Attendeetype { get; set; }
        [Column("VALIDITYSTARTDATE", TypeName = "DATE")]
        public DateTime Validitystartdate { get; set; }
        [Column("VALIDITYENDDATE", TypeName = "DATE")]
        public DateTime? Validityenddate { get; set; }
        [Column("DISABLED")]
        public bool? Disabled { get; set; }
        [Column("ORACLEENTITYNAME")]
        [StringLength(100)]
        public string Oracleentityname { get; set; }
        [Column("ORACLEENTITYID")]
        [StringLength(1000)]
        public string Oracleentityid { get; set; }
        [Column("OBJECTVERSIONNO")]
        public int? Objectversionno { get; set; }
        [Column("TRAININGTOPIC")]
        [StringLength(100)]
        public string Trainingtopic { get; set; }
        [Column("REMARKS")]
        [StringLength(100)]
        public string Remarks { get; set; }
        [Column("TRAININGRESULT")]
        [StringLength(100)]
        public string Trainingresult { get; set; }
        [Column("ISATTENDED")]
        [StringLength(1)]
        public string Isattended { get; set; }
        [Column("PKGUID")]
        [StringLength(36)]
        public string Pkguid { get; set; }
        [Required]
        [Column("TRAININGTYPENAME")]
        [StringLength(255)]
        public string Trainingtypename { get; set; }
        [Column("TRAININGTYPEDESCRIPTION")]
        [StringLength(2000)]
        public string Trainingtypedescription { get; set; }
        [Column("TRAININGTYPEQUICKACCESSCODE")]
        [StringLength(25)]
        public string Trainingtypequickaccesscode { get; set; }
        [Column("TRAININGTYPECOMMENTS")]
        [StringLength(2000)]
        public string Trainingtypecomments { get; set; }
        [Column("TRAININGTYPEDISABLED")]
        public bool? Trainingtypedisabled { get; set; }
        [Column("TRAININGTYPEORACLEENTITYNAME")]
        [StringLength(100)]
        public string Trainingtypeoracleentityname { get; set; }
        [Column("TRAININGTYPEORACLEENTITYID")]
        [StringLength(1000)]
        public string Trainingtypeoracleentityid { get; set; }
        [Column("TRAININGTYPEOBJECTVERSIONNO")]
        public int? Trainingtypeobjectversionno { get; set; }
        [Column("TRAININGTYPEPKGUID")]
        [StringLength(36)]
        public string Trainingtypepkguid { get; set; }
        [Column("TRAINERSTATUSENTITYGUID")]
        [StringLength(1)]
        public string Trainerstatusentityguid { get; set; }
        [Column("TRAINEREFFECTIVESTARTDATE", TypeName = "DATE")]
        public DateTime Trainereffectivestartdate { get; set; }
        [Column("TRAINEREFFECTIVEENDDATE", TypeName = "DATE")]
        public DateTime Trainereffectiveenddate { get; set; }
        [Column("TRAINERDISABLED")]
        public bool? Trainerdisabled { get; set; }
        [Column("TRAINERORACLEENTITYNAME")]
        [StringLength(100)]
        public string Traineroracleentityname { get; set; }
        [Column("TRAINERORACLEENTITYID")]
        [StringLength(1000)]
        public string Traineroracleentityid { get; set; }
        [Column("TRAINEROBJECTVERSIONNO")]
        public int? Trainerobjectversionno { get; set; }
        [Column("TRAINERPKGUID")]
        [StringLength(36)]
        public string Trainerpkguid { get; set; }
        [Column("TRAINING_MAG_PER_TYPE")]
        [StringLength(1)]
        public string TrainingMagPerType { get; set; }
        [Column("TRAINING_MAG_ID")]
        public string TrainingMagId { get; set; }
        [Column("TRAINING_MAG_PER_ID")]
        [StringLength(1)]
        public string TrainingMagPerId { get; set; }
        [Column("TRAINING_MAG_EMP_NUM")]
        [StringLength(1)]
        public string TrainingMagEmpNum { get; set; }
        [Column("TRAINING_MAG_NPW_NUM")]
        [StringLength(1)]
        public string TrainingMagNpwNum { get; set; }
        [Column("TRAINING_MAG_FULL_NAME")]
        public string TrainingMagFullName { get; set; }
        [Column("TRAINING_MAG_ORG_ID")]
        [StringLength(1)]
        public string TrainingMagOrgId { get; set; }
        [Column("TRAINING_MAG_POSITION_NAME")]
        public string TrainingMagPositionName { get; set; }
        [Column("TRAINING_MAG_POSITION_ID")]
        [StringLength(1)]
        public string TrainingMagPositionId { get; set; }
        [Column("TRAINING_MAG_JOB_NAME")]
        public string TrainingMagJobName { get; set; }
        [Column("TRAINING_MAG_JOB_ID")]
        [StringLength(1)]
        public string TrainingMagJobId { get; set; }
        [Required]
        [Column("STATUS_ENT_STSGUID")]
        [StringLength(36)]
        public string StatusEntStsguid { get; set; }
        [Column("STATUS_ENT_ENTGUID")]
        [StringLength(36)]
        public string StatusEntEntguid { get; set; }
        [Column("STATUS_ENT_OBJ_VER_NO")]
        public int? StatusEntObjVerNo { get; set; }
        [Column("STATUS_CODE")]
        [StringLength(25)]
        public string StatusCode { get; set; }
        [Column("STATUS_NAME")]
        [StringLength(200)]
        public string StatusName { get; set; }
        [Column("STATUS_DESC")]
        [StringLength(1000)]
        public string StatusDesc { get; set; }
        [Column("ENTITY_CODE")]
        [StringLength(50)]
        public string EntityCode { get; set; }
        [Column("TOTALADDED", TypeName = "NUMBER")]
        public decimal? Totaladded { get; set; }
        [Column("TOTALATTENDED", TypeName = "NUMBER")]
        public decimal? Totalattended { get; set; }
    }
}
