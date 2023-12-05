using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ClientInductionAPI.Models.CIModel
{
    [Keyless]
    [Table("TRIPDATA_ARCHIVE")]
    public partial class TripdataArchive
    {
        [Column("JOBID")]
        [StringLength(36)]
        public string Jobid { get; set; }
        [Column("TRIPID")]
        [StringLength(36)]
        public string Tripid { get; set; }
        [Column("CUSTOMERNAME")]
        [StringLength(200)]
        public string Customername { get; set; }
        [Column("CUSTOMERMOBILENO", TypeName = "NUMBER")]
        public decimal? Customermobileno { get; set; }
        [Column("CUSTOMEREMAILID")]
        [StringLength(200)]
        public string Customeremailid { get; set; }
        [Column("CABREGISTRATION")]
        [StringLength(36)]
        public string Cabregistration { get; set; }
        [Column("SUBSCRIBERID", TypeName = "NUMBER")]
        public decimal? Subscriberid { get; set; }
        [Column("BOOKINGTIME", TypeName = "DATE")]
        public DateTime? Bookingtime { get; set; }
        [Column("PICKUPTIME", TypeName = "DATE")]
        public DateTime? Pickuptime { get; set; }
        [Column("CUSTOMERASSIGNEDTIME", TypeName = "DATE")]
        public DateTime? Customerassignedtime { get; set; }
        [Column("TRIPSTARTTIME", TypeName = "DATE")]
        public DateTime? Tripstarttime { get; set; }
        [Column("TRIPENDTIME", TypeName = "DATE")]
        public DateTime? Tripendtime { get; set; }
        [Column("PICKUPADDRESS")]
        public string Pickupaddress { get; set; }
        [Column("DROPADDRESS")]
        public string Dropaddress { get; set; }
        [Column("PICKUPLOCATION")]
        public string Pickuplocation { get; set; }
        [Column("DROPLOCATION")]
        public string Droplocation { get; set; }
        [Column("HIREDDISTANCEKM", TypeName = "NUMBER")]
        public decimal? Hireddistancekm { get; set; }
        [Column("APPROXDISTANCEKM", TypeName = "NUMBER")]
        public decimal? Approxdistancekm { get; set; }
        [Column("ONCALLDISTCANE", TypeName = "NUMBER")]
        public decimal? Oncalldistcane { get; set; }
        [Column("PAYMENTTYPE")]
        [StringLength(36)]
        public string Paymenttype { get; set; }
        [Column("JOBTYPE")]
        [StringLength(36)]
        public string Jobtype { get; set; }
        [Column("TRITYPE")]
        [StringLength(36)]
        public string Tritype { get; set; }
        [Column("CHANNEL")]
        [StringLength(36)]
        public string Channel { get; set; }
        [Column("CONVENIENCECHARGE", TypeName = "NUMBER")]
        public decimal? Conveniencecharge { get; set; }
        [Column("RUNNINGFARE", TypeName = "NUMBER")]
        public decimal? Runningfare { get; set; }
        [Column("WAITINGFARE", TypeName = "NUMBER")]
        public decimal? Waitingfare { get; set; }
        [Column("OTHERCHARGES", TypeName = "NUMBER")]
        public decimal? Othercharges { get; set; }
        [Column("REVENUE", TypeName = "NUMBER")]
        public decimal? Revenue { get; set; }
        [Column("COUPONAMOUNT", TypeName = "NUMBER")]
        public decimal? Couponamount { get; set; }
        [Column("PAYABLEAMOUNT", TypeName = "NUMBER")]
        public decimal? Payableamount { get; set; }
        [Column("SHADOWAMOUNT", TypeName = "NUMBER")]
        public decimal? Shadowamount { get; set; }
        [Column("RFIDIN")]
        [StringLength(36)]
        public string Rfidin { get; set; }
        [Column("CABBRAND")]
        [StringLength(36)]
        public string Cabbrand { get; set; }
        [Column("JOBBRAND")]
        [StringLength(36)]
        public string Jobbrand { get; set; }
        [Column("ADDITIONALFARE", TypeName = "NUMBER")]
        public decimal? Additionalfare { get; set; }
        [Column("TOLLCHARGE", TypeName = "NUMBER")]
        public decimal? Tollcharge { get; set; }
        [Column("DRIVERALLOWANCE", TypeName = "NUMBER")]
        public decimal? Driverallowance { get; set; }
        [Column("CALLERID")]
        [StringLength(20)]
        public string Callerid { get; set; }
        [Column("STATUS")]
        [StringLength(100)]
        public string Status { get; set; }
        [Column("TRIPRECEIVEDDATE", TypeName = "DATE")]
        public DateTime? Tripreceiveddate { get; set; }
        [Column("AIRPORTCHARGES", TypeName = "NUMBER")]
        public decimal? Airportcharges { get; set; }
        [Column("CORPORATECOMPANYNAME")]
        [StringLength(200)]
        public string Corporatecompanyname { get; set; }
        [Column("ISRIDESHARE", TypeName = "NUMBER")]
        public decimal? Isrideshare { get; set; }
        [Column("MATCHEDJOBID")]
        [StringLength(36)]
        public string Matchedjobid { get; set; }
        [Column("RSTRIPSEQUENCE", TypeName = "NUMBER")]
        public decimal? Rstripsequence { get; set; }
        [Column("DATECREATED", TypeName = "DATE")]
        public DateTime? Datecreated { get; set; }
        [Column("RSDISCOUNT", TypeName = "NUMBER")]
        public decimal? Rsdiscount { get; set; }
        [Column("RSSTATUS")]
        [StringLength(50)]
        public string Rsstatus { get; set; }
        [Column("RETTRIGGERFLAG", TypeName = "NUMBER")]
        public decimal? Rettriggerflag { get; set; }
        [Column("RETTRIGGERDATE", TypeName = "DATE")]
        public DateTime? Rettriggerdate { get; set; }
        [Column("CROSSSELLINGFARE", TypeName = "NUMBER")]
        public decimal? Crosssellingfare { get; set; }
        [Column("DRIVERPARTNERPAYMENT", TypeName = "NUMBER")]
        public decimal? Driverpartnerpayment { get; set; }
        [Column("CORPORATECODE")]
        [StringLength(200)]
        public string Corporatecode { get; set; }
        [Column("ACTUALRUNNINGFARE", TypeName = "NUMBER(10,2)")]
        public decimal? Actualrunningfare { get; set; }
        [Column("MERUSHARE", TypeName = "NUMBER(10,2)")]
        public decimal? Merushare { get; set; }
        [Column("TMPDIFFERENCEAMOUNT", TypeName = "NUMBER(10,2)")]
        public decimal? Tmpdifferenceamount { get; set; }
        [Column("TMPNOSHOWCAR")]
        [StringLength(255)]
        public string Tmpnoshowcar { get; set; }
        [Column("TMPNOSHOWDRIVER")]
        [StringLength(255)]
        public string Tmpnoshowdriver { get; set; }
        [Column("TMPBOOKINGFARE", TypeName = "NUMBER(10,2)")]
        public decimal? Tmpbookingfare { get; set; }
        [Column("TMPDISPATCHFARE", TypeName = "NUMBER(10,2)")]
        public decimal? Tmpdispatchfare { get; set; }
        [Column("THIRDPARTYVENDOR")]
        [StringLength(15)]
        public string Thirdpartyvendor { get; set; }
        [Column("WAITTIME", TypeName = "NUMBER")]
        public decimal? Waittime { get; set; }
        [Column("TRIPDURATION", TypeName = "NUMBER")]
        public decimal? Tripduration { get; set; }
        [Column("CASHPAID", TypeName = "NUMBER(10,2)")]
        public decimal? Cashpaid { get; set; }
        [Column("BOOKINGTYPE")]
        [StringLength(15)]
        public string Bookingtype { get; set; }
        [Column("PACKAGEBASEKM", TypeName = "NUMBER")]
        public decimal? Packagebasekm { get; set; }
        [Column("PACKAGEBASEHR", TypeName = "NUMBER")]
        public decimal? Packagebasehr { get; set; }
        [Column("CUSTOMERTOLL", TypeName = "NUMBER")]
        public decimal? Customertoll { get; set; }
        [Column("ROUTEID", TypeName = "NUMBER")]
        public decimal? Routeid { get; set; }
        [Column("FROMSTATE")]
        [StringLength(255)]
        public string Fromstate { get; set; }
        [Column("DRIVERDAYSPENT", TypeName = "NUMBER")]
        public decimal? Driverdayspent { get; set; }
        [Column("DRIVERNIGHTSPENT", TypeName = "NUMBER")]
        public decimal? Drivernightspent { get; set; }
        [Column("PAYMENTTYPE2")]
        [StringLength(36)]
        public string Paymenttype2 { get; set; }
        [Column("DRIVERPARTNERPAYMENT2", TypeName = "NUMBER")]
        public decimal? Driverpartnerpayment2 { get; set; }
        [Column("AIRPORTTOLL", TypeName = "NUMBER")]
        public decimal? Airporttoll { get; set; }
        [Column("PICKUPMESSAGE")]
        [StringLength(100)]
        public string Pickupmessage { get; set; }
        [Column("EMPSHIFT")]
        [StringLength(10)]
        public string Empshift { get; set; }
        [Column("MONROETRIPTYPE")]
        [StringLength(10)]
        public string Monroetriptype { get; set; }
        [Column("NOOFEMP", TypeName = "NUMBER")]
        public decimal? Noofemp { get; set; }
        [Column("DUTYSLIPURL")]
        [StringLength(1000)]
        public string Dutyslipurl { get; set; }
        [Column("TOLLURL")]
        [StringLength(1000)]
        public string Tollurl { get; set; }
        [Column("WALLETNAME")]
        [StringLength(100)]
        public string Walletname { get; set; }
        [Column("WALLETTRANSACTIONID")]
        [StringLength(100)]
        public string Wallettransactionid { get; set; }
        [Column("MMTBOOKINGFEE", TypeName = "NUMBER")]
        public decimal? Mmtbookingfee { get; set; }
    }
}
