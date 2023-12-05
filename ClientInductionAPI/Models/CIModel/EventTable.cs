using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ClientInductionAPI.Models.CIModel
{
    [Keyless]
    [Table("EVENT_TABLE")]
    public partial class EventTable
    {
        [Column("ID", TypeName = "NUMBER")]
        public decimal? Id { get; set; }
        [Column("EVENT_DATA", TypeName = "CLOB")]
        public string EventData { get; set; }
        [Column("ITEMKEY")]
        [StringLength(20)]
        public string Itemkey { get; set; }
        [Column("EVENTNAME")]
        [StringLength(20)]
        public string Eventname { get; set; }
        [Column("SUBS_NAME")]
        [StringLength(50)]
        public string SubsName { get; set; }
        [Column("CREATE_ON", TypeName = "DATE")]
        public DateTime? CreateOn { get; set; }
    }
}
