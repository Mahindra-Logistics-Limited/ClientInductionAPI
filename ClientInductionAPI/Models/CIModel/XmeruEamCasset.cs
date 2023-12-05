using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ClientInductionAPI.Models.CIModel
{
    [Keyless]
    [Table("XMERU_EAM_CASSET")]
    public partial class XmeruEamCasset
    {
        [Column("INVENTORY_ITEM_ID", TypeName = "NUMBER")]
        public decimal InventoryItemId { get; set; }
        [Column("CURRENT_ORGANIZATION_ID", TypeName = "NUMBER")]
        public decimal CurrentOrganizationId { get; set; }
        [Required]
        [Column("SERIAL_NUMBER")]
        [StringLength(30)]
        public string SerialNumber { get; set; }
        [Column("ORGANIZATION_ID", TypeName = "NUMBER")]
        public decimal OrganizationId { get; set; }
        [Column("SEGMENT1")]
        [StringLength(40)]
        public string Segment1 { get; set; }
        [Column("DESCRIPTION")]
        [StringLength(240)]
        public string Description { get; set; }
        [Column("INSTANCE_ID", TypeName = "NUMBER")]
        public decimal InstanceId { get; set; }
        [Required]
        [Column("ASSET_NO")]
        [StringLength(30)]
        public string AssetNo { get; set; }
        [Column("TIME_STAMP")]
        [StringLength(240)]
        public string TimeStamp { get; set; }
        [Column("VEHICLE_STATUS")]
        [StringLength(240)]
        public string VehicleStatus { get; set; }
        [Column("EVENT_DATE")]
        [StringLength(240)]
        public string EventDate { get; set; }
        [Column("PARENT_ITEM", TypeName = "NUMBER")]
        public decimal? ParentItem { get; set; }
        [Column("PARENT_SERIAL")]
        [StringLength(30)]
        public string ParentSerial { get; set; }
        [Column("PARENT_INSTANCE")]
        [StringLength(30)]
        public string ParentInstance { get; set; }
        [Column("ACTIVE_START_DATE", TypeName = "DATE")]
        public DateTime? ActiveStartDate { get; set; }
        [Column("ACTIVE_END_DATE", TypeName = "DATE")]
        public DateTime? ActiveEndDate { get; set; }
        [Column("TYPE")]
        [StringLength(40)]
        public string Type { get; set; }
        [Column("MAKE")]
        [StringLength(40)]
        public string Make { get; set; }
        [Column("MODEL")]
        [StringLength(40)]
        public string Model { get; set; }
        [Required]
        [Column("ORG_NAME")]
        [StringLength(240)]
        public string OrgName { get; set; }
        [Column("CNG_VOUCHER_VAL_DATE", TypeName = "DATE")]
        public DateTime? CngVoucherValDate { get; set; }
        [Column("PERMIT_DATE", TypeName = "DATE")]
        public DateTime? PermitDate { get; set; }
        [Column("SIM_NUMBER")]
        [StringLength(150)]
        public string SimNumber { get; set; }
        [Column("MOBILE_NUMBER")]
        [StringLength(150)]
        public string MobileNumber { get; set; }
        [Column("SERVICE_PROVIDER")]
        [StringLength(150)]
        public string ServiceProvider { get; set; }
        [Column("MDT_DEVICE_ID")]
        [StringLength(150)]
        public string MdtDeviceId { get; set; }
        [Column("STATUS")]
        [StringLength(50)]
        public string Status { get; set; }
        [Column("ERRORMSG")]
        [StringLength(1000)]
        public string Errormsg { get; set; }
        [Column("CARDEVICE_STATUS")]
        [StringLength(20)]
        public string CardeviceStatus { get; set; }
    }
}
