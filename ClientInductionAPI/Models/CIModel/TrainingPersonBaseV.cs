using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ClientInductionAPI.Models.CIModel
{
    [Keyless]
    public partial class TrainingPersonBaseV
    {
        [Required]
        [Column("TRAININGATTENDEEGUID")]
        [StringLength(36)]
        public string Trainingattendeeguid { get; set; }
        [Required]
        [Column("PERSONMASTERGUID")]
        [StringLength(36)]
        public string Personmasterguid { get; set; }
        [Required]
        [Column("TRAININGBATCHMASTERGUID")]
        [StringLength(36)]
        public string Trainingbatchmasterguid { get; set; }
        [Column("ISATTENDED")]
        [StringLength(1)]
        public string Isattended { get; set; }
        [Column("OBTAINEDMARKS")]
        [StringLength(10)]
        public string Obtainedmarks { get; set; }
        [Column("TRAININGRESULT")]
        [StringLength(500)]
        public string Trainingresult { get; set; }
        [Column("REMARKS")]
        [StringLength(1000)]
        public string Remarks { get; set; }
        [Column("ATTENDEORACLEENTITYNAME")]
        [StringLength(100)]
        public string Attendeoracleentityname { get; set; }
        [Column("ATTENDEORACLEENTITYID")]
        [StringLength(1000)]
        public string Attendeoracleentityid { get; set; }
        [Column("ATTENDEOBJECTVERSIONNO")]
        public int? Attendeobjectversionno { get; set; }
        [Column("ATTENDEVALIDITYSTARTDATE", TypeName = "DATE")]
        public DateTime? Attendevaliditystartdate { get; set; }
        [Column("ATTENDEVALIDITYENDDATE", TypeName = "DATE")]
        public DateTime? Attendevalidityenddate { get; set; }
        [Column("TRAININGATTENDEEPKGUID")]
        [StringLength(36)]
        public string Trainingattendeepkguid { get; set; }
        [Required]
        [Column("PERSONID")]
        [StringLength(1000)]
        public string Personid { get; set; }
        [Required]
        [Column("PERS_TITLE")]
        [StringLength(10)]
        public string PersTitle { get; set; }
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
        [Column("PERS_GENDER")]
        [StringLength(10)]
        public string PersGender { get; set; }
        [Column("PERS_DOB", TypeName = "DATE")]
        public DateTime PersDob { get; set; }
        [Required]
        [Column("PERS_BIOID")]
        [StringLength(255)]
        public string PersBioid { get; set; }
        [Column("PERS_DSEFLAG")]
        public bool? PersDseflag { get; set; }
        [Column("PERS_SPFLAG")]
        public bool? PersSpflag { get; set; }
        [Column("PERS_DRIVERFLAG")]
        public bool? PersDriverflag { get; set; }
        [Column("PERS_STATUS_CODE")]
        [StringLength(25)]
        public string PersStatusCode { get; set; }
        [Column("PERS_OBJ_VER_NO")]
        public int? PersObjVerNo { get; set; }
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
        [Column("TRAININGSTATUSENTITYGUID")]
        [StringLength(36)]
        public string Trainingstatusentityguid { get; set; }
        [Column("TOTALMARKS", TypeName = "NUMBER(38)")]
        public decimal? Totalmarks { get; set; }
        [Column("ATTENDEETYPE")]
        [StringLength(100)]
        public string Attendeetype { get; set; }
        [Column("BATCHVALIDITYSTARTDATE", TypeName = "DATE")]
        public DateTime Batchvaliditystartdate { get; set; }
        [Column("BATCHVALIDITYENDDATE", TypeName = "DATE")]
        public DateTime? Batchvalidityenddate { get; set; }
        [Column("BATCHDISABLED")]
        public bool? Batchdisabled { get; set; }
        [Column("BATCHORACLEENTITYNAME")]
        [StringLength(100)]
        public string Batchoracleentityname { get; set; }
        [Column("BATCHORACLEENTITYID")]
        [StringLength(1000)]
        public string Batchoracleentityid { get; set; }
        [Column("BATCHOBJECTVERSIONNO")]
        public int? Batchobjectversionno { get; set; }
        [Column("TRAININGTOPIC")]
        [StringLength(100)]
        public string Trainingtopic { get; set; }
        [Column("BATCHPKGUID")]
        [StringLength(36)]
        public string Batchpkguid { get; set; }
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
    }
}
