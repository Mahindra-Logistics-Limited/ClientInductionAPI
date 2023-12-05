using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ClientInductionAPI.Models.CIModel
{
    [Keyless]
    [Table("SP_MANTHAN")]
    public partial class SpManthan
    {
        [Column("SEQ_ID")]
        public int? SeqId { get; set; }
        [Column("VERIFICATIONID")]
        public int? Verificationid { get; set; }
        [Column("PROSPECTID")]
        public int? Prospectid { get; set; }
        [Column("ASSOCIATEID")]
        [StringLength(30)]
        public string Associateid { get; set; }
        [Column("ADDRESSPROOFPATH")]
        [StringLength(250)]
        public string Addressproofpath { get; set; }
        [Column("ADDRESSSTATUS")]
        [StringLength(50)]
        public string Addressstatus { get; set; }
        [Column("ADDRESSERROR")]
        [StringLength(2000)]
        public string Addresserror { get; set; }
        [Column("ADDFLAG")]
        [StringLength(10)]
        public string Addflag { get; set; }
        [Column("PHOTOIDPATH")]
        [StringLength(250)]
        public string Photoidpath { get; set; }
        [Column("PHOTOIDSTATUS")]
        [StringLength(50)]
        public string Photoidstatus { get; set; }
        [Column("PHOTOIDERROR")]
        [StringLength(2000)]
        public string Photoiderror { get; set; }
        [Column("PHOTOFLAG")]
        [StringLength(10)]
        public string Photoflag { get; set; }
        [Column("PANCOPYPATH")]
        [StringLength(250)]
        public string Pancopypath { get; set; }
        [Column("PANCOPYSTATUS")]
        [StringLength(50)]
        public string Pancopystatus { get; set; }
        [Column("PANCOPYERROR")]
        [StringLength(2000)]
        public string Pancopyerror { get; set; }
        [Column("PANFLAG")]
        [StringLength(10)]
        public string Panflag { get; set; }
        [Column("PAN")]
        [StringLength(15)]
        public string Pan { get; set; }
        [Column("DRIVINGLICENSEPATH")]
        [StringLength(250)]
        public string Drivinglicensepath { get; set; }
        [Column("DRIVINGLICENSESTATUS")]
        [StringLength(50)]
        public string Drivinglicensestatus { get; set; }
        [Column("DRIVINGLICENSEERROR")]
        [StringLength(2000)]
        public string Drivinglicenseerror { get; set; }
        [Column("DRIVINGFLAG")]
        [StringLength(10)]
        public string Drivingflag { get; set; }
        [Column("DLEXPIRYDATE", TypeName = "DATE")]
        public DateTime? Dlexpirydate { get; set; }
        [Column("SERVICETAXPATH")]
        [StringLength(250)]
        public string Servicetaxpath { get; set; }
        [Column("SERVICETAXSTATUS")]
        [StringLength(50)]
        public string Servicetaxstatus { get; set; }
        [Column("SERVICETAXERROR")]
        [StringLength(2000)]
        public string Servicetaxerror { get; set; }
        [Column("SERVICETAXFLAG")]
        [StringLength(10)]
        public string Servicetaxflag { get; set; }
        [Column("CANCELLEDCHECKPATH")]
        [StringLength(250)]
        public string Cancelledcheckpath { get; set; }
        [Column("CANCELLEDCHECKSTATUS")]
        [StringLength(50)]
        public string Cancelledcheckstatus { get; set; }
        [Column("CANCELLEDCHECKERROR")]
        [StringLength(2000)]
        public string Cancelledcheckerror { get; set; }
        [Column("CANCELLEDCHECKFLAG")]
        [StringLength(10)]
        public string Cancelledcheckflag { get; set; }
        [Column("AGGREMENTDOCPATH")]
        [StringLength(250)]
        public string Aggrementdocpath { get; set; }
        [Column("AGGREMENTDOCSTATUS")]
        [StringLength(50)]
        public string Aggrementdocstatus { get; set; }
        [Column("AGGREMENTDOCERROR")]
        [StringLength(2000)]
        public string Aggrementdocerror { get; set; }
        [Column("AGGREMENTDOCFLAG")]
        [StringLength(10)]
        public string Aggrementdocflag { get; set; }
        [Column("STATUS")]
        [StringLength(10)]
        public string Status { get; set; }
    }
}
