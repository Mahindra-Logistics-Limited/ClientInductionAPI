using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ClientInductionAPI.Models.CIModel
{
    [Keyless]
    public partial class ReinspectionscheduleV
    {
        [Column("GUID")]
        [StringLength(36)]
        public string Guid { get; set; }
        [Column("WORKSHOPMASTERGUID")]
        [StringLength(36)]
        public string Workshopmasterguid { get; set; }
        [Column("BRANCHMASTERGUID")]
        [StringLength(36)]
        public string Branchmasterguid { get; set; }
        [Column("SLOTNO")]
        public byte? Slotno { get; set; }
        [Column("INSPECTTYPE")]
        [StringLength(50)]
        public string Inspecttype { get; set; }
        [Column("CARMASTERGUID")]
        [StringLength(36)]
        public string Carmasterguid { get; set; }
        [Column("SCHEDULEDATE", TypeName = "DATE")]
        public DateTime? Scheduledate { get; set; }
        [Column("SCHEDULESTATUSENTITYGUID")]
        [StringLength(36)]
        public string Schedulestatusentityguid { get; set; }
        [Column("PKGUID")]
        [StringLength(36)]
        public string Pkguid { get; set; }
        [Column("INSPECTIONRESULTGUID")]
        [StringLength(36)]
        public string Inspectionresultguid { get; set; }
    }
}
