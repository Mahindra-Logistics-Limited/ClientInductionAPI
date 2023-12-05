using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ClientInductionAPI.Models.CIModel
{
    [Keyless]
    [Table("AIRPORTPARKINGENTRY")]
    [Index(nameof(Entryid), Name = "UNI_ENTRYID", IsUnique = true)]
    public partial class Airportparkingentry
    {
        [Column("CARNO")]
        [StringLength(255)]
        public string Carno { get; set; }
        [Column("DRIVERID")]
        [StringLength(100)]
        public string Driverid { get; set; }
        [Column("TERMINALNAME")]
        [StringLength(255)]
        public string Terminalname { get; set; }
        [Column("PARKINGFEE", TypeName = "NUMBER(10,2)")]
        public decimal? Parkingfee { get; set; }
        [Column("ENTRYDATETIME", TypeName = "DATE")]
        public DateTime? Entrydatetime { get; set; }
        [Column("DATECREATED", TypeName = "DATE")]
        public DateTime Datecreated { get; set; }
        [Column("STATUS")]
        [StringLength(10)]
        public string Status { get; set; }
        [Column("ENTRYID")]
        [StringLength(100)]
        public string Entryid { get; set; }
    }
}
