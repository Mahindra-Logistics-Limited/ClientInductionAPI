using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ClientInductionAPI.Models.CIModel
{
    [Keyless]
    [Table("XMERU_AR_SUBS_PER")]
    public partial class XmeruArSubsPer
    {
        [Required]
        [Column("PARTY_NAME")]
        [StringLength(360)]
        public string PartyName { get; set; }
        [Required]
        [Column("ACCOUNT_NUMBER")]
        [StringLength(30)]
        public string AccountNumber { get; set; }
        [Required]
        [Column("STATUS")]
        [StringLength(1)]
        public string Status { get; set; }
        [Column("PARTY_ID")]
        public long PartyId { get; set; }
        [Column("DEPOSIT_AMOUNT")]
        [StringLength(150)]
        public string DepositAmount { get; set; }
        [Column("DATE_OF_JOIN")]
        [StringLength(150)]
        public string DateOfJoin { get; set; }
        [Column("DATE_OF_LEAVING")]
        [StringLength(150)]
        public string DateOfLeaving { get; set; }
        [Column("DATE_OF_REJOIN")]
        [StringLength(150)]
        public string DateOfRejoin { get; set; }
        [Column("CURRENT_SUBS_RATE")]
        [StringLength(150)]
        public string CurrentSubsRate { get; set; }
        [Column("SEND_TO_SIEBEL")]
        [StringLength(150)]
        public string SendToSiebel { get; set; }
        [Column("SUBS_TDS_PCT")]
        [StringLength(150)]
        public string SubsTdsPct { get; set; }
        [Column("ADDRESS1")]
        [StringLength(240)]
        public string Address1 { get; set; }
        [Column("ADDRESS2")]
        [StringLength(240)]
        public string Address2 { get; set; }
        [Column("COUNTRY")]
        [StringLength(60)]
        public string Country { get; set; }
        [Column("STATE")]
        [StringLength(60)]
        public string State { get; set; }
        [Column("POSTAL_CODE")]
        [StringLength(60)]
        public string PostalCode { get; set; }
        [Column("PARTY_SITE_ID")]
        public long PartySiteId { get; set; }
        [Column("CUST_ACCOUNT_ID")]
        public long CustAccountId { get; set; }
        [Column("CUST_ACCT_SITE_ID")]
        public long CustAcctSiteId { get; set; }
        [Column("SITE_USE_ID")]
        public long SiteUseId { get; set; }
        [Column("PRIMARY_PHONE_NUMBER")]
        [StringLength(40)]
        public string PrimaryPhoneNumber { get; set; }
        [Column("ORG_ID")]
        public long? OrgId { get; set; }
        [Column("CONV_STATUS")]
        [StringLength(50)]
        public string ConvStatus { get; set; }
        [Column("CAR_STATUS")]
        [StringLength(50)]
        public string CarStatus { get; set; }
        [Column("ERRORMSG")]
        [StringLength(1000)]
        public string Errormsg { get; set; }
        [Column("DOB", TypeName = "DATE")]
        public DateTime? Dob { get; set; }
        [Column("STATUSENTITYGUID")]
        [StringLength(36)]
        public string Statusentityguid { get; set; }
        [Column("BIOMETRICID")]
        [StringLength(50)]
        public string Biometricid { get; set; }
        [Column("GENDER")]
        [StringLength(20)]
        public string Gender { get; set; }
        [Column("RESONMASTERGUID")]
        [StringLength(36)]
        public string Resonmasterguid { get; set; }
        [Column("PK_GUID")]
        [StringLength(36)]
        public string PkGuid { get; set; }
        [Column("SP_STATUS")]
        [StringLength(30)]
        public string SpStatus { get; set; }
        [Column("DRIVER_STATUS")]
        [StringLength(30)]
        public string DriverStatus { get; set; }
        [Column("SPSITE_STATUS")]
        [StringLength(30)]
        public string SpsiteStatus { get; set; }
        [Column("MENTOR_REF_ID")]
        [StringLength(36)]
        public string MentorRefId { get; set; }
        [Column("BIOID")]
        [StringLength(50)]
        public string Bioid { get; set; }
    }
}
