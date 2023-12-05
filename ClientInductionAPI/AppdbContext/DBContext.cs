using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using ClientInductionAPI.Models.CIModel;
using ClientInductionAPI.Models.CIAppModel;

#nullable disable

namespace ClientInductionAPI.Appdbcontext
{
    public partial class DBContext : DbContext
    {
        public DBContext()
        {
        }

        public DBContext(DbContextOptions<DBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Addressverification> Addressverifications { get; set; }
        public virtual DbSet<Addressverisetmaster> Addressverisetmasters { get; set; }
        public virtual DbSet<Addrvericonfig> Addrvericonfigs { get; set; }
        public virtual DbSet<Airportparkingentry> Airportparkingentries { get; set; }
        public virtual DbSet<Alertserviceconfig> Alertserviceconfigs { get; set; }
        public virtual DbSet<AllDocV> AllDocVs { get; set; }
        public virtual DbSet<AllMentorlistV> AllMentorlistVs { get; set; }
        public virtual DbSet<AllocbalanceBaseV> AllocbalanceBaseVs { get; set; }
        public virtual DbSet<AllocbalanceV> AllocbalanceVs { get; set; }
        public virtual DbSet<Anchorlocation> Anchorlocations { get; set; }
        public virtual DbSet<Answermaster> Answermasters { get; set; }
        public virtual DbSet<AnswersBaseV> AnswersBaseVs { get; set; }
        public virtual DbSet<AnswersV> AnswersVs { get; set; }
        public virtual DbSet<Answertypemapping> Answertypemappings { get; set; }
        public virtual DbSet<Answertypemaster> Answertypemasters { get; set; }
        public virtual DbSet<Applicationlogtable> Applicationlogtables { get; set; }
        public virtual DbSet<Applicationpageaction> Applicationpageactions { get; set; }
        public virtual DbSet<Applicationpageactionrole> Applicationpageactionroles { get; set; }
        public virtual DbSet<ApplicationpageactionroleV> ApplicationpageactionroleVs { get; set; }
        public virtual DbSet<Applicationpagemaster> Applicationpagemasters { get; set; }
        public virtual DbSet<ArPaymentSchedulesAll> ArPaymentSchedulesAlls { get; set; }
        public virtual DbSet<ArPaymentSchedulesAllArchive> ArPaymentSchedulesAllArchives { get; set; }
        public virtual DbSet<ArReceiptMethodAccountsAll> ArReceiptMethodAccountsAlls { get; set; }
        public virtual DbSet<Avoidtxnupdatebalance> Avoidtxnupdatebalances { get; set; }
        public virtual DbSet<Avoidtxnupdatebalancebymodel> Avoidtxnupdatebalancebymodels { get; set; }
        public virtual DbSet<Bankbranchmaster> Bankbranchmasters { get; set; }
        public virtual DbSet<Bankmaster> Bankmasters { get; set; }
        public virtual DbSet<Bbmparameter> Bbmparameters { get; set; }
        public virtual DbSet<BbmparameterBaseV> BbmparameterBaseVs { get; set; }
        public virtual DbSet<BbmparameterV> BbmparameterVs { get; set; }
        public virtual DbSet<Blacklist> Blacklists { get; set; }
        public virtual DbSet<Branchmaster> Branchmasters { get; set; }
        public virtual DbSet<Brandmaster> Brandmasters { get; set; }
        public virtual DbSet<Broadcastmessagemaster> Broadcastmessagemasters { get; set; }
        public virtual DbSet<Businesscategorymaster> Businesscategorymasters { get; set; }
        public virtual DbSet<CarAccrualV> CarAccrualVs { get; set; }
        public virtual DbSet<CarAllocBaseV> CarAllocBaseVs { get; set; }
        public virtual DbSet<CarAllocV> CarAllocVs { get; set; }
        public virtual DbSet<CarBaseV> CarBaseVs { get; set; }
        public virtual DbSet<CarDeviceBaseV> CarDeviceBaseVs { get; set; }
        public virtual DbSet<CarDeviceV> CarDeviceVs { get; set; }
        public virtual DbSet<CarDevicelistBaseV> CarDevicelistBaseVs { get; set; }
        public virtual DbSet<CarDevicelistV> CarDevicelistVs { get; set; }
        public virtual DbSet<CarDriverBaseV> CarDriverBaseVs { get; set; }
        public virtual DbSet<CarDriverV> CarDriverVs { get; set; }
        public virtual DbSet<CarEnrolfeeV> CarEnrolfeeVs { get; set; }
        public virtual DbSet<CarExpV> CarExpVs { get; set; }
        public virtual DbSet<CarExpiryReportV> CarExpiryReportVs { get; set; }
        public virtual DbSet<CarGvComponentsBaseV> CarGvComponentsBaseVs { get; set; }
        public virtual DbSet<CarGvComponentsV> CarGvComponentsVs { get; set; }
        public virtual DbSet<CarMandetoryDeviceSimMobV> CarMandetoryDeviceSimMobVs { get; set; }
        public virtual DbSet<CarMandetoryDeviceV> CarMandetoryDeviceVs { get; set; }
        public virtual DbSet<CarManthan> CarManthans { get; set; }
        public virtual DbSet<CarReportV> CarReportVs { get; set; }
        public virtual DbSet<CarStatusAllocV> CarStatusAllocVs { get; set; }
        public virtual DbSet<CarStatusSummaryMv> CarStatusSummaryMvs { get; set; }
        public virtual DbSet<CarStatusSummaryV> CarStatusSummaryVs { get; set; }
        public virtual DbSet<CarV> CarVs { get; set; }
        public virtual DbSet<Carallocation> Carallocations { get; set; }
        public virtual DbSet<Cardevice> Cardevices { get; set; }
        public virtual DbSet<Cardevicemakemaster> Cardevicemakemasters { get; set; }
        public virtual DbSet<Cardevicemodel> Cardevicemodels { get; set; }
        public virtual DbSet<Cardoc> Cardocs { get; set; }
        public virtual DbSet<CardocFitnessV> CardocFitnessVs { get; set; }
        public virtual DbSet<CardocPermitV> CardocPermitVs { get; set; }
        public virtual DbSet<CardocPucV> CardocPucVs { get; set; }
        public virtual DbSet<CardocRcV> CardocRcVs { get; set; }
        public virtual DbSet<CardocRoadtaxV> CardocRoadtaxVs { get; set; }
        public virtual DbSet<CardocsBaseV> CardocsBaseVs { get; set; }
        public virtual DbSet<CardocsInsuranceV> CardocsInsuranceVs { get; set; }
        public virtual DbSet<CardocsInterface> CardocsInterfaces { get; set; }
        public virtual DbSet<CardocsV> CardocsVs { get; set; }
        public virtual DbSet<CardocsdocumentnoV> CardocsdocumentnoVs { get; set; }
        public virtual DbSet<Cardocsinf> Cardocsinfs { get; set; }
        public virtual DbSet<Cardriver> Cardrivers { get; set; }
        public virtual DbSet<CargvV> CargvVs { get; set; }
        public virtual DbSet<Carlock> Carlocks { get; set; }
        public virtual DbSet<CarlocksBaseV> CarlocksBaseVs { get; set; }
        public virtual DbSet<CarlocksV> CarlocksVs { get; set; }
        public virtual DbSet<Carmaster> Carmasters { get; set; }
        public virtual DbSet<CarmasterFb> CarmasterFbs { get; set; }
        public virtual DbSet<CcMaster> CcMasters { get; set; }
        public virtual DbSet<CcMasterInt> CcMasterInts { get; set; }
        public virtual DbSet<CcMasterSummary> CcMasterSummaries { get; set; }
        public virtual DbSet<CcMasterSummaryV> CcMasterSummaryVs { get; set; }
        public virtual DbSet<CcMasterV> CcMasterVs { get; set; }
        public virtual DbSet<CcSiteSummaryV> CcSiteSummaryVs { get; set; }
        public virtual DbSet<CdStatusV> CdStatusVs { get; set; }
        public virtual DbSet<Clientmap> Clientmaps { get; set; }
        public virtual DbSet<Clientmapeventdata03aug23> Clientmapeventdata03aug23s { get; set; }
        public virtual DbSet<Clientmapeventdatum> Clientmapeventdata { get; set; }
        public virtual DbSet<Clientmapmaster> Clientmapmasters { get; set; }
        public virtual DbSet<Colormaster> Colormasters { get; set; }
        public virtual DbSet<ComplaintactionV> ComplaintactionVs { get; set; }
        public virtual DbSet<Complaintactionmaster> Complaintactionmasters { get; set; }
        public virtual DbSet<Complaintapievent> Complaintapievents { get; set; }
        public virtual DbSet<Complaintapieventhistory> Complaintapieventhistories { get; set; }
        public virtual DbSet<Complaintcategorymapping> Complaintcategorymappings { get; set; }
        public virtual DbSet<Complaintcategorymaster> Complaintcategorymasters { get; set; }
        public virtual DbSet<Complaintcramaster> Complaintcramasters { get; set; }
        public virtual DbSet<Complaintdetail> Complaintdetails { get; set; }
        public virtual DbSet<ComplaintdetailsV> ComplaintdetailsVs { get; set; }
        public virtual DbSet<Complaintincomingcategory> Complaintincomingcategories { get; set; }
        public virtual DbSet<Complaintpragati> Complaintpragatis { get; set; }
        public virtual DbSet<Complaintsourcemaster> Complaintsourcemasters { get; set; }
        public virtual DbSet<Complaintstatusmaster> Complaintstatusmasters { get; set; }
        public virtual DbSet<ContactBaseV> ContactBaseVs { get; set; }
        public virtual DbSet<ContactV> ContactVs { get; set; }
        public virtual DbSet<Contactsubtype> Contactsubtypes { get; set; }
        public virtual DbSet<Contacttypemaster> Contacttypemasters { get; set; }
        public virtual DbSet<CorporateMaster> CorporateMasters { get; set; }
        public virtual DbSet<Corporatetriprequest> Corporatetriprequests { get; set; }
        public virtual DbSet<Countrymaster> Countrymasters { get; set; }
        public virtual DbSet<CreditbalanceV> CreditbalanceVs { get; set; }
        public virtual DbSet<Creditbalancelimit> Creditbalancelimits { get; set; }
        public virtual DbSet<Creditlimitconfig> Creditlimitconfigs { get; set; }
        public virtual DbSet<CycledatesV> CycledatesVs { get; set; }
        public virtual DbSet<Cycleday> Cycledays { get; set; }
        public virtual DbSet<Cyclemaster> Cyclemasters { get; set; }
        public virtual DbSet<CyclemasterBaseV> CyclemasterBaseVs { get; set; }
        public virtual DbSet<CyclemasterV> CyclemasterVs { get; set; }
        public virtual DbSet<DailyCarTransactionV> DailyCarTransactionVs { get; set; }
        public virtual DbSet<DailyTransactionSummaryV> DailyTransactionSummaryVs { get; set; }
        public virtual DbSet<DatesV> DatesVs { get; set; }
        public virtual DbSet<DepositOldRuleV> DepositOldRuleVs { get; set; }
        public virtual DbSet<DepositRuleV> DepositRuleVs { get; set; }
        public virtual DbSet<DeviceBaseV> DeviceBaseVs { get; set; }
        public virtual DbSet<DeviceDocActionV> DeviceDocActionVs { get; set; }
        public virtual DbSet<DeviceMdtV> DeviceMdtVs { get; set; }
        public virtual DbSet<DeviceMeterV> DeviceMeterVs { get; set; }
        public virtual DbSet<DevicePrinterV> DevicePrinterVs { get; set; }
        public virtual DbSet<DeviceReportV> DeviceReportVs { get; set; }
        public virtual DbSet<DeviceSimV> DeviceSimVs { get; set; }
        public virtual DbSet<DeviceV> DeviceVs { get; set; }
        public virtual DbSet<Devicedoc> Devicedocs { get; set; }
        public virtual DbSet<DevicedocsBaseV> DevicedocsBaseVs { get; set; }
        public virtual DbSet<DevicedocsV> DevicedocsVs { get; set; }
        public virtual DbSet<DevicemakemasterBaseV> DevicemakemasterBaseVs { get; set; }
        public virtual DbSet<DevicemakemasterV> DevicemakemasterVs { get; set; }
        public virtual DbSet<Devicemaster> Devicemasters { get; set; }
        public virtual DbSet<DevicemodelBaseV> DevicemodelBaseVs { get; set; }
        public virtual DbSet<DevicemodelV> DevicemodelVs { get; set; }
        public virtual DbSet<Devicesecurity> Devicesecurities { get; set; }
        public virtual DbSet<Devicetypemaster> Devicetypemasters { get; set; }
        public virtual DbSet<DisAllActiveAllocV> DisAllActiveAllocVs { get; set; }
        public virtual DbSet<DisAllActiveSpV> DisAllActiveSpVs { get; set; }
        public virtual DbSet<DisAllDocV> DisAllDocVs { get; set; }
        public virtual DbSet<DisAllocV> DisAllocVs { get; set; }
        public virtual DbSet<DisAllocatedCarsV> DisAllocatedCarsVs { get; set; }
        public virtual DbSet<DisApiMessageV> DisApiMessageVs { get; set; }
        public virtual DbSet<DisAuthTbl> DisAuthTbls { get; set; }
        public virtual DbSet<DisAuthoriseDevice> DisAuthoriseDevices { get; set; }
        public virtual DbSet<DisCarDocV> DisCarDocVs { get; set; }
        public virtual DbSet<DisComplaintV> DisComplaintVs { get; set; }
        public virtual DbSet<DisDeviceDocV> DisDeviceDocVs { get; set; }
        public virtual DbSet<DisDriverDocV> DisDriverDocVs { get; set; }
        public virtual DbSet<DisFcmTokenTbl> DisFcmTokenTbls { get; set; }
        public virtual DbSet<DisFcmTokenV> DisFcmTokenVs { get; set; }
        public virtual DbSet<DisFcmtknMessage> DisFcmtknMessages { get; set; }
        public virtual DbSet<DisMandatoryDocTbl> DisMandatoryDocTbls { get; set; }
        public virtual DbSet<DisOtpTbl> DisOtpTbls { get; set; }
        public virtual DbSet<DisOutstandingHistV> DisOutstandingHistVs { get; set; }
        public virtual DbSet<DisPersonV> DisPersonVs { get; set; }
        public virtual DbSet<DisPosteddocTbl> DisPosteddocTbls { get; set; }
        public virtual DbSet<DisPragatiTxnV> DisPragatiTxnVs { get; set; }
        public virtual DbSet<DisRequestreasonmaster> DisRequestreasonmasters { get; set; }
        public virtual DbSet<DisServicerequest> DisServicerequests { get; set; }
        public virtual DbSet<DisServicerequestV> DisServicerequestVs { get; set; }
        public virtual DbSet<DisServicerequesttype> DisServicerequesttypes { get; set; }
        public virtual DbSet<DisServicetypeReasonV> DisServicetypeReasonVs { get; set; }
        public virtual DbSet<DisSmseventdatum> DisSmseventdata { get; set; }
        public virtual DbSet<DisSpDocV> DisSpDocVs { get; set; }
        public virtual DbSet<DisSpSiteBalHistV> DisSpSiteBalHistVs { get; set; }
        public virtual DbSet<DisSpTxnV> DisSpTxnVs { get; set; }
        public virtual DbSet<DisStatmentTxntypeV> DisStatmentTxntypeVs { get; set; }
        public virtual DbSet<DisTransactiontypePkgV> DisTransactiontypePkgVs { get; set; }
        public virtual DbSet<DisTransactiontypeV> DisTransactiontypeVs { get; set; }
        public virtual DbSet<DisTripAllV> DisTripAllVs { get; set; }
        public virtual DbSet<DisTripDataV> DisTripDataVs { get; set; }
        public virtual DbSet<DisTripSubscriptionV> DisTripSubscriptionVs { get; set; }
        public virtual DbSet<Disapimaster> Disapimasters { get; set; }
        public virtual DbSet<Disapimessagemaster> Disapimessagemasters { get; set; }
        public virtual DbSet<DispAllActiveCarsV> DispAllActiveCarsVs { get; set; }
        public virtual DbSet<DispAllActiveCarsV1> DispAllActiveCarsV1s { get; set; }
        public virtual DbSet<DispAllCarDriverV> DispAllCarDriverVs { get; set; }
        public virtual DbSet<DispatchAuthTbl> DispatchAuthTbls { get; set; }
        public virtual DbSet<DispatchFcmTokenTbl> DispatchFcmTokenTbls { get; set; }
        public virtual DbSet<DispatchFcmtknMessage> DispatchFcmtknMessages { get; set; }
        public virtual DbSet<DispatchOtpTbl> DispatchOtpTbls { get; set; }
        public virtual DbSet<DobConfigTbl> DobConfigTbls { get; set; }
        public virtual DbSet<DobDocBrandMapping> DobDocBrandMappings { get; set; }
        public virtual DbSet<DobDocBrandMapping22> DobDocBrandMapping22s { get; set; }
        public virtual DbSet<DobDocPlaceholder> DobDocPlaceholders { get; set; }
        public virtual DbSet<DobDocPlaceholderV3> DobDocPlaceholderV3s { get; set; }
        public virtual DbSet<DobDocSubtypeTbl> DobDocSubtypeTbls { get; set; }
        public virtual DbSet<DobDocumentV> DobDocumentVs { get; set; }
        public virtual DbSet<DobMandatoryDocTbl> DobMandatoryDocTbls { get; set; }
        public virtual DbSet<DobMandatoryDocTblV2> DobMandatoryDocTblV2s { get; set; }
        public virtual DbSet<Dobapimaster> Dobapimasters { get; set; }
        public virtual DbSet<DocAction> DocActions { get; set; }
        public virtual DbSet<DocActionType> DocActionTypes { get; set; }
        public virtual DbSet<DocActionV> DocActionVs { get; set; }
        public virtual DbSet<DocBaseV> DocBaseVs { get; set; }
        public virtual DbSet<DocEntV> DocEntVs { get; set; }
        public virtual DbSet<DocTypCatEntV> DocTypCatEntVs { get; set; }
        public virtual DbSet<DocV> DocVs { get; set; }
        public virtual DbSet<Documentcategorymaster> Documentcategorymasters { get; set; }
        public virtual DbSet<Documentlockrule> Documentlockrules { get; set; }
        public virtual DbSet<Documenttypecategory> Documenttypecategories { get; set; }
        public virtual DbSet<Documenttypeentity> Documenttypeentities { get; set; }
        public virtual DbSet<Documenttypemaster> Documenttypemasters { get; set; }
        public virtual DbSet<Documenttypepurpose> Documenttypepurposes { get; set; }
        public virtual DbSet<DriverBaseV> DriverBaseVs { get; set; }
        public virtual DbSet<DriverDetailsV> DriverDetailsVs { get; set; }
        public virtual DbSet<DriverManthan> DriverManthans { get; set; }
        public virtual DbSet<DriverTrainingV> DriverTrainingVs { get; set; }
        public virtual DbSet<DriverV> DriverVs { get; set; }
        public virtual DbSet<Drivermaster> Drivermasters { get; set; }
        public virtual DbSet<Driverrating> Driverratings { get; set; }
        public virtual DbSet<Driverrating90days1> Driverrating90days1s { get; set; }
        public virtual DbSet<Drivertip> Drivertips { get; set; }
        public virtual DbSet<EmiMaster> EmiMasters { get; set; }
        public virtual DbSet<EmiTransactionmaster> EmiTransactionmasters { get; set; }
        public virtual DbSet<EmiTransactionmastera> EmiTransactionmasteras { get; set; }
        public virtual DbSet<Entitycolumn> Entitycolumns { get; set; }
        public virtual DbSet<Entityjoin> Entityjoins { get; set; }
        public virtual DbSet<Entitymaster> Entitymasters { get; set; }
        public virtual DbSet<Environmentmaster> Environmentmasters { get; set; }
        public virtual DbSet<Errormessage> Errormessages { get; set; }
        public virtual DbSet<EscrowHistV> EscrowHistVs { get; set; }
        public virtual DbSet<EventTable> EventTables { get; set; }
        public virtual DbSet<Eventdatum> Eventdata { get; set; }
        public virtual DbSet<Exceptionreasonmaster> Exceptionreasonmasters { get; set; }
        public virtual DbSet<Exitinterview> Exitinterviews { get; set; }
        public virtual DbSet<ExternalPayment> ExternalPayments { get; set; }
        public virtual DbSet<FaqV> FaqVs { get; set; }
        public virtual DbSet<Faqgroupmaster> Faqgroupmasters { get; set; }
        public virtual DbSet<Faqmaster> Faqmasters { get; set; }
        public virtual DbSet<Fixedtriprule> Fixedtriprules { get; set; }
        public virtual DbSet<FreeCarsBaseV> FreeCarsBaseVs { get; set; }
        public virtual DbSet<FreeCarsV> FreeCarsVs { get; set; }
        public virtual DbSet<FreeDriverV> FreeDriverVs { get; set; }
        public virtual DbSet<Frequencymaster> Frequencymasters { get; set; }
        public virtual DbSet<FtrQacdcoflexi> FtrQacdcoflexis { get; set; }
        public virtual DbSet<Fundnottransfered> Fundnottransfereds { get; set; }
        public virtual DbSet<FundtransferTaskExecution> FundtransferTaskExecutions { get; set; }
        public virtual DbSet<FundtransferTxn> FundtransferTxns { get; set; }
        public virtual DbSet<FundwithdrawalTxn> FundwithdrawalTxns { get; set; }
        public virtual DbSet<GlV> GlVs { get; set; }
        public virtual DbSet<Greivancescategory> Greivancescategories { get; set; }
        public virtual DbSet<Groupvariant> Groupvariants { get; set; }
        public virtual DbSet<Gvcomponent> Gvcomponents { get; set; }
        public virtual DbSet<GvcomponentAuditLog> GvcomponentAuditLogs { get; set; }
        public virtual DbSet<Gvcomponentmaster> Gvcomponentmasters { get; set; }
        public virtual DbSet<Gvcomponenttypemaster> Gvcomponenttypemasters { get; set; }
        public virtual DbSet<Gvrankthresholdmaster> Gvrankthresholdmasters { get; set; }
        public virtual DbSet<Helpmessagemaster> Helpmessagemasters { get; set; }
        public virtual DbSet<Imageverificationlog> Imageverificationlogs { get; set; }
        public virtual DbSet<IncentiveValidTripsV> IncentiveValidTripsVs { get; set; }
        public virtual DbSet<Inspectioncategorymaster> Inspectioncategorymasters { get; set; }
        public virtual DbSet<Inspectiondetail> Inspectiondetails { get; set; }
        public virtual DbSet<Inspectionresult> Inspectionresults { get; set; }
        public virtual DbSet<InspectionscheduleV> InspectionscheduleVs { get; set; }
        public virtual DbSet<Inspectiontypemaster> Inspectiontypemasters { get; set; }
        public virtual DbSet<Interaction> Interactions { get; set; }
        public virtual DbSet<InteractionsBaseV> InteractionsBaseVs { get; set; }
        public virtual DbSet<InteractionsV> InteractionsVs { get; set; }
        public virtual DbSet<InvoiceProgramexecution> InvoiceProgramexecutions { get; set; }
        public virtual DbSet<Issuemaster> Issuemasters { get; set; }
        public virtual DbSet<JXmeruCabDailyStatus> JXmeruCabDailyStatuses { get; set; }
        public virtual DbSet<LeadBaseV> LeadBaseVs { get; set; }
        public virtual DbSet<LeadV> LeadVs { get; set; }
        public virtual DbSet<Leadmaster> Leadmasters { get; set; }
        public virtual DbSet<LeadmasterBaseV> LeadmasterBaseVs { get; set; }
        public virtual DbSet<Leadsourcemaster> Leadsourcemasters { get; set; }
        public virtual DbSet<LebranchBaseV> LebranchBaseVs { get; set; }
        public virtual DbSet<LebranchV> LebranchVs { get; set; }
        public virtual DbSet<Lebranchsecurity> Lebranchsecurities { get; set; }
        public virtual DbSet<Legalentitymaster> Legalentitymasters { get; set; }
        public virtual DbSet<Linqlogtable> Linqlogtables { get; set; }
        public virtual DbSet<LockExceptionBaseV> LockExceptionBaseVs { get; set; }
        public virtual DbSet<LockExceptionV> LockExceptionVs { get; set; }
        public virtual DbSet<LockExecutionLog> LockExecutionLogs { get; set; }
        public virtual DbSet<Lockexception> Lockexceptions { get; set; }
        public virtual DbSet<Lockreasonmaster> Lockreasonmasters { get; set; }
        public virtual DbSet<Locktypemaster> Locktypemasters { get; set; }
        public virtual DbSet<ManthanCarOffRoad> ManthanCarOffRoads { get; set; }
        public virtual DbSet<ManthanCarOffRoadV> ManthanCarOffRoadVs { get; set; }
        public virtual DbSet<ManthanCarTerminated> ManthanCarTerminateds { get; set; }
        public virtual DbSet<ManthanCarTerminatedV> ManthanCarTerminatedVs { get; set; }
        public virtual DbSet<ManthanDriverAttachedV> ManthanDriverAttachedVs { get; set; }
        public virtual DbSet<ManthanDriverDetachedV> ManthanDriverDetachedVs { get; set; }
        public virtual DbSet<ManthanLockUnlockV> ManthanLockUnlockVs { get; set; }
        public virtual DbSet<ManthanOnroadDeviceV> ManthanOnroadDeviceVs { get; set; }
        public virtual DbSet<ManthanOnroadDriverV> ManthanOnroadDriverVs { get; set; }
        public virtual DbSet<ManthanOnroadV> ManthanOnroadVs { get; set; }
        public virtual DbSet<ManthanPersonTerminatedV> ManthanPersonTerminatedVs { get; set; }
        public virtual DbSet<ManualCreditlimitDetail> ManualCreditlimitDetails { get; set; }
        public virtual DbSet<ManualLockDetail> ManualLockDetails { get; set; }
        public virtual DbSet<MentorPersonV> MentorPersonVs { get; set; }
        public virtual DbSet<MentorV> MentorVs { get; set; }
        public virtual DbSet<Menumaster> Menumasters { get; set; }
        public virtual DbSet<MenumasterBaseV> MenumasterBaseVs { get; set; }
        public virtual DbSet<MenumasterV> MenumasterVs { get; set; }
        public virtual DbSet<Meruwebsitefeedbackdetail> Meruwebsitefeedbackdetails { get; set; }
        public virtual DbSet<MeterCalibrationV> MeterCalibrationVs { get; set; }
        public virtual DbSet<Modelmaster> Modelmasters { get; set; }
        public virtual DbSet<NetosV> NetosVs { get; set; }
        public virtual DbSet<Odometerreading> Odometerreadings { get; set; }
        public virtual DbSet<OutstandingHistV> OutstandingHistVs { get; set; }
        public virtual DbSet<OutstationTxn> OutstationTxns { get; set; }
        public virtual DbSet<OxygenTbl1> OxygenTbl1s { get; set; }
        public virtual DbSet<OxygenTbl2> OxygenTbl2s { get; set; }
        public virtual DbSet<Pageactionmaster> Pageactionmasters { get; set; }
        public virtual DbSet<Parametermaster> Parametermasters { get; set; }
        public virtual DbSet<PerCancelledChequeV> PerCancelledChequeVs { get; set; }
        public virtual DbSet<Permittype> Permittypes { get; set; }
        public virtual DbSet<PersdocAadhaarV> PersdocAadhaarVs { get; set; }
        public virtual DbSet<PersdocAgreementV> PersdocAgreementVs { get; set; }
        public virtual DbSet<PersdocBusinessLicV> PersdocBusinessLicVs { get; set; }
        public virtual DbSet<PersdocPanV> PersdocPanVs { get; set; }
        public virtual DbSet<PersdocPhotographV> PersdocPhotographVs { get; set; }
        public virtual DbSet<PersdocRtoAuthV> PersdocRtoAuthVs { get; set; }
        public virtual DbSet<PersonBaseV> PersonBaseVs { get; set; }
        public virtual DbSet<PersonContactDetailsBaseV> PersonContactDetailsBaseVs { get; set; }
        public virtual DbSet<PersonContactDetailsV> PersonContactDetailsVs { get; set; }
        public virtual DbSet<PersonDetailBaseV> PersonDetailBaseVs { get; set; }
        public virtual DbSet<PersonDetailV> PersonDetailVs { get; set; }
        public virtual DbSet<PersonDocActionV> PersonDocActionVs { get; set; }
        public virtual DbSet<PersonExpiryDocV> PersonExpiryDocVs { get; set; }
        public virtual DbSet<PersonExpiryDocV1> PersonExpiryDocV1s { get; set; }
        public virtual DbSet<PersonPositionV> PersonPositionVs { get; set; }
        public virtual DbSet<PersonRatingV> PersonRatingVs { get; set; }
        public virtual DbSet<PersonV> PersonVs { get; set; }
        public virtual DbSet<PersonaddressBaseV> PersonaddressBaseVs { get; set; }
        public virtual DbSet<PersonaddressV> PersonaddressVs { get; set; }
        public virtual DbSet<Personcontact> Personcontacts { get; set; }
        public virtual DbSet<Persondoc> Persondocs { get; set; }
        public virtual DbSet<PersondocsAddV> PersondocsAddVs { get; set; }
        public virtual DbSet<PersondocsBadgeV> PersondocsBadgeVs { get; set; }
        public virtual DbSet<PersondocsBaseV> PersondocsBaseVs { get; set; }
        public virtual DbSet<PersondocsIdV> PersondocsIdVs { get; set; }
        public virtual DbSet<PersondocsInterface> PersondocsInterfaces { get; set; }
        public virtual DbSet<PersondocsLicenseV> PersondocsLicenseVs { get; set; }
        public virtual DbSet<PersondocsPhoneV> PersondocsPhoneVs { get; set; }
        public virtual DbSet<PersondocsV> PersondocsVs { get; set; }
        public virtual DbSet<PersondocsactionV> PersondocsactionVs { get; set; }
        public virtual DbSet<PersondocsdocumentnoV> PersondocsdocumentnoVs { get; set; }
        public virtual DbSet<Persondocsinf> Persondocsinfs { get; set; }
        public virtual DbSet<Persongreivance> Persongreivances { get; set; }
        public virtual DbSet<PersongreivanceV> PersongreivanceVs { get; set; }
        public virtual DbSet<PersonlistBaseV> PersonlistBaseVs { get; set; }
        public virtual DbSet<PersonlistV> PersonlistVs { get; set; }
        public virtual DbSet<Personmaster> Personmasters { get; set; }
        public virtual DbSet<PersonphoneBaseV> PersonphoneBaseVs { get; set; }
        public virtual DbSet<PersonphoneV> PersonphoneVs { get; set; }
        public virtual DbSet<PhotographinsertStg> PhotographinsertStgs { get; set; }
        public virtual DbSet<Pkgcabsdailycalculation> Pkgcabsdailycalculations { get; set; }
        public virtual DbSet<Pkgcabsmonthlycalculation> Pkgcabsmonthlycalculations { get; set; }
        public virtual DbSet<Pkgcabstaskexecution> Pkgcabstaskexecutions { get; set; }
        public virtual DbSet<PoliceVerificationV> PoliceVerificationVs { get; set; }
        public virtual DbSet<PostTxnTble> PostTxnTbles { get; set; }
        public virtual DbSet<PragatiInterfaceServiceLog> PragatiInterfaceServiceLogs { get; set; }
        public virtual DbSet<QcCheckNo> QcCheckNos { get; set; }
        public virtual DbSet<Questionbankcategorymaster> Questionbankcategorymasters { get; set; }
        public virtual DbSet<Questionbankmaster> Questionbankmasters { get; set; }
        public virtual DbSet<RaTerm> RaTerms { get; set; }
        public virtual DbSet<RatingV> RatingVs { get; set; }
        public virtual DbSet<Ratingmaster> Ratingmasters { get; set; }
        public virtual DbSet<RazorPayTxn> RazorPayTxns { get; set; }
        public virtual DbSet<Reasonmaster> Reasonmasters { get; set; }
        public virtual DbSet<ReceipttypeV> ReceipttypeVs { get; set; }
        public virtual DbSet<Reinduction> Reinductions { get; set; }
        public virtual DbSet<ReinductionV> ReinductionVs { get; set; }
        public virtual DbSet<ReinspectionscheduleV> ReinspectionscheduleVs { get; set; }
        public virtual DbSet<Report> Reports { get; set; }
        public virtual DbSet<Reportexecution> Reportexecutions { get; set; }
        public virtual DbSet<ReportexecutionV> ReportexecutionVs { get; set; }
        public virtual DbSet<Reportgroup> Reportgroups { get; set; }
        public virtual DbSet<Reportparameter> Reportparameters { get; set; }
        public virtual DbSet<Resultsmaster> Resultsmasters { get; set; }
        public virtual DbSet<RetErrLog> RetErrLogs { get; set; }
        public virtual DbSet<RetLog> RetLogs { get; set; }
        public virtual DbSet<RevenueReport> RevenueReports { get; set; }
        public virtual DbSet<RoleActionV> RoleActionVs { get; set; }
        public virtual DbSet<Rolemaster> Rolemasters { get; set; }
        public virtual DbSet<Rolemenu> Rolemenus { get; set; }
        public virtual DbSet<Rolereportgroup> Rolereportgroups { get; set; }
        public virtual DbSet<RolereportgroupV> RolereportgroupVs { get; set; }
        public virtual DbSet<Rolesecuritycombination> Rolesecuritycombinations { get; set; }
        public virtual DbSet<Routemaster> Routemasters { get; set; }
        public virtual DbSet<RpBackup> RpBackups { get; set; }
        public virtual DbSet<RuleBackup> RuleBackups { get; set; }
        public virtual DbSet<RuleCarDriverV> RuleCarDriverVs { get; set; }
        public virtual DbSet<RulePhone> RulePhones { get; set; }
        public virtual DbSet<RuleTable> RuleTables { get; set; }
        public virtual DbSet<SalesAuthTbl> SalesAuthTbls { get; set; }
        public virtual DbSet<SalesBackofficePersonV> SalesBackofficePersonVs { get; set; }
        public virtual DbSet<SalesCabqcInterface> SalesCabqcInterfaces { get; set; }
        public virtual DbSet<SalesCarInterface> SalesCarInterfaces { get; set; }
        public virtual DbSet<SalesCardrivermapping> SalesCardrivermappings { get; set; }
        public virtual DbSet<SalesCardrivermappingV3> SalesCardrivermappingV3s { get; set; }
        public virtual DbSet<SalesDocumentsInterface> SalesDocumentsInterfaces { get; set; }
        public virtual DbSet<SalesDocumentsInterfaceV> SalesDocumentsInterfaceVs { get; set; }
        public virtual DbSet<SalesDocumentsInterfaceV3> SalesDocumentsInterfaceV3s { get; set; }
        public virtual DbSet<SalesDriverInterface> SalesDriverInterfaces { get; set; }
        public virtual DbSet<SalesDriverInterfaceV3> SalesDriverInterfaceV3s { get; set; }
        public virtual DbSet<SalesFueltypeInterface> SalesFueltypeInterfaces { get; set; }
        public virtual DbSet<SalesOnroadTbl> SalesOnroadTbls { get; set; }
        public virtual DbSet<SalesOtpTbl> SalesOtpTbls { get; set; }
        public virtual DbSet<SalesOwnerInterface> SalesOwnerInterfaces { get; set; }
        public virtual DbSet<SalesOwnerInterfaceV3> SalesOwnerInterfaceV3s { get; set; }
        public virtual DbSet<SalesVehicleInterfaceV3> SalesVehicleInterfaceV3s { get; set; }
        public virtual DbSet<Sapconfig> Sapconfigs { get; set; }
        public virtual DbSet<SapglV> SapglVs { get; set; }
        public virtual DbSet<Saptaskexecution> Saptaskexecutions { get; set; }
        public virtual DbSet<Schparameter> Schparameters { get; set; }
        public virtual DbSet<SchparameterValuesV> SchparameterValuesVs { get; set; }
        public virtual DbSet<Schparametertran> Schparametertrans { get; set; }
        public virtual DbSet<Schprogram> Schprograms { get; set; }
        public virtual DbSet<Schprogramtran> Schprogramtrans { get; set; }
        public virtual DbSet<Schprogramusermapping> Schprogramusermappings { get; set; }
        public virtual DbSet<Schvalueset> Schvaluesets { get; set; }
        public virtual DbSet<Searchentity> Searchentities { get; set; }
        public virtual DbSet<Searchtemplatedisplaycolumn> Searchtemplatedisplaycolumns { get; set; }
        public virtual DbSet<Searchtemplateentity> Searchtemplateentities { get; set; }
        public virtual DbSet<Searchtemplatemaster> Searchtemplatemasters { get; set; }
        public virtual DbSet<SearchtemplatemasterV> SearchtemplatemasterVs { get; set; }
        public virtual DbSet<Searchtemplatequery> Searchtemplatequeries { get; set; }
        public virtual DbSet<Searchtemplatewhereclause> Searchtemplatewhereclauses { get; set; }
        public virtual DbSet<SecurityBaseV> SecurityBaseVs { get; set; }
        public virtual DbSet<SecurityV> SecurityVs { get; set; }
        public virtual DbSet<Securitycombination> Securitycombinations { get; set; }
        public virtual DbSet<Sedantoflexi> Sedantoflexis { get; set; }
        public virtual DbSet<SendcomplaintnoteV> SendcomplaintnoteVs { get; set; }
        public virtual DbSet<Serviceprocessexecution> Serviceprocessexecutions { get; set; }
        public virtual DbSet<Serviceprovider> Serviceproviders { get; set; }
        public virtual DbSet<Shiftmaster> Shiftmasters { get; set; }
        public virtual DbSet<SiteDetailsBaseV> SiteDetailsBaseVs { get; set; }
        public virtual DbSet<SiteDetailsV> SiteDetailsVs { get; set; }
        public virtual DbSet<SiteInvoiceCalc> SiteInvoiceCalcs { get; set; }
        public virtual DbSet<Sitetypemaster> Sitetypemasters { get; set; }
        public virtual DbSet<SmsMissDocReportTemp> SmsMissDocReportTemps { get; set; }
        public virtual DbSet<Smseventdatum> Smseventdata { get; set; }
        public virtual DbSet<SnpCheckTab> SnpCheckTabs { get; set; }
        public virtual DbSet<SpAddressBaseV> SpAddressBaseVs { get; set; }
        public virtual DbSet<SpAddressV> SpAddressVs { get; set; }
        public virtual DbSet<SpBaseV> SpBaseVs { get; set; }
        public virtual DbSet<SpCarDriDeatilsV> SpCarDriDeatilsVs { get; set; }
        public virtual DbSet<SpDseTrainingV> SpDseTrainingVs { get; set; }
        public virtual DbSet<SpManthan> SpManthans { get; set; }
        public virtual DbSet<SpSiteBal> SpSiteBals { get; set; }
        public virtual DbSet<SpSiteBalHist> SpSiteBalHists { get; set; }
        public virtual DbSet<SpSiteBalHistGapFillLog> SpSiteBalHistGapFillLogs { get; set; }
        public virtual DbSet<SpSiteBalHistTemp> SpSiteBalHistTemps { get; set; }
        public virtual DbSet<SpSiteBalTrigger> SpSiteBalTriggers { get; set; }
        public virtual DbSet<SpTotalBreakV> SpTotalBreakVs { get; set; }
        public virtual DbSet<SpTrainingV> SpTrainingVs { get; set; }
        public virtual DbSet<SpV> SpVs { get; set; }
        public virtual DbSet<SpbalanceBaseV> SpbalanceBaseVs { get; set; }
        public virtual DbSet<SpbalanceV> SpbalanceVs { get; set; }
        public virtual DbSet<Spbreak> Spbreaks { get; set; }
        public virtual DbSet<SpbreakBaseV> SpbreakBaseVs { get; set; }
        public virtual DbSet<SpbreakV> SpbreakVs { get; set; }
        public virtual DbSet<Spclient> Spclients { get; set; }
        public virtual DbSet<Spclientmapmaster> Spclientmapmasters { get; set; }
        public virtual DbSet<SpsiteBaseV> SpsiteBaseVs { get; set; }
        public virtual DbSet<SpsiteV> SpsiteVs { get; set; }
        public virtual DbSet<Spsitemaster> Spsitemasters { get; set; }
        public virtual DbSet<Statemaster> Statemasters { get; set; }
        public virtual DbSet<StatementV> StatementVs { get; set; }
        public virtual DbSet<StatementarchievV> StatementarchievVs { get; set; }
        public virtual DbSet<StatusBaseV> StatusBaseVs { get; set; }
        public virtual DbSet<StatusV> StatusVs { get; set; }
        public virtual DbSet<Statusentity> Statusentities { get; set; }
        public virtual DbSet<Statusmaster> Statusmasters { get; set; }
        public virtual DbSet<SubledgerInt> SubledgerInts { get; set; }
        public virtual DbSet<Symptomsmaster> Symptomsmasters { get; set; }
        public virtual DbSet<SymptomsmasterBaseV> SymptomsmasterBaseVs { get; set; }
        public virtual DbSet<SymptomsmasterV> SymptomsmasterVs { get; set; }
        public virtual DbSet<Systemlocalisation> Systemlocalisations { get; set; }
        public virtual DbSet<Systemsetting> Systemsettings { get; set; }
        public virtual DbSet<T> Ts { get; set; }
        public virtual DbSet<Tallytaskexecution> Tallytaskexecutions { get; set; }
        public virtual DbSet<TaxMaster> TaxMasters { get; set; }
        public virtual DbSet<Tbluser> Tblusers { get; set; }
        public virtual DbSet<TempBank> TempBanks { get; set; }
        public virtual DbSet<TempDseTxnTbl> TempDseTxnTbls { get; set; }
        public virtual DbSet<TempEstimatedDriverEarning> TempEstimatedDriverEarnings { get; set; }
        public virtual DbSet<TempSpSiteBalHist> TempSpSiteBalHists { get; set; }
        public virtual DbSet<TempSpSiteBalTrigger> TempSpSiteBalTriggers { get; set; }
        public virtual DbSet<Tempdevice> Tempdevices { get; set; }
        public virtual DbSet<Tempdocmigration> Tempdocmigrations { get; set; }
        public virtual DbSet<TemplateExecutionTxn> TemplateExecutionTxns { get; set; }
        public virtual DbSet<TemplateTxnV> TemplateTxnVs { get; set; }
        public virtual DbSet<Templateexecution> Templateexecutions { get; set; }
        public virtual DbSet<TemplateexecutionV> TemplateexecutionVs { get; set; }
        public virtual DbSet<TemplateexecutiondetailV> TemplateexecutiondetailVs { get; set; }
        public virtual DbSet<Templateparameter> Templateparameters { get; set; }
        public virtual DbSet<Templatequerycorelatedcol> Templatequerycorelatedcols { get; set; }
        public virtual DbSet<Templatequerycorrelatedcolumn> Templatequerycorrelatedcolumns { get; set; }
        public virtual DbSet<TemporaryTable> TemporaryTables { get; set; }
        public virtual DbSet<Temppragatimanthanlocksync> Temppragatimanthanlocksyncs { get; set; }
        public virtual DbSet<Temppragatimanthanlocksync1> Temppragatimanthanlocksync1s { get; set; }
        public virtual DbSet<Test> Tests { get; set; }
        public virtual DbSet<Test1> Test1s { get; set; }
        public virtual DbSet<Testtable> Testtables { get; set; }
        public virtual DbSet<Trainerdetail> Trainerdetails { get; set; }
        public virtual DbSet<Trainermaster> Trainermasters { get; set; }
        public virtual DbSet<TrainingBatchBaseV> TrainingBatchBaseVs { get; set; }
        public virtual DbSet<TrainingBatchV> TrainingBatchVs { get; set; }
        public virtual DbSet<TrainingManagerV> TrainingManagerVs { get; set; }
        public virtual DbSet<TrainingPersonBaseV> TrainingPersonBaseVs { get; set; }
        public virtual DbSet<TrainingPersonV> TrainingPersonVs { get; set; }
        public virtual DbSet<TrainingPersonphoneV> TrainingPersonphoneVs { get; set; }
        public virtual DbSet<Trainingattendee> Trainingattendees { get; set; }
        public virtual DbSet<Trainingbatchmaster> Trainingbatchmasters { get; set; }
        public virtual DbSet<Trainingmaster> Trainingmasters { get; set; }
        public virtual DbSet<Trainingsubtype> Trainingsubtypes { get; set; }
        public virtual DbSet<Trainingtypemaster> Trainingtypemasters { get; set; }
        public virtual DbSet<TransactionBaseV> TransactionBaseVs { get; set; }
        public virtual DbSet<TransactionV> TransactionVs { get; set; }
        public virtual DbSet<TransactionarchiveBaseV> TransactionarchiveBaseVs { get; set; }
        public virtual DbSet<TransactionarchiveV> TransactionarchiveVs { get; set; }
        public virtual DbSet<Transactioncategory> Transactioncategories { get; set; }
        public virtual DbSet<Transactionclass> Transactionclasses { get; set; }
        public virtual DbSet<Transactionmaster> Transactionmasters { get; set; }
        public virtual DbSet<Transactionmaster06042023> Transactionmaster06042023s { get; set; }
        public virtual DbSet<Transactionmasterarchive> Transactionmasterarchives { get; set; }
        public virtual DbSet<Transactionsource> Transactionsources { get; set; }
        public virtual DbSet<Transactiontype> Transactiontypes { get; set; }
        public virtual DbSet<TransactiontypeBaseV> TransactiontypeBaseVs { get; set; }
        public virtual DbSet<TransactiontypeV> TransactiontypeVs { get; set; }
        public virtual DbSet<TripAllocV> TripAllocVs { get; set; }
        public virtual DbSet<TripDataBaseV> TripDataBaseVs { get; set; }
        public virtual DbSet<TripDataV> TripDataVs { get; set; }
        public virtual DbSet<TripDriverV> TripDriverVs { get; set; }
        public virtual DbSet<TripPhoneV> TripPhoneVs { get; set; }
        public virtual DbSet<TripRevenueV> TripRevenueVs { get; set; }
        public virtual DbSet<TripSummaryMv> TripSummaryMvs { get; set; }
        public virtual DbSet<TripSummaryV> TripSummaryVs { get; set; }
        public virtual DbSet<Tripdata1> Tripdata1s { get; set; }
        public virtual DbSet<Tripdata1Archive> Tripdata1Archives { get; set; }
        public virtual DbSet<Tripdata1ArchiveNew> Tripdata1ArchiveNews { get; set; }
        public virtual DbSet<TripdataArchive> TripdataArchives { get; set; }
        public virtual DbSet<TripdataArchiveNew> TripdataArchiveNews { get; set; }
        public virtual DbSet<Tripdatum> Tripdata { get; set; }
        public virtual DbSet<Triprating> Tripratings { get; set; }
        public virtual DbSet<TriprevanueMv> TriprevanueMvs { get; set; }
        public virtual DbSet<Unitmaster> Unitmasters { get; set; }
        public virtual DbSet<UpdatebalanceBaseV> UpdatebalanceBaseVs { get; set; }
        public virtual DbSet<UpdatebalanceV> UpdatebalanceVs { get; set; }
        public virtual DbSet<UpiTxnFundtransfer> UpiTxnFundtransfers { get; set; }
        public virtual DbSet<UpiTxnTable> UpiTxnTables { get; set; }
        public virtual DbSet<UpiTxnTableTest> UpiTxnTableTests { get; set; }
        public virtual DbSet<UserBaseV> UserBaseVs { get; set; }
        public virtual DbSet<UserJobPositionV> UserJobPositionVs { get; set; }
        public virtual DbSet<UserPositionV> UserPositionVs { get; set; }
        public virtual DbSet<UserV> UserVs { get; set; }
        public virtual DbSet<UserassignedroleV> UserassignedroleVs { get; set; }
        public virtual DbSet<Usercity> Usercities { get; set; }
        public virtual DbSet<Userlocalisation> Userlocalisations { get; set; }
        public virtual DbSet<Usermaster> Usermasters { get; set; }
        public virtual DbSet<Userpassword> Userpasswords { get; set; }
        public virtual DbSet<Userrole> Userroles { get; set; }
        public virtual DbSet<Userroleexclusion> Userroleexclusions { get; set; }
        public virtual DbSet<UserrolesecurityV> UserrolesecurityVs { get; set; }
        public virtual DbSet<Usersetting> Usersettings { get; set; }
        public virtual DbSet<VBalancerefund> VBalancerefunds { get; set; }
        public virtual DbSet<VehicleType> VehicleTypes { get; set; }
        public virtual DbSet<View1> View1s { get; set; }
        public virtual DbSet<View10> View10s { get; set; }
        public virtual DbSet<View11> View11s { get; set; }
        public virtual DbSet<View12> View12s { get; set; }
        public virtual DbSet<View13> View13s { get; set; }
        public virtual DbSet<View14> View14s { get; set; }
        public virtual DbSet<View15> View15s { get; set; }
        public virtual DbSet<View16> View16s { get; set; }
        public virtual DbSet<View2> View2s { get; set; }
        public virtual DbSet<View3> View3s { get; set; }
        public virtual DbSet<View4> View4s { get; set; }
        public virtual DbSet<View5> View5s { get; set; }
        public virtual DbSet<View6> View6s { get; set; }
        public virtual DbSet<View7> View7s { get; set; }
        public virtual DbSet<View8> View8s { get; set; }
        public virtual DbSet<View9> View9s { get; set; }
        public virtual DbSet<WorkrequestBaseV> WorkrequestBaseVs { get; set; }
        public virtual DbSet<WorkrequestV> WorkrequestVs { get; set; }
        public virtual DbSet<Workrequestmaster> Workrequestmasters { get; set; }
        public virtual DbSet<Workshopmaster> Workshopmasters { get; set; }
        public virtual DbSet<Worktypemaster> Worktypemasters { get; set; }
        public virtual DbSet<XmeruArSubsPer> XmeruArSubsPers { get; set; }
        public virtual DbSet<XmeruArSubsPerBkp> XmeruArSubsPerBkps { get; set; }
        public virtual DbSet<XmeruArTerminationDep> XmeruArTerminationDeps { get; set; }
        public virtual DbSet<XmeruBalCorrectionLog> XmeruBalCorrectionLogs { get; set; }
        public virtual DbSet<XmeruBalCorrectionLogDtl> XmeruBalCorrectionLogDtls { get; set; }
        public virtual DbSet<XmeruCustLogTable> XmeruCustLogTables { get; set; }
        public virtual DbSet<XmeruDataLog> XmeruDataLogs { get; set; }
        public virtual DbSet<XmeruEamCasset> XmeruEamCassets { get; set; }
        public virtual DbSet<XmeruEmiBalUpdateTracking> XmeruEmiBalUpdateTrackings { get; set; }
        public virtual DbSet<XmeruFtrReport> XmeruFtrReports { get; set; }
        public virtual DbSet<XmeruGvuploadTbl> XmeruGvuploadTbls { get; set; }
        public virtual DbSet<XmeruInvoiceImportStg> XmeruInvoiceImportStgs { get; set; }
        public virtual DbSet<XmeruLogTable> XmeruLogTables { get; set; }
        public virtual DbSet<XmeruLogTblBkp1> XmeruLogTblBkp1s { get; set; }
        public virtual DbSet<XmeruLogTblBkp2> XmeruLogTblBkp2s { get; set; }
        public virtual DbSet<XmeruLogTblBkp3> XmeruLogTblBkp3s { get; set; }
        public virtual DbSet<XmeruMaxEmpNo> XmeruMaxEmpNos { get; set; }
        public virtual DbSet<XmeruNlsLogTbl> XmeruNlsLogTbls { get; set; }
        public virtual DbSet<XmeruOutstandingHistV> XmeruOutstandingHistVs { get; set; }
        public virtual DbSet<XmeruPerAllPeoplePhoneV> XmeruPerAllPeoplePhoneVs { get; set; }
        public virtual DbSet<XmeruSmsRecipent> XmeruSmsRecipents { get; set; }
        public virtual DbSet<XmeruTempTbl> XmeruTempTbls { get; set; }
        public virtual DbSet<XmeruTxnTbl> XmeruTxnTbls { get; set; }
        public virtual DbSet<XmeruWflTransaction> XmeruWflTransactions { get; set; }
        public virtual DbSet<XmeruWorkshopInspSlot> XmeruWorkshopInspSlots { get; set; }
        public virtual DbSet<XmeruWrVouchersStage> XmeruWrVouchersStages { get; set; }
        public virtual DbSet<ZipdialInterface> ZipdialInterfaces { get; set; }
        public virtual DbSet<ZipdialMapping> ZipdialMappings { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseOracle(Settings.ConnectionString);
                //#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                //              optionsBuilder.UseOracle("User Id=xmeru;Password=meru123;Data Source=192.168.0.24:1521/UPREPROD;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("XMERU")
                .HasAnnotation("Relational:Collation", "USING_NLS_COMP");

            modelBuilder.Entity<Addressverification>(entity =>
            {
                entity.HasKey(e => e.Postcardcode)
                    .HasName("PK_POSTCARDCODE");

                entity.Property(e => e.Postcardcode).IsUnicode(false);

                entity.Property(e => e.Cycle1status).IsUnicode(false);

                entity.Property(e => e.Cycle1usercreated).IsUnicode(false);

                entity.Property(e => e.Cycle2status).IsUnicode(false);

                entity.Property(e => e.Cycle2usercreated).IsUnicode(false);

                entity.Property(e => e.Driverid).IsUnicode(false);

                entity.Property(e => e.Guid).IsUnicode(false);

                entity.Property(e => e.Postcardpath).IsUnicode(false);

                entity.Property(e => e.Postcardusercreated).IsUnicode(false);

                entity.Property(e => e.Setid)
                    .HasPrecision(10)
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Unlockbyuser).IsUnicode(false);

                entity.Property(e => e.Unlockreason).IsUnicode(false);
            });

            modelBuilder.Entity<Addressverisetmaster>(entity =>
            {
                entity.Property(e => e.Branch).IsUnicode(false);

                entity.Property(e => e.Guid).IsUnicode(false);

                entity.Property(e => e.Legalentity).IsUnicode(false);

                entity.Property(e => e.Liveflag).IsUnicode(false);

                entity.Property(e => e.Model).IsUnicode(false);

                entity.Property(e => e.Setid).HasPrecision(10);

                entity.Property(e => e.Usercreated).IsUnicode(false);
            });

            modelBuilder.Entity<Addrvericonfig>(entity =>
            {
                entity.Property(e => e.Cycle2day).HasPrecision(10);

                entity.Property(e => e.Guid).IsUnicode(false);

                entity.Property(e => e.Lockday).HasPrecision(10);

                entity.Property(e => e.Smsday).HasPrecision(10);

                entity.Property(e => e.Usercreated).IsUnicode(false);
            });

            modelBuilder.Entity<Airportparkingentry>(entity =>
            {
                entity.Property(e => e.Carno).IsUnicode(false);

                entity.Property(e => e.Driverid).IsUnicode(false);

                entity.Property(e => e.Entryid).IsUnicode(false);

                entity.Property(e => e.Parkingfee).HasDefaultValueSql("0");

                entity.Property(e => e.Status).IsUnicode(false);

                entity.Property(e => e.Terminalname).IsUnicode(false);
            });

            modelBuilder.Entity<Alertserviceconfig>(entity =>
            {
                entity.HasKey(e => e.Guid)
                    .HasName("ALERTSERVICECONFIG_PK");

                entity.Property(e => e.Guid).IsUnicode(false);

                entity.Property(e => e.Createddate).HasDefaultValueSql("sysdate \n");

                entity.Property(e => e.Disabled)
                    .HasPrecision(1)
                    .HasDefaultValueSql("0 ");

                entity.Property(e => e.Mobilenumbers).IsUnicode(false);

                entity.Property(e => e.Name).IsUnicode(false);

                entity.Property(e => e.Query).IsUnicode(false);
            });

            modelBuilder.Entity<AllDocV>(entity =>
            {
                entity.ToView("ALL_DOC_V");

                entity.Property(e => e.Documentno).IsUnicode(false);

                entity.Property(e => e.Documenttype).IsUnicode(false);

                entity.Property(e => e.Documenttypemastername).IsUnicode(false);

                entity.Property(e => e.Ownerguid).IsUnicode(false);
            });

            modelBuilder.Entity<AllMentorlistV>(entity =>
            {
                entity.ToView("ALL_MENTORLIST_V");

                entity.Property(e => e.EmployeeNumber)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.FullName).IsUnicode(false);

                entity.Property(e => e.Id)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.JobId)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.JobName)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.NpwNumber)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.OrganizationId)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.PersonType)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.PositionId)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.PositionName).IsUnicode(false);
            });

            modelBuilder.Entity<AllocbalanceBaseV>(entity =>
            {
                entity.ToView("ALLOCBALANCE_BASE_V");

                entity.Property(e => e.AllocGuid).IsUnicode(false);

                entity.Property(e => e.AllocPaySiteGuid).IsUnicode(false);

                entity.Property(e => e.AllocPaySiteName).IsUnicode(false);

                entity.Property(e => e.Allocstatusentityguid).IsUnicode(false);

                entity.Property(e => e.Billsiteuseid).IsUnicode(false);

                entity.Property(e => e.CarRegnno).IsUnicode(false);

                entity.Property(e => e.Carmasterguid).IsUnicode(false);

                entity.Property(e => e.EntityCode).IsUnicode(false);

                entity.Property(e => e.Personguid).IsUnicode(false);

                entity.Property(e => e.Sitemasterguid).IsUnicode(false);

                entity.Property(e => e.Sitename).IsUnicode(false);

                entity.Property(e => e.SpBioId).IsUnicode(false);

                entity.Property(e => e.SpGuid).IsUnicode(false);

                entity.Property(e => e.SpLname).IsUnicode(false);

                entity.Property(e => e.SpMname).IsUnicode(false);

                entity.Property(e => e.SpName).IsUnicode(false);

                entity.Property(e => e.SpStatus).IsUnicode(false);

                entity.Property(e => e.Spid).IsUnicode(false);

                entity.Property(e => e.StatusCode).IsUnicode(false);

                entity.Property(e => e.StatusEntStsguid).IsUnicode(false);

                entity.Property(e => e.StatusName).IsUnicode(false);
            });

            modelBuilder.Entity<AllocbalanceV>(entity =>
            {
                entity.ToView("ALLOCBALANCE_V");

                entity.Property(e => e.AllocGuid).IsUnicode(false);

                entity.Property(e => e.AllocPaySiteGuid).IsUnicode(false);

                entity.Property(e => e.AllocPaySiteName).IsUnicode(false);

                entity.Property(e => e.Allocstatusentityguid).IsUnicode(false);

                entity.Property(e => e.Billsiteuseid).IsUnicode(false);

                entity.Property(e => e.CarRegnno).IsUnicode(false);

                entity.Property(e => e.Carmasterguid).IsUnicode(false);

                entity.Property(e => e.EntityCode).IsUnicode(false);

                entity.Property(e => e.Personguid).IsUnicode(false);

                entity.Property(e => e.Sitemasterguid).IsUnicode(false);

                entity.Property(e => e.Sitename).IsUnicode(false);

                entity.Property(e => e.SpBioId).IsUnicode(false);

                entity.Property(e => e.SpGuid).IsUnicode(false);

                entity.Property(e => e.SpLname).IsUnicode(false);

                entity.Property(e => e.SpMname).IsUnicode(false);

                entity.Property(e => e.SpName).IsUnicode(false);

                entity.Property(e => e.SpStatus).IsUnicode(false);

                entity.Property(e => e.Spid).IsUnicode(false);

                entity.Property(e => e.StatusCode).IsUnicode(false);

                entity.Property(e => e.StatusEntStsguid).IsUnicode(false);

                entity.Property(e => e.StatusName).IsUnicode(false);
            });

            modelBuilder.Entity<Anchorlocation>(entity =>
            {
                entity.Property(e => e.Branchmasterguid).IsUnicode(false);

                entity.Property(e => e.Comments).IsUnicode(false);

                entity.Property(e => e.Disabled).HasPrecision(1);

                entity.Property(e => e.Guid).IsUnicode(false);

                entity.Property(e => e.Name).IsUnicode(false);

                entity.Property(e => e.Objectversionno).HasPrecision(10);

                entity.Property(e => e.Oracleentityid).IsUnicode(false);

                entity.Property(e => e.Oracleentityname).IsUnicode(false);

                entity.Property(e => e.Pkguid).IsUnicode(false);

                entity.Property(e => e.Quickaccesscode).IsUnicode(false);

                entity.Property(e => e.Userarchived).IsUnicode(false);

                entity.Property(e => e.Usercreated).IsUnicode(false);

                entity.Property(e => e.Userdeleted).IsUnicode(false);

                entity.Property(e => e.Userupdated).IsUnicode(false);
            });

            modelBuilder.Entity<Answermaster>(entity =>
            {
                entity.Property(e => e.Comments).IsUnicode(false);

                entity.Property(e => e.Description).IsUnicode(false);

                entity.Property(e => e.Disabled).HasPrecision(1);

                entity.Property(e => e.Guid).IsUnicode(false);

                entity.Property(e => e.Name).IsUnicode(false);

                entity.Property(e => e.Objectversionno).HasPrecision(3);

                entity.Property(e => e.Oracleentityid).IsUnicode(false);

                entity.Property(e => e.Oracleentityname).IsUnicode(false);

                entity.Property(e => e.Pkguid).IsUnicode(false);

                entity.Property(e => e.Quickaccesscode).IsUnicode(false);

                entity.Property(e => e.Userarchived).IsUnicode(false);

                entity.Property(e => e.Usercreated).IsUnicode(false);

                entity.Property(e => e.Userdeleted).IsUnicode(false);

                entity.Property(e => e.Userupdated).IsUnicode(false);
            });

            modelBuilder.Entity<AnswersBaseV>(entity =>
            {
                entity.ToView("ANSWERS_BASE_V");

                entity.Property(e => e.Answercomments).IsUnicode(false);

                entity.Property(e => e.Answerdescription).IsUnicode(false);

                entity.Property(e => e.Answerdisabled).HasPrecision(1);

                entity.Property(e => e.Answermasterguid).IsUnicode(false);

                entity.Property(e => e.Answername).IsUnicode(false);

                entity.Property(e => e.Answerobjectversionno).HasPrecision(3);

                entity.Property(e => e.Answeroracleentityid).IsUnicode(false);

                entity.Property(e => e.Answeroracleentityname).IsUnicode(false);

                entity.Property(e => e.Answerpkguid).IsUnicode(false);

                entity.Property(e => e.Answerquickaccesscode).IsUnicode(false);

                entity.Property(e => e.Answerserialnumber).HasPrecision(5);

                entity.Property(e => e.Answertypecomments).IsUnicode(false);

                entity.Property(e => e.Answertypedescription).IsUnicode(false);

                entity.Property(e => e.Answertypedisabled).HasPrecision(1);

                entity.Property(e => e.Answertypemappingguid).IsUnicode(false);

                entity.Property(e => e.Answertypemasterguid).IsUnicode(false);

                entity.Property(e => e.Answertypename).IsUnicode(false);

                entity.Property(e => e.Answertypeobjectversionno).HasPrecision(3);

                entity.Property(e => e.Answertypeoracleentityid).IsUnicode(false);

                entity.Property(e => e.Answertypeoracleentityname).IsUnicode(false);

                entity.Property(e => e.Answertypepkguid).IsUnicode(false);

                entity.Property(e => e.Answertypequickaccesscode).IsUnicode(false);

                entity.Property(e => e.Defaultanswermasterguid).IsUnicode(false);

                entity.Property(e => e.Inspectiontypecomments).IsUnicode(false);

                entity.Property(e => e.Inspectiontypedescription).IsUnicode(false);

                entity.Property(e => e.Inspectiontypedisabled).HasPrecision(1);

                entity.Property(e => e.Inspectiontypemasterguid).IsUnicode(false);

                entity.Property(e => e.Inspectiontypename).IsUnicode(false);

                entity.Property(e => e.Inspectiontypeobjectversionno).HasPrecision(3);

                entity.Property(e => e.Inspectiontypeoracleentityid).IsUnicode(false);

                entity.Property(e => e.Inspectiontypeoracleentityname).IsUnicode(false);

                entity.Property(e => e.Inspectiontypepkguid).IsUnicode(false);

                entity.Property(e => e.Inspectiontypequickaccesscode).IsUnicode(false);

                entity.Property(e => e.Mappingcomments).IsUnicode(false);

                entity.Property(e => e.Mappingdescription).IsUnicode(false);

                entity.Property(e => e.Mappingdisabled).HasPrecision(1);

                entity.Property(e => e.Mappingobjectversionno).HasPrecision(3);

                entity.Property(e => e.Mappingoracleentityid).IsUnicode(false);

                entity.Property(e => e.Mappingoracleentityname).IsUnicode(false);

                entity.Property(e => e.Mappingpkguid).IsUnicode(false);

                entity.Property(e => e.Mappingquickaccesscode).IsUnicode(false);

                entity.Property(e => e.QbankCatComments).IsUnicode(false);

                entity.Property(e => e.QbankCatDescription).IsUnicode(false);

                entity.Property(e => e.QbankCatDisabled).HasPrecision(1);

                entity.Property(e => e.QbankCatName).IsUnicode(false);

                entity.Property(e => e.QbankCatObjectversionno).HasPrecision(3);

                entity.Property(e => e.QbankCatOracleentityid).IsUnicode(false);

                entity.Property(e => e.QbankCatOracleentityname).IsUnicode(false);

                entity.Property(e => e.QbankCatPkguid).IsUnicode(false);

                entity.Property(e => e.QbankCatQuickaccesscode).IsUnicode(false);

                entity.Property(e => e.Questionbankcategorymasterguid).IsUnicode(false);

                entity.Property(e => e.Questionbankcomments).IsUnicode(false);

                entity.Property(e => e.Questionbankdescription).IsUnicode(false);

                entity.Property(e => e.Questionbankdisabled).HasPrecision(1);

                entity.Property(e => e.Questionbankmasterguid).IsUnicode(false);

                entity.Property(e => e.Questionbankmastername).IsUnicode(false);

                entity.Property(e => e.Questionbankobjectversionno).HasPrecision(3);

                entity.Property(e => e.Questionbankoracleentityid).IsUnicode(false);

                entity.Property(e => e.Questionbankoracleentityname).IsUnicode(false);

                entity.Property(e => e.Questionbankpkguid).IsUnicode(false);

                entity.Property(e => e.Questionbankquickaccesscode).IsUnicode(false);
            });

            modelBuilder.Entity<AnswersV>(entity =>
            {
                entity.ToView("ANSWERS_V");

                entity.Property(e => e.Answercomments).IsUnicode(false);

                entity.Property(e => e.Answerdescription).IsUnicode(false);

                entity.Property(e => e.Answerdisabled).HasPrecision(1);

                entity.Property(e => e.Answermasterguid).IsUnicode(false);

                entity.Property(e => e.Answername).IsUnicode(false);

                entity.Property(e => e.Answerobjectversionno).HasPrecision(3);

                entity.Property(e => e.Answeroracleentityid).IsUnicode(false);

                entity.Property(e => e.Answeroracleentityname).IsUnicode(false);

                entity.Property(e => e.Answerpkguid).IsUnicode(false);

                entity.Property(e => e.Answerquickaccesscode).IsUnicode(false);

                entity.Property(e => e.Answerserialnumber).HasPrecision(5);

                entity.Property(e => e.Answertypecomments).IsUnicode(false);

                entity.Property(e => e.Answertypedescription).IsUnicode(false);

                entity.Property(e => e.Answertypedisabled).HasPrecision(1);

                entity.Property(e => e.Answertypemappingguid).IsUnicode(false);

                entity.Property(e => e.Answertypemasterguid).IsUnicode(false);

                entity.Property(e => e.Answertypename).IsUnicode(false);

                entity.Property(e => e.Answertypeobjectversionno).HasPrecision(3);

                entity.Property(e => e.Answertypeoracleentityid).IsUnicode(false);

                entity.Property(e => e.Answertypeoracleentityname).IsUnicode(false);

                entity.Property(e => e.Answertypepkguid).IsUnicode(false);

                entity.Property(e => e.Answertypequickaccesscode).IsUnicode(false);

                entity.Property(e => e.Defaultanswermasterguid).IsUnicode(false);

                entity.Property(e => e.Inspectiontypecomments).IsUnicode(false);

                entity.Property(e => e.Inspectiontypedescription).IsUnicode(false);

                entity.Property(e => e.Inspectiontypedisabled).HasPrecision(1);

                entity.Property(e => e.Inspectiontypemasterguid).IsUnicode(false);

                entity.Property(e => e.Inspectiontypename).IsUnicode(false);

                entity.Property(e => e.Inspectiontypeobjectversionno).HasPrecision(3);

                entity.Property(e => e.Inspectiontypeoracleentityid).IsUnicode(false);

                entity.Property(e => e.Inspectiontypeoracleentityname).IsUnicode(false);

                entity.Property(e => e.Inspectiontypepkguid).IsUnicode(false);

                entity.Property(e => e.Inspectiontypequickaccesscode).IsUnicode(false);

                entity.Property(e => e.Mappingcomments).IsUnicode(false);

                entity.Property(e => e.Mappingdescription).IsUnicode(false);

                entity.Property(e => e.Mappingdisabled).HasPrecision(1);

                entity.Property(e => e.Mappingobjectversionno).HasPrecision(3);

                entity.Property(e => e.Mappingoracleentityid).IsUnicode(false);

                entity.Property(e => e.Mappingoracleentityname).IsUnicode(false);

                entity.Property(e => e.Mappingpkguid).IsUnicode(false);

                entity.Property(e => e.Mappingquickaccesscode).IsUnicode(false);

                entity.Property(e => e.QbankCatComments).IsUnicode(false);

                entity.Property(e => e.QbankCatDescription).IsUnicode(false);

                entity.Property(e => e.QbankCatDisabled).HasPrecision(1);

                entity.Property(e => e.QbankCatName).IsUnicode(false);

                entity.Property(e => e.QbankCatObjectversionno).HasPrecision(3);

                entity.Property(e => e.QbankCatOracleentityid).IsUnicode(false);

                entity.Property(e => e.QbankCatOracleentityname).IsUnicode(false);

                entity.Property(e => e.QbankCatPkguid).IsUnicode(false);

                entity.Property(e => e.QbankCatQuickaccesscode).IsUnicode(false);

                entity.Property(e => e.Questionbankcategorymasterguid).IsUnicode(false);

                entity.Property(e => e.Questionbankcomments).IsUnicode(false);

                entity.Property(e => e.Questionbankdescription).IsUnicode(false);

                entity.Property(e => e.Questionbankdisabled).HasPrecision(1);

                entity.Property(e => e.Questionbankmasterguid).IsUnicode(false);

                entity.Property(e => e.Questionbankmastername).IsUnicode(false);

                entity.Property(e => e.Questionbankobjectversionno).HasPrecision(3);

                entity.Property(e => e.Questionbankoracleentityid).IsUnicode(false);

                entity.Property(e => e.Questionbankoracleentityname).IsUnicode(false);

                entity.Property(e => e.Questionbankpkguid).IsUnicode(false);

                entity.Property(e => e.Questionbankquickaccesscode).IsUnicode(false);
            });

            modelBuilder.Entity<Answertypemapping>(entity =>
            {
                entity.Property(e => e.Answermasterguid).IsUnicode(false);

                entity.Property(e => e.Answerserialnumber).HasPrecision(5);

                entity.Property(e => e.Answertypemasterguid).IsUnicode(false);

                entity.Property(e => e.Comments).IsUnicode(false);

                entity.Property(e => e.Description).IsUnicode(false);

                entity.Property(e => e.Disabled)
                    .HasPrecision(1)
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Guid).IsUnicode(false);

                entity.Property(e => e.Objectversionno).HasPrecision(3);

                entity.Property(e => e.Oracleentityid).IsUnicode(false);

                entity.Property(e => e.Oracleentityname).IsUnicode(false);

                entity.Property(e => e.Pkguid).IsUnicode(false);

                entity.Property(e => e.Quickaccesscode).IsUnicode(false);

                entity.Property(e => e.Userarchived).IsUnicode(false);

                entity.Property(e => e.Usercreated).IsUnicode(false);

                entity.Property(e => e.Userdeleted).IsUnicode(false);

                entity.Property(e => e.Userupdated).IsUnicode(false);
            });

            modelBuilder.Entity<Answertypemaster>(entity =>
            {
                entity.Property(e => e.Comments).IsUnicode(false);

                entity.Property(e => e.Description).IsUnicode(false);

                entity.Property(e => e.Disabled)
                    .HasPrecision(1)
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Guid).IsUnicode(false);

                entity.Property(e => e.Name).IsUnicode(false);

                entity.Property(e => e.Objectversionno).HasPrecision(3);

                entity.Property(e => e.Oracleentityid).IsUnicode(false);

                entity.Property(e => e.Oracleentityname).IsUnicode(false);

                entity.Property(e => e.Pkguid).IsUnicode(false);

                entity.Property(e => e.Quickaccesscode).IsUnicode(false);

                entity.Property(e => e.Userarchived).IsUnicode(false);

                entity.Property(e => e.Usercreated).IsUnicode(false);

                entity.Property(e => e.Userdeleted).IsUnicode(false);

                entity.Property(e => e.Userupdated).IsUnicode(false);
            });

            modelBuilder.Entity<Applicationlogtable>(entity =>
            {
                entity.Property(e => e.Actionmethodname).IsUnicode(false);

                entity.Property(e => e.Controllername).IsUnicode(false);

                entity.Property(e => e.Executionguid).IsUnicode(false);

                entity.Property(e => e.Filename).IsUnicode(false);

                entity.Property(e => e.Message).IsUnicode(false);

                entity.Property(e => e.Sessionid).IsUnicode(false);

                entity.Property(e => e.Username).IsUnicode(false);
            });

            modelBuilder.Entity<Applicationpageaction>(entity =>
            {
                entity.Property(e => e.Applicationpagemasterguid).IsUnicode(false);

                entity.Property(e => e.Comments).IsUnicode(false);

                entity.Property(e => e.Description).IsUnicode(false);

                entity.Property(e => e.Disabled).HasPrecision(1);

                entity.Property(e => e.Guid).IsUnicode(false);

                entity.Property(e => e.Name).IsUnicode(false);

                entity.Property(e => e.Objectversionno).HasPrecision(10);

                entity.Property(e => e.Oracleentityid).IsUnicode(false);

                entity.Property(e => e.Oracleentityname).IsUnicode(false);

                entity.Property(e => e.Pageactionmasterguid).IsUnicode(false);

                entity.Property(e => e.Pkguid).IsUnicode(false);

                entity.Property(e => e.Quickaccesscode).IsUnicode(false);

                entity.Property(e => e.Userarchived).IsUnicode(false);

                entity.Property(e => e.Usercreated).IsUnicode(false);

                entity.Property(e => e.Userdeleted).IsUnicode(false);

                entity.Property(e => e.Userupdated).IsUnicode(false);
            });

            modelBuilder.Entity<Applicationpageactionrole>(entity =>
            {
                entity.Property(e => e.Applicationpageactionguid).IsUnicode(false);

                entity.Property(e => e.Comments).IsUnicode(false);

                entity.Property(e => e.Description).IsUnicode(false);

                entity.Property(e => e.Disabled).HasPrecision(1);

                entity.Property(e => e.Guid).IsUnicode(false);

                entity.Property(e => e.Name).IsUnicode(false);

                entity.Property(e => e.Objectversionno)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Oracleentityid)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Oracleentityname)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Pkguid).IsUnicode(false);

                entity.Property(e => e.Quickaccesscode).IsUnicode(false);

                entity.Property(e => e.Roleguid).IsUnicode(false);

                entity.Property(e => e.Userarchived).IsUnicode(false);

                entity.Property(e => e.Usercreated).IsUnicode(false);

                entity.Property(e => e.Userdeleted).IsUnicode(false);

                entity.Property(e => e.Userupdated).IsUnicode(false);
            });

            modelBuilder.Entity<ApplicationpageactionroleV>(entity =>
            {
                entity.ToView("APPLICATIONPAGEACTIONROLE_V");

                entity.Property(e => e.Applicationpageactionguid).IsUnicode(false);

                entity.Property(e => e.Applicationpageactionroleguid).IsUnicode(false);

                entity.Property(e => e.ApplicationpagemasterCode).IsUnicode(false);

                entity.Property(e => e.Applicationpagemasterguid).IsUnicode(false);

                entity.Property(e => e.Applicationpagemastername).IsUnicode(false);

                entity.Property(e => e.PageactionmasterCode).IsUnicode(false);

                entity.Property(e => e.PageactionmasterName).IsUnicode(false);

                entity.Property(e => e.Pageactionmasterguid).IsUnicode(false);

                entity.Property(e => e.Roleguid).IsUnicode(false);

                entity.Property(e => e.RolemasterCode).IsUnicode(false);

                entity.Property(e => e.RolemasterName).IsUnicode(false);
            });

            modelBuilder.Entity<Applicationpagemaster>(entity =>
            {
                entity.Property(e => e.Comments).IsUnicode(false);

                entity.Property(e => e.Description).IsUnicode(false);

                entity.Property(e => e.Disabled).HasPrecision(1);

                entity.Property(e => e.Guid).IsUnicode(false);

                entity.Property(e => e.Name).IsUnicode(false);

                entity.Property(e => e.Objectversionno).HasPrecision(10);

                entity.Property(e => e.Oracleentityid).IsUnicode(false);

                entity.Property(e => e.Oracleentityname).IsUnicode(false);

                entity.Property(e => e.Pkguid).IsUnicode(false);

                entity.Property(e => e.Quickaccesscode).IsUnicode(false);

                entity.Property(e => e.Userarchived).IsUnicode(false);

                entity.Property(e => e.Usercreated).IsUnicode(false);

                entity.Property(e => e.Userdeleted).IsUnicode(false);

                entity.Property(e => e.Userupdated).IsUnicode(false);
            });

            modelBuilder.Entity<ArPaymentSchedulesAll>(entity =>
            {
                entity.Property(e => e.ActiveClaimFlag).IsUnicode(false);

                entity.Property(e => e.AdjustmentIdLast).HasPrecision(15);

                entity.Property(e => e.AssociatedCashReceiptId).HasPrecision(15);

                entity.Property(e => e.Attribute1).IsUnicode(false);

                entity.Property(e => e.Attribute10).IsUnicode(false);

                entity.Property(e => e.Attribute11).IsUnicode(false);

                entity.Property(e => e.Attribute12).IsUnicode(false);

                entity.Property(e => e.Attribute13).IsUnicode(false);

                entity.Property(e => e.Attribute14).IsUnicode(false);

                entity.Property(e => e.Attribute15).IsUnicode(false);

                entity.Property(e => e.Attribute2).IsUnicode(false);

                entity.Property(e => e.Attribute3).IsUnicode(false);

                entity.Property(e => e.Attribute4).IsUnicode(false);

                entity.Property(e => e.Attribute5).IsUnicode(false);

                entity.Property(e => e.Attribute6).IsUnicode(false);

                entity.Property(e => e.Attribute7).IsUnicode(false);

                entity.Property(e => e.Attribute8).IsUnicode(false);

                entity.Property(e => e.Attribute9).IsUnicode(false);

                entity.Property(e => e.AttributeCategory).IsUnicode(false);

                entity.Property(e => e.CashAppliedStatusLast).IsUnicode(false);

                entity.Property(e => e.CashReceiptId).HasPrecision(15);

                entity.Property(e => e.CashReceiptIdLast).HasPrecision(15);

                entity.Property(e => e.CashReceiptStatusLast).IsUnicode(false);

                entity.Property(e => e.Class).IsUnicode(false);

                entity.Property(e => e.CollectorLast).HasPrecision(15);

                entity.Property(e => e.ConsInvId).HasPrecision(15);

                entity.Property(e => e.ConsInvIdRev).HasPrecision(15);

                entity.Property(e => e.CreatedBy).HasPrecision(15);

                entity.Property(e => e.CustTrxTypeId).HasPrecision(15);

                entity.Property(e => e.CustomerId).HasPrecision(15);

                entity.Property(e => e.CustomerSiteUseId).HasPrecision(15);

                entity.Property(e => e.CustomerTrxId).HasPrecision(15);

                entity.Property(e => e.ExchangeRateType).IsUnicode(false);

                entity.Property(e => e.ExcludeFromConsBillFlag).IsUnicode(false);

                entity.Property(e => e.ExcludeFromDunningFlag).IsUnicode(false);

                entity.Property(e => e.FollowUpCodeLast).IsUnicode(false);

                entity.Property(e => e.GlobalAttribute1).IsUnicode(false);

                entity.Property(e => e.GlobalAttribute10).IsUnicode(false);

                entity.Property(e => e.GlobalAttribute11).IsUnicode(false);

                entity.Property(e => e.GlobalAttribute12).IsUnicode(false);

                entity.Property(e => e.GlobalAttribute13).IsUnicode(false);

                entity.Property(e => e.GlobalAttribute14).IsUnicode(false);

                entity.Property(e => e.GlobalAttribute15).IsUnicode(false);

                entity.Property(e => e.GlobalAttribute16).IsUnicode(false);

                entity.Property(e => e.GlobalAttribute17).IsUnicode(false);

                entity.Property(e => e.GlobalAttribute18).IsUnicode(false);

                entity.Property(e => e.GlobalAttribute19).IsUnicode(false);

                entity.Property(e => e.GlobalAttribute2).IsUnicode(false);

                entity.Property(e => e.GlobalAttribute20).IsUnicode(false);

                entity.Property(e => e.GlobalAttribute3).IsUnicode(false);

                entity.Property(e => e.GlobalAttribute4).IsUnicode(false);

                entity.Property(e => e.GlobalAttribute5).IsUnicode(false);

                entity.Property(e => e.GlobalAttribute6).IsUnicode(false);

                entity.Property(e => e.GlobalAttribute7).IsUnicode(false);

                entity.Property(e => e.GlobalAttribute8).IsUnicode(false);

                entity.Property(e => e.GlobalAttribute9).IsUnicode(false);

                entity.Property(e => e.GlobalAttributeCategory).IsUnicode(false);

                entity.Property(e => e.InCollection).IsUnicode(false);

                entity.Property(e => e.InvoiceCurrencyCode).IsUnicode(false);

                entity.Property(e => e.LastUpdateLogin).HasPrecision(15);

                entity.Property(e => e.LastUpdatedBy).HasPrecision(15);

                entity.Property(e => e.MrcAcctdAmountDueRemaining).IsUnicode(false);

                entity.Property(e => e.MrcCustomerTrxId).IsUnicode(false);

                entity.Property(e => e.MrcExchangeDate).IsUnicode(false);

                entity.Property(e => e.MrcExchangeRate).IsUnicode(false);

                entity.Property(e => e.MrcExchangeRateType).IsUnicode(false);

                entity.Property(e => e.NumberOfDueDates).HasPrecision(15);

                entity.Property(e => e.OrgId)
                    .HasPrecision(15)
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.PaymentApproval).IsUnicode(false);

                entity.Property(e => e.PaymentScheduleId).HasPrecision(15);

                entity.Property(e => e.ProgramApplicationId).HasPrecision(15);

                entity.Property(e => e.ProgramId).HasPrecision(15);

                entity.Property(e => e.ReceiptConfirmedFlag).IsUnicode(false);

                entity.Property(e => e.RequestId).HasPrecision(15);

                entity.Property(e => e.ReservedType).IsUnicode(false);

                entity.Property(e => e.ReservedValue).HasPrecision(15);

                entity.Property(e => e.ReversedCashReceiptId).HasPrecision(15);

                entity.Property(e => e.SelectedForReceiptBatchId).HasPrecision(15);

                entity.Property(e => e.StagedDunningLevel).HasPrecision(2);

                entity.Property(e => e.Status).IsUnicode(false);

                entity.Property(e => e.TermId).HasPrecision(15);

                entity.Property(e => e.TermsSequenceNumber).HasPrecision(15);

                entity.Property(e => e.TrxNumber).IsUnicode(false);
            });

            modelBuilder.Entity<ArPaymentSchedulesAllArchive>(entity =>
            {
                entity.Property(e => e.ActiveClaimFlag).IsUnicode(false);

                entity.Property(e => e.AdjustmentIdLast).HasPrecision(15);

                entity.Property(e => e.AssociatedCashReceiptId).HasPrecision(15);

                entity.Property(e => e.Attribute1).IsUnicode(false);

                entity.Property(e => e.Attribute10).IsUnicode(false);

                entity.Property(e => e.Attribute11).IsUnicode(false);

                entity.Property(e => e.Attribute12).IsUnicode(false);

                entity.Property(e => e.Attribute13).IsUnicode(false);

                entity.Property(e => e.Attribute14).IsUnicode(false);

                entity.Property(e => e.Attribute15).IsUnicode(false);

                entity.Property(e => e.Attribute2).IsUnicode(false);

                entity.Property(e => e.Attribute3).IsUnicode(false);

                entity.Property(e => e.Attribute4).IsUnicode(false);

                entity.Property(e => e.Attribute5).IsUnicode(false);

                entity.Property(e => e.Attribute6).IsUnicode(false);

                entity.Property(e => e.Attribute7).IsUnicode(false);

                entity.Property(e => e.Attribute8).IsUnicode(false);

                entity.Property(e => e.Attribute9).IsUnicode(false);

                entity.Property(e => e.AttributeCategory).IsUnicode(false);

                entity.Property(e => e.CashAppliedStatusLast).IsUnicode(false);

                entity.Property(e => e.CashReceiptId).HasPrecision(15);

                entity.Property(e => e.CashReceiptIdLast).HasPrecision(15);

                entity.Property(e => e.CashReceiptStatusLast).IsUnicode(false);

                entity.Property(e => e.Class).IsUnicode(false);

                entity.Property(e => e.CollectorLast).HasPrecision(15);

                entity.Property(e => e.ConsInvId).HasPrecision(15);

                entity.Property(e => e.ConsInvIdRev).HasPrecision(15);

                entity.Property(e => e.CreatedBy).HasPrecision(15);

                entity.Property(e => e.CustTrxTypeId).HasPrecision(15);

                entity.Property(e => e.CustomerId).HasPrecision(15);

                entity.Property(e => e.CustomerSiteUseId).HasPrecision(15);

                entity.Property(e => e.CustomerTrxId).HasPrecision(15);

                entity.Property(e => e.ExchangeRateType).IsUnicode(false);

                entity.Property(e => e.ExcludeFromConsBillFlag).IsUnicode(false);

                entity.Property(e => e.ExcludeFromDunningFlag).IsUnicode(false);

                entity.Property(e => e.FollowUpCodeLast).IsUnicode(false);

                entity.Property(e => e.GlobalAttribute1).IsUnicode(false);

                entity.Property(e => e.GlobalAttribute10).IsUnicode(false);

                entity.Property(e => e.GlobalAttribute11).IsUnicode(false);

                entity.Property(e => e.GlobalAttribute12).IsUnicode(false);

                entity.Property(e => e.GlobalAttribute13).IsUnicode(false);

                entity.Property(e => e.GlobalAttribute14).IsUnicode(false);

                entity.Property(e => e.GlobalAttribute15).IsUnicode(false);

                entity.Property(e => e.GlobalAttribute16).IsUnicode(false);

                entity.Property(e => e.GlobalAttribute17).IsUnicode(false);

                entity.Property(e => e.GlobalAttribute18).IsUnicode(false);

                entity.Property(e => e.GlobalAttribute19).IsUnicode(false);

                entity.Property(e => e.GlobalAttribute2).IsUnicode(false);

                entity.Property(e => e.GlobalAttribute20).IsUnicode(false);

                entity.Property(e => e.GlobalAttribute3).IsUnicode(false);

                entity.Property(e => e.GlobalAttribute4).IsUnicode(false);

                entity.Property(e => e.GlobalAttribute5).IsUnicode(false);

                entity.Property(e => e.GlobalAttribute6).IsUnicode(false);

                entity.Property(e => e.GlobalAttribute7).IsUnicode(false);

                entity.Property(e => e.GlobalAttribute8).IsUnicode(false);

                entity.Property(e => e.GlobalAttribute9).IsUnicode(false);

                entity.Property(e => e.GlobalAttributeCategory).IsUnicode(false);

                entity.Property(e => e.InCollection).IsUnicode(false);

                entity.Property(e => e.InvoiceCurrencyCode).IsUnicode(false);

                entity.Property(e => e.LastUpdateLogin).HasPrecision(15);

                entity.Property(e => e.LastUpdatedBy).HasPrecision(15);

                entity.Property(e => e.MrcAcctdAmountDueRemaining).IsUnicode(false);

                entity.Property(e => e.MrcCustomerTrxId).IsUnicode(false);

                entity.Property(e => e.MrcExchangeDate).IsUnicode(false);

                entity.Property(e => e.MrcExchangeRate).IsUnicode(false);

                entity.Property(e => e.MrcExchangeRateType).IsUnicode(false);

                entity.Property(e => e.NumberOfDueDates).HasPrecision(15);

                entity.Property(e => e.OrgId).HasPrecision(15);

                entity.Property(e => e.PaymentApproval).IsUnicode(false);

                entity.Property(e => e.PaymentScheduleId).HasPrecision(15);

                entity.Property(e => e.ProgramApplicationId).HasPrecision(15);

                entity.Property(e => e.ProgramId).HasPrecision(15);

                entity.Property(e => e.ReceiptConfirmedFlag).IsUnicode(false);

                entity.Property(e => e.RequestId).HasPrecision(15);

                entity.Property(e => e.ReservedType).IsUnicode(false);

                entity.Property(e => e.ReservedValue).HasPrecision(15);

                entity.Property(e => e.ReversedCashReceiptId).HasPrecision(15);

                entity.Property(e => e.SelectedForReceiptBatchId).HasPrecision(15);

                entity.Property(e => e.StagedDunningLevel).HasPrecision(2);

                entity.Property(e => e.Status).IsUnicode(false);

                entity.Property(e => e.TermId).HasPrecision(15);

                entity.Property(e => e.TermsSequenceNumber).HasPrecision(15);

                entity.Property(e => e.TrxNumber).IsUnicode(false);
            });

            modelBuilder.Entity<ArReceiptMethodAccountsAll>(entity =>
            {
                entity.Property(e => e.Attribute1).IsUnicode(false);

                entity.Property(e => e.BranchCode).IsUnicode(false);

                entity.Property(e => e.Legalentity).IsUnicode(false);
            });

            modelBuilder.Entity<Avoidtxnupdatebalance>(entity =>
            {
                entity.Property(e => e.Disabled).HasPrecision(1);

                entity.Property(e => e.Guid).IsUnicode(false);

                entity.Property(e => e.Securitycombinationguid).IsUnicode(false);

                entity.Property(e => e.Transactiontypeguid).IsUnicode(false);
            });

            modelBuilder.Entity<Avoidtxnupdatebalancebymodel>(entity =>
            {
                entity.Property(e => e.Branchmasterguid).IsUnicode(false);

                entity.Property(e => e.Disabled).HasPrecision(1);

                entity.Property(e => e.Guid).IsUnicode(false);

                entity.Property(e => e.Modelmasterguid).IsUnicode(false);

                entity.Property(e => e.Transactiontypeguid).IsUnicode(false);
            });

            modelBuilder.Entity<Bankbranchmaster>(entity =>
            {
                entity.HasKey(e => e.Guid)
                    .HasName("SYS_C0010821");

                entity.Property(e => e.Guid).IsUnicode(false);

                entity.Property(e => e.Disabled).HasPrecision(1);

                entity.Property(e => e.Name).IsUnicode(false);

                entity.Property(e => e.Usercreated).IsUnicode(false);
            });

            modelBuilder.Entity<Bankmaster>(entity =>
            {
                entity.HasKey(e => e.Guid)
                    .HasName("SYS_C0010820");

                entity.Property(e => e.Guid).IsUnicode(false);

                entity.Property(e => e.Disabled).HasPrecision(1);

                entity.Property(e => e.Name).IsUnicode(false);

                entity.Property(e => e.Usercreated).IsUnicode(false);
            });

            modelBuilder.Entity<Bbmparameter>(entity =>
            {
                entity.Property(e => e.BranchGuid).IsUnicode(false);

                entity.Property(e => e.BrandGuid).IsUnicode(false);

                entity.Property(e => e.Disabled).HasPrecision(1);

                entity.Property(e => e.Guid).IsUnicode(false);

                entity.Property(e => e.LeGuid).IsUnicode(false);

                entity.Property(e => e.ModelGuid).IsUnicode(false);

                entity.Property(e => e.Objectversionno).HasPrecision(3);

                entity.Property(e => e.Oracleentityid).IsUnicode(false);

                entity.Property(e => e.Oracleentityname).IsUnicode(false);

                entity.Property(e => e.Parametermasterguid).IsUnicode(false);

                entity.Property(e => e.Parametervalue).IsUnicode(false);

                entity.Property(e => e.Pkguid).IsUnicode(false);

                entity.Property(e => e.Securitycombinationguid).IsUnicode(false);

                entity.Property(e => e.Transactiontypeguid).IsUnicode(false);

                entity.Property(e => e.Unitmasterguid).IsUnicode(false);

                entity.Property(e => e.Userarchived)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Usercreated)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Userdeleted)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Userupdated)
                    .IsUnicode(false)
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<BbmparameterBaseV>(entity =>
            {
                entity.ToView("BBMPARAMETER_BASE_V");

                entity.Property(e => e.BbmBranchGuid).IsUnicode(false);

                entity.Property(e => e.BbmBrandGuid).IsUnicode(false);

                entity.Property(e => e.BbmLeGuid).IsUnicode(false);

                entity.Property(e => e.BbmModelGuid).IsUnicode(false);

                entity.Property(e => e.BrandCode).IsUnicode(false);

                entity.Property(e => e.BrandGuid).IsUnicode(false);

                entity.Property(e => e.BrandName).IsUnicode(false);

                entity.Property(e => e.CityCode).IsUnicode(false);

                entity.Property(e => e.CityGuid).IsUnicode(false);

                entity.Property(e => e.CityName).IsUnicode(false);

                entity.Property(e => e.Disabled).HasPrecision(1);

                entity.Property(e => e.GlSegment1).IsUnicode(false);

                entity.Property(e => e.GlSement4).IsUnicode(false);

                entity.Property(e => e.GlSement6).IsUnicode(false);

                entity.Property(e => e.Guid).IsUnicode(false);

                entity.Property(e => e.LeCode).IsUnicode(false);

                entity.Property(e => e.LeGuid).IsUnicode(false);

                entity.Property(e => e.LeName).IsUnicode(false);

                entity.Property(e => e.LebranchGuid).IsUnicode(false);

                entity.Property(e => e.ModelCode).IsUnicode(false);

                entity.Property(e => e.ModelGuid).IsUnicode(false);

                entity.Property(e => e.ModelName).IsUnicode(false);

                entity.Property(e => e.Objectversionno).HasPrecision(3);

                entity.Property(e => e.Oracleentityid).IsUnicode(false);

                entity.Property(e => e.Oracleentityname).IsUnicode(false);

                entity.Property(e => e.OrgId).HasPrecision(4);

                entity.Property(e => e.Parametercomments).IsUnicode(false);

                entity.Property(e => e.Parameterdescription).IsUnicode(false);

                entity.Property(e => e.Parameterdisabled).HasPrecision(1);

                entity.Property(e => e.Parametermasterguid).IsUnicode(false);

                entity.Property(e => e.Parametername).IsUnicode(false);

                entity.Property(e => e.Parameterquickaccesscode).IsUnicode(false);

                entity.Property(e => e.Parametervalue).IsUnicode(false);

                entity.Property(e => e.SecObjVerNo).HasPrecision(10);

                entity.Property(e => e.Securitycombinationguid).IsUnicode(false);

                entity.Property(e => e.Transactiontypeguid).IsUnicode(false);

                entity.Property(e => e.Unitmasterguid).IsUnicode(false);

                entity.Property(e => e.Userarchived)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Usercreated)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Userdeleted)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Userupdated)
                    .IsUnicode(false)
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<BbmparameterV>(entity =>
            {
                entity.ToView("BBMPARAMETER_V");

                entity.Property(e => e.BbmBranchGuid).IsUnicode(false);

                entity.Property(e => e.BbmBrandGuid).IsUnicode(false);

                entity.Property(e => e.BbmLeGuid).IsUnicode(false);

                entity.Property(e => e.BbmModelGuid).IsUnicode(false);

                entity.Property(e => e.BrandCode).IsUnicode(false);

                entity.Property(e => e.BrandGuid).IsUnicode(false);

                entity.Property(e => e.BrandName).IsUnicode(false);

                entity.Property(e => e.CityCode).IsUnicode(false);

                entity.Property(e => e.CityGuid).IsUnicode(false);

                entity.Property(e => e.CityName).IsUnicode(false);

                entity.Property(e => e.Disabled).HasPrecision(1);

                entity.Property(e => e.GlSegment1).IsUnicode(false);

                entity.Property(e => e.GlSement4).IsUnicode(false);

                entity.Property(e => e.GlSement6).IsUnicode(false);

                entity.Property(e => e.Guid).IsUnicode(false);

                entity.Property(e => e.LeCode).IsUnicode(false);

                entity.Property(e => e.LeGuid).IsUnicode(false);

                entity.Property(e => e.LeName).IsUnicode(false);

                entity.Property(e => e.LebranchGuid).IsUnicode(false);

                entity.Property(e => e.ModelCode).IsUnicode(false);

                entity.Property(e => e.ModelGuid).IsUnicode(false);

                entity.Property(e => e.ModelName).IsUnicode(false);

                entity.Property(e => e.Objectversionno).HasPrecision(3);

                entity.Property(e => e.Oracleentityid).IsUnicode(false);

                entity.Property(e => e.Oracleentityname).IsUnicode(false);

                entity.Property(e => e.OrgId).HasPrecision(4);

                entity.Property(e => e.Parametercomments).IsUnicode(false);

                entity.Property(e => e.Parameterdescription).IsUnicode(false);

                entity.Property(e => e.Parameterdisabled).HasPrecision(1);

                entity.Property(e => e.Parametermasterguid).IsUnicode(false);

                entity.Property(e => e.Parametername).IsUnicode(false);

                entity.Property(e => e.Parameterquickaccesscode).IsUnicode(false);

                entity.Property(e => e.Parametervalue).IsUnicode(false);

                entity.Property(e => e.SecObjVerNo).HasPrecision(10);

                entity.Property(e => e.Securitycombinationguid).IsUnicode(false);

                entity.Property(e => e.Transactiontypeguid).IsUnicode(false);

                entity.Property(e => e.Unitmasterguid).IsUnicode(false);

                entity.Property(e => e.Userarchived)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Usercreated)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Userdeleted)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Userupdated)
                    .IsUnicode(false)
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<Blacklist>(entity =>
            {
                entity.Property(e => e.Comments).IsUnicode(false);

                entity.Property(e => e.Guid).IsUnicode(false);

                entity.Property(e => e.Objectversionno).HasPrecision(3);

                entity.Property(e => e.Oracleentityid).IsUnicode(false);

                entity.Property(e => e.Oracleentityname).IsUnicode(false);

                entity.Property(e => e.Personmasterguid).IsUnicode(false);

                entity.Property(e => e.Pkguid).IsUnicode(false);

                entity.Property(e => e.Statusentityguid).IsUnicode(false);

                entity.Property(e => e.Userarchived).IsUnicode(false);

                entity.Property(e => e.Usercreated).IsUnicode(false);

                entity.Property(e => e.Userdeleted).IsUnicode(false);

                entity.Property(e => e.Userupdated).IsUnicode(false);
            });

            modelBuilder.Entity<Branchmaster>(entity =>
            {
                entity.Property(e => e.Campaignname).IsUnicode(false);

                entity.Property(e => e.Ccphoneno).IsUnicode(false);

                entity.Property(e => e.Comments).IsUnicode(false);

                entity.Property(e => e.Costcenter).IsUnicode(false);

                entity.Property(e => e.Countrymasterguid).IsUnicode(false);

                entity.Property(e => e.Description).IsUnicode(false);

                entity.Property(e => e.Dialno).IsUnicode(false);

                entity.Property(e => e.Disabled).HasPrecision(1);

                entity.Property(e => e.Guid).IsUnicode(false);

                entity.Property(e => e.Manthancityid).HasPrecision(3);

                entity.Property(e => e.Name).IsUnicode(false);

                entity.Property(e => e.Objectversionno).HasPrecision(10);

                entity.Property(e => e.Oracleentityid).IsUnicode(false);

                entity.Property(e => e.Oracleentityname).IsUnicode(false);

                entity.Property(e => e.Pkguid).IsUnicode(false);

                entity.Property(e => e.Profitcenter).IsUnicode(false);

                entity.Property(e => e.Quickaccesscode).IsUnicode(false);

                entity.Property(e => e.Sapbusinessplace).IsUnicode(false);

                entity.Property(e => e.Sapcitycode).IsUnicode(false);

                entity.Property(e => e.Sapinternalorder).IsUnicode(false);

                entity.Property(e => e.Showinverificationscreen)
                    .HasPrecision(1)
                    .HasDefaultValueSql("(1)");

                entity.Property(e => e.Userarchived).IsUnicode(false);

                entity.Property(e => e.Usercreated).IsUnicode(false);

                entity.Property(e => e.Userdeleted).IsUnicode(false);

                entity.Property(e => e.Userupdated).IsUnicode(false);
            });

            modelBuilder.Entity<Brandmaster>(entity =>
            {
                entity.HasKey(e => e.Guid)
                    .HasName("BRANDMASTER_PK");

                entity.Property(e => e.Guid).IsUnicode(false);

                entity.Property(e => e.Comments).IsUnicode(false);

                entity.Property(e => e.Description).IsUnicode(false);

                entity.Property(e => e.Disabled).HasPrecision(1);

                entity.Property(e => e.Manthanbrandid).HasPrecision(3);

                entity.Property(e => e.Manthanbrandtype).IsUnicode(false);

                entity.Property(e => e.Name).IsUnicode(false);

                entity.Property(e => e.Objectversionno).HasPrecision(10);

                entity.Property(e => e.Oracleentityid).IsUnicode(false);

                entity.Property(e => e.Oracleentityname).IsUnicode(false);

                entity.Property(e => e.Pkguid).IsUnicode(false);

                entity.Property(e => e.Quickaccesscode).IsUnicode(false);

                entity.Property(e => e.Showinverificationscreen)
                    .HasPrecision(1)
                    .HasDefaultValueSql("(1)");

                entity.Property(e => e.Userarchived).IsUnicode(false);

                entity.Property(e => e.Usercreated).IsUnicode(false);

                entity.Property(e => e.Userdeleted).IsUnicode(false);

                entity.Property(e => e.Userupdated).IsUnicode(false);
            });

            modelBuilder.Entity<Broadcastmessagemaster>(entity =>
            {
                entity.HasKey(e => e.Guid)
                    .HasName("SYS_C009965");

                entity.Property(e => e.Guid).IsUnicode(false);

                entity.Property(e => e.Branchmasterguid).IsUnicode(false);

                entity.Property(e => e.Brandmasterguid).IsUnicode(false);

                entity.Property(e => e.Disabled)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(0) ")
                    .IsFixedLength(true);

                entity.Property(e => e.Modelmasterguid).IsUnicode(false);

                entity.Property(e => e.Objectversionno).IsUnicode(false);

                entity.Property(e => e.Oracleentityid).IsUnicode(false);

                entity.Property(e => e.Oracleentityname).IsUnicode(false);

                entity.Property(e => e.Pkguid).IsUnicode(false);

                entity.Property(e => e.Userarchived).IsUnicode(false);

                entity.Property(e => e.Usercreated).IsUnicode(false);

                entity.Property(e => e.Userdeleted).IsUnicode(false);

                entity.Property(e => e.Userupdated).IsUnicode(false);
            });

            modelBuilder.Entity<Businesscategorymaster>(entity =>
            {
                entity.Property(e => e.Comments).IsUnicode(false);

                entity.Property(e => e.Description).IsUnicode(false);

                entity.Property(e => e.Disabled).HasPrecision(1);

                entity.Property(e => e.Guid).IsUnicode(false);

                entity.Property(e => e.Name).IsUnicode(false);

                entity.Property(e => e.Objectversionno).HasPrecision(10);

                entity.Property(e => e.Oracleentityid).IsUnicode(false);

                entity.Property(e => e.Oracleentityname).IsUnicode(false);

                entity.Property(e => e.Pkguid).IsUnicode(false);

                entity.Property(e => e.Quickaccesscode).IsUnicode(false);

                entity.Property(e => e.Userarchived).IsUnicode(false);

                entity.Property(e => e.Usercreated).IsUnicode(false);

                entity.Property(e => e.Userdeleted).IsUnicode(false);

                entity.Property(e => e.Userupdated).IsUnicode(false);
            });

            modelBuilder.Entity<CarAccrualV>(entity =>
            {
                entity.ToView("CAR_ACCRUAL_V");

                entity.Property(e => e.BrandCode).IsUnicode(false);

                entity.Property(e => e.BrandGuid).IsUnicode(false);

                entity.Property(e => e.BrandName).IsUnicode(false);

                entity.Property(e => e.CarGuid).IsUnicode(false);

                entity.Property(e => e.CarGvguid).IsUnicode(false);

                entity.Property(e => e.CarGvname).IsUnicode(false);

                entity.Property(e => e.CarMake).IsUnicode(false);

                entity.Property(e => e.CarModel).IsUnicode(false);

                entity.Property(e => e.CarRegnNo).IsUnicode(false);

                entity.Property(e => e.CarStatusCode).IsUnicode(false);

                entity.Property(e => e.CarStatusName).IsUnicode(false);

                entity.Property(e => e.CityCode).IsUnicode(false);

                entity.Property(e => e.CityGuid).IsUnicode(false);

                entity.Property(e => e.CityName).IsUnicode(false);

                entity.Property(e => e.CycleDaysCode).IsUnicode(false);

                entity.Property(e => e.CycleDaysGuid)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.CycleDaysName).IsUnicode(false);

                entity.Property(e => e.GlSegment1).IsUnicode(false);

                entity.Property(e => e.GlSement4).IsUnicode(false);

                entity.Property(e => e.GlSement6).IsUnicode(false);

                entity.Property(e => e.GvcCode).IsUnicode(false);

                entity.Property(e => e.GvcFreqCode).IsUnicode(false);

                entity.Property(e => e.GvcFreqGuid).IsUnicode(false);

                entity.Property(e => e.GvcFreqName).IsUnicode(false);

                entity.Property(e => e.GvcGuid).IsUnicode(false);

                entity.Property(e => e.GvcObjVerNo).HasPrecision(3);

                entity.Property(e => e.GvcValue).IsUnicode(false);

                entity.Property(e => e.GvcValuetype).IsUnicode(false);

                entity.Property(e => e.LeCode).IsUnicode(false);

                entity.Property(e => e.LeGuid).IsUnicode(false);

                entity.Property(e => e.LeName).IsUnicode(false);

                entity.Property(e => e.LebranchGuid).IsUnicode(false);

                entity.Property(e => e.ModelCode).IsUnicode(false);

                entity.Property(e => e.ModelGuid).IsUnicode(false);

                entity.Property(e => e.ModelName).IsUnicode(false);

                entity.Property(e => e.OrgId).HasPrecision(4);

                entity.Property(e => e.SecGuid).IsUnicode(false);

                entity.Property(e => e.SecObjVerNo).HasPrecision(10);

                entity.Property(e => e.TxnClassCode).IsUnicode(false);

                entity.Property(e => e.TxnClassGuid).IsUnicode(false);

                entity.Property(e => e.TxnClassName).IsUnicode(false);

                entity.Property(e => e.TxnTypeCode).IsUnicode(false);

                entity.Property(e => e.TxnTypeGuid).IsUnicode(false);

                entity.Property(e => e.TxnTypeName).IsUnicode(false);
            });

            modelBuilder.Entity<CarAllocBaseV>(entity =>
            {
                entity.ToView("CAR_ALLOC_BASE_V");

                entity.Property(e => e.AllocGuid).IsUnicode(false);

                entity.Property(e => e.AllocPaySiteGuid).IsUnicode(false);

                entity.Property(e => e.AllocPaySiteName).IsUnicode(false);

                entity.Property(e => e.Allocstatusentityguid).IsUnicode(false);

                entity.Property(e => e.BrandCode).IsUnicode(false);

                entity.Property(e => e.BrandGuid).IsUnicode(false);

                entity.Property(e => e.BrandName).IsUnicode(false);

                entity.Property(e => e.CarDefrredDocCheckFlag).IsUnicode(false);

                entity.Property(e => e.CarGuid).IsUnicode(false);

                entity.Property(e => e.CarObjectversionno).HasPrecision(3);

                entity.Property(e => e.CarOracleentityid).IsUnicode(false);

                entity.Property(e => e.CarOracleentityname).IsUnicode(false);

                entity.Property(e => e.CarReadyflag).IsUnicode(false);

                entity.Property(e => e.CarRegnno).IsUnicode(false);

                entity.Property(e => e.Cardevicemakemasterguid).IsUnicode(false);

                entity.Property(e => e.Cardevicemodelguid).IsUnicode(false);

                entity.Property(e => e.Carmasterpkguid).IsUnicode(false);

                entity.Property(e => e.Chassisno).IsUnicode(false);

                entity.Property(e => e.CityCode).IsUnicode(false);

                entity.Property(e => e.CityGuid).IsUnicode(false);

                entity.Property(e => e.CityName).IsUnicode(false);

                entity.Property(e => e.Driverflag).HasPrecision(1);

                entity.Property(e => e.Dseflag).HasPrecision(1);

                entity.Property(e => e.Engineno).IsUnicode(false);

                entity.Property(e => e.EntityCode).IsUnicode(false);

                entity.Property(e => e.GlSegment1).IsUnicode(false);

                entity.Property(e => e.GlSement4).IsUnicode(false);

                entity.Property(e => e.GlSement6).IsUnicode(false);

                entity.Property(e => e.Groupvariantguid).IsUnicode(false);

                entity.Property(e => e.LeCode).IsUnicode(false);

                entity.Property(e => e.LeGuid).IsUnicode(false);

                entity.Property(e => e.LeName).IsUnicode(false);

                entity.Property(e => e.LebranchGuid).IsUnicode(false);

                entity.Property(e => e.ModelCode).IsUnicode(false);

                entity.Property(e => e.ModelGuid).IsUnicode(false);

                entity.Property(e => e.ModelName).IsUnicode(false);

                entity.Property(e => e.OrgId).HasPrecision(4);

                entity.Property(e => e.Ownershiptype).IsUnicode(false);

                entity.Property(e => e.Poolflag).IsUnicode(false);

                entity.Property(e => e.Reasonmasterguid).IsUnicode(false);

                entity.Property(e => e.Rfidflag).HasPrecision(1);

                entity.Property(e => e.SecObjVerNo).HasPrecision(10);

                entity.Property(e => e.Securitycombinationguid).IsUnicode(false);

                entity.Property(e => e.Serviceproviderguid).IsUnicode(false);

                entity.Property(e => e.Serviceproviderpkguid).IsUnicode(false);

                entity.Property(e => e.Sitetypecode).IsUnicode(false);

                entity.Property(e => e.Sitetypename).IsUnicode(false);

                entity.Property(e => e.SpDefrredDocCheckFlag).IsUnicode(false);

                entity.Property(e => e.SpGuid).IsUnicode(false);

                entity.Property(e => e.SpId).IsUnicode(false);

                entity.Property(e => e.SpName).IsUnicode(false);

                entity.Property(e => e.SpPersonguid).IsUnicode(false);

                entity.Property(e => e.Spflag).HasPrecision(1);

                entity.Property(e => e.StatusCode).IsUnicode(false);

                entity.Property(e => e.StatusEntEntguid).IsUnicode(false);

                entity.Property(e => e.StatusEntStsguid).IsUnicode(false);

                entity.Property(e => e.StatusName).IsUnicode(false);

                entity.Property(e => e.Statusentityguid).IsUnicode(false);

                entity.Property(e => e.Tdscode).IsUnicode(false);

                entity.Property(e => e.Workshopmasterguid).IsUnicode(false);
            });

            modelBuilder.Entity<CarAllocV>(entity =>
            {
                entity.ToView("CAR_ALLOC_V");

                entity.Property(e => e.AllocGuid).IsUnicode(false);

                entity.Property(e => e.AllocPaySiteGuid).IsUnicode(false);

                entity.Property(e => e.AllocPaySiteName).IsUnicode(false);

                entity.Property(e => e.Allocstatusentityguid).IsUnicode(false);

                entity.Property(e => e.BrandCode).IsUnicode(false);

                entity.Property(e => e.BrandGuid).IsUnicode(false);

                entity.Property(e => e.BrandName).IsUnicode(false);

                entity.Property(e => e.CarDefrredDocCheckFlag).IsUnicode(false);

                entity.Property(e => e.CarGuid).IsUnicode(false);

                entity.Property(e => e.CarObjectversionno).HasPrecision(3);

                entity.Property(e => e.CarOracleentityid).IsUnicode(false);

                entity.Property(e => e.CarOracleentityname).IsUnicode(false);

                entity.Property(e => e.CarReadyflag).IsUnicode(false);

                entity.Property(e => e.CarRegnno).IsUnicode(false);

                entity.Property(e => e.Cardevicemakemasterguid).IsUnicode(false);

                entity.Property(e => e.Cardevicemodelguid).IsUnicode(false);

                entity.Property(e => e.Carmasterpkguid).IsUnicode(false);

                entity.Property(e => e.Chassisno).IsUnicode(false);

                entity.Property(e => e.CityCode).IsUnicode(false);

                entity.Property(e => e.CityGuid).IsUnicode(false);

                entity.Property(e => e.CityName).IsUnicode(false);

                entity.Property(e => e.Driverflag).HasPrecision(1);

                entity.Property(e => e.Dseflag).HasPrecision(1);

                entity.Property(e => e.Engineno).IsUnicode(false);

                entity.Property(e => e.EntityCode).IsUnicode(false);

                entity.Property(e => e.GlSegment1).IsUnicode(false);

                entity.Property(e => e.GlSement4).IsUnicode(false);

                entity.Property(e => e.GlSement6).IsUnicode(false);

                entity.Property(e => e.Groupvariantguid).IsUnicode(false);

                entity.Property(e => e.LeCode).IsUnicode(false);

                entity.Property(e => e.LeGuid).IsUnicode(false);

                entity.Property(e => e.LeName).IsUnicode(false);

                entity.Property(e => e.LebranchGuid).IsUnicode(false);

                entity.Property(e => e.ModelCode).IsUnicode(false);

                entity.Property(e => e.ModelGuid).IsUnicode(false);

                entity.Property(e => e.ModelName).IsUnicode(false);

                entity.Property(e => e.OrgId).HasPrecision(4);

                entity.Property(e => e.Ownershiptype).IsUnicode(false);

                entity.Property(e => e.Poolflag).IsUnicode(false);

                entity.Property(e => e.Reasonmasterguid).IsUnicode(false);

                entity.Property(e => e.Rfidflag).HasPrecision(1);

                entity.Property(e => e.SecObjVerNo).HasPrecision(10);

                entity.Property(e => e.Securitycombinationguid).IsUnicode(false);

                entity.Property(e => e.Serviceproviderguid).IsUnicode(false);

                entity.Property(e => e.Serviceproviderpkguid).IsUnicode(false);

                entity.Property(e => e.Sitetypecode).IsUnicode(false);

                entity.Property(e => e.Sitetypename).IsUnicode(false);

                entity.Property(e => e.SpDefrredDocCheckFlag).IsUnicode(false);

                entity.Property(e => e.SpGuid).IsUnicode(false);

                entity.Property(e => e.SpId).IsUnicode(false);

                entity.Property(e => e.SpName).IsUnicode(false);

                entity.Property(e => e.SpPersonguid).IsUnicode(false);

                entity.Property(e => e.Spflag).HasPrecision(1);

                entity.Property(e => e.StatusCode).IsUnicode(false);

                entity.Property(e => e.StatusEntEntguid).IsUnicode(false);

                entity.Property(e => e.StatusEntStsguid).IsUnicode(false);

                entity.Property(e => e.StatusName).IsUnicode(false);

                entity.Property(e => e.Statusentityguid).IsUnicode(false);

                entity.Property(e => e.Tdscode).IsUnicode(false);

                entity.Property(e => e.Workshopmasterguid).IsUnicode(false);
            });

            modelBuilder.Entity<CarBaseV>(entity =>
            {
                entity.ToView("CAR_BASE_V");

                entity.Property(e => e.Branchmasterguid).IsUnicode(false);

                entity.Property(e => e.Businesscode).IsUnicode(false);

                entity.Property(e => e.CarBrandCode).IsUnicode(false);

                entity.Property(e => e.CarBrandGuid).IsUnicode(false);

                entity.Property(e => e.CarBrandName).IsUnicode(false);

                entity.Property(e => e.CarBusinesscategoryGuid).IsUnicode(false);

                entity.Property(e => e.CarBusinesscategoryName).IsUnicode(false);

                entity.Property(e => e.CarChassisno).IsUnicode(false);

                entity.Property(e => e.CarCityCode).IsUnicode(false);

                entity.Property(e => e.CarCityGuid).IsUnicode(false);

                entity.Property(e => e.CarCityName).IsUnicode(false);

                entity.Property(e => e.CarColorGuid).IsUnicode(false);

                entity.Property(e => e.CarColorName).IsUnicode(false);

                entity.Property(e => e.CarColorQuickaccesscode).IsUnicode(false);

                entity.Property(e => e.CarDefrredDocCheckFlag).IsUnicode(false);

                entity.Property(e => e.CarGuid).IsUnicode(false);

                entity.Property(e => e.CarGvguid).IsUnicode(false);

                entity.Property(e => e.CarGvname).IsUnicode(false);

                entity.Property(e => e.CarLeBranchGuid).IsUnicode(false);

                entity.Property(e => e.CarLeCode).IsUnicode(false);

                entity.Property(e => e.CarLeName).IsUnicode(false);

                entity.Property(e => e.CarMake).IsUnicode(false);

                entity.Property(e => e.CarMakeCode).IsUnicode(false);

                entity.Property(e => e.CarModel).IsUnicode(false);

                entity.Property(e => e.CarModelGuid).IsUnicode(false);

                entity.Property(e => e.CarModelcode).IsUnicode(false);

                entity.Property(e => e.CarObjVerNo).HasPrecision(3);

                entity.Property(e => e.CarOpModelCode).IsUnicode(false);

                entity.Property(e => e.CarOpModelName).IsUnicode(false);

                entity.Property(e => e.CarOwner).IsUnicode(false);

                entity.Property(e => e.CarOwnerSpStatus).IsUnicode(false);

                entity.Property(e => e.CarOwnerSpid).IsUnicode(false);

                entity.Property(e => e.CarOwnerSpname).IsUnicode(false);

                entity.Property(e => e.CarPkguid).IsUnicode(false);

                entity.Property(e => e.CarRegnNo).IsUnicode(false);

                entity.Property(e => e.CarSecGuid).IsUnicode(false);

                entity.Property(e => e.CarStatusCode).IsUnicode(false);

                entity.Property(e => e.CarStatusName).IsUnicode(false);

                entity.Property(e => e.CarYear).IsUnicode(false);

                entity.Property(e => e.Clientmapguid).IsUnicode(false);

                entity.Property(e => e.Engineno).IsUnicode(false);

                entity.Property(e => e.Issendtomonroe).HasPrecision(5);

                entity.Property(e => e.Locationworkshopmasterguid).IsUnicode(false);

                entity.Property(e => e.Lockstatus).IsUnicode(false);

                entity.Property(e => e.OrgId).HasPrecision(4);

                entity.Property(e => e.Poolflag).IsUnicode(false);

                entity.Property(e => e.Readyflag).IsUnicode(false);

                entity.Property(e => e.Rfidflag).HasPrecision(1);

                entity.Property(e => e.SpDefrredDocCheckFlag).IsUnicode(false);

                entity.Property(e => e.SpPersonguid).IsUnicode(false);

                entity.Property(e => e.SpPkguid).IsUnicode(false);

                entity.Property(e => e.Spguid).IsUnicode(false);

                entity.Property(e => e.Workshopcomments).IsUnicode(false);

                entity.Property(e => e.Workshopdescription).IsUnicode(false);

                entity.Property(e => e.Workshopdisabled).HasPrecision(1);

                entity.Property(e => e.Workshoplocationtype).IsUnicode(false);

                entity.Property(e => e.Workshopmasterguid).IsUnicode(false);

                entity.Property(e => e.Workshopname).IsUnicode(false);

                entity.Property(e => e.Workshoppkguid).IsUnicode(false);

                entity.Property(e => e.Workshopquickaccesscode).IsUnicode(false);
            });

            modelBuilder.Entity<CarDeviceBaseV>(entity =>
            {
                entity.ToView("CAR_DEVICE_BASE_V");

                entity.Property(e => e.CarChassisno).IsUnicode(false);

                entity.Property(e => e.CarDefrredDocCheckFlag).IsUnicode(false);

                entity.Property(e => e.CarDevGuid).IsUnicode(false);

                entity.Property(e => e.CarDevObjVerNo).HasPrecision(10);

                entity.Property(e => e.CarGuid).IsUnicode(false);

                entity.Property(e => e.CarLeBranchGuid).IsUnicode(false);

                entity.Property(e => e.CarObjVerNo).HasPrecision(3);

                entity.Property(e => e.CarOwnerSpStatus).IsUnicode(false);

                entity.Property(e => e.CarOwnerSpid).IsUnicode(false);

                entity.Property(e => e.CarOwnerSpname).IsUnicode(false);

                entity.Property(e => e.CarPkguid).IsUnicode(false);

                entity.Property(e => e.CarRegnNo).IsUnicode(false);

                entity.Property(e => e.CarSecGuid).IsUnicode(false);

                entity.Property(e => e.CarStatusCode).IsUnicode(false);

                entity.Property(e => e.CarStatusName).IsUnicode(false);

                entity.Property(e => e.CardevStatusCode).IsUnicode(false);

                entity.Property(e => e.DevGuid).IsUnicode(false);

                entity.Property(e => e.DevId).IsUnicode(false);

                entity.Property(e => e.DevMobNo).IsUnicode(false);

                entity.Property(e => e.DevPkguid).IsUnicode(false);

                entity.Property(e => e.DevSerialNo).IsUnicode(false);

                entity.Property(e => e.DevStatusCode).IsUnicode(false);

                entity.Property(e => e.DevTypeCode).IsUnicode(false);

                entity.Property(e => e.SpDefrredDocCheckFlag).IsUnicode(false);

                entity.Property(e => e.SpPkguid).IsUnicode(false);

                entity.Property(e => e.Spguid).IsUnicode(false);
            });

            modelBuilder.Entity<CarDeviceV>(entity =>
            {
                entity.ToView("CAR_DEVICE_V");

                entity.Property(e => e.CarChassisno).IsUnicode(false);

                entity.Property(e => e.CarDefrredDocCheckFlag).IsUnicode(false);

                entity.Property(e => e.CarDevGuid).IsUnicode(false);

                entity.Property(e => e.CarDevObjVerNo).HasPrecision(10);

                entity.Property(e => e.CarGuid).IsUnicode(false);

                entity.Property(e => e.CarLeBranchGuid).IsUnicode(false);

                entity.Property(e => e.CarObjVerNo).HasPrecision(3);

                entity.Property(e => e.CarOwnerSpStatus).IsUnicode(false);

                entity.Property(e => e.CarOwnerSpid).IsUnicode(false);

                entity.Property(e => e.CarOwnerSpname).IsUnicode(false);

                entity.Property(e => e.CarPkguid).IsUnicode(false);

                entity.Property(e => e.CarRegnNo).IsUnicode(false);

                entity.Property(e => e.CarSecGuid).IsUnicode(false);

                entity.Property(e => e.CarStatusCode).IsUnicode(false);

                entity.Property(e => e.CarStatusName).IsUnicode(false);

                entity.Property(e => e.CardevStatusCode).IsUnicode(false);

                entity.Property(e => e.DevGuid).IsUnicode(false);

                entity.Property(e => e.DevId).IsUnicode(false);

                entity.Property(e => e.DevMobNo).IsUnicode(false);

                entity.Property(e => e.DevPkguid).IsUnicode(false);

                entity.Property(e => e.DevSerialNo).IsUnicode(false);

                entity.Property(e => e.DevStatusCode).IsUnicode(false);

                entity.Property(e => e.DevTypeCode).IsUnicode(false);

                entity.Property(e => e.SpDefrredDocCheckFlag).IsUnicode(false);

                entity.Property(e => e.SpPkguid).IsUnicode(false);

                entity.Property(e => e.Spguid).IsUnicode(false);
            });

            modelBuilder.Entity<CarDevicelistBaseV>(entity =>
            {
                entity.ToView("CAR_DEVICELIST_BASE_V");

                entity.Property(e => e.CarDevStatusCode).IsUnicode(false);

                entity.Property(e => e.CarDevStatusentityguid).IsUnicode(false);

                entity.Property(e => e.Cardeviceguid).IsUnicode(false);

                entity.Property(e => e.Cardevicemakemasterguid).IsUnicode(false);

                entity.Property(e => e.Cardevicemodelguid).IsUnicode(false);

                entity.Property(e => e.Carguid).IsUnicode(false);

                entity.Property(e => e.Chassisno).IsUnicode(false);

                entity.Property(e => e.DevStatusCode).IsUnicode(false);

                entity.Property(e => e.DevStatusName).IsUnicode(false);

                entity.Property(e => e.DevTypeCode).IsUnicode(false);

                entity.Property(e => e.DevTypeName).IsUnicode(false);

                entity.Property(e => e.Devicecurrentlocation).IsUnicode(false);

                entity.Property(e => e.Deviceid).IsUnicode(false);

                entity.Property(e => e.Devicelebranchsecurityguid).IsUnicode(false);

                entity.Property(e => e.Devicemasterguid).IsUnicode(false);

                entity.Property(e => e.Devicemobileno).IsUnicode(false);

                entity.Property(e => e.Deviceobjectversionno).HasPrecision(10);

                entity.Property(e => e.Deviceoracleentityid).IsUnicode(false);

                entity.Property(e => e.Deviceoracleentityname).IsUnicode(false);

                entity.Property(e => e.Deviceownershiptype).IsUnicode(false);

                entity.Property(e => e.Devicepkguid).IsUnicode(false);

                entity.Property(e => e.Deviceserialno).IsUnicode(false);

                entity.Property(e => e.Devicetypecomments).IsUnicode(false);

                entity.Property(e => e.Devicetypedescription).IsUnicode(false);

                entity.Property(e => e.Devicetypedisabled).HasPrecision(1);

                entity.Property(e => e.Devicetypemasterguid).IsUnicode(false);

                entity.Property(e => e.Devicetypename).IsUnicode(false);

                entity.Property(e => e.Devicetypeobjectversionno).HasPrecision(10);

                entity.Property(e => e.Devicetypeoracleentityid).IsUnicode(false);

                entity.Property(e => e.Devicetypeoracleentityname).IsUnicode(false);

                entity.Property(e => e.Devicetypepkguid).IsUnicode(false);

                entity.Property(e => e.Devicetypequickaccesscode).IsUnicode(false);

                entity.Property(e => e.Devicetyperegularexpression).IsUnicode(false);

                entity.Property(e => e.Engineno).IsUnicode(false);

                entity.Property(e => e.Groupvariantguid).IsUnicode(false);

                entity.Property(e => e.Makemastercomments).IsUnicode(false);

                entity.Property(e => e.Makemasterdescription).IsUnicode(false);

                entity.Property(e => e.Makemasterdisabled).HasPrecision(1);

                entity.Property(e => e.Makemasterguid).IsUnicode(false);

                entity.Property(e => e.Makemastername).IsUnicode(false);

                entity.Property(e => e.Makemasterobjectversionno).HasPrecision(10);

                entity.Property(e => e.Makemasteroracleentityid).IsUnicode(false);

                entity.Property(e => e.Makemasteroracleentityname).IsUnicode(false);

                entity.Property(e => e.Makemasterpkguid).IsUnicode(false);

                entity.Property(e => e.Makemasterquickaccesscode).IsUnicode(false);

                entity.Property(e => e.Modelcomments).IsUnicode(false);

                entity.Property(e => e.Modeldescription).IsUnicode(false);

                entity.Property(e => e.Modeldisabled).HasPrecision(1);

                entity.Property(e => e.Modelguid).IsUnicode(false);

                entity.Property(e => e.Modelname).IsUnicode(false);

                entity.Property(e => e.Modelobjectversionno).HasPrecision(10);

                entity.Property(e => e.Modeloracleentityid).IsUnicode(false);

                entity.Property(e => e.Modeloracleentityname).IsUnicode(false);

                entity.Property(e => e.Modelpkguid).IsUnicode(false);

                entity.Property(e => e.Modelquickaccesscode).IsUnicode(false);

                entity.Property(e => e.Objectversionno).HasPrecision(3);

                entity.Property(e => e.Oracleentityid).IsUnicode(false);

                entity.Property(e => e.Oracleentityname).IsUnicode(false);

                entity.Property(e => e.Ownershiptype).IsUnicode(false);

                entity.Property(e => e.Pkguid).IsUnicode(false);

                entity.Property(e => e.Poolflag).IsUnicode(false);

                entity.Property(e => e.Readyflag).IsUnicode(false);

                entity.Property(e => e.Reasonmasterguid).IsUnicode(false);

                entity.Property(e => e.Registrationno).IsUnicode(false);

                entity.Property(e => e.Rfidflag).HasPrecision(1);

                entity.Property(e => e.Securitycombinationguid).IsUnicode(false);

                entity.Property(e => e.Serviceproviderguid).IsUnicode(false);

                entity.Property(e => e.Statusentityguid).IsUnicode(false);

                entity.Property(e => e.Workshopmasterguid).IsUnicode(false);
            });

            modelBuilder.Entity<CarDevicelistV>(entity =>
            {
                entity.ToView("CAR_DEVICELIST_V");

                entity.Property(e => e.CarDevStatusCode).IsUnicode(false);

                entity.Property(e => e.CarDevStatusentityguid).IsUnicode(false);

                entity.Property(e => e.Cardeviceguid).IsUnicode(false);

                entity.Property(e => e.Cardevicemakemasterguid).IsUnicode(false);

                entity.Property(e => e.Cardevicemodelguid).IsUnicode(false);

                entity.Property(e => e.Carguid).IsUnicode(false);

                entity.Property(e => e.Chassisno).IsUnicode(false);

                entity.Property(e => e.DevStatusCode).IsUnicode(false);

                entity.Property(e => e.DevStatusName).IsUnicode(false);

                entity.Property(e => e.DevTypeCode).IsUnicode(false);

                entity.Property(e => e.DevTypeName).IsUnicode(false);

                entity.Property(e => e.Devicecurrentlocation).IsUnicode(false);

                entity.Property(e => e.Deviceid).IsUnicode(false);

                entity.Property(e => e.Devicelebranchsecurityguid).IsUnicode(false);

                entity.Property(e => e.Devicemasterguid).IsUnicode(false);

                entity.Property(e => e.Devicemobileno).IsUnicode(false);

                entity.Property(e => e.Deviceobjectversionno).HasPrecision(10);

                entity.Property(e => e.Deviceoracleentityid).IsUnicode(false);

                entity.Property(e => e.Deviceoracleentityname).IsUnicode(false);

                entity.Property(e => e.Deviceownershiptype).IsUnicode(false);

                entity.Property(e => e.Devicepkguid).IsUnicode(false);

                entity.Property(e => e.Deviceserialno).IsUnicode(false);

                entity.Property(e => e.Devicetypecomments).IsUnicode(false);

                entity.Property(e => e.Devicetypedescription).IsUnicode(false);

                entity.Property(e => e.Devicetypedisabled).HasPrecision(1);

                entity.Property(e => e.Devicetypemasterguid).IsUnicode(false);

                entity.Property(e => e.Devicetypename).IsUnicode(false);

                entity.Property(e => e.Devicetypeobjectversionno).HasPrecision(10);

                entity.Property(e => e.Devicetypeoracleentityid).IsUnicode(false);

                entity.Property(e => e.Devicetypeoracleentityname).IsUnicode(false);

                entity.Property(e => e.Devicetypepkguid).IsUnicode(false);

                entity.Property(e => e.Devicetypequickaccesscode).IsUnicode(false);

                entity.Property(e => e.Devicetyperegularexpression).IsUnicode(false);

                entity.Property(e => e.Engineno).IsUnicode(false);

                entity.Property(e => e.Groupvariantguid).IsUnicode(false);

                entity.Property(e => e.Makemastercomments).IsUnicode(false);

                entity.Property(e => e.Makemasterdescription).IsUnicode(false);

                entity.Property(e => e.Makemasterdisabled).HasPrecision(1);

                entity.Property(e => e.Makemasterguid).IsUnicode(false);

                entity.Property(e => e.Makemastername).IsUnicode(false);

                entity.Property(e => e.Makemasterobjectversionno).HasPrecision(10);

                entity.Property(e => e.Makemasteroracleentityid).IsUnicode(false);

                entity.Property(e => e.Makemasteroracleentityname).IsUnicode(false);

                entity.Property(e => e.Makemasterpkguid).IsUnicode(false);

                entity.Property(e => e.Makemasterquickaccesscode).IsUnicode(false);

                entity.Property(e => e.Modelcomments).IsUnicode(false);

                entity.Property(e => e.Modeldescription).IsUnicode(false);

                entity.Property(e => e.Modeldisabled).HasPrecision(1);

                entity.Property(e => e.Modelguid).IsUnicode(false);

                entity.Property(e => e.Modelname).IsUnicode(false);

                entity.Property(e => e.Modelobjectversionno).HasPrecision(10);

                entity.Property(e => e.Modeloracleentityid).IsUnicode(false);

                entity.Property(e => e.Modeloracleentityname).IsUnicode(false);

                entity.Property(e => e.Modelpkguid).IsUnicode(false);

                entity.Property(e => e.Modelquickaccesscode).IsUnicode(false);

                entity.Property(e => e.Objectversionno).HasPrecision(3);

                entity.Property(e => e.Oracleentityid).IsUnicode(false);

                entity.Property(e => e.Oracleentityname).IsUnicode(false);

                entity.Property(e => e.Ownershiptype).IsUnicode(false);

                entity.Property(e => e.Pkguid).IsUnicode(false);

                entity.Property(e => e.Poolflag).IsUnicode(false);

                entity.Property(e => e.Readyflag).IsUnicode(false);

                entity.Property(e => e.Reasonmasterguid).IsUnicode(false);

                entity.Property(e => e.Registrationno).IsUnicode(false);

                entity.Property(e => e.Rfidflag).HasPrecision(1);

                entity.Property(e => e.Securitycombinationguid).IsUnicode(false);

                entity.Property(e => e.Serviceproviderguid).IsUnicode(false);

                entity.Property(e => e.Statusentityguid).IsUnicode(false);

                entity.Property(e => e.Workshopmasterguid).IsUnicode(false);
            });

            modelBuilder.Entity<CarDriverBaseV>(entity =>
            {
                entity.ToView("CAR_DRIVER_BASE_V");

                entity.Property(e => e.CarDriverObjVerNo).HasPrecision(10);

                entity.Property(e => e.CarGuid).IsUnicode(false);

                entity.Property(e => e.CarRegnNo).IsUnicode(false);

                entity.Property(e => e.CarStatusCode).IsUnicode(false);

                entity.Property(e => e.CardriverGuid).IsUnicode(false);

                entity.Property(e => e.CardriverStatusentityguid).IsUnicode(false);

                entity.Property(e => e.DriverGuid).IsUnicode(false);

                entity.Property(e => e.DriverId).IsUnicode(false);

                entity.Property(e => e.DriverName).IsUnicode(false);

                entity.Property(e => e.DriverPersGuid).IsUnicode(false);

                entity.Property(e => e.DriverStatus).IsUnicode(false);

                entity.Property(e => e.EntityCode).IsUnicode(false);

                entity.Property(e => e.StatusCode).IsUnicode(false);

                entity.Property(e => e.StatusDesc).IsUnicode(false);

                entity.Property(e => e.StatusEntEntguid).IsUnicode(false);

                entity.Property(e => e.StatusEntObjVerNo).HasPrecision(10);

                entity.Property(e => e.StatusEntStsguid).IsUnicode(false);

                entity.Property(e => e.StatusName).IsUnicode(false);
            });

            modelBuilder.Entity<CarDriverV>(entity =>
            {
                entity.ToView("CAR_DRIVER_V");

                entity.Property(e => e.CarDriverObjVerNo).HasPrecision(10);

                entity.Property(e => e.CarGuid).IsUnicode(false);

                entity.Property(e => e.CarRegnNo).IsUnicode(false);

                entity.Property(e => e.CarStatusCode).IsUnicode(false);

                entity.Property(e => e.CardriverGuid).IsUnicode(false);

                entity.Property(e => e.CardriverStatusentityguid).IsUnicode(false);

                entity.Property(e => e.DriverGuid).IsUnicode(false);

                entity.Property(e => e.DriverId).IsUnicode(false);

                entity.Property(e => e.DriverName).IsUnicode(false);

                entity.Property(e => e.DriverPersGuid).IsUnicode(false);

                entity.Property(e => e.DriverStatus).IsUnicode(false);

                entity.Property(e => e.EntityCode).IsUnicode(false);

                entity.Property(e => e.StatusCode).IsUnicode(false);

                entity.Property(e => e.StatusDesc).IsUnicode(false);

                entity.Property(e => e.StatusEntEntguid).IsUnicode(false);

                entity.Property(e => e.StatusEntObjVerNo).HasPrecision(10);

                entity.Property(e => e.StatusEntStsguid).IsUnicode(false);

                entity.Property(e => e.StatusName).IsUnicode(false);
            });

            modelBuilder.Entity<CarEnrolfeeV>(entity =>
            {
                entity.ToView("CAR_ENROLFEE_V");

                entity.Property(e => e.BrandCode).IsUnicode(false);

                entity.Property(e => e.BrandGuid).IsUnicode(false);

                entity.Property(e => e.BrandName).IsUnicode(false);

                entity.Property(e => e.CarGuid).IsUnicode(false);

                entity.Property(e => e.CarGvguid).IsUnicode(false);

                entity.Property(e => e.CarGvname).IsUnicode(false);

                entity.Property(e => e.CarMake).IsUnicode(false);

                entity.Property(e => e.CarModel).IsUnicode(false);

                entity.Property(e => e.CarRegnNo).IsUnicode(false);

                entity.Property(e => e.CarStatusCode).IsUnicode(false);

                entity.Property(e => e.CarStatusName).IsUnicode(false);

                entity.Property(e => e.CityCode).IsUnicode(false);

                entity.Property(e => e.CityGuid).IsUnicode(false);

                entity.Property(e => e.CityName).IsUnicode(false);

                entity.Property(e => e.CycleDaysCode).IsUnicode(false);

                entity.Property(e => e.CycleDaysGuid)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.CycleDaysName).IsUnicode(false);

                entity.Property(e => e.GlSegment1).IsUnicode(false);

                entity.Property(e => e.GlSement4).IsUnicode(false);

                entity.Property(e => e.GlSement6).IsUnicode(false);

                entity.Property(e => e.GvcCode).IsUnicode(false);

                entity.Property(e => e.GvcFreqCode).IsUnicode(false);

                entity.Property(e => e.GvcFreqGuid).IsUnicode(false);

                entity.Property(e => e.GvcFreqName).IsUnicode(false);

                entity.Property(e => e.GvcGuid).IsUnicode(false);

                entity.Property(e => e.GvcObjVerNo).HasPrecision(3);

                entity.Property(e => e.GvcValue).IsUnicode(false);

                entity.Property(e => e.GvcValuetype).IsUnicode(false);

                entity.Property(e => e.LeCode).IsUnicode(false);

                entity.Property(e => e.LeGuid).IsUnicode(false);

                entity.Property(e => e.LeName).IsUnicode(false);

                entity.Property(e => e.LebranchGuid).IsUnicode(false);

                entity.Property(e => e.ModelCode).IsUnicode(false);

                entity.Property(e => e.ModelGuid).IsUnicode(false);

                entity.Property(e => e.ModelName).IsUnicode(false);

                entity.Property(e => e.OrgId).HasPrecision(4);

                entity.Property(e => e.SecGuid).IsUnicode(false);

                entity.Property(e => e.SecObjVerNo).HasPrecision(10);

                entity.Property(e => e.TxnClassCode).IsUnicode(false);

                entity.Property(e => e.TxnClassGuid).IsUnicode(false);

                entity.Property(e => e.TxnClassName).IsUnicode(false);

                entity.Property(e => e.TxnTypeCode).IsUnicode(false);

                entity.Property(e => e.TxnTypeGuid).IsUnicode(false);

                entity.Property(e => e.TxnTypeName).IsUnicode(false);
            });

            modelBuilder.Entity<CarExpV>(entity =>
            {
                entity.ToView("CAR_EXP_V");

                entity.Property(e => e.BrandName).IsUnicode(false);

                entity.Property(e => e.Carmasterguid).IsUnicode(false);

                entity.Property(e => e.CityName).IsUnicode(false);

                entity.Property(e => e.Cmguid).IsUnicode(false);

                entity.Property(e => e.Firstname).IsUnicode(false);

                entity.Property(e => e.FitnesscertificateDocNo).IsUnicode(false);

                entity.Property(e => e.InsuranceDocNo).IsUnicode(false);

                entity.Property(e => e.Lastname).IsUnicode(false);

                entity.Property(e => e.LeName).IsUnicode(false);

                entity.Property(e => e.Middlename).IsUnicode(false);

                entity.Property(e => e.ModelName).IsUnicode(false);

                entity.Property(e => e.PermitDocNo).IsUnicode(false);

                entity.Property(e => e.Personid).IsUnicode(false);

                entity.Property(e => e.RcDocNo).IsUnicode(false);

                entity.Property(e => e.Re1guid).IsUnicode(false);

                entity.Property(e => e.Re2guid).IsUnicode(false);

                entity.Property(e => e.Re3guid).IsUnicode(false);

                entity.Property(e => e.Registrationno).IsUnicode(false);

                entity.Property(e => e.RoadtaxDocNo).IsUnicode(false);

                entity.Property(e => e.SecGuid).IsUnicode(false);

                entity.Property(e => e.StatusName).IsUnicode(false);
            });

            modelBuilder.Entity<CarExpiryReportV>(entity =>
            {
                entity.ToView("CAR_EXPIRY_REPORT_V");

                entity.Property(e => e.BrandCode).IsUnicode(false);

                entity.Property(e => e.BrandName).IsUnicode(false);

                entity.Property(e => e.CityCode).IsUnicode(false);

                entity.Property(e => e.CityName).IsUnicode(false);

                entity.Property(e => e.Fit1Documentno).IsUnicode(false);

                entity.Property(e => e.Fit1Quickaccesscode).IsUnicode(false);

                entity.Property(e => e.Ins1Documentno).IsUnicode(false);

                entity.Property(e => e.Ins1Quickaccesscode).IsUnicode(false);

                entity.Property(e => e.LeCode).IsUnicode(false);

                entity.Property(e => e.LeName).IsUnicode(false);

                entity.Property(e => e.ModelCode).IsUnicode(false);

                entity.Property(e => e.ModelName).IsUnicode(false);

                entity.Property(e => e.Per1Documentno).IsUnicode(false);

                entity.Property(e => e.Per1Quickaccesscode).IsUnicode(false);

                entity.Property(e => e.PmRegistrationno).IsUnicode(false);

                entity.Property(e => e.Rc1Documentno).IsUnicode(false);

                entity.Property(e => e.Rc1Quickaccesscode).IsUnicode(false);

                entity.Property(e => e.SecGuid).IsUnicode(false);

                entity.Property(e => e.SecQuickaccesscode).IsUnicode(false);

                entity.Property(e => e.SpmFullname).IsUnicode(false);

                entity.Property(e => e.SpmPersonid).IsUnicode(false);

                entity.Property(e => e.SvStatusCode).IsUnicode(false);

                entity.Property(e => e.Tx1Documentno).IsUnicode(false);

                entity.Property(e => e.Tx1Quickaccesscode).IsUnicode(false);
            });

            modelBuilder.Entity<CarGvComponentsBaseV>(entity =>
            {
                entity.ToView("CAR_GV_COMPONENTS_BASE_V");

                entity.Property(e => e.BrandCode).IsUnicode(false);

                entity.Property(e => e.BrandGuid).IsUnicode(false);

                entity.Property(e => e.BrandName).IsUnicode(false);

                entity.Property(e => e.CarGuid).IsUnicode(false);

                entity.Property(e => e.CarGvguid).IsUnicode(false);

                entity.Property(e => e.CarGvname).IsUnicode(false);

                entity.Property(e => e.CarMake).IsUnicode(false);

                entity.Property(e => e.CarModel).IsUnicode(false);

                entity.Property(e => e.CarRegnNo).IsUnicode(false);

                entity.Property(e => e.CarStatusCode).IsUnicode(false);

                entity.Property(e => e.CarStatusName).IsUnicode(false);

                entity.Property(e => e.CityCode).IsUnicode(false);

                entity.Property(e => e.CityGuid).IsUnicode(false);

                entity.Property(e => e.CityName).IsUnicode(false);

                entity.Property(e => e.CycleDaysCode).IsUnicode(false);

                entity.Property(e => e.CycleDaysGuid)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.CycleDaysName).IsUnicode(false);

                entity.Property(e => e.GlSegment1).IsUnicode(false);

                entity.Property(e => e.GlSement4).IsUnicode(false);

                entity.Property(e => e.GlSement6).IsUnicode(false);

                entity.Property(e => e.GvcCode).IsUnicode(false);

                entity.Property(e => e.GvcFreqCode).IsUnicode(false);

                entity.Property(e => e.GvcFreqGuid).IsUnicode(false);

                entity.Property(e => e.GvcFreqName).IsUnicode(false);

                entity.Property(e => e.GvcGuid).IsUnicode(false);

                entity.Property(e => e.GvcObjVerNo).HasPrecision(3);

                entity.Property(e => e.GvcValue).IsUnicode(false);

                entity.Property(e => e.GvcValuetype).IsUnicode(false);

                entity.Property(e => e.LeCode).IsUnicode(false);

                entity.Property(e => e.LeGuid).IsUnicode(false);

                entity.Property(e => e.LeName).IsUnicode(false);

                entity.Property(e => e.LebranchGuid).IsUnicode(false);

                entity.Property(e => e.ModelCode).IsUnicode(false);

                entity.Property(e => e.ModelGuid).IsUnicode(false);

                entity.Property(e => e.ModelName).IsUnicode(false);

                entity.Property(e => e.OrgId).HasPrecision(4);

                entity.Property(e => e.SecGuid).IsUnicode(false);

                entity.Property(e => e.SecObjVerNo).HasPrecision(10);

                entity.Property(e => e.TxnClassCode).IsUnicode(false);

                entity.Property(e => e.TxnClassGuid).IsUnicode(false);

                entity.Property(e => e.TxnClassName).IsUnicode(false);

                entity.Property(e => e.TxnTypeCode).IsUnicode(false);

                entity.Property(e => e.TxnTypeGuid).IsUnicode(false);

                entity.Property(e => e.TxnTypeName).IsUnicode(false);
            });

            modelBuilder.Entity<CarGvComponentsV>(entity =>
            {
                entity.ToView("CAR_GV_COMPONENTS_V");

                entity.Property(e => e.BrandCode).IsUnicode(false);

                entity.Property(e => e.BrandGuid).IsUnicode(false);

                entity.Property(e => e.BrandName).IsUnicode(false);

                entity.Property(e => e.CarGuid).IsUnicode(false);

                entity.Property(e => e.CarGvguid).IsUnicode(false);

                entity.Property(e => e.CarGvname).IsUnicode(false);

                entity.Property(e => e.CarMake).IsUnicode(false);

                entity.Property(e => e.CarModel).IsUnicode(false);

                entity.Property(e => e.CarRegnNo).IsUnicode(false);

                entity.Property(e => e.CarStatusCode).IsUnicode(false);

                entity.Property(e => e.CarStatusName).IsUnicode(false);

                entity.Property(e => e.CityCode).IsUnicode(false);

                entity.Property(e => e.CityGuid).IsUnicode(false);

                entity.Property(e => e.CityName).IsUnicode(false);

                entity.Property(e => e.CycleDaysCode).IsUnicode(false);

                entity.Property(e => e.CycleDaysGuid)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.CycleDaysName).IsUnicode(false);

                entity.Property(e => e.GlSegment1).IsUnicode(false);

                entity.Property(e => e.GlSement4).IsUnicode(false);

                entity.Property(e => e.GlSement6).IsUnicode(false);

                entity.Property(e => e.GvcCode).IsUnicode(false);

                entity.Property(e => e.GvcFreqCode).IsUnicode(false);

                entity.Property(e => e.GvcFreqGuid).IsUnicode(false);

                entity.Property(e => e.GvcFreqName).IsUnicode(false);

                entity.Property(e => e.GvcGuid).IsUnicode(false);

                entity.Property(e => e.GvcObjVerNo).HasPrecision(3);

                entity.Property(e => e.GvcValue).IsUnicode(false);

                entity.Property(e => e.GvcValuetype).IsUnicode(false);

                entity.Property(e => e.LeCode).IsUnicode(false);

                entity.Property(e => e.LeGuid).IsUnicode(false);

                entity.Property(e => e.LeName).IsUnicode(false);

                entity.Property(e => e.LebranchGuid).IsUnicode(false);

                entity.Property(e => e.ModelCode).IsUnicode(false);

                entity.Property(e => e.ModelGuid).IsUnicode(false);

                entity.Property(e => e.ModelName).IsUnicode(false);

                entity.Property(e => e.OrgId).HasPrecision(4);

                entity.Property(e => e.SecGuid).IsUnicode(false);

                entity.Property(e => e.SecObjVerNo).HasPrecision(10);

                entity.Property(e => e.TxnClassCode).IsUnicode(false);

                entity.Property(e => e.TxnClassGuid).IsUnicode(false);

                entity.Property(e => e.TxnClassName).IsUnicode(false);

                entity.Property(e => e.TxnTypeCode).IsUnicode(false);

                entity.Property(e => e.TxnTypeGuid).IsUnicode(false);

                entity.Property(e => e.TxnTypeName).IsUnicode(false);
            });

            modelBuilder.Entity<CarMandetoryDeviceSimMobV>(entity =>
            {
                entity.ToView("CAR_MANDETORY_DEVICE_SIM_MOB_V");

                entity.Property(e => e.CarGuid).IsUnicode(false);

                entity.Property(e => e.LeGuid).IsUnicode(false);

                entity.Property(e => e.SecGuid).IsUnicode(false);
            });

            modelBuilder.Entity<CarMandetoryDeviceV>(entity =>
            {
                entity.ToView("CAR_MANDETORY_DEVICE_V");

                entity.Property(e => e.CarGuid).IsUnicode(false);

                entity.Property(e => e.LeGuid).IsUnicode(false);

                entity.Property(e => e.SecGuid).IsUnicode(false);
            });

            modelBuilder.Entity<CarManthan>(entity =>
            {
                entity.Property(e => e.Cabregistrationno).IsUnicode(false);

                entity.Property(e => e.Fitnesscertificateno).IsUnicode(false);

                entity.Property(e => e.Fitnessdocpath).IsUnicode(false);

                entity.Property(e => e.Fitnesserror).IsUnicode(false);

                entity.Property(e => e.Fitnessflag).IsUnicode(false);

                entity.Property(e => e.Fitnessstatus).IsUnicode(false);

                entity.Property(e => e.Insurancecompany).IsUnicode(false);

                entity.Property(e => e.Insurancedocpath).IsUnicode(false);

                entity.Property(e => e.Insuranceerror).IsUnicode(false);

                entity.Property(e => e.Insuranceflag).IsUnicode(false);

                entity.Property(e => e.Insurancepolicynumber).IsUnicode(false);

                entity.Property(e => e.Insurancestatus).IsUnicode(false);

                entity.Property(e => e.Insurancetype).IsUnicode(false);

                entity.Property(e => e.Nationalpermitdocumenterror).IsUnicode(false);

                entity.Property(e => e.Nationalpermitdocumentflag).IsUnicode(false);

                entity.Property(e => e.Nationalpermitdocumentpath).IsUnicode(false);

                entity.Property(e => e.Nationalpermitdocumentstatus).IsUnicode(false);

                entity.Property(e => e.Nationalpermitno).IsUnicode(false);

                entity.Property(e => e.Rcdocumenterror).IsUnicode(false);

                entity.Property(e => e.Rcdocumentflag).IsUnicode(false);

                entity.Property(e => e.Rcdocumentpath).IsUnicode(false);

                entity.Property(e => e.Rcdocumentstatus).IsUnicode(false);

                entity.Property(e => e.Roadtaxdocpath).IsUnicode(false);

                entity.Property(e => e.Roadtaxerror).IsUnicode(false);

                entity.Property(e => e.Roadtaxflag).IsUnicode(false);

                entity.Property(e => e.Roadtaxstatus).IsUnicode(false);

                entity.Property(e => e.SeqId).HasPrecision(10);

                entity.Property(e => e.Statepermitdocumenterror).IsUnicode(false);

                entity.Property(e => e.Statepermitdocumentflag).IsUnicode(false);

                entity.Property(e => e.Statepermitdocumentpath).IsUnicode(false);

                entity.Property(e => e.Statepermitdocumentstatus).IsUnicode(false);

                entity.Property(e => e.Statepermitno).IsUnicode(false);

                entity.Property(e => e.Status).IsUnicode(false);
            });

            modelBuilder.Entity<CarReportV>(entity =>
            {
                entity.ToView("CAR_REPORT_V");

                entity.Property(e => e.Brand).IsUnicode(false);

                entity.Property(e => e.Carmake).IsUnicode(false);

                entity.Property(e => e.Carmodel).IsUnicode(false);

                entity.Property(e => e.Carnumber).IsUnicode(false);

                entity.Property(e => e.Carowner).IsUnicode(false);

                entity.Property(e => e.Carstatus).IsUnicode(false);

                entity.Property(e => e.Chassisno).IsUnicode(false);

                entity.Property(e => e.City).IsUnicode(false);

                entity.Property(e => e.Engineno).IsUnicode(false);

                entity.Property(e => e.FitDoc).IsUnicode(false);

                entity.Property(e => e.GvName).IsUnicode(false);

                entity.Property(e => e.InsDoc).IsUnicode(false);

                entity.Property(e => e.Lename).IsUnicode(false);

                entity.Property(e => e.Model).IsUnicode(false);

                entity.Property(e => e.PerDoc).IsUnicode(false);

                entity.Property(e => e.RcDoc).IsUnicode(false);

                entity.Property(e => e.SecGuid).IsUnicode(false);

                entity.Property(e => e.Spid).IsUnicode(false);

                entity.Property(e => e.Spname).IsUnicode(false);
            });

            modelBuilder.Entity<CarStatusAllocV>(entity =>
            {
                entity.ToView("CAR_STATUS_ALLOC_V");

                entity.Property(e => e.AllocEntityCode).IsUnicode(false);

                entity.Property(e => e.AllocGuid).IsUnicode(false);

                entity.Property(e => e.AllocPaySiteGuid).IsUnicode(false);

                entity.Property(e => e.AllocPaySiteName).IsUnicode(false);

                entity.Property(e => e.AllocStatusCode).IsUnicode(false);

                entity.Property(e => e.AllocStatusEntEntguid).IsUnicode(false);

                entity.Property(e => e.AllocStatusEntStsguid).IsUnicode(false);

                entity.Property(e => e.AllocStatusName).IsUnicode(false);

                entity.Property(e => e.AllocStatusentityguid).IsUnicode(false);

                entity.Property(e => e.BrandGuid).IsUnicode(false);

                entity.Property(e => e.CarEntityCode).IsUnicode(false);

                entity.Property(e => e.CarGuid).IsUnicode(false);

                entity.Property(e => e.CarRegnno).IsUnicode(false);

                entity.Property(e => e.CarStatusCode).IsUnicode(false);

                entity.Property(e => e.CarStatusEntEntguid).IsUnicode(false);

                entity.Property(e => e.CarStatusEntStsguid).IsUnicode(false);

                entity.Property(e => e.CarStatusName).IsUnicode(false);

                entity.Property(e => e.Carmasterpkguid).IsUnicode(false);

                entity.Property(e => e.Chassisno).IsUnicode(false);

                entity.Property(e => e.Driverflag).HasPrecision(1);

                entity.Property(e => e.Dseflag).HasPrecision(1);

                entity.Property(e => e.Engineno).IsUnicode(false);

                entity.Property(e => e.LeGuid).IsUnicode(false);

                entity.Property(e => e.LebranchGuid).IsUnicode(false);

                entity.Property(e => e.OrgId).HasPrecision(4);

                entity.Property(e => e.Securitycombinationguid).IsUnicode(false);

                entity.Property(e => e.Serviceproviderpkguid).IsUnicode(false);

                entity.Property(e => e.SpGuid).IsUnicode(false);

                entity.Property(e => e.SpId).IsUnicode(false);

                entity.Property(e => e.SpName).IsUnicode(false);

                entity.Property(e => e.Spflag).HasPrecision(1);

                entity.Property(e => e.Statusentityguid).IsUnicode(false);
            });

            modelBuilder.Entity<CarStatusSummaryMv>(entity =>
            {
                entity.Property(e => e.Brand).IsUnicode(false);

                entity.Property(e => e.City).IsUnicode(false);

                entity.Property(e => e.Model).IsUnicode(false);

                entity.Property(e => e.StatusCode).IsUnicode(false);

                entity.Property(e => e.StatusName).IsUnicode(false);
            });

            modelBuilder.Entity<CarStatusSummaryV>(entity =>
            {
                entity.ToView("CAR_STATUS_SUMMARY_V");

                entity.Property(e => e.Brand).IsUnicode(false);

                entity.Property(e => e.City).IsUnicode(false);

                entity.Property(e => e.Model).IsUnicode(false);

                entity.Property(e => e.StatusCode).IsUnicode(false);

                entity.Property(e => e.StatusName).IsUnicode(false);
            });

            modelBuilder.Entity<CarV>(entity =>
            {
                entity.ToView("CAR_V");

                entity.Property(e => e.Branchmasterguid).IsUnicode(false);

                entity.Property(e => e.Businesscode).IsUnicode(false);

                entity.Property(e => e.CarBrandCode).IsUnicode(false);

                entity.Property(e => e.CarBrandGuid).IsUnicode(false);

                entity.Property(e => e.CarBrandName).IsUnicode(false);

                entity.Property(e => e.CarBusinesscategoryGuid).IsUnicode(false);

                entity.Property(e => e.CarBusinesscategoryName).IsUnicode(false);

                entity.Property(e => e.CarChassisno).IsUnicode(false);

                entity.Property(e => e.CarCityCode).IsUnicode(false);

                entity.Property(e => e.CarCityGuid).IsUnicode(false);

                entity.Property(e => e.CarCityName).IsUnicode(false);

                entity.Property(e => e.CarColorGuid).IsUnicode(false);

                entity.Property(e => e.CarColorName).IsUnicode(false);

                entity.Property(e => e.CarColorQuickaccesscode).IsUnicode(false);

                entity.Property(e => e.CarDefrredDocCheckFlag).IsUnicode(false);

                entity.Property(e => e.CarGuid).IsUnicode(false);

                entity.Property(e => e.CarGvguid).IsUnicode(false);

                entity.Property(e => e.CarGvname).IsUnicode(false);

                entity.Property(e => e.CarLeBranchGuid).IsUnicode(false);

                entity.Property(e => e.CarLeCode).IsUnicode(false);

                entity.Property(e => e.CarLeName).IsUnicode(false);

                entity.Property(e => e.CarMake).IsUnicode(false);

                entity.Property(e => e.CarMakeCode).IsUnicode(false);

                entity.Property(e => e.CarModel).IsUnicode(false);

                entity.Property(e => e.CarModelGuid).IsUnicode(false);

                entity.Property(e => e.CarModelcode).IsUnicode(false);

                entity.Property(e => e.CarObjVerNo).HasPrecision(3);

                entity.Property(e => e.CarOpModelCode).IsUnicode(false);

                entity.Property(e => e.CarOpModelName).IsUnicode(false);

                entity.Property(e => e.CarOwner).IsUnicode(false);

                entity.Property(e => e.CarOwnerSpStatus).IsUnicode(false);

                entity.Property(e => e.CarOwnerSpid).IsUnicode(false);

                entity.Property(e => e.CarOwnerSpname).IsUnicode(false);

                entity.Property(e => e.CarPkguid).IsUnicode(false);

                entity.Property(e => e.CarRegnNo).IsUnicode(false);

                entity.Property(e => e.CarSecGuid).IsUnicode(false);

                entity.Property(e => e.CarStatusCode).IsUnicode(false);

                entity.Property(e => e.CarStatusName).IsUnicode(false);

                entity.Property(e => e.CarYear).IsUnicode(false);

                entity.Property(e => e.Clientmapguid).IsUnicode(false);

                entity.Property(e => e.Engineno).IsUnicode(false);

                entity.Property(e => e.Issendtomonroe).HasPrecision(5);

                entity.Property(e => e.Locationworkshopmasterguid).IsUnicode(false);

                entity.Property(e => e.Lockstatus).IsUnicode(false);

                entity.Property(e => e.OrgId).HasPrecision(4);

                entity.Property(e => e.Poolflag).IsUnicode(false);

                entity.Property(e => e.Readyflag).IsUnicode(false);

                entity.Property(e => e.Rfidflag).HasPrecision(1);

                entity.Property(e => e.SpDefrredDocCheckFlag).IsUnicode(false);

                entity.Property(e => e.SpPersonguid).IsUnicode(false);

                entity.Property(e => e.SpPkguid).IsUnicode(false);

                entity.Property(e => e.Spguid).IsUnicode(false);

                entity.Property(e => e.Workshopcomments).IsUnicode(false);

                entity.Property(e => e.Workshopdescription).IsUnicode(false);

                entity.Property(e => e.Workshopdisabled).HasPrecision(1);

                entity.Property(e => e.Workshoplocationtype).IsUnicode(false);

                entity.Property(e => e.Workshopmasterguid).IsUnicode(false);

                entity.Property(e => e.Workshopname).IsUnicode(false);

                entity.Property(e => e.Workshoppkguid).IsUnicode(false);

                entity.Property(e => e.Workshopquickaccesscode).IsUnicode(false);
            });

            modelBuilder.Entity<Carallocation>(entity =>
            {
                entity.Property(e => e.Carmasterguid).IsUnicode(false);

                entity.Property(e => e.Carmasterpkguid).IsUnicode(false);

                entity.Property(e => e.Guid).IsUnicode(false);

                entity.Property(e => e.Objectversionno).HasPrecision(3);

                entity.Property(e => e.Oracleentityid).IsUnicode(false);

                entity.Property(e => e.Oracleentityname).IsUnicode(false);

                entity.Property(e => e.Pkguid).IsUnicode(false);

                entity.Property(e => e.Serviceproviderguid).IsUnicode(false);

                entity.Property(e => e.Serviceproviderpkguid).IsUnicode(false);

                entity.Property(e => e.Spsitemasterguid).IsUnicode(false);

                entity.Property(e => e.Statusentityguid).IsUnicode(false);

                entity.Property(e => e.Userarchived).IsUnicode(false);

                entity.Property(e => e.Usercreated).IsUnicode(false);

                entity.Property(e => e.Userdeleted).IsUnicode(false);

                entity.Property(e => e.Userupdated).IsUnicode(false);
            });

            modelBuilder.Entity<Cardevice>(entity =>
            {
                entity.Property(e => e.Carmasterguid).IsUnicode(false);

                entity.Property(e => e.Devicemasterguid).IsUnicode(false);

                entity.Property(e => e.Guid).IsUnicode(false);

                entity.Property(e => e.Objectversionno).HasPrecision(10);

                entity.Property(e => e.Oracleentityid).IsUnicode(false);

                entity.Property(e => e.Oracleentityname).IsUnicode(false);

                entity.Property(e => e.Pkguid).IsUnicode(false);

                entity.Property(e => e.Statusentityguid).IsUnicode(false);

                entity.Property(e => e.Userarchived).IsUnicode(false);

                entity.Property(e => e.Usercreated).IsUnicode(false);

                entity.Property(e => e.Userdeleted).IsUnicode(false);

                entity.Property(e => e.Userupdated).IsUnicode(false);
            });

            modelBuilder.Entity<Cardevicemakemaster>(entity =>
            {
                entity.HasKey(e => e.Guid)
                    .HasName("SYS_C0010867");

                entity.Property(e => e.Guid).IsUnicode(false);

                entity.Property(e => e.Comments).IsUnicode(false);

                entity.Property(e => e.Description).IsUnicode(false);

                entity.Property(e => e.Devicetypemasterguid).IsUnicode(false);

                entity.Property(e => e.Disabled).HasPrecision(1);

                entity.Property(e => e.Name).IsUnicode(false);

                entity.Property(e => e.Objectversionno).HasPrecision(10);

                entity.Property(e => e.Oracleentityid).IsUnicode(false);

                entity.Property(e => e.Oracleentityname).IsUnicode(false);

                entity.Property(e => e.Pkguid).IsUnicode(false);

                entity.Property(e => e.Quickaccesscode).IsUnicode(false);

                entity.Property(e => e.Showinverificationscreen)
                    .HasPrecision(1)
                    .HasDefaultValueSql("(1)");

                entity.Property(e => e.Userarchived).IsUnicode(false);

                entity.Property(e => e.Usercreated).IsUnicode(false);

                entity.Property(e => e.Userdeleted).IsUnicode(false);

                entity.Property(e => e.Userupdated).IsUnicode(false);
            });

            modelBuilder.Entity<Cardevicemodel>(entity =>
            {
                entity.Property(e => e.Brandmasterguid).IsUnicode(false);

                entity.Property(e => e.Cardevicemakemasterguid).IsUnicode(false);

                entity.Property(e => e.Comments).IsUnicode(false);

                entity.Property(e => e.Description).IsUnicode(false);

                entity.Property(e => e.Disabled).HasPrecision(1);

                entity.Property(e => e.Guid).IsUnicode(false);

                entity.Property(e => e.Name).IsUnicode(false);

                entity.Property(e => e.Objectversionno).HasPrecision(10);

                entity.Property(e => e.Oracleentityid).IsUnicode(false);

                entity.Property(e => e.Oracleentityname).IsUnicode(false);

                entity.Property(e => e.Pkguid).IsUnicode(false);

                entity.Property(e => e.Quickaccesscode).IsUnicode(false);

                entity.Property(e => e.Userarchived).IsUnicode(false);

                entity.Property(e => e.Usercreated).IsUnicode(false);

                entity.Property(e => e.Userdeleted).IsUnicode(false);

                entity.Property(e => e.Userupdated).IsUnicode(false);
            });

            modelBuilder.Entity<Cardoc>(entity =>
            {
                entity.Property(e => e.Carmasterguid).IsUnicode(false);

                entity.Property(e => e.Disabled).HasPrecision(1);

                entity.Property(e => e.Documentname).IsUnicode(false);

                entity.Property(e => e.Documentno).IsUnicode(false);

                entity.Property(e => e.Documentpath).IsUnicode(false);

                entity.Property(e => e.Documenttypecategoryguid).IsUnicode(false);

                entity.Property(e => e.Documenttypeentityguid).IsUnicode(false);

                entity.Property(e => e.Guid).IsUnicode(false);

                entity.Property(e => e.Objectversionno).HasPrecision(10);

                entity.Property(e => e.Oracleentityid).IsUnicode(false);

                entity.Property(e => e.Oracleentityname).IsUnicode(false);

                entity.Property(e => e.Pkguid).IsUnicode(false);

                entity.Property(e => e.Statusentityguid).IsUnicode(false);

                entity.Property(e => e.Userarchived).IsUnicode(false);

                entity.Property(e => e.Usercreated).IsUnicode(false);

                entity.Property(e => e.Userdeleted).IsUnicode(false);

                entity.Property(e => e.Userupdated).IsUnicode(false);
            });

            modelBuilder.Entity<CardocFitnessV>(entity =>
            {
                entity.ToView("CARDOC_FITNESS_V");

                entity.Property(e => e.CarGuid).IsUnicode(false);

                entity.Property(e => e.DocFileName).IsUnicode(false);

                entity.Property(e => e.DocGuid).IsUnicode(false);

                entity.Property(e => e.DocNo).IsUnicode(false);
            });

            modelBuilder.Entity<CardocPermitV>(entity =>
            {
                entity.ToView("CARDOC_PERMIT_V");

                entity.Property(e => e.CarGuid).IsUnicode(false);

                entity.Property(e => e.DocFileName).IsUnicode(false);

                entity.Property(e => e.DocGuid).IsUnicode(false);

                entity.Property(e => e.DocNo).IsUnicode(false);
            });

            modelBuilder.Entity<CardocPucV>(entity =>
            {
                entity.ToView("CARDOC_PUC_V");

                entity.Property(e => e.CarGuid).IsUnicode(false);

                entity.Property(e => e.DocFileName).IsUnicode(false);

                entity.Property(e => e.DocGuid).IsUnicode(false);

                entity.Property(e => e.DocNo).IsUnicode(false);
            });

            modelBuilder.Entity<CardocRcV>(entity =>
            {
                entity.ToView("CARDOC_RC_V");

                entity.Property(e => e.CarGuid).IsUnicode(false);

                entity.Property(e => e.DocFileName).IsUnicode(false);

                entity.Property(e => e.DocGuid).IsUnicode(false);

                entity.Property(e => e.DocNo).IsUnicode(false);
            });

            modelBuilder.Entity<CardocRoadtaxV>(entity =>
            {
                entity.ToView("CARDOC_ROADTAX_V");

                entity.Property(e => e.CarGuid).IsUnicode(false);

                entity.Property(e => e.DocFileName).IsUnicode(false);

                entity.Property(e => e.DocGuid).IsUnicode(false);

                entity.Property(e => e.DocNo).IsUnicode(false);
            });

            modelBuilder.Entity<CardocsBaseV>(entity =>
            {
                entity.ToView("CARDOCS_BASE_V");

                entity.Property(e => e.CarGuid).IsUnicode(false);

                entity.Property(e => e.CarLeBranchGuid).IsUnicode(false);

                entity.Property(e => e.CarRegnNo).IsUnicode(false);

                entity.Property(e => e.CarSecGuid).IsUnicode(false);

                entity.Property(e => e.CarStatus).IsUnicode(false);

                entity.Property(e => e.DocDocumentpath).IsUnicode(false);

                entity.Property(e => e.DocFileName).IsUnicode(false);

                entity.Property(e => e.DocGuid).IsUnicode(false);

                entity.Property(e => e.DocNo).IsUnicode(false);

                entity.Property(e => e.DocObjVerNo).HasPrecision(10);

                entity.Property(e => e.DocStatusCode).IsUnicode(false);

                entity.Property(e => e.DocStatusName).IsUnicode(false);

                entity.Property(e => e.DocType).IsUnicode(false);

                entity.Property(e => e.DocTypeCode).IsUnicode(false);

                entity.Property(e => e.Documenttypecategoryguid).IsUnicode(false);

                entity.Property(e => e.Documenttypeentityguid).IsUnicode(false);

                entity.Property(e => e.Escalationdays).HasPrecision(10);

                entity.Property(e => e.Renewaldays).HasPrecision(10);

                entity.Property(e => e.Statusentityguid).IsUnicode(false);
            });

            modelBuilder.Entity<CardocsInsuranceV>(entity =>
            {
                entity.ToView("CARDOCS_INSURANCE_V");

                entity.Property(e => e.CarGuid).IsUnicode(false);

                entity.Property(e => e.DocFileName).IsUnicode(false);

                entity.Property(e => e.DocGuid).IsUnicode(false);

                entity.Property(e => e.DocNo).IsUnicode(false);
            });

            modelBuilder.Entity<CardocsInterface>(entity =>
            {
                entity.Property(e => e.Carmasterguid).IsUnicode(false);

                entity.Property(e => e.Disabled).HasPrecision(1);

                entity.Property(e => e.Documentname).IsUnicode(false);

                entity.Property(e => e.Documentno).IsUnicode(false);

                entity.Property(e => e.Documentpath).IsUnicode(false);

                entity.Property(e => e.Documenttypecategoryguid).IsUnicode(false);

                entity.Property(e => e.Documenttypeentityguid).IsUnicode(false);

                entity.Property(e => e.Guid).IsUnicode(false);

                entity.Property(e => e.Objectversionno).HasPrecision(10);

                entity.Property(e => e.Oracleentityid).IsUnicode(false);

                entity.Property(e => e.Oracleentityname).IsUnicode(false);

                entity.Property(e => e.Pkguid).IsUnicode(false);

                entity.Property(e => e.Statusentityguid).IsUnicode(false);

                entity.Property(e => e.Userarchived).IsUnicode(false);

                entity.Property(e => e.Usercreated).IsUnicode(false);

                entity.Property(e => e.Userdeleted).IsUnicode(false);

                entity.Property(e => e.Userupdated).IsUnicode(false);
            });

            modelBuilder.Entity<CardocsV>(entity =>
            {
                entity.ToView("CARDOCS_V");

                entity.Property(e => e.CarGuid).IsUnicode(false);

                entity.Property(e => e.CarLeBranchGuid).IsUnicode(false);

                entity.Property(e => e.CarRegnNo).IsUnicode(false);

                entity.Property(e => e.CarSecGuid).IsUnicode(false);

                entity.Property(e => e.CarStatus).IsUnicode(false);

                entity.Property(e => e.DocDocumentpath).IsUnicode(false);

                entity.Property(e => e.DocFileName).IsUnicode(false);

                entity.Property(e => e.DocGuid).IsUnicode(false);

                entity.Property(e => e.DocNo).IsUnicode(false);

                entity.Property(e => e.DocObjVerNo).HasPrecision(10);

                entity.Property(e => e.DocStatusCode).IsUnicode(false);

                entity.Property(e => e.DocStatusName).IsUnicode(false);

                entity.Property(e => e.DocType).IsUnicode(false);

                entity.Property(e => e.DocTypeCode).IsUnicode(false);

                entity.Property(e => e.Documenttypecategoryguid).IsUnicode(false);

                entity.Property(e => e.Documenttypeentityguid).IsUnicode(false);

                entity.Property(e => e.Escalationdays).HasPrecision(10);

                entity.Property(e => e.Renewaldays).HasPrecision(10);

                entity.Property(e => e.Statusentityguid).IsUnicode(false);
            });

            modelBuilder.Entity<CardocsdocumentnoV>(entity =>
            {
                entity.ToView("CARDOCSDOCUMENTNO_V");

                entity.Property(e => e.Carmasterguid).IsUnicode(false);

                entity.Property(e => e.Documentno).IsUnicode(false);

                entity.Property(e => e.Documenttypeentityguid).IsUnicode(false);

                entity.Property(e => e.Guid).IsUnicode(false);
            });

            modelBuilder.Entity<Cardocsinf>(entity =>
            {
                entity.Property(e => e.Cabid).IsUnicode(false);

                entity.Property(e => e.Carmasterguid).IsUnicode(false);

                entity.Property(e => e.Disabled).HasPrecision(1);

                entity.Property(e => e.Documentname).IsUnicode(false);

                entity.Property(e => e.Documentno).IsUnicode(false);

                entity.Property(e => e.Documentpath).IsUnicode(false);

                entity.Property(e => e.Documenttypecategoryguid).IsUnicode(false);

                entity.Property(e => e.Documenttypeentityguid).IsUnicode(false);

                entity.Property(e => e.Guid).IsUnicode(false);

                entity.Property(e => e.Objectversionno).HasPrecision(10);

                entity.Property(e => e.Oracleentityid).IsUnicode(false);

                entity.Property(e => e.Oracleentityname).IsUnicode(false);

                entity.Property(e => e.Pkguid).IsUnicode(false);

                entity.Property(e => e.Status).IsUnicode(false);

                entity.Property(e => e.Statusentityguid).IsUnicode(false);

                entity.Property(e => e.Userarchived).IsUnicode(false);

                entity.Property(e => e.Usercreated).IsUnicode(false);

                entity.Property(e => e.Userdeleted).IsUnicode(false);

                entity.Property(e => e.Userupdated).IsUnicode(false);
            });

            modelBuilder.Entity<Cardriver>(entity =>
            {
                entity.Property(e => e.Carmasterguid).IsUnicode(false);

                entity.Property(e => e.Disabled).HasPrecision(1);

                entity.Property(e => e.Drivermasterguid).IsUnicode(false);

                entity.Property(e => e.Guid).IsUnicode(false);

                entity.Property(e => e.Objectversionno).HasPrecision(10);

                entity.Property(e => e.Oracleentityid).IsUnicode(false);

                entity.Property(e => e.Oracleentityname).IsUnicode(false);

                entity.Property(e => e.Pkguid).IsUnicode(false);

                entity.Property(e => e.Statusentityguid).IsUnicode(false);

                entity.Property(e => e.Userarchived).IsUnicode(false);

                entity.Property(e => e.Usercreated).IsUnicode(false);

                entity.Property(e => e.Userdeleted).IsUnicode(false);

                entity.Property(e => e.Userupdated).IsUnicode(false);
            });

            modelBuilder.Entity<CargvV>(entity =>
            {
                entity.ToView("CARGV_V");

                entity.Property(e => e.CarGvguid).IsUnicode(false);

                entity.Property(e => e.Carguid).IsUnicode(false);

                entity.Property(e => e.GvcValue).IsUnicode(false);

                entity.Property(e => e.Quickaccesscode).IsUnicode(false);

                entity.Property(e => e.TClass).IsUnicode(false);

                entity.Property(e => e.TxnTypeGuid).IsUnicode(false);
            });

            modelBuilder.Entity<Carlock>(entity =>
            {
                entity.Property(e => e.Carlocksguid).IsUnicode(false);

                entity.Property(e => e.Carmasterguid).IsUnicode(false);

                entity.Property(e => e.Guid).IsUnicode(false);

                entity.Property(e => e.Lockdetails).IsUnicode(false);

                entity.Property(e => e.Locksourceentity).IsUnicode(false);

                entity.Property(e => e.Locktxnref).IsUnicode(false);

                entity.Property(e => e.Locktypemasterguid).IsUnicode(false);

                entity.Property(e => e.Manthanlockstatus).IsUnicode(false);

                entity.Property(e => e.Manthanunlockstatus).IsUnicode(false);

                entity.Property(e => e.Oracleentityid).IsUnicode(false);

                entity.Property(e => e.Oracleentityname).IsUnicode(false);

                entity.Property(e => e.Pkguid).IsUnicode(false);

                entity.Property(e => e.Statusentityguid).IsUnicode(false);

                entity.Property(e => e.Unlocksourceentity).IsUnicode(false);

                entity.Property(e => e.Unlocktxnref).IsUnicode(false);

                entity.Property(e => e.Userarchived).IsUnicode(false);

                entity.Property(e => e.Usercreated).IsUnicode(false);

                entity.Property(e => e.Userdeleted).IsUnicode(false);

                entity.Property(e => e.Userupdated).IsUnicode(false);
            });

            modelBuilder.Entity<CarlocksBaseV>(entity =>
            {
                entity.ToView("CARLOCKS_BASE_V");

                entity.Property(e => e.CarRegnNo).IsUnicode(false);

                entity.Property(e => e.Carlockguid).IsUnicode(false);

                entity.Property(e => e.CarlocksEntityCode).IsUnicode(false);

                entity.Property(e => e.CarlocksStatusCode).IsUnicode(false);

                entity.Property(e => e.CarlocksStatusDesc).IsUnicode(false);

                entity.Property(e => e.CarlocksStatusEntEntguid).IsUnicode(false);

                entity.Property(e => e.CarlocksStatusEntStsguid).IsUnicode(false);

                entity.Property(e => e.CarlocksStatusName).IsUnicode(false);

                entity.Property(e => e.Carlockspkguid).IsUnicode(false);

                entity.Property(e => e.Carmasterguid).IsUnicode(false);

                entity.Property(e => e.Guid).IsUnicode(false);

                entity.Property(e => e.Lockcomments).IsUnicode(false);

                entity.Property(e => e.Lockdescription).IsUnicode(false);

                entity.Property(e => e.Lockdetails).IsUnicode(false);

                entity.Property(e => e.Lockdisabled).HasPrecision(1);

                entity.Property(e => e.Lockname).IsUnicode(false);

                entity.Property(e => e.Lockobjectversionno).HasPrecision(10);

                entity.Property(e => e.Lockoracleentityid).IsUnicode(false);

                entity.Property(e => e.Lockoracleentityname).IsUnicode(false);

                entity.Property(e => e.Lockquickaccesscode).IsUnicode(false);

                entity.Property(e => e.Locksourceentity).IsUnicode(false);

                entity.Property(e => e.Lockstatuscolor).IsUnicode(false);

                entity.Property(e => e.Locktxnref).IsUnicode(false);

                entity.Property(e => e.Locktypemasterguid).IsUnicode(false);

                entity.Property(e => e.Locktypemasterpkguid).IsUnicode(false);

                entity.Property(e => e.StatusEntObjVerNo).HasPrecision(10);

                entity.Property(e => e.Statusentityguid).IsUnicode(false);

                entity.Property(e => e.Unlocksourceentity).IsUnicode(false);

                entity.Property(e => e.Unlocktxnref).IsUnicode(false);
            });

            modelBuilder.Entity<CarlocksV>(entity =>
            {
                entity.ToView("CARLOCKS_V");

                entity.Property(e => e.CarRegnNo).IsUnicode(false);

                entity.Property(e => e.Carlockguid).IsUnicode(false);

                entity.Property(e => e.CarlocksEntityCode).IsUnicode(false);

                entity.Property(e => e.CarlocksStatusCode).IsUnicode(false);

                entity.Property(e => e.CarlocksStatusDesc).IsUnicode(false);

                entity.Property(e => e.CarlocksStatusEntEntguid).IsUnicode(false);

                entity.Property(e => e.CarlocksStatusEntStsguid).IsUnicode(false);

                entity.Property(e => e.CarlocksStatusName).IsUnicode(false);

                entity.Property(e => e.Carlockspkguid).IsUnicode(false);

                entity.Property(e => e.Carmasterguid).IsUnicode(false);

                entity.Property(e => e.Guid).IsUnicode(false);

                entity.Property(e => e.Lockcomments).IsUnicode(false);

                entity.Property(e => e.Lockdescription).IsUnicode(false);

                entity.Property(e => e.Lockdetails).IsUnicode(false);

                entity.Property(e => e.Lockdisabled).HasPrecision(1);

                entity.Property(e => e.Lockname).IsUnicode(false);

                entity.Property(e => e.Lockobjectversionno).HasPrecision(10);

                entity.Property(e => e.Lockoracleentityid).IsUnicode(false);

                entity.Property(e => e.Lockoracleentityname).IsUnicode(false);

                entity.Property(e => e.Lockquickaccesscode).IsUnicode(false);

                entity.Property(e => e.Locksourceentity).IsUnicode(false);

                entity.Property(e => e.Lockstatuscolor).IsUnicode(false);

                entity.Property(e => e.Locktxnref).IsUnicode(false);

                entity.Property(e => e.Locktypemasterguid).IsUnicode(false);

                entity.Property(e => e.Locktypemasterpkguid).IsUnicode(false);

                entity.Property(e => e.StatusEntObjVerNo).HasPrecision(10);

                entity.Property(e => e.Statusentityguid).IsUnicode(false);

                entity.Property(e => e.Unlocksourceentity).IsUnicode(false);

                entity.Property(e => e.Unlocktxnref).IsUnicode(false);
            });

            modelBuilder.Entity<Carmaster>(entity =>
            {
                entity.Property(e => e.Actualcity).IsUnicode(false);

                entity.Property(e => e.Actualstate).IsUnicode(false);

                entity.Property(e => e.Anchorlocationguid).IsUnicode(false);

                entity.Property(e => e.Businesscategorymasterguid)
                    .IsUnicode(false)
                    .HasDefaultValueSql("'742B3578D1C40DC9E05338011CAC08EE'");

                entity.Property(e => e.Cardevicemakemasterguid).IsUnicode(false);

                entity.Property(e => e.Cardevicemodelguid).IsUnicode(false);

                entity.Property(e => e.Carmakeyear).IsUnicode(false);

                entity.Property(e => e.Chassisno).IsUnicode(false);

                entity.Property(e => e.Clientmapguid).IsUnicode(false);

                entity.Property(e => e.Colorsmasterguid).IsUnicode(false);

                entity.Property(e => e.DefrredDocCheckFlag).IsUnicode(false);

                entity.Property(e => e.Engineno).IsUnicode(false);

                entity.Property(e => e.Garagelocation).IsUnicode(false);

                entity.Property(e => e.Groupvariantguid).IsUnicode(false);

                entity.Property(e => e.Guid).IsUnicode(false);

                entity.Property(e => e.Isac)
                    .HasPrecision(1)
                    .HasDefaultValueSql("(1)\n");

                entity.Property(e => e.Iscabsentforinduction).HasPrecision(5);

                entity.Property(e => e.Iscmp).HasDefaultValueSql("0");

                entity.Property(e => e.Islbo).HasDefaultValueSql("1");

                entity.Property(e => e.Issendtomonroe)
                    .HasPrecision(5)
                    .HasDefaultValueSql("0 ");

                entity.Property(e => e.Locationworkshopmasterguid).IsUnicode(false);

                entity.Property(e => e.Mobikqrcode).IsUnicode(false);

                entity.Property(e => e.Noofseats).HasDefaultValueSql("(0)");

                entity.Property(e => e.Objectversionno).HasPrecision(3);

                entity.Property(e => e.Oracleentityid).IsUnicode(false);

                entity.Property(e => e.Oracleentityname).IsUnicode(false);

                entity.Property(e => e.Ownershiptype).IsUnicode(false);

                entity.Property(e => e.Paytmqrcode).IsUnicode(false);

                entity.Property(e => e.Permittype)
                    .IsUnicode(false)
                    .HasDefaultValueSql("'State Permit'");

                entity.Property(e => e.Pkguid).IsUnicode(false);

                entity.Property(e => e.Poolflag).IsUnicode(false);

                entity.Property(e => e.Readyflag).IsUnicode(false);

                entity.Property(e => e.Reasonmasterguid).IsUnicode(false);

                entity.Property(e => e.Registrationno).IsUnicode(false);

                entity.Property(e => e.Rfidflag).HasPrecision(1);

                entity.Property(e => e.Securitycombinationguid).IsUnicode(false);

                entity.Property(e => e.Serviceproviderguid).IsUnicode(false);

                entity.Property(e => e.Shiftmasterguid).IsUnicode(false);

                entity.Property(e => e.Statusentityguid).IsUnicode(false);

                entity.Property(e => e.Userarchived).IsUnicode(false);

                entity.Property(e => e.Usercreated).IsUnicode(false);

                entity.Property(e => e.Userdeleted).IsUnicode(false);

                entity.Property(e => e.Userupdated).IsUnicode(false);

                entity.Property(e => e.Workshopmasterguid).IsUnicode(false);
            });

            modelBuilder.Entity<CarmasterFb>(entity =>
            {
                entity.ToView("CARMASTER_FB");

                entity.Property(e => e.Cardevicemakemasterguid).IsUnicode(false);

                entity.Property(e => e.Cardevicemodelguid).IsUnicode(false);

                entity.Property(e => e.Carmakeyear).IsUnicode(false);

                entity.Property(e => e.Chassisno).IsUnicode(false);

                entity.Property(e => e.Colorsmasterguid).IsUnicode(false);

                entity.Property(e => e.DefrredDocCheckFlag).IsUnicode(false);

                entity.Property(e => e.Engineno).IsUnicode(false);

                entity.Property(e => e.Groupvariantguid).IsUnicode(false);

                entity.Property(e => e.Guid).IsUnicode(false);

                entity.Property(e => e.Locationworkshopmasterguid).IsUnicode(false);

                entity.Property(e => e.Objectversionno).HasPrecision(3);

                entity.Property(e => e.Oracleentityid).IsUnicode(false);

                entity.Property(e => e.Oracleentityname).IsUnicode(false);

                entity.Property(e => e.Ownershiptype).IsUnicode(false);

                entity.Property(e => e.Pkguid).IsUnicode(false);

                entity.Property(e => e.Poolflag).IsUnicode(false);

                entity.Property(e => e.Readyflag).IsUnicode(false);

                entity.Property(e => e.Reasonmasterguid).IsUnicode(false);

                entity.Property(e => e.Registrationno).IsUnicode(false);

                entity.Property(e => e.Rfidflag).HasPrecision(1);

                entity.Property(e => e.Securitycombinationguid).IsUnicode(false);

                entity.Property(e => e.Serviceproviderguid).IsUnicode(false);

                entity.Property(e => e.Statusentityguid).IsUnicode(false);

                entity.Property(e => e.Userarchived).IsUnicode(false);

                entity.Property(e => e.Usercreated).IsUnicode(false);

                entity.Property(e => e.Userdeleted).IsUnicode(false);

                entity.Property(e => e.Userupdated).IsUnicode(false);

                entity.Property(e => e.Workshopmasterguid).IsUnicode(false);
            });

            modelBuilder.Entity<CcMaster>(entity =>
            {
                entity.Property(e => e.CarNo).IsUnicode(false);

                entity.Property(e => e.CcDate).HasDefaultValueSql("trunc(SYSDATE)");
            });

            modelBuilder.Entity<CcMasterInt>(entity =>
            {
                entity.Property(e => e.CarNo).IsUnicode(false);
            });

            modelBuilder.Entity<CcMasterSummary>(entity =>
            {
                entity.ToView("CC_MASTER_SUMMARY");

                entity.Property(e => e.CarNo).IsUnicode(false);
            });

            modelBuilder.Entity<CcMasterSummaryV>(entity =>
            {
                entity.ToView("CC_MASTER_SUMMARY_V");

                entity.Property(e => e.CarNo).IsUnicode(false);
            });

            modelBuilder.Entity<CcMasterV>(entity =>
            {
                entity.ToView("CC_MASTER_V");

                entity.Property(e => e.CarNo).IsUnicode(false);
            });

            modelBuilder.Entity<CcSiteSummaryV>(entity =>
            {
                entity.ToView("CC_SITE_SUMMARY_V");

                entity.Property(e => e.CarNo).IsUnicode(false);

                entity.Property(e => e.Carmasterguid).IsUnicode(false);

                entity.Property(e => e.Securitycombinationguid).IsUnicode(false);

                entity.Property(e => e.Sitemasterguid).IsUnicode(false);
            });

            modelBuilder.Entity<CdStatusV>(entity =>
            {
                entity.ToView("CD_STATUS_V");

                entity.Property(e => e.Cardriverguid).IsUnicode(false);

                entity.Property(e => e.Carmasterguid).IsUnicode(false);

                entity.Property(e => e.CdObjectversionno).HasPrecision(10);

                entity.Property(e => e.Drivermasterguid).IsUnicode(false);

                entity.Property(e => e.Registrationno).IsUnicode(false);

                entity.Property(e => e.StatusCode).IsUnicode(false);
            });

            modelBuilder.Entity<Clientmap>(entity =>
            {
                entity.Property(e => e.Branchguid).IsUnicode(false);

                entity.Property(e => e.Clientid).IsUnicode(false);

                entity.Property(e => e.Clientname).IsUnicode(false);

                entity.Property(e => e.Guid).IsUnicode(false);
            });

            modelBuilder.Entity<Clientmapeventdata03aug23>(entity =>
            {
                entity.Property(e => e.BusinessCategory).IsUnicode(false);

                entity.Property(e => e.DriverProcessedResult).IsUnicode(false);

                entity.Property(e => e.EventCode).IsUnicode(false);

                entity.Property(e => e.ParamString).IsUnicode(false);

                entity.Property(e => e.ProcessedStatus).IsUnicode(false);

                entity.Property(e => e.VehicleProcessedResult).IsUnicode(false);

                entity.Property(e => e.VendorProcessedResult).IsUnicode(false);
            });

            modelBuilder.Entity<Clientmapeventdatum>(entity =>
            {
                entity.Property(e => e.BusinessCategory).IsUnicode(false);

                entity.Property(e => e.DriverProcessedResult).IsUnicode(false);

                entity.Property(e => e.EventCode).IsUnicode(false);

                entity.Property(e => e.ParamString).IsUnicode(false);

                entity.Property(e => e.ProcessedStatus).IsUnicode(false);

                entity.Property(e => e.VehicleProcessedResult).IsUnicode(false);

                entity.Property(e => e.VendorProcessedResult).IsUnicode(false);
            });

            modelBuilder.Entity<Clientmapmaster>(entity =>
            {
                entity.Property(e => e.Branchguid).IsUnicode(false);

                entity.Property(e => e.Clientid).IsUnicode(false);

                entity.Property(e => e.Clientmapguid).IsUnicode(false);

                entity.Property(e => e.Clientname).IsUnicode(false);

                entity.Property(e => e.Guid).IsUnicode(false);
            });

            modelBuilder.Entity<Colormaster>(entity =>
            {
                entity.Property(e => e.Comments).IsUnicode(false);

                entity.Property(e => e.Description).IsUnicode(false);

                entity.Property(e => e.Disabled).HasPrecision(1);

                entity.Property(e => e.Guid).IsUnicode(false);

                entity.Property(e => e.Name).IsUnicode(false);

                entity.Property(e => e.Objectversionno).HasPrecision(10);

                entity.Property(e => e.Oracleentityid).IsUnicode(false);

                entity.Property(e => e.Oracleentityname).IsUnicode(false);

                entity.Property(e => e.Pkguid).IsUnicode(false);

                entity.Property(e => e.Quickaccesscode).IsUnicode(false);

                entity.Property(e => e.Userarchived).IsUnicode(false);

                entity.Property(e => e.Usercreated).IsUnicode(false);

                entity.Property(e => e.Userdeleted).IsUnicode(false);

                entity.Property(e => e.Userupdated).IsUnicode(false);
            });

            modelBuilder.Entity<ComplaintactionV>(entity =>
            {
                entity.ToView("COMPLAINTACTION_V");

                entity.Property(e => e.ActionGuid).IsUnicode(false);

                entity.Property(e => e.ActionName).IsUnicode(false);

                entity.Property(e => e.BranchGuid).IsUnicode(false);

                entity.Property(e => e.Branchname).IsUnicode(false);

                entity.Property(e => e.Disabled).HasPrecision(1);
            });

            modelBuilder.Entity<Complaintactionmaster>(entity =>
            {
                entity.HasKey(e => e.Guid)
                    .HasName("SYS_C0010866");

                entity.Property(e => e.Guid).IsUnicode(false);

                entity.Property(e => e.Comments).IsUnicode(false);

                entity.Property(e => e.Description).IsUnicode(false);

                entity.Property(e => e.Disabled)
                    .HasPrecision(1)
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Name).IsUnicode(false);

                entity.Property(e => e.Objectversionno).IsUnicode(false);

                entity.Property(e => e.Oracleentityid).IsUnicode(false);

                entity.Property(e => e.Oracleentityname).IsUnicode(false);

                entity.Property(e => e.Pkguid).IsUnicode(false);

                entity.Property(e => e.Quickaccesscode).IsUnicode(false);

                entity.Property(e => e.Transactiontypeguid).IsUnicode(false);

                entity.Property(e => e.Userarchived).IsUnicode(false);

                entity.Property(e => e.Usercreated).IsUnicode(false);

                entity.Property(e => e.Userdeleted).IsUnicode(false);

                entity.Property(e => e.Userupdated).IsUnicode(false);
            });

            modelBuilder.Entity<Complaintapievent>(entity =>
            {
                entity.Property(e => e.Comments).IsUnicode(false);

                entity.Property(e => e.ComplaintId).IsUnicode(false);

                entity.Property(e => e.ComplaintStatus).IsUnicode(false);

                entity.Property(e => e.Processedstatus).IsUnicode(false);
            });

            modelBuilder.Entity<Complaintapieventhistory>(entity =>
            {
                entity.Property(e => e.Comments).IsUnicode(false);

                entity.Property(e => e.ComplaintId).IsUnicode(false);

                entity.Property(e => e.ComplaintStatus).IsUnicode(false);

                entity.Property(e => e.Processedstatus).IsUnicode(false);
            });

            modelBuilder.Entity<Complaintcategorymapping>(entity =>
            {
                entity.HasKey(e => e.Guid)
                    .HasName("SYS_C0010864");

                entity.Property(e => e.Guid).IsUnicode(false);

                entity.Property(e => e.Comments).IsUnicode(false);

                entity.Property(e => e.Complaintcategorymasterguid).IsUnicode(false);

                entity.Property(e => e.Complaintincomingcategoryguid).IsUnicode(false);

                entity.Property(e => e.Datearchived).HasPrecision(6);

                entity.Property(e => e.Datecreated).HasPrecision(6);

                entity.Property(e => e.Datedeleted).HasPrecision(6);

                entity.Property(e => e.Dateupdated).HasPrecision(6);

                entity.Property(e => e.Disabled)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(0) ")
                    .IsFixedLength(true);

                entity.Property(e => e.Objectversionno).IsUnicode(false);

                entity.Property(e => e.Oracleentityid).IsUnicode(false);

                entity.Property(e => e.Oracleentityname).IsUnicode(false);

                entity.Property(e => e.Pkguid).IsUnicode(false);

                entity.Property(e => e.Userarchived).IsUnicode(false);

                entity.Property(e => e.Usercreated).IsUnicode(false);

                entity.Property(e => e.Userdeleted).IsUnicode(false);

                entity.Property(e => e.Userupdated).IsUnicode(false);
            });

            modelBuilder.Entity<Complaintcategorymaster>(entity =>
            {
                entity.HasKey(e => e.Guid)
                    .HasName("SYS_C0010865");

                entity.Property(e => e.Guid).IsUnicode(false);

                entity.Property(e => e.Categorylevel).IsUnicode(false);

                entity.Property(e => e.Comments).IsUnicode(false);

                entity.Property(e => e.Debitthetripamount).HasPrecision(1);

                entity.Property(e => e.Description).IsUnicode(false);

                entity.Property(e => e.Disabled)
                    .HasPrecision(1)
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Name).IsUnicode(false);

                entity.Property(e => e.Objectversionno).IsUnicode(false);

                entity.Property(e => e.Oracleentityid).IsUnicode(false);

                entity.Property(e => e.Oracleentityname).IsUnicode(false);

                entity.Property(e => e.Pkguid).IsUnicode(false);

                entity.Property(e => e.Quickaccesscode).IsUnicode(false);

                entity.Property(e => e.Userarchived).IsUnicode(false);

                entity.Property(e => e.Usercreated).IsUnicode(false);

                entity.Property(e => e.Userdeleted).IsUnicode(false);

                entity.Property(e => e.Userupdated).IsUnicode(false);
            });

            modelBuilder.Entity<Complaintcramaster>(entity =>
            {
                entity.Property(e => e.Branchmasterguid).IsUnicode(false);

                entity.Property(e => e.Comments).IsUnicode(false);

                entity.Property(e => e.Complaintactionmasterguid).IsUnicode(false);

                entity.Property(e => e.Complaintcategorymasterguid).IsUnicode(false);

                entity.Property(e => e.Disabled)
                    .HasPrecision(1)
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Guid).IsUnicode(false);

                entity.Property(e => e.Objectversionno).IsUnicode(false);

                entity.Property(e => e.Oracleentityid).IsUnicode(false);

                entity.Property(e => e.Oracleentityname).IsUnicode(false);

                entity.Property(e => e.Pkguid).IsUnicode(false);

                entity.Property(e => e.Ratingmasterguid).IsUnicode(false);

                entity.Property(e => e.Userarchived).IsUnicode(false);

                entity.Property(e => e.Usercreated).IsUnicode(false);

                entity.Property(e => e.Userdeleted).IsUnicode(false);

                entity.Property(e => e.Userupdated).IsUnicode(false);
            });

            modelBuilder.Entity<Complaintdetail>(entity =>
            {
                entity.HasKey(e => e.Guid)
                    .HasName("SYS_C0010863");

                entity.Property(e => e.Guid).IsUnicode(false);

                entity.Property(e => e.Carregnno).IsUnicode(false);

                entity.Property(e => e.Comments).IsUnicode(false);

                entity.Property(e => e.Complaintbody).IsUnicode(false);

                entity.Property(e => e.Complaintid).IsUnicode(false);

                entity.Property(e => e.Complaintincommingcategory).IsUnicode(false);

                entity.Property(e => e.Complaintsource).IsUnicode(false);

                entity.Property(e => e.Complaintsubject).IsUnicode(false);

                entity.Property(e => e.Complainttype).IsUnicode(false);

                entity.Property(e => e.Customeremailid).IsUnicode(false);

                entity.Property(e => e.Customermobile).IsUnicode(false);

                entity.Property(e => e.Disabled)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(0) ")
                    .IsFixedLength(true);

                entity.Property(e => e.Driverid).IsUnicode(false);

                entity.Property(e => e.Jobid).IsUnicode(false);

                entity.Property(e => e.Objectversionno).IsUnicode(false);

                entity.Property(e => e.Oracleentityid).IsUnicode(false);

                entity.Property(e => e.Oracleentityname).IsUnicode(false);

                entity.Property(e => e.Pkguid).IsUnicode(false);

                entity.Property(e => e.Status).IsUnicode(false);

                entity.Property(e => e.Userarchived).IsUnicode(false);

                entity.Property(e => e.Usercreated).IsUnicode(false);

                entity.Property(e => e.Userdeleted).IsUnicode(false);

                entity.Property(e => e.Userupdated).IsUnicode(false);
            });

            modelBuilder.Entity<ComplaintdetailsV>(entity =>
            {
                entity.ToView("COMPLAINTDETAILS_V");

                entity.Property(e => e.Actionstatusguid).IsUnicode(false);

                entity.Property(e => e.Actualactionguid).IsUnicode(false);

                entity.Property(e => e.Additionaldebitcomments).IsUnicode(false);

                entity.Property(e => e.Assignedtopersonid).HasPrecision(10);

                entity.Property(e => e.BrandCode).IsUnicode(false);

                entity.Property(e => e.BrandGuid).IsUnicode(false);

                entity.Property(e => e.BrandName).IsUnicode(false);

                entity.Property(e => e.CarSecGuid).IsUnicode(false);

                entity.Property(e => e.Carmasterguid).IsUnicode(false);

                entity.Property(e => e.Carregistrationno).IsUnicode(false);

                entity.Property(e => e.CityCode).IsUnicode(false);

                entity.Property(e => e.CityGuid).IsUnicode(false);

                entity.Property(e => e.CityName).IsUnicode(false);

                entity.Property(e => e.Comments).IsUnicode(false);

                entity.Property(e => e.ComplaintPkguid).IsUnicode(false);

                entity.Property(e => e.Complaintbody).IsUnicode(false);

                entity.Property(e => e.Complaintcategorymasterguid).IsUnicode(false);

                entity.Property(e => e.Complaintdescription).IsUnicode(false);

                entity.Property(e => e.Complaintid).IsUnicode(false);

                entity.Property(e => e.Complaintincommingcategory).IsUnicode(false);

                entity.Property(e => e.Complaintincommingcategoryguid).IsUnicode(false);

                entity.Property(e => e.Complaintlevel).IsUnicode(false);

                entity.Property(e => e.Complaintname).IsUnicode(false);

                entity.Property(e => e.Complaintpragatiguid).IsUnicode(false);

                entity.Property(e => e.Complaintquickaccesscode).IsUnicode(false);

                entity.Property(e => e.Complaintsource).IsUnicode(false);

                entity.Property(e => e.Complaintsourceguid).IsUnicode(false);

                entity.Property(e => e.Complaintsubject).IsUnicode(false);

                entity.Property(e => e.Complainttype).IsUnicode(false);

                entity.Property(e => e.Customeremailid).IsUnicode(false);

                entity.Property(e => e.Customermobile).IsUnicode(false);

                entity.Property(e => e.DriverName).IsUnicode(false);

                entity.Property(e => e.Driverid).IsUnicode(false);

                entity.Property(e => e.Drivermasterguid).IsUnicode(false);

                entity.Property(e => e.Jobid).IsUnicode(false);

                entity.Property(e => e.LeCode).IsUnicode(false);

                entity.Property(e => e.LeGuid).IsUnicode(false);

                entity.Property(e => e.LeName).IsUnicode(false);

                entity.Property(e => e.ModelCode).IsUnicode(false);

                entity.Property(e => e.ModelGuid).IsUnicode(false);

                entity.Property(e => e.ModelName).IsUnicode(false);

                entity.Property(e => e.Pythonserverdata).IsUnicode(false);

                entity.Property(e => e.Serviceproviderguid).IsUnicode(false);

                entity.Property(e => e.SpFullname).IsUnicode(false);

                entity.Property(e => e.SpStatus)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Spid).IsUnicode(false);

                entity.Property(e => e.Status).IsUnicode(false);

                entity.Property(e => e.Suggestedactionguid).IsUnicode(false);

                entity.Property(e => e.UserId)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Userguid).IsUnicode(false);
            });

            modelBuilder.Entity<Complaintincomingcategory>(entity =>
            {
                entity.HasKey(e => e.Guid)
                    .HasName("SYS_C0010861");

                entity.Property(e => e.Guid).IsUnicode(false);

                entity.Property(e => e.Comments).IsUnicode(false);

                entity.Property(e => e.Description).IsUnicode(false);

                entity.Property(e => e.Disabled)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(0) ")
                    .IsFixedLength(true);

                entity.Property(e => e.Name).IsUnicode(false);

                entity.Property(e => e.Objectversionno).IsUnicode(false);

                entity.Property(e => e.Oracleentityid).IsUnicode(false);

                entity.Property(e => e.Oracleentityname).IsUnicode(false);

                entity.Property(e => e.Pkguid).IsUnicode(false);

                entity.Property(e => e.Quickaccesscode).IsUnicode(false);

                entity.Property(e => e.Userarchived).IsUnicode(false);

                entity.Property(e => e.Usercreated).IsUnicode(false);

                entity.Property(e => e.Userdeleted).IsUnicode(false);

                entity.Property(e => e.Userupdated).IsUnicode(false);
            });

            modelBuilder.Entity<Complaintpragati>(entity =>
            {
                entity.HasKey(e => e.Guid)
                    .HasName("SYS_C0010862");

                entity.Property(e => e.Guid).IsUnicode(false);

                entity.Property(e => e.Actionstatusguid).IsUnicode(false);

                entity.Property(e => e.Actualactionguid).IsUnicode(false);

                entity.Property(e => e.Additionaldebitcomments).IsUnicode(false);

                entity.Property(e => e.Assignedtopersonid).HasPrecision(10);

                entity.Property(e => e.Carmasterguid).IsUnicode(false);

                entity.Property(e => e.Comments).IsUnicode(false);

                entity.Property(e => e.Complaintcategorymasterguid).IsUnicode(false);

                entity.Property(e => e.Complaintid).IsUnicode(false);

                entity.Property(e => e.Complaintincommingcategoryguid).IsUnicode(false);

                entity.Property(e => e.Complaintsourceguid).IsUnicode(false);

                entity.Property(e => e.Debitthetripamount).HasPrecision(1);

                entity.Property(e => e.Disabled).IsUnicode(false);

                entity.Property(e => e.Drivermasterguid).IsUnicode(false);

                entity.Property(e => e.Jobid).IsUnicode(false);

                entity.Property(e => e.Objectversionno).IsUnicode(false);

                entity.Property(e => e.Oracleentityid).IsUnicode(false);

                entity.Property(e => e.Oracleentityname).IsUnicode(false);

                entity.Property(e => e.Pkguid).IsUnicode(false);

                entity.Property(e => e.Pythonserverdata)
                    .IsUnicode(false)
                    .HasDefaultValueSql("null");

                entity.Property(e => e.Pythonserverstatus)
                    .IsUnicode(false)
                    .HasDefaultValueSql("null")
                    .IsFixedLength(true);

                entity.Property(e => e.Serviceproviderguid).IsUnicode(false);

                entity.Property(e => e.Suggestedactionguid).IsUnicode(false);

                entity.Property(e => e.Userarchived).IsUnicode(false);

                entity.Property(e => e.Usercreated).IsUnicode(false);

                entity.Property(e => e.Userdeleted).IsUnicode(false);

                entity.Property(e => e.Userupdated).IsUnicode(false);
            });

            modelBuilder.Entity<Complaintsourcemaster>(entity =>
            {
                entity.HasKey(e => e.Guid)
                    .HasName("SYS_C0010860");

                entity.Property(e => e.Guid).IsUnicode(false);

                entity.Property(e => e.Comments).IsUnicode(false);

                entity.Property(e => e.Description).IsUnicode(false);

                entity.Property(e => e.Disabled)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(0) ")
                    .IsFixedLength(true);

                entity.Property(e => e.Name).IsUnicode(false);

                entity.Property(e => e.Objectversionno).IsUnicode(false);

                entity.Property(e => e.Oracleentityid).IsUnicode(false);

                entity.Property(e => e.Oracleentityname).IsUnicode(false);

                entity.Property(e => e.Pkguid).IsUnicode(false);

                entity.Property(e => e.Quickaccesscode).IsUnicode(false);

                entity.Property(e => e.Userarchived).IsUnicode(false);

                entity.Property(e => e.Usercreated).IsUnicode(false);

                entity.Property(e => e.Userdeleted).IsUnicode(false);

                entity.Property(e => e.Userupdated).IsUnicode(false);
            });

            modelBuilder.Entity<Complaintstatusmaster>(entity =>
            {
                entity.Property(e => e.Comments).IsUnicode(false);

                entity.Property(e => e.Description).IsUnicode(false);

                entity.Property(e => e.Disabled)
                    .HasPrecision(1)
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Guid).IsUnicode(false);

                entity.Property(e => e.Name).IsUnicode(false);

                entity.Property(e => e.Objectversionno).IsUnicode(false);

                entity.Property(e => e.Oracleentityid).IsUnicode(false);

                entity.Property(e => e.Oracleentityname).IsUnicode(false);

                entity.Property(e => e.Pkguid).IsUnicode(false);

                entity.Property(e => e.Quickaccesscode).IsUnicode(false);

                entity.Property(e => e.Userarchived).IsUnicode(false);

                entity.Property(e => e.Usercreated).IsUnicode(false);

                entity.Property(e => e.Userdeleted).IsUnicode(false);

                entity.Property(e => e.Userupdated).IsUnicode(false);
            });

            modelBuilder.Entity<ContactBaseV>(entity =>
            {
                entity.ToView("CONTACT_BASE_V");

                entity.Property(e => e.Contactsubtypeguid).IsUnicode(false);

                entity.Property(e => e.Contacttypemasterguid).IsUnicode(false);

                entity.Property(e => e.Subtypecomments).IsUnicode(false);

                entity.Property(e => e.Subtypedescription).IsUnicode(false);

                entity.Property(e => e.Subtypedisabled).HasPrecision(1);

                entity.Property(e => e.Subtypename).IsUnicode(false);

                entity.Property(e => e.Subtypeobjectversionno).HasPrecision(10);

                entity.Property(e => e.Subtypeoracleentityid).IsUnicode(false);

                entity.Property(e => e.Subtypeoracleentityname).IsUnicode(false);

                entity.Property(e => e.Subtypepkguid).IsUnicode(false);

                entity.Property(e => e.Subtypequickaccesscode).IsUnicode(false);

                entity.Property(e => e.Typemastercomments).IsUnicode(false);

                entity.Property(e => e.Typemasterdescription).IsUnicode(false);

                entity.Property(e => e.Typemasterdisabled).HasPrecision(1);

                entity.Property(e => e.Typemastername).IsUnicode(false);

                entity.Property(e => e.Typemasterobjectversionno).HasPrecision(10);

                entity.Property(e => e.Typemasteroracleentityid).IsUnicode(false);

                entity.Property(e => e.Typemasteroracleentityname).IsUnicode(false);

                entity.Property(e => e.Typemasterpkguid).IsUnicode(false);

                entity.Property(e => e.Typemasterquickaccesscode).IsUnicode(false);
            });

            modelBuilder.Entity<ContactV>(entity =>
            {
                entity.ToView("CONTACT_V");

                entity.Property(e => e.Contactsubtypeguid).IsUnicode(false);

                entity.Property(e => e.Contacttypemasterguid).IsUnicode(false);

                entity.Property(e => e.Subtypecomments).IsUnicode(false);

                entity.Property(e => e.Subtypedescription).IsUnicode(false);

                entity.Property(e => e.Subtypedisabled).HasPrecision(1);

                entity.Property(e => e.Subtypename).IsUnicode(false);

                entity.Property(e => e.Subtypeobjectversionno).HasPrecision(10);

                entity.Property(e => e.Subtypeoracleentityid).IsUnicode(false);

                entity.Property(e => e.Subtypeoracleentityname).IsUnicode(false);

                entity.Property(e => e.Subtypepkguid).IsUnicode(false);

                entity.Property(e => e.Subtypequickaccesscode).IsUnicode(false);

                entity.Property(e => e.Typemastercomments).IsUnicode(false);

                entity.Property(e => e.Typemasterdescription).IsUnicode(false);

                entity.Property(e => e.Typemasterdisabled).HasPrecision(1);

                entity.Property(e => e.Typemastername).IsUnicode(false);

                entity.Property(e => e.Typemasterobjectversionno).HasPrecision(10);

                entity.Property(e => e.Typemasteroracleentityid).IsUnicode(false);

                entity.Property(e => e.Typemasteroracleentityname).IsUnicode(false);

                entity.Property(e => e.Typemasterpkguid).IsUnicode(false);

                entity.Property(e => e.Typemasterquickaccesscode).IsUnicode(false);
            });

            modelBuilder.Entity<Contactsubtype>(entity =>
            {
                entity.Property(e => e.Comments).IsUnicode(false);

                entity.Property(e => e.Contacttypemasterguid).IsUnicode(false);

                entity.Property(e => e.Description).IsUnicode(false);

                entity.Property(e => e.Disabled).HasPrecision(1);

                entity.Property(e => e.Guid).IsUnicode(false);

                entity.Property(e => e.Name).IsUnicode(false);

                entity.Property(e => e.Objectversionno).HasPrecision(10);

                entity.Property(e => e.Oracleentityid).IsUnicode(false);

                entity.Property(e => e.Oracleentityname).IsUnicode(false);

                entity.Property(e => e.Pkguid).IsUnicode(false);

                entity.Property(e => e.Quickaccesscode).IsUnicode(false);

                entity.Property(e => e.Userarchived).IsUnicode(false);

                entity.Property(e => e.Usercreated).IsUnicode(false);

                entity.Property(e => e.Userdeleted).IsUnicode(false);

                entity.Property(e => e.Userupdated).IsUnicode(false);
            });

            modelBuilder.Entity<Contacttypemaster>(entity =>
            {
                entity.Property(e => e.Comments).IsUnicode(false);

                entity.Property(e => e.Description).IsUnicode(false);

                entity.Property(e => e.Disabled).HasPrecision(1);

                entity.Property(e => e.Guid).IsUnicode(false);

                entity.Property(e => e.Name).IsUnicode(false);

                entity.Property(e => e.Objectversionno).HasPrecision(10);

                entity.Property(e => e.Oracleentityid).IsUnicode(false);

                entity.Property(e => e.Oracleentityname).IsUnicode(false);

                entity.Property(e => e.Pkguid).IsUnicode(false);

                entity.Property(e => e.Quickaccesscode).IsUnicode(false);

                entity.Property(e => e.Userarchived).IsUnicode(false);

                entity.Property(e => e.Usercreated).IsUnicode(false);

                entity.Property(e => e.Userdeleted).IsUnicode(false);

                entity.Property(e => e.Userupdated).IsUnicode(false);
            });

            modelBuilder.Entity<CorporateMaster>(entity =>
            {
                entity.HasKey(e => e.Guid)
                    .HasName("SYS_C0010819");

                entity.Property(e => e.Guid).IsUnicode(false);

                entity.Property(e => e.Code).IsUnicode(false);

                entity.Property(e => e.Description).IsUnicode(false);

                entity.Property(e => e.Name).IsUnicode(false);

                entity.Property(e => e.Usercreated).IsUnicode(false);
            });

            modelBuilder.Entity<Corporatetriprequest>(entity =>
            {
                entity.HasKey(e => e.VoucherId)
                    .HasName("VOUCHER_PK");

                entity.Property(e => e.VoucherId).IsUnicode(false);

                entity.Property(e => e.CapturedTime).IsUnicode(false);

                entity.Property(e => e.JobId).IsUnicode(false);

                entity.Property(e => e.Source).IsUnicode(false);

                entity.Property(e => e.Url).IsUnicode(false);
            });

            modelBuilder.Entity<Countrymaster>(entity =>
            {
                entity.Property(e => e.Comments).IsUnicode(false);

                entity.Property(e => e.Countrycode).IsUnicode(false);

                entity.Property(e => e.Description).IsUnicode(false);

                entity.Property(e => e.Disabled).HasPrecision(1);

                entity.Property(e => e.Guid).IsUnicode(false);

                entity.Property(e => e.Name).IsUnicode(false);

                entity.Property(e => e.Objectversionno).HasPrecision(10);

                entity.Property(e => e.Oracleentityid).IsUnicode(false);

                entity.Property(e => e.Oracleentityname).IsUnicode(false);

                entity.Property(e => e.Pkguid).IsUnicode(false);

                entity.Property(e => e.Quickaccesscode).IsUnicode(false);

                entity.Property(e => e.Userarchived).IsUnicode(false);

                entity.Property(e => e.Usercreated).IsUnicode(false);

                entity.Property(e => e.Userdeleted).IsUnicode(false);

                entity.Property(e => e.Userupdated).IsUnicode(false);
            });

            modelBuilder.Entity<CreditbalanceV>(entity =>
            {
                entity.ToView("CREDITBALANCE_V");

                entity.Property(e => e.CarNo).IsUnicode(false);

                entity.Property(e => e.MaxLimit).IsUnicode(false);

                entity.Property(e => e.MinLimit).IsUnicode(false);

                entity.Property(e => e.Multiplier).IsUnicode(false);

                entity.Property(e => e.SpId).IsUnicode(false);

                entity.Property(e => e.ValueMultiplier).IsUnicode(false);
            });

            modelBuilder.Entity<Creditbalancelimit>(entity =>
            {
                entity.Property(e => e.Amount).HasDefaultValueSql("0");

                entity.Property(e => e.CarNo).IsUnicode(false);

                entity.Property(e => e.Guid).IsUnicode(false);
            });

            modelBuilder.Entity<Creditlimitconfig>(entity =>
            {
                entity.HasKey(e => e.Guid)
                    .HasName("SYS_C0065914");

                entity.Property(e => e.Guid).IsUnicode(false);

                entity.Property(e => e.Creditlimitamount).HasPrecision(12);

                entity.Property(e => e.Creditlimitday).HasPrecision(2);

                entity.Property(e => e.Securitycombinationguid).IsUnicode(false);
            });

            modelBuilder.Entity<CycledatesV>(entity =>
            {
                entity.ToView("CYCLEDATES_V");

                entity.Property(e => e.Cyclemasterguid).IsUnicode(false);

                entity.Property(e => e.Guid)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Name).IsUnicode(false);

                entity.Property(e => e.Quickaccesscode).IsUnicode(false);
            });

            modelBuilder.Entity<Cycleday>(entity =>
            {
                entity.Property(e => e.Comments).IsUnicode(false);

                entity.Property(e => e.Cyclemasterguid).IsUnicode(false);

                entity.Property(e => e.Description).IsUnicode(false);

                entity.Property(e => e.Disabled).HasPrecision(1);

                entity.Property(e => e.Guid)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Name).IsUnicode(false);

                entity.Property(e => e.Objectversionno)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Oracleentityid)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Oracleentityname)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Oracleentitytype)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Pkguid).IsUnicode(false);

                entity.Property(e => e.Quickaccesscode).IsUnicode(false);

                entity.Property(e => e.Userarchived)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Usercreated)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Userdeleted)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Userupdated)
                    .IsUnicode(false)
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<Cyclemaster>(entity =>
            {
                entity.Property(e => e.Comments).IsUnicode(false);

                entity.Property(e => e.Description).IsUnicode(false);

                entity.Property(e => e.Disabled).HasPrecision(1);

                entity.Property(e => e.Guid)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Name).IsUnicode(false);

                entity.Property(e => e.Objectversionno)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Oracleentityid)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Oracleentityname)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Oracleentitytype)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Pkguid).IsUnicode(false);

                entity.Property(e => e.Quickaccesscode).IsUnicode(false);

                entity.Property(e => e.Userarchived)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Usercreated)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Userdeleted)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Userupdated)
                    .IsUnicode(false)
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<CyclemasterBaseV>(entity =>
            {
                entity.ToView("CYCLEMASTER_BASE_V");

                entity.Property(e => e.Cycledaycomments).IsUnicode(false);

                entity.Property(e => e.Cycledaydescription).IsUnicode(false);

                entity.Property(e => e.Cycledaydisabled).HasPrecision(1);

                entity.Property(e => e.Cycledayguid)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Cycledayname).IsUnicode(false);

                entity.Property(e => e.Cycledayobjectversionno)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Cycledayoracleentityid)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Cycledayoracleentityname)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Cycledayoracleentitytype)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Cycledaypkguid).IsUnicode(false);

                entity.Property(e => e.Cycledayquickaccesscode).IsUnicode(false);

                entity.Property(e => e.Cyclemastercomments).IsUnicode(false);

                entity.Property(e => e.Cyclemasterdescription).IsUnicode(false);

                entity.Property(e => e.Cyclemasterdisabled).HasPrecision(1);

                entity.Property(e => e.Cyclemasterguid)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Cyclemastername).IsUnicode(false);

                entity.Property(e => e.Cyclemasterobjectversionno)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Cyclemasteroracleentityid)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Cyclemasteroracleentityname)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Cyclemasteroracleentitytype)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Cyclemasterpkguid).IsUnicode(false);

                entity.Property(e => e.Cyclemasterquickaccesscode).IsUnicode(false);
            });

            modelBuilder.Entity<CyclemasterV>(entity =>
            {
                entity.ToView("CYCLEMASTER_V");

                entity.Property(e => e.Cycledaycomments).IsUnicode(false);

                entity.Property(e => e.Cycledaydescription).IsUnicode(false);

                entity.Property(e => e.Cycledaydisabled).HasPrecision(1);

                entity.Property(e => e.Cycledayguid)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Cycledayname).IsUnicode(false);

                entity.Property(e => e.Cycledayobjectversionno)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Cycledayoracleentityid)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Cycledayoracleentityname)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Cycledayoracleentitytype)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Cycledaypkguid).IsUnicode(false);

                entity.Property(e => e.Cycledayquickaccesscode).IsUnicode(false);

                entity.Property(e => e.Cyclemastercomments).IsUnicode(false);

                entity.Property(e => e.Cyclemasterdescription).IsUnicode(false);

                entity.Property(e => e.Cyclemasterdisabled).HasPrecision(1);

                entity.Property(e => e.Cyclemasterguid)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Cyclemastername).IsUnicode(false);

                entity.Property(e => e.Cyclemasterobjectversionno)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Cyclemasteroracleentityid)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Cyclemasteroracleentityname)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Cyclemasteroracleentitytype)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Cyclemasterpkguid).IsUnicode(false);

                entity.Property(e => e.Cyclemasterquickaccesscode).IsUnicode(false);
            });

            modelBuilder.Entity<DailyCarTransactionV>(entity =>
            {
                entity.ToView("DAILY_CAR_TRANSACTION_V");

                entity.Property(e => e.CarRegnNo).IsUnicode(false);

                entity.Property(e => e.Carmasterguid).IsUnicode(false);
            });

            modelBuilder.Entity<DailyTransactionSummaryV>(entity =>
            {
                entity.ToView("DAILY_TRANSACTION_SUMMARY_V");

                entity.Property(e => e.Carmasterguid).IsUnicode(false);

                entity.Property(e => e.SiteGuid).IsUnicode(false);
            });

            modelBuilder.Entity<DatesV>(entity =>
            {
                entity.ToView("DATES_V");
            });

            modelBuilder.Entity<DepositOldRuleV>(entity =>
            {
                entity.ToView("DEPOSIT_OLD_RULE_V");

                entity.Property(e => e.Carmasterguid).IsUnicode(false);
            });

            modelBuilder.Entity<DepositRuleV>(entity =>
            {
                entity.ToView("DEPOSIT_RULE_V");

                entity.Property(e => e.Carmasterguid).IsUnicode(false);
            });

            modelBuilder.Entity<DeviceBaseV>(entity =>
            {
                entity.ToView("DEVICE_BASE_V");

                entity.Property(e => e.DevGuid).IsUnicode(false);

                entity.Property(e => e.DevId).IsUnicode(false);

                entity.Property(e => e.DevLoc).IsUnicode(false);

                entity.Property(e => e.DevMake).IsUnicode(false);

                entity.Property(e => e.DevMakeCode).IsUnicode(false);

                entity.Property(e => e.DevMobNo).IsUnicode(false);

                entity.Property(e => e.DevModel).IsUnicode(false);

                entity.Property(e => e.DevModelcode).IsUnicode(false);

                entity.Property(e => e.DevObjVerNo).HasPrecision(10);

                entity.Property(e => e.DevOwner).IsUnicode(false);

                entity.Property(e => e.DevOwnerSpStatus).IsUnicode(false);

                entity.Property(e => e.DevOwnerSpid).IsUnicode(false);

                entity.Property(e => e.DevOwnerSpname).IsUnicode(false);

                entity.Property(e => e.DevPkguid).IsUnicode(false);

                entity.Property(e => e.DevSerialNo).IsUnicode(false);

                entity.Property(e => e.DevStatusCode).IsUnicode(false);

                entity.Property(e => e.DevStatusName).IsUnicode(false);

                entity.Property(e => e.DevTypeCode).IsUnicode(false);

                entity.Property(e => e.DevTypeName).IsUnicode(false);

                entity.Property(e => e.LebranchGuid).IsUnicode(false);

                entity.Property(e => e.SecGuid).IsUnicode(false);
            });

            modelBuilder.Entity<DeviceDocActionV>(entity =>
            {
                entity.ToView("DEVICE_DOC_ACTION_V");

                entity.Property(e => e.ActionCode).IsUnicode(false);

                entity.Property(e => e.ActionDescription).IsUnicode(false);

                entity.Property(e => e.ActionName).IsUnicode(false);

                entity.Property(e => e.Deviceid).IsUnicode(false);

                entity.Property(e => e.Devicemasterguid).IsUnicode(false);

                entity.Property(e => e.DocActionPkguid).IsUnicode(false);

                entity.Property(e => e.DocGuid).IsUnicode(false);

                entity.Property(e => e.DocType).IsUnicode(false);

                entity.Property(e => e.Documentno).IsUnicode(false);

                entity.Property(e => e.Lebranchsecurityguid).IsUnicode(false);

                entity.Property(e => e.Mobileno).IsUnicode(false);

                entity.Property(e => e.Serialno).IsUnicode(false);

                entity.Property(e => e.Serviceproviderguid).IsUnicode(false);
            });

            modelBuilder.Entity<DeviceMdtV>(entity =>
            {
                entity.ToView("DEVICE_MDT_V");

                entity.Property(e => e.DevGuid).IsUnicode(false);

                entity.Property(e => e.DevId).IsUnicode(false);

                entity.Property(e => e.DevLoc).IsUnicode(false);

                entity.Property(e => e.DevMake).IsUnicode(false);

                entity.Property(e => e.DevMakeCode).IsUnicode(false);

                entity.Property(e => e.DevMobNo).IsUnicode(false);

                entity.Property(e => e.DevModel).IsUnicode(false);

                entity.Property(e => e.DevModelcode).IsUnicode(false);

                entity.Property(e => e.DevObjVerNo).HasPrecision(10);

                entity.Property(e => e.DevOwner).IsUnicode(false);

                entity.Property(e => e.DevOwnerSpStatus).IsUnicode(false);

                entity.Property(e => e.DevOwnerSpid).IsUnicode(false);

                entity.Property(e => e.DevOwnerSpname).IsUnicode(false);

                entity.Property(e => e.DevPkguid).IsUnicode(false);

                entity.Property(e => e.DevSerialNo).IsUnicode(false);

                entity.Property(e => e.DevStatusCode).IsUnicode(false);

                entity.Property(e => e.DevStatusName).IsUnicode(false);

                entity.Property(e => e.DevTypeCode).IsUnicode(false);

                entity.Property(e => e.DevTypeName).IsUnicode(false);
            });

            modelBuilder.Entity<DeviceMeterV>(entity =>
            {
                entity.ToView("DEVICE_METER_V");

                entity.Property(e => e.DevGuid).IsUnicode(false);

                entity.Property(e => e.DevId).IsUnicode(false);

                entity.Property(e => e.DevLoc).IsUnicode(false);

                entity.Property(e => e.DevMake).IsUnicode(false);

                entity.Property(e => e.DevMakeCode).IsUnicode(false);

                entity.Property(e => e.DevMobNo).IsUnicode(false);

                entity.Property(e => e.DevModel).IsUnicode(false);

                entity.Property(e => e.DevModelcode).IsUnicode(false);

                entity.Property(e => e.DevObjVerNo).HasPrecision(10);

                entity.Property(e => e.DevOwner).IsUnicode(false);

                entity.Property(e => e.DevOwnerSpStatus).IsUnicode(false);

                entity.Property(e => e.DevOwnerSpid).IsUnicode(false);

                entity.Property(e => e.DevOwnerSpname).IsUnicode(false);

                entity.Property(e => e.DevPkguid).IsUnicode(false);

                entity.Property(e => e.DevSerialNo).IsUnicode(false);

                entity.Property(e => e.DevStatusCode).IsUnicode(false);

                entity.Property(e => e.DevStatusName).IsUnicode(false);

                entity.Property(e => e.DevTypeCode).IsUnicode(false);

                entity.Property(e => e.DevTypeName).IsUnicode(false);
            });

            modelBuilder.Entity<DevicePrinterV>(entity =>
            {
                entity.ToView("DEVICE_PRINTER_V");

                entity.Property(e => e.DevGuid).IsUnicode(false);

                entity.Property(e => e.DevId).IsUnicode(false);

                entity.Property(e => e.DevLoc).IsUnicode(false);

                entity.Property(e => e.DevMake).IsUnicode(false);

                entity.Property(e => e.DevMakeCode).IsUnicode(false);

                entity.Property(e => e.DevMobNo).IsUnicode(false);

                entity.Property(e => e.DevModel).IsUnicode(false);

                entity.Property(e => e.DevModelcode).IsUnicode(false);

                entity.Property(e => e.DevObjVerNo).HasPrecision(10);

                entity.Property(e => e.DevOwner).IsUnicode(false);

                entity.Property(e => e.DevOwnerSpStatus).IsUnicode(false);

                entity.Property(e => e.DevOwnerSpid).IsUnicode(false);

                entity.Property(e => e.DevOwnerSpname).IsUnicode(false);

                entity.Property(e => e.DevPkguid).IsUnicode(false);

                entity.Property(e => e.DevSerialNo).IsUnicode(false);

                entity.Property(e => e.DevStatusCode).IsUnicode(false);

                entity.Property(e => e.DevStatusName).IsUnicode(false);

                entity.Property(e => e.DevTypeCode).IsUnicode(false);

                entity.Property(e => e.DevTypeName).IsUnicode(false);
            });

            modelBuilder.Entity<DeviceReportV>(entity =>
            {
                entity.ToView("DEVICE_REPORT_V");

                entity.Property(e => e.BrandName).IsUnicode(false);

                entity.Property(e => e.CarGuid).IsUnicode(false);

                entity.Property(e => e.CarSecuritycombinationguid).IsUnicode(false);

                entity.Property(e => e.Carnumber).IsUnicode(false);

                entity.Property(e => e.CityName).IsUnicode(false);

                entity.Property(e => e.LeName).IsUnicode(false);

                entity.Property(e => e.Mdt).IsUnicode(false);

                entity.Property(e => e.MdtId).IsUnicode(false);

                entity.Property(e => e.MdtOwnershiptype).IsUnicode(false);

                entity.Property(e => e.MdtSerialno).IsUnicode(false);

                entity.Property(e => e.MdtStatus).IsUnicode(false);

                entity.Property(e => e.Meter).IsUnicode(false);

                entity.Property(e => e.MeterId).IsUnicode(false);

                entity.Property(e => e.MeterOwnershiptype).IsUnicode(false);

                entity.Property(e => e.MeterSerialno).IsUnicode(false);

                entity.Property(e => e.MeterStatus).IsUnicode(false);

                entity.Property(e => e.Mobile).IsUnicode(false);

                entity.Property(e => e.MobileId).IsUnicode(false);

                entity.Property(e => e.MobileOwnershiptype).IsUnicode(false);

                entity.Property(e => e.MobileSerialno).IsUnicode(false);

                entity.Property(e => e.MobileStatus).IsUnicode(false);

                entity.Property(e => e.ModelName).IsUnicode(false);

                entity.Property(e => e.Printer).IsUnicode(false);

                entity.Property(e => e.PrinterId).IsUnicode(false);

                entity.Property(e => e.PrinterOwnershiptype).IsUnicode(false);

                entity.Property(e => e.PrinterSerialno).IsUnicode(false);

                entity.Property(e => e.PrinterStatus).IsUnicode(false);

                entity.Property(e => e.Sim).IsUnicode(false);

                entity.Property(e => e.SimId).IsUnicode(false);

                entity.Property(e => e.SimOwnershiptype).IsUnicode(false);

                entity.Property(e => e.SimSerialno).IsUnicode(false);

                entity.Property(e => e.SimStatus).IsUnicode(false);
            });

            modelBuilder.Entity<DeviceSimV>(entity =>
            {
                entity.ToView("DEVICE_SIM_V");

                entity.Property(e => e.DevGuid).IsUnicode(false);

                entity.Property(e => e.DevId).IsUnicode(false);

                entity.Property(e => e.DevLoc).IsUnicode(false);

                entity.Property(e => e.DevMake).IsUnicode(false);

                entity.Property(e => e.DevMakeCode).IsUnicode(false);

                entity.Property(e => e.DevMobNo).IsUnicode(false);

                entity.Property(e => e.DevModel).IsUnicode(false);

                entity.Property(e => e.DevModelcode).IsUnicode(false);

                entity.Property(e => e.DevObjVerNo).HasPrecision(10);

                entity.Property(e => e.DevOwner).IsUnicode(false);

                entity.Property(e => e.DevOwnerSpStatus).IsUnicode(false);

                entity.Property(e => e.DevOwnerSpid).IsUnicode(false);

                entity.Property(e => e.DevOwnerSpname).IsUnicode(false);

                entity.Property(e => e.DevPkguid).IsUnicode(false);

                entity.Property(e => e.DevSerialNo).IsUnicode(false);

                entity.Property(e => e.DevStatusCode).IsUnicode(false);

                entity.Property(e => e.DevStatusName).IsUnicode(false);

                entity.Property(e => e.DevTypeCode).IsUnicode(false);

                entity.Property(e => e.DevTypeName).IsUnicode(false);
            });

            modelBuilder.Entity<DeviceV>(entity =>
            {
                entity.ToView("DEVICE_V");

                entity.Property(e => e.DevGuid).IsUnicode(false);

                entity.Property(e => e.DevId).IsUnicode(false);

                entity.Property(e => e.DevLoc).IsUnicode(false);

                entity.Property(e => e.DevMake).IsUnicode(false);

                entity.Property(e => e.DevMakeCode).IsUnicode(false);

                entity.Property(e => e.DevMobNo).IsUnicode(false);

                entity.Property(e => e.DevModel).IsUnicode(false);

                entity.Property(e => e.DevModelcode).IsUnicode(false);

                entity.Property(e => e.DevObjVerNo).HasPrecision(10);

                entity.Property(e => e.DevOwner).IsUnicode(false);

                entity.Property(e => e.DevOwnerSpStatus).IsUnicode(false);

                entity.Property(e => e.DevOwnerSpid).IsUnicode(false);

                entity.Property(e => e.DevOwnerSpname).IsUnicode(false);

                entity.Property(e => e.DevPkguid).IsUnicode(false);

                entity.Property(e => e.DevSerialNo).IsUnicode(false);

                entity.Property(e => e.DevStatusCode).IsUnicode(false);

                entity.Property(e => e.DevStatusName).IsUnicode(false);

                entity.Property(e => e.DevTypeCode).IsUnicode(false);

                entity.Property(e => e.DevTypeName).IsUnicode(false);

                entity.Property(e => e.LebranchGuid).IsUnicode(false);

                entity.Property(e => e.SecGuid).IsUnicode(false);
            });

            modelBuilder.Entity<Devicedoc>(entity =>
            {
                entity.Property(e => e.Devicemasterguid).IsUnicode(false);

                entity.Property(e => e.Disabled).HasPrecision(1);

                entity.Property(e => e.Documentname).IsUnicode(false);

                entity.Property(e => e.Documentno).IsUnicode(false);

                entity.Property(e => e.Documentpath).IsUnicode(false);

                entity.Property(e => e.Documenttypecategoryguid).IsUnicode(false);

                entity.Property(e => e.Documenttypeentityguid).IsUnicode(false);

                entity.Property(e => e.Guid).IsUnicode(false);

                entity.Property(e => e.Objectversionno).HasPrecision(10);

                entity.Property(e => e.Oracleentityid).IsUnicode(false);

                entity.Property(e => e.Oracleentityname).IsUnicode(false);

                entity.Property(e => e.Pkguid).IsUnicode(false);

                entity.Property(e => e.Statusentityguid).IsUnicode(false);

                entity.Property(e => e.Userarchived).IsUnicode(false);

                entity.Property(e => e.Usercreated).IsUnicode(false);

                entity.Property(e => e.Userdeleted).IsUnicode(false);

                entity.Property(e => e.Userupdated).IsUnicode(false);
            });

            modelBuilder.Entity<DevicedocsBaseV>(entity =>
            {
                entity.ToView("DEVICEDOCS_BASE_V");

                entity.Property(e => e.Cardevicemakemasterguid).IsUnicode(false);

                entity.Property(e => e.Cardevicemodelguid).IsUnicode(false);

                entity.Property(e => e.DeviceCurrentlocation).IsUnicode(false);

                entity.Property(e => e.DeviceStatusentityguid).IsUnicode(false);

                entity.Property(e => e.Deviceid).IsUnicode(false);

                entity.Property(e => e.Devicemasterguid).IsUnicode(false);

                entity.Property(e => e.Devicetypemasterguid).IsUnicode(false);

                entity.Property(e => e.DocDisabled).HasPrecision(1);

                entity.Property(e => e.DocDocumentpath).IsUnicode(false);

                entity.Property(e => e.DocGuid).IsUnicode(false);

                entity.Property(e => e.DocObjectversionno).HasPrecision(10);

                entity.Property(e => e.DocOracleentityid).IsUnicode(false);

                entity.Property(e => e.DocOracleentityname).IsUnicode(false);

                entity.Property(e => e.DocPkguid).IsUnicode(false);

                entity.Property(e => e.DocStatusCode).IsUnicode(false);

                entity.Property(e => e.DocStatusName).IsUnicode(false);

                entity.Property(e => e.DocStatusentityguid).IsUnicode(false);

                entity.Property(e => e.DocType).IsUnicode(false);

                entity.Property(e => e.DocTypeCode).IsUnicode(false);

                entity.Property(e => e.Documentname).IsUnicode(false);

                entity.Property(e => e.Documentno).IsUnicode(false);

                entity.Property(e => e.Documenttypecategoryguid).IsUnicode(false);

                entity.Property(e => e.Documenttypeentityguid).IsUnicode(false);

                entity.Property(e => e.Lebranchsecurityguid).IsUnicode(false);

                entity.Property(e => e.Mobileno).IsUnicode(false);

                entity.Property(e => e.Ownershiptype).IsUnicode(false);

                entity.Property(e => e.Serialno).IsUnicode(false);

                entity.Property(e => e.Serviceproviderguid).IsUnicode(false);
            });

            modelBuilder.Entity<DevicedocsV>(entity =>
            {
                entity.ToView("DEVICEDOCS_V");

                entity.Property(e => e.Cardevicemakemasterguid).IsUnicode(false);

                entity.Property(e => e.Cardevicemodelguid).IsUnicode(false);

                entity.Property(e => e.DeviceCurrentlocation).IsUnicode(false);

                entity.Property(e => e.DeviceStatusentityguid).IsUnicode(false);

                entity.Property(e => e.Deviceid).IsUnicode(false);

                entity.Property(e => e.Devicemasterguid).IsUnicode(false);

                entity.Property(e => e.Devicetypemasterguid).IsUnicode(false);

                entity.Property(e => e.DocDisabled).HasPrecision(1);

                entity.Property(e => e.DocDocumentpath).IsUnicode(false);

                entity.Property(e => e.DocGuid).IsUnicode(false);

                entity.Property(e => e.DocObjectversionno).HasPrecision(10);

                entity.Property(e => e.DocOracleentityid).IsUnicode(false);

                entity.Property(e => e.DocOracleentityname).IsUnicode(false);

                entity.Property(e => e.DocPkguid).IsUnicode(false);

                entity.Property(e => e.DocStatusCode).IsUnicode(false);

                entity.Property(e => e.DocStatusName).IsUnicode(false);

                entity.Property(e => e.DocStatusentityguid).IsUnicode(false);

                entity.Property(e => e.DocType).IsUnicode(false);

                entity.Property(e => e.DocTypeCode).IsUnicode(false);

                entity.Property(e => e.Documentname).IsUnicode(false);

                entity.Property(e => e.Documentno).IsUnicode(false);

                entity.Property(e => e.Documenttypecategoryguid).IsUnicode(false);

                entity.Property(e => e.Documenttypeentityguid).IsUnicode(false);

                entity.Property(e => e.Lebranchsecurityguid).IsUnicode(false);

                entity.Property(e => e.Mobileno).IsUnicode(false);

                entity.Property(e => e.Ownershiptype).IsUnicode(false);

                entity.Property(e => e.Serialno).IsUnicode(false);

                entity.Property(e => e.Serviceproviderguid).IsUnicode(false);
            });

            modelBuilder.Entity<DevicemakemasterBaseV>(entity =>
            {
                entity.ToView("DEVICEMAKEMASTER_BASE_V");

                entity.Property(e => e.Devicetypecomments).IsUnicode(false);

                entity.Property(e => e.Devicetypedescription).IsUnicode(false);

                entity.Property(e => e.Devicetypedisabled).HasPrecision(1);

                entity.Property(e => e.Devicetypemasterguid).IsUnicode(false);

                entity.Property(e => e.Devicetypename).IsUnicode(false);

                entity.Property(e => e.Devicetypeobjectversionno).HasPrecision(10);

                entity.Property(e => e.Devicetypeoracleentityid).IsUnicode(false);

                entity.Property(e => e.Devicetypeoracleentityname).IsUnicode(false);

                entity.Property(e => e.Devicetypepkguid).IsUnicode(false);

                entity.Property(e => e.Devicetypequickaccesscode).IsUnicode(false);

                entity.Property(e => e.Devicetyperegularexpression).IsUnicode(false);

                entity.Property(e => e.Makemastercomments).IsUnicode(false);

                entity.Property(e => e.Makemasterdescription).IsUnicode(false);

                entity.Property(e => e.Makemasterdisabled).HasPrecision(1);

                entity.Property(e => e.Makemasterguid).IsUnicode(false);

                entity.Property(e => e.Makemastername).IsUnicode(false);

                entity.Property(e => e.Makemasterobjectversionno).HasPrecision(10);

                entity.Property(e => e.Makemasteroracleentityid).IsUnicode(false);

                entity.Property(e => e.Makemasteroracleentityname).IsUnicode(false);

                entity.Property(e => e.Makemasterpkguid).IsUnicode(false);

                entity.Property(e => e.Makemasterquickaccesscode).IsUnicode(false);
            });

            modelBuilder.Entity<DevicemakemasterV>(entity =>
            {
                entity.ToView("DEVICEMAKEMASTER_V");

                entity.Property(e => e.Devicetypecomments).IsUnicode(false);

                entity.Property(e => e.Devicetypedescription).IsUnicode(false);

                entity.Property(e => e.Devicetypedisabled).HasPrecision(1);

                entity.Property(e => e.Devicetypemasterguid).IsUnicode(false);

                entity.Property(e => e.Devicetypename).IsUnicode(false);

                entity.Property(e => e.Devicetypeobjectversionno).HasPrecision(10);

                entity.Property(e => e.Devicetypeoracleentityid).IsUnicode(false);

                entity.Property(e => e.Devicetypeoracleentityname).IsUnicode(false);

                entity.Property(e => e.Devicetypepkguid).IsUnicode(false);

                entity.Property(e => e.Devicetypequickaccesscode).IsUnicode(false);

                entity.Property(e => e.Devicetyperegularexpression).IsUnicode(false);

                entity.Property(e => e.Makemastercomments).IsUnicode(false);

                entity.Property(e => e.Makemasterdescription).IsUnicode(false);

                entity.Property(e => e.Makemasterdisabled).HasPrecision(1);

                entity.Property(e => e.Makemasterguid).IsUnicode(false);

                entity.Property(e => e.Makemastername).IsUnicode(false);

                entity.Property(e => e.Makemasterobjectversionno).HasPrecision(10);

                entity.Property(e => e.Makemasteroracleentityid).IsUnicode(false);

                entity.Property(e => e.Makemasteroracleentityname).IsUnicode(false);

                entity.Property(e => e.Makemasterpkguid).IsUnicode(false);

                entity.Property(e => e.Makemasterquickaccesscode).IsUnicode(false);
            });

            modelBuilder.Entity<Devicemaster>(entity =>
            {
                entity.Property(e => e.Cardevicemakemasterguid).IsUnicode(false);

                entity.Property(e => e.Cardevicemodelguid).IsUnicode(false);

                entity.Property(e => e.Currentlocation).IsUnicode(false);

                entity.Property(e => e.Deviceid).IsUnicode(false);

                entity.Property(e => e.Devicetypemasterguid).IsUnicode(false);

                entity.Property(e => e.Guid).IsUnicode(false);

                entity.Property(e => e.Lebranchsecurityguid).IsUnicode(false);

                entity.Property(e => e.Mobileno).IsUnicode(false);

                entity.Property(e => e.Objectversionno).HasPrecision(10);

                entity.Property(e => e.Oracleentityid).IsUnicode(false);

                entity.Property(e => e.Oracleentityname).IsUnicode(false);

                entity.Property(e => e.Ownershiptype).IsUnicode(false);

                entity.Property(e => e.Pkguid).IsUnicode(false);

                entity.Property(e => e.Readyflag).IsUnicode(false);

                entity.Property(e => e.Securitycombinationguid).IsUnicode(false);

                entity.Property(e => e.Serialno).IsUnicode(false);

                entity.Property(e => e.Serviceproviderguid).IsUnicode(false);

                entity.Property(e => e.Statusentityguid).IsUnicode(false);

                entity.Property(e => e.Userarchived).IsUnicode(false);

                entity.Property(e => e.Usercreated).IsUnicode(false);

                entity.Property(e => e.Userdeleted).IsUnicode(false);

                entity.Property(e => e.Userupdated).IsUnicode(false);
            });

            modelBuilder.Entity<DevicemodelBaseV>(entity =>
            {
                entity.ToView("DEVICEMODEL_BASE_V");

                entity.Property(e => e.Devicetypemasterguid).IsUnicode(false);

                entity.Property(e => e.Makemastercomments).IsUnicode(false);

                entity.Property(e => e.Makemasterdescription).IsUnicode(false);

                entity.Property(e => e.Makemasterdisabled).HasPrecision(1);

                entity.Property(e => e.Makemasterguid).IsUnicode(false);

                entity.Property(e => e.Makemastername).IsUnicode(false);

                entity.Property(e => e.Makemasterobjectversionno).HasPrecision(10);

                entity.Property(e => e.Makemasteroracleentityid).IsUnicode(false);

                entity.Property(e => e.Makemasteroracleentityname).IsUnicode(false);

                entity.Property(e => e.Makemasterpkguid).IsUnicode(false);

                entity.Property(e => e.Makemasterquickaccesscode).IsUnicode(false);

                entity.Property(e => e.Modelcomments).IsUnicode(false);

                entity.Property(e => e.Modeldescription).IsUnicode(false);

                entity.Property(e => e.Modeldisabled).HasPrecision(1);

                entity.Property(e => e.Modelguid).IsUnicode(false);

                entity.Property(e => e.Modelname).IsUnicode(false);

                entity.Property(e => e.Modelobjectversionno).HasPrecision(10);

                entity.Property(e => e.Modeloracleentityid).IsUnicode(false);

                entity.Property(e => e.Modeloracleentityname).IsUnicode(false);

                entity.Property(e => e.Modelpkguid).IsUnicode(false);

                entity.Property(e => e.Modelquickaccesscode).IsUnicode(false);
            });

            modelBuilder.Entity<DevicemodelV>(entity =>
            {
                entity.ToView("DEVICEMODEL_V");

                entity.Property(e => e.Devicetypemasterguid).IsUnicode(false);

                entity.Property(e => e.Makemastercomments).IsUnicode(false);

                entity.Property(e => e.Makemasterdescription).IsUnicode(false);

                entity.Property(e => e.Makemasterdisabled).HasPrecision(1);

                entity.Property(e => e.Makemasterguid).IsUnicode(false);

                entity.Property(e => e.Makemastername).IsUnicode(false);

                entity.Property(e => e.Makemasterobjectversionno).HasPrecision(10);

                entity.Property(e => e.Makemasteroracleentityid).IsUnicode(false);

                entity.Property(e => e.Makemasteroracleentityname).IsUnicode(false);

                entity.Property(e => e.Makemasterpkguid).IsUnicode(false);

                entity.Property(e => e.Makemasterquickaccesscode).IsUnicode(false);

                entity.Property(e => e.Modelcomments).IsUnicode(false);

                entity.Property(e => e.Modeldescription).IsUnicode(false);

                entity.Property(e => e.Modeldisabled).HasPrecision(1);

                entity.Property(e => e.Modelguid).IsUnicode(false);

                entity.Property(e => e.Modelname).IsUnicode(false);

                entity.Property(e => e.Modelobjectversionno).HasPrecision(10);

                entity.Property(e => e.Modeloracleentityid).IsUnicode(false);

                entity.Property(e => e.Modeloracleentityname).IsUnicode(false);

                entity.Property(e => e.Modelpkguid).IsUnicode(false);

                entity.Property(e => e.Modelquickaccesscode).IsUnicode(false);
            });

            modelBuilder.Entity<Devicesecurity>(entity =>
            {
                entity.Property(e => e.BrandName).IsUnicode(false);

                entity.Property(e => e.CityName).IsUnicode(false);

                entity.Property(e => e.Guid).IsUnicode(false);

                entity.Property(e => e.LeName).IsUnicode(false);

                entity.Property(e => e.ModelName).IsUnicode(false);
            });

            modelBuilder.Entity<Devicetypemaster>(entity =>
            {
                entity.Property(e => e.Comments).IsUnicode(false);

                entity.Property(e => e.Description).IsUnicode(false);

                entity.Property(e => e.Disabled).HasPrecision(1);

                entity.Property(e => e.Guid).IsUnicode(false);

                entity.Property(e => e.Name).IsUnicode(false);

                entity.Property(e => e.Objectversionno).HasPrecision(10);

                entity.Property(e => e.Oracleentityid).IsUnicode(false);

                entity.Property(e => e.Oracleentityname).IsUnicode(false);

                entity.Property(e => e.Pkguid).IsUnicode(false);

                entity.Property(e => e.Quickaccesscode).IsUnicode(false);

                entity.Property(e => e.Regularexpression).IsUnicode(false);

                entity.Property(e => e.Userarchived).IsUnicode(false);

                entity.Property(e => e.Usercreated).IsUnicode(false);

                entity.Property(e => e.Userdeleted).IsUnicode(false);

                entity.Property(e => e.Userupdated).IsUnicode(false);
            });

            modelBuilder.Entity<DisAllActiveAllocV>(entity =>
            {
                entity.ToView("DIS_ALL_ACTIVE_ALLOC_V");

                entity.Property(e => e.Carallocationguid).IsUnicode(false);

                entity.Property(e => e.Carmasterguid).IsUnicode(false);

                entity.Property(e => e.Carno).IsUnicode(false);

                entity.Property(e => e.Contactno).IsUnicode(false);

                entity.Property(e => e.Name).IsUnicode(false);

                entity.Property(e => e.Personid).IsUnicode(false);

                entity.Property(e => e.Personrole).IsUnicode(false);

                entity.Property(e => e.Serviceproviderguid).IsUnicode(false);

                entity.Property(e => e.Sppersonmasterguid).IsUnicode(false);
            });

            modelBuilder.Entity<DisAllActiveSpV>(entity =>
            {
                entity.ToView("DIS_ALL_ACTIVE_SP_V");

                entity.Property(e => e.Contactno).IsUnicode(false);

                entity.Property(e => e.Gender).IsUnicode(false);

                entity.Property(e => e.Guid).IsUnicode(false);

                entity.Property(e => e.Name).IsUnicode(false);

                entity.Property(e => e.Personid).IsUnicode(false);

                entity.Property(e => e.Personrole).IsUnicode(false);
            });

            modelBuilder.Entity<DisAllDocV>(entity =>
            {
                entity.ToView("DIS_ALL_DOC_V");

                entity.Property(e => e.Accountno).IsUnicode(false);

                entity.Property(e => e.Beneficieryname).IsUnicode(false);

                entity.Property(e => e.Displayname).IsUnicode(false);

                entity.Property(e => e.Documentname).IsUnicode(false);

                entity.Property(e => e.Documentno).IsUnicode(false);

                entity.Property(e => e.Entity).IsUnicode(false);

                entity.Property(e => e.Ifsccode).IsUnicode(false);

                entity.Property(e => e.Mandatory).IsUnicode(false);

                entity.Property(e => e.Owner).IsUnicode(false);

                entity.Property(e => e.Status).IsUnicode(false);
            });

            modelBuilder.Entity<DisAllocV>(entity =>
            {
                entity.ToView("DIS_ALLOC_V");

                entity.Property(e => e.Carmasterguid).IsUnicode(false);

                entity.Property(e => e.Personid).IsUnicode(false);

                entity.Property(e => e.Registrationno).IsUnicode(false);

                entity.Property(e => e.Securitycombinationguid).IsUnicode(false);

                entity.Property(e => e.Serviceproviderguid).IsUnicode(false);

                entity.Property(e => e.Sppersonguid).IsUnicode(false);

                entity.Property(e => e.Spsitemasterguid).IsUnicode(false);
            });

            modelBuilder.Entity<DisAllocatedCarsV>(entity =>
            {
                entity.ToView("DIS_ALLOCATED_CARS_V");

                entity.Property(e => e.Carmasterguid).IsUnicode(false);

                entity.Property(e => e.Contactno).IsUnicode(false);

                entity.Property(e => e.Gender).IsUnicode(false);

                entity.Property(e => e.Personrole).IsUnicode(false);

                entity.Property(e => e.Spid).IsUnicode(false);

                entity.Property(e => e.Spname).IsUnicode(false);

                entity.Property(e => e.Sppersonmasterguid).IsUnicode(false);
            });

            modelBuilder.Entity<DisApiMessageV>(entity =>
            {
                entity.ToView("DIS_API_MESSAGE_V");

                entity.Property(e => e.Apidescription).IsUnicode(false);

                entity.Property(e => e.Apimasterguid).IsUnicode(false);

                entity.Property(e => e.Apiname).IsUnicode(false);

                entity.Property(e => e.Apiquickaccesscode).IsUnicode(false);

                entity.Property(e => e.Disapimessagemasterguid).IsUnicode(false);

                entity.Property(e => e.Message).IsUnicode(false);

                entity.Property(e => e.Messagenumber).IsUnicode(false);

                entity.Property(e => e.Status).IsUnicode(false);

                entity.Property(e => e.Statuscode).IsUnicode(false);
            });

            modelBuilder.Entity<DisAuthTbl>(entity =>
            {
                entity.HasKey(e => e.Guid)
                    .HasName("AUTH_GUID_PK");

                entity.Property(e => e.Guid).IsUnicode(false);

                entity.Property(e => e.Attribute1).IsUnicode(false);

                entity.Property(e => e.Attribute2).IsUnicode(false);

                entity.Property(e => e.Attribute3).IsUnicode(false);

                entity.Property(e => e.Attribute4).IsUnicode(false);

                entity.Property(e => e.Attribute5).IsUnicode(false);

                entity.Property(e => e.Isbundlewithdispatchapp)
                    .IsUnicode(false)
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Personmasterguid).IsUnicode(false);

                entity.Property(e => e.Pkguid).IsUnicode(false);

                entity.Property(e => e.Referenceotpguid).IsUnicode(false);

                entity.Property(e => e.Usercreated).IsUnicode(false);

                entity.Property(e => e.Userdeleted).IsUnicode(false);

                entity.Property(e => e.Userupdated).IsUnicode(false);
            });

            modelBuilder.Entity<DisAuthoriseDevice>(entity =>
            {
                entity.HasKey(e => e.Guid)
                    .HasName("AUTH_DEV_GUID_PK");

                entity.Property(e => e.Guid).IsUnicode(false);

                entity.Property(e => e.Attribute1).IsUnicode(false);

                entity.Property(e => e.Attribute2).IsUnicode(false);

                entity.Property(e => e.Attribute3).IsUnicode(false);

                entity.Property(e => e.Attribute4).IsUnicode(false);

                entity.Property(e => e.Attribute5).IsUnicode(false);

                entity.Property(e => e.Carguid).IsUnicode(false);

                entity.Property(e => e.DeviceImei).IsUnicode(false);

                entity.Property(e => e.Fcmtoken).IsUnicode(false);

                entity.Property(e => e.Hwdeviceid).IsUnicode(false);

                entity.Property(e => e.Pkguid).IsUnicode(false);

                entity.Property(e => e.Pragatideviceid).IsUnicode(false);

                entity.Property(e => e.Usercreated).IsUnicode(false);

                entity.Property(e => e.Userdeleted).IsUnicode(false);

                entity.Property(e => e.Userupdated).IsUnicode(false);
            });

            modelBuilder.Entity<DisCarDocV>(entity =>
            {
                entity.ToView("DIS_CAR_DOC_V");

                entity.Property(e => e.Displayname).IsUnicode(false);

                entity.Property(e => e.Documentname).IsUnicode(false);

                entity.Property(e => e.Documentno).IsUnicode(false);

                entity.Property(e => e.Entity).IsUnicode(false);

                entity.Property(e => e.Mandatory).IsUnicode(false);

                entity.Property(e => e.Owner).IsUnicode(false);

                entity.Property(e => e.Status).IsUnicode(false);
            });

            modelBuilder.Entity<DisComplaintV>(entity =>
            {
                entity.ToView("DIS_COMPLAINT_V");

                entity.Property(e => e.Carregnno).IsUnicode(false);

                entity.Property(e => e.Categorylevel).IsUnicode(false);

                entity.Property(e => e.Complaintid).IsUnicode(false);

                entity.Property(e => e.Complaintincommingcategory).IsUnicode(false);

                entity.Property(e => e.Driverid).IsUnicode(false);

                entity.Property(e => e.Spid).IsUnicode(false);
            });

            modelBuilder.Entity<DisDeviceDocV>(entity =>
            {
                entity.ToView("DIS_DEVICE_DOC_V");

                entity.Property(e => e.Displayname).IsUnicode(false);

                entity.Property(e => e.Documentname).IsUnicode(false);

                entity.Property(e => e.Documentno).IsUnicode(false);

                entity.Property(e => e.Entity).IsUnicode(false);

                entity.Property(e => e.Mandatory).IsUnicode(false);

                entity.Property(e => e.Owner).IsUnicode(false);

                entity.Property(e => e.Status).IsUnicode(false);
            });

            modelBuilder.Entity<DisDriverDocV>(entity =>
            {
                entity.ToView("DIS_DRIVER_DOC_V");

                entity.Property(e => e.Displayname).IsUnicode(false);

                entity.Property(e => e.Documentname).IsUnicode(false);

                entity.Property(e => e.Documentno).IsUnicode(false);

                entity.Property(e => e.Entity).IsUnicode(false);

                entity.Property(e => e.Mandatory).IsUnicode(false);

                entity.Property(e => e.Owner).IsUnicode(false);

                entity.Property(e => e.Status).IsUnicode(false);
            });

            modelBuilder.Entity<DisFcmTokenTbl>(entity =>
            {
                entity.HasKey(e => e.Guid)
                    .HasName("DISFCMTOKENTBL_PK");

                entity.Property(e => e.Guid).IsUnicode(false);

                entity.Property(e => e.Auth).IsUnicode(false);

                entity.Property(e => e.Fcmtoken).IsUnicode(false);

                entity.Property(e => e.Hwdeviceid).IsUnicode(false);

                entity.Property(e => e.Mobileno).IsUnicode(false);

                entity.Property(e => e.Usercreated).IsUnicode(false);

                entity.Property(e => e.Userupdated).IsUnicode(false);
            });

            modelBuilder.Entity<DisFcmTokenV>(entity =>
            {
                entity.ToView("DIS_FCM_TOKEN_V");

                entity.Property(e => e.Auth).IsUnicode(false);

                entity.Property(e => e.Driverflag).HasPrecision(1);

                entity.Property(e => e.Dseflag).HasPrecision(1);

                entity.Property(e => e.Fcmtoken).IsUnicode(false);

                entity.Property(e => e.Guid).IsUnicode(false);

                entity.Property(e => e.Hwdeviceid).IsUnicode(false);

                entity.Property(e => e.Mobileno).IsUnicode(false);

                entity.Property(e => e.Name).IsUnicode(false);

                entity.Property(e => e.Personid).IsUnicode(false);

                entity.Property(e => e.Spflag).HasPrecision(1);
            });

            modelBuilder.Entity<DisFcmtknMessage>(entity =>
            {
                entity.HasKey(e => e.Guid)
                    .HasName("DISFCMTKNMSG_PK");

                entity.Property(e => e.Guid).IsUnicode(false);

                entity.Property(e => e.Fcmtoken).IsUnicode(false);

                entity.Property(e => e.Hwdeviceid).IsUnicode(false);

                entity.Property(e => e.Message).IsUnicode(false);

                entity.Property(e => e.Mobileno).IsUnicode(false);

                entity.Property(e => e.Pragatideviceid).IsUnicode(false);

                entity.Property(e => e.Serverresponse).IsUnicode(false);

                entity.Property(e => e.Status).IsUnicode(false);
            });

            modelBuilder.Entity<DisMandatoryDocTbl>(entity =>
            {
                entity.Property(e => e.Displayname).IsUnicode(false);

                entity.Property(e => e.Documenttypeentityguid).IsUnicode(false);

                entity.Property(e => e.Documenttypemastername).IsUnicode(false);

                entity.Property(e => e.Entity).IsUnicode(false);

                entity.Property(e => e.Mandatory).IsUnicode(false);

                entity.Property(e => e.Quickaccesscode).IsUnicode(false);
            });

            modelBuilder.Entity<DisOtpTbl>(entity =>
            {
                entity.HasKey(e => e.Guid)
                    .HasName("OTP_MOB_OTP_PK");

                entity.Property(e => e.Guid).IsUnicode(false);

                entity.Property(e => e.Attribute1).IsUnicode(false);

                entity.Property(e => e.Attribute2).IsUnicode(false);

                entity.Property(e => e.Attribute3).IsUnicode(false);

                entity.Property(e => e.Attribute4).IsUnicode(false);

                entity.Property(e => e.Attribute5).IsUnicode(false);

                entity.Property(e => e.Personguid).IsUnicode(false);

                entity.Property(e => e.Pkguid).IsUnicode(false);

                entity.Property(e => e.Usercreated).IsUnicode(false);

                entity.Property(e => e.Userdeleted).IsUnicode(false);

                entity.Property(e => e.Userupdated).IsUnicode(false);
            });

            modelBuilder.Entity<DisOutstandingHistV>(entity =>
            {
                entity.ToView("DIS_OUTSTANDING_HIST_V");

                entity.Property(e => e.Personid).IsUnicode(false);

                entity.Property(e => e.Registrationno).IsUnicode(false);

                entity.Property(e => e.Siteguid).IsUnicode(false);
            });

            modelBuilder.Entity<DisPersonV>(entity =>
            {
                entity.ToView("DIS_PERSON_V");

                entity.Property(e => e.Contactno).IsUnicode(false);

                entity.Property(e => e.Driverflag).HasPrecision(1);

                entity.Property(e => e.Dseflag).HasPrecision(1);

                entity.Property(e => e.Gender).IsUnicode(false);

                entity.Property(e => e.Mentorreferenceid).IsUnicode(false);

                entity.Property(e => e.Name).IsUnicode(false);

                entity.Property(e => e.Personid).IsUnicode(false);

                entity.Property(e => e.Personmasterguid).IsUnicode(false);

                entity.Property(e => e.Personrole).IsUnicode(false);

                entity.Property(e => e.Spflag).HasPrecision(1);
            });

            modelBuilder.Entity<DisPosteddocTbl>(entity =>
            {
                entity.HasKey(e => e.Documnetsrno)
                    .HasName("DIS_POSTDOC_PK");

                entity.Property(e => e.Attribute1).IsUnicode(false);

                entity.Property(e => e.Attribute2).IsUnicode(false);

                entity.Property(e => e.Attribute3).IsUnicode(false);

                entity.Property(e => e.Bankaccountno).IsUnicode(false);

                entity.Property(e => e.Bankbeneficiaryname).IsUnicode(false);

                entity.Property(e => e.Bankifsccode).IsUnicode(false);

                entity.Property(e => e.Carno).IsUnicode(false);

                entity.Property(e => e.Docpath).IsUnicode(false);

                entity.Property(e => e.Doctype).IsUnicode(false);

                entity.Property(e => e.Doctypename).IsUnicode(false);

                entity.Property(e => e.Mentor).IsUnicode(false);

                entity.Property(e => e.Mentoroperationstatus).IsUnicode(false);

                entity.Property(e => e.Personid).IsUnicode(false);

                entity.Property(e => e.Status).IsUnicode(false);

                entity.Property(e => e.Usercreated).IsUnicode(false);

                entity.Property(e => e.Userupdated).IsUnicode(false);
            });

            modelBuilder.Entity<DisPragatiTxnV>(entity =>
            {
                entity.ToView("DIS_PRAGATI_TXN_V");

                entity.Property(e => e.CarGuid).IsUnicode(false);

                entity.Property(e => e.Comments).IsUnicode(false);

                entity.Property(e => e.Immediatepaytermflag).IsUnicode(false);

                entity.Property(e => e.PersonGuid).IsUnicode(false);

                entity.Property(e => e.Registrationno).IsUnicode(false);

                entity.Property(e => e.SiteGuid).IsUnicode(false);

                entity.Property(e => e.Sitename).IsUnicode(false);

                entity.Property(e => e.SpGuid).IsUnicode(false);

                entity.Property(e => e.SpPersonId).IsUnicode(false);

                entity.Property(e => e.TxnClass).IsUnicode(false);

                entity.Property(e => e.TxnClassGuid).IsUnicode(false);

                entity.Property(e => e.TxnNo).IsUnicode(false);

                entity.Property(e => e.TxnType).IsUnicode(false);

                entity.Property(e => e.TxnTypeGuid).IsUnicode(false);
            });

            modelBuilder.Entity<DisRequestreasonmaster>(entity =>
            {
                entity.HasKey(e => new { e.Requestreasonno, e.Servicetypeno })
                    .HasName("DIS_RR_PK");

                entity.Property(e => e.Details).IsUnicode(false);

                entity.Property(e => e.Reason).IsUnicode(false);

                entity.Property(e => e.Usercreated).IsUnicode(false);
            });

            modelBuilder.Entity<DisServicerequest>(entity =>
            {
                entity.HasKey(e => e.Servicerequestno)
                    .HasName("DIS_SR_PK");

                entity.Property(e => e.Attribute1).IsUnicode(false);

                entity.Property(e => e.Attribute2).IsUnicode(false);

                entity.Property(e => e.Attribute3).IsUnicode(false);

                entity.Property(e => e.Mentor).IsUnicode(false);

                entity.Property(e => e.Mentoroperationstatus).IsUnicode(false);

                entity.Property(e => e.Personid).IsUnicode(false);

                entity.Property(e => e.Requestdetails).IsUnicode(false);

                entity.Property(e => e.Status).IsUnicode(false);

                entity.Property(e => e.Usercreated).IsUnicode(false);

                entity.Property(e => e.Userupdated).IsUnicode(false);
            });

            modelBuilder.Entity<DisServicerequestV>(entity =>
            {
                entity.ToView("DIS_SERVICEREQUEST_V");

                entity.Property(e => e.Attribute1).IsUnicode(false);

                entity.Property(e => e.Attribute2).IsUnicode(false);

                entity.Property(e => e.Attribute3).IsUnicode(false);

                entity.Property(e => e.Mentor).IsUnicode(false);

                entity.Property(e => e.Personid).IsUnicode(false);

                entity.Property(e => e.Reason).IsUnicode(false);

                entity.Property(e => e.Requestdetails).IsUnicode(false);

                entity.Property(e => e.Servicetypename).IsUnicode(false);

                entity.Property(e => e.Status).IsUnicode(false);

                entity.Property(e => e.Usercreated).IsUnicode(false);
            });

            modelBuilder.Entity<DisServicerequesttype>(entity =>
            {
                entity.HasKey(e => e.Servicetypeno)
                    .HasName("DIS_SRT_PK");

                entity.Property(e => e.Name).IsUnicode(false);

                entity.Property(e => e.Usercreated).IsUnicode(false);
            });

            modelBuilder.Entity<DisServicetypeReasonV>(entity =>
            {
                entity.ToView("DIS_SERVICETYPE_REASON_V");

                entity.Property(e => e.Reason).IsUnicode(false);

                entity.Property(e => e.Reasondetails).IsUnicode(false);

                entity.Property(e => e.Servicetypename).IsUnicode(false);
            });

            modelBuilder.Entity<DisSmseventdatum>(entity =>
            {
                entity.Property(e => e.EventCode).IsUnicode(false);

                entity.Property(e => e.ParamString).IsUnicode(false);

                entity.Property(e => e.ProcessedResult).IsUnicode(false);

                entity.Property(e => e.ProcessedStatus).IsUnicode(false);

                entity.Property(e => e.Smstype).IsUnicode(false);
            });

            modelBuilder.Entity<DisSpDocV>(entity =>
            {
                entity.ToView("DIS_SP_DOC_V");

                entity.Property(e => e.Accountno).IsUnicode(false);

                entity.Property(e => e.Beneficieryname).IsUnicode(false);

                entity.Property(e => e.Displayname).IsUnicode(false);

                entity.Property(e => e.Documentname).IsUnicode(false);

                entity.Property(e => e.Documentno).IsUnicode(false);

                entity.Property(e => e.Entity).IsUnicode(false);

                entity.Property(e => e.Ifsccode).IsUnicode(false);

                entity.Property(e => e.Mandatory).IsUnicode(false);

                entity.Property(e => e.Owner).IsUnicode(false);

                entity.Property(e => e.Status).IsUnicode(false);
            });

            modelBuilder.Entity<DisSpSiteBalHistV>(entity =>
            {
                entity.ToView("DIS_SP_SITE_BAL_HIST_V");

                entity.Property(e => e.Siteguid).IsUnicode(false);

                entity.Property(e => e.Sitename).IsUnicode(false);

                entity.Property(e => e.SpPerGuid).IsUnicode(false);

                entity.Property(e => e.SpPersonId).IsUnicode(false);
            });

            modelBuilder.Entity<DisSpTxnV>(entity =>
            {
                entity.ToView("DIS_SP_TXN_V");

                entity.Property(e => e.CarGuid).IsUnicode(false);

                entity.Property(e => e.Comments).IsUnicode(false);

                entity.Property(e => e.Immediatepaytermflag).IsUnicode(false);

                entity.Property(e => e.PersonGuid).IsUnicode(false);

                entity.Property(e => e.Registrationno).IsUnicode(false);

                entity.Property(e => e.SiteGuid).IsUnicode(false);

                entity.Property(e => e.Sitename).IsUnicode(false);

                entity.Property(e => e.SpGuid).IsUnicode(false);

                entity.Property(e => e.SpPersonId).IsUnicode(false);

                entity.Property(e => e.TxnClass).IsUnicode(false);

                entity.Property(e => e.TxnClassGuid).IsUnicode(false);

                entity.Property(e => e.TxnNo).IsUnicode(false);

                entity.Property(e => e.TxnType).IsUnicode(false);

                entity.Property(e => e.TxnTypeGuid).IsUnicode(false);
            });

            modelBuilder.Entity<DisStatmentTxntypeV>(entity =>
            {
                entity.ToView("DIS_STATMENT_TXNTYPE_V");

                entity.Property(e => e.Txntype).IsUnicode(false);
            });

            modelBuilder.Entity<DisTransactiontypePkgV>(entity =>
            {
                entity.ToView("DIS_TRANSACTIONTYPE_PKG_V");

                entity.Property(e => e.Signindicator).IsUnicode(false);

                entity.Property(e => e.Transactionclasscode).IsUnicode(false);

                entity.Property(e => e.Transactionclassname).IsUnicode(false);

                entity.Property(e => e.Transactiontypecode).IsUnicode(false);

                entity.Property(e => e.Transactiontypeguid).IsUnicode(false);

                entity.Property(e => e.Transactiontypename).IsUnicode(false);

                entity.Property(e => e.Txntype).IsUnicode(false);
            });

            modelBuilder.Entity<DisTransactiontypeV>(entity =>
            {
                entity.ToView("DIS_TRANSACTIONTYPE_V");

                entity.Property(e => e.Signindicator).IsUnicode(false);

                entity.Property(e => e.Transactionclasscode).IsUnicode(false);

                entity.Property(e => e.Transactionclassname).IsUnicode(false);

                entity.Property(e => e.Transactiontypecode).IsUnicode(false);

                entity.Property(e => e.Transactiontypeguid).IsUnicode(false);

                entity.Property(e => e.Transactiontypename).IsUnicode(false);

                entity.Property(e => e.Txntype).IsUnicode(false);
            });

            modelBuilder.Entity<DisTripAllV>(entity =>
            {
                entity.ToView("DIS_TRIP_ALL_V");

                entity.Property(e => e.PaymentMode).IsUnicode(false);

                entity.Property(e => e.Time).IsUnicode(false);

                entity.Property(e => e.TripEnd).IsUnicode(false);

                entity.Property(e => e.TripStart).IsUnicode(false);

                entity.Property(e => e.Tripid).IsUnicode(false);
            });

            modelBuilder.Entity<DisTripDataV>(entity =>
            {
                entity.ToView("DIS_TRIP_DATA_V");

                entity.Property(e => e.Carregnno).IsUnicode(false);

                entity.Property(e => e.Channel).IsUnicode(false);

                entity.Property(e => e.Droplocation).IsUnicode(false);

                entity.Property(e => e.Paymenttype).IsUnicode(false);

                entity.Property(e => e.Pickuplocation).IsUnicode(false);

                entity.Property(e => e.Status).IsUnicode(false);

                entity.Property(e => e.Tripid).IsUnicode(false);
            });

            modelBuilder.Entity<DisTripSubscriptionV>(entity =>
            {
                entity.ToView("DIS_TRIP_SUBSCRIPTION_V");

                entity.Property(e => e.BrandCode).IsUnicode(false);

                entity.Property(e => e.Carregnno).IsUnicode(false);

                entity.Property(e => e.CityCode).IsUnicode(false);

                entity.Property(e => e.LeCode).IsUnicode(false);

                entity.Property(e => e.ModelCode).IsUnicode(false);

                entity.Property(e => e.Spid).IsUnicode(false);

                entity.Property(e => e.Tripid).IsUnicode(false);

                entity.Property(e => e.TxnClass).IsUnicode(false);

                entity.Property(e => e.TxnStatusCode).IsUnicode(false);

                entity.Property(e => e.TxnType).IsUnicode(false);
            });

            modelBuilder.Entity<Disapimaster>(entity =>
            {
                entity.HasKey(e => e.Guid)
                    .HasName("SYS_C0010838");

                entity.Property(e => e.Guid).IsUnicode(false);

                entity.Property(e => e.Description).IsUnicode(false);

                entity.Property(e => e.Disabled)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(0) ")
                    .IsFixedLength(true);

                entity.Property(e => e.Name).IsUnicode(false);

                entity.Property(e => e.Objectversionno).IsUnicode(false);

                entity.Property(e => e.Pkguid).IsUnicode(false);

                entity.Property(e => e.Quickaccesscode).IsUnicode(false);

                entity.Property(e => e.Usercreated).IsUnicode(false);

                entity.Property(e => e.Userdeleted).IsUnicode(false);

                entity.Property(e => e.Userupdated).IsUnicode(false);
            });

            modelBuilder.Entity<Disapimessagemaster>(entity =>
            {
                entity.Property(e => e.Apimasterguid).IsUnicode(false);

                entity.Property(e => e.Disabled)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(0) ")
                    .IsFixedLength(true);

                entity.Property(e => e.Guid).IsUnicode(false);

                entity.Property(e => e.Message).IsUnicode(false);

                entity.Property(e => e.Messagenumber).IsUnicode(false);

                entity.Property(e => e.Objectversionno).IsUnicode(false);

                entity.Property(e => e.Pkguid).IsUnicode(false);

                entity.Property(e => e.Status).IsUnicode(false);

                entity.Property(e => e.Statuscode).IsUnicode(false);

                entity.Property(e => e.Usercreated).IsUnicode(false);

                entity.Property(e => e.Userdeleted).IsUnicode(false);

                entity.Property(e => e.Userupdated).IsUnicode(false);

                entity.HasOne(d => d.Apimastergu)
                    .WithMany()
                    .HasForeignKey(d => d.Apimasterguid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("MSG_FK");
            });

            modelBuilder.Entity<DispAllActiveCarsV>(entity =>
            {
                entity.ToView("DISP_ALL_ACTIVE_CARS_V");

                entity.Property(e => e.Brand).IsUnicode(false);

                entity.Property(e => e.BrandName).IsUnicode(false);

                entity.Property(e => e.Businesscategory).IsUnicode(false);

                entity.Property(e => e.Carmasterguid).IsUnicode(false);

                entity.Property(e => e.Carno).IsUnicode(false);

                entity.Property(e => e.CityName).IsUnicode(false);

                entity.Property(e => e.Color).IsUnicode(false);

                entity.Property(e => e.Contactno).IsUnicode(false);

                entity.Property(e => e.Gender).IsUnicode(false);

                entity.Property(e => e.LeName).IsUnicode(false);

                entity.Property(e => e.Manthanbrandid).HasPrecision(3);

                entity.Property(e => e.Manthanbusinesscategoryid).HasPrecision(10);

                entity.Property(e => e.Manthancityid).HasPrecision(3);

                entity.Property(e => e.Model).IsUnicode(false);

                entity.Property(e => e.ModelName).IsUnicode(false);

                entity.Property(e => e.Name).IsUnicode(false);

                entity.Property(e => e.Ownershiptype).IsUnicode(false);

                entity.Property(e => e.Personid).IsUnicode(false);

                entity.Property(e => e.Personrole).IsUnicode(false);

                entity.Property(e => e.Shiftfromtime).IsUnicode(false);

                entity.Property(e => e.Shifttotime).IsUnicode(false);

                entity.Property(e => e.Sppersonmasterguid).IsUnicode(false);
            });

            modelBuilder.Entity<DispAllActiveCarsV1>(entity =>
            {
                entity.ToView("DISP_ALL_ACTIVE_CARS_V1");

                entity.Property(e => e.Carmasterguid).IsUnicode(false);

                entity.Property(e => e.Carno).IsUnicode(false);

                entity.Property(e => e.Manthanbrandid).HasPrecision(3);

                entity.Property(e => e.Manthancityid).HasPrecision(3);

                entity.Property(e => e.ModelName).IsUnicode(false);

                entity.Property(e => e.Ownershiptype).IsUnicode(false);
            });

            modelBuilder.Entity<DispAllCarDriverV>(entity =>
            {
                entity.ToView("DISP_ALL_CAR_DRIVER_V");

                entity.Property(e => e.Brand).IsUnicode(false);

                entity.Property(e => e.BrandName).IsUnicode(false);

                entity.Property(e => e.Carmasterguid).IsUnicode(false);

                entity.Property(e => e.Carno).IsUnicode(false);

                entity.Property(e => e.CityName).IsUnicode(false);

                entity.Property(e => e.Contactno).IsUnicode(false);

                entity.Property(e => e.Driverid).IsUnicode(false);

                entity.Property(e => e.LeName).IsUnicode(false);

                entity.Property(e => e.Manthanbrandid).HasPrecision(3);

                entity.Property(e => e.Manthancityid).HasPrecision(3);

                entity.Property(e => e.Model).IsUnicode(false);

                entity.Property(e => e.ModelName).IsUnicode(false);

                entity.Property(e => e.Name).IsUnicode(false);

                entity.Property(e => e.Ownershiptype).IsUnicode(false);

                entity.Property(e => e.Personrole).IsUnicode(false);

                entity.Property(e => e.Spid).IsUnicode(false);

                entity.Property(e => e.Spname).IsUnicode(false);
            });

            modelBuilder.Entity<DispatchAuthTbl>(entity =>
            {
                entity.HasKey(e => e.Guid)
                    .HasName("DISPATCH_AUTH_GUID_PK");

                entity.Property(e => e.Guid).IsUnicode(false);

                entity.Property(e => e.Attribute1).IsUnicode(false);

                entity.Property(e => e.Attribute2).IsUnicode(false);

                entity.Property(e => e.Attribute3).IsUnicode(false);

                entity.Property(e => e.Attribute4).IsUnicode(false);

                entity.Property(e => e.Attribute5).IsUnicode(false);

                entity.Property(e => e.Hwdeviceid).IsUnicode(false);

                entity.Property(e => e.Pkguid).IsUnicode(false);

                entity.Property(e => e.Usercreated).IsUnicode(false);

                entity.Property(e => e.Userdeleted).IsUnicode(false);

                entity.Property(e => e.Userupdated).IsUnicode(false);
            });

            modelBuilder.Entity<DispatchFcmTokenTbl>(entity =>
            {
                entity.HasKey(e => e.Guid)
                    .HasName("DISPFCMTKNTBL_PK");

                entity.Property(e => e.Guid).IsUnicode(false);

                entity.Property(e => e.Auth).IsUnicode(false);

                entity.Property(e => e.Fcmtoken).IsUnicode(false);

                entity.Property(e => e.Hwdeviceid).IsUnicode(false);

                entity.Property(e => e.Mobileno).IsUnicode(false);

                entity.Property(e => e.Usercreated).IsUnicode(false);

                entity.Property(e => e.Userupdated).IsUnicode(false);
            });

            modelBuilder.Entity<DispatchFcmtknMessage>(entity =>
            {
                entity.HasKey(e => e.Guid)
                    .HasName("DISPFCMTKNMSG_PK");

                entity.Property(e => e.Guid).IsUnicode(false);

                entity.Property(e => e.Fcmtoken).IsUnicode(false);

                entity.Property(e => e.Hwdeviceid).IsUnicode(false);

                entity.Property(e => e.Message).IsUnicode(false);

                entity.Property(e => e.Mobileno).IsUnicode(false);

                entity.Property(e => e.Pragatideviceid).IsUnicode(false);

                entity.Property(e => e.Serverresponse).IsUnicode(false);

                entity.Property(e => e.Status).IsUnicode(false);
            });

            modelBuilder.Entity<DispatchOtpTbl>(entity =>
            {
                entity.HasKey(e => e.Guid)
                    .HasName("DISP_OTP_MOB_PK");

                entity.Property(e => e.Guid).IsUnicode(false);

                entity.Property(e => e.Attribute1).IsUnicode(false);

                entity.Property(e => e.Attribute2).IsUnicode(false);

                entity.Property(e => e.Attribute3).IsUnicode(false);

                entity.Property(e => e.Attribute4).IsUnicode(false);

                entity.Property(e => e.Attribute5).IsUnicode(false);

                entity.Property(e => e.Pkguid).IsUnicode(false);

                entity.Property(e => e.Usercreated).IsUnicode(false);

                entity.Property(e => e.Userdeleted).IsUnicode(false);

                entity.Property(e => e.Userupdated).IsUnicode(false);
            });

            modelBuilder.Entity<DobConfigTbl>(entity =>
            {
                entity.HasKey(e => e.Guid)
                    .HasName("SALE__CONFIG_PK");

                entity.Property(e => e.Guid).IsUnicode(false);

                entity.Property(e => e.Citycode).IsUnicode(false);

                entity.Property(e => e.Driversms1stline).IsUnicode(false);

                entity.Property(e => e.Driversms2ndline).IsUnicode(false);

                entity.Property(e => e.Driversms3rdline).IsUnicode(false);

                entity.Property(e => e.Driversms4rtline).IsUnicode(false);

                entity.Property(e => e.Driversms5thline).IsUnicode(false);

                entity.Property(e => e.Driversms6thline).IsUnicode(false);

                entity.Property(e => e.Driversms7thline).IsUnicode(false);

                entity.Property(e => e.Driversms8thline).IsUnicode(false);

                entity.Property(e => e.PersonId).HasPrecision(10);

                entity.Property(e => e.Securitycombinationguid).IsUnicode(false);

                entity.Property(e => e.Spsms1stline).IsUnicode(false);

                entity.Property(e => e.Spsms2ndline).IsUnicode(false);

                entity.Property(e => e.Spsms3rdline).IsUnicode(false);

                entity.Property(e => e.Spsms4rtline).IsUnicode(false);

                entity.Property(e => e.Spsms5thline).IsUnicode(false);

                entity.Property(e => e.Spsms6thline).IsUnicode(false);

                entity.Property(e => e.Spsms7thline).IsUnicode(false);

                entity.Property(e => e.Spsms8thline).IsUnicode(false);

                entity.Property(e => e.Spsms9thline).IsUnicode(false);

                entity.Property(e => e.Usercreated).IsUnicode(false);

                entity.Property(e => e.Userupdated).IsUnicode(false);
            });

            modelBuilder.Entity<DobDocBrandMapping>(entity =>
            {
                entity.HasKey(e => e.Guid)
                    .HasName("DOB_DOC_BRAND_MAPPING_PK11");

                entity.Property(e => e.Guid)
                    .IsUnicode(false)
                    .HasDefaultValueSql("SYS_GUID() ");

                entity.Property(e => e.Branchmasterguid).IsUnicode(false);

                entity.Property(e => e.Brandmasterguid).IsUnicode(false);

                entity.Property(e => e.Businesscategorymasterguid).IsUnicode(false);

                entity.Property(e => e.Category).IsUnicode(false);

                entity.Property(e => e.Documenttypeentityguid).IsUnicode(false);

                entity.Property(e => e.Entity).IsUnicode(false);

                entity.Property(e => e.Ismandatory).IsUnicode(false);

                entity.HasOne(d => d.Brandmastergu)
                    .WithMany(p => p.DobDocBrandMappings)
                    .HasForeignKey(d => d.Brandmasterguid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("DOB_DOC_BRAND_MAPPING11_FK1");

                entity.HasOne(d => d.Documenttypeentitygu)
                    .WithMany(p => p.DobDocBrandMappings)
                    .HasForeignKey(d => d.Documenttypeentityguid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("DOB_DOC_BRAND_MAPPING11_FK2");
            });

            modelBuilder.Entity<DobDocBrandMapping22>(entity =>
            {
                entity.HasKey(e => e.Guid)
                    .HasName("DOB_DOC_BRAND_MAPPING_PK");

                entity.Property(e => e.Guid)
                    .IsUnicode(false)
                    .HasDefaultValueSql("SYS_GUID() ");

                entity.Property(e => e.Branchmasterguid).IsUnicode(false);

                entity.Property(e => e.Brandmasterguid).IsUnicode(false);

                entity.Property(e => e.Businesscategorymasterguid).IsUnicode(false);

                entity.Property(e => e.Category).IsUnicode(false);

                entity.Property(e => e.Documenttypeentityguid).IsUnicode(false);

                entity.Property(e => e.Entity).IsUnicode(false);

                entity.Property(e => e.Ismandatory).IsUnicode(false);

                entity.HasOne(d => d.Brandmastergu)
                    .WithMany(p => p.DobDocBrandMapping22s)
                    .HasForeignKey(d => d.Brandmasterguid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("DOB_DOC_BRAND_MAPPING_FK1");

                entity.HasOne(d => d.Documenttypeentitygu)
                    .WithMany(p => p.DobDocBrandMapping22s)
                    .HasForeignKey(d => d.Documenttypeentityguid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("DOB_DOC_BRAND_MAPPING_FK2");
            });

            modelBuilder.Entity<DobDocPlaceholder>(entity =>
            {
                entity.HasKey(e => e.Guid)
                    .HasName("DOB_DOC_PLACEHOLDER_PK");

                entity.Property(e => e.Guid).IsUnicode(false);

                entity.Property(e => e.Controlid).IsUnicode(false);

                entity.Property(e => e.Controltype).IsUnicode(false);

                entity.Property(e => e.Documenttypeentityguid).IsUnicode(false);

                entity.Property(e => e.Placeholder).IsUnicode(false);

                entity.Property(e => e.Posttextdbfield).IsUnicode(false);

                entity.Property(e => e.Pretext).IsUnicode(false);

                entity.Property(e => e.Required).IsUnicode(false);

                entity.Property(e => e.Value).IsUnicode(false);
            });

            modelBuilder.Entity<DobDocPlaceholderV3>(entity =>
            {
                entity.HasKey(e => e.Guid)
                    .HasName("SYS_C00231531");

                entity.Property(e => e.Guid).IsUnicode(false);

                entity.Property(e => e.Controlid).IsUnicode(false);

                entity.Property(e => e.Controltype).IsUnicode(false);

                entity.Property(e => e.Documenttypeentityguid).IsUnicode(false);

                entity.Property(e => e.Isdisabled)
                    .HasPrecision(1)
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Placeholder).IsUnicode(false);

                entity.Property(e => e.Posttextdbfield).IsUnicode(false);

                entity.Property(e => e.Pretext).IsUnicode(false);

                entity.Property(e => e.Required).IsUnicode(false);

                entity.Property(e => e.Value).IsUnicode(false);
            });

            modelBuilder.Entity<DobDocSubtypeTbl>(entity =>
            {
                entity.Property(e => e.Documenttypeentityguid).IsUnicode(false);

                entity.Property(e => e.Name).IsUnicode(false);
            });

            modelBuilder.Entity<DobDocumentV>(entity =>
            {
                entity.ToView("DOB_DOCUMENT_V");

                entity.Property(e => e.Category).IsUnicode(false);

                entity.Property(e => e.Documenttypeentityguid).IsUnicode(false);

                entity.Property(e => e.Documenttypemastername).IsUnicode(false);

                entity.Property(e => e.Entity).IsUnicode(false);
            });

            modelBuilder.Entity<DobMandatoryDocTbl>(entity =>
            {
                entity.HasKey(e => e.Guid)
                    .HasName("DOB_MANDATORY_DOC_TBL_PK");

                entity.Property(e => e.Guid).IsUnicode(false);

                entity.Property(e => e.Displayname).IsUnicode(false);

                entity.Property(e => e.Documenttypeentityguid).IsUnicode(false);

                entity.Property(e => e.Documenttypemastername).IsUnicode(false);

                entity.Property(e => e.Quickaccesscode).IsUnicode(false);

                entity.Property(e => e.Remarks).IsUnicode(false);

                entity.Property(e => e.Shortname).IsUnicode(false);

                entity.HasOne(d => d.Documenttypeentitygu)
                    .WithMany(p => p.DobMandatoryDocTbls)
                    .HasForeignKey(d => d.Documenttypeentityguid)
                    .HasConstraintName("DOCUMENTTYPEENTITYGUID_FK");
            });

            modelBuilder.Entity<DobMandatoryDocTblV2>(entity =>
            {
                entity.HasKey(e => e.Guid)
                    .HasName("DOB_MANDATORY_DOC_TBL_V2_PK");

                entity.Property(e => e.Guid).IsUnicode(false);

                entity.Property(e => e.Displayname).IsUnicode(false);

                entity.Property(e => e.Documenttypeentityguid).IsUnicode(false);

                entity.Property(e => e.Documenttypemastername).IsUnicode(false);

                entity.Property(e => e.Entity).IsUnicode(false);

                entity.Property(e => e.Ismandatory).HasPrecision(1);

                entity.Property(e => e.Message).IsUnicode(false);

                entity.Property(e => e.Quickaccesscode).IsUnicode(false);

                entity.Property(e => e.Shortname).IsUnicode(false);
            });

            modelBuilder.Entity<Dobapimaster>(entity =>
            {
                entity.HasKey(e => e.Guid)
                    .HasName("SYS_C0010837");

                entity.Property(e => e.Guid).IsUnicode(false);

                entity.Property(e => e.Description).IsUnicode(false);

                entity.Property(e => e.Disabled)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(0) ")
                    .IsFixedLength(true);

                entity.Property(e => e.Name).IsUnicode(false);

                entity.Property(e => e.Objectversionno).IsUnicode(false);

                entity.Property(e => e.Pkguid).IsUnicode(false);

                entity.Property(e => e.Quickaccesscode).IsUnicode(false);

                entity.Property(e => e.Usercreated).IsUnicode(false);

                entity.Property(e => e.Userdeleted).IsUnicode(false);

                entity.Property(e => e.Userupdated).IsUnicode(false);
            });

            modelBuilder.Entity<DocAction>(entity =>
            {
                entity.Property(e => e.ActionCode).IsUnicode(false);

                entity.Property(e => e.CarRegnNo).IsUnicode(false);

                entity.Property(e => e.Carguid).IsUnicode(false);

                entity.Property(e => e.Documentcode).IsUnicode(false);

                entity.Property(e => e.Documentguid).IsUnicode(false);

                entity.Property(e => e.Documenttype).IsUnicode(false);

                entity.Property(e => e.Guid).IsUnicode(false);

                entity.Property(e => e.Personguid).IsUnicode(false);

                entity.Property(e => e.Personid).IsUnicode(false);

                entity.Property(e => e.Smsstatus).IsUnicode(false);
            });

            modelBuilder.Entity<DocActionType>(entity =>
            {
                entity.Property(e => e.Description).IsUnicode(false);

                entity.Property(e => e.Name).IsUnicode(false);

                entity.Property(e => e.Quickaccesscode).IsUnicode(false);
            });

            modelBuilder.Entity<DocActionV>(entity =>
            {
                entity.ToView("DOC_ACTION_V");

                entity.Property(e => e.ActionCode).IsUnicode(false);

                entity.Property(e => e.ActionDescription).IsUnicode(false);

                entity.Property(e => e.ActionName).IsUnicode(false);

                entity.Property(e => e.DocActionPkguid).IsUnicode(false);

                entity.Property(e => e.DocGuid).IsUnicode(false);

                entity.Property(e => e.DocType).IsUnicode(false);
            });

            modelBuilder.Entity<DocBaseV>(entity =>
            {
                entity.ToView("DOC_BASE_V");

                entity.Property(e => e.DocTypeEnComments).IsUnicode(false);

                entity.Property(e => e.DocTypeEnDescription).IsUnicode(false);

                entity.Property(e => e.DocTypeEnDisabled).HasPrecision(1);

                entity.Property(e => e.DocTypeEnGuid).IsUnicode(false);

                entity.Property(e => e.DocTypeEnObjectversionno).HasPrecision(10);

                entity.Property(e => e.DocTypeEnOracleentityid).IsUnicode(false);

                entity.Property(e => e.DocTypeEnOracleentityname).IsUnicode(false);

                entity.Property(e => e.DocTypeEnPkguid).IsUnicode(false);

                entity.Property(e => e.DocTypeEnQuickaccesscode).IsUnicode(false);

                entity.Property(e => e.DocTypeMComments).IsUnicode(false);

                entity.Property(e => e.DocTypeMDescription).IsUnicode(false);

                entity.Property(e => e.DocTypeMDisabled).HasPrecision(1);

                entity.Property(e => e.DocTypeMName).IsUnicode(false);

                entity.Property(e => e.DocTypeMObjectversionno).HasPrecision(10);

                entity.Property(e => e.DocTypeMOracleentityid).IsUnicode(false);

                entity.Property(e => e.DocTypeMOracleentityname).IsUnicode(false);

                entity.Property(e => e.DocTypeMPkguid).IsUnicode(false);

                entity.Property(e => e.DocTypeMQuickaccesscode).IsUnicode(false);

                entity.Property(e => e.DocTypeMRegularexpression).IsUnicode(false);

                entity.Property(e => e.Documenttypemasterguid).IsUnicode(false);

                entity.Property(e => e.EnTypeComments).IsUnicode(false);

                entity.Property(e => e.EnTypeDescription).IsUnicode(false);

                entity.Property(e => e.EnTypeDisabled).HasPrecision(1);

                entity.Property(e => e.EnTypeName).IsUnicode(false);

                entity.Property(e => e.EnTypeObjectversionno).HasPrecision(10);

                entity.Property(e => e.EnTypeOracleentityid).IsUnicode(false);

                entity.Property(e => e.EnTypeOracleentityname).IsUnicode(false);

                entity.Property(e => e.EnTypePkguid).IsUnicode(false);

                entity.Property(e => e.EnTypeQuickaccesscode).IsUnicode(false);

                entity.Property(e => e.Entitymasterguid).IsUnicode(false);

                entity.Property(e => e.Escalationdays).HasPrecision(10);

                entity.Property(e => e.Renewaldays).HasPrecision(10);
            });

            modelBuilder.Entity<DocEntV>(entity =>
            {
                entity.ToView("DOC_ENT_V");

                entity.Property(e => e.Documenttypeentityguid).IsUnicode(false);

                entity.Property(e => e.Documenttypemastername).IsUnicode(false);

                entity.Property(e => e.Quickaccesscode).IsUnicode(false);
            });

            modelBuilder.Entity<DocTypCatEntV>(entity =>
            {
                entity.ToView("DOC_TYP_CAT_ENT_V");

                entity.Property(e => e.Documentcategorymasterguid).IsUnicode(false);

                entity.Property(e => e.Documenttypecategoryguid).IsUnicode(false);

                entity.Property(e => e.Documenttypeentityguid).IsUnicode(false);
            });

            modelBuilder.Entity<DocV>(entity =>
            {
                entity.ToView("DOC_V");

                entity.Property(e => e.DocTypeEnComments).IsUnicode(false);

                entity.Property(e => e.DocTypeEnDescription).IsUnicode(false);

                entity.Property(e => e.DocTypeEnDisabled).HasPrecision(1);

                entity.Property(e => e.DocTypeEnGuid).IsUnicode(false);

                entity.Property(e => e.DocTypeEnObjectversionno).HasPrecision(10);

                entity.Property(e => e.DocTypeEnOracleentityid).IsUnicode(false);

                entity.Property(e => e.DocTypeEnOracleentityname).IsUnicode(false);

                entity.Property(e => e.DocTypeEnPkguid).IsUnicode(false);

                entity.Property(e => e.DocTypeEnQuickaccesscode).IsUnicode(false);

                entity.Property(e => e.DocTypeMComments).IsUnicode(false);

                entity.Property(e => e.DocTypeMDescription).IsUnicode(false);

                entity.Property(e => e.DocTypeMDisabled).HasPrecision(1);

                entity.Property(e => e.DocTypeMName).IsUnicode(false);

                entity.Property(e => e.DocTypeMObjectversionno).HasPrecision(10);

                entity.Property(e => e.DocTypeMOracleentityid).IsUnicode(false);

                entity.Property(e => e.DocTypeMOracleentityname).IsUnicode(false);

                entity.Property(e => e.DocTypeMPkguid).IsUnicode(false);

                entity.Property(e => e.DocTypeMQuickaccesscode).IsUnicode(false);

                entity.Property(e => e.DocTypeMRegularexpression).IsUnicode(false);

                entity.Property(e => e.Documenttypemasterguid).IsUnicode(false);

                entity.Property(e => e.EnTypeComments).IsUnicode(false);

                entity.Property(e => e.EnTypeDescription).IsUnicode(false);

                entity.Property(e => e.EnTypeDisabled).HasPrecision(1);

                entity.Property(e => e.EnTypeName).IsUnicode(false);

                entity.Property(e => e.EnTypeObjectversionno).HasPrecision(10);

                entity.Property(e => e.EnTypeOracleentityid).IsUnicode(false);

                entity.Property(e => e.EnTypeOracleentityname).IsUnicode(false);

                entity.Property(e => e.EnTypePkguid).IsUnicode(false);

                entity.Property(e => e.EnTypeQuickaccesscode).IsUnicode(false);

                entity.Property(e => e.Entitymasterguid).IsUnicode(false);

                entity.Property(e => e.Escalationdays).HasPrecision(10);

                entity.Property(e => e.Renewaldays).HasPrecision(10);
            });

            modelBuilder.Entity<Documentcategorymaster>(entity =>
            {
                entity.Property(e => e.Comments).IsUnicode(false);

                entity.Property(e => e.Description).IsUnicode(false);

                entity.Property(e => e.Disabled).HasPrecision(1);

                entity.Property(e => e.Guid).IsUnicode(false);

                entity.Property(e => e.Name).IsUnicode(false);

                entity.Property(e => e.Objectversionno).HasPrecision(10);

                entity.Property(e => e.Oracleentityid).IsUnicode(false);

                entity.Property(e => e.Oracleentityname).IsUnicode(false);

                entity.Property(e => e.Pkguid).IsUnicode(false);

                entity.Property(e => e.Quickaccesscode).IsUnicode(false);

                entity.Property(e => e.Userarchived).IsUnicode(false);

                entity.Property(e => e.Usercreated).IsUnicode(false);

                entity.Property(e => e.Userdeleted).IsUnicode(false);

                entity.Property(e => e.Userupdated).IsUnicode(false);
            });

            modelBuilder.Entity<Documentlockrule>(entity =>
            {
                entity.Property(e => e.BrandGuid).IsUnicode(false);

                entity.Property(e => e.Businesscategorymasterguid).IsUnicode(false);

                entity.Property(e => e.EnabledFlag).IsUnicode(false);

                entity.Property(e => e.Entity).IsUnicode(false);

                entity.Property(e => e.LebranchGuid).IsUnicode(false);

                entity.Property(e => e.Lockruleflag).IsUnicode(false);

                entity.Property(e => e.ModelGuid).IsUnicode(false);

                entity.Property(e => e.Quickaccesscode).IsUnicode(false);

                entity.Property(e => e.RuleName).IsUnicode(false);

                entity.Property(e => e.RuleOldName).IsUnicode(false);

                entity.Property(e => e.SecurityGuid).IsUnicode(false);

                entity.Property(e => e.ViewCol).IsUnicode(false);

                entity.Property(e => e.ViewName).IsUnicode(false);
            });

            modelBuilder.Entity<Documenttypecategory>(entity =>
            {
                entity.Property(e => e.Disabled).HasPrecision(1);

                entity.Property(e => e.Documentcategorymasterguid).IsUnicode(false);

                entity.Property(e => e.Documenttypemasterguid).IsUnicode(false);

                entity.Property(e => e.Guid).IsUnicode(false);

                entity.Property(e => e.Objectversionno).HasPrecision(10);

                entity.Property(e => e.Oracleentityid).IsUnicode(false);

                entity.Property(e => e.Oracleentityname).IsUnicode(false);

                entity.Property(e => e.Pkguid).IsUnicode(false);

                entity.Property(e => e.Quickaccesscode).IsUnicode(false);

                entity.Property(e => e.Userarchived).IsUnicode(false);

                entity.Property(e => e.Usercreated).IsUnicode(false);

                entity.Property(e => e.Userdeleted).IsUnicode(false);

                entity.Property(e => e.Userupdated).IsUnicode(false);
            });

            modelBuilder.Entity<Documenttypeentity>(entity =>
            {
                entity.HasKey(e => e.Guid)
                    .HasName("DOCUMENTTYPEENTITY_PK");

                entity.Property(e => e.Guid).IsUnicode(false);

                entity.Property(e => e.Comments).IsUnicode(false);

                entity.Property(e => e.Description).IsUnicode(false);

                entity.Property(e => e.Disabled).HasPrecision(1);

                entity.Property(e => e.Documenttypemasterguid).IsUnicode(false);

                entity.Property(e => e.Entitymasterguid).IsUnicode(false);

                entity.Property(e => e.Objectversionno).HasPrecision(10);

                entity.Property(e => e.Oracleentityid).IsUnicode(false);

                entity.Property(e => e.Oracleentityname).IsUnicode(false);

                entity.Property(e => e.Pkguid).IsUnicode(false);

                entity.Property(e => e.Quickaccesscode).IsUnicode(false);

                entity.Property(e => e.Userarchived).IsUnicode(false);

                entity.Property(e => e.Usercreated).IsUnicode(false);

                entity.Property(e => e.Userdeleted).IsUnicode(false);

                entity.Property(e => e.Userupdated).IsUnicode(false);
            });

            modelBuilder.Entity<Documenttypemaster>(entity =>
            {
                entity.Property(e => e.Comments).IsUnicode(false);

                entity.Property(e => e.Description).IsUnicode(false);

                entity.Property(e => e.Disabled).HasPrecision(1);

                entity.Property(e => e.Escalationdays).HasPrecision(10);

                entity.Property(e => e.Guid).IsUnicode(false);

                entity.Property(e => e.Name).IsUnicode(false);

                entity.Property(e => e.Objectversionno).HasPrecision(10);

                entity.Property(e => e.Oracleentityid).IsUnicode(false);

                entity.Property(e => e.Oracleentityname).IsUnicode(false);

                entity.Property(e => e.Pkguid).IsUnicode(false);

                entity.Property(e => e.Quickaccesscode).IsUnicode(false);

                entity.Property(e => e.Regularexpression).IsUnicode(false);

                entity.Property(e => e.Renewaldays).HasPrecision(10);

                entity.Property(e => e.Userarchived).IsUnicode(false);

                entity.Property(e => e.Usercreated).IsUnicode(false);

                entity.Property(e => e.Userdeleted).IsUnicode(false);

                entity.Property(e => e.Userupdated).IsUnicode(false);
            });

            modelBuilder.Entity<Documenttypepurpose>(entity =>
            {
                entity.Property(e => e.Description).IsUnicode(false);

                entity.Property(e => e.Disabled).HasPrecision(1);

                entity.Property(e => e.Guid).IsUnicode(false);

                entity.Property(e => e.Name).IsUnicode(false);

                entity.Property(e => e.Objectversionno).HasPrecision(10);

                entity.Property(e => e.Oracleentityid).IsUnicode(false);

                entity.Property(e => e.Oracleentityname).IsUnicode(false);

                entity.Property(e => e.Pkguid).IsUnicode(false);

                entity.Property(e => e.Quickaccesscode).IsUnicode(false);

                entity.Property(e => e.Userarchived).IsUnicode(false);

                entity.Property(e => e.Usercreated).IsUnicode(false);

                entity.Property(e => e.Userdeleted).IsUnicode(false);

                entity.Property(e => e.Userupdated).IsUnicode(false);
            });

            modelBuilder.Entity<DriverBaseV>(entity =>
            {
                entity.ToView("DRIVER_BASE_V");

                entity.Property(e => e.ContactNo).IsUnicode(false);

                entity.Property(e => e.DriverBioid).IsUnicode(false);

                entity.Property(e => e.DriverFname).IsUnicode(false);

                entity.Property(e => e.DriverLname).IsUnicode(false);

                entity.Property(e => e.DriverMname).IsUnicode(false);

                entity.Property(e => e.DriverObjVerNo).HasPrecision(10);

                entity.Property(e => e.DriverReadyflag).IsUnicode(false);

                entity.Property(e => e.DriverStatus).IsUnicode(false);

                entity.Property(e => e.Driverflag).HasPrecision(1);

                entity.Property(e => e.Driverid).IsUnicode(false);

                entity.Property(e => e.Dseflag).HasPrecision(1);

                entity.Property(e => e.Guid).IsUnicode(false);

                entity.Property(e => e.Issendtomonroe).HasPrecision(5);

                entity.Property(e => e.PersStatus).IsUnicode(false);

                entity.Property(e => e.Personguid).IsUnicode(false);

                entity.Property(e => e.SpBioid).IsUnicode(false);

                entity.Property(e => e.SpFname).IsUnicode(false);

                entity.Property(e => e.SpLname).IsUnicode(false);

                entity.Property(e => e.SpMname).IsUnicode(false);

                entity.Property(e => e.SpStatus).IsUnicode(false);

                entity.Property(e => e.Spflag).HasPrecision(1);

                entity.Property(e => e.Spguid).IsUnicode(false);

                entity.Property(e => e.Spid).IsUnicode(false);
            });

            modelBuilder.Entity<DriverDetailsV>(entity =>
            {
                entity.ToView("DRIVER_DETAILS_V");

                entity.Property(e => e.Addressline1).IsUnicode(false);

                entity.Property(e => e.Addressline2).IsUnicode(false);

                entity.Property(e => e.City).IsUnicode(false);

                entity.Property(e => e.Contactno).IsUnicode(false);

                entity.Property(e => e.Driverid).IsUnicode(false);

                entity.Property(e => e.LeName).IsUnicode(false);

                entity.Property(e => e.Model).IsUnicode(false);

                entity.Property(e => e.Name).IsUnicode(false);

                entity.Property(e => e.Personmasterguid).IsUnicode(false);

                entity.Property(e => e.Pincode).IsUnicode(false);

                entity.Property(e => e.State).IsUnicode(false);
            });

            modelBuilder.Entity<DriverManthan>(entity =>
            {
                entity.Property(e => e.Addresserror).IsUnicode(false);

                entity.Property(e => e.Addressproofpath).IsUnicode(false);

                entity.Property(e => e.Addressstatus).IsUnicode(false);

                entity.Property(e => e.Ageerror).IsUnicode(false);

                entity.Property(e => e.Ageproofpath).IsUnicode(false);

                entity.Property(e => e.Agestatus).IsUnicode(false);

                entity.Property(e => e.Associatedriverid).HasPrecision(8);

                entity.Property(e => e.Bedgeerror).IsUnicode(false);

                entity.Property(e => e.Bedgeno).IsUnicode(false);

                entity.Property(e => e.Bedgepath).IsUnicode(false);

                entity.Property(e => e.Bedgestatus).IsUnicode(false);

                entity.Property(e => e.Driverid).IsUnicode(false);

                entity.Property(e => e.Drivingerror).IsUnicode(false);

                entity.Property(e => e.Drivinglicenseno).IsUnicode(false);

                entity.Property(e => e.Drivinglicensepath).IsUnicode(false);

                entity.Property(e => e.Drivingstatus).IsUnicode(false);

                entity.Property(e => e.Isdeleted).HasPrecision(1);

                entity.Property(e => e.Lastupdatedby).HasPrecision(4);

                entity.Property(e => e.Medicaltest).IsUnicode(false);

                entity.Property(e => e.Pan).IsUnicode(false);

                entity.Property(e => e.Panerror).IsUnicode(false);

                entity.Property(e => e.Panpath).IsUnicode(false);

                entity.Property(e => e.Panstatus).IsUnicode(false);

                entity.Property(e => e.Photoiderror).IsUnicode(false);

                entity.Property(e => e.Photoidproofpath).IsUnicode(false);

                entity.Property(e => e.Photoidstatus).IsUnicode(false);

                entity.Property(e => e.Policeerror).IsUnicode(false);

                entity.Property(e => e.Policestatus).IsUnicode(false);

                entity.Property(e => e.Policevarificationpath).IsUnicode(false);

                entity.Property(e => e.Policeverification).IsUnicode(false);

                entity.Property(e => e.Recorder).HasPrecision(4);

                entity.Property(e => e.SeqId).HasPrecision(4);

                entity.Property(e => e.Status).IsUnicode(false);

                entity.Property(e => e.Subscriberid).HasPrecision(8);

                entity.Property(e => e.Verificationid).HasPrecision(8);

                entity.Property(e => e.Verifiedproof).IsUnicode(false);
            });

            modelBuilder.Entity<DriverTrainingV>(entity =>
            {
                entity.ToView("DRIVER_TRAINING_V");

                entity.Property(e => e.Attendeetype).IsUnicode(false);

                entity.Property(e => e.Attendeobjectversionno).HasPrecision(10);

                entity.Property(e => e.Attendeoracleentityid).IsUnicode(false);

                entity.Property(e => e.Attendeoracleentityname).IsUnicode(false);

                entity.Property(e => e.Batchdisabled).HasPrecision(1);

                entity.Property(e => e.Batchobjectversionno).HasPrecision(10);

                entity.Property(e => e.Batchoracleentityid).IsUnicode(false);

                entity.Property(e => e.Batchoracleentityname).IsUnicode(false);

                entity.Property(e => e.Batchpkguid).IsUnicode(false);

                entity.Property(e => e.EntityCode).IsUnicode(false);

                entity.Property(e => e.Isattended).IsUnicode(false);

                entity.Property(e => e.Obtainedmarks).IsUnicode(false);

                entity.Property(e => e.PersBioid).IsUnicode(false);

                entity.Property(e => e.PersDriverflag).HasPrecision(1);

                entity.Property(e => e.PersDseflag).HasPrecision(1);

                entity.Property(e => e.PersFname).IsUnicode(false);

                entity.Property(e => e.PersGender).IsUnicode(false);

                entity.Property(e => e.PersLname).IsUnicode(false);

                entity.Property(e => e.PersMname).IsUnicode(false);

                entity.Property(e => e.PersObjVerNo).HasPrecision(10);

                entity.Property(e => e.PersSpflag).HasPrecision(1);

                entity.Property(e => e.PersStatusCode).IsUnicode(false);

                entity.Property(e => e.PersTitle).IsUnicode(false);

                entity.Property(e => e.Personid).IsUnicode(false);

                entity.Property(e => e.Personmasterguid).IsUnicode(false);

                entity.Property(e => e.Remarks).IsUnicode(false);

                entity.Property(e => e.StatusCode).IsUnicode(false);

                entity.Property(e => e.StatusDesc).IsUnicode(false);

                entity.Property(e => e.StatusEntEntguid).IsUnicode(false);

                entity.Property(e => e.StatusEntObjVerNo).HasPrecision(10);

                entity.Property(e => e.StatusEntStsguid).IsUnicode(false);

                entity.Property(e => e.StatusName).IsUnicode(false);

                entity.Property(e => e.Trainerdisabled).HasPrecision(1);

                entity.Property(e => e.Trainermasterguid).IsUnicode(false);

                entity.Property(e => e.Trainerobjectversionno).HasPrecision(10);

                entity.Property(e => e.Traineroracleentityid).IsUnicode(false);

                entity.Property(e => e.Traineroracleentityname).IsUnicode(false);

                entity.Property(e => e.Trainerpkguid).IsUnicode(false);

                entity.Property(e => e.Trainerstatusentityguid)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.TrainingMagEmpNum)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.TrainingMagFullName).IsUnicode(false);

                entity.Property(e => e.TrainingMagId).IsUnicode(false);

                entity.Property(e => e.TrainingMagJobId)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.TrainingMagJobName).IsUnicode(false);

                entity.Property(e => e.TrainingMagNpwNum)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.TrainingMagOrgId)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.TrainingMagPerId)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.TrainingMagPerType)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.TrainingMagPositionId)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.TrainingMagPositionName).IsUnicode(false);

                entity.Property(e => e.Trainingattendeeguid).IsUnicode(false);

                entity.Property(e => e.Trainingattendeepkguid).IsUnicode(false);

                entity.Property(e => e.Trainingbatchmasterguid).IsUnicode(false);

                entity.Property(e => e.Trainingname).IsUnicode(false);

                entity.Property(e => e.Trainingresult).IsUnicode(false);

                entity.Property(e => e.Trainingstatusentityguid).IsUnicode(false);

                entity.Property(e => e.Trainingtopic).IsUnicode(false);

                entity.Property(e => e.Trainingtypecomments).IsUnicode(false);

                entity.Property(e => e.Trainingtypedescription).IsUnicode(false);

                entity.Property(e => e.Trainingtypedisabled).HasPrecision(1);

                entity.Property(e => e.Trainingtypemasterguid).IsUnicode(false);

                entity.Property(e => e.Trainingtypename).IsUnicode(false);

                entity.Property(e => e.Trainingtypeobjectversionno).HasPrecision(10);

                entity.Property(e => e.Trainingtypeoracleentityid).IsUnicode(false);

                entity.Property(e => e.Trainingtypeoracleentityname).IsUnicode(false);

                entity.Property(e => e.Trainingtypepkguid).IsUnicode(false);

                entity.Property(e => e.Trainingtypequickaccesscode).IsUnicode(false);
            });

            modelBuilder.Entity<DriverV>(entity =>
            {
                entity.ToView("DRIVER_V");

                entity.Property(e => e.ContactNo).IsUnicode(false);

                entity.Property(e => e.DriverBioid).IsUnicode(false);

                entity.Property(e => e.DriverFname).IsUnicode(false);

                entity.Property(e => e.DriverLname).IsUnicode(false);

                entity.Property(e => e.DriverMname).IsUnicode(false);

                entity.Property(e => e.DriverObjVerNo).HasPrecision(10);

                entity.Property(e => e.DriverReadyflag).IsUnicode(false);

                entity.Property(e => e.DriverStatus).IsUnicode(false);

                entity.Property(e => e.Driverflag).HasPrecision(1);

                entity.Property(e => e.Driverid).IsUnicode(false);

                entity.Property(e => e.Dseflag).HasPrecision(1);

                entity.Property(e => e.Guid).IsUnicode(false);

                entity.Property(e => e.Issendtomonroe).HasPrecision(5);

                entity.Property(e => e.PersStatus).IsUnicode(false);

                entity.Property(e => e.Personguid).IsUnicode(false);

                entity.Property(e => e.SpBioid).IsUnicode(false);

                entity.Property(e => e.SpFname).IsUnicode(false);

                entity.Property(e => e.SpLname).IsUnicode(false);

                entity.Property(e => e.SpMname).IsUnicode(false);

                entity.Property(e => e.SpStatus).IsUnicode(false);

                entity.Property(e => e.Spflag).HasPrecision(1);

                entity.Property(e => e.Spguid).IsUnicode(false);

                entity.Property(e => e.Spid).IsUnicode(false);
            });

            modelBuilder.Entity<Drivermaster>(entity =>
            {
                entity.Property(e => e.DefrredDocCheckFlag).IsUnicode(false);

                entity.Property(e => e.Disabled)
                    .HasPrecision(1)
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Effectiveenddate).HasDefaultValueSql("to_timestamp('4712-12-31','yyyy-mm-dd')");

                entity.Property(e => e.Guid).IsUnicode(false);

                entity.Property(e => e.Issendtomonroe)
                    .HasPrecision(5)
                    .HasDefaultValueSql("0 ");

                entity.Property(e => e.Objectversionno).HasPrecision(10);

                entity.Property(e => e.Oracleentityid).IsUnicode(false);

                entity.Property(e => e.Oracleentityname).IsUnicode(false);

                entity.Property(e => e.Personmasterguid).IsUnicode(false);

                entity.Property(e => e.Pkguid).IsUnicode(false);

                entity.Property(e => e.Readyflag).IsUnicode(false);

                entity.Property(e => e.Serviceproviderguid).IsUnicode(false);

                entity.Property(e => e.Statusentityguid).IsUnicode(false);

                entity.Property(e => e.Userarchived).IsUnicode(false);

                entity.Property(e => e.Usercreated).IsUnicode(false);

                entity.Property(e => e.Userdeleted).IsUnicode(false);

                entity.Property(e => e.Userupdated).IsUnicode(false);
            });

            modelBuilder.Entity<Driverrating>(entity =>
            {
                entity.Property(e => e.Comments).IsUnicode(false);

                entity.Property(e => e.Disabled)
                    .HasPrecision(1)
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Drivermasterguid).IsUnicode(false);

                entity.Property(e => e.Guid).IsUnicode(false);

                entity.Property(e => e.Objectversionno).IsUnicode(false);

                entity.Property(e => e.Oracleentityid).IsUnicode(false);

                entity.Property(e => e.Oracleentityname).IsUnicode(false);

                entity.Property(e => e.Pkguid).IsUnicode(false);

                entity.Property(e => e.Ratingmasterguid).IsUnicode(false);

                entity.Property(e => e.Userarchived).IsUnicode(false);

                entity.Property(e => e.Usercreated).IsUnicode(false);

                entity.Property(e => e.Userdeleted).IsUnicode(false);

                entity.Property(e => e.Userupdated).IsUnicode(false);
            });

            modelBuilder.Entity<Driverrating90days1>(entity =>
            {
                entity.Property(e => e.Comments).IsUnicode(false);

                entity.Property(e => e.Disabled).HasPrecision(1);

                entity.Property(e => e.Drivermasterguid).IsUnicode(false);

                entity.Property(e => e.Guid).IsUnicode(false);

                entity.Property(e => e.Objectversionno).IsUnicode(false);

                entity.Property(e => e.Oracleentityid).IsUnicode(false);

                entity.Property(e => e.Oracleentityname).IsUnicode(false);

                entity.Property(e => e.Pkguid).IsUnicode(false);

                entity.Property(e => e.Ratingmasterguid).IsUnicode(false);

                entity.Property(e => e.Userarchived).IsUnicode(false);

                entity.Property(e => e.Usercreated).IsUnicode(false);

                entity.Property(e => e.Userdeleted).IsUnicode(false);

                entity.Property(e => e.Userupdated).IsUnicode(false);
            });

            modelBuilder.Entity<Drivertip>(entity =>
            {
                entity.HasKey(e => e.Tripid)
                    .HasName("TRIPID_DRIVERTIP_PK");

                entity.Property(e => e.Tripid).IsUnicode(false);

                entity.Property(e => e.Carno).IsUnicode(false);

                entity.Property(e => e.Driverid).IsUnicode(false);

                entity.Property(e => e.Status).IsUnicode(false);

                entity.Property(e => e.Tipamount).HasDefaultValueSql("0");
            });

            modelBuilder.Entity<EmiMaster>(entity =>
            {
                entity.Property(e => e.Disabled).HasDefaultValueSql("0");

                entity.Property(e => e.Guid).IsUnicode(false);

                entity.Property(e => e.Siteguid).IsUnicode(false);

                entity.Property(e => e.TxnClass).IsUnicode(false);

                entity.Property(e => e.TxnType).IsUnicode(false);
            });

            modelBuilder.Entity<EmiTransactionmaster>(entity =>
            {
                entity.Property(e => e.Guid).IsUnicode(false);

                entity.Property(e => e.Siteguid).IsUnicode(false);

                entity.Property(e => e.TxnGuid).IsUnicode(false);

                entity.Property(e => e.TxnName).IsUnicode(false);
            });

            modelBuilder.Entity<EmiTransactionmastera>(entity =>
            {
                entity.Property(e => e.Guid).IsUnicode(false);

                entity.Property(e => e.Siteguid).IsUnicode(false);

                entity.Property(e => e.TxnGuid).IsUnicode(false);

                entity.Property(e => e.TxnName).IsUnicode(false);
            });

            modelBuilder.Entity<Entitycolumn>(entity =>
            {
                entity.Property(e => e.Columnname).IsUnicode(false);

                entity.Property(e => e.Datatype).IsUnicode(false);

                entity.Property(e => e.Entityguid).IsUnicode(false);
            });

            modelBuilder.Entity<Entityjoin>(entity =>
            {
                entity.Property(e => e.Jointext).IsUnicode(false);

                entity.Property(e => e.Leftentityid).IsUnicode(false);

                entity.Property(e => e.Operator).IsUnicode(false);

                entity.Property(e => e.Rightentityid).IsUnicode(false);
            });

            modelBuilder.Entity<Entitymaster>(entity =>
            {
                entity.Property(e => e.Comments).IsUnicode(false);

                entity.Property(e => e.Description).IsUnicode(false);

                entity.Property(e => e.Disabled).HasPrecision(1);

                entity.Property(e => e.Guid).IsUnicode(false);

                entity.Property(e => e.Name).IsUnicode(false);

                entity.Property(e => e.Objectversionno).HasPrecision(10);

                entity.Property(e => e.Oracleentityid).IsUnicode(false);

                entity.Property(e => e.Oracleentityname).IsUnicode(false);

                entity.Property(e => e.Pkguid).IsUnicode(false);

                entity.Property(e => e.Quickaccesscode).IsUnicode(false);

                entity.Property(e => e.Userarchived).IsUnicode(false);

                entity.Property(e => e.Usercreated).IsUnicode(false);

                entity.Property(e => e.Userdeleted).IsUnicode(false);

                entity.Property(e => e.Userupdated).IsUnicode(false);
            });

            modelBuilder.Entity<Environmentmaster>(entity =>
            {
                entity.Property(e => e.Value).IsUnicode(false);

                entity.Property(e => e.Variable).IsUnicode(false);
            });

            modelBuilder.Entity<Errormessage>(entity =>
            {
                entity.Property(e => e.Classname).IsUnicode(false);

                entity.Property(e => e.Errormessagetext).IsUnicode(false);

                entity.Property(e => e.Methodname).IsUnicode(false);
            });

            modelBuilder.Entity<EscrowHistV>(entity =>
            {
                entity.ToView("ESCROW_HIST_V");

                entity.Property(e => e.BrandName).IsUnicode(false);

                entity.Property(e => e.CityName).IsUnicode(false);

                entity.Property(e => e.LeName).IsUnicode(false);

                entity.Property(e => e.ModelName).IsUnicode(false);

                entity.Property(e => e.Reguid).IsUnicode(false);

                entity.Property(e => e.Securitycombinationguid).IsUnicode(false);

                entity.Property(e => e.Sitename).IsUnicode(false);

                entity.Property(e => e.SpFname).IsUnicode(false);

                entity.Property(e => e.SpLname).IsUnicode(false);

                entity.Property(e => e.Spid).IsUnicode(false);

                entity.Property(e => e.TransactionDate).IsUnicode(false);

                entity.Property(e => e.TransactionType).IsUnicode(false);

                entity.Property(e => e.Username).IsUnicode(false);
            });

            modelBuilder.Entity<EventTable>(entity =>
            {
                entity.Property(e => e.Eventname).IsUnicode(false);

                entity.Property(e => e.Itemkey).IsUnicode(false);

                entity.Property(e => e.SubsName).IsUnicode(false);
            });

            modelBuilder.Entity<Eventdatum>(entity =>
            {
                entity.Property(e => e.PEventCode).IsUnicode(false);

                entity.Property(e => e.PParamString).IsUnicode(false);

                entity.Property(e => e.ProcessedResult).IsUnicode(false);

                entity.Property(e => e.ProcessedStatus).IsUnicode(false);

                entity.Property(e => e.Source).IsUnicode(false);
            });

            modelBuilder.Entity<Exceptionreasonmaster>(entity =>
            {
                entity.Property(e => e.Guid).IsUnicode(false);

                entity.Property(e => e.Reason).IsUnicode(false);

                entity.Property(e => e.Type).IsUnicode(false);
            });

            modelBuilder.Entity<Exitinterview>(entity =>
            {
                entity.Property(e => e.Carmasterguid).IsUnicode(false);

                entity.Property(e => e.Guid).IsUnicode(false);

                entity.Property(e => e.Objectversionno).HasPrecision(10);

                entity.Property(e => e.Oracleentityid).IsUnicode(false);

                entity.Property(e => e.Oracleentityname).IsUnicode(false);

                entity.Property(e => e.Otherfeedback).IsUnicode(false);

                entity.Property(e => e.Personmasterguid).IsUnicode(false);

                entity.Property(e => e.Pkguid).IsUnicode(false);

                entity.Property(e => e.Statusentityguid).IsUnicode(false);

                entity.Property(e => e.Terminationreason).IsUnicode(false);

                entity.Property(e => e.Thingslikemosttext).IsUnicode(false);

                entity.Property(e => e.Thingsliketochangetext).IsUnicode(false);

                entity.Property(e => e.Userarchived).IsUnicode(false);

                entity.Property(e => e.Usercreated).IsUnicode(false);

                entity.Property(e => e.Userdeleted).IsUnicode(false);

                entity.Property(e => e.Userupdated).IsUnicode(false);
            });

            modelBuilder.Entity<ExternalPayment>(entity =>
            {
                entity.Property(e => e.CabNo).IsUnicode(false);

                entity.Property(e => e.Comments).IsUnicode(false);

                entity.Property(e => e.ProcessingStatus).IsUnicode(false);

                entity.Property(e => e.SpId).IsUnicode(false);

                entity.Property(e => e.TxnSource).IsUnicode(false);
            });

            modelBuilder.Entity<FaqV>(entity =>
            {
                entity.ToView("FAQ_V");

                entity.Property(e => e.Answere).IsUnicode(false);

                entity.Property(e => e.Faqgroupheading).IsUnicode(false);

                entity.Property(e => e.Faqgroupmasterguid).IsUnicode(false);

                entity.Property(e => e.Faqgroupname).IsUnicode(false);

                entity.Property(e => e.Faqgroupquickaccesscode).IsUnicode(false);

                entity.Property(e => e.Faqmasterguid).IsUnicode(false);

                entity.Property(e => e.Faqmasterquickaccesscode).IsUnicode(false);

                entity.Property(e => e.Question).IsUnicode(false);
            });

            modelBuilder.Entity<Faqgroupmaster>(entity =>
            {
                entity.Property(e => e.Guid).IsUnicode(false);

                entity.Property(e => e.Heading).IsUnicode(false);

                entity.Property(e => e.Name).IsUnicode(false);

                entity.Property(e => e.Quickaccesscode).IsUnicode(false);
            });

            modelBuilder.Entity<Faqmaster>(entity =>
            {
                entity.Property(e => e.Answere).IsUnicode(false);

                entity.Property(e => e.Faqgroupmasterguid).IsUnicode(false);

                entity.Property(e => e.Guid).IsUnicode(false);

                entity.Property(e => e.Question).IsUnicode(false);

                entity.Property(e => e.Quickaccesscode).IsUnicode(false);
            });

            modelBuilder.Entity<Fixedtriprule>(entity =>
            {
                entity.Property(e => e.Comments).IsUnicode(false);

                entity.Property(e => e.Description).IsUnicode(false);

                entity.Property(e => e.Disabled).HasPrecision(1);

                entity.Property(e => e.Factor).HasPrecision(10);

                entity.Property(e => e.FixedUnit).IsUnicode(false);

                entity.Property(e => e.Guid).IsUnicode(false);

                entity.Property(e => e.Lebranchsecurityguid).IsUnicode(false);

                entity.Property(e => e.Name).IsUnicode(false);

                entity.Property(e => e.Objectversionno).HasPrecision(10);

                entity.Property(e => e.Oracleentityid).IsUnicode(false);

                entity.Property(e => e.Oracleentityname).IsUnicode(false);

                entity.Property(e => e.Pkguid).IsUnicode(false);

                entity.Property(e => e.Quickaccesscode).IsUnicode(false);

                entity.Property(e => e.Securitycombinationguid).IsUnicode(false);

                entity.Property(e => e.Sourceentityguid).IsUnicode(false);

                entity.Property(e => e.Transactiontypeguid).IsUnicode(false);

                entity.Property(e => e.Userarchived).IsUnicode(false);

                entity.Property(e => e.Usercreated).IsUnicode(false);

                entity.Property(e => e.Userdeleted).IsUnicode(false);

                entity.Property(e => e.Userupdated).IsUnicode(false);

                entity.Property(e => e.Valuetype).IsUnicode(false);
            });

            modelBuilder.Entity<FreeCarsBaseV>(entity =>
            {
                entity.ToView("FREE_CARS_BASE_V");

                entity.Property(e => e.Branchmasterguid).IsUnicode(false);

                entity.Property(e => e.CarBrandCode).IsUnicode(false);

                entity.Property(e => e.CarBrandName).IsUnicode(false);

                entity.Property(e => e.CarChassisno).IsUnicode(false);

                entity.Property(e => e.CarCityCode).IsUnicode(false);

                entity.Property(e => e.CarCityName).IsUnicode(false);

                entity.Property(e => e.CarDefrredDocCheckFlag).IsUnicode(false);

                entity.Property(e => e.CarGuid).IsUnicode(false);

                entity.Property(e => e.CarGvguid).IsUnicode(false);

                entity.Property(e => e.CarGvname).IsUnicode(false);

                entity.Property(e => e.CarLeBranchGuid).IsUnicode(false);

                entity.Property(e => e.CarLeCode).IsUnicode(false);

                entity.Property(e => e.CarLeName).IsUnicode(false);

                entity.Property(e => e.CarMake).IsUnicode(false);

                entity.Property(e => e.CarMakeCode).IsUnicode(false);

                entity.Property(e => e.CarModel).IsUnicode(false);

                entity.Property(e => e.CarModelGuid).IsUnicode(false);

                entity.Property(e => e.CarModelcode).IsUnicode(false);

                entity.Property(e => e.CarObjVerNo).HasPrecision(3);

                entity.Property(e => e.CarOpModelCode).IsUnicode(false);

                entity.Property(e => e.CarOpModelName).IsUnicode(false);

                entity.Property(e => e.CarOwner).IsUnicode(false);

                entity.Property(e => e.CarOwnerSpStatus).IsUnicode(false);

                entity.Property(e => e.CarOwnerSpid).IsUnicode(false);

                entity.Property(e => e.CarOwnerSpname).IsUnicode(false);

                entity.Property(e => e.CarPkguid).IsUnicode(false);

                entity.Property(e => e.CarRegnNo).IsUnicode(false);

                entity.Property(e => e.CarSecGuid).IsUnicode(false);

                entity.Property(e => e.CarStatusCode).IsUnicode(false);

                entity.Property(e => e.CarStatusName).IsUnicode(false);

                entity.Property(e => e.Engineno).IsUnicode(false);

                entity.Property(e => e.Locationworkshopmasterguid).IsUnicode(false);

                entity.Property(e => e.Poolflag).IsUnicode(false);

                entity.Property(e => e.Rfidflag).HasPrecision(1);

                entity.Property(e => e.SpDefrredDocCheckFlag).IsUnicode(false);

                entity.Property(e => e.SpPersonguid).IsUnicode(false);

                entity.Property(e => e.SpPkguid).IsUnicode(false);

                entity.Property(e => e.Spguid).IsUnicode(false);

                entity.Property(e => e.Workshopcomments).IsUnicode(false);

                entity.Property(e => e.Workshopdescription).IsUnicode(false);

                entity.Property(e => e.Workshopdisabled).HasPrecision(1);

                entity.Property(e => e.Workshoplocationtype).IsUnicode(false);

                entity.Property(e => e.Workshopmasterguid).IsUnicode(false);

                entity.Property(e => e.Workshopname).IsUnicode(false);

                entity.Property(e => e.Workshoppkguid).IsUnicode(false);

                entity.Property(e => e.Workshopquickaccesscode).IsUnicode(false);
            });

            modelBuilder.Entity<FreeCarsV>(entity =>
            {
                entity.ToView("FREE_CARS_V");

                entity.Property(e => e.Branchmasterguid).IsUnicode(false);

                entity.Property(e => e.CarBrandCode).IsUnicode(false);

                entity.Property(e => e.CarBrandName).IsUnicode(false);

                entity.Property(e => e.CarChassisno).IsUnicode(false);

                entity.Property(e => e.CarCityCode).IsUnicode(false);

                entity.Property(e => e.CarCityName).IsUnicode(false);

                entity.Property(e => e.CarDefrredDocCheckFlag).IsUnicode(false);

                entity.Property(e => e.CarGuid).IsUnicode(false);

                entity.Property(e => e.CarGvguid).IsUnicode(false);

                entity.Property(e => e.CarGvname).IsUnicode(false);

                entity.Property(e => e.CarLeBranchGuid).IsUnicode(false);

                entity.Property(e => e.CarLeCode).IsUnicode(false);

                entity.Property(e => e.CarLeName).IsUnicode(false);

                entity.Property(e => e.CarMake).IsUnicode(false);

                entity.Property(e => e.CarMakeCode).IsUnicode(false);

                entity.Property(e => e.CarModel).IsUnicode(false);

                entity.Property(e => e.CarModelGuid).IsUnicode(false);

                entity.Property(e => e.CarModelcode).IsUnicode(false);

                entity.Property(e => e.CarObjVerNo).HasPrecision(3);

                entity.Property(e => e.CarOpModelCode).IsUnicode(false);

                entity.Property(e => e.CarOpModelName).IsUnicode(false);

                entity.Property(e => e.CarOwner).IsUnicode(false);

                entity.Property(e => e.CarOwnerSpStatus).IsUnicode(false);

                entity.Property(e => e.CarOwnerSpid).IsUnicode(false);

                entity.Property(e => e.CarOwnerSpname).IsUnicode(false);

                entity.Property(e => e.CarPkguid).IsUnicode(false);

                entity.Property(e => e.CarRegnNo).IsUnicode(false);

                entity.Property(e => e.CarSecGuid).IsUnicode(false);

                entity.Property(e => e.CarStatusCode).IsUnicode(false);

                entity.Property(e => e.CarStatusName).IsUnicode(false);

                entity.Property(e => e.Engineno).IsUnicode(false);

                entity.Property(e => e.Locationworkshopmasterguid).IsUnicode(false);

                entity.Property(e => e.Poolflag).IsUnicode(false);

                entity.Property(e => e.Rfidflag).HasPrecision(1);

                entity.Property(e => e.SpDefrredDocCheckFlag).IsUnicode(false);

                entity.Property(e => e.SpPersonguid).IsUnicode(false);

                entity.Property(e => e.SpPkguid).IsUnicode(false);

                entity.Property(e => e.Spguid).IsUnicode(false);

                entity.Property(e => e.Workshopcomments).IsUnicode(false);

                entity.Property(e => e.Workshopdescription).IsUnicode(false);

                entity.Property(e => e.Workshopdisabled).HasPrecision(1);

                entity.Property(e => e.Workshoplocationtype).IsUnicode(false);

                entity.Property(e => e.Workshopmasterguid).IsUnicode(false);

                entity.Property(e => e.Workshopname).IsUnicode(false);

                entity.Property(e => e.Workshoppkguid).IsUnicode(false);

                entity.Property(e => e.Workshopquickaccesscode).IsUnicode(false);
            });

            modelBuilder.Entity<FreeDriverV>(entity =>
            {
                entity.ToView("FREE_DRIVER_V");

                entity.Property(e => e.ContactNo).IsUnicode(false);

                entity.Property(e => e.DriverBioid).IsUnicode(false);

                entity.Property(e => e.DriverFname).IsUnicode(false);

                entity.Property(e => e.DriverLname).IsUnicode(false);

                entity.Property(e => e.DriverMname).IsUnicode(false);

                entity.Property(e => e.DriverObjVerNo).HasPrecision(10);

                entity.Property(e => e.DriverReadyflag).IsUnicode(false);

                entity.Property(e => e.DriverStatus).IsUnicode(false);

                entity.Property(e => e.Driverflag).HasPrecision(1);

                entity.Property(e => e.Driverid).IsUnicode(false);

                entity.Property(e => e.Dseflag).HasPrecision(1);

                entity.Property(e => e.Guid).IsUnicode(false);

                entity.Property(e => e.PersStatus).IsUnicode(false);

                entity.Property(e => e.Personguid).IsUnicode(false);

                entity.Property(e => e.SpBioid).IsUnicode(false);

                entity.Property(e => e.SpFname).IsUnicode(false);

                entity.Property(e => e.SpLname).IsUnicode(false);

                entity.Property(e => e.SpMname).IsUnicode(false);

                entity.Property(e => e.SpStatus).IsUnicode(false);

                entity.Property(e => e.Spflag).HasPrecision(1);

                entity.Property(e => e.Spguid).IsUnicode(false);

                entity.Property(e => e.Spid).IsUnicode(false);
            });

            modelBuilder.Entity<Frequencymaster>(entity =>
            {
                entity.Property(e => e.Comments).IsUnicode(false);

                entity.Property(e => e.Description).IsUnicode(false);

                entity.Property(e => e.Disabled).HasPrecision(1);

                entity.Property(e => e.Guid)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Name).IsUnicode(false);

                entity.Property(e => e.Objectversionno)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Oracleentityid)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Oracleentityname)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Oracleentitytype)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Pkguid).IsUnicode(false);

                entity.Property(e => e.Quickaccesscode).IsUnicode(false);

                entity.Property(e => e.Userarchived)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Usercreated)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Userdeleted)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Userupdated)
                    .IsUnicode(false)
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<FtrQacdcoflexi>(entity =>
            {
                entity.Property(e => e.Associateid).IsUnicode(false);

                entity.Property(e => e.Associatename).IsUnicode(false);

                entity.Property(e => e.Bankname).IsUnicode(false);

                entity.Property(e => e.Cabregistrationno).IsUnicode(false);

                entity.Property(e => e.Cabtype).IsUnicode(false);

                entity.Property(e => e.Chequeno).IsUnicode(false);

                entity.Property(e => e.Cityname).IsUnicode(false);

                entity.Property(e => e.Paymentmode).IsUnicode(false);

                entity.Property(e => e.Remarks).IsUnicode(false);

                entity.Property(e => e.Transactionsubtype).IsUnicode(false);

                entity.Property(e => e.Transactiontype).IsUnicode(false);

                entity.Property(e => e.Transrefnumber).IsUnicode(false);

                entity.Property(e => e.Username).IsUnicode(false);
            });

            modelBuilder.Entity<Fundnottransfered>(entity =>
            {
                entity.Property(e => e.Guid).IsUnicode(false);

                entity.Property(e => e.Site).IsUnicode(false);

                entity.Property(e => e.Smstext).IsUnicode(false);

                entity.Property(e => e.Spid).IsUnicode(false);
            });

            modelBuilder.Entity<FundtransferTaskExecution>(entity =>
            {
                entity.HasKey(e => e.Guid)
                    .HasName("FUNDTRANSFER_TASK_EXECUTION_PK");

                entity.Property(e => e.Guid).IsUnicode(false);

                entity.Property(e => e.Activityname).IsUnicode(false);

                entity.Property(e => e.Remark1).IsUnicode(false);

                entity.Property(e => e.Remark2).IsUnicode(false);

                entity.Property(e => e.Statuscode).IsUnicode(false);
            });

            modelBuilder.Entity<FundtransferTxn>(entity =>
            {
                entity.HasKey(e => e.Guid)
                    .HasName("FUND_TRANSFER_PK");

                entity.Property(e => e.Guid).IsUnicode(false);

                entity.Property(e => e.Bankreferenceno).IsUnicode(false);

                entity.Property(e => e.Comments).IsUnicode(false);

                entity.Property(e => e.Creditballimit).HasDefaultValueSql("0");

                entity.Property(e => e.Creditlimit).HasDefaultValueSql("0");

                entity.Property(e => e.Formulatype)
                    .IsUnicode(false)
                    .HasDefaultValueSql("null\n                    ");

                entity.Property(e => e.Fundtransferrequest).IsUnicode(false);

                entity.Property(e => e.Fundtransferresponse).IsUnicode(false);

                entity.Property(e => e.Fundtransferstatuscode).IsUnicode(false);

                entity.Property(e => e.Getstatusrequest).IsUnicode(false);

                entity.Property(e => e.Getstatusresponse).IsUnicode(false);

                entity.Property(e => e.Getstatusstatuscode).IsUnicode(false);

                entity.Property(e => e.Issendnotification).IsUnicode(false);

                entity.Property(e => e.LockcalcLockbal).HasDefaultValueSql("0");

                entity.Property(e => e.NetOs).HasDefaultValueSql("0");

                entity.Property(e => e.Site).IsUnicode(false);

                entity.Property(e => e.Spid).IsUnicode(false);

                entity.Property(e => e.Substatuscode).IsUnicode(false);

                entity.Property(e => e.Substatustext).IsUnicode(false);

                entity.Property(e => e.Uniquerequestno).IsUnicode(false);

                entity.Property(e => e.Uniqueresponseno).IsUnicode(false);
            });

            modelBuilder.Entity<FundwithdrawalTxn>(entity =>
            {
                entity.HasKey(e => e.Guid)
                    .HasName("FUNDWITHDRAWAL_TXN_PK");

                entity.Property(e => e.Guid).IsUnicode(false);

                entity.Property(e => e.Bankreferenceno).IsUnicode(false);

                entity.Property(e => e.Comments).IsUnicode(false);

                entity.Property(e => e.Formulatype).IsUnicode(false);

                entity.Property(e => e.Fundtransferrequest).IsUnicode(false);

                entity.Property(e => e.Fundtransferresponse).IsUnicode(false);

                entity.Property(e => e.Fundtransferstatuscode).IsUnicode(false);

                entity.Property(e => e.Getstatusrequest).IsUnicode(false);

                entity.Property(e => e.Getstatusresponse).IsUnicode(false);

                entity.Property(e => e.Getstatusstatuscode).IsUnicode(false);

                entity.Property(e => e.Issendnotification).IsUnicode(false);

                entity.Property(e => e.Site).IsUnicode(false);

                entity.Property(e => e.Spid).IsUnicode(false);

                entity.Property(e => e.Substatuscode).IsUnicode(false);

                entity.Property(e => e.Substatustext).IsUnicode(false);

                entity.Property(e => e.Uniquerequestno).IsUnicode(false);

                entity.Property(e => e.Uniqueresponseno).IsUnicode(false);
            });

            modelBuilder.Entity<GlV>(entity =>
            {
                entity.ToView("GL_V");

                entity.Property(e => e.CityName).IsUnicode(false);

                entity.Property(e => e.GlName).IsUnicode(false);

                entity.Property(e => e.LegalEntity).IsUnicode(false);

                entity.Property(e => e.TransactionClass).IsUnicode(false);

                entity.Property(e => e.TransactionType).IsUnicode(false);
            });

            modelBuilder.Entity<Greivancescategory>(entity =>
            {
                entity.Property(e => e.Comments).IsUnicode(false);

                entity.Property(e => e.Description).IsUnicode(false);

                entity.Property(e => e.Disabled).HasPrecision(1);

                entity.Property(e => e.Guid).IsUnicode(false);

                entity.Property(e => e.Name).IsUnicode(false);

                entity.Property(e => e.Objectversionno).HasPrecision(10);

                entity.Property(e => e.Oracleentityid).IsUnicode(false);

                entity.Property(e => e.Oracleentityname).IsUnicode(false);

                entity.Property(e => e.Pkguid).IsUnicode(false);

                entity.Property(e => e.Quickaccesscode).IsUnicode(false);

                entity.Property(e => e.Statuscolor).IsUnicode(false);

                entity.Property(e => e.Userarchived).IsUnicode(false);

                entity.Property(e => e.Usercreated).IsUnicode(false);

                entity.Property(e => e.Userdeleted).IsUnicode(false);

                entity.Property(e => e.Userupdated).IsUnicode(false);
            });

            modelBuilder.Entity<Groupvariant>(entity =>
            {
                entity.Property(e => e.Guid).IsUnicode(false);

                entity.Property(e => e.Isdefaultgv)
                    .HasPrecision(1)
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Name).IsUnicode(false);

                entity.Property(e => e.Objectversionno).HasPrecision(10);

                entity.Property(e => e.Oracleentityid).IsUnicode(false);

                entity.Property(e => e.Oracleentityname).IsUnicode(false);

                entity.Property(e => e.Pkguid).IsUnicode(false);

                entity.Property(e => e.Securitycombinationguid).IsUnicode(false);

                entity.Property(e => e.Userarchived).IsUnicode(false);

                entity.Property(e => e.Usercreated).IsUnicode(false);

                entity.Property(e => e.Userdeleted).IsUnicode(false);

                entity.Property(e => e.Userupdated).IsUnicode(false);
            });

            modelBuilder.Entity<Gvcomponent>(entity =>
            {
                entity.Property(e => e.Capitalrecodays).IsUnicode(false);

                entity.Property(e => e.Capitalrecoflag).IsUnicode(false);

                entity.Property(e => e.Cyclemasterguid).IsUnicode(false);

                entity.Property(e => e.Frequencymasterguid).IsUnicode(false);

                entity.Property(e => e.Groupvariantguid).IsUnicode(false);

                entity.Property(e => e.Guid).IsUnicode(false);

                entity.Property(e => e.Impactedbygvchange).IsUnicode(false);

                entity.Property(e => e.Name).IsUnicode(false);

                entity.Property(e => e.Objectversionno).HasPrecision(3);

                entity.Property(e => e.Oracleentityid).IsUnicode(false);

                entity.Property(e => e.Oracleentityname).IsUnicode(false);

                entity.Property(e => e.Pkguid).IsUnicode(false);

                entity.Property(e => e.Quickaccesscode).IsUnicode(false);

                entity.Property(e => e.Transactiontypeguid).IsUnicode(false);

                entity.Property(e => e.Userarchived).IsUnicode(false);

                entity.Property(e => e.Usercreated).IsUnicode(false);

                entity.Property(e => e.Userdeleted).IsUnicode(false);

                entity.Property(e => e.Userupdated).IsUnicode(false);

                entity.Property(e => e.Valueamount).IsUnicode(false);

                entity.Property(e => e.Valuetype).IsUnicode(false);
            });

            modelBuilder.Entity<GvcomponentAuditLog>(entity =>
            {
                entity.Property(e => e.Capitalrecodays).IsUnicode(false);

                entity.Property(e => e.Capitalrecoflag).IsUnicode(false);

                entity.Property(e => e.Cyclemasterguid).IsUnicode(false);

                entity.Property(e => e.Frequencymasterguid).IsUnicode(false);

                entity.Property(e => e.Groupvariantguid).IsUnicode(false);

                entity.Property(e => e.Guid).IsUnicode(false);

                entity.Property(e => e.Impactedbygvchange).IsUnicode(false);

                entity.Property(e => e.Name).IsUnicode(false);

                entity.Property(e => e.Objectversionno).HasPrecision(3);

                entity.Property(e => e.Oracleentityid).IsUnicode(false);

                entity.Property(e => e.Oracleentityname).IsUnicode(false);

                entity.Property(e => e.Pkguid).IsUnicode(false);

                entity.Property(e => e.Quickaccesscode).IsUnicode(false);

                entity.Property(e => e.Transactiontypeguid).IsUnicode(false);

                entity.Property(e => e.Userarchived).IsUnicode(false);

                entity.Property(e => e.Usercreated).IsUnicode(false);

                entity.Property(e => e.Userdeleted).IsUnicode(false);

                entity.Property(e => e.Userupdated).IsUnicode(false);

                entity.Property(e => e.Valuetype).IsUnicode(false);
            });

            modelBuilder.Entity<Gvcomponentmaster>(entity =>
            {
                entity.Property(e => e.Quickaccesscode).IsUnicode(false);
            });

            modelBuilder.Entity<Gvcomponenttypemaster>(entity =>
            {
                entity.Property(e => e.Comments).IsUnicode(false);

                entity.Property(e => e.Description).IsUnicode(false);

                entity.Property(e => e.Disabled).HasPrecision(1);

                entity.Property(e => e.Guid).IsUnicode(false);

                entity.Property(e => e.Name).IsUnicode(false);

                entity.Property(e => e.Objectversionno).HasPrecision(10);

                entity.Property(e => e.Oracleentityid).IsUnicode(false);

                entity.Property(e => e.Oracleentityname).IsUnicode(false);

                entity.Property(e => e.Pkguid).IsUnicode(false);

                entity.Property(e => e.Quickaccesscode).IsUnicode(false);

                entity.Property(e => e.Userarchived).IsUnicode(false);

                entity.Property(e => e.Usercreated).IsUnicode(false);

                entity.Property(e => e.Userdeleted).IsUnicode(false);

                entity.Property(e => e.Userupdated).IsUnicode(false);
            });

            modelBuilder.Entity<Gvrankthresholdmaster>(entity =>
            {
                entity.Property(e => e.Gvname).IsUnicode(false);
            });

            modelBuilder.Entity<Helpmessagemaster>(entity =>
            {
                entity.Property(e => e.Applicationpagemasterguid).IsUnicode(false);

                entity.Property(e => e.Comments).IsUnicode(false);

                entity.Property(e => e.Disabled)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(0) ")
                    .IsFixedLength(true);

                entity.Property(e => e.Guid).IsUnicode(false);

                entity.Property(e => e.Objectversionno).IsUnicode(false);

                entity.Property(e => e.Oracleentityid).IsUnicode(false);

                entity.Property(e => e.Oracleentityname).IsUnicode(false);

                entity.Property(e => e.Pageactionmasterguid).IsUnicode(false);

                entity.Property(e => e.Pkguid).IsUnicode(false);

                entity.Property(e => e.Userarchived).IsUnicode(false);

                entity.Property(e => e.Usercreated).IsUnicode(false);

                entity.Property(e => e.Userdeleted).IsUnicode(false);

                entity.Property(e => e.Userupdated).IsUnicode(false);
            });

            modelBuilder.Entity<Imageverificationlog>(entity =>
            {
                entity.Property(e => e.Apiname).IsUnicode(false);

                entity.Property(e => e.Doctypename).IsUnicode(false);

                entity.Property(e => e.Guid).IsUnicode(false);

                entity.Property(e => e.Imagename).IsUnicode(false);

                entity.Property(e => e.Personid).IsUnicode(false);

                entity.Property(e => e.Salesdocinterfaceguid).IsUnicode(false);
            });

            modelBuilder.Entity<IncentiveValidTripsV>(entity =>
            {
                entity.ToView("INCENTIVE_VALID_TRIPS_V");

                entity.Property(e => e.Carmasterguid).IsUnicode(false);

                entity.Property(e => e.Carregistrationno).IsUnicode(false);

                entity.Property(e => e.Securitycombinationguid).IsUnicode(false);

                entity.Property(e => e.Siteguid).IsUnicode(false);

                entity.Property(e => e.Tripid).IsUnicode(false);
            });

            modelBuilder.Entity<Inspectioncategorymaster>(entity =>
            {
                entity.HasKey(e => e.Guid)
                    .HasName("SYS_C0010878");

                entity.Property(e => e.Guid).IsUnicode(false);

                entity.Property(e => e.Comments).IsUnicode(false);

                entity.Property(e => e.Description).IsUnicode(false);

                entity.Property(e => e.Disabled).HasPrecision(1);

                entity.Property(e => e.Name).IsUnicode(false);

                entity.Property(e => e.Objectversionno).HasPrecision(3);

                entity.Property(e => e.Oracleentityid).IsUnicode(false);

                entity.Property(e => e.Oracleentityname).IsUnicode(false);

                entity.Property(e => e.Pkguid).IsUnicode(false);

                entity.Property(e => e.Quickaccesscode).IsUnicode(false);

                entity.Property(e => e.Userarchived).IsUnicode(false);

                entity.Property(e => e.Usercreated).IsUnicode(false);

                entity.Property(e => e.Userdeleted).IsUnicode(false);

                entity.Property(e => e.Userupdated).IsUnicode(false);
            });

            modelBuilder.Entity<Inspectiondetail>(entity =>
            {
                entity.Property(e => e.Answertypemappingguid).IsUnicode(false);

                entity.Property(e => e.Comments).IsUnicode(false);

                entity.Property(e => e.Description).IsUnicode(false);

                entity.Property(e => e.Disabled)
                    .HasPrecision(1)
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Guid).IsUnicode(false);

                entity.Property(e => e.Inspectionresultsguid).IsUnicode(false);

                entity.Property(e => e.Objectversionno).HasPrecision(3);

                entity.Property(e => e.Oracleentityid).IsUnicode(false);

                entity.Property(e => e.Oracleentityname).IsUnicode(false);

                entity.Property(e => e.Pkguid).IsUnicode(false);

                entity.Property(e => e.Questionbankmasterguid).IsUnicode(false);

                entity.Property(e => e.Quickaccesscode).IsUnicode(false);

                entity.Property(e => e.Userarchived).IsUnicode(false);

                entity.Property(e => e.Usercreated).IsUnicode(false);

                entity.Property(e => e.Userdeleted).IsUnicode(false);

                entity.Property(e => e.Userupdated).IsUnicode(false);
            });

            modelBuilder.Entity<Inspectionresult>(entity =>
            {
                entity.Property(e => e.Carmasterguid).IsUnicode(false);

                entity.Property(e => e.Comments).IsUnicode(false);

                entity.Property(e => e.Description).IsUnicode(false);

                entity.Property(e => e.Disabled)
                    .HasPrecision(1)
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Drivermasterguid).IsUnicode(false);

                entity.Property(e => e.Guid).IsUnicode(false);

                entity.Property(e => e.Inspectiondocno).IsUnicode(false);

                entity.Property(e => e.Inspectiontypemasterguid).IsUnicode(false);

                entity.Property(e => e.Objectversionno).HasPrecision(3);

                entity.Property(e => e.Oracleentityid).IsUnicode(false);

                entity.Property(e => e.Oracleentityname).IsUnicode(false);

                entity.Property(e => e.Pkguid).IsUnicode(false);

                entity.Property(e => e.Quickaccesscode).IsUnicode(false);

                entity.Property(e => e.Resultsmasterguid).IsUnicode(false);

                entity.Property(e => e.Userarchived).IsUnicode(false);

                entity.Property(e => e.Usercreated).IsUnicode(false);

                entity.Property(e => e.Userdeleted).IsUnicode(false);

                entity.Property(e => e.Userupdated).IsUnicode(false);
            });

            modelBuilder.Entity<InspectionscheduleV>(entity =>
            {
                entity.ToView("INSPECTIONSCHEDULE_V");

                entity.Property(e => e.Branchmasterguid).IsUnicode(false);

                entity.Property(e => e.CarCityName).IsUnicode(false);

                entity.Property(e => e.CarRegnNo).IsUnicode(false);

                entity.Property(e => e.Carmasterguid).IsUnicode(false);

                entity.Property(e => e.Guid).IsUnicode(false);

                entity.Property(e => e.Inspectionresultguid).IsUnicode(false);

                entity.Property(e => e.Inspecttype).IsUnicode(false);

                entity.Property(e => e.Pkguid).IsUnicode(false);

                entity.Property(e => e.Schedulestatusentityguid).IsUnicode(false);

                entity.Property(e => e.Slotno).HasPrecision(3);

                entity.Property(e => e.StatusCode).IsUnicode(false);

                entity.Property(e => e.StatusName).IsUnicode(false);

                entity.Property(e => e.Workshopmasterguid).IsUnicode(false);
            });

            modelBuilder.Entity<Inspectiontypemaster>(entity =>
            {
                entity.Property(e => e.Comments).IsUnicode(false);

                entity.Property(e => e.Description).IsUnicode(false);

                entity.Property(e => e.Disabled)
                    .HasPrecision(1)
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Guid).IsUnicode(false);

                entity.Property(e => e.Inspectioncategorymasterguid).IsUnicode(false);

                entity.Property(e => e.Name).IsUnicode(false);

                entity.Property(e => e.Objectversionno).HasPrecision(3);

                entity.Property(e => e.Oracleentityid).IsUnicode(false);

                entity.Property(e => e.Oracleentityname).IsUnicode(false);

                entity.Property(e => e.Pkguid).IsUnicode(false);

                entity.Property(e => e.Quickaccesscode).IsUnicode(false);

                entity.Property(e => e.Userarchived).IsUnicode(false);

                entity.Property(e => e.Usercreated).IsUnicode(false);

                entity.Property(e => e.Userdeleted).IsUnicode(false);

                entity.Property(e => e.Userupdated).IsUnicode(false);
            });

            modelBuilder.Entity<Interaction>(entity =>
            {
                entity.Property(e => e.Guid).IsUnicode(false);

                entity.Property(e => e.Interactionresult).IsUnicode(false);

                entity.Property(e => e.Interactiontype).IsUnicode(false);

                entity.Property(e => e.Leadmasterguid).IsUnicode(false);

                entity.Property(e => e.Objectversionno).HasPrecision(3);

                entity.Property(e => e.Oracleentityid).IsUnicode(false);

                entity.Property(e => e.Oracleentityname).IsUnicode(false);

                entity.Property(e => e.Pkguid).IsUnicode(false);

                entity.Property(e => e.Remarks).IsUnicode(false);

                entity.Property(e => e.Userarchived).IsUnicode(false);

                entity.Property(e => e.Usercreated).IsUnicode(false);

                entity.Property(e => e.Userdeleted).IsUnicode(false);

                entity.Property(e => e.Userupdated).IsUnicode(false);
            });

            modelBuilder.Entity<InteractionsBaseV>(entity =>
            {
                entity.ToView("INTERACTIONS_BASE_V");

                entity.Property(e => e.Backofficepersonid).IsUnicode(false);

                entity.Property(e => e.Contactsubtypeguid).IsUnicode(false);

                entity.Property(e => e.EntityCode).IsUnicode(false);

                entity.Property(e => e.Interactionguid).IsUnicode(false);

                entity.Property(e => e.Interactionobjectversionno).HasPrecision(3);

                entity.Property(e => e.Interactionoracleentityid).IsUnicode(false);

                entity.Property(e => e.Interactionoracleentityname).IsUnicode(false);

                entity.Property(e => e.Interactionpkguid).IsUnicode(false);

                entity.Property(e => e.Interactionremarks).IsUnicode(false);

                entity.Property(e => e.Interactionresult).IsUnicode(false);

                entity.Property(e => e.Interactiontype).IsUnicode(false);

                entity.Property(e => e.Leadbiometricid).IsUnicode(false);

                entity.Property(e => e.Leadcontactno).IsUnicode(false);

                entity.Property(e => e.Leadcountrycodeguid).IsUnicode(false);

                entity.Property(e => e.Leadfirstname).IsUnicode(false);

                entity.Property(e => e.Leadlastname).IsUnicode(false);

                entity.Property(e => e.Leadmasterguid).IsUnicode(false);

                entity.Property(e => e.Leadmiddlename).IsUnicode(false);

                entity.Property(e => e.Leadobjectversionno).HasPrecision(3);

                entity.Property(e => e.Leadoracleentityid).IsUnicode(false);

                entity.Property(e => e.Leadoracleentityname).IsUnicode(false);

                entity.Property(e => e.Leadpkguid).IsUnicode(false);

                entity.Property(e => e.Leadsourceguid).IsUnicode(false);

                entity.Property(e => e.Leadtitle).IsUnicode(false);

                entity.Property(e => e.Leadusercreated).IsUnicode(false);

                entity.Property(e => e.Personguid).IsUnicode(false);

                entity.Property(e => e.Probability).IsUnicode(false);

                entity.Property(e => e.Salesreppersonid).IsUnicode(false);

                entity.Property(e => e.StatusCode).IsUnicode(false);

                entity.Property(e => e.StatusDesc).IsUnicode(false);

                entity.Property(e => e.StatusEntEntguid).IsUnicode(false);

                entity.Property(e => e.StatusEntObjVerNo).HasPrecision(10);

                entity.Property(e => e.StatusEntStsguid).IsUnicode(false);

                entity.Property(e => e.StatusName).IsUnicode(false);

                entity.Property(e => e.Statusentityguid).IsUnicode(false);

                entity.Property(e => e.Userallowdomainlogin).IsUnicode(false);

                entity.Property(e => e.Usercontactnumber).IsUnicode(false);

                entity.Property(e => e.Usercreated).IsUnicode(false);

                entity.Property(e => e.Userculture).IsUnicode(false);

                entity.Property(e => e.Userdisabled).HasPrecision(1);

                entity.Property(e => e.Userdomainloginname).IsUnicode(false);

                entity.Property(e => e.Useremail).IsUnicode(false);

                entity.Property(e => e.Userfailedloginattempts).IsUnicode(false);

                entity.Property(e => e.Userfirstname).IsUnicode(false);

                entity.Property(e => e.Userlastname).IsUnicode(false);

                entity.Property(e => e.Userloginattempts).IsUnicode(false);

                entity.Property(e => e.Userobjectversionno).HasPrecision(10);

                entity.Property(e => e.Useroracleentityid).IsUnicode(false);

                entity.Property(e => e.Useroracleentityname).IsUnicode(false);

                entity.Property(e => e.Useroracleuserid).IsUnicode(false);

                entity.Property(e => e.Userpkguid).IsUnicode(false);

                entity.Property(e => e.Usertheme).IsUnicode(false);
            });

            modelBuilder.Entity<InteractionsV>(entity =>
            {
                entity.ToView("INTERACTIONS_V");

                entity.Property(e => e.Backofficepersonid).IsUnicode(false);

                entity.Property(e => e.Contactsubtypeguid).IsUnicode(false);

                entity.Property(e => e.EntityCode).IsUnicode(false);

                entity.Property(e => e.Interactionguid).IsUnicode(false);

                entity.Property(e => e.Interactionobjectversionno).HasPrecision(3);

                entity.Property(e => e.Interactionoracleentityid).IsUnicode(false);

                entity.Property(e => e.Interactionoracleentityname).IsUnicode(false);

                entity.Property(e => e.Interactionpkguid).IsUnicode(false);

                entity.Property(e => e.Interactionremarks).IsUnicode(false);

                entity.Property(e => e.Interactionresult).IsUnicode(false);

                entity.Property(e => e.Interactiontype).IsUnicode(false);

                entity.Property(e => e.Leadbiometricid).IsUnicode(false);

                entity.Property(e => e.Leadcontactno).IsUnicode(false);

                entity.Property(e => e.Leadcountrycodeguid).IsUnicode(false);

                entity.Property(e => e.Leadfirstname).IsUnicode(false);

                entity.Property(e => e.Leadlastname).IsUnicode(false);

                entity.Property(e => e.Leadmasterguid).IsUnicode(false);

                entity.Property(e => e.Leadmiddlename).IsUnicode(false);

                entity.Property(e => e.Leadobjectversionno).HasPrecision(3);

                entity.Property(e => e.Leadoracleentityid).IsUnicode(false);

                entity.Property(e => e.Leadoracleentityname).IsUnicode(false);

                entity.Property(e => e.Leadpkguid).IsUnicode(false);

                entity.Property(e => e.Leadsourceguid).IsUnicode(false);

                entity.Property(e => e.Leadtitle).IsUnicode(false);

                entity.Property(e => e.Leadusercreated).IsUnicode(false);

                entity.Property(e => e.Personguid).IsUnicode(false);

                entity.Property(e => e.Probability).IsUnicode(false);

                entity.Property(e => e.Salesreppersonid).IsUnicode(false);

                entity.Property(e => e.StatusCode).IsUnicode(false);

                entity.Property(e => e.StatusDesc).IsUnicode(false);

                entity.Property(e => e.StatusEntEntguid).IsUnicode(false);

                entity.Property(e => e.StatusEntObjVerNo).HasPrecision(10);

                entity.Property(e => e.StatusEntStsguid).IsUnicode(false);

                entity.Property(e => e.StatusName).IsUnicode(false);

                entity.Property(e => e.Statusentityguid).IsUnicode(false);

                entity.Property(e => e.Userallowdomainlogin).IsUnicode(false);

                entity.Property(e => e.Usercontactnumber).IsUnicode(false);

                entity.Property(e => e.Usercreated).IsUnicode(false);

                entity.Property(e => e.Userculture).IsUnicode(false);

                entity.Property(e => e.Userdisabled).HasPrecision(1);

                entity.Property(e => e.Userdomainloginname).IsUnicode(false);

                entity.Property(e => e.Useremail).IsUnicode(false);

                entity.Property(e => e.Userfailedloginattempts).IsUnicode(false);

                entity.Property(e => e.Userfirstname).IsUnicode(false);

                entity.Property(e => e.Userlastname).IsUnicode(false);

                entity.Property(e => e.Userloginattempts).IsUnicode(false);

                entity.Property(e => e.Userobjectversionno).HasPrecision(10);

                entity.Property(e => e.Useroracleentityid).IsUnicode(false);

                entity.Property(e => e.Useroracleentityname).IsUnicode(false);

                entity.Property(e => e.Useroracleuserid).IsUnicode(false);

                entity.Property(e => e.Userpkguid).IsUnicode(false);

                entity.Property(e => e.Usertheme).IsUnicode(false);
            });

            modelBuilder.Entity<InvoiceProgramexecution>(entity =>
            {
                entity.HasKey(e => e.Guid)
                    .HasName("SYS_C009962");

                entity.Property(e => e.Guid).IsUnicode(false);

                entity.Property(e => e.Errordescription).IsUnicode(false);

                entity.Property(e => e.Status).IsUnicode(false);

                entity.Property(e => e.Usercreated).IsUnicode(false);
            });

            modelBuilder.Entity<Issuemaster>(entity =>
            {
                entity.Property(e => e.Defaultsymptoms).IsUnicode(false);

                entity.Property(e => e.Guid).IsUnicode(false);

                entity.Property(e => e.Name).IsUnicode(false);

                entity.Property(e => e.Objectversionno).HasPrecision(3);

                entity.Property(e => e.Oracleentityid).IsUnicode(false);

                entity.Property(e => e.Oracleentityname).IsUnicode(false);

                entity.Property(e => e.Oracleentitytype).IsUnicode(false);

                entity.Property(e => e.Pkguid).IsUnicode(false);

                entity.Property(e => e.Userarchived).IsUnicode(false);

                entity.Property(e => e.Usercreated).IsUnicode(false);

                entity.Property(e => e.Userdeleted).IsUnicode(false);

                entity.Property(e => e.Userupdated).IsUnicode(false);
            });

            modelBuilder.Entity<JXmeruCabDailyStatus>(entity =>
            {
                entity.Property(e => e.JrnConsumed).IsUnicode(false);

                entity.Property(e => e.JrnFlag).IsUnicode(false);

                entity.Property(e => e.JrnSubscriber).IsUnicode(false);

                entity.Property(e => e.VehicleNum).IsUnicode(false);
            });

            modelBuilder.Entity<LeadBaseV>(entity =>
            {
                entity.ToView("LEAD_BASE_V");

                entity.Property(e => e.BackofficeEmployeeNumber)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.BackofficePersonId1)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.BackofficePersonName).IsUnicode(false);

                entity.Property(e => e.Backofficepersonid).IsUnicode(false);

                entity.Property(e => e.Biometricid).IsUnicode(false);

                entity.Property(e => e.Contactno).IsUnicode(false);

                entity.Property(e => e.Contactsubtypeguid).IsUnicode(false);

                entity.Property(e => e.Countrycodeguid).IsUnicode(false);

                entity.Property(e => e.Gender).IsUnicode(false);

                entity.Property(e => e.LeadEntityCode).IsUnicode(false);

                entity.Property(e => e.LeadFullname).IsUnicode(false);

                entity.Property(e => e.LeadStatusCode).IsUnicode(false);

                entity.Property(e => e.LeadStatusDesc).IsUnicode(false);

                entity.Property(e => e.LeadStatusEntStsguid).IsUnicode(false);

                entity.Property(e => e.LeadStatusName).IsUnicode(false);

                entity.Property(e => e.Leadmasterguid).IsUnicode(false);

                entity.Property(e => e.Leadsourceguid).IsUnicode(false);

                entity.Property(e => e.LebranchGuid).IsUnicode(false);

                entity.Property(e => e.NpwNumber)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.PersonType)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Personguid).IsUnicode(false);

                entity.Property(e => e.Pkguid).IsUnicode(false);

                entity.Property(e => e.PositionName)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Probability).IsUnicode(false);

                entity.Property(e => e.Salesreppersonid).IsUnicode(false);

                entity.Property(e => e.SourceComments).IsUnicode(false);

                entity.Property(e => e.SourceDescription).IsUnicode(false);

                entity.Property(e => e.SourceName).IsUnicode(false);

                entity.Property(e => e.SourceOracleentityid).IsUnicode(false);

                entity.Property(e => e.SourceOracleentityname).IsUnicode(false);

                entity.Property(e => e.SourcePkguid).IsUnicode(false);

                entity.Property(e => e.SourceQuickaccesscode).IsUnicode(false);

                entity.Property(e => e.StatusEntObjVerNo).HasPrecision(10);

                entity.Property(e => e.Statusentityguid).IsUnicode(false);

                entity.Property(e => e.Usercreated).IsUnicode(false);
            });

            modelBuilder.Entity<LeadV>(entity =>
            {
                entity.ToView("LEAD_V");

                entity.Property(e => e.BackofficeEmployeeNumber)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.BackofficePersonId1)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.BackofficePersonName).IsUnicode(false);

                entity.Property(e => e.Backofficepersonid).IsUnicode(false);

                entity.Property(e => e.Biometricid).IsUnicode(false);

                entity.Property(e => e.Contactno).IsUnicode(false);

                entity.Property(e => e.Contactsubtypeguid).IsUnicode(false);

                entity.Property(e => e.Countrycodeguid).IsUnicode(false);

                entity.Property(e => e.Gender).IsUnicode(false);

                entity.Property(e => e.LeadEntityCode).IsUnicode(false);

                entity.Property(e => e.LeadFullname).IsUnicode(false);

                entity.Property(e => e.LeadStatusCode).IsUnicode(false);

                entity.Property(e => e.LeadStatusDesc).IsUnicode(false);

                entity.Property(e => e.LeadStatusEntStsguid).IsUnicode(false);

                entity.Property(e => e.LeadStatusName).IsUnicode(false);

                entity.Property(e => e.Leadmasterguid).IsUnicode(false);

                entity.Property(e => e.Leadsourceguid).IsUnicode(false);

                entity.Property(e => e.LebranchGuid).IsUnicode(false);

                entity.Property(e => e.NpwNumber)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.PersonType)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Personguid).IsUnicode(false);

                entity.Property(e => e.Pkguid).IsUnicode(false);

                entity.Property(e => e.PositionName)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Probability).IsUnicode(false);

                entity.Property(e => e.Salesreppersonid).IsUnicode(false);

                entity.Property(e => e.SourceComments).IsUnicode(false);

                entity.Property(e => e.SourceDescription).IsUnicode(false);

                entity.Property(e => e.SourceName).IsUnicode(false);

                entity.Property(e => e.SourceOracleentityid).IsUnicode(false);

                entity.Property(e => e.SourceOracleentityname).IsUnicode(false);

                entity.Property(e => e.SourcePkguid).IsUnicode(false);

                entity.Property(e => e.SourceQuickaccesscode).IsUnicode(false);

                entity.Property(e => e.StatusEntObjVerNo).HasPrecision(10);

                entity.Property(e => e.Statusentityguid).IsUnicode(false);

                entity.Property(e => e.Usercreated).IsUnicode(false);
            });

            modelBuilder.Entity<Leadmaster>(entity =>
            {
                entity.Property(e => e.Backofficepersonid).IsUnicode(false);

                entity.Property(e => e.Biometricid).IsUnicode(false);

                entity.Property(e => e.Contactno).IsUnicode(false);

                entity.Property(e => e.Contactsubtypeguid).IsUnicode(false);

                entity.Property(e => e.Countrycodeguid).IsUnicode(false);

                entity.Property(e => e.Firstname).IsUnicode(false);

                entity.Property(e => e.Gender).IsUnicode(false);

                entity.Property(e => e.Guid).IsUnicode(false);

                entity.Property(e => e.Lastname).IsUnicode(false);

                entity.Property(e => e.Leadsourceguid).IsUnicode(false);

                entity.Property(e => e.LebranchGuid).IsUnicode(false);

                entity.Property(e => e.Middlename).IsUnicode(false);

                entity.Property(e => e.Objectversionno).HasPrecision(3);

                entity.Property(e => e.Oracleentityid).IsUnicode(false);

                entity.Property(e => e.Oracleentityname).IsUnicode(false);

                entity.Property(e => e.Personguid).IsUnicode(false);

                entity.Property(e => e.Pkguid).IsUnicode(false);

                entity.Property(e => e.Probability).IsUnicode(false);

                entity.Property(e => e.Salesreppersonid).IsUnicode(false);

                entity.Property(e => e.Statusentityguid).IsUnicode(false);

                entity.Property(e => e.Title).IsUnicode(false);

                entity.Property(e => e.Userarchived).IsUnicode(false);

                entity.Property(e => e.Usercreated).IsUnicode(false);

                entity.Property(e => e.Userdeleted).IsUnicode(false);

                entity.Property(e => e.Userupdated).IsUnicode(false);
            });

            modelBuilder.Entity<LeadmasterBaseV>(entity =>
            {
                entity.ToView("LEADMASTER_BASE_V");

                entity.Property(e => e.Backofficepersonid).IsUnicode(false);

                entity.Property(e => e.Biometricid).IsUnicode(false);

                entity.Property(e => e.Contactno).IsUnicode(false);

                entity.Property(e => e.Contactsubtypeguid).IsUnicode(false);

                entity.Property(e => e.Countrycodeguid).IsUnicode(false);

                entity.Property(e => e.Email).IsUnicode(false);

                entity.Property(e => e.EmailAddress).IsUnicode(false);

                entity.Property(e => e.EmployeeId)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.FullName).IsUnicode(false);

                entity.Property(e => e.LeadEntityCode).IsUnicode(false);

                entity.Property(e => e.LeadFullname).IsUnicode(false);

                entity.Property(e => e.LeadStatusCode).IsUnicode(false);

                entity.Property(e => e.LeadStatusDesc).IsUnicode(false);

                entity.Property(e => e.LeadStatusEntEntguid).IsUnicode(false);

                entity.Property(e => e.LeadStatusEntStsguid).IsUnicode(false);

                entity.Property(e => e.LeadStatusName).IsUnicode(false);

                entity.Property(e => e.Leadmasterguid).IsUnicode(false);

                entity.Property(e => e.Leadsourceguid).IsUnicode(false);

                entity.Property(e => e.LoginFullname).IsUnicode(false);

                entity.Property(e => e.Personguid).IsUnicode(false);

                entity.Property(e => e.Pkguid).IsUnicode(false);

                entity.Property(e => e.Probability).IsUnicode(false);

                entity.Property(e => e.Salesreppersonid).IsUnicode(false);

                entity.Property(e => e.StatusEntObjVerNo).HasPrecision(10);

                entity.Property(e => e.Statusentityguid).IsUnicode(false);

                entity.Property(e => e.UserId)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.UserName).IsUnicode(false);

                entity.Property(e => e.UserPkguid).IsUnicode(false);

                entity.Property(e => e.Userguid).IsUnicode(false);
            });

            modelBuilder.Entity<Leadsourcemaster>(entity =>
            {
                entity.Property(e => e.Comments).IsUnicode(false);

                entity.Property(e => e.Description).IsUnicode(false);

                entity.Property(e => e.Disabled).HasPrecision(1);

                entity.Property(e => e.Guid).IsUnicode(false);

                entity.Property(e => e.Name).IsUnicode(false);

                entity.Property(e => e.Objectversionno).HasPrecision(3);

                entity.Property(e => e.Oracleentityid).IsUnicode(false);

                entity.Property(e => e.Oracleentityname).IsUnicode(false);

                entity.Property(e => e.Pkguid).IsUnicode(false);

                entity.Property(e => e.Quickaccesscode).IsUnicode(false);

                entity.Property(e => e.Userarchived).IsUnicode(false);

                entity.Property(e => e.Usercreated).IsUnicode(false);

                entity.Property(e => e.Userdeleted).IsUnicode(false);

                entity.Property(e => e.Userupdated).IsUnicode(false);
            });

            modelBuilder.Entity<LebranchBaseV>(entity =>
            {
                entity.ToView("LEBRANCH_BASE_V");

                entity.Property(e => e.BranchCode).IsUnicode(false);

                entity.Property(e => e.BranchGuid).IsUnicode(false);

                entity.Property(e => e.BranchName).IsUnicode(false);

                entity.Property(e => e.GlSegment1).IsUnicode(false);

                entity.Property(e => e.LeCode).IsUnicode(false);

                entity.Property(e => e.LeGuid).IsUnicode(false);

                entity.Property(e => e.LeName).IsUnicode(false);

                entity.Property(e => e.LebObjVerNo).HasPrecision(10);

                entity.Property(e => e.LebranchGuid).IsUnicode(false);

                entity.Property(e => e.OrgId).HasPrecision(4);
            });

            modelBuilder.Entity<LebranchV>(entity =>
            {
                entity.ToView("LEBRANCH_V");

                entity.Property(e => e.BranchCode).IsUnicode(false);

                entity.Property(e => e.BranchGuid).IsUnicode(false);

                entity.Property(e => e.BranchName).IsUnicode(false);

                entity.Property(e => e.GlSegment1).IsUnicode(false);

                entity.Property(e => e.LeCode).IsUnicode(false);

                entity.Property(e => e.LeGuid).IsUnicode(false);

                entity.Property(e => e.LeName).IsUnicode(false);

                entity.Property(e => e.LebObjVerNo).HasPrecision(10);

                entity.Property(e => e.LebranchGuid).IsUnicode(false);

                entity.Property(e => e.OrgId).HasPrecision(4);
            });

            modelBuilder.Entity<Lebranchsecurity>(entity =>
            {
                entity.Property(e => e.Branchmasterguid).IsUnicode(false);

                entity.Property(e => e.Disabled).HasPrecision(1);

                entity.Property(e => e.Guid).IsUnicode(false);

                entity.Property(e => e.Legalentitymasterguid).IsUnicode(false);

                entity.Property(e => e.Objectversionno).HasPrecision(10);

                entity.Property(e => e.Oracleentityid).IsUnicode(false);

                entity.Property(e => e.Oracleentityname).IsUnicode(false);

                entity.Property(e => e.Orgid).HasPrecision(4);

                entity.Property(e => e.Pkguid).IsUnicode(false);

                entity.Property(e => e.Userarchived).IsUnicode(false);

                entity.Property(e => e.Usercreated).IsUnicode(false);

                entity.Property(e => e.Userdeleted).IsUnicode(false);

                entity.Property(e => e.Userupdated).IsUnicode(false);
            });

            modelBuilder.Entity<Legalentitymaster>(entity =>
            {
                entity.Property(e => e.Comments).IsUnicode(false);

                entity.Property(e => e.Description).IsUnicode(false);

                entity.Property(e => e.Disabled).HasPrecision(1);

                entity.Property(e => e.Guid).IsUnicode(false);

                entity.Property(e => e.Name).IsUnicode(false);

                entity.Property(e => e.Objectversionno).HasPrecision(10);

                entity.Property(e => e.Oracleentityid).IsUnicode(false);

                entity.Property(e => e.Oracleentityname).IsUnicode(false);

                entity.Property(e => e.Pkguid).IsUnicode(false);

                entity.Property(e => e.Quickaccesscode).IsUnicode(false);

                entity.Property(e => e.Showinverificationscreen)
                    .HasPrecision(1)
                    .HasDefaultValueSql("(1)");

                entity.Property(e => e.Userarchived).IsUnicode(false);

                entity.Property(e => e.Usercreated).IsUnicode(false);

                entity.Property(e => e.Userdeleted).IsUnicode(false);

                entity.Property(e => e.Userupdated).IsUnicode(false);
            });

            modelBuilder.Entity<Linqlogtable>(entity =>
            {
                entity.Property(e => e.Logtext).IsUnicode(false);
            });

            modelBuilder.Entity<LockExceptionBaseV>(entity =>
            {
                entity.ToView("LOCK_EXCEPTION_BASE_V");

                entity.Property(e => e.Branchmasterguid).IsUnicode(false);

                entity.Property(e => e.CarBrandCode).IsUnicode(false);

                entity.Property(e => e.CarBrandName).IsUnicode(false);

                entity.Property(e => e.CarChassisno).IsUnicode(false);

                entity.Property(e => e.CarCityCode).IsUnicode(false);

                entity.Property(e => e.CarGvguid).IsUnicode(false);

                entity.Property(e => e.CarLeBranchGuid).IsUnicode(false);

                entity.Property(e => e.CarLeCode).IsUnicode(false);

                entity.Property(e => e.CarMakeCode).IsUnicode(false);

                entity.Property(e => e.CarModelcode).IsUnicode(false);

                entity.Property(e => e.CarObjVerNo).HasPrecision(3);

                entity.Property(e => e.CarOpModelCode).IsUnicode(false);

                entity.Property(e => e.CarOwner).IsUnicode(false);

                entity.Property(e => e.CarOwnerSpid).IsUnicode(false);

                entity.Property(e => e.CarPkguid).IsUnicode(false);

                entity.Property(e => e.CarRegnNo).IsUnicode(false);

                entity.Property(e => e.CarSecGuid).IsUnicode(false);

                entity.Property(e => e.CarSecGuidLeCode).IsUnicode(false);

                entity.Property(e => e.CarStatusCode).IsUnicode(false);

                entity.Property(e => e.Carlockguid).IsUnicode(false);

                entity.Property(e => e.Carmasterguid).IsUnicode(false);

                entity.Property(e => e.Description).IsUnicode(false);

                entity.Property(e => e.Locationworkshopmasterguid).IsUnicode(false);

                entity.Property(e => e.Lockdetails).IsUnicode(false);

                entity.Property(e => e.LockexceptionEntityCode).IsUnicode(false);

                entity.Property(e => e.LockexceptionStatusCode).IsUnicode(false);

                entity.Property(e => e.LockexceptionStatusDesc).IsUnicode(false);

                entity.Property(e => e.LockexceptionStatusName).IsUnicode(false);

                entity.Property(e => e.Lockexceptionguid).IsUnicode(false);

                entity.Property(e => e.Lockname).IsUnicode(false);

                entity.Property(e => e.Lockreference).IsUnicode(false);

                entity.Property(e => e.Locktypemasterguid).IsUnicode(false);

                entity.Property(e => e.Objectversionno).HasPrecision(10);

                entity.Property(e => e.Pkguid).IsUnicode(false);

                entity.Property(e => e.Quickaccesscode).IsUnicode(false);

                entity.Property(e => e.Sourceentity).IsUnicode(false);

                entity.Property(e => e.SpPkguid).IsUnicode(false);

                entity.Property(e => e.Spguid).IsUnicode(false);

                entity.Property(e => e.StatusEntEntguid).IsUnicode(false);

                entity.Property(e => e.StatusEntObjVerNo).HasPrecision(10);

                entity.Property(e => e.StatusEntStsguid).IsUnicode(false);

                entity.Property(e => e.Statuscolor).IsUnicode(false);

                entity.Property(e => e.Statusentityguid).IsUnicode(false);

                entity.Property(e => e.Workshopmasterguid).IsUnicode(false);

                entity.Property(e => e.Workshoppkguid).IsUnicode(false);

                entity.Property(e => e.Workshopquickaccesscode).IsUnicode(false);
            });

            modelBuilder.Entity<LockExceptionV>(entity =>
            {
                entity.ToView("LOCK_EXCEPTION_V");

                entity.Property(e => e.Branchmasterguid).IsUnicode(false);

                entity.Property(e => e.CarBrandCode).IsUnicode(false);

                entity.Property(e => e.CarBrandName).IsUnicode(false);

                entity.Property(e => e.CarChassisno).IsUnicode(false);

                entity.Property(e => e.CarCityCode).IsUnicode(false);

                entity.Property(e => e.CarGvguid).IsUnicode(false);

                entity.Property(e => e.CarLeBranchGuid).IsUnicode(false);

                entity.Property(e => e.CarLeCode).IsUnicode(false);

                entity.Property(e => e.CarMakeCode).IsUnicode(false);

                entity.Property(e => e.CarModelcode).IsUnicode(false);

                entity.Property(e => e.CarObjVerNo).HasPrecision(3);

                entity.Property(e => e.CarOpModelCode).IsUnicode(false);

                entity.Property(e => e.CarOwner).IsUnicode(false);

                entity.Property(e => e.CarOwnerSpid).IsUnicode(false);

                entity.Property(e => e.CarPkguid).IsUnicode(false);

                entity.Property(e => e.CarRegnNo).IsUnicode(false);

                entity.Property(e => e.CarSecGuid).IsUnicode(false);

                entity.Property(e => e.CarSecGuidLeCode).IsUnicode(false);

                entity.Property(e => e.CarStatusCode).IsUnicode(false);

                entity.Property(e => e.Carlockguid).IsUnicode(false);

                entity.Property(e => e.Carmasterguid).IsUnicode(false);

                entity.Property(e => e.Description).IsUnicode(false);

                entity.Property(e => e.Locationworkshopmasterguid).IsUnicode(false);

                entity.Property(e => e.Lockdetails).IsUnicode(false);

                entity.Property(e => e.LockexceptionEntityCode).IsUnicode(false);

                entity.Property(e => e.LockexceptionStatusCode).IsUnicode(false);

                entity.Property(e => e.LockexceptionStatusDesc).IsUnicode(false);

                entity.Property(e => e.LockexceptionStatusName).IsUnicode(false);

                entity.Property(e => e.Lockexceptionguid).IsUnicode(false);

                entity.Property(e => e.Lockname).IsUnicode(false);

                entity.Property(e => e.Lockreference).IsUnicode(false);

                entity.Property(e => e.Locktypemasterguid).IsUnicode(false);

                entity.Property(e => e.Objectversionno).HasPrecision(10);

                entity.Property(e => e.Pkguid).IsUnicode(false);

                entity.Property(e => e.Quickaccesscode).IsUnicode(false);

                entity.Property(e => e.Sourceentity).IsUnicode(false);

                entity.Property(e => e.SpPkguid).IsUnicode(false);

                entity.Property(e => e.Spguid).IsUnicode(false);

                entity.Property(e => e.StatusEntEntguid).IsUnicode(false);

                entity.Property(e => e.StatusEntObjVerNo).HasPrecision(10);

                entity.Property(e => e.StatusEntStsguid).IsUnicode(false);

                entity.Property(e => e.Statuscolor).IsUnicode(false);

                entity.Property(e => e.Statusentityguid).IsUnicode(false);

                entity.Property(e => e.Workshopmasterguid).IsUnicode(false);

                entity.Property(e => e.Workshoppkguid).IsUnicode(false);

                entity.Property(e => e.Workshopquickaccesscode).IsUnicode(false);
            });

            modelBuilder.Entity<LockExecutionLog>(entity =>
            {
                entity.Property(e => e.BranchGuid).IsUnicode(false);

                entity.Property(e => e.PrcedureName).IsUnicode(false);

                entity.Property(e => e.Status).IsUnicode(false);
            });

            modelBuilder.Entity<Lockexception>(entity =>
            {
                entity.Property(e => e.Carmasterguid).IsUnicode(false);

                entity.Property(e => e.Guid).IsUnicode(false);

                entity.Property(e => e.Lockdetails).IsUnicode(false);

                entity.Property(e => e.Lockguid).IsUnicode(false);

                entity.Property(e => e.Lockreference).IsUnicode(false);

                entity.Property(e => e.Locktypemasterguid).IsUnicode(false);

                entity.Property(e => e.Pkguid).IsUnicode(false);

                entity.Property(e => e.Sourceentity).IsUnicode(false);

                entity.Property(e => e.Statusentityguid).IsUnicode(false);
            });

            modelBuilder.Entity<Lockreasonmaster>(entity =>
            {
                entity.Property(e => e.Disabled).HasPrecision(1);

                entity.Property(e => e.Guid).IsUnicode(false);

                entity.Property(e => e.Lockstatus).IsUnicode(false);

                entity.Property(e => e.Reason).IsUnicode(false);
            });

            modelBuilder.Entity<Locktypemaster>(entity =>
            {
                entity.Property(e => e.Comments).IsUnicode(false);

                entity.Property(e => e.Description).IsUnicode(false);

                entity.Property(e => e.Disabled).HasPrecision(1);

                entity.Property(e => e.Guid).IsUnicode(false);

                entity.Property(e => e.Lockname).IsUnicode(false);

                entity.Property(e => e.Objectversionno).HasPrecision(10);

                entity.Property(e => e.Oracleentityid).IsUnicode(false);

                entity.Property(e => e.Oracleentityname).IsUnicode(false);

                entity.Property(e => e.Pkguid).IsUnicode(false);

                entity.Property(e => e.Quickaccesscode).IsUnicode(false);

                entity.Property(e => e.Statuscolor).IsUnicode(false);

                entity.Property(e => e.Userarchived).IsUnicode(false);

                entity.Property(e => e.Usercreated).IsUnicode(false);

                entity.Property(e => e.Userdeleted).IsUnicode(false);

                entity.Property(e => e.Userupdated).IsUnicode(false);
            });

            modelBuilder.Entity<ManthanCarOffRoad>(entity =>
            {
                entity.ToView("MANTHAN_CAR_OFF_ROAD");

                entity.Property(e => e.Cabregistrationno).IsUnicode(false);
            });

            modelBuilder.Entity<ManthanCarOffRoadV>(entity =>
            {
                entity.ToView("MANTHAN_CAR_OFF_ROAD_V");

                entity.Property(e => e.Cabregistrationno).IsUnicode(false);
            });

            modelBuilder.Entity<ManthanCarTerminated>(entity =>
            {
                entity.ToView("MANTHAN_CAR_TERMINATED");

                entity.Property(e => e.Cabregistrationno).IsUnicode(false);
            });

            modelBuilder.Entity<ManthanCarTerminatedV>(entity =>
            {
                entity.ToView("MANTHAN_CAR_TERMINATED_V");

                entity.Property(e => e.Cabregistrationno).IsUnicode(false);
            });

            modelBuilder.Entity<ManthanDriverAttachedV>(entity =>
            {
                entity.ToView("MANTHAN_DRIVER_ATTACHED_V");

                entity.Property(e => e.Allocationdatetime).IsUnicode(false);

                entity.Property(e => e.Brandtype).IsUnicode(false);

                entity.Property(e => e.Bussniesmodel).IsUnicode(false);

                entity.Property(e => e.Cabregistrationno).IsUnicode(false);

                entity.Property(e => e.Cardriverguid).IsUnicode(false);

                entity.Property(e => e.Cityname).HasPrecision(3);

                entity.Property(e => e.Driverid).IsUnicode(false);

                entity.Property(e => e.Driverlastname).IsUnicode(false);

                entity.Property(e => e.Drivermiddlename).IsUnicode(false);

                entity.Property(e => e.Drivermobileno).IsUnicode(false);

                entity.Property(e => e.Drivername).IsUnicode(false);

                entity.Property(e => e.Spid).IsUnicode(false);
            });

            modelBuilder.Entity<ManthanDriverDetachedV>(entity =>
            {
                entity.ToView("MANTHAN_DRIVER_DETACHED_V");

                entity.Property(e => e.Cabregistrationno).IsUnicode(false);

                entity.Property(e => e.Cardriverguid).IsUnicode(false);

                entity.Property(e => e.Driverid).IsUnicode(false);
            });

            modelBuilder.Entity<ManthanLockUnlockV>(entity =>
            {
                entity.ToView("MANTHAN_LOCK_UNLOCK_V");

                entity.Property(e => e.Cabregistrationno).IsUnicode(false);

                entity.Property(e => e.Doneby)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Reason).IsUnicode(false);
            });

            modelBuilder.Entity<ManthanOnroadDeviceV>(entity =>
            {
                entity.ToView("MANTHAN_ONROAD_DEVICE_V");

                entity.Property(e => e.Actualcity).IsUnicode(false);

                entity.Property(e => e.Actualstate).IsUnicode(false);

                entity.Property(e => e.Allocationdatetime).IsUnicode(false);

                entity.Property(e => e.Anchorlocationid).IsUnicode(false);

                entity.Property(e => e.Brandtype).IsUnicode(false);

                entity.Property(e => e.Bussniesmodel).IsUnicode(false);

                entity.Property(e => e.Cabcolor).IsUnicode(false);

                entity.Property(e => e.Cabcompanyname).IsUnicode(false);

                entity.Property(e => e.Cabmodelname).IsUnicode(false);

                entity.Property(e => e.Cabregistrationno).IsUnicode(false);

                entity.Property(e => e.Cabyearmake).IsUnicode(false);

                entity.Property(e => e.Chasisno).IsUnicode(false);

                entity.Property(e => e.Cityname).HasPrecision(3);

                entity.Property(e => e.Emailid)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Engineno).IsUnicode(false);

                entity.Property(e => e.Paytmqrcode).IsUnicode(false);

                entity.Property(e => e.Permittype).IsUnicode(false);

                entity.Property(e => e.Primarybusinesscategory).IsUnicode(false);

                entity.Property(e => e.Registrationdate).IsUnicode(false);

                entity.Property(e => e.Shiftid).IsUnicode(false);

                entity.Property(e => e.Siebeldeviceno).IsUnicode(false);

                entity.Property(e => e.Simcardno).IsUnicode(false);

                entity.Property(e => e.Spaddress).IsUnicode(false);

                entity.Property(e => e.Spcontactno).IsUnicode(false);

                entity.Property(e => e.Spid).IsUnicode(false);

                entity.Property(e => e.Spname).IsUnicode(false);
            });

            modelBuilder.Entity<ManthanOnroadDriverV>(entity =>
            {
                entity.ToView("MANTHAN_ONROAD_DRIVER_V");

                entity.Property(e => e.Brandtype).IsUnicode(false);

                entity.Property(e => e.Bussniesmodel).IsUnicode(false);

                entity.Property(e => e.Cabcompanyname).IsUnicode(false);

                entity.Property(e => e.Cabmodelname).IsUnicode(false);

                entity.Property(e => e.Cabregistrationno).IsUnicode(false);

                entity.Property(e => e.Chasisno).IsUnicode(false);

                entity.Property(e => e.Cityname).HasPrecision(3);

                entity.Property(e => e.Emailid)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Engineno).IsUnicode(false);

                entity.Property(e => e.Siebelsubscriberid).IsUnicode(false);

                entity.Property(e => e.Spid).IsUnicode(false);

                entity.Property(e => e.Subscriberfirstname).IsUnicode(false);

                entity.Property(e => e.Subscriberlastname).IsUnicode(false);

                entity.Property(e => e.Subscribermiddlename).IsUnicode(false);

                entity.Property(e => e.Subscribermobileno).IsUnicode(false);
            });

            modelBuilder.Entity<ManthanOnroadV>(entity =>
            {
                entity.ToView("MANTHAN_ONROAD_V");

                entity.Property(e => e.Brandtype).IsUnicode(false);

                entity.Property(e => e.Bussniesmodel).IsUnicode(false);

                entity.Property(e => e.Cabcompanyname).IsUnicode(false);

                entity.Property(e => e.Cabmodelname).IsUnicode(false);

                entity.Property(e => e.Cabregistrationno).IsUnicode(false);

                entity.Property(e => e.Chasisno).IsUnicode(false);

                entity.Property(e => e.Cityname).IsUnicode(false);

                entity.Property(e => e.Emailid)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Engineno).IsUnicode(false);

                entity.Property(e => e.Siebeldeviceno).IsUnicode(false);

                entity.Property(e => e.Siebelsubscriberid).IsUnicode(false);

                entity.Property(e => e.Simcardno).IsUnicode(false);

                entity.Property(e => e.Spid).IsUnicode(false);

                entity.Property(e => e.Subscriberfirstname).IsUnicode(false);

                entity.Property(e => e.Subscriberlastname).IsUnicode(false);

                entity.Property(e => e.Subscribermiddlename).IsUnicode(false);

                entity.Property(e => e.Subscribermobileno).IsUnicode(false);
            });

            modelBuilder.Entity<ManthanPersonTerminatedV>(entity =>
            {
                entity.ToView("MANTHAN_PERSON_TERMINATED_V");

                entity.Property(e => e.Driverflag).HasPrecision(1);

                entity.Property(e => e.Driverid).IsUnicode(false);

                entity.Property(e => e.Dseflag).HasPrecision(1);

                entity.Property(e => e.Spflag).HasPrecision(1);
            });

            modelBuilder.Entity<ManualCreditlimitDetail>(entity =>
            {
                entity.Property(e => e.Remark).IsUnicode(false);

                entity.Property(e => e.Sitename).IsUnicode(false);

                entity.Property(e => e.Spid).IsUnicode(false);

                entity.Property(e => e.Status).IsUnicode(false);

                entity.Property(e => e.Usercreated).IsUnicode(false);
            });

            modelBuilder.Entity<ManualLockDetail>(entity =>
            {
                entity.Property(e => e.Branchguid).IsUnicode(false);

                entity.Property(e => e.Carbranch).IsUnicode(false);

                entity.Property(e => e.Carguid).IsUnicode(false);

                entity.Property(e => e.Carleguid).IsUnicode(false);

                entity.Property(e => e.Enableflag).IsUnicode(false);

                entity.Property(e => e.ExecutionGuid).IsUnicode(false);

                entity.Property(e => e.Roleguid).IsUnicode(false);

                entity.Property(e => e.SecGuid).IsUnicode(false);

                entity.Property(e => e.Siteguid).IsUnicode(false);

                entity.Property(e => e.Sitename).IsUnicode(false);

                entity.Property(e => e.Spid).IsUnicode(false);

                entity.Property(e => e.Status).IsUnicode(false);

                entity.Property(e => e.Usercreated).IsUnicode(false);

                entity.Property(e => e.Userguid).IsUnicode(false);

                entity.Property(e => e.Userleguid).IsUnicode(false);
            });

            modelBuilder.Entity<MentorPersonV>(entity =>
            {
                entity.ToView("MENTOR_PERSON_V");

                entity.Property(e => e.EmployeeNumber)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.FullName).IsUnicode(false);

                entity.Property(e => e.Id)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.NpwNumber)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.OrganizationId)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.PersonType)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.PositionId)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.PositionName)
                    .IsUnicode(false)
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<MentorV>(entity =>
            {
                entity.ToView("MENTOR_V");

                entity.Property(e => e.FullName).IsUnicode(false);

                entity.Property(e => e.Guid).IsUnicode(false);

                entity.Property(e => e.PositionName).IsUnicode(false);
            });

            modelBuilder.Entity<Menumaster>(entity =>
            {
                entity.Property(e => e.Applicationpagemasterguid).IsUnicode(false);

                entity.Property(e => e.Comments).IsUnicode(false);

                entity.Property(e => e.Datecreated).HasPrecision(6);

                entity.Property(e => e.Dateupdated).HasPrecision(6);

                entity.Property(e => e.Description).IsUnicode(false);

                entity.Property(e => e.Disabled).HasPrecision(1);

                entity.Property(e => e.Guid).IsUnicode(false);

                entity.Property(e => e.Name).IsUnicode(false);

                entity.Property(e => e.Objectversionno).HasPrecision(10);

                entity.Property(e => e.Oracleentityid).IsUnicode(false);

                entity.Property(e => e.Oracleentityname).IsUnicode(false);

                entity.Property(e => e.Orderno).HasPrecision(10);

                entity.Property(e => e.Parentmenuguid).IsUnicode(false);

                entity.Property(e => e.Pkguid).IsUnicode(false);

                entity.Property(e => e.Quickaccesscode).IsUnicode(false);

                entity.Property(e => e.Userarchived).IsUnicode(false);

                entity.Property(e => e.Usercreated).IsUnicode(false);

                entity.Property(e => e.Userdeleted).IsUnicode(false);

                entity.Property(e => e.Userupdated).IsUnicode(false);
            });

            modelBuilder.Entity<MenumasterBaseV>(entity =>
            {
                entity.ToView("MENUMASTER_BASE_V");

                entity.Property(e => e.AppPageComments).IsUnicode(false);

                entity.Property(e => e.AppPageDescription).IsUnicode(false);

                entity.Property(e => e.AppPageDisabled).HasPrecision(1);

                entity.Property(e => e.AppPageName).IsUnicode(false);

                entity.Property(e => e.AppPageObjectversionno).HasPrecision(10);

                entity.Property(e => e.AppPageOracleentityid).IsUnicode(false);

                entity.Property(e => e.AppPageOracleentityname).IsUnicode(false);

                entity.Property(e => e.AppPagePkguid).IsUnicode(false);

                entity.Property(e => e.AppPageQuickaccesscode).IsUnicode(false);

                entity.Property(e => e.Applicationpagemasterguid).IsUnicode(false);

                entity.Property(e => e.Menucomments).IsUnicode(false);

                entity.Property(e => e.Menudescription).IsUnicode(false);

                entity.Property(e => e.Menudisabled).HasPrecision(1);

                entity.Property(e => e.Menumasterguid).IsUnicode(false);

                entity.Property(e => e.Menuname).IsUnicode(false);

                entity.Property(e => e.Menuobjectversionno).HasPrecision(10);

                entity.Property(e => e.Menuoracleentityid).IsUnicode(false);

                entity.Property(e => e.Menuoracleentityname).IsUnicode(false);

                entity.Property(e => e.Menuquickaccesscode).IsUnicode(false);

                entity.Property(e => e.Orderno).HasPrecision(10);

                entity.Property(e => e.Parentmenuguid).IsUnicode(false);

                entity.Property(e => e.Pkguid).IsUnicode(false);
            });

            modelBuilder.Entity<MenumasterV>(entity =>
            {
                entity.ToView("MENUMASTER_V");

                entity.Property(e => e.AppPageComments).IsUnicode(false);

                entity.Property(e => e.AppPageDescription).IsUnicode(false);

                entity.Property(e => e.AppPageDisabled).HasPrecision(1);

                entity.Property(e => e.AppPageName).IsUnicode(false);

                entity.Property(e => e.AppPageObjectversionno).HasPrecision(10);

                entity.Property(e => e.AppPageOracleentityid).IsUnicode(false);

                entity.Property(e => e.AppPageOracleentityname).IsUnicode(false);

                entity.Property(e => e.AppPagePkguid).IsUnicode(false);

                entity.Property(e => e.AppPageQuickaccesscode).IsUnicode(false);

                entity.Property(e => e.Applicationpagemasterguid).IsUnicode(false);

                entity.Property(e => e.Menucomments).IsUnicode(false);

                entity.Property(e => e.Menudescription).IsUnicode(false);

                entity.Property(e => e.Menudisabled).HasPrecision(1);

                entity.Property(e => e.Menumasterguid).IsUnicode(false);

                entity.Property(e => e.Menuname).IsUnicode(false);

                entity.Property(e => e.Menuobjectversionno).HasPrecision(10);

                entity.Property(e => e.Menuoracleentityid).IsUnicode(false);

                entity.Property(e => e.Menuoracleentityname).IsUnicode(false);

                entity.Property(e => e.Menuquickaccesscode).IsUnicode(false);

                entity.Property(e => e.Orderno).HasPrecision(10);

                entity.Property(e => e.Parentmenuguid).IsUnicode(false);

                entity.Property(e => e.Pkguid).IsUnicode(false);
            });

            modelBuilder.Entity<Meruwebsitefeedbackdetail>(entity =>
            {
                entity.Property(e => e.Actiontakendatetime).HasPrecision(6);

                entity.Property(e => e.Bookingreferenceno).IsUnicode(false);

                entity.Property(e => e.Complainttakenuser).IsUnicode(false);

                entity.Property(e => e.Createddate).HasPrecision(6);

                entity.Property(e => e.Feedbackdetails).IsUnicode(false);

                entity.Property(e => e.Guid).IsUnicode(false);

                entity.Property(e => e.Remarks).IsUnicode(false);
            });

            modelBuilder.Entity<MeterCalibrationV>(entity =>
            {
                entity.ToView("METER_CALIBRATION_V");

                entity.Property(e => e.CarGuid).IsUnicode(false);

                entity.Property(e => e.DocGuid).IsUnicode(false);
            });

            modelBuilder.Entity<Modelmaster>(entity =>
            {
                entity.Property(e => e.Comments).IsUnicode(false);

                entity.Property(e => e.Description).IsUnicode(false);

                entity.Property(e => e.Disabled).HasPrecision(1);

                entity.Property(e => e.Guid).IsUnicode(false);

                entity.Property(e => e.Manthanmodeltype).IsUnicode(false);

                entity.Property(e => e.Name).IsUnicode(false);

                entity.Property(e => e.Objectversionno).HasPrecision(10);

                entity.Property(e => e.Oracleentityid).IsUnicode(false);

                entity.Property(e => e.Oracleentityname).IsUnicode(false);

                entity.Property(e => e.Pkguid).IsUnicode(false);

                entity.Property(e => e.Quickaccesscode).IsUnicode(false);

                entity.Property(e => e.Showinverificationscreen)
                    .HasPrecision(1)
                    .HasDefaultValueSql("(1)");

                entity.Property(e => e.Userarchived).IsUnicode(false);

                entity.Property(e => e.Usercreated).IsUnicode(false);

                entity.Property(e => e.Userdeleted).IsUnicode(false);

                entity.Property(e => e.Userupdated).IsUnicode(false);
            });

            modelBuilder.Entity<NetosV>(entity =>
            {
                entity.ToView("NETOS_V");

                entity.Property(e => e.Siteguid).IsUnicode(false);
            });

            modelBuilder.Entity<Odometerreading>(entity =>
            {
                entity.Property(e => e.Carguid).IsUnicode(false);

                entity.Property(e => e.Carpkguid).IsUnicode(false);

                entity.Property(e => e.Comments).IsUnicode(false);

                entity.Property(e => e.Disabled).HasPrecision(1);

                entity.Property(e => e.Guid).IsUnicode(false);

                entity.Property(e => e.Objectversionno).HasPrecision(10);

                entity.Property(e => e.Odomterreading).IsUnicode(false);

                entity.Property(e => e.Oracleentityid).IsUnicode(false);

                entity.Property(e => e.Oracleentityname).IsUnicode(false);

                entity.Property(e => e.Pkguid).IsUnicode(false);

                entity.Property(e => e.Userarchived).IsUnicode(false);

                entity.Property(e => e.Usercreated).IsUnicode(false);

                entity.Property(e => e.Userdeleted).IsUnicode(false);

                entity.Property(e => e.Userupdated).IsUnicode(false);
            });

            modelBuilder.Entity<OutstandingHistV>(entity =>
            {
                entity.ToView("OUTSTANDING_HIST_V");

                entity.Property(e => e.BrandName).IsUnicode(false);

                entity.Property(e => e.CarStatus).IsUnicode(false);

                entity.Property(e => e.CityName).IsUnicode(false);

                entity.Property(e => e.Contactno).IsUnicode(false);

                entity.Property(e => e.Driverflag).HasPrecision(1);

                entity.Property(e => e.Dseflag).HasPrecision(1);

                entity.Property(e => e.Firstname).IsUnicode(false);

                entity.Property(e => e.Lastname).IsUnicode(false);

                entity.Property(e => e.LeName).IsUnicode(false);

                entity.Property(e => e.ModelName).IsUnicode(false);

                entity.Property(e => e.Personid).IsUnicode(false);

                entity.Property(e => e.Pmguid).IsUnicode(false);

                entity.Property(e => e.Reguid).IsUnicode(false);

                entity.Property(e => e.Securitycombinationguid).IsUnicode(false);

                entity.Property(e => e.SiteStatus).IsUnicode(false);

                entity.Property(e => e.Siteguid).IsUnicode(false);

                entity.Property(e => e.Sitename).IsUnicode(false);

                entity.Property(e => e.Spflag).HasPrecision(1);

                entity.Property(e => e.Spguid).IsUnicode(false);
            });

            modelBuilder.Entity<OutstationTxn>(entity =>
            {
                entity.HasKey(e => e.Guid)
                    .HasName("SYS_C0074210");

                entity.Property(e => e.Guid).IsUnicode(false);

                entity.Property(e => e.Datecreated).HasDefaultValueSql("sysdate");

                entity.Property(e => e.Jobid).IsUnicode(false);

                entity.Property(e => e.Merupaymentid).IsUnicode(false);

                entity.Property(e => e.Serviceprovider).IsUnicode(false);

                entity.Property(e => e.Transactionid).HasPrecision(12);

                entity.Property(e => e.Transactiontype).IsUnicode(false);
            });

            modelBuilder.Entity<OxygenTbl1>(entity =>
            {
                entity.Property(e => e.CarNo).IsUnicode(false);

                entity.Property(e => e.Guid).IsUnicode(false);

                entity.Property(e => e.MerchantId).IsUnicode(false);

                entity.Property(e => e.Spid).IsUnicode(false);

                entity.Property(e => e.Status).IsUnicode(false);

                entity.Property(e => e.TransactionSource).IsUnicode(false);

                entity.Property(e => e.UniqueTransactionId).IsUnicode(false);
            });

            modelBuilder.Entity<OxygenTbl2>(entity =>
            {
                entity.Property(e => e.CarNo).IsUnicode(false);

                entity.Property(e => e.Carguid).IsUnicode(false);

                entity.Property(e => e.Guid).IsUnicode(false);

                entity.Property(e => e.SecGuid).IsUnicode(false);

                entity.Property(e => e.Siteguid).IsUnicode(false);

                entity.Property(e => e.SpGuid).IsUnicode(false);

                entity.Property(e => e.Spid).IsUnicode(false);

                entity.Property(e => e.Status).IsUnicode(false);

                entity.Property(e => e.TransactionId).IsUnicode(false);

                entity.Property(e => e.TransactionNo).IsUnicode(false);

                entity.Property(e => e.TransactionSource).IsUnicode(false);

                entity.Property(e => e.UniqueTransactionId).IsUnicode(false);
            });

            modelBuilder.Entity<Pageactionmaster>(entity =>
            {
                entity.Property(e => e.Comments).IsUnicode(false);

                entity.Property(e => e.Description).IsUnicode(false);

                entity.Property(e => e.Disabled).HasPrecision(1);

                entity.Property(e => e.Guid).IsUnicode(false);

                entity.Property(e => e.Name).IsUnicode(false);

                entity.Property(e => e.Objectversionno).HasPrecision(10);

                entity.Property(e => e.Oracleentityid).IsUnicode(false);

                entity.Property(e => e.Oracleentityname).IsUnicode(false);

                entity.Property(e => e.Pkguid).IsUnicode(false);

                entity.Property(e => e.Quickaccesscode).IsUnicode(false);

                entity.Property(e => e.Userarchived).IsUnicode(false);

                entity.Property(e => e.Usercreated).IsUnicode(false);

                entity.Property(e => e.Userdeleted).IsUnicode(false);

                entity.Property(e => e.Userupdated).IsUnicode(false);
            });

            modelBuilder.Entity<Parametermaster>(entity =>
            {
                entity.Property(e => e.Comments).IsUnicode(false);

                entity.Property(e => e.Description).IsUnicode(false);

                entity.Property(e => e.Disabled).HasPrecision(1);

                entity.Property(e => e.Guid).IsUnicode(false);

                entity.Property(e => e.Name).IsUnicode(false);

                entity.Property(e => e.Objectversionno).HasPrecision(10);

                entity.Property(e => e.Oracleentityid).IsUnicode(false);

                entity.Property(e => e.Oracleentityname).IsUnicode(false);

                entity.Property(e => e.Pkguid).IsUnicode(false);

                entity.Property(e => e.Quickaccesscode).IsUnicode(false);

                entity.Property(e => e.Userarchived).IsUnicode(false);

                entity.Property(e => e.Usercreated).IsUnicode(false);

                entity.Property(e => e.Userdeleted).IsUnicode(false);

                entity.Property(e => e.Userupdated).IsUnicode(false);
            });

            modelBuilder.Entity<PerCancelledChequeV>(entity =>
            {
                entity.ToView("PER_CANCELLED_CHEQUE_V");

                entity.Property(e => e.DocFileName).IsUnicode(false);

                entity.Property(e => e.DocGuid).IsUnicode(false);

                entity.Property(e => e.DocNo).IsUnicode(false);

                entity.Property(e => e.DocObjVerNo).HasPrecision(10);

                entity.Property(e => e.DocPurpose).IsUnicode(false);

                entity.Property(e => e.DocPurposeCode).IsUnicode(false);

                entity.Property(e => e.DocStatusCode).IsUnicode(false);

                entity.Property(e => e.DocStatusName).IsUnicode(false);

                entity.Property(e => e.DocType).IsUnicode(false);

                entity.Property(e => e.DocTypeCode).IsUnicode(false);

                entity.Property(e => e.Escalationdays).HasPrecision(10);

                entity.Property(e => e.PersFname).IsUnicode(false);

                entity.Property(e => e.PersGuid).IsUnicode(false);

                entity.Property(e => e.PersLname).IsUnicode(false);

                entity.Property(e => e.PersMname).IsUnicode(false);

                entity.Property(e => e.PersonId).IsUnicode(false);

                entity.Property(e => e.Renewaldays).HasPrecision(10);
            });

            modelBuilder.Entity<Permittype>(entity =>
            {
                entity.Property(e => e.Description).IsUnicode(false);

                entity.Property(e => e.Disabled).HasPrecision(1);

                entity.Property(e => e.Guid).IsUnicode(false);

                entity.Property(e => e.Name).IsUnicode(false);

                entity.Property(e => e.Quickaccesscode).IsUnicode(false);
            });

            modelBuilder.Entity<PersdocAadhaarV>(entity =>
            {
                entity.ToView("PERSDOC_AADHAAR_V");

                entity.Property(e => e.DocFileName).IsUnicode(false);

                entity.Property(e => e.DocGuid).IsUnicode(false);

                entity.Property(e => e.DocNo).IsUnicode(false);

                entity.Property(e => e.DocObjVerNo).HasPrecision(10);

                entity.Property(e => e.DocPurpose).IsUnicode(false);

                entity.Property(e => e.DocPurposeCode).IsUnicode(false);

                entity.Property(e => e.DocStatusCode).IsUnicode(false);

                entity.Property(e => e.DocStatusName).IsUnicode(false);

                entity.Property(e => e.DocType).IsUnicode(false);

                entity.Property(e => e.DocTypeCode).IsUnicode(false);

                entity.Property(e => e.Escalationdays).HasPrecision(10);

                entity.Property(e => e.PersFname).IsUnicode(false);

                entity.Property(e => e.PersGuid).IsUnicode(false);

                entity.Property(e => e.PersLname).IsUnicode(false);

                entity.Property(e => e.PersMname).IsUnicode(false);

                entity.Property(e => e.PersonId).IsUnicode(false);

                entity.Property(e => e.Renewaldays).HasPrecision(10);
            });

            modelBuilder.Entity<PersdocAgreementV>(entity =>
            {
                entity.ToView("PERSDOC_AGREEMENT_V");

                entity.Property(e => e.DocFileName).IsUnicode(false);

                entity.Property(e => e.DocGuid).IsUnicode(false);

                entity.Property(e => e.DocNo).IsUnicode(false);

                entity.Property(e => e.DocObjVerNo).HasPrecision(10);

                entity.Property(e => e.DocPurpose).IsUnicode(false);

                entity.Property(e => e.DocPurposeCode).IsUnicode(false);

                entity.Property(e => e.DocStatusCode).IsUnicode(false);

                entity.Property(e => e.DocStatusName).IsUnicode(false);

                entity.Property(e => e.DocType).IsUnicode(false);

                entity.Property(e => e.DocTypeCode).IsUnicode(false);

                entity.Property(e => e.Escalationdays).HasPrecision(10);

                entity.Property(e => e.PersFname).IsUnicode(false);

                entity.Property(e => e.PersGuid).IsUnicode(false);

                entity.Property(e => e.PersLname).IsUnicode(false);

                entity.Property(e => e.PersMname).IsUnicode(false);

                entity.Property(e => e.PersonId).IsUnicode(false);

                entity.Property(e => e.Renewaldays).HasPrecision(10);
            });

            modelBuilder.Entity<PersdocBusinessLicV>(entity =>
            {
                entity.ToView("PERSDOC_BUSINESS_LIC_V");

                entity.Property(e => e.DocFileName).IsUnicode(false);

                entity.Property(e => e.DocGuid).IsUnicode(false);

                entity.Property(e => e.DocNo).IsUnicode(false);

                entity.Property(e => e.DocObjVerNo).HasPrecision(10);

                entity.Property(e => e.DocPurpose).IsUnicode(false);

                entity.Property(e => e.DocPurposeCode).IsUnicode(false);

                entity.Property(e => e.DocStatusCode).IsUnicode(false);

                entity.Property(e => e.DocStatusName).IsUnicode(false);

                entity.Property(e => e.DocType).IsUnicode(false);

                entity.Property(e => e.DocTypeCode).IsUnicode(false);

                entity.Property(e => e.Escalationdays).HasPrecision(10);

                entity.Property(e => e.PersFname).IsUnicode(false);

                entity.Property(e => e.PersGuid).IsUnicode(false);

                entity.Property(e => e.PersLname).IsUnicode(false);

                entity.Property(e => e.PersMname).IsUnicode(false);

                entity.Property(e => e.PersonId).IsUnicode(false);

                entity.Property(e => e.Renewaldays).HasPrecision(10);
            });

            modelBuilder.Entity<PersdocPanV>(entity =>
            {
                entity.ToView("PERSDOC_PAN_V");

                entity.Property(e => e.DocFileName).IsUnicode(false);

                entity.Property(e => e.DocGuid).IsUnicode(false);

                entity.Property(e => e.DocNo).IsUnicode(false);

                entity.Property(e => e.DocObjVerNo).HasPrecision(10);

                entity.Property(e => e.DocPurpose).IsUnicode(false);

                entity.Property(e => e.DocPurposeCode).IsUnicode(false);

                entity.Property(e => e.DocStatusCode).IsUnicode(false);

                entity.Property(e => e.DocStatusName).IsUnicode(false);

                entity.Property(e => e.DocType).IsUnicode(false);

                entity.Property(e => e.DocTypeCode).IsUnicode(false);

                entity.Property(e => e.Escalationdays).HasPrecision(10);

                entity.Property(e => e.PersFname).IsUnicode(false);

                entity.Property(e => e.PersGuid).IsUnicode(false);

                entity.Property(e => e.PersLname).IsUnicode(false);

                entity.Property(e => e.PersMname).IsUnicode(false);

                entity.Property(e => e.PersonId).IsUnicode(false);

                entity.Property(e => e.Renewaldays).HasPrecision(10);
            });

            modelBuilder.Entity<PersdocPhotographV>(entity =>
            {
                entity.ToView("PERSDOC_PHOTOGRAPH_V");

                entity.Property(e => e.DocFileName).IsUnicode(false);

                entity.Property(e => e.DocGuid).IsUnicode(false);

                entity.Property(e => e.DocNo).IsUnicode(false);

                entity.Property(e => e.DocObjVerNo).HasPrecision(10);

                entity.Property(e => e.DocPurpose).IsUnicode(false);

                entity.Property(e => e.DocPurposeCode).IsUnicode(false);

                entity.Property(e => e.DocStatusCode).IsUnicode(false);

                entity.Property(e => e.DocStatusName).IsUnicode(false);

                entity.Property(e => e.DocType).IsUnicode(false);

                entity.Property(e => e.DocTypeCode).IsUnicode(false);

                entity.Property(e => e.Escalationdays).HasPrecision(10);

                entity.Property(e => e.PersFname).IsUnicode(false);

                entity.Property(e => e.PersGuid).IsUnicode(false);

                entity.Property(e => e.PersLname).IsUnicode(false);

                entity.Property(e => e.PersMname).IsUnicode(false);

                entity.Property(e => e.PersonId).IsUnicode(false);

                entity.Property(e => e.Renewaldays).HasPrecision(10);
            });

            modelBuilder.Entity<PersdocRtoAuthV>(entity =>
            {
                entity.ToView("PERSDOC_RTO_AUTH_V");

                entity.Property(e => e.DocFileName).IsUnicode(false);

                entity.Property(e => e.DocGuid).IsUnicode(false);

                entity.Property(e => e.DocNo).IsUnicode(false);

                entity.Property(e => e.DocObjVerNo).HasPrecision(10);

                entity.Property(e => e.DocPurpose).IsUnicode(false);

                entity.Property(e => e.DocPurposeCode).IsUnicode(false);

                entity.Property(e => e.DocStatusCode).IsUnicode(false);

                entity.Property(e => e.DocStatusName).IsUnicode(false);

                entity.Property(e => e.DocType).IsUnicode(false);

                entity.Property(e => e.DocTypeCode).IsUnicode(false);

                entity.Property(e => e.Escalationdays).HasPrecision(10);

                entity.Property(e => e.PersFname).IsUnicode(false);

                entity.Property(e => e.PersGuid).IsUnicode(false);

                entity.Property(e => e.PersLname).IsUnicode(false);

                entity.Property(e => e.PersMname).IsUnicode(false);

                entity.Property(e => e.PersonId).IsUnicode(false);

                entity.Property(e => e.Renewaldays).HasPrecision(10);
            });

            modelBuilder.Entity<PersonBaseV>(entity =>
            {
                entity.ToView("PERSON_BASE_V");

                entity.Property(e => e.Businesscategory).IsUnicode(false);

                entity.Property(e => e.EntityCode).IsUnicode(false);

                entity.Property(e => e.Isdriversentforinduction).HasPrecision(5);

                entity.Property(e => e.Isspsentforinduction).HasPrecision(5);

                entity.Property(e => e.Mentorid).IsUnicode(false);

                entity.Property(e => e.PersBioid).IsUnicode(false);

                entity.Property(e => e.PersDisabled).HasPrecision(1);

                entity.Property(e => e.PersDriverflag).HasPrecision(1);

                entity.Property(e => e.PersDseflag).HasPrecision(1);

                entity.Property(e => e.PersFname).IsUnicode(false);

                entity.Property(e => e.PersGender).IsUnicode(false);

                entity.Property(e => e.PersGuid).IsUnicode(false);

                entity.Property(e => e.PersLname).IsUnicode(false);

                entity.Property(e => e.PersMname).IsUnicode(false);

                entity.Property(e => e.PersObjVerNo).HasPrecision(10);

                entity.Property(e => e.PersSpflag).HasPrecision(1);

                entity.Property(e => e.PersStatusCode).IsUnicode(false);

                entity.Property(e => e.PersTitle).IsUnicode(false);

                entity.Property(e => e.Personid).IsUnicode(false);

                entity.Property(e => e.StatusDesc).IsUnicode(false);

                entity.Property(e => e.StatusEntEntguid).IsUnicode(false);

                entity.Property(e => e.StatusEntGuid).IsUnicode(false);

                entity.Property(e => e.StatusEntObjVerNo).HasPrecision(10);

                entity.Property(e => e.StatusEntStsguid).IsUnicode(false);

                entity.Property(e => e.StatusName).IsUnicode(false);
            });

            modelBuilder.Entity<PersonContactDetailsBaseV>(entity =>
            {
                entity.ToView("PERSON_CONTACT_DETAILS_BASE_V");

                entity.Property(e => e.Addressline1).IsUnicode(false);

                entity.Property(e => e.Addressline2).IsUnicode(false);

                entity.Property(e => e.Cityname).IsUnicode(false);

                entity.Property(e => e.Contactno).IsUnicode(false);

                entity.Property(e => e.Contactsubtypeguid).IsUnicode(false);

                entity.Property(e => e.Contacttypemasterguid).IsUnicode(false);

                entity.Property(e => e.Countrycodeguid).IsUnicode(false);

                entity.Property(e => e.Countrymasterguid).IsUnicode(false);

                entity.Property(e => e.Disabled).HasPrecision(1);

                entity.Property(e => e.Emailid).IsUnicode(false);

                entity.Property(e => e.Objectversionno).HasPrecision(10);

                entity.Property(e => e.Oracleentityid).IsUnicode(false);

                entity.Property(e => e.Oracleentityname).IsUnicode(false);

                entity.Property(e => e.Personcontactguid).IsUnicode(false);

                entity.Property(e => e.Personcontactpkguid).IsUnicode(false);

                entity.Property(e => e.Personmasterguid).IsUnicode(false);

                entity.Property(e => e.Pincode).IsUnicode(false);

                entity.Property(e => e.Primaryflag).HasPrecision(1);

                entity.Property(e => e.Statemasterguid).IsUnicode(false);

                entity.Property(e => e.Subtypecomments).IsUnicode(false);

                entity.Property(e => e.Subtypedescription).IsUnicode(false);

                entity.Property(e => e.Subtypedisabled).HasPrecision(1);

                entity.Property(e => e.Subtypename).IsUnicode(false);

                entity.Property(e => e.Subtypeobjectversionno).HasPrecision(10);

                entity.Property(e => e.Subtypeoracleentityid).IsUnicode(false);

                entity.Property(e => e.Subtypeoracleentityname).IsUnicode(false);

                entity.Property(e => e.Subtypepkguid).IsUnicode(false);

                entity.Property(e => e.Subtypequickaccesscode).IsUnicode(false);

                entity.Property(e => e.Typemastercomments).IsUnicode(false);

                entity.Property(e => e.Typemasterdescription).IsUnicode(false);

                entity.Property(e => e.Typemasterdisabled).HasPrecision(1);

                entity.Property(e => e.Typemastername).IsUnicode(false);

                entity.Property(e => e.Typemasterobjectversionno).HasPrecision(10);

                entity.Property(e => e.Typemasteroracleentityid).IsUnicode(false);

                entity.Property(e => e.Typemasteroracleentityname).IsUnicode(false);

                entity.Property(e => e.Typemasterpkguid).IsUnicode(false);

                entity.Property(e => e.Typemasterquickaccesscode).IsUnicode(false);
            });

            modelBuilder.Entity<PersonContactDetailsV>(entity =>
            {
                entity.ToView("PERSON_CONTACT_DETAILS_V");

                entity.Property(e => e.Addressline1).IsUnicode(false);

                entity.Property(e => e.Addressline2).IsUnicode(false);

                entity.Property(e => e.Cityname).IsUnicode(false);

                entity.Property(e => e.Contactno).IsUnicode(false);

                entity.Property(e => e.Contactsubtypeguid).IsUnicode(false);

                entity.Property(e => e.Contacttypemasterguid).IsUnicode(false);

                entity.Property(e => e.Countrycodeguid).IsUnicode(false);

                entity.Property(e => e.Countrymasterguid).IsUnicode(false);

                entity.Property(e => e.Disabled).HasPrecision(1);

                entity.Property(e => e.Emailid).IsUnicode(false);

                entity.Property(e => e.Objectversionno).HasPrecision(10);

                entity.Property(e => e.Oracleentityid).IsUnicode(false);

                entity.Property(e => e.Oracleentityname).IsUnicode(false);

                entity.Property(e => e.Personcontactguid).IsUnicode(false);

                entity.Property(e => e.Personcontactpkguid).IsUnicode(false);

                entity.Property(e => e.Personmasterguid).IsUnicode(false);

                entity.Property(e => e.Pincode).IsUnicode(false);

                entity.Property(e => e.Primaryflag).HasPrecision(1);

                entity.Property(e => e.Statemasterguid).IsUnicode(false);

                entity.Property(e => e.Subtypecomments).IsUnicode(false);

                entity.Property(e => e.Subtypedescription).IsUnicode(false);

                entity.Property(e => e.Subtypedisabled).HasPrecision(1);

                entity.Property(e => e.Subtypename).IsUnicode(false);

                entity.Property(e => e.Subtypeobjectversionno).HasPrecision(10);

                entity.Property(e => e.Subtypeoracleentityid).IsUnicode(false);

                entity.Property(e => e.Subtypeoracleentityname).IsUnicode(false);

                entity.Property(e => e.Subtypepkguid).IsUnicode(false);

                entity.Property(e => e.Subtypequickaccesscode).IsUnicode(false);

                entity.Property(e => e.Typemastercomments).IsUnicode(false);

                entity.Property(e => e.Typemasterdescription).IsUnicode(false);

                entity.Property(e => e.Typemasterdisabled).HasPrecision(1);

                entity.Property(e => e.Typemastername).IsUnicode(false);

                entity.Property(e => e.Typemasterobjectversionno).HasPrecision(10);

                entity.Property(e => e.Typemasteroracleentityid).IsUnicode(false);

                entity.Property(e => e.Typemasteroracleentityname).IsUnicode(false);

                entity.Property(e => e.Typemasterpkguid).IsUnicode(false);

                entity.Property(e => e.Typemasterquickaccesscode).IsUnicode(false);
            });

            modelBuilder.Entity<PersonDetailBaseV>(entity =>
            {
                entity.ToView("PERSON_DETAIL_BASE_V");

                entity.Property(e => e.AddrLine1).IsUnicode(false);

                entity.Property(e => e.AddrLine2).IsUnicode(false);

                entity.Property(e => e.AddrTypeName).IsUnicode(false);

                entity.Property(e => e.Country).IsUnicode(false);

                entity.Property(e => e.PersBioid).IsUnicode(false);

                entity.Property(e => e.PersDriverflag).HasPrecision(1);

                entity.Property(e => e.PersDseflag).HasPrecision(1);

                entity.Property(e => e.PersFname).IsUnicode(false);

                entity.Property(e => e.PersGender).IsUnicode(false);

                entity.Property(e => e.PersGuid).IsUnicode(false);

                entity.Property(e => e.PersLname).IsUnicode(false);

                entity.Property(e => e.PersMname).IsUnicode(false);

                entity.Property(e => e.PersObjVerNo).HasPrecision(10);

                entity.Property(e => e.PersSpflag).HasPrecision(1);

                entity.Property(e => e.PersStatusCode).IsUnicode(false);

                entity.Property(e => e.PersTitle).IsUnicode(false);

                entity.Property(e => e.Personid).IsUnicode(false);

                entity.Property(e => e.PhoneGuid).IsUnicode(false);

                entity.Property(e => e.PhoneNo).IsUnicode(false);

                entity.Property(e => e.PhonePersGuid).IsUnicode(false);

                entity.Property(e => e.PhoneTypeCode).IsUnicode(false);

                entity.Property(e => e.PhoneTypeName).IsUnicode(false);

                entity.Property(e => e.State).IsUnicode(false);
            });

            modelBuilder.Entity<PersonDetailV>(entity =>
            {
                entity.ToView("PERSON_DETAIL_V");

                entity.Property(e => e.AddrLine1).IsUnicode(false);

                entity.Property(e => e.AddrLine2).IsUnicode(false);

                entity.Property(e => e.AddrTypeName).IsUnicode(false);

                entity.Property(e => e.Country).IsUnicode(false);

                entity.Property(e => e.PersBioid).IsUnicode(false);

                entity.Property(e => e.PersDriverflag).HasPrecision(1);

                entity.Property(e => e.PersDseflag).HasPrecision(1);

                entity.Property(e => e.PersFname).IsUnicode(false);

                entity.Property(e => e.PersGender).IsUnicode(false);

                entity.Property(e => e.PersGuid).IsUnicode(false);

                entity.Property(e => e.PersLname).IsUnicode(false);

                entity.Property(e => e.PersMname).IsUnicode(false);

                entity.Property(e => e.PersObjVerNo).HasPrecision(10);

                entity.Property(e => e.PersSpflag).HasPrecision(1);

                entity.Property(e => e.PersStatusCode).IsUnicode(false);

                entity.Property(e => e.PersTitle).IsUnicode(false);

                entity.Property(e => e.Personid).IsUnicode(false);

                entity.Property(e => e.PhoneGuid).IsUnicode(false);

                entity.Property(e => e.PhoneNo).IsUnicode(false);

                entity.Property(e => e.PhonePersGuid).IsUnicode(false);

                entity.Property(e => e.PhoneTypeCode).IsUnicode(false);

                entity.Property(e => e.PhoneTypeName).IsUnicode(false);

                entity.Property(e => e.State).IsUnicode(false);
            });

            modelBuilder.Entity<PersonDocActionV>(entity =>
            {
                entity.ToView("PERSON_DOC_ACTION_V");

                entity.Property(e => e.ActionCode).IsUnicode(false);

                entity.Property(e => e.ActionDescription).IsUnicode(false);

                entity.Property(e => e.ActionName).IsUnicode(false);

                entity.Property(e => e.DocActionPkguid).IsUnicode(false);

                entity.Property(e => e.DocGuid).IsUnicode(false);

                entity.Property(e => e.DocNo).IsUnicode(false);

                entity.Property(e => e.DocType).IsUnicode(false);

                entity.Property(e => e.Mentorid).IsUnicode(false);

                entity.Property(e => e.PersFname).IsUnicode(false);

                entity.Property(e => e.PersGuid).IsUnicode(false);

                entity.Property(e => e.PersLname).IsUnicode(false);

                entity.Property(e => e.PersMname).IsUnicode(false);

                entity.Property(e => e.PersonId).IsUnicode(false);
            });

            modelBuilder.Entity<PersonExpiryDocV>(entity =>
            {
                entity.ToView("PERSON_EXPIRY_DOC_V");

                entity.Property(e => e.BadgeDocumentno).IsUnicode(false);

                entity.Property(e => e.BadgeQuickaccesscode).IsUnicode(false);

                entity.Property(e => e.CitAddress).IsUnicode(false);

                entity.Property(e => e.CitCityname).IsUnicode(false);

                entity.Property(e => e.DlDocumentno).IsUnicode(false);

                entity.Property(e => e.DlQuickaccesscode).IsUnicode(false);

                entity.Property(e => e.MobContactno).IsUnicode(false);

                entity.Property(e => e.PanDocumentno).IsUnicode(false);

                entity.Property(e => e.PanQuickaccesscode).IsUnicode(false);

                entity.Property(e => e.PmDriverflag)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.PmDseflag)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.PmFullname).IsUnicode(false);

                entity.Property(e => e.PmPersonid).IsUnicode(false);

                entity.Property(e => e.PmSpflag)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.StStatusName).IsUnicode(false);
            });

            modelBuilder.Entity<PersonExpiryDocV1>(entity =>
            {
                entity.ToView("PERSON_EXPIRY_DOC_V1");

                entity.Property(e => e.AddreQuickaccesscode).IsUnicode(false);

                entity.Property(e => e.AgreeDocumentno).IsUnicode(false);

                entity.Property(e => e.AgreeQuickaccesscode).IsUnicode(false);

                entity.Property(e => e.CitAddress).IsUnicode(false);

                entity.Property(e => e.CitCityname).IsUnicode(false);

                entity.Property(e => e.MobContactno).IsUnicode(false);

                entity.Property(e => e.PhotoQuickaccesscode).IsUnicode(false);

                entity.Property(e => e.PmDriverflag)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.PmDseflag)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.PmFullname).IsUnicode(false);

                entity.Property(e => e.PmPersonid).IsUnicode(false);

                entity.Property(e => e.PmSpflag)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.PvcQuickaccesscode).IsUnicode(false);

                entity.Property(e => e.StStatusName).IsUnicode(false);
            });

            modelBuilder.Entity<PersonPositionV>(entity =>
            {
                entity.ToView("PERSON_POSITION_V");

                entity.Property(e => e.EmployeeNumber)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.FullName).IsUnicode(false);

                entity.Property(e => e.Id)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.JobId)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.JobName)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.NpwNumber)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.OrganizationId)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.PersonType)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.PositionId)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.PositionName)
                    .IsUnicode(false)
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<PersonRatingV>(entity =>
            {
                entity.ToView("PERSON_RATING_V");

                entity.Property(e => e.Drivermasterguid).IsUnicode(false);

                entity.Property(e => e.Personmasterguid).IsUnicode(false);

                entity.Property(e => e.Ratingguid).IsUnicode(false);
            });

            modelBuilder.Entity<PersonV>(entity =>
            {
                entity.ToView("PERSON_V");

                entity.Property(e => e.Businesscategory).IsUnicode(false);

                entity.Property(e => e.EntityCode).IsUnicode(false);

                entity.Property(e => e.Isdriversentforinduction).HasPrecision(5);

                entity.Property(e => e.Isspsentforinduction).HasPrecision(5);

                entity.Property(e => e.Mentorid).IsUnicode(false);

                entity.Property(e => e.PersBioid).IsUnicode(false);

                entity.Property(e => e.PersDisabled).HasPrecision(1);

                entity.Property(e => e.PersDriverflag).HasPrecision(1);

                entity.Property(e => e.PersDseflag).HasPrecision(1);

                entity.Property(e => e.PersFname).IsUnicode(false);

                entity.Property(e => e.PersGender).IsUnicode(false);

                entity.Property(e => e.PersGuid).IsUnicode(false);

                entity.Property(e => e.PersLname).IsUnicode(false);

                entity.Property(e => e.PersMname).IsUnicode(false);

                entity.Property(e => e.PersObjVerNo).HasPrecision(10);

                entity.Property(e => e.PersSpflag).HasPrecision(1);

                entity.Property(e => e.PersStatusCode).IsUnicode(false);

                entity.Property(e => e.PersTitle).IsUnicode(false);

                entity.Property(e => e.Personid).IsUnicode(false);

                entity.Property(e => e.StatusDesc).IsUnicode(false);

                entity.Property(e => e.StatusEntEntguid).IsUnicode(false);

                entity.Property(e => e.StatusEntGuid).IsUnicode(false);

                entity.Property(e => e.StatusEntObjVerNo).HasPrecision(10);

                entity.Property(e => e.StatusEntStsguid).IsUnicode(false);

                entity.Property(e => e.StatusName).IsUnicode(false);
            });

            modelBuilder.Entity<PersonaddressBaseV>(entity =>
            {
                entity.ToView("PERSONADDRESS_BASE_V");

                entity.Property(e => e.AddrGuid).IsUnicode(false);

                entity.Property(e => e.AddrLine1).IsUnicode(false);

                entity.Property(e => e.AddrLine2).IsUnicode(false);

                entity.Property(e => e.AddrObjVerNo).HasPrecision(10);

                entity.Property(e => e.AddrPersGuid).IsUnicode(false);

                entity.Property(e => e.AddrTypeCode).IsUnicode(false);

                entity.Property(e => e.AddrTypeName).IsUnicode(false);

                entity.Property(e => e.City).IsUnicode(false);

                entity.Property(e => e.Country).IsUnicode(false);

                entity.Property(e => e.PersFname).IsUnicode(false);

                entity.Property(e => e.PersLname).IsUnicode(false);

                entity.Property(e => e.PersMname).IsUnicode(false);

                entity.Property(e => e.Personid).IsUnicode(false);

                entity.Property(e => e.Pincode).IsUnicode(false);

                entity.Property(e => e.Primaryflag).HasPrecision(1);

                entity.Property(e => e.State).IsUnicode(false);
            });

            modelBuilder.Entity<PersonaddressV>(entity =>
            {
                entity.ToView("PERSONADDRESS_V");

                entity.Property(e => e.AddrGuid).IsUnicode(false);

                entity.Property(e => e.AddrLine1).IsUnicode(false);

                entity.Property(e => e.AddrLine2).IsUnicode(false);

                entity.Property(e => e.AddrObjVerNo).HasPrecision(10);

                entity.Property(e => e.AddrPersGuid).IsUnicode(false);

                entity.Property(e => e.AddrTypeCode).IsUnicode(false);

                entity.Property(e => e.AddrTypeName).IsUnicode(false);

                entity.Property(e => e.City).IsUnicode(false);

                entity.Property(e => e.Country).IsUnicode(false);

                entity.Property(e => e.PersFname).IsUnicode(false);

                entity.Property(e => e.PersLname).IsUnicode(false);

                entity.Property(e => e.PersMname).IsUnicode(false);

                entity.Property(e => e.Personid).IsUnicode(false);

                entity.Property(e => e.Pincode).IsUnicode(false);

                entity.Property(e => e.Primaryflag).HasPrecision(1);

                entity.Property(e => e.State).IsUnicode(false);
            });

            modelBuilder.Entity<Personcontact>(entity =>
            {
                entity.Property(e => e.Addressline1).IsUnicode(false);

                entity.Property(e => e.Addressline2).IsUnicode(false);

                entity.Property(e => e.Cityname).IsUnicode(false);

                entity.Property(e => e.Contactno).IsUnicode(false);

                entity.Property(e => e.Contactsubtypeguid).IsUnicode(false);

                entity.Property(e => e.Countrycodeguid).IsUnicode(false);

                entity.Property(e => e.Countrymasterguid).IsUnicode(false);

                entity.Property(e => e.Disabled).HasPrecision(1);

                entity.Property(e => e.Emailid).IsUnicode(false);

                entity.Property(e => e.Guid).IsUnicode(false);

                entity.Property(e => e.Objectversionno).HasPrecision(10);

                entity.Property(e => e.Oracleentityid).IsUnicode(false);

                entity.Property(e => e.Oracleentityname).IsUnicode(false);

                entity.Property(e => e.Personmasterguid).IsUnicode(false);

                entity.Property(e => e.Pincode).IsUnicode(false);

                entity.Property(e => e.Pkguid).IsUnicode(false);

                entity.Property(e => e.Primaryflag).HasPrecision(1);

                entity.Property(e => e.Statemasterguid).IsUnicode(false);

                entity.Property(e => e.Userarchived).IsUnicode(false);

                entity.Property(e => e.Usercreated).IsUnicode(false);

                entity.Property(e => e.Userdeleted).IsUnicode(false);

                entity.Property(e => e.Userupdated).IsUnicode(false);
            });

            modelBuilder.Entity<Persondoc>(entity =>
            {
                entity.Property(e => e.Bankaccountno).IsUnicode(false);

                entity.Property(e => e.Bankbeneficiaryname).IsUnicode(false);

                entity.Property(e => e.Bankbranchmasterguid).IsUnicode(false);

                entity.Property(e => e.Bankifsccode).IsUnicode(false);

                entity.Property(e => e.Bankmasterguid).IsUnicode(false);

                entity.Property(e => e.Disabled)
                    .HasPrecision(1)
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Documentname).IsUnicode(false);

                entity.Property(e => e.Documentno).IsUnicode(false);

                entity.Property(e => e.Documentpath).IsUnicode(false);

                entity.Property(e => e.Documenttypeentityguid).IsUnicode(false);

                entity.Property(e => e.Documenttypepurposeguid).IsUnicode(false);

                entity.Property(e => e.Effectiveenddate).HasDefaultValueSql("to_timestamp('4712-12-31','yyyy-mm-dd')");

                entity.Property(e => e.Guid).IsUnicode(false);

                entity.Property(e => e.Objectversionno).HasPrecision(10);

                entity.Property(e => e.Oracleentityid).IsUnicode(false);

                entity.Property(e => e.Oracleentityname).IsUnicode(false);

                entity.Property(e => e.Personmasterguid).IsUnicode(false);

                entity.Property(e => e.Pkguid).IsUnicode(false);

                entity.Property(e => e.Statusentityguid).IsUnicode(false);

                entity.Property(e => e.Userarchived).IsUnicode(false);

                entity.Property(e => e.Usercreated).IsUnicode(false);

                entity.Property(e => e.Userdeleted).IsUnicode(false);

                entity.Property(e => e.Userupdated).IsUnicode(false);
            });

            modelBuilder.Entity<PersondocsAddV>(entity =>
            {
                entity.ToView("PERSONDOCS_ADD_V");

                entity.Property(e => e.DocFileName).IsUnicode(false);

                entity.Property(e => e.DocGuid).IsUnicode(false);

                entity.Property(e => e.DocNo).IsUnicode(false);

                entity.Property(e => e.DocObjVerNo).HasPrecision(10);

                entity.Property(e => e.DocPurpose).IsUnicode(false);

                entity.Property(e => e.DocPurposeCode).IsUnicode(false);

                entity.Property(e => e.DocStatusCode).IsUnicode(false);

                entity.Property(e => e.DocStatusName).IsUnicode(false);

                entity.Property(e => e.DocType).IsUnicode(false);

                entity.Property(e => e.DocTypeCode).IsUnicode(false);

                entity.Property(e => e.Escalationdays).HasPrecision(10);

                entity.Property(e => e.PersFname).IsUnicode(false);

                entity.Property(e => e.PersGuid).IsUnicode(false);

                entity.Property(e => e.PersLname).IsUnicode(false);

                entity.Property(e => e.PersMname).IsUnicode(false);

                entity.Property(e => e.PersonId).IsUnicode(false);

                entity.Property(e => e.Renewaldays).HasPrecision(10);
            });

            modelBuilder.Entity<PersondocsBadgeV>(entity =>
            {
                entity.ToView("PERSONDOCS_BADGE_V");

                entity.Property(e => e.DocFileName).IsUnicode(false);

                entity.Property(e => e.DocGuid).IsUnicode(false);

                entity.Property(e => e.DocNo).IsUnicode(false);

                entity.Property(e => e.DocObjVerNo).HasPrecision(10);

                entity.Property(e => e.DocPurpose).IsUnicode(false);

                entity.Property(e => e.DocPurposeCode).IsUnicode(false);

                entity.Property(e => e.DocStatusCode).IsUnicode(false);

                entity.Property(e => e.DocStatusName).IsUnicode(false);

                entity.Property(e => e.DocType).IsUnicode(false);

                entity.Property(e => e.DocTypeCode).IsUnicode(false);

                entity.Property(e => e.Escalationdays).HasPrecision(10);

                entity.Property(e => e.PersFname).IsUnicode(false);

                entity.Property(e => e.PersGuid).IsUnicode(false);

                entity.Property(e => e.PersLname).IsUnicode(false);

                entity.Property(e => e.PersMname).IsUnicode(false);

                entity.Property(e => e.PersonId).IsUnicode(false);

                entity.Property(e => e.Renewaldays).HasPrecision(10);
            });

            modelBuilder.Entity<PersondocsBaseV>(entity =>
            {
                entity.ToView("PERSONDOCS_BASE_V");

                entity.Property(e => e.DocDocumentpath).IsUnicode(false);

                entity.Property(e => e.DocFileName).IsUnicode(false);

                entity.Property(e => e.DocGuid).IsUnicode(false);

                entity.Property(e => e.DocNo).IsUnicode(false);

                entity.Property(e => e.DocObjVerNo).HasPrecision(10);

                entity.Property(e => e.DocPurpose).IsUnicode(false);

                entity.Property(e => e.DocPurposeCode).IsUnicode(false);

                entity.Property(e => e.DocStatusCode).IsUnicode(false);

                entity.Property(e => e.DocStatusName).IsUnicode(false);

                entity.Property(e => e.DocType).IsUnicode(false);

                entity.Property(e => e.DocTypeCode).IsUnicode(false);

                entity.Property(e => e.Documenttypeentityguid).IsUnicode(false);

                entity.Property(e => e.Documenttypepurposeguid).IsUnicode(false);

                entity.Property(e => e.Escalationdays).HasPrecision(10);

                entity.Property(e => e.PersFname).IsUnicode(false);

                entity.Property(e => e.PersGuid).IsUnicode(false);

                entity.Property(e => e.PersLname).IsUnicode(false);

                entity.Property(e => e.PersMname).IsUnicode(false);

                entity.Property(e => e.PersonId).IsUnicode(false);

                entity.Property(e => e.Renewaldays).HasPrecision(10);

                entity.Property(e => e.Statusentityguid).IsUnicode(false);
            });

            modelBuilder.Entity<PersondocsIdV>(entity =>
            {
                entity.ToView("PERSONDOCS_ID_V");

                entity.Property(e => e.DocFileName).IsUnicode(false);

                entity.Property(e => e.DocGuid).IsUnicode(false);

                entity.Property(e => e.DocNo).IsUnicode(false);

                entity.Property(e => e.DocObjVerNo).HasPrecision(10);

                entity.Property(e => e.DocPurpose).IsUnicode(false);

                entity.Property(e => e.DocPurposeCode).IsUnicode(false);

                entity.Property(e => e.DocStatusCode).IsUnicode(false);

                entity.Property(e => e.DocStatusName).IsUnicode(false);

                entity.Property(e => e.DocType).IsUnicode(false);

                entity.Property(e => e.DocTypeCode).IsUnicode(false);

                entity.Property(e => e.Escalationdays).HasPrecision(10);

                entity.Property(e => e.PersFname).IsUnicode(false);

                entity.Property(e => e.PersGuid).IsUnicode(false);

                entity.Property(e => e.PersLname).IsUnicode(false);

                entity.Property(e => e.PersMname).IsUnicode(false);

                entity.Property(e => e.PersonId).IsUnicode(false);

                entity.Property(e => e.Renewaldays).HasPrecision(10);
            });

            modelBuilder.Entity<PersondocsInterface>(entity =>
            {
                entity.Property(e => e.Bankaccountno).IsUnicode(false);

                entity.Property(e => e.Bankbeneficiaryname).IsUnicode(false);

                entity.Property(e => e.Bankbranchmasterguid).IsUnicode(false);

                entity.Property(e => e.Bankifsccode).IsUnicode(false);

                entity.Property(e => e.Bankmasterguid).IsUnicode(false);

                entity.Property(e => e.Disabled)
                    .HasPrecision(1)
                    .HasDefaultValueSql("'0' \n");

                entity.Property(e => e.Documentname).IsUnicode(false);

                entity.Property(e => e.Documentno).IsUnicode(false);

                entity.Property(e => e.Documentpath).IsUnicode(false);

                entity.Property(e => e.Documenttypeentityguid).IsUnicode(false);

                entity.Property(e => e.Documenttypepurposeguid).IsUnicode(false);

                entity.Property(e => e.Effectiveenddate).HasDefaultValueSql("to_timestamp('4712-12-31','yyyy-mm-dd') \n");

                entity.Property(e => e.Guid).IsUnicode(false);

                entity.Property(e => e.Objectversionno).HasPrecision(10);

                entity.Property(e => e.Oracleentityid).IsUnicode(false);

                entity.Property(e => e.Oracleentityname).IsUnicode(false);

                entity.Property(e => e.Personmasterguid).IsUnicode(false);

                entity.Property(e => e.Pkguid).IsUnicode(false);

                entity.Property(e => e.Statusentityguid).IsUnicode(false);

                entity.Property(e => e.Userarchived).IsUnicode(false);

                entity.Property(e => e.Usercreated).IsUnicode(false);

                entity.Property(e => e.Userdeleted).IsUnicode(false);

                entity.Property(e => e.Userupdated).IsUnicode(false);
            });

            modelBuilder.Entity<PersondocsLicenseV>(entity =>
            {
                entity.ToView("PERSONDOCS_LICENSE_V");

                entity.Property(e => e.DocFileName).IsUnicode(false);

                entity.Property(e => e.DocGuid).IsUnicode(false);

                entity.Property(e => e.DocNo).IsUnicode(false);

                entity.Property(e => e.DocObjVerNo).HasPrecision(10);

                entity.Property(e => e.DocPurpose).IsUnicode(false);

                entity.Property(e => e.DocPurposeCode).IsUnicode(false);

                entity.Property(e => e.DocStatusCode).IsUnicode(false);

                entity.Property(e => e.DocStatusName).IsUnicode(false);

                entity.Property(e => e.DocType).IsUnicode(false);

                entity.Property(e => e.DocTypeCode).IsUnicode(false);

                entity.Property(e => e.Escalationdays).HasPrecision(10);

                entity.Property(e => e.PersFname).IsUnicode(false);

                entity.Property(e => e.PersGuid).IsUnicode(false);

                entity.Property(e => e.PersLname).IsUnicode(false);

                entity.Property(e => e.PersMname).IsUnicode(false);

                entity.Property(e => e.PersonId).IsUnicode(false);

                entity.Property(e => e.Renewaldays).HasPrecision(10);
            });

            modelBuilder.Entity<PersondocsPhoneV>(entity =>
            {
                entity.ToView("PERSONDOCS_PHONE_V");

                entity.Property(e => e.DocFileName).IsUnicode(false);

                entity.Property(e => e.DocGuid).IsUnicode(false);

                entity.Property(e => e.DocNo).IsUnicode(false);

                entity.Property(e => e.DocObjVerNo).HasPrecision(10);

                entity.Property(e => e.DocPurpose).IsUnicode(false);

                entity.Property(e => e.DocPurposeCode).IsUnicode(false);

                entity.Property(e => e.DocStatusCode).IsUnicode(false);

                entity.Property(e => e.DocStatusName).IsUnicode(false);

                entity.Property(e => e.DocType).IsUnicode(false);

                entity.Property(e => e.DocTypeCode).IsUnicode(false);

                entity.Property(e => e.Escalationdays).HasPrecision(10);

                entity.Property(e => e.PersFname).IsUnicode(false);

                entity.Property(e => e.PersGuid).IsUnicode(false);

                entity.Property(e => e.PersLname).IsUnicode(false);

                entity.Property(e => e.PersMname).IsUnicode(false);

                entity.Property(e => e.PersonId).IsUnicode(false);

                entity.Property(e => e.Renewaldays).HasPrecision(10);
            });

            modelBuilder.Entity<PersondocsV>(entity =>
            {
                entity.ToView("PERSONDOCS_V");

                entity.Property(e => e.DocDocumentpath).IsUnicode(false);

                entity.Property(e => e.DocFileName).IsUnicode(false);

                entity.Property(e => e.DocGuid).IsUnicode(false);

                entity.Property(e => e.DocNo).IsUnicode(false);

                entity.Property(e => e.DocObjVerNo).HasPrecision(10);

                entity.Property(e => e.DocPurpose).IsUnicode(false);

                entity.Property(e => e.DocPurposeCode).IsUnicode(false);

                entity.Property(e => e.DocStatusCode).IsUnicode(false);

                entity.Property(e => e.DocStatusName).IsUnicode(false);

                entity.Property(e => e.DocType).IsUnicode(false);

                entity.Property(e => e.DocTypeCode).IsUnicode(false);

                entity.Property(e => e.Documenttypeentityguid).IsUnicode(false);

                entity.Property(e => e.Documenttypepurposeguid).IsUnicode(false);

                entity.Property(e => e.Escalationdays).HasPrecision(10);

                entity.Property(e => e.PersFname).IsUnicode(false);

                entity.Property(e => e.PersGuid).IsUnicode(false);

                entity.Property(e => e.PersLname).IsUnicode(false);

                entity.Property(e => e.PersMname).IsUnicode(false);

                entity.Property(e => e.PersonId).IsUnicode(false);

                entity.Property(e => e.Renewaldays).HasPrecision(10);

                entity.Property(e => e.Statusentityguid).IsUnicode(false);
            });

            modelBuilder.Entity<PersondocsactionV>(entity =>
            {
                entity.ToView("PERSONDOCSACTION_V");

                entity.Property(e => e.ActionDescription).IsUnicode(false);

                entity.Property(e => e.ActionName).IsUnicode(false);

                entity.Property(e => e.DocFileName).IsUnicode(false);

                entity.Property(e => e.DocGuid).IsUnicode(false);

                entity.Property(e => e.DocNo).IsUnicode(false);

                entity.Property(e => e.DocObjVerNo).HasPrecision(10);

                entity.Property(e => e.DocPurpose).IsUnicode(false);

                entity.Property(e => e.DocPurposeCode).IsUnicode(false);

                entity.Property(e => e.DocStatusCode).IsUnicode(false);

                entity.Property(e => e.DocStatusName).IsUnicode(false);

                entity.Property(e => e.DocType).IsUnicode(false);

                entity.Property(e => e.DocTypeCode).IsUnicode(false);

                entity.Property(e => e.Escalationdays).HasPrecision(10);

                entity.Property(e => e.PersFname).IsUnicode(false);

                entity.Property(e => e.PersGuid).IsUnicode(false);

                entity.Property(e => e.PersLname).IsUnicode(false);

                entity.Property(e => e.PersMname).IsUnicode(false);

                entity.Property(e => e.PersonId).IsUnicode(false);

                entity.Property(e => e.Renewaldays).HasPrecision(10);
            });

            modelBuilder.Entity<PersondocsdocumentnoV>(entity =>
            {
                entity.ToView("PERSONDOCSDOCUMENTNO_V");

                entity.Property(e => e.Documentno).IsUnicode(false);

                entity.Property(e => e.Documenttypeentityguid).IsUnicode(false);

                entity.Property(e => e.Guid).IsUnicode(false);

                entity.Property(e => e.Personmasterguid).IsUnicode(false);
            });

            modelBuilder.Entity<Persondocsinf>(entity =>
            {
                entity.Property(e => e.Disabled).HasPrecision(1);

                entity.Property(e => e.Documentname).IsUnicode(false);

                entity.Property(e => e.Documentno).IsUnicode(false);

                entity.Property(e => e.Documentpath).IsUnicode(false);

                entity.Property(e => e.Documenttypeentityguid).IsUnicode(false);

                entity.Property(e => e.Documenttypepurposeguid).IsUnicode(false);

                entity.Property(e => e.Guid).IsUnicode(false);

                entity.Property(e => e.Objectversionno).HasPrecision(10);

                entity.Property(e => e.Oracleentityid).IsUnicode(false);

                entity.Property(e => e.Oracleentityname).IsUnicode(false);

                entity.Property(e => e.Personmasterguid).IsUnicode(false);

                entity.Property(e => e.Pkguid).IsUnicode(false);

                entity.Property(e => e.Status).IsUnicode(false);

                entity.Property(e => e.Statusentityguid).IsUnicode(false);

                entity.Property(e => e.Userarchived).IsUnicode(false);

                entity.Property(e => e.Usercreated).IsUnicode(false);

                entity.Property(e => e.Userdeleted).IsUnicode(false);

                entity.Property(e => e.Userupdated).IsUnicode(false);
            });

            modelBuilder.Entity<Persongreivance>(entity =>
            {
                entity.Property(e => e.CarGuid).IsUnicode(false);

                entity.Property(e => e.City).IsUnicode(false);

                entity.Property(e => e.Complaintdetails).IsUnicode(false);

                entity.Property(e => e.Complaintid).HasPrecision(10);

                entity.Property(e => e.CrmPushGeneratedTime).IsUnicode(false);

                entity.Property(e => e.Crtobjectid).IsUnicode(false);

                entity.Property(e => e.Dstphone).IsUnicode(false);

                entity.Property(e => e.Greivancescategoryguid).IsUnicode(false);

                entity.Property(e => e.Guid).IsUnicode(false);

                entity.Property(e => e.Location).IsUnicode(false);

                entity.Property(e => e.Objectversionno).HasPrecision(10);

                entity.Property(e => e.Oracleentityid).IsUnicode(false);

                entity.Property(e => e.Oracleentityname).IsUnicode(false);

                entity.Property(e => e.Personguid).IsUnicode(false);

                entity.Property(e => e.Phone).IsUnicode(false);

                entity.Property(e => e.Pkguid).IsUnicode(false);

                entity.Property(e => e.Queuename).IsUnicode(false);

                entity.Property(e => e.Resolvedetails).IsUnicode(false);

                entity.Property(e => e.Sessionid).IsUnicode(false);

                entity.Property(e => e.Statusentityguid).IsUnicode(false);

                entity.Property(e => e.Userarchived).IsUnicode(false);

                entity.Property(e => e.Usercreated).IsUnicode(false);

                entity.Property(e => e.Usercrtobjectid).IsUnicode(false);

                entity.Property(e => e.Userdeleted).IsUnicode(false);

                entity.Property(e => e.Userid).IsUnicode(false);

                entity.Property(e => e.Userupdated).IsUnicode(false);
            });

            modelBuilder.Entity<PersongreivanceV>(entity =>
            {
                entity.ToView("PERSONGREIVANCE_V");

                entity.Property(e => e.CarBrandCode).IsUnicode(false);

                entity.Property(e => e.CarGuid).IsUnicode(false);

                entity.Property(e => e.CarOpModelCode).IsUnicode(false);

                entity.Property(e => e.CarRegnNo).IsUnicode(false);

                entity.Property(e => e.CarSecGuid).IsUnicode(false);

                entity.Property(e => e.Comments).IsUnicode(false);

                entity.Property(e => e.Complaintdetails).IsUnicode(false);

                entity.Property(e => e.Complaintid).HasPrecision(10);

                entity.Property(e => e.Description).IsUnicode(false);

                entity.Property(e => e.Disabled).HasPrecision(1);

                entity.Property(e => e.EntityCode).IsUnicode(false);

                entity.Property(e => e.Guid).IsUnicode(false);

                entity.Property(e => e.MentorFullName).IsUnicode(false);

                entity.Property(e => e.Mentorid).IsUnicode(false);

                entity.Property(e => e.Name).IsUnicode(false);

                entity.Property(e => e.PersFname).IsUnicode(false);

                entity.Property(e => e.PersLname).IsUnicode(false);

                entity.Property(e => e.PersMname).IsUnicode(false);

                entity.Property(e => e.PersTitle).IsUnicode(false);

                entity.Property(e => e.Personguid).IsUnicode(false);

                entity.Property(e => e.Personid).IsUnicode(false);

                entity.Property(e => e.PhoneGuid).IsUnicode(false);

                entity.Property(e => e.PhoneNo).IsUnicode(false);

                entity.Property(e => e.PhoneObjVerNo).HasPrecision(10);

                entity.Property(e => e.PhoneTypeCode).IsUnicode(false);

                entity.Property(e => e.PhoneTypeName).IsUnicode(false);

                entity.Property(e => e.Pkguid).IsUnicode(false);

                entity.Property(e => e.Quickaccesscode).IsUnicode(false);

                entity.Property(e => e.Resolvedetails).IsUnicode(false);

                entity.Property(e => e.StatusCode).IsUnicode(false);

                entity.Property(e => e.StatusDesc).IsUnicode(false);

                entity.Property(e => e.StatusEntEntguid).IsUnicode(false);

                entity.Property(e => e.StatusEntObjVerNo).HasPrecision(10);

                entity.Property(e => e.StatusEntStsguid).IsUnicode(false);

                entity.Property(e => e.StatusName).IsUnicode(false);

                entity.Property(e => e.Statusentityguid).IsUnicode(false);
            });

            modelBuilder.Entity<PersonlistBaseV>(entity =>
            {
                entity.ToView("PERSONLIST_BASE_V");

                entity.Property(e => e.DriverStatus).IsUnicode(false);

                entity.Property(e => e.DriverStatusName).IsUnicode(false);

                entity.Property(e => e.EntityCode).IsUnicode(false);

                entity.Property(e => e.MentorFullName).IsUnicode(false);

                entity.Property(e => e.Mentorid).IsUnicode(false);

                entity.Property(e => e.PersBioid).IsUnicode(false);

                entity.Property(e => e.PersDisabled).HasPrecision(1);

                entity.Property(e => e.PersDriverflag).HasPrecision(1);

                entity.Property(e => e.PersDseflag).HasPrecision(1);

                entity.Property(e => e.PersFname).IsUnicode(false);

                entity.Property(e => e.PersGender).IsUnicode(false);

                entity.Property(e => e.PersGuid).IsUnicode(false);

                entity.Property(e => e.PersLname).IsUnicode(false);

                entity.Property(e => e.PersMname).IsUnicode(false);

                entity.Property(e => e.PersObjVerNo).HasPrecision(10);

                entity.Property(e => e.PersSpflag).HasPrecision(1);

                entity.Property(e => e.PersStatusCode).IsUnicode(false);

                entity.Property(e => e.PersTitle).IsUnicode(false);

                entity.Property(e => e.Personid).IsUnicode(false);

                entity.Property(e => e.PhoneGuid).IsUnicode(false);

                entity.Property(e => e.PhoneNo).IsUnicode(false);

                entity.Property(e => e.PhoneObjVerNo).HasPrecision(10);

                entity.Property(e => e.PhoneTypeCode).IsUnicode(false);

                entity.Property(e => e.PhoneTypeName).IsUnicode(false);

                entity.Property(e => e.SpStatus).IsUnicode(false);

                entity.Property(e => e.SpStatusName).IsUnicode(false);

                entity.Property(e => e.StatusDesc).IsUnicode(false);

                entity.Property(e => e.StatusEntEntguid).IsUnicode(false);

                entity.Property(e => e.StatusEntGuid).IsUnicode(false);

                entity.Property(e => e.StatusEntObjVerNo).HasPrecision(10);

                entity.Property(e => e.StatusEntStsguid).IsUnicode(false);

                entity.Property(e => e.StatusName).IsUnicode(false);
            });

            modelBuilder.Entity<PersonlistV>(entity =>
            {
                entity.ToView("PERSONLIST_V");

                entity.Property(e => e.DriverStatus).IsUnicode(false);

                entity.Property(e => e.DriverStatusName).IsUnicode(false);

                entity.Property(e => e.EntityCode).IsUnicode(false);

                entity.Property(e => e.MentorFullName).IsUnicode(false);

                entity.Property(e => e.Mentorid).IsUnicode(false);

                entity.Property(e => e.PersBioid).IsUnicode(false);

                entity.Property(e => e.PersDisabled).HasPrecision(1);

                entity.Property(e => e.PersDriverflag).HasPrecision(1);

                entity.Property(e => e.PersDseflag).HasPrecision(1);

                entity.Property(e => e.PersFname).IsUnicode(false);

                entity.Property(e => e.PersGender).IsUnicode(false);

                entity.Property(e => e.PersGuid).IsUnicode(false);

                entity.Property(e => e.PersLname).IsUnicode(false);

                entity.Property(e => e.PersMname).IsUnicode(false);

                entity.Property(e => e.PersObjVerNo).HasPrecision(10);

                entity.Property(e => e.PersSpflag).HasPrecision(1);

                entity.Property(e => e.PersStatusCode).IsUnicode(false);

                entity.Property(e => e.PersTitle).IsUnicode(false);

                entity.Property(e => e.Personid).IsUnicode(false);

                entity.Property(e => e.PhoneGuid).IsUnicode(false);

                entity.Property(e => e.PhoneNo).IsUnicode(false);

                entity.Property(e => e.PhoneObjVerNo).HasPrecision(10);

                entity.Property(e => e.PhoneTypeCode).IsUnicode(false);

                entity.Property(e => e.PhoneTypeName).IsUnicode(false);

                entity.Property(e => e.SpStatus).IsUnicode(false);

                entity.Property(e => e.SpStatusName).IsUnicode(false);

                entity.Property(e => e.StatusDesc).IsUnicode(false);

                entity.Property(e => e.StatusEntEntguid).IsUnicode(false);

                entity.Property(e => e.StatusEntGuid).IsUnicode(false);

                entity.Property(e => e.StatusEntObjVerNo).HasPrecision(10);

                entity.Property(e => e.StatusEntStsguid).IsUnicode(false);

                entity.Property(e => e.StatusName).IsUnicode(false);
            });

            modelBuilder.Entity<Personmaster>(entity =>
            {
                entity.Property(e => e.Biometricid).IsUnicode(false);

                entity.Property(e => e.Businesscategory).IsUnicode(false);

                entity.Property(e => e.Disabled).HasPrecision(1);

                entity.Property(e => e.Driverflag).HasPrecision(1);

                entity.Property(e => e.Dseflag).HasPrecision(1);

                entity.Property(e => e.Firstname).IsUnicode(false);

                entity.Property(e => e.Gender).IsUnicode(false);

                entity.Property(e => e.Guid).IsUnicode(false);

                entity.Property(e => e.Isdriversentforinduction).HasPrecision(5);

                entity.Property(e => e.Isspsentforinduction).HasPrecision(5);

                entity.Property(e => e.Lastname).IsUnicode(false);

                entity.Property(e => e.Leadreferenceguid).IsUnicode(false);

                entity.Property(e => e.Mentorreferenceid).IsUnicode(false);

                entity.Property(e => e.Middlename).IsUnicode(false);

                entity.Property(e => e.Objectversionno).HasPrecision(10);

                entity.Property(e => e.Oracleentityid).IsUnicode(false);

                entity.Property(e => e.Oracleentityname).IsUnicode(false);

                entity.Property(e => e.Personid).IsUnicode(false);

                entity.Property(e => e.Pkguid).IsUnicode(false);

                entity.Property(e => e.Reasonmasterguid).IsUnicode(false);

                entity.Property(e => e.Sparefieldstring1).IsUnicode(false);

                entity.Property(e => e.Sparefieldstring2).IsUnicode(false);

                entity.Property(e => e.Sparefieldstring3).IsUnicode(false);

                entity.Property(e => e.Spclientmapguid).IsUnicode(false);

                entity.Property(e => e.Spflag).HasPrecision(1);

                entity.Property(e => e.Statusentityguid).IsUnicode(false);

                entity.Property(e => e.Title).IsUnicode(false);

                entity.Property(e => e.Userarchived).IsUnicode(false);

                entity.Property(e => e.Usercreated).IsUnicode(false);

                entity.Property(e => e.Userdeleted).IsUnicode(false);

                entity.Property(e => e.Userupdated).IsUnicode(false);
            });

            modelBuilder.Entity<PersonphoneBaseV>(entity =>
            {
                entity.ToView("PERSONPHONE_BASE_V");

                entity.Property(e => e.Countrycode).IsUnicode(false);

                entity.Property(e => e.Countrymasterguid).IsUnicode(false);

                entity.Property(e => e.Countryname).IsUnicode(false);

                entity.Property(e => e.PersFname).IsUnicode(false);

                entity.Property(e => e.PersLname).IsUnicode(false);

                entity.Property(e => e.PersMname).IsUnicode(false);

                entity.Property(e => e.Personid).IsUnicode(false);

                entity.Property(e => e.PhoneGuid).IsUnicode(false);

                entity.Property(e => e.PhoneNo).IsUnicode(false);

                entity.Property(e => e.PhoneObjVerNo).HasPrecision(10);

                entity.Property(e => e.PhonePersGuid).IsUnicode(false);

                entity.Property(e => e.PhoneTypeCode).IsUnicode(false);

                entity.Property(e => e.PhoneTypeName).IsUnicode(false);

                entity.Property(e => e.Primaryflag).HasPrecision(1);
            });

            modelBuilder.Entity<PersonphoneV>(entity =>
            {
                entity.ToView("PERSONPHONE_V");

                entity.Property(e => e.Countrycode).IsUnicode(false);

                entity.Property(e => e.Countrymasterguid).IsUnicode(false);

                entity.Property(e => e.Countryname).IsUnicode(false);

                entity.Property(e => e.PersFname).IsUnicode(false);

                entity.Property(e => e.PersLname).IsUnicode(false);

                entity.Property(e => e.PersMname).IsUnicode(false);

                entity.Property(e => e.Personid).IsUnicode(false);

                entity.Property(e => e.PhoneGuid).IsUnicode(false);

                entity.Property(e => e.PhoneNo).IsUnicode(false);

                entity.Property(e => e.PhoneObjVerNo).HasPrecision(10);

                entity.Property(e => e.PhonePersGuid).IsUnicode(false);

                entity.Property(e => e.PhoneTypeCode).IsUnicode(false);

                entity.Property(e => e.PhoneTypeName).IsUnicode(false);

                entity.Property(e => e.Primaryflag).HasPrecision(1);
            });

            modelBuilder.Entity<PhotographinsertStg>(entity =>
            {
                entity.Property(e => e.Personid).IsUnicode(false);

                entity.Property(e => e.Status).IsUnicode(false);
            });

            modelBuilder.Entity<Pkgcabsdailycalculation>(entity =>
            {
                entity.HasKey(e => e.Guid)
                    .HasName("PKGCABSDAILYCALCULATION_PK");

                entity.Property(e => e.Guid).IsUnicode(false);

                entity.Property(e => e.Apicomments).IsUnicode(false);

                entity.Property(e => e.Cabno).IsUnicode(false);

                entity.Property(e => e.Comments).IsUnicode(false);

                entity.Property(e => e.Datecreated).HasDefaultValueSql("sysdate");

                entity.Property(e => e.Groupvariantguid).IsUnicode(false);

                entity.Property(e => e.Iseligibleforshift).HasPrecision(1);

                entity.Property(e => e.Isprorata).HasPrecision(1);

                entity.Property(e => e.Qualified).HasPrecision(1);

                entity.Property(e => e.Spid).IsUnicode(false);

                entity.Property(e => e.Status).IsUnicode(false);
            });

            modelBuilder.Entity<Pkgcabsmonthlycalculation>(entity =>
            {
                entity.HasKey(e => e.Guid)
                    .HasName("PKGCABSMONTHLYCALCULATION_PK");

                entity.Property(e => e.Guid).IsUnicode(false);

                entity.Property(e => e.Cabno).IsUnicode(false);

                entity.Property(e => e.Comments).IsUnicode(false);

                entity.Property(e => e.Datecreated).HasDefaultValueSql("sysdate");

                entity.Property(e => e.Groupvariantguid).IsUnicode(false);

                entity.Property(e => e.Qualified).HasPrecision(1);

                entity.Property(e => e.Spid).IsUnicode(false);

                entity.Property(e => e.Status).IsUnicode(false);
            });

            modelBuilder.Entity<Pkgcabstaskexecution>(entity =>
            {
                entity.HasKey(e => e.Guid)
                    .HasName("PKGCABS_TASK_EXECUTION_PK");

                entity.Property(e => e.Guid).IsUnicode(false);

                entity.Property(e => e.Activityname).IsUnicode(false);

                entity.Property(e => e.Datecreated).HasDefaultValueSql("sysdate ");

                entity.Property(e => e.Dateupdated).HasDefaultValueSql("NULL ");

                entity.Property(e => e.Remark1).IsUnicode(false);

                entity.Property(e => e.Remark2).IsUnicode(false);

                entity.Property(e => e.Statuscode).IsUnicode(false);
            });

            modelBuilder.Entity<PoliceVerificationV>(entity =>
            {
                entity.ToView("POLICE_VERIFICATION_V");

                entity.Property(e => e.DocFileName).IsUnicode(false);

                entity.Property(e => e.DocGuid).IsUnicode(false);

                entity.Property(e => e.DocNo).IsUnicode(false);

                entity.Property(e => e.DocObjVerNo).HasPrecision(10);

                entity.Property(e => e.DocPurpose).IsUnicode(false);

                entity.Property(e => e.DocPurposeCode).IsUnicode(false);

                entity.Property(e => e.DocStatusCode).IsUnicode(false);

                entity.Property(e => e.DocStatusName).IsUnicode(false);

                entity.Property(e => e.DocType).IsUnicode(false);

                entity.Property(e => e.DocTypeCode).IsUnicode(false);

                entity.Property(e => e.Escalationdays).HasPrecision(10);

                entity.Property(e => e.PersFname).IsUnicode(false);

                entity.Property(e => e.PersGuid).IsUnicode(false);

                entity.Property(e => e.PersLname).IsUnicode(false);

                entity.Property(e => e.PersMname).IsUnicode(false);

                entity.Property(e => e.PersonId).IsUnicode(false);

                entity.Property(e => e.Renewaldays).HasPrecision(10);
            });

            modelBuilder.Entity<PostTxnTble>(entity =>
            {
                entity.Property(e => e.Oracleentityid).IsUnicode(false);
            });

            modelBuilder.Entity<PragatiInterfaceServiceLog>(entity =>
            {
                entity.Property(e => e.ResponseComments).IsUnicode(false);
            });

            modelBuilder.Entity<QcCheckNo>(entity =>
            {
                entity.Property(e => e.Carguid).IsUnicode(false);

                entity.Property(e => e.Carpkguid).IsUnicode(false);

                entity.Property(e => e.Comments).IsUnicode(false);

                entity.Property(e => e.Disabled).HasPrecision(1);

                entity.Property(e => e.Guid).IsUnicode(false);

                entity.Property(e => e.Objectversionno).HasPrecision(10);

                entity.Property(e => e.Oracleentityid).IsUnicode(false);

                entity.Property(e => e.Oracleentityname).IsUnicode(false);

                entity.Property(e => e.Pkguid).IsUnicode(false);

                entity.Property(e => e.QcDocNo).IsUnicode(false);

                entity.Property(e => e.Userarchived).IsUnicode(false);

                entity.Property(e => e.Usercreated).IsUnicode(false);

                entity.Property(e => e.Userdeleted).IsUnicode(false);

                entity.Property(e => e.Userupdated).IsUnicode(false);
            });

            modelBuilder.Entity<Questionbankcategorymaster>(entity =>
            {
                entity.Property(e => e.Comments).IsUnicode(false);

                entity.Property(e => e.Description).IsUnicode(false);

                entity.Property(e => e.Disabled)
                    .HasPrecision(1)
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Guid).IsUnicode(false);

                entity.Property(e => e.Name).IsUnicode(false);

                entity.Property(e => e.Objectversionno).HasPrecision(3);

                entity.Property(e => e.Oracleentityid).IsUnicode(false);

                entity.Property(e => e.Oracleentityname).IsUnicode(false);

                entity.Property(e => e.Pkguid).IsUnicode(false);

                entity.Property(e => e.Questioncategoryserialno).HasPrecision(5);

                entity.Property(e => e.Quickaccesscode).IsUnicode(false);

                entity.Property(e => e.Userarchived).IsUnicode(false);

                entity.Property(e => e.Usercreated).IsUnicode(false);

                entity.Property(e => e.Userdeleted).IsUnicode(false);

                entity.Property(e => e.Userupdated).IsUnicode(false);
            });

            modelBuilder.Entity<Questionbankmaster>(entity =>
            {
                entity.Property(e => e.Answertypemasterguid).IsUnicode(false);

                entity.Property(e => e.Comments).IsUnicode(false);

                entity.Property(e => e.Defaultanswermasterguid).IsUnicode(false);

                entity.Property(e => e.Description).IsUnicode(false);

                entity.Property(e => e.Disabled)
                    .HasPrecision(1)
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Guid).IsUnicode(false);

                entity.Property(e => e.Inspectioncategorymasterguid).IsUnicode(false);

                entity.Property(e => e.Name).IsUnicode(false);

                entity.Property(e => e.Objectversionno).HasPrecision(3);

                entity.Property(e => e.Oracleentityid).IsUnicode(false);

                entity.Property(e => e.Oracleentityname).IsUnicode(false);

                entity.Property(e => e.Pkguid).IsUnicode(false);

                entity.Property(e => e.Questionbankcategorymasterguid).IsUnicode(false);

                entity.Property(e => e.Questionserialno).HasPrecision(5);

                entity.Property(e => e.Quickaccesscode).IsUnicode(false);

                entity.Property(e => e.Userarchived).IsUnicode(false);

                entity.Property(e => e.Usercreated).IsUnicode(false);

                entity.Property(e => e.Userdeleted).IsUnicode(false);

                entity.Property(e => e.Userupdated).IsUnicode(false);
            });

            modelBuilder.Entity<RaTerm>(entity =>
            {
                entity.Property(e => e.Description).IsUnicode(false);

                entity.Property(e => e.Name).IsUnicode(false);
            });

            modelBuilder.Entity<RatingV>(entity =>
            {
                entity.ToView("RATING_V");

                entity.Property(e => e.Bookingreferenceno).IsUnicode(false);

                entity.Property(e => e.Carmasterguid).IsUnicode(false);

                entity.Property(e => e.Carregistrationno).IsUnicode(false);

                entity.Property(e => e.Complainttakenuser).IsUnicode(false);

                entity.Property(e => e.Drivermasterguid).IsUnicode(false);

                entity.Property(e => e.Feedbackdetails).IsUnicode(false);

                entity.Property(e => e.Pkguid).IsUnicode(false);

                entity.Property(e => e.Remarks).IsUnicode(false);

                entity.Property(e => e.Securitycombinationguid).IsUnicode(false);

                entity.Property(e => e.Serviceproviderguid).IsUnicode(false);

                entity.Property(e => e.Siteguid).IsUnicode(false);

                entity.Property(e => e.Statusentityguid).IsUnicode(false);

                entity.Property(e => e.Tripguid).IsUnicode(false);

                entity.Property(e => e.Tripid).IsUnicode(false);
            });

            modelBuilder.Entity<Ratingmaster>(entity =>
            {
                entity.Property(e => e.Comments).IsUnicode(false);

                entity.Property(e => e.Description).IsUnicode(false);

                entity.Property(e => e.Disabled)
                    .HasPrecision(1)
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Guid).IsUnicode(false);

                entity.Property(e => e.Name).IsUnicode(false);

                entity.Property(e => e.Objectversionno).IsUnicode(false);

                entity.Property(e => e.Oracleentityid).IsUnicode(false);

                entity.Property(e => e.Oracleentityname).IsUnicode(false);

                entity.Property(e => e.Pkguid).IsUnicode(false);

                entity.Property(e => e.Userarchived).IsUnicode(false);

                entity.Property(e => e.Usercreated).IsUnicode(false);

                entity.Property(e => e.Userdeleted).IsUnicode(false);

                entity.Property(e => e.Userupdated).IsUnicode(false);
            });

            modelBuilder.Entity<RazorPayTxn>(entity =>
            {
                entity.HasKey(e => e.Merupaymentid)
                    .HasName("RAZOR_PAY_TXN_PK");

                entity.Property(e => e.Merupaymentid).IsUnicode(false);

                entity.Property(e => e.Carno).IsUnicode(false);

                entity.Property(e => e.Paymentmettype).IsUnicode(false);

                entity.Property(e => e.Paymentname).IsUnicode(false);

                entity.Property(e => e.Paymentrefid).IsUnicode(false);

                entity.Property(e => e.Pragatistatus).IsUnicode(false);

                entity.Property(e => e.Pragatittxnid).IsUnicode(false);

                entity.Property(e => e.Spid).IsUnicode(false);
            });

            modelBuilder.Entity<Reasonmaster>(entity =>
            {
                entity.Property(e => e.Comments).IsUnicode(false);

                entity.Property(e => e.Description).IsUnicode(false);

                entity.Property(e => e.Disabled).HasPrecision(1);

                entity.Property(e => e.Guid).IsUnicode(false);

                entity.Property(e => e.Name).IsUnicode(false);

                entity.Property(e => e.Objectversionno).HasPrecision(10);

                entity.Property(e => e.Oracleentityid).IsUnicode(false);

                entity.Property(e => e.Oracleentityname).IsUnicode(false);

                entity.Property(e => e.Pkguid).IsUnicode(false);

                entity.Property(e => e.Quickaccesscode).IsUnicode(false);

                entity.Property(e => e.Statuscolor).IsUnicode(false);

                entity.Property(e => e.Userarchived).IsUnicode(false);

                entity.Property(e => e.Usercreated).IsUnicode(false);

                entity.Property(e => e.Userdeleted).IsUnicode(false);

                entity.Property(e => e.Userupdated).IsUnicode(false);
            });

            modelBuilder.Entity<ReceipttypeV>(entity =>
            {
                entity.ToView("RECEIPTTYPE_V");

                entity.Property(e => e.BranchCode).IsUnicode(false);

                entity.Property(e => e.Guid).IsUnicode(false);

                entity.Property(e => e.Legalentity).IsUnicode(false);

                entity.Property(e => e.Name).IsUnicode(false);

                entity.Property(e => e.Quickaccesscode).IsUnicode(false);
            });

            modelBuilder.Entity<Reinduction>(entity =>
            {
                entity.Property(e => e.Comments).IsUnicode(false);

                entity.Property(e => e.Disabled).HasPrecision(1);

                entity.Property(e => e.Guid).IsUnicode(false);

                entity.Property(e => e.Isapprovalrequired)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Objectversionno).HasPrecision(10);

                entity.Property(e => e.Oracleentityid).IsUnicode(false);

                entity.Property(e => e.Oracleentityname).IsUnicode(false);

                entity.Property(e => e.Personmasterguid).IsUnicode(false);

                entity.Property(e => e.Pkguid).IsUnicode(false);

                entity.Property(e => e.Reasonmasterguid).IsUnicode(false);

                entity.Property(e => e.Reinductiontype).IsUnicode(false);

                entity.Property(e => e.Securitycombinationguid).IsUnicode(false);

                entity.Property(e => e.Spsitemasterguid).IsUnicode(false);

                entity.Property(e => e.Statusentityguid).IsUnicode(false);

                entity.Property(e => e.Userarchived).IsUnicode(false);

                entity.Property(e => e.Usercreated).IsUnicode(false);

                entity.Property(e => e.Userdeleted).IsUnicode(false);

                entity.Property(e => e.Userupdated).IsUnicode(false);
            });

            modelBuilder.Entity<ReinductionV>(entity =>
            {
                entity.ToView("REINDUCTION_V");

                entity.Property(e => e.EntityCode).IsUnicode(false);

                entity.Property(e => e.Guid).IsUnicode(false);

                entity.Property(e => e.Isapprovalrequired)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Objectversionno).HasPrecision(10);

                entity.Property(e => e.PersBioid).IsUnicode(false);

                entity.Property(e => e.PersDriverflag).HasPrecision(1);

                entity.Property(e => e.PersDseflag).HasPrecision(1);

                entity.Property(e => e.PersFname).IsUnicode(false);

                entity.Property(e => e.PersGender).IsUnicode(false);

                entity.Property(e => e.PersLname).IsUnicode(false);

                entity.Property(e => e.PersMname).IsUnicode(false);

                entity.Property(e => e.PersObjVerNo).HasPrecision(10);

                entity.Property(e => e.PersSpflag).HasPrecision(1);

                entity.Property(e => e.PersStatusCode).IsUnicode(false);

                entity.Property(e => e.PersTitle).IsUnicode(false);

                entity.Property(e => e.Personid).IsUnicode(false);

                entity.Property(e => e.Personmasterguid).IsUnicode(false);

                entity.Property(e => e.Pkguid).IsUnicode(false);

                entity.Property(e => e.ReinductionStatusCode).IsUnicode(false);

                entity.Property(e => e.ReinductionStatusDesc).IsUnicode(false);

                entity.Property(e => e.ReinductionStatusName).IsUnicode(false);

                entity.Property(e => e.Spsitemasterguid).IsUnicode(false);

                entity.Property(e => e.StatusEntEntguid).IsUnicode(false);

                entity.Property(e => e.StatusEntObjVerNo).HasPrecision(10);

                entity.Property(e => e.StatusEntStsguid).IsUnicode(false);

                entity.Property(e => e.Statusentityguid).IsUnicode(false);
            });

            modelBuilder.Entity<ReinspectionscheduleV>(entity =>
            {
                entity.ToView("REINSPECTIONSCHEDULE_V");

                entity.Property(e => e.Branchmasterguid).IsUnicode(false);

                entity.Property(e => e.Carmasterguid).IsUnicode(false);

                entity.Property(e => e.Guid).IsUnicode(false);

                entity.Property(e => e.Inspectionresultguid).IsUnicode(false);

                entity.Property(e => e.Inspecttype).IsUnicode(false);

                entity.Property(e => e.Pkguid).IsUnicode(false);

                entity.Property(e => e.Schedulestatusentityguid).IsUnicode(false);

                entity.Property(e => e.Slotno).HasPrecision(3);

                entity.Property(e => e.Workshopmasterguid).IsUnicode(false);
            });

            modelBuilder.Entity<Report>(entity =>
            {
                entity.Property(e => e.RepCode).IsUnicode(false);

                entity.Property(e => e.RepGroupId).IsUnicode(false);

                entity.Property(e => e.RepGuid).IsUnicode(false);

                entity.Property(e => e.RepName).IsUnicode(false);

                entity.Property(e => e.SecurityEnableFlag).HasPrecision(1);

                entity.Property(e => e.Usercreated).IsUnicode(false);

                entity.Property(e => e.Userupdated).IsUnicode(false);
            });

            modelBuilder.Entity<Reportexecution>(entity =>
            {
                entity.HasKey(e => e.Guid)
                    .HasName("PK_GUID");

                entity.Property(e => e.Guid).IsUnicode(false);

                entity.Property(e => e.Parametertextfield1).IsUnicode(false);

                entity.Property(e => e.Parametertextfield2).IsUnicode(false);

                entity.Property(e => e.Parametertextfield3).IsUnicode(false);

                entity.Property(e => e.Parametertextfield4).IsUnicode(false);

                entity.Property(e => e.Parametertextfield5).IsUnicode(false);

                entity.Property(e => e.Reportguid).IsUnicode(false);

                entity.Property(e => e.Securitycombinationguid).IsUnicode(false);

                entity.Property(e => e.Usercreated).IsUnicode(false);

                entity.Property(e => e.Userupdated).IsUnicode(false);
            });

            modelBuilder.Entity<ReportexecutionV>(entity =>
            {
                entity.ToView("REPORTEXECUTION_V");

                entity.Property(e => e.Guid).IsUnicode(false);

                entity.Property(e => e.Parametertextfield1).IsUnicode(false);

                entity.Property(e => e.Parametertextfield2).IsUnicode(false);

                entity.Property(e => e.Parametertextfield3).IsUnicode(false);

                entity.Property(e => e.Parametertextfield4).IsUnicode(false);

                entity.Property(e => e.Parametertextfield5).IsUnicode(false);

                entity.Property(e => e.Reportguid).IsUnicode(false);

                entity.Property(e => e.Securitycombinationguid).IsUnicode(false);
            });

            modelBuilder.Entity<Reportgroup>(entity =>
            {
                entity.Property(e => e.Description).IsUnicode(false);

                entity.Property(e => e.Guid).IsUnicode(false);

                entity.Property(e => e.Reportgroupname).IsUnicode(false);

                entity.Property(e => e.Usercreated).IsUnicode(false);

                entity.Property(e => e.Userupdated).IsUnicode(false);
            });

            modelBuilder.Entity<Reportparameter>(entity =>
            {
                entity.Property(e => e.DisplayDatatype).IsUnicode(false);

                entity.Property(e => e.ParamColDefaultValue).IsUnicode(false);

                entity.Property(e => e.ParamColDisplayName).IsUnicode(false);

                entity.Property(e => e.ParamColName).IsUnicode(false);

                entity.Property(e => e.ParamType).IsUnicode(false);

                entity.Property(e => e.ParamValidationViewname).IsUnicode(false);

                entity.Property(e => e.RepId).IsUnicode(false);

                entity.Property(e => e.RepParamGuid).IsUnicode(false);

                entity.Property(e => e.Usercreated).IsUnicode(false);

                entity.Property(e => e.Userupdated).IsUnicode(false);
            });

            modelBuilder.Entity<Resultsmaster>(entity =>
            {
                entity.Property(e => e.Comments).IsUnicode(false);

                entity.Property(e => e.Description).IsUnicode(false);

                entity.Property(e => e.Disabled)
                    .HasPrecision(1)
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Guid).IsUnicode(false);

                entity.Property(e => e.Name).IsUnicode(false);

                entity.Property(e => e.Objectversionno).HasPrecision(3);

                entity.Property(e => e.Oracleentityid).IsUnicode(false);

                entity.Property(e => e.Oracleentityname).IsUnicode(false);

                entity.Property(e => e.Pkguid).IsUnicode(false);

                entity.Property(e => e.Quickaccesscode).IsUnicode(false);

                entity.Property(e => e.Userarchived).IsUnicode(false);

                entity.Property(e => e.Usercreated).IsUnicode(false);

                entity.Property(e => e.Userdeleted).IsUnicode(false);

                entity.Property(e => e.Userupdated).IsUnicode(false);
            });

            modelBuilder.Entity<RetErrLog>(entity =>
            {
                entity.Property(e => e.ErrorText).IsUnicode(false);

                entity.Property(e => e.XmlText).IsUnicode(false);
            });

            modelBuilder.Entity<RetLog>(entity =>
            {
                entity.Property(e => e.PSuccessful).IsUnicode(false);

                entity.Property(e => e.Result).IsUnicode(false);
            });

            modelBuilder.Entity<RevenueReport>(entity =>
            {
                entity.Property(e => e.CarNo).IsUnicode(false);

                entity.Property(e => e.City).IsUnicode(false);

                entity.Property(e => e.LeName).IsUnicode(false);

                entity.Property(e => e.Model).IsUnicode(false);

                entity.Property(e => e.Siteguid).IsUnicode(false);

                entity.Property(e => e.SpId).IsUnicode(false);

                entity.Property(e => e.Usercreated).IsUnicode(false);
            });

            modelBuilder.Entity<RoleActionV>(entity =>
            {
                entity.ToView("ROLE_ACTION_V");

                entity.Property(e => e.Pageactions).IsUnicode(false);

                entity.Property(e => e.Pagename).IsUnicode(false);

                entity.Property(e => e.Roleguid).IsUnicode(false);

                entity.Property(e => e.Rolename).IsUnicode(false);
            });

            modelBuilder.Entity<Rolemaster>(entity =>
            {
                entity.Property(e => e.Comments).IsUnicode(false);

                entity.Property(e => e.Description).IsUnicode(false);

                entity.Property(e => e.Disabled).HasPrecision(1);

                entity.Property(e => e.Guid).IsUnicode(false);

                entity.Property(e => e.Name).IsUnicode(false);

                entity.Property(e => e.Objectversionno).HasPrecision(10);

                entity.Property(e => e.Oracleentityid).IsUnicode(false);

                entity.Property(e => e.Oracleentityname).IsUnicode(false);

                entity.Property(e => e.Pkguid).IsUnicode(false);

                entity.Property(e => e.Quickaccesscode).IsUnicode(false);

                entity.Property(e => e.Userarchived).IsUnicode(false);

                entity.Property(e => e.Usercreated).IsUnicode(false);

                entity.Property(e => e.Userdeleted).IsUnicode(false);

                entity.Property(e => e.Userupdated).IsUnicode(false);
            });

            modelBuilder.Entity<Rolemenu>(entity =>
            {
                entity.Property(e => e.Comments).IsUnicode(false);

                entity.Property(e => e.Description).IsUnicode(false);

                entity.Property(e => e.Disabled).HasPrecision(1);

                entity.Property(e => e.Guid).IsUnicode(false);

                entity.Property(e => e.Menumasterguid).IsUnicode(false);

                entity.Property(e => e.Name).IsUnicode(false);

                entity.Property(e => e.Objectversionno).HasPrecision(10);

                entity.Property(e => e.Oracleentityid).IsUnicode(false);

                entity.Property(e => e.Oracleentityname).IsUnicode(false);

                entity.Property(e => e.Pkguid).IsUnicode(false);

                entity.Property(e => e.Quickaccesscode).IsUnicode(false);

                entity.Property(e => e.Rolemasterguid).IsUnicode(false);

                entity.Property(e => e.Userarchived).IsUnicode(false);

                entity.Property(e => e.Usercreated).IsUnicode(false);

                entity.Property(e => e.Userdeleted).IsUnicode(false);

                entity.Property(e => e.Userupdated).IsUnicode(false);
            });

            modelBuilder.Entity<Rolereportgroup>(entity =>
            {
                entity.Property(e => e.Guid).IsUnicode(false);

                entity.Property(e => e.Reportgroupguid).IsUnicode(false);

                entity.Property(e => e.Roleguid).IsUnicode(false);
            });

            modelBuilder.Entity<RolereportgroupV>(entity =>
            {
                entity.ToView("ROLEREPORTGROUP_V");

                entity.Property(e => e.Reportgroupguid).IsUnicode(false);

                entity.Property(e => e.Reportgroupname).IsUnicode(false);

                entity.Property(e => e.Roleguid).IsUnicode(false);

                entity.Property(e => e.Rolename).IsUnicode(false);

                entity.Property(e => e.Rolequickaccesscode).IsUnicode(false);

                entity.Property(e => e.Rolereportgroupguid).IsUnicode(false);
            });

            modelBuilder.Entity<Rolesecuritycombination>(entity =>
            {
                entity.Property(e => e.Comments).IsUnicode(false);

                entity.Property(e => e.Description).IsUnicode(false);

                entity.Property(e => e.Disabled).HasPrecision(1);

                entity.Property(e => e.Guid).IsUnicode(false);

                entity.Property(e => e.Isdefault).IsUnicode(false);

                entity.Property(e => e.Name).IsUnicode(false);

                entity.Property(e => e.Objectversionno).HasPrecision(10);

                entity.Property(e => e.Oracleentityid).IsUnicode(false);

                entity.Property(e => e.Oracleentityname).IsUnicode(false);

                entity.Property(e => e.Pkguid).IsUnicode(false);

                entity.Property(e => e.Quickaccesscode).IsUnicode(false);

                entity.Property(e => e.Responsibilityid).IsUnicode(false);

                entity.Property(e => e.Securitycombinationguid).IsUnicode(false);

                entity.Property(e => e.Userarchived).IsUnicode(false);

                entity.Property(e => e.Usercreated).IsUnicode(false);

                entity.Property(e => e.Userdeleted).IsUnicode(false);

                entity.Property(e => e.Userroleguid).IsUnicode(false);

                entity.Property(e => e.Userupdated).IsUnicode(false);
            });

            modelBuilder.Entity<Routemaster>(entity =>
            {
                entity.HasKey(e => e.Routeid)
                    .HasName("ROUTEMASTER_PK");

                entity.Property(e => e.Brand).IsUnicode(false);

                entity.Property(e => e.Datecreated).HasDefaultValueSql("SYSDATE");

                entity.Property(e => e.Destination).IsUnicode(false);

                entity.Property(e => e.Disabled)
                    .HasPrecision(1)
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Source).IsUnicode(false);
            });

            modelBuilder.Entity<RpBackup>(entity =>
            {
                entity.Property(e => e.MainQueryText).IsUnicode(false);

                entity.Property(e => e.RepCode).IsUnicode(false);

                entity.Property(e => e.RepGroupId).IsUnicode(false);

                entity.Property(e => e.RepGuid).IsUnicode(false);

                entity.Property(e => e.RepName).IsUnicode(false);

                entity.Property(e => e.SecurityEnableFlag).HasPrecision(1);

                entity.Property(e => e.Usercreated).IsUnicode(false);

                entity.Property(e => e.Userupdated).IsUnicode(false);
            });

            modelBuilder.Entity<RuleBackup>(entity =>
            {
                entity.Property(e => e.EnabledFlag).IsUnicode(false);

                entity.Property(e => e.Entity).IsUnicode(false);

                entity.Property(e => e.LebranchGuid).IsUnicode(false);

                entity.Property(e => e.ModelGuid).IsUnicode(false);

                entity.Property(e => e.RuleName).IsUnicode(false);

                entity.Property(e => e.SecurityGuid).IsUnicode(false);

                entity.Property(e => e.ViewCol).IsUnicode(false);

                entity.Property(e => e.ViewName).IsUnicode(false);
            });

            modelBuilder.Entity<RuleCarDriverV>(entity =>
            {
                entity.ToView("RULE_CAR_DRIVER_V");

                entity.Property(e => e.CarGuid).IsUnicode(false);

                entity.Property(e => e.CarRegnNo).IsUnicode(false);

                entity.Property(e => e.CardriverGuid).IsUnicode(false);

                entity.Property(e => e.Driverguid).IsUnicode(false);
            });

            modelBuilder.Entity<RulePhone>(entity =>
            {
                entity.ToView("RULE_PHONE");

                entity.Property(e => e.Countrycode).IsUnicode(false);

                entity.Property(e => e.Countrymasterguid).IsUnicode(false);

                entity.Property(e => e.Countryname).IsUnicode(false);

                entity.Property(e => e.PersFname).IsUnicode(false);

                entity.Property(e => e.PersLname).IsUnicode(false);

                entity.Property(e => e.PersMname).IsUnicode(false);

                entity.Property(e => e.Personid).IsUnicode(false);

                entity.Property(e => e.PhoneGuid).IsUnicode(false);

                entity.Property(e => e.PhoneNo).IsUnicode(false);

                entity.Property(e => e.PhoneObjVerNo).HasPrecision(10);

                entity.Property(e => e.PhonePersGuid).IsUnicode(false);

                entity.Property(e => e.PhoneTypeCode).IsUnicode(false);

                entity.Property(e => e.PhoneTypeName).IsUnicode(false);

                entity.Property(e => e.Primaryflag).HasPrecision(1);
            });

            modelBuilder.Entity<RuleTable>(entity =>
            {
                entity.Property(e => e.BrandGuid).IsUnicode(false);

                entity.Property(e => e.EnabledFlag).IsUnicode(false);

                entity.Property(e => e.Entity).IsUnicode(false);

                entity.Property(e => e.LebranchGuid).IsUnicode(false);

                entity.Property(e => e.ModelGuid).IsUnicode(false);

                entity.Property(e => e.Quickaccesscode).IsUnicode(false);

                entity.Property(e => e.RuleName).IsUnicode(false);

                entity.Property(e => e.RuleOldName).IsUnicode(false);

                entity.Property(e => e.SecurityGuid).IsUnicode(false);

                entity.Property(e => e.ViewCol).IsUnicode(false);

                entity.Property(e => e.ViewName).IsUnicode(false);
            });

            modelBuilder.Entity<SalesAuthTbl>(entity =>
            {
                entity.HasKey(e => e.Guid)
                    .HasName("SALES_GUID_PK");

                entity.Property(e => e.Guid).IsUnicode(false);

                entity.Property(e => e.Attribute1).IsUnicode(false);

                entity.Property(e => e.Attribute2).IsUnicode(false);

                entity.Property(e => e.Attribute3).IsUnicode(false);

                entity.Property(e => e.Attribute4).IsUnicode(false);

                entity.Property(e => e.Attribute5).IsUnicode(false);

                entity.Property(e => e.Pkguid).IsUnicode(false);

                entity.Property(e => e.Referenceotpguid).IsUnicode(false);

                entity.Property(e => e.Usercreated).IsUnicode(false);

                entity.Property(e => e.Userdeleted).IsUnicode(false);

                entity.Property(e => e.Usermasterguid).IsUnicode(false);

                entity.Property(e => e.Userupdated).IsUnicode(false);
            });

            modelBuilder.Entity<SalesBackofficePersonV>(entity =>
            {
                entity.ToView("SALES_BACKOFFICE_PERSON_V");

                entity.Property(e => e.EmployeeNumber)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.FullName).IsUnicode(false);

                entity.Property(e => e.Id)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.NpwNumber)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.OrganizationId)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.PersonType)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.PositionId)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.PositionName)
                    .IsUnicode(false)
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<SalesCabqcInterface>(entity =>
            {
                entity.HasKey(e => e.Guid)
                    .HasName("SALES_CABQCGUID_PK");

                entity.Property(e => e.Guid).IsUnicode(false);

                entity.Property(e => e.Carguid).IsUnicode(false);

                entity.Property(e => e.Drivingskill)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Ownerguid).IsUnicode(false);

                entity.Property(e => e.Status).IsUnicode(false);

                entity.Property(e => e.Trainingrequird)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Usercreated).IsUnicode(false);

                entity.Property(e => e.Userupdated).IsUnicode(false);

                entity.Property(e => e.Vehiclecondition)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.HasOne(d => d.Cargu)
                    .WithMany(p => p.SalesCabqcInterfaces)
                    .HasForeignKey(d => d.Carguid)
                    .HasConstraintName("SALES_CABQCGUID_FK2");

                entity.HasOne(d => d.Ownergu)
                    .WithMany(p => p.SalesCabqcInterfaces)
                    .HasForeignKey(d => d.Ownerguid)
                    .HasConstraintName("SALES_CABQCGUID_FK1");
            });

            modelBuilder.Entity<SalesCarInterface>(entity =>
            {
                entity.HasKey(e => e.Guid)
                    .HasName("SALES_CARGUID_PK");

                entity.Property(e => e.Guid).IsUnicode(false);

                entity.Property(e => e.Actualcity).IsUnicode(false);

                entity.Property(e => e.Actualstate).IsUnicode(false);

                entity.Property(e => e.Anchorlocationguid).IsUnicode(false);

                entity.Property(e => e.Brand).IsUnicode(false);

                entity.Property(e => e.Businesscategorymasterguid)
                    .IsUnicode(false)
                    .HasDefaultValueSql("'7542ED071CDF7E32E05318011CAC7B7D'");

                entity.Property(e => e.Carmake).IsUnicode(false);

                entity.Property(e => e.Carmakename).IsUnicode(false);

                entity.Property(e => e.Carmodel).IsUnicode(false);

                entity.Property(e => e.Carmodelname).IsUnicode(false);

                entity.Property(e => e.Carno).IsUnicode(false);

                entity.Property(e => e.Chassisno).IsUnicode(false);

                entity.Property(e => e.City).IsUnicode(false);

                entity.Property(e => e.Clientmapguid).IsUnicode(false);

                entity.Property(e => e.Color).IsUnicode(false);

                entity.Property(e => e.Colorname).IsUnicode(false);

                entity.Property(e => e.Deviceid).IsUnicode(false);

                entity.Property(e => e.Fueltype).IsUnicode(false);

                entity.Property(e => e.Fueltypename).IsUnicode(false);

                entity.Property(e => e.Garagelocation).IsUnicode(false);

                entity.Property(e => e.Groupvariantguid).IsUnicode(false);

                entity.Property(e => e.Isac)
                    .HasPrecision(1)
                    .HasDefaultValueSql("(1)\n");

                entity.Property(e => e.Le).IsUnicode(false);

                entity.Property(e => e.Mobileno).IsUnicode(false);

                entity.Property(e => e.Model).IsUnicode(false);

                entity.Property(e => e.Noofseats).HasDefaultValueSql("(0)");

                entity.Property(e => e.Orastatus).IsUnicode(false);

                entity.Property(e => e.Ownerguid).IsUnicode(false);

                entity.Property(e => e.Permittype).IsUnicode(false);

                entity.Property(e => e.Sentnormsdatatomnathan).HasDefaultValueSql("0");

                entity.Property(e => e.Shiftmasterguid).IsUnicode(false);

                entity.Property(e => e.Status).IsUnicode(false);

                entity.Property(e => e.Usercreated).IsUnicode(false);

                entity.Property(e => e.Userupdated).IsUnicode(false);

                entity.Property(e => e.Yearofreg).IsUnicode(false);

                entity.HasOne(d => d.Ownergu)
                    .WithMany(p => p.SalesCarInterfaces)
                    .HasForeignKey(d => d.Ownerguid)
                    .HasConstraintName("SALES_CAROWNERGUID_FK");
            });

            modelBuilder.Entity<SalesCardrivermapping>(entity =>
            {
                entity.HasKey(e => e.Guid)
                    .HasName("SALES_CARDRIVERMAPPING_PK");

                entity.Property(e => e.Guid).IsUnicode(false);

                entity.Property(e => e.Carguid).IsUnicode(false);

                entity.Property(e => e.Driverguid).IsUnicode(false);

                entity.Property(e => e.Ownerguid).IsUnicode(false);

                entity.Property(e => e.Status).IsUnicode(false);

                entity.Property(e => e.Usercreated).IsUnicode(false);

                entity.Property(e => e.Userupdated).IsUnicode(false);

                entity.HasOne(d => d.Cargu)
                    .WithMany(p => p.SalesCardrivermappings)
                    .HasForeignKey(d => d.Carguid)
                    .HasConstraintName("FK_SALES_CAR_INTERFACE");

                entity.HasOne(d => d.Drivergu)
                    .WithMany(p => p.SalesCardrivermappings)
                    .HasForeignKey(d => d.Driverguid)
                    .HasConstraintName("SALES_CARDRIVERMAPPING_FK");
            });

            modelBuilder.Entity<SalesCardrivermappingV3>(entity =>
            {
                entity.HasKey(e => e.Guid)
                    .HasName("SYS_C00229576");

                entity.Property(e => e.Guid).IsUnicode(false);

                entity.Property(e => e.Carguid).IsUnicode(false);

                entity.Property(e => e.Driverguid).IsUnicode(false);

                entity.Property(e => e.Ownerguid).IsUnicode(false);

                entity.Property(e => e.Status).IsUnicode(false);

                entity.Property(e => e.Usercreated).IsUnicode(false);

                entity.Property(e => e.Userupdated).IsUnicode(false);
            });

            modelBuilder.Entity<SalesDocumentsInterface>(entity =>
            {
                entity.HasKey(e => e.Guid)
                    .HasName("SALES_DOCUMENTSGUID_PK");

                entity.Property(e => e.Guid).IsUnicode(false);

                entity.Property(e => e.Aadharcardmatch).HasDefaultValueSql("0");

                entity.Property(e => e.Docpath).IsUnicode(false);

                entity.Property(e => e.Doctypename).IsUnicode(false);

                entity.Property(e => e.Documenttype).IsUnicode(false);

                entity.Property(e => e.Documenttypeentityguid).IsUnicode(false);

                entity.Property(e => e.Entityuniqueid).IsUnicode(false);

                entity.Property(e => e.Imagename).IsUnicode(false);

                entity.Property(e => e.Imageverified).HasDefaultValueSql("0");

                entity.Property(e => e.Status).IsUnicode(false);

                entity.Property(e => e.Usercreated).IsUnicode(false);

                entity.Property(e => e.Userupdated).IsUnicode(false);
            });

            modelBuilder.Entity<SalesDocumentsInterfaceV>(entity =>
            {
                entity.ToView("SALES_DOCUMENTS_INTERFACE_V");

                entity.Property(e => e.Docpath).IsUnicode(false);

                entity.Property(e => e.Doctypename).IsUnicode(false);

                entity.Property(e => e.Documenttype).IsUnicode(false);

                entity.Property(e => e.Documenttypeentityguid).IsUnicode(false);

                entity.Property(e => e.Entityuniqueid).IsUnicode(false);

                entity.Property(e => e.Guid).IsUnicode(false);

                entity.Property(e => e.Imagename).IsUnicode(false);

                entity.Property(e => e.Ownerguid).IsUnicode(false);

                entity.Property(e => e.Status).IsUnicode(false);

                entity.Property(e => e.Usercreated).IsUnicode(false);

                entity.Property(e => e.Userupdated).IsUnicode(false);
            });

            modelBuilder.Entity<SalesDocumentsInterfaceV3>(entity =>
            {
                entity.HasKey(e => e.Guid)
                    .HasName("SYS_C00229497");

                entity.Property(e => e.Guid).IsUnicode(false);

                entity.Property(e => e.Doctypename).IsUnicode(false);

                entity.Property(e => e.Documenttype).IsUnicode(false);

                entity.Property(e => e.Documenttypeentityguid).IsUnicode(false);

                entity.Property(e => e.Entityuniqueid).IsUnicode(false);

                entity.Property(e => e.Imagename).IsUnicode(false);

                entity.Property(e => e.Imageverified).HasDefaultValueSql("0\n  ");

                entity.Property(e => e.Status)
                    .IsUnicode(false)
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Userupdated).IsUnicode(false);
            });

            modelBuilder.Entity<SalesDriverInterface>(entity =>
            {
                entity.HasKey(e => e.Guid)
                    .HasName("SALES_DRIVERGUID_PK");

                entity.Property(e => e.Guid).IsUnicode(false);

                entity.Property(e => e.Aadharcardno).IsUnicode(false);

                entity.Property(e => e.Address).IsUnicode(false);

                entity.Property(e => e.Area).IsUnicode(false);

                entity.Property(e => e.Devicehardwareid).IsUnicode(false);

                entity.Property(e => e.District).IsUnicode(false);

                entity.Property(e => e.Driverid).IsUnicode(false);

                entity.Property(e => e.Drivername).IsUnicode(false);

                entity.Property(e => e.Emailid).IsUnicode(false);

                entity.Property(e => e.Ownerguid).IsUnicode(false);

                entity.Property(e => e.Pincode).IsUnicode(false);

                entity.Property(e => e.State).IsUnicode(false);

                entity.Property(e => e.Status).IsUnicode(false);

                entity.Property(e => e.Usercreated).IsUnicode(false);

                entity.Property(e => e.Userupdated).IsUnicode(false);

                entity.HasOne(d => d.Ownergu)
                    .WithMany(p => p.SalesDriverInterfaces)
                    .HasForeignKey(d => d.Ownerguid)
                    .HasConstraintName("SALES_DRIVEROWNERGUID_FK");
            });

            modelBuilder.Entity<SalesDriverInterfaceV3>(entity =>
            {
                entity.HasKey(e => e.Guid)
                    .HasName("SYS_C00229494");

                entity.Property(e => e.Guid).IsUnicode(false);

                entity.Property(e => e.Addressline1).IsUnicode(false);

                entity.Property(e => e.Addressline2).IsUnicode(false);

                entity.Property(e => e.Driverid).IsUnicode(false);

                entity.Property(e => e.Drivername).IsUnicode(false);

                entity.Property(e => e.Mobilenumber).IsUnicode(false);

                entity.Property(e => e.Ownerguid).IsUnicode(false);

                entity.Property(e => e.Source).IsUnicode(false);

                entity.Property(e => e.Status).IsUnicode(false);

                entity.Property(e => e.Usercreated).IsUnicode(false);

                entity.Property(e => e.Userupdated).IsUnicode(false);
            });

            modelBuilder.Entity<SalesFueltypeInterface>(entity =>
            {
                entity.HasKey(e => e.Guid)
                    .HasName("SALES_FUELTYPE_INTERFACE_PK");

                entity.Property(e => e.Guid).IsUnicode(false);

                entity.Property(e => e.Fueltype).IsUnicode(false);
            });

            modelBuilder.Entity<SalesOnroadTbl>(entity =>
            {
                entity.Property(e => e.Businesscategorymasterguid)
                    .IsUnicode(false)
                    .HasDefaultValueSql("'7542ED071CDF7E32E05318011CAC7B7D'");

                entity.Property(e => e.Carno).IsUnicode(false);

                entity.Property(e => e.Driverid).IsUnicode(false);

                entity.Property(e => e.Lat).IsUnicode(false);

                entity.Property(e => e.Log).IsUnicode(false);

                entity.Property(e => e.Ownerguid).IsUnicode(false);

                entity.Property(e => e.Spid).IsUnicode(false);

                entity.Property(e => e.Usercreated).IsUnicode(false);
            });

            modelBuilder.Entity<SalesOtpTbl>(entity =>
            {
                entity.HasKey(e => e.Guid)
                    .HasName("SALE_OTP_MOB_OTP_PK");

                entity.Property(e => e.Guid).IsUnicode(false);

                entity.Property(e => e.Attribute1).IsUnicode(false);

                entity.Property(e => e.Attribute2).IsUnicode(false);

                entity.Property(e => e.Attribute3).IsUnicode(false);

                entity.Property(e => e.Attribute4).IsUnicode(false);

                entity.Property(e => e.Attribute5).IsUnicode(false);

                entity.Property(e => e.Pkguid).IsUnicode(false);

                entity.Property(e => e.Usercreated).IsUnicode(false);

                entity.Property(e => e.Userdeleted).IsUnicode(false);

                entity.Property(e => e.Usermasterguid).IsUnicode(false);

                entity.Property(e => e.Userupdated).IsUnicode(false);
            });

            modelBuilder.Entity<SalesOwnerInterface>(entity =>
            {
                entity.HasKey(e => e.Guid)
                    .HasName("SALES_OWNERGUID_PK");

                entity.Property(e => e.Guid).IsUnicode(false);

                entity.Property(e => e.Aadharcardno).IsUnicode(false);

                entity.Property(e => e.Accno).IsUnicode(false);

                entity.Property(e => e.Address).IsUnicode(false);

                entity.Property(e => e.Area).IsUnicode(false);

                entity.Property(e => e.Bankname).IsUnicode(false);

                entity.Property(e => e.Businesscategorymasterguid).IsUnicode(false);

                entity.Property(e => e.District).IsUnicode(false);

                entity.Property(e => e.EmailId).IsUnicode(false);

                entity.Property(e => e.Ifsccode).IsUnicode(false);

                entity.Property(e => e.Orastatus).IsUnicode(false);

                entity.Property(e => e.Ownerid).IsUnicode(false);

                entity.Property(e => e.Ownername).IsUnicode(false);

                entity.Property(e => e.Panno).IsUnicode(false);

                entity.Property(e => e.Personflag).IsUnicode(false);

                entity.Property(e => e.Pincode).IsUnicode(false);

                entity.Property(e => e.Spclientmapguid).IsUnicode(false);

                entity.Property(e => e.State).IsUnicode(false);

                entity.Property(e => e.Status).IsUnicode(false);

                entity.Property(e => e.Usercreated).IsUnicode(false);

                entity.Property(e => e.Userupdated).IsUnicode(false);
            });

            modelBuilder.Entity<SalesOwnerInterfaceV3>(entity =>
            {
                entity.HasKey(e => e.Guid)
                    .HasName("SYS_C00229487");

                entity.Property(e => e.Guid).IsUnicode(false);

                entity.Property(e => e.Address).IsUnicode(false);

                entity.Property(e => e.Addressline1).IsUnicode(false);

                entity.Property(e => e.Addressline2).IsUnicode(false);

                entity.Property(e => e.Datasubmitted).HasPrecision(1);

                entity.Property(e => e.EmailId).IsUnicode(false);

                entity.Property(e => e.Fleetownerflag).IsUnicode(false);

                entity.Property(e => e.Mobilenumber).IsUnicode(false);

                entity.Property(e => e.Ownerid).IsUnicode(false);

                entity.Property(e => e.Ownername).IsUnicode(false);

                entity.Property(e => e.Personflag).IsUnicode(false);

                entity.Property(e => e.Status).IsUnicode(false);

                entity.Property(e => e.Userupdated).IsUnicode(false);
            });

            modelBuilder.Entity<SalesVehicleInterfaceV3>(entity =>
            {
                entity.HasKey(e => e.Guid)
                    .HasName("SYS_C00229500");

                entity.Property(e => e.Guid).IsUnicode(false);

                entity.Property(e => e.Brand).IsUnicode(false);

                entity.Property(e => e.Businesscategorymasterguid).IsUnicode(false);

                entity.Property(e => e.Businesscategorymasterguid2).IsUnicode(false);

                entity.Property(e => e.Carmake).IsUnicode(false);

                entity.Property(e => e.Carmodel).IsUnicode(false);

                entity.Property(e => e.Carno).IsUnicode(false);

                entity.Property(e => e.Chassisno).IsUnicode(false);

                entity.Property(e => e.City).IsUnicode(false);

                entity.Property(e => e.Color).IsUnicode(false);

                entity.Property(e => e.Deviceid).IsUnicode(false);

                entity.Property(e => e.Fueltype).IsUnicode(false);

                entity.Property(e => e.Groupvariantguid).IsUnicode(false);

                entity.Property(e => e.Isac)
                    .HasPrecision(1)
                    .HasDefaultValueSql("(1)\n  ");

                entity.Property(e => e.Le).IsUnicode(false);

                entity.Property(e => e.Model).IsUnicode(false);

                entity.Property(e => e.Noofseats).HasDefaultValueSql("(0) ");

                entity.Property(e => e.Ownerguid).IsUnicode(false);

                entity.Property(e => e.Permittype).IsUnicode(false);

                entity.Property(e => e.Sentbusinesscategory)
                    .HasPrecision(1)
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Source).IsUnicode(false);

                entity.Property(e => e.Status).IsUnicode(false);

                entity.Property(e => e.Userupdated).IsUnicode(false);

                entity.Property(e => e.VehicleOwnerMobilenumber).IsUnicode(false);

                entity.Property(e => e.VehicleOwnerName).IsUnicode(false);

                entity.Property(e => e.VehicleTypeGuid).IsUnicode(false);

                entity.Property(e => e.Vehiclecity).IsUnicode(false);

                entity.Property(e => e.Vehiclestate).IsUnicode(false);

                entity.Property(e => e.Yearofreg).IsUnicode(false);
            });

            modelBuilder.Entity<Sapconfig>(entity =>
            {
                entity.Property(e => e.Basetransactiontype).IsUnicode(false);

                entity.Property(e => e.Companycode).IsUnicode(false);

                entity.Property(e => e.Currency).IsUnicode(false);

                entity.Property(e => e.Narration).IsUnicode(false);

                entity.Property(e => e.Sectioncode).IsUnicode(false);

                entity.Property(e => e.Showinstatementnoglcode).IsUnicode(false);

                entity.Property(e => e.Showinstatementnoglname).IsUnicode(false);

                entity.Property(e => e.Showinstatementyesglcode).IsUnicode(false);

                entity.Property(e => e.Showinstatementyesglname).IsUnicode(false);
            });

            modelBuilder.Entity<SapglV>(entity =>
            {
                entity.ToView("SAPGL_V");

                entity.Property(e => e.BaseTransactionDate).IsUnicode(false);

                entity.Property(e => e.BusinessPlace).IsUnicode(false);

                entity.Property(e => e.CityCode).IsUnicode(false);

                entity.Property(e => e.Costcenter).IsUnicode(false);

                entity.Property(e => e.Documenttype).IsUnicode(false);

                entity.Property(e => e.GlCode).IsUnicode(false);

                entity.Property(e => e.InernalOrder).IsUnicode(false);

                entity.Property(e => e.Profitcenter).IsUnicode(false);

                entity.Property(e => e.Showinstatement).IsUnicode(false);

                entity.Property(e => e.Total).IsUnicode(false);

                entity.Property(e => e.TransactionClass).IsUnicode(false);

                entity.Property(e => e.TransactionDate).IsUnicode(false);

                entity.Property(e => e.TransactionType).IsUnicode(false);
            });

            modelBuilder.Entity<Saptaskexecution>(entity =>
            {
                entity.Property(e => e.Guid).IsUnicode(false);

                entity.Property(e => e.Status).IsUnicode(false);

                entity.Property(e => e.Tallydllresponse).IsUnicode(false);
            });

            modelBuilder.Entity<Schparameter>(entity =>
            {
                entity.Property(e => e.Datatype).IsUnicode(false);

                entity.Property(e => e.Direction).IsUnicode(false);

                entity.Property(e => e.Guid).IsUnicode(false);

                entity.Property(e => e.Parametername).IsUnicode(false);

                entity.Property(e => e.Schprogramguid).IsUnicode(false);

                entity.Property(e => e.Usercreated).IsUnicode(false);

                entity.Property(e => e.Valuesettype).IsUnicode(false);
            });

            modelBuilder.Entity<SchparameterValuesV>(entity =>
            {
                entity.ToView("SCHPARAMETER_VALUES_V");

                entity.Property(e => e.Datatype).IsUnicode(false);

                entity.Property(e => e.ParDirection).IsUnicode(false);

                entity.Property(e => e.Parameterguid).IsUnicode(false);

                entity.Property(e => e.Parametername).IsUnicode(false);

                entity.Property(e => e.Programguid).IsUnicode(false);

                entity.Property(e => e.Valuesetguid).IsUnicode(false);

                entity.Property(e => e.Valuesettype).IsUnicode(false);

                entity.Property(e => e.Valusetvalue).IsUnicode(false);
            });

            modelBuilder.Entity<Schparametertran>(entity =>
            {
                entity.Property(e => e.Guid).IsUnicode(false);

                entity.Property(e => e.Requestid).IsUnicode(false);

                entity.Property(e => e.Schparameterguid).IsUnicode(false);

                entity.Property(e => e.Schprogramguid).IsUnicode(false);

                entity.Property(e => e.Usercreated).IsUnicode(false);

                entity.Property(e => e.Value).IsUnicode(false);
            });

            modelBuilder.Entity<Schprogram>(entity =>
            {
                entity.Property(e => e.Dateupdate).IsUnicode(false);

                entity.Property(e => e.Description).IsUnicode(false);

                entity.Property(e => e.Email).IsUnicode(false);

                entity.Property(e => e.EmailCc).IsUnicode(false);

                entity.Property(e => e.Guid).IsUnicode(false);

                entity.Property(e => e.Name).IsUnicode(false);

                entity.Property(e => e.Procedurename).IsUnicode(false);

                entity.Property(e => e.Programtype).IsUnicode(false);

                entity.Property(e => e.Usercreated).IsUnicode(false);
            });

            modelBuilder.Entity<Schprogramtran>(entity =>
            {
                entity.Property(e => e.Durationtype).IsUnicode(false);

                entity.Property(e => e.Guid).IsUnicode(false);

                entity.Property(e => e.Nextrequestid).IsUnicode(false);

                entity.Property(e => e.Phase).IsUnicode(false);

                entity.Property(e => e.Requestid).IsUnicode(false);

                entity.Property(e => e.Schprogramguid).IsUnicode(false);

                entity.Property(e => e.Status).IsUnicode(false);

                entity.Property(e => e.Usercreated).IsUnicode(false);
            });

            modelBuilder.Entity<Schprogramusermapping>(entity =>
            {
                entity.Property(e => e.Guid).IsUnicode(false);

                entity.Property(e => e.Schprogramguid).IsUnicode(false);

                entity.Property(e => e.Usercreated).IsUnicode(false);

                entity.Property(e => e.Userguid).IsUnicode(false);
            });

            modelBuilder.Entity<Schvalueset>(entity =>
            {
                entity.Property(e => e.Guid).IsUnicode(false);

                entity.Property(e => e.Schparameterguid).IsUnicode(false);

                entity.Property(e => e.Usercreated).IsUnicode(false);

                entity.Property(e => e.Value).IsUnicode(false);
            });

            modelBuilder.Entity<Searchentity>(entity =>
            {
                entity.Property(e => e.Entityname).IsUnicode(false);

                entity.Property(e => e.Entitytype).IsUnicode(false);

                entity.Property(e => e.Guid).IsUnicode(false);

                entity.Property(e => e.Objectversionno).HasPrecision(3);

                entity.Property(e => e.Oracleentityid).IsUnicode(false);

                entity.Property(e => e.Oracleentityname).IsUnicode(false);

                entity.Property(e => e.Pkguid).IsUnicode(false);

                entity.Property(e => e.Userarchived).IsUnicode(false);

                entity.Property(e => e.Usercreated).IsUnicode(false);

                entity.Property(e => e.Userdeleted).IsUnicode(false);

                entity.Property(e => e.Userupdated).IsUnicode(false);
            });

            modelBuilder.Entity<Searchtemplatedisplaycolumn>(entity =>
            {
                entity.Property(e => e.Aggregatefilteroperator).IsUnicode(false);

                entity.Property(e => e.Aggregatefiltervaluetext).IsUnicode(false);

                entity.Property(e => e.Aggregatefiltervaluetype).IsUnicode(false);

                entity.Property(e => e.Aggregatefunction).IsUnicode(false);

                entity.Property(e => e.Columndisplayname).IsUnicode(false);

                entity.Property(e => e.Guid).IsUnicode(false);

                entity.Property(e => e.Objectversionno).HasPrecision(3);

                entity.Property(e => e.Oracleentityid).IsUnicode(false);

                entity.Property(e => e.Oracleentityname).IsUnicode(false);

                entity.Property(e => e.Pkguid).IsUnicode(false);

                entity.Property(e => e.Searchtemplateentitiesguid).IsUnicode(false);

                entity.Property(e => e.Searchtemplatequeriesguid).IsUnicode(false);

                entity.Property(e => e.Siteguidflag).IsUnicode(false);

                entity.Property(e => e.Userarchived).IsUnicode(false);

                entity.Property(e => e.Usercreated).IsUnicode(false);

                entity.Property(e => e.Userdeleted).IsUnicode(false);

                entity.Property(e => e.Userupdated).IsUnicode(false);
            });

            modelBuilder.Entity<Searchtemplateentity>(entity =>
            {
                entity.Property(e => e.Guid).IsUnicode(false);

                entity.Property(e => e.Objectversionno).HasPrecision(3);

                entity.Property(e => e.Oracleentityid).IsUnicode(false);

                entity.Property(e => e.Oracleentityname).IsUnicode(false);

                entity.Property(e => e.Pkguid).IsUnicode(false);

                entity.Property(e => e.Searchentitiesguid).IsUnicode(false);

                entity.Property(e => e.Searchentityalias).IsUnicode(false);

                entity.Property(e => e.Searchtemplatequeriesguid).IsUnicode(false);

                entity.Property(e => e.Statusentityguid).IsUnicode(false);

                entity.Property(e => e.Userarchived).IsUnicode(false);

                entity.Property(e => e.Usercreated).IsUnicode(false);

                entity.Property(e => e.Userdeleted).IsUnicode(false);

                entity.Property(e => e.Userupdated).IsUnicode(false);
            });

            modelBuilder.Entity<Searchtemplatemaster>(entity =>
            {
                entity.Property(e => e.Approvalenabled).IsUnicode(false);

                entity.Property(e => e.Guid).IsUnicode(false);

                entity.Property(e => e.Objectversionno).HasPrecision(3);

                entity.Property(e => e.Oracleentityid).IsUnicode(false);

                entity.Property(e => e.Oracleentityname).IsUnicode(false);

                entity.Property(e => e.Pkguid).IsUnicode(false);

                entity.Property(e => e.Statusentityguid).IsUnicode(false);

                entity.Property(e => e.Summaryviewname).IsUnicode(false);

                entity.Property(e => e.Summaryviewtext).IsUnicode(false);

                entity.Property(e => e.Templatedescription).IsUnicode(false);

                entity.Property(e => e.Templatename).IsUnicode(false);

                entity.Property(e => e.Templatetransactiontypeid).IsUnicode(false);

                entity.Property(e => e.Templatetype).IsUnicode(false);

                entity.Property(e => e.Transactionresultformula).IsUnicode(false);

                entity.Property(e => e.Userarchived).IsUnicode(false);

                entity.Property(e => e.Usercreated).IsUnicode(false);

                entity.Property(e => e.Userdeleted).IsUnicode(false);

                entity.Property(e => e.Userupdated).IsUnicode(false);

                entity.Property(e => e.Viewname).IsUnicode(false);

                entity.Property(e => e.Viewtext).IsUnicode(false);
            });

            modelBuilder.Entity<SearchtemplatemasterV>(entity =>
            {
                entity.ToView("SEARCHTEMPLATEMASTER_V");

                entity.Property(e => e.Approvalenabled).IsUnicode(false);

                entity.Property(e => e.ClassCode).IsUnicode(false);

                entity.Property(e => e.Searchtemplatemasterguid).IsUnicode(false);

                entity.Property(e => e.Statusentityguid).IsUnicode(false);

                entity.Property(e => e.Summaryviewname).IsUnicode(false);

                entity.Property(e => e.Summaryviewtext).IsUnicode(false);

                entity.Property(e => e.Templatedescription).IsUnicode(false);

                entity.Property(e => e.Templatename).IsUnicode(false);

                entity.Property(e => e.Templatetransactiontypeid).IsUnicode(false);

                entity.Property(e => e.Templatetype).IsUnicode(false);

                entity.Property(e => e.Transactionresultformula).IsUnicode(false);

                entity.Property(e => e.TypeCode).IsUnicode(false);

                entity.Property(e => e.Typename).IsUnicode(false);

                entity.Property(e => e.Viewname).IsUnicode(false);

                entity.Property(e => e.Viewtext).IsUnicode(false);
            });

            modelBuilder.Entity<Searchtemplatequery>(entity =>
            {
                entity.Property(e => e.Guid).IsUnicode(false);

                entity.Property(e => e.Objectversionno).HasPrecision(3);

                entity.Property(e => e.Oracleentityid).IsUnicode(false);

                entity.Property(e => e.Oracleentityname).IsUnicode(false);

                entity.Property(e => e.Pkguid).IsUnicode(false);

                entity.Property(e => e.Querydescription).IsUnicode(false);

                entity.Property(e => e.Querygroupclause).IsUnicode(false);

                entity.Property(e => e.Queryhaveclause).IsUnicode(false);

                entity.Property(e => e.Queryname).IsUnicode(false);

                entity.Property(e => e.Querytype).IsUnicode(false);

                entity.Property(e => e.Queryviewname).IsUnicode(false);

                entity.Property(e => e.Queryviewtext).IsUnicode(false);

                entity.Property(e => e.Searchtemplatemasterguid).IsUnicode(false);

                entity.Property(e => e.Statusentityguid).IsUnicode(false);

                entity.Property(e => e.Userarchived).IsUnicode(false);

                entity.Property(e => e.Usercreated).IsUnicode(false);

                entity.Property(e => e.Userdeleted).IsUnicode(false);

                entity.Property(e => e.Userupdated).IsUnicode(false);
            });

            modelBuilder.Entity<Searchtemplatewhereclause>(entity =>
            {
                entity.Property(e => e.Clausetype).IsUnicode(false);

                entity.Property(e => e.Conditionandor).IsUnicode(false);

                entity.Property(e => e.Conditionandorpostbrackets).IsUnicode(false);

                entity.Property(e => e.Existquerylinkid).IsUnicode(false);

                entity.Property(e => e.Guid).IsUnicode(false);

                entity.Property(e => e.Leftentitycolumnid).IsUnicode(false);

                entity.Property(e => e.Leftpostcolumntext).IsUnicode(false);

                entity.Property(e => e.Leftprebrackets).IsUnicode(false);

                entity.Property(e => e.Leftprecolumntext).IsUnicode(false);

                entity.Property(e => e.Lefttemplateentityid).IsUnicode(false);

                entity.Property(e => e.Operator).IsUnicode(false);

                entity.Property(e => e.Pkguid).IsUnicode(false);

                entity.Property(e => e.Rightconstanttext).IsUnicode(false);

                entity.Property(e => e.Rightpostbrackets).IsUnicode(false);

                entity.Property(e => e.Rightprecolumntext).IsUnicode(false);

                entity.Property(e => e.Rightsidetype).IsUnicode(false);

                entity.Property(e => e.Rightsysdateflag).IsUnicode(false);

                entity.Property(e => e.Righttemplateentityid).IsUnicode(false);

                entity.Property(e => e.Searchtemplatequeriesguid).IsUnicode(false);
            });

            modelBuilder.Entity<SecurityBaseV>(entity =>
            {
                entity.ToView("SECURITY_BASE_V");

                entity.Property(e => e.BrandCode).IsUnicode(false);

                entity.Property(e => e.BrandGuid).IsUnicode(false);

                entity.Property(e => e.BrandName).IsUnicode(false);

                entity.Property(e => e.CityCode).IsUnicode(false);

                entity.Property(e => e.CityGuid).IsUnicode(false);

                entity.Property(e => e.CityName).IsUnicode(false);

                entity.Property(e => e.GlSegment1).IsUnicode(false);

                entity.Property(e => e.GlSement4).IsUnicode(false);

                entity.Property(e => e.GlSement6).IsUnicode(false);

                entity.Property(e => e.LeCode).IsUnicode(false);

                entity.Property(e => e.LeGuid).IsUnicode(false);

                entity.Property(e => e.LeName).IsUnicode(false);

                entity.Property(e => e.LebranchGuid).IsUnicode(false);

                entity.Property(e => e.Manthanbrandid).HasPrecision(3);

                entity.Property(e => e.Manthanbrandtype).IsUnicode(false);

                entity.Property(e => e.Manthancityid).HasPrecision(3);

                entity.Property(e => e.Manthanmodeltype).IsUnicode(false);

                entity.Property(e => e.ModelCode).IsUnicode(false);

                entity.Property(e => e.ModelGuid).IsUnicode(false);

                entity.Property(e => e.ModelName).IsUnicode(false);

                entity.Property(e => e.OrgId).HasPrecision(4);

                entity.Property(e => e.SecGuid).IsUnicode(false);

                entity.Property(e => e.SecObjVerNo).HasPrecision(10);

                entity.Property(e => e.SecQuickaccesscode).IsUnicode(false);
            });

            modelBuilder.Entity<SecurityV>(entity =>
            {
                entity.ToView("SECURITY_V");

                entity.Property(e => e.BrandCode).IsUnicode(false);

                entity.Property(e => e.BrandGuid).IsUnicode(false);

                entity.Property(e => e.BrandName).IsUnicode(false);

                entity.Property(e => e.CityCode).IsUnicode(false);

                entity.Property(e => e.CityGuid).IsUnicode(false);

                entity.Property(e => e.CityName).IsUnicode(false);

                entity.Property(e => e.GlSegment1).IsUnicode(false);

                entity.Property(e => e.GlSement4).IsUnicode(false);

                entity.Property(e => e.GlSement6).IsUnicode(false);

                entity.Property(e => e.LeCode).IsUnicode(false);

                entity.Property(e => e.LeGuid).IsUnicode(false);

                entity.Property(e => e.LeName).IsUnicode(false);

                entity.Property(e => e.LebranchGuid).IsUnicode(false);

                entity.Property(e => e.Manthanbrandid).HasPrecision(3);

                entity.Property(e => e.Manthanbrandtype).IsUnicode(false);

                entity.Property(e => e.Manthancityid).HasPrecision(3);

                entity.Property(e => e.Manthanmodeltype).IsUnicode(false);

                entity.Property(e => e.ModelCode).IsUnicode(false);

                entity.Property(e => e.ModelGuid).IsUnicode(false);

                entity.Property(e => e.ModelName).IsUnicode(false);

                entity.Property(e => e.OrgId).HasPrecision(4);

                entity.Property(e => e.SecGuid).IsUnicode(false);

                entity.Property(e => e.SecObjVerNo).HasPrecision(10);

                entity.Property(e => e.SecQuickaccesscode).IsUnicode(false);
            });

            modelBuilder.Entity<Securitycombination>(entity =>
            {
                entity.Property(e => e.Branchmasterguid).IsUnicode(false);

                entity.Property(e => e.Brandmasterguid).IsUnicode(false);

                entity.Property(e => e.Comments).IsUnicode(false);

                entity.Property(e => e.Description).IsUnicode(false);

                entity.Property(e => e.Disabled).HasPrecision(1);

                entity.Property(e => e.Guid).IsUnicode(false);

                entity.Property(e => e.Legalentitymasterguid).IsUnicode(false);

                entity.Property(e => e.Modelmasterguid).IsUnicode(false);

                entity.Property(e => e.Name).IsUnicode(false);

                entity.Property(e => e.Objectversionno).HasPrecision(10);

                entity.Property(e => e.Oracleentityid).IsUnicode(false);

                entity.Property(e => e.Oracleentityname).IsUnicode(false);

                entity.Property(e => e.Orgid).IsUnicode(false);

                entity.Property(e => e.Pkguid).IsUnicode(false);

                entity.Property(e => e.Quickaccesscode).IsUnicode(false);

                entity.Property(e => e.Userarchived).IsUnicode(false);

                entity.Property(e => e.Usercreated).IsUnicode(false);

                entity.Property(e => e.Userdeleted).IsUnicode(false);

                entity.Property(e => e.Userupdated).IsUnicode(false);
            });

            modelBuilder.Entity<Sedantoflexi>(entity =>
            {
                entity.Property(e => e.Anchorlocation).IsUnicode(false);

                entity.Property(e => e.Carno).IsUnicode(false);

                entity.Property(e => e.DeviceStatus)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Garagelocation).IsUnicode(false);

                entity.Property(e => e.Guid).IsUnicode(false);

                entity.Property(e => e.MasterStatus)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.NewGv).IsUnicode(false);

                entity.Property(e => e.NewSc).IsUnicode(false);

                entity.Property(e => e.OffroadInterfaceStatus)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.OffroadStatus)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.OldGv).IsUnicode(false);

                entity.Property(e => e.OldSc).IsUnicode(false);

                entity.Property(e => e.OnroadInterfaceStatus)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.OnroadStatus)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Shift).IsUnicode(false);

                entity.Property(e => e.UserMasterGuid).IsUnicode(false);
            });

            modelBuilder.Entity<SendcomplaintnoteV>(entity =>
            {
                entity.ToView("SENDCOMPLAINTNOTE_V");

                entity.Property(e => e.Comments).IsUnicode(false);

                entity.Property(e => e.ComplaintId).IsUnicode(false);

                entity.Property(e => e.Name).IsUnicode(false);
            });

            modelBuilder.Entity<Serviceprocessexecution>(entity =>
            {
                entity.HasKey(e => e.Guid)
                    .HasName("SERVICEPROCESSEXECUTION_PK");

                entity.Property(e => e.Guid).IsUnicode(false);

                entity.Property(e => e.Datecreated).HasDefaultValueSql("SYSDATE");

                entity.Property(e => e.Servicename).IsUnicode(false);

                entity.Property(e => e.Status).IsUnicode(false);
            });

            modelBuilder.Entity<Serviceprovider>(entity =>
            {
                entity.Property(e => e.Custaccid).IsUnicode(false);

                entity.Property(e => e.DefrredDocCheckFlag).IsUnicode(false);

                entity.Property(e => e.Disabled)
                    .HasPrecision(1)
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Effectiveenddate).HasDefaultValueSql("to_timestamp('4712-12-31','yyyy-mm-dd')");

                entity.Property(e => e.Guid).IsUnicode(false);

                entity.Property(e => e.Issendtomonroe)
                    .HasPrecision(5)
                    .HasDefaultValueSql("0 ");

                entity.Property(e => e.Linktosupplier).IsUnicode(false);

                entity.Property(e => e.Objectversionno).HasPrecision(10);

                entity.Property(e => e.Oracleentityid).IsUnicode(false);

                entity.Property(e => e.Oracleentityname).IsUnicode(false);

                entity.Property(e => e.Personmasterguid).IsUnicode(false);

                entity.Property(e => e.Persontype).IsUnicode(false);

                entity.Property(e => e.Pkguid).IsUnicode(false);

                entity.Property(e => e.Readyflag).IsUnicode(false);

                entity.Property(e => e.Statusentityguid).IsUnicode(false);

                entity.Property(e => e.Tdscode).IsUnicode(false);

                entity.Property(e => e.Userarchived).IsUnicode(false);

                entity.Property(e => e.Usercreated).IsUnicode(false);

                entity.Property(e => e.Userdeleted).IsUnicode(false);

                entity.Property(e => e.Userupdated).IsUnicode(false);
            });

            modelBuilder.Entity<Shiftmaster>(entity =>
            {
                entity.Property(e => e.Comments).IsUnicode(false);

                entity.Property(e => e.Disabled).HasPrecision(1);

                entity.Property(e => e.Guid).IsUnicode(false);

                entity.Property(e => e.Name).IsUnicode(false);

                entity.Property(e => e.Objectversionno).HasPrecision(10);

                entity.Property(e => e.Oracleentityid).IsUnicode(false);

                entity.Property(e => e.Oracleentityname).IsUnicode(false);

                entity.Property(e => e.Pkguid).IsUnicode(false);

                entity.Property(e => e.Quickaccesscode).IsUnicode(false);

                entity.Property(e => e.Userarchived).IsUnicode(false);

                entity.Property(e => e.Usercreated).IsUnicode(false);

                entity.Property(e => e.Userdeleted).IsUnicode(false);

                entity.Property(e => e.Userupdated).IsUnicode(false);
            });

            modelBuilder.Entity<SiteDetailsBaseV>(entity =>
            {
                entity.ToView("SITE_DETAILS_BASE_V");

                entity.Property(e => e.Billsiteuseid).IsUnicode(false);

                entity.Property(e => e.Objectversionno).HasPrecision(10);

                entity.Property(e => e.Personguid).IsUnicode(false);

                entity.Property(e => e.Pkguid).IsUnicode(false);

                entity.Property(e => e.Securitycombinationguid).IsUnicode(false);

                entity.Property(e => e.Siteguid).IsUnicode(false);

                entity.Property(e => e.Sitename).IsUnicode(false);

                entity.Property(e => e.Spguid).IsUnicode(false);

                entity.Property(e => e.Statusentityguid).IsUnicode(false);
            });

            modelBuilder.Entity<SiteDetailsV>(entity =>
            {
                entity.ToView("SITE_DETAILS_V");

                entity.Property(e => e.Billsiteuseid).IsUnicode(false);

                entity.Property(e => e.Objectversionno).HasPrecision(10);

                entity.Property(e => e.Personguid).IsUnicode(false);

                entity.Property(e => e.Pkguid).IsUnicode(false);

                entity.Property(e => e.Securitycombinationguid).IsUnicode(false);

                entity.Property(e => e.Siteguid).IsUnicode(false);

                entity.Property(e => e.Sitename).IsUnicode(false);

                entity.Property(e => e.Spguid).IsUnicode(false);

                entity.Property(e => e.Statusentityguid).IsUnicode(false);
            });

            modelBuilder.Entity<SiteInvoiceCalc>(entity =>
            {
                entity.Property(e => e.InvoiceProgramexecutionGuid).IsUnicode(false);

                entity.Property(e => e.Siteguid).IsUnicode(false);

                entity.Property(e => e.Usercreated).IsUnicode(false);
            });

            modelBuilder.Entity<Sitetypemaster>(entity =>
            {
                entity.Property(e => e.Description).IsUnicode(false);

                entity.Property(e => e.Disabled).HasPrecision(1);

                entity.Property(e => e.Guid)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Name).IsUnicode(false);

                entity.Property(e => e.Objectversionno).HasPrecision(3);

                entity.Property(e => e.Oracleentityid).IsUnicode(false);

                entity.Property(e => e.Oracleentityname).IsUnicode(false);

                entity.Property(e => e.Pkguid).IsUnicode(false);

                entity.Property(e => e.Quickaccesscode).IsUnicode(false);

                entity.Property(e => e.Userarchived)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Usercreated)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Userdeleted)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Userupdated)
                    .IsUnicode(false)
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<SmsMissDocReportTemp>(entity =>
            {
                entity.Property(e => e.CarNo).IsUnicode(false);

                entity.Property(e => e.Datecreated).HasDefaultValueSql("SYSDATE\n  ");

                entity.Property(e => e.DocumentName).IsUnicode(false);

                entity.Property(e => e.EntityDocType).IsUnicode(false);

                entity.Property(e => e.EntityId).IsUnicode(false);

                entity.Property(e => e.EntityType).IsUnicode(false);

                entity.Property(e => e.Guid).IsUnicode(false);

                entity.Property(e => e.Personid).IsUnicode(false);

                entity.Property(e => e.SmsString).IsUnicode(false);
            });

            modelBuilder.Entity<Smseventdatum>(entity =>
            {
                entity.Property(e => e.EventCode).IsUnicode(false);

                entity.Property(e => e.ParamString).IsUnicode(false);

                entity.Property(e => e.ProcessedResult).IsUnicode(false);

                entity.Property(e => e.ProcessedStatus).IsUnicode(false);
            });

            modelBuilder.Entity<SnpCheckTab>(entity =>
            {
                entity.Property(e => e.CatalogName).IsUnicode(false);

                entity.Property(e => e.ConsName).IsUnicode(false);

                entity.Property(e => e.ConsType).IsUnicode(false);

                entity.Property(e => e.ErrCount).HasPrecision(10);

                entity.Property(e => e.ErrMess).IsUnicode(false);

                entity.Property(e => e.ErrType).IsUnicode(false);

                entity.Property(e => e.FullResName).IsUnicode(false);

                entity.Property(e => e.Origin).IsUnicode(false);

                entity.Property(e => e.ResourceName).IsUnicode(false);

                entity.Property(e => e.SchemaName).IsUnicode(false);
            });

            modelBuilder.Entity<SpAddressBaseV>(entity =>
            {
                entity.ToView("SP_ADDRESS_BASE_V");

                entity.Property(e => e.AddrLine1).IsUnicode(false);

                entity.Property(e => e.AddrLine2).IsUnicode(false);

                entity.Property(e => e.AddrTypeName).IsUnicode(false);

                entity.Property(e => e.Country).IsUnicode(false);

                entity.Property(e => e.CustId).IsUnicode(false);

                entity.Property(e => e.Driverflag).HasPrecision(1);

                entity.Property(e => e.Dseflag).HasPrecision(1);

                entity.Property(e => e.PersStatus).IsUnicode(false);

                entity.Property(e => e.Personguid).IsUnicode(false);

                entity.Property(e => e.Personid).IsUnicode(false);

                entity.Property(e => e.PhoneGuid).IsUnicode(false);

                entity.Property(e => e.PhoneNo).IsUnicode(false);

                entity.Property(e => e.PhonePersGuid).IsUnicode(false);

                entity.Property(e => e.PhoneTypeCode).IsUnicode(false);

                entity.Property(e => e.PhoneTypeName).IsUnicode(false);

                entity.Property(e => e.SpBioid).IsUnicode(false);

                entity.Property(e => e.SpFname).IsUnicode(false);

                entity.Property(e => e.SpLname).IsUnicode(false);

                entity.Property(e => e.SpMname).IsUnicode(false);

                entity.Property(e => e.SpPkguid).IsUnicode(false);

                entity.Property(e => e.SpStatus).IsUnicode(false);

                entity.Property(e => e.Spflag).HasPrecision(1);

                entity.Property(e => e.Spguid).IsUnicode(false);

                entity.Property(e => e.Spid).IsUnicode(false);

                entity.Property(e => e.State).IsUnicode(false);
            });

            modelBuilder.Entity<SpAddressV>(entity =>
            {
                entity.ToView("SP_ADDRESS_V");

                entity.Property(e => e.AddrLine1).IsUnicode(false);

                entity.Property(e => e.AddrLine2).IsUnicode(false);

                entity.Property(e => e.AddrTypeName).IsUnicode(false);

                entity.Property(e => e.Country).IsUnicode(false);

                entity.Property(e => e.CustId).IsUnicode(false);

                entity.Property(e => e.Driverflag).HasPrecision(1);

                entity.Property(e => e.Dseflag).HasPrecision(1);

                entity.Property(e => e.PersStatus).IsUnicode(false);

                entity.Property(e => e.Personguid).IsUnicode(false);

                entity.Property(e => e.Personid).IsUnicode(false);

                entity.Property(e => e.PhoneGuid).IsUnicode(false);

                entity.Property(e => e.PhoneNo).IsUnicode(false);

                entity.Property(e => e.PhonePersGuid).IsUnicode(false);

                entity.Property(e => e.PhoneTypeCode).IsUnicode(false);

                entity.Property(e => e.PhoneTypeName).IsUnicode(false);

                entity.Property(e => e.SpBioid).IsUnicode(false);

                entity.Property(e => e.SpFname).IsUnicode(false);

                entity.Property(e => e.SpLname).IsUnicode(false);

                entity.Property(e => e.SpMname).IsUnicode(false);

                entity.Property(e => e.SpPkguid).IsUnicode(false);

                entity.Property(e => e.SpStatus).IsUnicode(false);

                entity.Property(e => e.Spflag).HasPrecision(1);

                entity.Property(e => e.Spguid).IsUnicode(false);

                entity.Property(e => e.Spid).IsUnicode(false);

                entity.Property(e => e.State).IsUnicode(false);
            });

            modelBuilder.Entity<SpBaseV>(entity =>
            {
                entity.ToView("SP_BASE_V");

                entity.Property(e => e.CustId).IsUnicode(false);

                entity.Property(e => e.Driverflag).HasPrecision(1);

                entity.Property(e => e.Dseflag).HasPrecision(1);

                entity.Property(e => e.Guid).IsUnicode(false);

                entity.Property(e => e.Issendtomonroe).HasPrecision(5);

                entity.Property(e => e.PersStatus).IsUnicode(false);

                entity.Property(e => e.Personguid).IsUnicode(false);

                entity.Property(e => e.Persontype).IsUnicode(false);

                entity.Property(e => e.SpBioid).IsUnicode(false);

                entity.Property(e => e.SpDefrredDocCheckFlag).IsUnicode(false);

                entity.Property(e => e.SpFname).IsUnicode(false);

                entity.Property(e => e.SpFullname).IsUnicode(false);

                entity.Property(e => e.SpLname).IsUnicode(false);

                entity.Property(e => e.SpMname).IsUnicode(false);

                entity.Property(e => e.SpObjVerNo).HasPrecision(10);

                entity.Property(e => e.SpPkguid).IsUnicode(false);

                entity.Property(e => e.SpStatus).IsUnicode(false);

                entity.Property(e => e.Spclientmapguid).IsUnicode(false);

                entity.Property(e => e.Spflag).HasPrecision(1);

                entity.Property(e => e.Spid).IsUnicode(false);

                entity.Property(e => e.Tdscode).IsUnicode(false);
            });

            modelBuilder.Entity<SpCarDriDeatilsV>(entity =>
            {
                entity.ToView("SP_CAR_DRI_DEATILS_V");

                entity.Property(e => e.Carguid).IsUnicode(false);

                entity.Property(e => e.DriverPersonGuid).IsUnicode(false);

                entity.Property(e => e.Registrationno).IsUnicode(false);

                entity.Property(e => e.SpPersonGuid).IsUnicode(false);

                entity.Property(e => e.Spid).IsUnicode(false);
            });

            modelBuilder.Entity<SpDseTrainingV>(entity =>
            {
                entity.ToView("SP_DSE_TRAINING_V");

                entity.Property(e => e.Attendeetype).IsUnicode(false);

                entity.Property(e => e.Attendeobjectversionno).HasPrecision(10);

                entity.Property(e => e.Attendeoracleentityid).IsUnicode(false);

                entity.Property(e => e.Attendeoracleentityname).IsUnicode(false);

                entity.Property(e => e.Batchdisabled).HasPrecision(1);

                entity.Property(e => e.Batchobjectversionno).HasPrecision(10);

                entity.Property(e => e.Batchoracleentityid).IsUnicode(false);

                entity.Property(e => e.Batchoracleentityname).IsUnicode(false);

                entity.Property(e => e.Batchpkguid).IsUnicode(false);

                entity.Property(e => e.EntityCode).IsUnicode(false);

                entity.Property(e => e.Isattended).IsUnicode(false);

                entity.Property(e => e.Obtainedmarks).IsUnicode(false);

                entity.Property(e => e.PersBioid).IsUnicode(false);

                entity.Property(e => e.PersDriverflag).HasPrecision(1);

                entity.Property(e => e.PersDseflag).HasPrecision(1);

                entity.Property(e => e.PersFname).IsUnicode(false);

                entity.Property(e => e.PersGender).IsUnicode(false);

                entity.Property(e => e.PersLname).IsUnicode(false);

                entity.Property(e => e.PersMname).IsUnicode(false);

                entity.Property(e => e.PersObjVerNo).HasPrecision(10);

                entity.Property(e => e.PersSpflag).HasPrecision(1);

                entity.Property(e => e.PersStatusCode).IsUnicode(false);

                entity.Property(e => e.PersTitle).IsUnicode(false);

                entity.Property(e => e.Personid).IsUnicode(false);

                entity.Property(e => e.Personmasterguid).IsUnicode(false);

                entity.Property(e => e.Remarks).IsUnicode(false);

                entity.Property(e => e.StatusCode).IsUnicode(false);

                entity.Property(e => e.StatusDesc).IsUnicode(false);

                entity.Property(e => e.StatusEntEntguid).IsUnicode(false);

                entity.Property(e => e.StatusEntObjVerNo).HasPrecision(10);

                entity.Property(e => e.StatusEntStsguid).IsUnicode(false);

                entity.Property(e => e.StatusName).IsUnicode(false);

                entity.Property(e => e.Trainerdisabled).HasPrecision(1);

                entity.Property(e => e.Trainermasterguid).IsUnicode(false);

                entity.Property(e => e.Trainerobjectversionno).HasPrecision(10);

                entity.Property(e => e.Traineroracleentityid).IsUnicode(false);

                entity.Property(e => e.Traineroracleentityname).IsUnicode(false);

                entity.Property(e => e.Trainerpkguid).IsUnicode(false);

                entity.Property(e => e.Trainerstatusentityguid)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.TrainingMagEmpNum)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.TrainingMagFullName).IsUnicode(false);

                entity.Property(e => e.TrainingMagId).IsUnicode(false);

                entity.Property(e => e.TrainingMagJobId)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.TrainingMagJobName).IsUnicode(false);

                entity.Property(e => e.TrainingMagNpwNum)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.TrainingMagOrgId)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.TrainingMagPerId)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.TrainingMagPerType)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.TrainingMagPositionId)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.TrainingMagPositionName).IsUnicode(false);

                entity.Property(e => e.Trainingattendeeguid).IsUnicode(false);

                entity.Property(e => e.Trainingattendeepkguid).IsUnicode(false);

                entity.Property(e => e.Trainingbatchmasterguid).IsUnicode(false);

                entity.Property(e => e.Trainingname).IsUnicode(false);

                entity.Property(e => e.Trainingresult).IsUnicode(false);

                entity.Property(e => e.Trainingstatusentityguid).IsUnicode(false);

                entity.Property(e => e.Trainingtopic).IsUnicode(false);

                entity.Property(e => e.Trainingtypecomments).IsUnicode(false);

                entity.Property(e => e.Trainingtypedescription).IsUnicode(false);

                entity.Property(e => e.Trainingtypedisabled).HasPrecision(1);

                entity.Property(e => e.Trainingtypemasterguid).IsUnicode(false);

                entity.Property(e => e.Trainingtypename).IsUnicode(false);

                entity.Property(e => e.Trainingtypeobjectversionno).HasPrecision(10);

                entity.Property(e => e.Trainingtypeoracleentityid).IsUnicode(false);

                entity.Property(e => e.Trainingtypeoracleentityname).IsUnicode(false);

                entity.Property(e => e.Trainingtypepkguid).IsUnicode(false);

                entity.Property(e => e.Trainingtypequickaccesscode).IsUnicode(false);
            });

            modelBuilder.Entity<SpManthan>(entity =>
            {
                entity.Property(e => e.Addflag).IsUnicode(false);

                entity.Property(e => e.Addresserror).IsUnicode(false);

                entity.Property(e => e.Addressproofpath).IsUnicode(false);

                entity.Property(e => e.Addressstatus).IsUnicode(false);

                entity.Property(e => e.Aggrementdocerror).IsUnicode(false);

                entity.Property(e => e.Aggrementdocflag).IsUnicode(false);

                entity.Property(e => e.Aggrementdocpath).IsUnicode(false);

                entity.Property(e => e.Aggrementdocstatus).IsUnicode(false);

                entity.Property(e => e.Associateid).IsUnicode(false);

                entity.Property(e => e.Cancelledcheckerror).IsUnicode(false);

                entity.Property(e => e.Cancelledcheckflag).IsUnicode(false);

                entity.Property(e => e.Cancelledcheckpath).IsUnicode(false);

                entity.Property(e => e.Cancelledcheckstatus).IsUnicode(false);

                entity.Property(e => e.Drivingflag).IsUnicode(false);

                entity.Property(e => e.Drivinglicenseerror).IsUnicode(false);

                entity.Property(e => e.Drivinglicensepath).IsUnicode(false);

                entity.Property(e => e.Drivinglicensestatus).IsUnicode(false);

                entity.Property(e => e.Pan).IsUnicode(false);

                entity.Property(e => e.Pancopyerror).IsUnicode(false);

                entity.Property(e => e.Pancopypath).IsUnicode(false);

                entity.Property(e => e.Pancopystatus).IsUnicode(false);

                entity.Property(e => e.Panflag).IsUnicode(false);

                entity.Property(e => e.Photoflag).IsUnicode(false);

                entity.Property(e => e.Photoiderror).IsUnicode(false);

                entity.Property(e => e.Photoidpath).IsUnicode(false);

                entity.Property(e => e.Photoidstatus).IsUnicode(false);

                entity.Property(e => e.Prospectid).HasPrecision(10);

                entity.Property(e => e.SeqId).HasPrecision(10);

                entity.Property(e => e.Servicetaxerror).IsUnicode(false);

                entity.Property(e => e.Servicetaxflag).IsUnicode(false);

                entity.Property(e => e.Servicetaxpath).IsUnicode(false);

                entity.Property(e => e.Servicetaxstatus).IsUnicode(false);

                entity.Property(e => e.Status).IsUnicode(false);

                entity.Property(e => e.Verificationid).HasPrecision(10);
            });

            modelBuilder.Entity<SpSiteBal>(entity =>
            {
                entity.Property(e => e.AccrualDue)
                    .ValueGeneratedOnAdd()
                    .HasDefaultValueSql("0 ");

                entity.Property(e => e.AccrualPostTot)
                    .ValueGeneratedOnAdd()
                    .HasDefaultValueSql("0 ");

                entity.Property(e => e.AccrualRem)
                    .ValueGeneratedOnAdd()
                    .HasDefaultValueSql("0 ");

                entity.Property(e => e.AccrualTot)
                    .ValueGeneratedOnAdd()
                    .HasDefaultValueSql("0 ");

                entity.Property(e => e.AccrualUnpost)
                    .ValueGeneratedOnAdd()
                    .HasDefaultValueSql("0 ");

                entity.Property(e => e.AdjPostTot)
                    .ValueGeneratedOnAdd()
                    .HasDefaultValueSql("0 ");

                entity.Property(e => e.AdjTot)
                    .ValueGeneratedOnAdd()
                    .HasDefaultValueSql("0 ");

                entity.Property(e => e.AdjUnapp)
                    .ValueGeneratedOnAdd()
                    .HasDefaultValueSql("0 ");

                entity.Property(e => e.AdjUnpost)
                    .ValueGeneratedOnAdd()
                    .HasDefaultValueSql("0 ");

                entity.Property(e => e.BackdateAccrual)
                    .ValueGeneratedOnAdd()
                    .HasDefaultValueSql("0 ");

                entity.Property(e => e.BackdateCr)
                    .ValueGeneratedOnAdd()
                    .HasDefaultValueSql("0 ");

                entity.Property(e => e.BackdateDep)
                    .ValueGeneratedOnAdd()
                    .HasDefaultValueSql("0 ");

                entity.Property(e => e.BackdateDr)
                    .ValueGeneratedOnAdd()
                    .HasDefaultValueSql("0 ");

                entity.Property(e => e.BackdateInv)
                    .ValueGeneratedOnAdd()
                    .HasDefaultValueSql("0 ");

                entity.Property(e => e.BackdatePmnt)
                    .ValueGeneratedOnAdd()
                    .HasDefaultValueSql("0 ");

                entity.Property(e => e.BalanceDt).ValueGeneratedOnAdd();

                entity.Property(e => e.CrPostTot)
                    .ValueGeneratedOnAdd()
                    .HasDefaultValueSql("0 ");

                entity.Property(e => e.CrTot)
                    .ValueGeneratedOnAdd()
                    .HasDefaultValueSql("0 ");

                entity.Property(e => e.CrUnapp)
                    .ValueGeneratedOnAdd()
                    .HasDefaultValueSql("0 ");

                entity.Property(e => e.CrUnpost)
                    .ValueGeneratedOnAdd()
                    .HasDefaultValueSql("0 ");

                entity.Property(e => e.CreatedBy)
                    .ValueGeneratedOnAdd()
                    .HasDefaultValueSql("0 ");

                entity.Property(e => e.CreationDate).ValueGeneratedOnAdd();

                entity.Property(e => e.CumulativeAccrual)
                    .ValueGeneratedOnAdd()
                    .HasDefaultValueSql("0 ");

                entity.Property(e => e.CumulativeAdj)
                    .ValueGeneratedOnAdd()
                    .HasDefaultValueSql("0 ");

                entity.Property(e => e.CumulativeCr)
                    .ValueGeneratedOnAdd()
                    .HasDefaultValueSql("0 ");

                entity.Property(e => e.CumulativeDep)
                    .ValueGeneratedOnAdd()
                    .HasDefaultValueSql("0 ");

                entity.Property(e => e.CumulativeDr)
                    .ValueGeneratedOnAdd()
                    .HasDefaultValueSql("0 ");

                entity.Property(e => e.CumulativeInv)
                    .ValueGeneratedOnAdd()
                    .HasDefaultValueSql("0 ");

                entity.Property(e => e.CumulativePmnt)
                    .ValueGeneratedOnAdd()
                    .HasDefaultValueSql("0 ");

                entity.Property(e => e.CumulativeRefund)
                    .ValueGeneratedOnAdd()
                    .HasDefaultValueSql("0 ");

                entity.Property(e => e.DepDue)
                    .ValueGeneratedOnAdd()
                    .HasDefaultValueSql("0 ");

                entity.Property(e => e.DepPost)
                    .ValueGeneratedOnAdd()
                    .HasDefaultValueSql("0 ");

                entity.Property(e => e.DepRem)
                    .ValueGeneratedOnAdd()
                    .HasDefaultValueSql("0 ");

                entity.Property(e => e.DepTot).ValueGeneratedOnAdd();

                entity.Property(e => e.DepUnpost)
                    .ValueGeneratedOnAdd()
                    .HasDefaultValueSql("0 ");

                entity.Property(e => e.DrDue)
                    .ValueGeneratedOnAdd()
                    .HasDefaultValueSql("0 ");

                entity.Property(e => e.DrPostTot)
                    .ValueGeneratedOnAdd()
                    .HasDefaultValueSql("0 ");

                entity.Property(e => e.DrRem)
                    .ValueGeneratedOnAdd()
                    .HasDefaultValueSql("0 ");

                entity.Property(e => e.DrTot)
                    .ValueGeneratedOnAdd()
                    .HasDefaultValueSql("0 ");

                entity.Property(e => e.DrUnpost)
                    .ValueGeneratedOnAdd()
                    .HasDefaultValueSql("0 ");

                entity.Property(e => e.InvDue)
                    .ValueGeneratedOnAdd()
                    .HasDefaultValueSql("0 ");

                entity.Property(e => e.InvPost)
                    .ValueGeneratedOnAdd()
                    .HasDefaultValueSql("0 ");

                entity.Property(e => e.InvRem)
                    .ValueGeneratedOnAdd()
                    .HasDefaultValueSql("0 ");

                entity.Property(e => e.InvTot)
                    .ValueGeneratedOnAdd()
                    .HasDefaultValueSql("0 ");

                entity.Property(e => e.InvUnpost)
                    .ValueGeneratedOnAdd()
                    .HasDefaultValueSql("0 ");

                entity.Property(e => e.LockBal)
                    .ValueGeneratedOnAdd()
                    .HasDefaultValueSql("0 ");

                entity.Property(e => e.LockBalCalcDate).ValueGeneratedOnAdd();

                entity.Property(e => e.LockLimit)
                    .ValueGeneratedOnAdd()
                    .HasDefaultValueSql("0 ");

                entity.Property(e => e.LockcalcLockbal).HasDefaultValueSql("0");

                entity.Property(e => e.OsLockClearedDt).ValueGeneratedOnAdd();

                entity.Property(e => e.OsLockCreatedDt).ValueGeneratedOnAdd();

                entity.Property(e => e.PkgnonbalupdateamountCr).HasDefaultValueSql("0");

                entity.Property(e => e.PkgnonbalupdateamountDr).HasDefaultValueSql("0");

                entity.Property(e => e.PmntPost)
                    .ValueGeneratedOnAdd()
                    .HasDefaultValueSql("0 ");

                entity.Property(e => e.PmntTot)
                    .ValueGeneratedOnAdd()
                    .HasDefaultValueSql("0 ");

                entity.Property(e => e.PmntUnapp)
                    .ValueGeneratedOnAdd()
                    .HasDefaultValueSql("0 ");

                entity.Property(e => e.PmntUnpost)
                    .ValueGeneratedOnAdd()
                    .HasDefaultValueSql("0 ");

                entity.Property(e => e.RefundPost)
                    .ValueGeneratedOnAdd()
                    .HasDefaultValueSql("0 ");

                entity.Property(e => e.RefundTot)
                    .ValueGeneratedOnAdd()
                    .HasDefaultValueSql("0 ");

                entity.Property(e => e.RefundUnpaid)
                    .ValueGeneratedOnAdd()
                    .HasDefaultValueSql("0 ");

                entity.Property(e => e.RefundUnpost)
                    .ValueGeneratedOnAdd()
                    .HasDefaultValueSql("0 ");

                entity.Property(e => e.Siteguid)
                    .IsUnicode(false)
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.TodayAccrual)
                    .ValueGeneratedOnAdd()
                    .HasDefaultValueSql("0 ");

                entity.Property(e => e.TodayCr)
                    .ValueGeneratedOnAdd()
                    .HasDefaultValueSql("0 ");

                entity.Property(e => e.TodayDep)
                    .ValueGeneratedOnAdd()
                    .HasDefaultValueSql("0 ");

                entity.Property(e => e.TodayDr)
                    .ValueGeneratedOnAdd()
                    .HasDefaultValueSql("0 ");

                entity.Property(e => e.TodayInv)
                    .ValueGeneratedOnAdd()
                    .HasDefaultValueSql("0 ");

                entity.Property(e => e.TodayPmnt)
                    .ValueGeneratedOnAdd()
                    .HasDefaultValueSql("0 ");

                entity.Property(e => e.UpdateDate).ValueGeneratedOnAdd();

                entity.Property(e => e.UpdatedBy)
                    .ValueGeneratedOnAdd()
                    .HasDefaultValueSql("0 ");
            });

            modelBuilder.Entity<SpSiteBalHist>(entity =>
            {
                entity.Property(e => e.LockcalcLockbal).HasDefaultValueSql("0");

                entity.Property(e => e.PkgnonbalupdateamountCr).HasDefaultValueSql("0");

                entity.Property(e => e.PkgnonbalupdateamountDr).HasDefaultValueSql("0");

                entity.Property(e => e.Siteguid).IsUnicode(false);
            });

            modelBuilder.Entity<SpSiteBalHistGapFillLog>(entity =>
            {
                entity.Property(e => e.SpSiteGuid).IsUnicode(false);
            });

            modelBuilder.Entity<SpSiteBalHistTemp>(entity =>
            {
                entity.Property(e => e.Siteguid).IsUnicode(false);
            });

            modelBuilder.Entity<SpSiteBalTrigger>(entity =>
            {
                entity.Property(e => e.Siteguid).IsUnicode(false);
            });

            modelBuilder.Entity<SpTotalBreakV>(entity =>
            {
                entity.ToView("SP_TOTAL_BREAK_V");

                entity.Property(e => e.Serviceproviderguid).IsUnicode(false);
            });

            modelBuilder.Entity<SpTrainingV>(entity =>
            {
                entity.ToView("SP_TRAINING_V");

                entity.Property(e => e.Attendeetype).IsUnicode(false);

                entity.Property(e => e.Attendeobjectversionno).HasPrecision(10);

                entity.Property(e => e.Attendeoracleentityid).IsUnicode(false);

                entity.Property(e => e.Attendeoracleentityname).IsUnicode(false);

                entity.Property(e => e.Batchdisabled).HasPrecision(1);

                entity.Property(e => e.Batchobjectversionno).HasPrecision(10);

                entity.Property(e => e.Batchoracleentityid).IsUnicode(false);

                entity.Property(e => e.Batchoracleentityname).IsUnicode(false);

                entity.Property(e => e.Batchpkguid).IsUnicode(false);

                entity.Property(e => e.EntityCode).IsUnicode(false);

                entity.Property(e => e.Isattended).IsUnicode(false);

                entity.Property(e => e.Obtainedmarks).IsUnicode(false);

                entity.Property(e => e.PersBioid).IsUnicode(false);

                entity.Property(e => e.PersDriverflag).HasPrecision(1);

                entity.Property(e => e.PersDseflag).HasPrecision(1);

                entity.Property(e => e.PersFname).IsUnicode(false);

                entity.Property(e => e.PersGender).IsUnicode(false);

                entity.Property(e => e.PersLname).IsUnicode(false);

                entity.Property(e => e.PersMname).IsUnicode(false);

                entity.Property(e => e.PersObjVerNo).HasPrecision(10);

                entity.Property(e => e.PersSpflag).HasPrecision(1);

                entity.Property(e => e.PersStatusCode).IsUnicode(false);

                entity.Property(e => e.PersTitle).IsUnicode(false);

                entity.Property(e => e.Personid).IsUnicode(false);

                entity.Property(e => e.Personmasterguid).IsUnicode(false);

                entity.Property(e => e.Remarks).IsUnicode(false);

                entity.Property(e => e.StatusCode).IsUnicode(false);

                entity.Property(e => e.StatusDesc).IsUnicode(false);

                entity.Property(e => e.StatusEntEntguid).IsUnicode(false);

                entity.Property(e => e.StatusEntObjVerNo).HasPrecision(10);

                entity.Property(e => e.StatusEntStsguid).IsUnicode(false);

                entity.Property(e => e.StatusName).IsUnicode(false);

                entity.Property(e => e.Trainerdisabled).HasPrecision(1);

                entity.Property(e => e.Trainermasterguid).IsUnicode(false);

                entity.Property(e => e.Trainerobjectversionno).HasPrecision(10);

                entity.Property(e => e.Traineroracleentityid).IsUnicode(false);

                entity.Property(e => e.Traineroracleentityname).IsUnicode(false);

                entity.Property(e => e.Trainerpkguid).IsUnicode(false);

                entity.Property(e => e.Trainerstatusentityguid)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.TrainingMagEmpNum)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.TrainingMagFullName).IsUnicode(false);

                entity.Property(e => e.TrainingMagId).IsUnicode(false);

                entity.Property(e => e.TrainingMagJobId)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.TrainingMagJobName).IsUnicode(false);

                entity.Property(e => e.TrainingMagNpwNum)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.TrainingMagOrgId)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.TrainingMagPerId)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.TrainingMagPerType)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.TrainingMagPositionId)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.TrainingMagPositionName).IsUnicode(false);

                entity.Property(e => e.Trainingattendeeguid).IsUnicode(false);

                entity.Property(e => e.Trainingattendeepkguid).IsUnicode(false);

                entity.Property(e => e.Trainingbatchmasterguid).IsUnicode(false);

                entity.Property(e => e.Trainingname).IsUnicode(false);

                entity.Property(e => e.Trainingresult).IsUnicode(false);

                entity.Property(e => e.Trainingstatusentityguid).IsUnicode(false);

                entity.Property(e => e.Trainingtopic).IsUnicode(false);

                entity.Property(e => e.Trainingtypecomments).IsUnicode(false);

                entity.Property(e => e.Trainingtypedescription).IsUnicode(false);

                entity.Property(e => e.Trainingtypedisabled).HasPrecision(1);

                entity.Property(e => e.Trainingtypemasterguid).IsUnicode(false);

                entity.Property(e => e.Trainingtypename).IsUnicode(false);

                entity.Property(e => e.Trainingtypeobjectversionno).HasPrecision(10);

                entity.Property(e => e.Trainingtypeoracleentityid).IsUnicode(false);

                entity.Property(e => e.Trainingtypeoracleentityname).IsUnicode(false);

                entity.Property(e => e.Trainingtypepkguid).IsUnicode(false);

                entity.Property(e => e.Trainingtypequickaccesscode).IsUnicode(false);
            });

            modelBuilder.Entity<SpV>(entity =>
            {
                entity.ToView("SP_V");

                entity.Property(e => e.CustId).IsUnicode(false);

                entity.Property(e => e.Driverflag).HasPrecision(1);

                entity.Property(e => e.Dseflag).HasPrecision(1);

                entity.Property(e => e.Guid).IsUnicode(false);

                entity.Property(e => e.Issendtomonroe).HasPrecision(5);

                entity.Property(e => e.PersStatus).IsUnicode(false);

                entity.Property(e => e.Personguid).IsUnicode(false);

                entity.Property(e => e.Persontype).IsUnicode(false);

                entity.Property(e => e.SpBioid).IsUnicode(false);

                entity.Property(e => e.SpDefrredDocCheckFlag).IsUnicode(false);

                entity.Property(e => e.SpFname).IsUnicode(false);

                entity.Property(e => e.SpFullname).IsUnicode(false);

                entity.Property(e => e.SpLname).IsUnicode(false);

                entity.Property(e => e.SpMname).IsUnicode(false);

                entity.Property(e => e.SpObjVerNo).HasPrecision(10);

                entity.Property(e => e.SpPkguid).IsUnicode(false);

                entity.Property(e => e.SpStatus).IsUnicode(false);

                entity.Property(e => e.Spclientmapguid).IsUnicode(false);

                entity.Property(e => e.Spflag).HasPrecision(1);

                entity.Property(e => e.Spid).IsUnicode(false);

                entity.Property(e => e.Tdscode).IsUnicode(false);
            });

            modelBuilder.Entity<SpbalanceBaseV>(entity =>
            {
                entity.ToView("SPBALANCE_BASE_V");

                entity.Property(e => e.Billsiteuseid).IsUnicode(false);

                entity.Property(e => e.BrandCode).IsUnicode(false);

                entity.Property(e => e.BrandGuid).IsUnicode(false);

                entity.Property(e => e.BrandName).IsUnicode(false);

                entity.Property(e => e.Carmasterguid).IsUnicode(false);

                entity.Property(e => e.CityCode).IsUnicode(false);

                entity.Property(e => e.CityGuid).IsUnicode(false);

                entity.Property(e => e.CityName).IsUnicode(false);

                entity.Property(e => e.Creditlimit).HasPrecision(10);

                entity.Property(e => e.GlSegment1).IsUnicode(false);

                entity.Property(e => e.GlSement4).IsUnicode(false);

                entity.Property(e => e.GlSement6).IsUnicode(false);

                entity.Property(e => e.LeCode).IsUnicode(false);

                entity.Property(e => e.LeGuid).IsUnicode(false);

                entity.Property(e => e.LeName).IsUnicode(false);

                entity.Property(e => e.LebranchGuid).IsUnicode(false);

                entity.Property(e => e.ModelCode).IsUnicode(false);

                entity.Property(e => e.ModelGuid).IsUnicode(false);

                entity.Property(e => e.ModelName).IsUnicode(false);

                entity.Property(e => e.OrgId).HasPrecision(4);

                entity.Property(e => e.Personguid).IsUnicode(false);

                entity.Property(e => e.SecObjVerNo).HasPrecision(10);

                entity.Property(e => e.Securitycombinationguid).IsUnicode(false);

                entity.Property(e => e.SiteStatusCode).IsUnicode(false);

                entity.Property(e => e.SiteStatusName).IsUnicode(false);

                entity.Property(e => e.Sitemasterguid).IsUnicode(false);

                entity.Property(e => e.Sitename).IsUnicode(false);

                entity.Property(e => e.SitetypeDescription).IsUnicode(false);

                entity.Property(e => e.SitetypeDisabled).HasPrecision(1);

                entity.Property(e => e.SitetypeName).IsUnicode(false);

                entity.Property(e => e.SitetypeObjectversionno).HasPrecision(3);

                entity.Property(e => e.SitetypeOracleentityid).IsUnicode(false);

                entity.Property(e => e.SitetypeOracleentityname).IsUnicode(false);

                entity.Property(e => e.SitetypePkguid).IsUnicode(false);

                entity.Property(e => e.SitetypeQuickaccesscode).IsUnicode(false);

                entity.Property(e => e.SpBioId).IsUnicode(false);

                entity.Property(e => e.SpFname).IsUnicode(false);

                entity.Property(e => e.SpGuid).IsUnicode(false);

                entity.Property(e => e.SpLname).IsUnicode(false);

                entity.Property(e => e.SpMname).IsUnicode(false);

                entity.Property(e => e.SpStatus).IsUnicode(false);

                entity.Property(e => e.Spid).IsUnicode(false);
            });

            modelBuilder.Entity<SpbalanceV>(entity =>
            {
                entity.ToView("SPBALANCE_V");

                entity.Property(e => e.Billsiteuseid).IsUnicode(false);

                entity.Property(e => e.BrandCode).IsUnicode(false);

                entity.Property(e => e.BrandGuid).IsUnicode(false);

                entity.Property(e => e.BrandName).IsUnicode(false);

                entity.Property(e => e.Carmasterguid).IsUnicode(false);

                entity.Property(e => e.CityCode).IsUnicode(false);

                entity.Property(e => e.CityGuid).IsUnicode(false);

                entity.Property(e => e.CityName).IsUnicode(false);

                entity.Property(e => e.Creditlimit).HasPrecision(10);

                entity.Property(e => e.GlSegment1).IsUnicode(false);

                entity.Property(e => e.GlSement4).IsUnicode(false);

                entity.Property(e => e.GlSement6).IsUnicode(false);

                entity.Property(e => e.LeCode).IsUnicode(false);

                entity.Property(e => e.LeGuid).IsUnicode(false);

                entity.Property(e => e.LeName).IsUnicode(false);

                entity.Property(e => e.LebranchGuid).IsUnicode(false);

                entity.Property(e => e.ModelCode).IsUnicode(false);

                entity.Property(e => e.ModelGuid).IsUnicode(false);

                entity.Property(e => e.ModelName).IsUnicode(false);

                entity.Property(e => e.OrgId).HasPrecision(4);

                entity.Property(e => e.Personguid).IsUnicode(false);

                entity.Property(e => e.SecObjVerNo).HasPrecision(10);

                entity.Property(e => e.Securitycombinationguid).IsUnicode(false);

                entity.Property(e => e.SiteStatusCode).IsUnicode(false);

                entity.Property(e => e.SiteStatusName).IsUnicode(false);

                entity.Property(e => e.Sitemasterguid).IsUnicode(false);

                entity.Property(e => e.Sitename).IsUnicode(false);

                entity.Property(e => e.SitetypeDescription).IsUnicode(false);

                entity.Property(e => e.SitetypeDisabled).HasPrecision(1);

                entity.Property(e => e.SitetypeName).IsUnicode(false);

                entity.Property(e => e.SitetypeObjectversionno).HasPrecision(3);

                entity.Property(e => e.SitetypeOracleentityid).IsUnicode(false);

                entity.Property(e => e.SitetypeOracleentityname).IsUnicode(false);

                entity.Property(e => e.SitetypePkguid).IsUnicode(false);

                entity.Property(e => e.SitetypeQuickaccesscode).IsUnicode(false);

                entity.Property(e => e.SpBioId).IsUnicode(false);

                entity.Property(e => e.SpFname).IsUnicode(false);

                entity.Property(e => e.SpGuid).IsUnicode(false);

                entity.Property(e => e.SpLname).IsUnicode(false);

                entity.Property(e => e.SpMname).IsUnicode(false);

                entity.Property(e => e.SpStatus).IsUnicode(false);

                entity.Property(e => e.Spid).IsUnicode(false);
            });

            modelBuilder.Entity<Spbreak>(entity =>
            {
                entity.Property(e => e.Carallocationguid).IsUnicode(false);

                entity.Property(e => e.Comments).IsUnicode(false);

                entity.Property(e => e.Disabled).HasPrecision(1);

                entity.Property(e => e.Guid).IsUnicode(false);

                entity.Property(e => e.Isapprovalrequired)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Objectversionno).HasPrecision(10);

                entity.Property(e => e.Oracleentityid).IsUnicode(false);

                entity.Property(e => e.Oracleentityname).IsUnicode(false);

                entity.Property(e => e.Pkguid).IsUnicode(false);

                entity.Property(e => e.Processedflag).IsUnicode(false);

                entity.Property(e => e.Serviceproviderguid).IsUnicode(false);

                entity.Property(e => e.Statusentityguid).IsUnicode(false);

                entity.Property(e => e.Userarchived).IsUnicode(false);

                entity.Property(e => e.Usercreated).IsUnicode(false);

                entity.Property(e => e.Userdeleted).IsUnicode(false);

                entity.Property(e => e.Userupdated).IsUnicode(false);
            });

            modelBuilder.Entity<SpbreakBaseV>(entity =>
            {
                entity.ToView("SPBREAK_BASE_V");

                entity.Property(e => e.Carallocationguid).IsUnicode(false);

                entity.Property(e => e.Carregistrationno).IsUnicode(false);

                entity.Property(e => e.Comments).IsUnicode(false);

                entity.Property(e => e.CustId).IsUnicode(false);

                entity.Property(e => e.Driverflag).HasPrecision(1);

                entity.Property(e => e.Dseflag).HasPrecision(1);

                entity.Property(e => e.EntityCode).IsUnicode(false);

                entity.Property(e => e.Isapprovalrequired)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.PersStatus).IsUnicode(false);

                entity.Property(e => e.Personguid).IsUnicode(false);

                entity.Property(e => e.Processedflag).IsUnicode(false);

                entity.Property(e => e.Securitycombinationguid).IsUnicode(false);

                entity.Property(e => e.Serviceproviderguid).IsUnicode(false);

                entity.Property(e => e.SpBioid).IsUnicode(false);

                entity.Property(e => e.SpFname).IsUnicode(false);

                entity.Property(e => e.SpLname).IsUnicode(false);

                entity.Property(e => e.SpMname).IsUnicode(false);

                entity.Property(e => e.SpObjVerNo).HasPrecision(10);

                entity.Property(e => e.SpStatus).IsUnicode(false);

                entity.Property(e => e.Spbreakdisabled).HasPrecision(1);

                entity.Property(e => e.Spbreakguid).IsUnicode(false);

                entity.Property(e => e.Spbreakobjectversionno).HasPrecision(10);

                entity.Property(e => e.Spbreakoracleentityid).IsUnicode(false);

                entity.Property(e => e.Spbreakoracleentityname).IsUnicode(false);

                entity.Property(e => e.Spbreakpkguid).IsUnicode(false);

                entity.Property(e => e.Spflag).HasPrecision(1);

                entity.Property(e => e.Spid).IsUnicode(false);

                entity.Property(e => e.StatusCode).IsUnicode(false);

                entity.Property(e => e.StatusDesc).IsUnicode(false);

                entity.Property(e => e.StatusEntEntguid).IsUnicode(false);

                entity.Property(e => e.StatusEntObjVerNo).HasPrecision(10);

                entity.Property(e => e.StatusEntStsguid).IsUnicode(false);

                entity.Property(e => e.StatusName).IsUnicode(false);

                entity.Property(e => e.Statusentityguid).IsUnicode(false);
            });

            modelBuilder.Entity<SpbreakV>(entity =>
            {
                entity.ToView("SPBREAK_V");

                entity.Property(e => e.Carallocationguid).IsUnicode(false);

                entity.Property(e => e.Carregistrationno).IsUnicode(false);

                entity.Property(e => e.Comments).IsUnicode(false);

                entity.Property(e => e.CustId).IsUnicode(false);

                entity.Property(e => e.Driverflag).HasPrecision(1);

                entity.Property(e => e.Dseflag).HasPrecision(1);

                entity.Property(e => e.EntityCode).IsUnicode(false);

                entity.Property(e => e.Isapprovalrequired)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.PersStatus).IsUnicode(false);

                entity.Property(e => e.Personguid).IsUnicode(false);

                entity.Property(e => e.Processedflag).IsUnicode(false);

                entity.Property(e => e.Securitycombinationguid).IsUnicode(false);

                entity.Property(e => e.Serviceproviderguid).IsUnicode(false);

                entity.Property(e => e.SpBioid).IsUnicode(false);

                entity.Property(e => e.SpFname).IsUnicode(false);

                entity.Property(e => e.SpLname).IsUnicode(false);

                entity.Property(e => e.SpMname).IsUnicode(false);

                entity.Property(e => e.SpObjVerNo).HasPrecision(10);

                entity.Property(e => e.SpStatus).IsUnicode(false);

                entity.Property(e => e.Spbreakdisabled).HasPrecision(1);

                entity.Property(e => e.Spbreakguid).IsUnicode(false);

                entity.Property(e => e.Spbreakobjectversionno).HasPrecision(10);

                entity.Property(e => e.Spbreakoracleentityid).IsUnicode(false);

                entity.Property(e => e.Spbreakoracleentityname).IsUnicode(false);

                entity.Property(e => e.Spbreakpkguid).IsUnicode(false);

                entity.Property(e => e.Spflag).HasPrecision(1);

                entity.Property(e => e.Spid).IsUnicode(false);

                entity.Property(e => e.StatusCode).IsUnicode(false);

                entity.Property(e => e.StatusDesc).IsUnicode(false);

                entity.Property(e => e.StatusEntEntguid).IsUnicode(false);

                entity.Property(e => e.StatusEntObjVerNo).HasPrecision(10);

                entity.Property(e => e.StatusEntStsguid).IsUnicode(false);

                entity.Property(e => e.StatusName).IsUnicode(false);

                entity.Property(e => e.Statusentityguid).IsUnicode(false);
            });

            modelBuilder.Entity<Spclient>(entity =>
            {
                entity.Property(e => e.Branchguid).IsUnicode(false);

                entity.Property(e => e.Clientid).IsUnicode(false);

                entity.Property(e => e.Clientname).IsUnicode(false);

                entity.Property(e => e.Guid).IsUnicode(false);
            });

            modelBuilder.Entity<Spclientmapmaster>(entity =>
            {
                entity.Property(e => e.Branchguid).IsUnicode(false);

                entity.Property(e => e.Clientid).IsUnicode(false);

                entity.Property(e => e.Clientname).IsUnicode(false);

                entity.Property(e => e.Guid).IsUnicode(false);

                entity.Property(e => e.Spclientmapguid).IsUnicode(false);
            });

            modelBuilder.Entity<SpsiteBaseV>(entity =>
            {
                entity.ToView("SPSITE_BASE_V");

                entity.Property(e => e.AddrTypeCode).IsUnicode(false);

                entity.Property(e => e.AddrTypeName).IsUnicode(false);

                entity.Property(e => e.Addressguid).IsUnicode(false);

                entity.Property(e => e.Billsiteuseid).IsUnicode(false);

                entity.Property(e => e.BrandCode).IsUnicode(false);

                entity.Property(e => e.BrandGuid).IsUnicode(false);

                entity.Property(e => e.BrandName).IsUnicode(false);

                entity.Property(e => e.Carmasterguid).IsUnicode(false);

                entity.Property(e => e.CityCode).IsUnicode(false);

                entity.Property(e => e.CityGuid).IsUnicode(false);

                entity.Property(e => e.CityName).IsUnicode(false);

                entity.Property(e => e.CustId).IsUnicode(false);

                entity.Property(e => e.Disabled).HasPrecision(1);

                entity.Property(e => e.Driverflag).HasPrecision(1);

                entity.Property(e => e.Dseflag).HasPrecision(1);

                entity.Property(e => e.EntityCode).IsUnicode(false);

                entity.Property(e => e.FullAddress).IsUnicode(false);

                entity.Property(e => e.GlSegment1).IsUnicode(false);

                entity.Property(e => e.GlSement4).IsUnicode(false);

                entity.Property(e => e.GlSement6).IsUnicode(false);

                entity.Property(e => e.LeCode).IsUnicode(false);

                entity.Property(e => e.LeGuid).IsUnicode(false);

                entity.Property(e => e.LeName).IsUnicode(false);

                entity.Property(e => e.LebranchGuid).IsUnicode(false);

                entity.Property(e => e.Lebranchsecurityguid).IsUnicode(false);

                entity.Property(e => e.ModelCode).IsUnicode(false);

                entity.Property(e => e.ModelGuid).IsUnicode(false);

                entity.Property(e => e.ModelName).IsUnicode(false);

                entity.Property(e => e.Objectversionno).HasPrecision(10);

                entity.Property(e => e.Oracleentityid).IsUnicode(false);

                entity.Property(e => e.Oracleentityname).IsUnicode(false);

                entity.Property(e => e.OrgId).HasPrecision(4);

                entity.Property(e => e.PersStatus).IsUnicode(false);

                entity.Property(e => e.Personguid).IsUnicode(false);

                entity.Property(e => e.Pkguid).IsUnicode(false);

                entity.Property(e => e.SecObjVerNo).HasPrecision(10);

                entity.Property(e => e.Securitycombinationguid).IsUnicode(false);

                entity.Property(e => e.Siteguid).IsUnicode(false);

                entity.Property(e => e.Sitename).IsUnicode(false);

                entity.Property(e => e.SitetypeDescription).IsUnicode(false);

                entity.Property(e => e.SitetypeDisabled).HasPrecision(1);

                entity.Property(e => e.SitetypeName).IsUnicode(false);

                entity.Property(e => e.SitetypeObjectversionno).HasPrecision(3);

                entity.Property(e => e.SitetypeOracleentityid).IsUnicode(false);

                entity.Property(e => e.SitetypeOracleentityname).IsUnicode(false);

                entity.Property(e => e.SitetypePkguid).IsUnicode(false);

                entity.Property(e => e.SitetypeQuickaccesscode).IsUnicode(false);

                entity.Property(e => e.Sitetypemasterguid).IsUnicode(false);

                entity.Property(e => e.SpBioid).IsUnicode(false);

                entity.Property(e => e.SpFname).IsUnicode(false);

                entity.Property(e => e.SpLname).IsUnicode(false);

                entity.Property(e => e.SpMname).IsUnicode(false);

                entity.Property(e => e.SpObjVerNo).HasPrecision(10);

                entity.Property(e => e.SpPkguid).IsUnicode(false);

                entity.Property(e => e.SpStatus).IsUnicode(false);

                entity.Property(e => e.Spflag).HasPrecision(1);

                entity.Property(e => e.Spguid).IsUnicode(false);

                entity.Property(e => e.Spid).IsUnicode(false);

                entity.Property(e => e.StatusCode).IsUnicode(false);

                entity.Property(e => e.StatusDesc).IsUnicode(false);

                entity.Property(e => e.StatusEntEntguid).IsUnicode(false);

                entity.Property(e => e.StatusEntObjVerNo).HasPrecision(10);

                entity.Property(e => e.StatusEntStsguid).IsUnicode(false);

                entity.Property(e => e.StatusName).IsUnicode(false);

                entity.Property(e => e.Statusentityguid).IsUnicode(false);
            });

            modelBuilder.Entity<SpsiteV>(entity =>
            {
                entity.ToView("SPSITE_V");

                entity.Property(e => e.AddrTypeCode).IsUnicode(false);

                entity.Property(e => e.AddrTypeName).IsUnicode(false);

                entity.Property(e => e.Addressguid).IsUnicode(false);

                entity.Property(e => e.Billsiteuseid).IsUnicode(false);

                entity.Property(e => e.BrandCode).IsUnicode(false);

                entity.Property(e => e.BrandGuid).IsUnicode(false);

                entity.Property(e => e.BrandName).IsUnicode(false);

                entity.Property(e => e.Carmasterguid).IsUnicode(false);

                entity.Property(e => e.CityCode).IsUnicode(false);

                entity.Property(e => e.CityGuid).IsUnicode(false);

                entity.Property(e => e.CityName).IsUnicode(false);

                entity.Property(e => e.CustId).IsUnicode(false);

                entity.Property(e => e.Disabled).HasPrecision(1);

                entity.Property(e => e.Driverflag).HasPrecision(1);

                entity.Property(e => e.Dseflag).HasPrecision(1);

                entity.Property(e => e.EntityCode).IsUnicode(false);

                entity.Property(e => e.FullAddress).IsUnicode(false);

                entity.Property(e => e.GlSegment1).IsUnicode(false);

                entity.Property(e => e.GlSement4).IsUnicode(false);

                entity.Property(e => e.GlSement6).IsUnicode(false);

                entity.Property(e => e.LeCode).IsUnicode(false);

                entity.Property(e => e.LeGuid).IsUnicode(false);

                entity.Property(e => e.LeName).IsUnicode(false);

                entity.Property(e => e.LebranchGuid).IsUnicode(false);

                entity.Property(e => e.Lebranchsecurityguid).IsUnicode(false);

                entity.Property(e => e.ModelCode).IsUnicode(false);

                entity.Property(e => e.ModelGuid).IsUnicode(false);

                entity.Property(e => e.ModelName).IsUnicode(false);

                entity.Property(e => e.Objectversionno).HasPrecision(10);

                entity.Property(e => e.Oracleentityid).IsUnicode(false);

                entity.Property(e => e.Oracleentityname).IsUnicode(false);

                entity.Property(e => e.OrgId).HasPrecision(4);

                entity.Property(e => e.PersStatus).IsUnicode(false);

                entity.Property(e => e.Personguid).IsUnicode(false);

                entity.Property(e => e.Pkguid).IsUnicode(false);

                entity.Property(e => e.SecObjVerNo).HasPrecision(10);

                entity.Property(e => e.Securitycombinationguid).IsUnicode(false);

                entity.Property(e => e.Siteguid).IsUnicode(false);

                entity.Property(e => e.Sitename).IsUnicode(false);

                entity.Property(e => e.SitetypeDescription).IsUnicode(false);

                entity.Property(e => e.SitetypeDisabled).HasPrecision(1);

                entity.Property(e => e.SitetypeName).IsUnicode(false);

                entity.Property(e => e.SitetypeObjectversionno).HasPrecision(3);

                entity.Property(e => e.SitetypeOracleentityid).IsUnicode(false);

                entity.Property(e => e.SitetypeOracleentityname).IsUnicode(false);

                entity.Property(e => e.SitetypePkguid).IsUnicode(false);

                entity.Property(e => e.SitetypeQuickaccesscode).IsUnicode(false);

                entity.Property(e => e.Sitetypemasterguid).IsUnicode(false);

                entity.Property(e => e.SpBioid).IsUnicode(false);

                entity.Property(e => e.SpFname).IsUnicode(false);

                entity.Property(e => e.SpLname).IsUnicode(false);

                entity.Property(e => e.SpMname).IsUnicode(false);

                entity.Property(e => e.SpObjVerNo).HasPrecision(10);

                entity.Property(e => e.SpPkguid).IsUnicode(false);

                entity.Property(e => e.SpStatus).IsUnicode(false);

                entity.Property(e => e.Spflag).HasPrecision(1);

                entity.Property(e => e.Spguid).IsUnicode(false);

                entity.Property(e => e.Spid).IsUnicode(false);

                entity.Property(e => e.StatusCode).IsUnicode(false);

                entity.Property(e => e.StatusDesc).IsUnicode(false);

                entity.Property(e => e.StatusEntEntguid).IsUnicode(false);

                entity.Property(e => e.StatusEntObjVerNo).HasPrecision(10);

                entity.Property(e => e.StatusEntStsguid).IsUnicode(false);

                entity.Property(e => e.StatusName).IsUnicode(false);

                entity.Property(e => e.Statusentityguid).IsUnicode(false);
            });

            modelBuilder.Entity<Spsitemaster>(entity =>
            {
                entity.Property(e => e.Addressguid).IsUnicode(false);

                entity.Property(e => e.Billsiteuseid).IsUnicode(false);

                entity.Property(e => e.Carmasterguid).IsUnicode(false);

                entity.Property(e => e.Creditbalancelimit).HasDefaultValueSql("'0'");

                entity.Property(e => e.Creditlimit)
                    .HasPrecision(10)
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Disabled).HasPrecision(1);

                entity.Property(e => e.Guid).IsUnicode(false);

                entity.Property(e => e.Lebranchsecurityguid).IsUnicode(false);

                entity.Property(e => e.Objectversionno).HasPrecision(10);

                entity.Property(e => e.Oracleentityid).IsUnicode(false);

                entity.Property(e => e.Oracleentityname).IsUnicode(false);

                entity.Property(e => e.Pkguid).IsUnicode(false);

                entity.Property(e => e.Securitycombinationguid).IsUnicode(false);

                entity.Property(e => e.Serviceproviderguid).IsUnicode(false);

                entity.Property(e => e.Sitename).IsUnicode(false);

                entity.Property(e => e.Sitetypemasterguid).IsUnicode(false);

                entity.Property(e => e.Sparefieldnumber1).IsUnicode(false);

                entity.Property(e => e.Sparefieldnumber2).IsUnicode(false);

                entity.Property(e => e.Sparefieldnumber3).IsUnicode(false);

                entity.Property(e => e.Sparefieldstring1).IsUnicode(false);

                entity.Property(e => e.Sparefieldstring2).IsUnicode(false);

                entity.Property(e => e.Sparefieldstring3).IsUnicode(false);

                entity.Property(e => e.Statusentityguid).IsUnicode(false);

                entity.Property(e => e.Userarchived).IsUnicode(false);

                entity.Property(e => e.Usercreated).IsUnicode(false);

                entity.Property(e => e.Userdeleted).IsUnicode(false);

                entity.Property(e => e.Userupdated).IsUnicode(false);
            });

            modelBuilder.Entity<Statemaster>(entity =>
            {
                entity.Property(e => e.Comments).IsUnicode(false);

                entity.Property(e => e.Countrymasterguid).IsUnicode(false);

                entity.Property(e => e.Description).IsUnicode(false);

                entity.Property(e => e.Disabled).HasPrecision(1);

                entity.Property(e => e.Gstno)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Guid).IsUnicode(false);

                entity.Property(e => e.Name).IsUnicode(false);

                entity.Property(e => e.Objectversionno).HasPrecision(10);

                entity.Property(e => e.Oracleentityid).IsUnicode(false);

                entity.Property(e => e.Oracleentityname).IsUnicode(false);

                entity.Property(e => e.Pkguid).IsUnicode(false);

                entity.Property(e => e.Quickaccesscode).IsUnicode(false);

                entity.Property(e => e.Userarchived).IsUnicode(false);

                entity.Property(e => e.Usercreated).IsUnicode(false);

                entity.Property(e => e.Userdeleted).IsUnicode(false);

                entity.Property(e => e.Userupdated).IsUnicode(false);
            });

            modelBuilder.Entity<StatementV>(entity =>
            {
                entity.ToView("STATEMENT_V");

                entity.Property(e => e.Comments).IsUnicode(false);

                entity.Property(e => e.QueryPart).IsUnicode(false);

                entity.Property(e => e.Sitename).IsUnicode(false);

                entity.Property(e => e.SpId).IsUnicode(false);

                entity.Property(e => e.SpName).IsUnicode(false);

                entity.Property(e => e.Tripid).IsUnicode(false);

                entity.Property(e => e.TxnNo).IsUnicode(false);

                entity.Property(e => e.TxnType).IsUnicode(false);
            });

            modelBuilder.Entity<StatementarchievV>(entity =>
            {
                entity.ToView("STATEMENTARCHIEV_V");

                entity.Property(e => e.Comments).IsUnicode(false);

                entity.Property(e => e.QueryPart).IsUnicode(false);

                entity.Property(e => e.Sitename).IsUnicode(false);

                entity.Property(e => e.SpId).IsUnicode(false);

                entity.Property(e => e.SpName).IsUnicode(false);

                entity.Property(e => e.Tripid).IsUnicode(false);

                entity.Property(e => e.TxnNo).IsUnicode(false);

                entity.Property(e => e.TxnType).IsUnicode(false);
            });

            modelBuilder.Entity<StatusBaseV>(entity =>
            {
                entity.ToView("STATUS_BASE_V");

                entity.Property(e => e.EntityCode).IsUnicode(false);

                entity.Property(e => e.StatusCode).IsUnicode(false);

                entity.Property(e => e.StatusDesc).IsUnicode(false);

                entity.Property(e => e.StatusEntEntguid).IsUnicode(false);

                entity.Property(e => e.StatusEntGuid).IsUnicode(false);

                entity.Property(e => e.StatusEntObjVerNo).HasPrecision(10);

                entity.Property(e => e.StatusEntStsguid).IsUnicode(false);

                entity.Property(e => e.StatusName).IsUnicode(false);
            });

            modelBuilder.Entity<StatusV>(entity =>
            {
                entity.ToView("STATUS_V");

                entity.Property(e => e.EntityCode).IsUnicode(false);

                entity.Property(e => e.StatusCode).IsUnicode(false);

                entity.Property(e => e.StatusDesc).IsUnicode(false);

                entity.Property(e => e.StatusEntEntguid).IsUnicode(false);

                entity.Property(e => e.StatusEntGuid).IsUnicode(false);

                entity.Property(e => e.StatusEntObjVerNo).HasPrecision(10);

                entity.Property(e => e.StatusEntStsguid).IsUnicode(false);

                entity.Property(e => e.StatusName).IsUnicode(false);
            });

            modelBuilder.Entity<Statusentity>(entity =>
            {
                entity.Property(e => e.Comments).IsUnicode(false);

                entity.Property(e => e.Description).IsUnicode(false);

                entity.Property(e => e.Disabled).HasPrecision(1);

                entity.Property(e => e.Entitymasterguid).IsUnicode(false);

                entity.Property(e => e.Guid).IsUnicode(false);

                entity.Property(e => e.Objectversionno).HasPrecision(10);

                entity.Property(e => e.Oracleentityid).IsUnicode(false);

                entity.Property(e => e.Oracleentityname).IsUnicode(false);

                entity.Property(e => e.Pkguid).IsUnicode(false);

                entity.Property(e => e.Quickaccesscode).IsUnicode(false);

                entity.Property(e => e.Statusmasterguid).IsUnicode(false);

                entity.Property(e => e.Userarchived).IsUnicode(false);

                entity.Property(e => e.Usercreated).IsUnicode(false);

                entity.Property(e => e.Userdeleted).IsUnicode(false);

                entity.Property(e => e.Userupdated).IsUnicode(false);
            });

            modelBuilder.Entity<Statusmaster>(entity =>
            {
                entity.Property(e => e.Comments).IsUnicode(false);

                entity.Property(e => e.Description).IsUnicode(false);

                entity.Property(e => e.Disabled).HasPrecision(1);

                entity.Property(e => e.Guid).IsUnicode(false);

                entity.Property(e => e.Name).IsUnicode(false);

                entity.Property(e => e.Objectversionno).HasPrecision(10);

                entity.Property(e => e.Oracleentityid).IsUnicode(false);

                entity.Property(e => e.Oracleentityname).IsUnicode(false);

                entity.Property(e => e.Pkguid).IsUnicode(false);

                entity.Property(e => e.Quickaccesscode).IsUnicode(false);

                entity.Property(e => e.Statuscolor).IsUnicode(false);

                entity.Property(e => e.Userarchived).IsUnicode(false);

                entity.Property(e => e.Usercreated).IsUnicode(false);

                entity.Property(e => e.Userdeleted).IsUnicode(false);

                entity.Property(e => e.Userupdated).IsUnicode(false);
            });

            modelBuilder.Entity<SubledgerInt>(entity =>
            {
                entity.Property(e => e.Billsiteuseid).IsUnicode(false);

                entity.Property(e => e.CarRegnNo).IsUnicode(false);

                entity.Property(e => e.Carmasterguid).IsUnicode(false);

                entity.Property(e => e.Citycode).IsUnicode(false);

                entity.Property(e => e.Groupid).IsUnicode(false);

                entity.Property(e => e.Securitycombinationguid).IsUnicode(false);

                entity.Property(e => e.Segment1).IsUnicode(false);

                entity.Property(e => e.Segment4).IsUnicode(false);

                entity.Property(e => e.Segment6).IsUnicode(false);

                entity.Property(e => e.Siteguid).IsUnicode(false);

                entity.Property(e => e.Spid).IsUnicode(false);

                entity.Property(e => e.Status).IsUnicode(false);
            });

            modelBuilder.Entity<Symptomsmaster>(entity =>
            {
                entity.Property(e => e.Guid).IsUnicode(false);

                entity.Property(e => e.Issuemasterguid).IsUnicode(false);

                entity.Property(e => e.Objectversionno).HasPrecision(3);

                entity.Property(e => e.Oracleentityid).IsUnicode(false);

                entity.Property(e => e.Oracleentityname).IsUnicode(false);

                entity.Property(e => e.Oracleentitytype).IsUnicode(false);

                entity.Property(e => e.Pkguid).IsUnicode(false);

                entity.Property(e => e.Symptoms).IsUnicode(false);

                entity.Property(e => e.Userarchived).IsUnicode(false);

                entity.Property(e => e.Usercreated).IsUnicode(false);

                entity.Property(e => e.Userdeleted).IsUnicode(false);

                entity.Property(e => e.Userupdated).IsUnicode(false);

                entity.Property(e => e.Workrequestguid).IsUnicode(false);
            });

            modelBuilder.Entity<SymptomsmasterBaseV>(entity =>
            {
                entity.ToView("SYMPTOMSMASTER_BASE_V");

                entity.Property(e => e.Carguid).IsUnicode(false);

                entity.Property(e => e.Defaultsymptoms).IsUnicode(false);

                entity.Property(e => e.EntityCode).IsUnicode(false);

                entity.Property(e => e.Issuemasterguid).IsUnicode(false);

                entity.Property(e => e.Issuename).IsUnicode(false);

                entity.Property(e => e.Issueobjectversionno).HasPrecision(3);

                entity.Property(e => e.Issueoracleentityid).IsUnicode(false);

                entity.Property(e => e.Issueoracleentityname).IsUnicode(false);

                entity.Property(e => e.Issueoracleentitytype).IsUnicode(false);

                entity.Property(e => e.Issuepkguid).IsUnicode(false);

                entity.Property(e => e.Odometerreading).IsUnicode(false);

                entity.Property(e => e.Pkguid).IsUnicode(false);

                entity.Property(e => e.Qcchecklistno).IsUnicode(false);

                entity.Property(e => e.Remarks).IsUnicode(false);

                entity.Property(e => e.Rono).IsUnicode(false);

                entity.Property(e => e.StatusCode).IsUnicode(false);

                entity.Property(e => e.StatusDesc).IsUnicode(false);

                entity.Property(e => e.StatusEntEntguid).IsUnicode(false);

                entity.Property(e => e.StatusEntObjVerNo).HasPrecision(10);

                entity.Property(e => e.StatusEntStsguid).IsUnicode(false);

                entity.Property(e => e.StatusName).IsUnicode(false);

                entity.Property(e => e.Statusentityguid).IsUnicode(false);

                entity.Property(e => e.Symptoms).IsUnicode(false);

                entity.Property(e => e.Symptomsmasterguid).IsUnicode(false);

                entity.Property(e => e.Symptomsobjectversionno).HasPrecision(3);

                entity.Property(e => e.Symptomsoracleentityid).IsUnicode(false);

                entity.Property(e => e.Symptomsoracleentityname).IsUnicode(false);

                entity.Property(e => e.Symptomsoracleentitytype).IsUnicode(false);

                entity.Property(e => e.Symptomspkguid).IsUnicode(false);

                entity.Property(e => e.Workrequestguid).IsUnicode(false);

                entity.Property(e => e.Workrequestno).IsUnicode(false);

                entity.Property(e => e.Workrequestobjectversionno).HasPrecision(3);

                entity.Property(e => e.Workrequestoracleentityid).IsUnicode(false);

                entity.Property(e => e.Workrequestoracleentityname).IsUnicode(false);

                entity.Property(e => e.Workrequestoracleentitytype).IsUnicode(false);

                entity.Property(e => e.Workshopguid).IsUnicode(false);

                entity.Property(e => e.Worktypeguid).IsUnicode(false);
            });

            modelBuilder.Entity<SymptomsmasterV>(entity =>
            {
                entity.ToView("SYMPTOMSMASTER_V");

                entity.Property(e => e.Carguid).IsUnicode(false);

                entity.Property(e => e.Defaultsymptoms).IsUnicode(false);

                entity.Property(e => e.EntityCode).IsUnicode(false);

                entity.Property(e => e.Issuemasterguid).IsUnicode(false);

                entity.Property(e => e.Issuename).IsUnicode(false);

                entity.Property(e => e.Issueobjectversionno).HasPrecision(3);

                entity.Property(e => e.Issueoracleentityid).IsUnicode(false);

                entity.Property(e => e.Issueoracleentityname).IsUnicode(false);

                entity.Property(e => e.Issueoracleentitytype).IsUnicode(false);

                entity.Property(e => e.Issuepkguid).IsUnicode(false);

                entity.Property(e => e.Odometerreading).IsUnicode(false);

                entity.Property(e => e.Pkguid).IsUnicode(false);

                entity.Property(e => e.Qcchecklistno).IsUnicode(false);

                entity.Property(e => e.Remarks).IsUnicode(false);

                entity.Property(e => e.Rono).IsUnicode(false);

                entity.Property(e => e.StatusCode).IsUnicode(false);

                entity.Property(e => e.StatusDesc).IsUnicode(false);

                entity.Property(e => e.StatusEntEntguid).IsUnicode(false);

                entity.Property(e => e.StatusEntObjVerNo).HasPrecision(10);

                entity.Property(e => e.StatusEntStsguid).IsUnicode(false);

                entity.Property(e => e.StatusName).IsUnicode(false);

                entity.Property(e => e.Statusentityguid).IsUnicode(false);

                entity.Property(e => e.Symptoms).IsUnicode(false);

                entity.Property(e => e.Symptomsmasterguid).IsUnicode(false);

                entity.Property(e => e.Symptomsobjectversionno).HasPrecision(3);

                entity.Property(e => e.Symptomsoracleentityid).IsUnicode(false);

                entity.Property(e => e.Symptomsoracleentityname).IsUnicode(false);

                entity.Property(e => e.Symptomsoracleentitytype).IsUnicode(false);

                entity.Property(e => e.Symptomspkguid).IsUnicode(false);

                entity.Property(e => e.Workrequestguid).IsUnicode(false);

                entity.Property(e => e.Workrequestno).IsUnicode(false);

                entity.Property(e => e.Workrequestobjectversionno).HasPrecision(3);

                entity.Property(e => e.Workrequestoracleentityid).IsUnicode(false);

                entity.Property(e => e.Workrequestoracleentityname).IsUnicode(false);

                entity.Property(e => e.Workrequestoracleentitytype).IsUnicode(false);

                entity.Property(e => e.Workshopguid).IsUnicode(false);

                entity.Property(e => e.Worktypeguid).IsUnicode(false);
            });

            modelBuilder.Entity<Systemlocalisation>(entity =>
            {
                entity.Property(e => e.Comments).IsUnicode(false);

                entity.Property(e => e.Culture).IsUnicode(false);

                entity.Property(e => e.Description).IsUnicode(false);

                entity.Property(e => e.Disabled).HasPrecision(1);

                entity.Property(e => e.Guid).IsUnicode(false);

                entity.Property(e => e.Module).IsUnicode(false);

                entity.Property(e => e.Name).IsUnicode(false);

                entity.Property(e => e.Objectversionno).HasPrecision(10);

                entity.Property(e => e.Oracleentityid).IsUnicode(false);

                entity.Property(e => e.Oracleentityname).IsUnicode(false);

                entity.Property(e => e.Pkguid).IsUnicode(false);

                entity.Property(e => e.Quickaccesscode).IsUnicode(false);

                entity.Property(e => e.Userarchived).IsUnicode(false);

                entity.Property(e => e.Usercreated).IsUnicode(false);

                entity.Property(e => e.Userdeleted).IsUnicode(false);

                entity.Property(e => e.Userupdated).IsUnicode(false);

                entity.Property(e => e.Value).IsUnicode(false);
            });

            modelBuilder.Entity<Systemsetting>(entity =>
            {
                entity.Property(e => e.Comments).IsUnicode(false);

                entity.Property(e => e.Datatype).IsUnicode(false);

                entity.Property(e => e.Description).IsUnicode(false);

                entity.Property(e => e.Disabled).HasPrecision(1);

                entity.Property(e => e.Guid).IsUnicode(false);

                entity.Property(e => e.Module).IsUnicode(false);

                entity.Property(e => e.Name).IsUnicode(false);

                entity.Property(e => e.Objectversionno).HasPrecision(10);

                entity.Property(e => e.Oracleentityid).IsUnicode(false);

                entity.Property(e => e.Oracleentityname).IsUnicode(false);

                entity.Property(e => e.Pkguid).IsUnicode(false);

                entity.Property(e => e.Quickaccesscode).IsUnicode(false);

                entity.Property(e => e.Userarchived).IsUnicode(false);

                entity.Property(e => e.Usercreated).IsUnicode(false);

                entity.Property(e => e.Userdeleted).IsUnicode(false);

                entity.Property(e => e.Userupdated).IsUnicode(false);

                entity.Property(e => e.Value).IsUnicode(false);
            });

            modelBuilder.Entity<T>(entity =>
            {
                entity.Property(e => e.Application).IsUnicode(false);

                entity.Property(e => e.DefaultCollation).IsUnicode(false);

                entity.Property(e => e.Duplicated).IsUnicode(false);

                entity.Property(e => e.EditionName).IsUnicode(false);

                entity.Property(e => e.Editionable).IsUnicode(false);

                entity.Property(e => e.Generated).IsUnicode(false);

                entity.Property(e => e.ObjectName).IsUnicode(false);

                entity.Property(e => e.ObjectType).IsUnicode(false);

                entity.Property(e => e.OracleMaintained).IsUnicode(false);

                entity.Property(e => e.Owner).IsUnicode(false);

                entity.Property(e => e.Secondary).IsUnicode(false);

                entity.Property(e => e.Sharded).IsUnicode(false);

                entity.Property(e => e.Sharing).IsUnicode(false);

                entity.Property(e => e.Status).IsUnicode(false);

                entity.Property(e => e.SubobjectName).IsUnicode(false);

                entity.Property(e => e.Temporary).IsUnicode(false);

                entity.Property(e => e.Timestamp).IsUnicode(false);
            });

            modelBuilder.Entity<Tallytaskexecution>(entity =>
            {
                entity.Property(e => e.Guid).IsUnicode(false);

                entity.Property(e => e.Status).IsUnicode(false);

                entity.Property(e => e.Tallydllresponse).IsUnicode(false);
            });

            modelBuilder.Entity<TaxMaster>(entity =>
            {
                entity.Property(e => e.Disable)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Guid).IsUnicode(false);

                entity.Property(e => e.Name).IsUnicode(false);

                entity.Property(e => e.Othercharges)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Quickaccesscode).IsUnicode(false);

                entity.Property(e => e.Securitycombinationguid).IsUnicode(false);

                entity.Property(e => e.Transactiontypeguid).IsUnicode(false);

                entity.Property(e => e.Usercreated).IsUnicode(false);

                entity.Property(e => e.Userupdated).IsUnicode(false);
            });

            modelBuilder.Entity<Tbluser>(entity =>
            {
                entity.Property(e => e.Email).IsUnicode(false);

                entity.Property(e => e.First).IsUnicode(false);

                entity.Property(e => e.Last).IsUnicode(false);

                entity.Property(e => e.UserPassword).IsUnicode(false);

                entity.Property(e => e.Username).IsUnicode(false);
            });

            modelBuilder.Entity<TempBank>(entity =>
            {
                entity.Property(e => e.Bankaccountno).IsUnicode(false);

                entity.Property(e => e.Bankbeneficiaryname).IsUnicode(false);

                entity.Property(e => e.Bankifsccode).IsUnicode(false);

                entity.Property(e => e.Spid).IsUnicode(false);

                entity.Property(e => e.Status)
                    .IsUnicode(false)
                    .HasDefaultValueSql("'PENDING'");
            });

            modelBuilder.Entity<TempDseTxnTbl>(entity =>
            {
                entity.Property(e => e.Amount).IsUnicode(false);

                entity.Property(e => e.SecGuid).IsUnicode(false);

                entity.Property(e => e.Siteguid).IsUnicode(false);

                entity.Property(e => e.Sitename).IsUnicode(false);

                entity.Property(e => e.Spid).IsUnicode(false);

                entity.Property(e => e.Status).IsUnicode(false);

                entity.Property(e => e.TxnGuid).IsUnicode(false);

                entity.Property(e => e.TxnType).IsUnicode(false);
            });

            modelBuilder.Entity<TempEstimatedDriverEarning>(entity =>
            {
                entity.Property(e => e.Bookingtype).IsUnicode(false);

                entity.Property(e => e.Cabno).IsUnicode(false);

                entity.Property(e => e.Channel).IsUnicode(false);

                entity.Property(e => e.Datecreated).HasDefaultValueSql("(SYSDATE)");

                entity.Property(e => e.Dropaddress).IsUnicode(false);

                entity.Property(e => e.Droplocation).IsUnicode(false);

                entity.Property(e => e.Estimatedearning).IsUnicode(false);

                entity.Property(e => e.Isdeleted)
                    .HasPrecision(1)
                    .HasDefaultValueSql("(0)\n");

                entity.Property(e => e.Pickupaddress).IsUnicode(false);

                entity.Property(e => e.Pickuplocation).IsUnicode(false);

                entity.Property(e => e.Requestid).IsUnicode(false);
            });

            modelBuilder.Entity<TempSpSiteBalTrigger>(entity =>
            {
                entity.Property(e => e.Siteguid).IsUnicode(false);
            });

            modelBuilder.Entity<Tempdevice>(entity =>
            {
                entity.Property(e => e.Deviceid).IsUnicode(false);

                entity.Property(e => e.Devicename).IsUnicode(false);

                entity.Property(e => e.Mobileno).IsUnicode(false);

                entity.Property(e => e.Simcardno).IsUnicode(false);
            });

            modelBuilder.Entity<Tempdocmigration>(entity =>
            {
                entity.Property(e => e.Entityidentification).IsUnicode(false);

                entity.Property(e => e.Entitytype).IsUnicode(false);

                entity.Property(e => e.Pragatiidentification).IsUnicode(false);
            });

            modelBuilder.Entity<TemplateExecutionTxn>(entity =>
            {
                entity.Property(e => e.Spsiteguid).IsUnicode(false);

                entity.Property(e => e.TemplateExecutionId).IsUnicode(false);

                entity.Property(e => e.TxnDate).IsUnicode(false);

                entity.Property(e => e.TxnTypeGuid).IsUnicode(false);
            });

            modelBuilder.Entity<TemplateTxnV>(entity =>
            {
                entity.ToView("TEMPLATE_TXN_V");

                entity.Property(e => e.Sitename).IsUnicode(false);

                entity.Property(e => e.Spid).IsUnicode(false);

                entity.Property(e => e.Spname).IsUnicode(false);

                entity.Property(e => e.Spsiteguid).IsUnicode(false);

                entity.Property(e => e.TemplateExecutionId).IsUnicode(false);

                entity.Property(e => e.Templatename).IsUnicode(false);

                entity.Property(e => e.TransactiontypeQcode).IsUnicode(false);

                entity.Property(e => e.TxnDate).IsUnicode(false);

                entity.Property(e => e.TxnTypeGuid).IsUnicode(false);

                entity.Property(e => e.Typename).IsUnicode(false);
            });

            modelBuilder.Entity<Templateexecution>(entity =>
            {
                entity.Property(e => e.Guid).IsUnicode(false);

                entity.Property(e => e.Objectversionno).HasPrecision(3);

                entity.Property(e => e.Oracleentityid).IsUnicode(false);

                entity.Property(e => e.Oracleentityname).IsUnicode(false);

                entity.Property(e => e.Parametertextfield1).IsUnicode(false);

                entity.Property(e => e.Parametertextfield10).IsUnicode(false);

                entity.Property(e => e.Parametertextfield2).IsUnicode(false);

                entity.Property(e => e.Parametertextfield3).IsUnicode(false);

                entity.Property(e => e.Parametertextfield4).IsUnicode(false);

                entity.Property(e => e.Parametertextfield5).IsUnicode(false);

                entity.Property(e => e.Parametertextfield6).IsUnicode(false);

                entity.Property(e => e.Parametertextfield7).IsUnicode(false);

                entity.Property(e => e.Parametertextfield8).IsUnicode(false);

                entity.Property(e => e.Parametertextfield9).IsUnicode(false);

                entity.Property(e => e.Pkguid).IsUnicode(false);

                entity.Property(e => e.Searchtemplatemasterguid).IsUnicode(false);

                entity.Property(e => e.Securitycombinationguid).IsUnicode(false);

                entity.Property(e => e.Statusentityguid).IsUnicode(false);

                entity.Property(e => e.Templateexecutionmessage).IsUnicode(false);

                entity.Property(e => e.Templateexecutionresult).IsUnicode(false);

                entity.Property(e => e.Userarchived).IsUnicode(false);

                entity.Property(e => e.Usercreated).IsUnicode(false);

                entity.Property(e => e.Userdeleted).IsUnicode(false);

                entity.Property(e => e.Userrole).IsUnicode(false);

                entity.Property(e => e.Userupdated).IsUnicode(false);

                entity.Property(e => e.WfUrl).IsUnicode(false);
            });

            modelBuilder.Entity<TemplateexecutionV>(entity =>
            {
                entity.ToView("TEMPLATEEXECUTION_V");

                entity.Property(e => e.LebranchGuid).IsUnicode(false);

                entity.Property(e => e.Searchtemplatemasterguid).IsUnicode(false);

                entity.Property(e => e.SecQuickaccesscode).IsUnicode(false);

                entity.Property(e => e.Securitycombinationguid).IsUnicode(false);

                entity.Property(e => e.Templateexecutionmessage).IsUnicode(false);

                entity.Property(e => e.Templateexecutionresult).IsUnicode(false);

                entity.Property(e => e.Templateexecutionsguid).IsUnicode(false);

                entity.Property(e => e.Templatename).IsUnicode(false);
            });

            modelBuilder.Entity<TemplateexecutiondetailV>(entity =>
            {
                entity.ToView("TEMPLATEEXECUTIONDETAIL_V");

                entity.Property(e => e.Approvalenabled).IsUnicode(false);

                entity.Property(e => e.BrandCode).IsUnicode(false);

                entity.Property(e => e.BrandGuid).IsUnicode(false);

                entity.Property(e => e.BrandName).IsUnicode(false);

                entity.Property(e => e.CityCode).IsUnicode(false);

                entity.Property(e => e.CityGuid).IsUnicode(false);

                entity.Property(e => e.CityName).IsUnicode(false);

                entity.Property(e => e.GlSegment1).IsUnicode(false);

                entity.Property(e => e.GlSement4).IsUnicode(false);

                entity.Property(e => e.GlSement6).IsUnicode(false);

                entity.Property(e => e.LeCode).IsUnicode(false);

                entity.Property(e => e.LeGuid).IsUnicode(false);

                entity.Property(e => e.LeName).IsUnicode(false);

                entity.Property(e => e.LebranchGuid).IsUnicode(false);

                entity.Property(e => e.ModelCode).IsUnicode(false);

                entity.Property(e => e.ModelGuid).IsUnicode(false);

                entity.Property(e => e.ModelName).IsUnicode(false);

                entity.Property(e => e.OrgId).HasPrecision(4);

                entity.Property(e => e.Searchstatusentityguid).IsUnicode(false);

                entity.Property(e => e.Searchtemplatemasterguid).IsUnicode(false);

                entity.Property(e => e.Searchtemplatemasterpkguid).IsUnicode(false);

                entity.Property(e => e.SecObjVerNo).HasPrecision(10);

                entity.Property(e => e.Securitycombinationguid).IsUnicode(false);

                entity.Property(e => e.Summaryviewname).IsUnicode(false);

                entity.Property(e => e.Summaryviewtext).IsUnicode(false);

                entity.Property(e => e.TemplateEntityCode).IsUnicode(false);

                entity.Property(e => e.TemplateStatusCode).IsUnicode(false);

                entity.Property(e => e.TemplateStatusDesc).IsUnicode(false);

                entity.Property(e => e.TemplateStatusEntEntguid).IsUnicode(false);

                entity.Property(e => e.TemplateStatusEntObjVerNo).HasPrecision(10);

                entity.Property(e => e.TemplateStatusEntStsguid).IsUnicode(false);

                entity.Property(e => e.TemplateStatusName).IsUnicode(false);

                entity.Property(e => e.TemplateStatusentityguid).IsUnicode(false);

                entity.Property(e => e.Templatedescription).IsUnicode(false);

                entity.Property(e => e.Templateexecutionmessage).IsUnicode(false);

                entity.Property(e => e.Templateexecutionresult).IsUnicode(false);

                entity.Property(e => e.Templateexecutionsguid).IsUnicode(false);

                entity.Property(e => e.Templateexecutionspkguid).IsUnicode(false);

                entity.Property(e => e.Templatename).IsUnicode(false);

                entity.Property(e => e.Templatetransactiontypeid).IsUnicode(false);

                entity.Property(e => e.Templatetype).IsUnicode(false);

                entity.Property(e => e.Transactionresultformula).IsUnicode(false);

                entity.Property(e => e.Userrole).IsUnicode(false);

                entity.Property(e => e.Viewname).IsUnicode(false);

                entity.Property(e => e.Viewtext).IsUnicode(false);

                entity.Property(e => e.WfUrl).IsUnicode(false);
            });

            modelBuilder.Entity<Templateparameter>(entity =>
            {
                entity.Property(e => e.Displayname).IsUnicode(false);

                entity.Property(e => e.Guid).IsUnicode(false);

                entity.Property(e => e.Templatemasterguid).IsUnicode(false);
            });

            modelBuilder.Entity<Templatequerycorelatedcol>(entity =>
            {
                entity.Property(e => e.Guid).IsUnicode(false);

                entity.Property(e => e.Objectversionno).HasPrecision(3);

                entity.Property(e => e.Oracleentityid).IsUnicode(false);

                entity.Property(e => e.Oracleentityname).IsUnicode(false);

                entity.Property(e => e.Pkguid).IsUnicode(false);

                entity.Property(e => e.Userarchived).IsUnicode(false);

                entity.Property(e => e.Usercreated).IsUnicode(false);

                entity.Property(e => e.Userdeleted).IsUnicode(false);

                entity.Property(e => e.Userupdated).IsUnicode(false);
            });

            modelBuilder.Entity<Templatequerycorrelatedcolumn>(entity =>
            {
                entity.Property(e => e.Mainqueryentitycolumnid).IsUnicode(false);

                entity.Property(e => e.Mainquerytemplateentityid).IsUnicode(false);

                entity.Property(e => e.Querycorrelationid).IsUnicode(false);

                entity.Property(e => e.Subqueryentitycolumnid).IsUnicode(false);

                entity.Property(e => e.Subquerytemplateentityid).IsUnicode(false);

                entity.Property(e => e.Templatemainqueryid).IsUnicode(false);

                entity.Property(e => e.Templatesubqueryid).IsUnicode(false);
            });

            modelBuilder.Entity<TemporaryTable>(entity =>
            {
                entity.Property(e => e.Id).HasPrecision(1);
            });

            modelBuilder.Entity<Temppragatimanthanlocksync>(entity =>
            {
                entity.Property(e => e.CabNo).IsUnicode(false);

                entity.Property(e => e.Datecreated).HasDefaultValueSql("sysdate ");

                entity.Property(e => e.Lockaction).IsUnicode(false);

                entity.Property(e => e.Status).HasDefaultValueSql("0 ");
            });

            modelBuilder.Entity<Temppragatimanthanlocksync1>(entity =>
            {
                entity.Property(e => e.CabNo).IsUnicode(false);

                entity.Property(e => e.Datecreated).HasDefaultValueSql("sysdate");

                entity.Property(e => e.Lockaction).IsUnicode(false);

                entity.Property(e => e.Status).HasDefaultValueSql("0");
            });

            modelBuilder.Entity<Test1>(entity =>
            {
                entity.Property(e => e.Name).IsUnicode(false);
            });

            modelBuilder.Entity<Testtable>(entity =>
            {
                entity.Property(e => e.Testname).IsUnicode(false);

                entity.Property(e => e.Value).IsUnicode(false);
            });

            modelBuilder.Entity<Trainerdetail>(entity =>
            {
                entity.Property(e => e.Comments).IsUnicode(false);

                entity.Property(e => e.Description).IsUnicode(false);

                entity.Property(e => e.Disabled).HasPrecision(1);

                entity.Property(e => e.Guid)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Name).IsUnicode(false);

                entity.Property(e => e.Oracleentityid)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Oracleentityname)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Pkguid).IsUnicode(false);

                entity.Property(e => e.Quickaccesscode).IsUnicode(false);

                entity.Property(e => e.Userarchived)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Usercreated)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Userdeleted)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Userupdated)
                    .IsUnicode(false)
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<Trainermaster>(entity =>
            {
                entity.Property(e => e.Disabled).HasPrecision(1);

                entity.Property(e => e.Guid).IsUnicode(false);

                entity.Property(e => e.Objectversionno).HasPrecision(10);

                entity.Property(e => e.Oracleentityid).IsUnicode(false);

                entity.Property(e => e.Oracleentityname).IsUnicode(false);

                entity.Property(e => e.Pkguid).IsUnicode(false);

                entity.Property(e => e.Statusentityguid).IsUnicode(false);

                entity.Property(e => e.Userarchived).IsUnicode(false);

                entity.Property(e => e.Usercreated).IsUnicode(false);

                entity.Property(e => e.Userdeleted).IsUnicode(false);

                entity.Property(e => e.Usermasterguid).IsUnicode(false);

                entity.Property(e => e.Userupdated).IsUnicode(false);
            });

            modelBuilder.Entity<TrainingBatchBaseV>(entity =>
            {
                entity.ToView("TRAINING_BATCH_BASE_V");

                entity.Property(e => e.Attendeetype).IsUnicode(false);

                entity.Property(e => e.Disabled).HasPrecision(1);

                entity.Property(e => e.EntityCode).IsUnicode(false);

                entity.Property(e => e.Isattended)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Objectversionno).HasPrecision(10);

                entity.Property(e => e.Oracleentityid).IsUnicode(false);

                entity.Property(e => e.Oracleentityname).IsUnicode(false);

                entity.Property(e => e.Pkguid).IsUnicode(false);

                entity.Property(e => e.Remarks).IsUnicode(false);

                entity.Property(e => e.StatusCode).IsUnicode(false);

                entity.Property(e => e.StatusDesc).IsUnicode(false);

                entity.Property(e => e.StatusEntEntguid).IsUnicode(false);

                entity.Property(e => e.StatusEntObjVerNo).HasPrecision(10);

                entity.Property(e => e.StatusEntStsguid).IsUnicode(false);

                entity.Property(e => e.StatusName).IsUnicode(false);

                entity.Property(e => e.Statusentityguid).IsUnicode(false);

                entity.Property(e => e.Trainerdisabled).HasPrecision(1);

                entity.Property(e => e.Trainermasterguid).IsUnicode(false);

                entity.Property(e => e.Trainerobjectversionno).HasPrecision(10);

                entity.Property(e => e.Traineroracleentityid).IsUnicode(false);

                entity.Property(e => e.Traineroracleentityname).IsUnicode(false);

                entity.Property(e => e.Trainerpkguid).IsUnicode(false);

                entity.Property(e => e.Trainerstatusentityguid)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.TrainingMagEmpNum)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.TrainingMagFullName).IsUnicode(false);

                entity.Property(e => e.TrainingMagId).IsUnicode(false);

                entity.Property(e => e.TrainingMagJobId)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.TrainingMagJobName).IsUnicode(false);

                entity.Property(e => e.TrainingMagNpwNum)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.TrainingMagOrgId)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.TrainingMagPerId)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.TrainingMagPerType)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.TrainingMagPositionId)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.TrainingMagPositionName).IsUnicode(false);

                entity.Property(e => e.Trainingbatchmasterguid).IsUnicode(false);

                entity.Property(e => e.Trainingname).IsUnicode(false);

                entity.Property(e => e.Trainingresult).IsUnicode(false);

                entity.Property(e => e.Trainingtopic).IsUnicode(false);

                entity.Property(e => e.Trainingtypecomments).IsUnicode(false);

                entity.Property(e => e.Trainingtypedescription).IsUnicode(false);

                entity.Property(e => e.Trainingtypedisabled).HasPrecision(1);

                entity.Property(e => e.Trainingtypemasterguid).IsUnicode(false);

                entity.Property(e => e.Trainingtypename).IsUnicode(false);

                entity.Property(e => e.Trainingtypeobjectversionno).HasPrecision(10);

                entity.Property(e => e.Trainingtypeoracleentityid).IsUnicode(false);

                entity.Property(e => e.Trainingtypeoracleentityname).IsUnicode(false);

                entity.Property(e => e.Trainingtypepkguid).IsUnicode(false);

                entity.Property(e => e.Trainingtypequickaccesscode).IsUnicode(false);
            });

            modelBuilder.Entity<TrainingBatchV>(entity =>
            {
                entity.ToView("TRAINING_BATCH_V");

                entity.Property(e => e.Attendeetype).IsUnicode(false);

                entity.Property(e => e.Disabled).HasPrecision(1);

                entity.Property(e => e.EntityCode).IsUnicode(false);

                entity.Property(e => e.Isattended)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Objectversionno).HasPrecision(10);

                entity.Property(e => e.Oracleentityid).IsUnicode(false);

                entity.Property(e => e.Oracleentityname).IsUnicode(false);

                entity.Property(e => e.Pkguid).IsUnicode(false);

                entity.Property(e => e.Remarks).IsUnicode(false);

                entity.Property(e => e.StatusCode).IsUnicode(false);

                entity.Property(e => e.StatusDesc).IsUnicode(false);

                entity.Property(e => e.StatusEntEntguid).IsUnicode(false);

                entity.Property(e => e.StatusEntObjVerNo).HasPrecision(10);

                entity.Property(e => e.StatusEntStsguid).IsUnicode(false);

                entity.Property(e => e.StatusName).IsUnicode(false);

                entity.Property(e => e.Statusentityguid).IsUnicode(false);

                entity.Property(e => e.Trainerdisabled).HasPrecision(1);

                entity.Property(e => e.Trainermasterguid).IsUnicode(false);

                entity.Property(e => e.Trainerobjectversionno).HasPrecision(10);

                entity.Property(e => e.Traineroracleentityid).IsUnicode(false);

                entity.Property(e => e.Traineroracleentityname).IsUnicode(false);

                entity.Property(e => e.Trainerpkguid).IsUnicode(false);

                entity.Property(e => e.Trainerstatusentityguid)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.TrainingMagEmpNum)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.TrainingMagFullName).IsUnicode(false);

                entity.Property(e => e.TrainingMagId).IsUnicode(false);

                entity.Property(e => e.TrainingMagJobId)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.TrainingMagJobName).IsUnicode(false);

                entity.Property(e => e.TrainingMagNpwNum)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.TrainingMagOrgId)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.TrainingMagPerId)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.TrainingMagPerType)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.TrainingMagPositionId)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.TrainingMagPositionName).IsUnicode(false);

                entity.Property(e => e.Trainingbatchmasterguid).IsUnicode(false);

                entity.Property(e => e.Trainingname).IsUnicode(false);

                entity.Property(e => e.Trainingresult).IsUnicode(false);

                entity.Property(e => e.Trainingtopic).IsUnicode(false);

                entity.Property(e => e.Trainingtypecomments).IsUnicode(false);

                entity.Property(e => e.Trainingtypedescription).IsUnicode(false);

                entity.Property(e => e.Trainingtypedisabled).HasPrecision(1);

                entity.Property(e => e.Trainingtypemasterguid).IsUnicode(false);

                entity.Property(e => e.Trainingtypename).IsUnicode(false);

                entity.Property(e => e.Trainingtypeobjectversionno).HasPrecision(10);

                entity.Property(e => e.Trainingtypeoracleentityid).IsUnicode(false);

                entity.Property(e => e.Trainingtypeoracleentityname).IsUnicode(false);

                entity.Property(e => e.Trainingtypepkguid).IsUnicode(false);

                entity.Property(e => e.Trainingtypequickaccesscode).IsUnicode(false);
            });

            modelBuilder.Entity<TrainingManagerV>(entity =>
            {
                entity.ToView("TRAINING_MANAGER_V");

                entity.Property(e => e.EmployeeNumber)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.FullName).IsUnicode(false);

                entity.Property(e => e.Id)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.JobId)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.JobName)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.NpwNumber)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.OrganizationId)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.PersonType)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.PositionId)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.PositionName)
                    .IsUnicode(false)
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<TrainingPersonBaseV>(entity =>
            {
                entity.ToView("TRAINING_PERSON_BASE_V");

                entity.Property(e => e.Attendeetype).IsUnicode(false);

                entity.Property(e => e.Attendeobjectversionno).HasPrecision(10);

                entity.Property(e => e.Attendeoracleentityid).IsUnicode(false);

                entity.Property(e => e.Attendeoracleentityname).IsUnicode(false);

                entity.Property(e => e.Batchdisabled).HasPrecision(1);

                entity.Property(e => e.Batchobjectversionno).HasPrecision(10);

                entity.Property(e => e.Batchoracleentityid).IsUnicode(false);

                entity.Property(e => e.Batchoracleentityname).IsUnicode(false);

                entity.Property(e => e.Batchpkguid).IsUnicode(false);

                entity.Property(e => e.EntityCode).IsUnicode(false);

                entity.Property(e => e.Isattended).IsUnicode(false);

                entity.Property(e => e.Obtainedmarks).IsUnicode(false);

                entity.Property(e => e.PersBioid).IsUnicode(false);

                entity.Property(e => e.PersDriverflag).HasPrecision(1);

                entity.Property(e => e.PersDseflag).HasPrecision(1);

                entity.Property(e => e.PersFname).IsUnicode(false);

                entity.Property(e => e.PersGender).IsUnicode(false);

                entity.Property(e => e.PersLname).IsUnicode(false);

                entity.Property(e => e.PersMname).IsUnicode(false);

                entity.Property(e => e.PersObjVerNo).HasPrecision(10);

                entity.Property(e => e.PersSpflag).HasPrecision(1);

                entity.Property(e => e.PersStatusCode).IsUnicode(false);

                entity.Property(e => e.PersTitle).IsUnicode(false);

                entity.Property(e => e.Personid).IsUnicode(false);

                entity.Property(e => e.Personmasterguid).IsUnicode(false);

                entity.Property(e => e.Remarks).IsUnicode(false);

                entity.Property(e => e.StatusCode).IsUnicode(false);

                entity.Property(e => e.StatusDesc).IsUnicode(false);

                entity.Property(e => e.StatusEntEntguid).IsUnicode(false);

                entity.Property(e => e.StatusEntObjVerNo).HasPrecision(10);

                entity.Property(e => e.StatusEntStsguid).IsUnicode(false);

                entity.Property(e => e.StatusName).IsUnicode(false);

                entity.Property(e => e.Trainerdisabled).HasPrecision(1);

                entity.Property(e => e.Trainermasterguid).IsUnicode(false);

                entity.Property(e => e.Trainerobjectversionno).HasPrecision(10);

                entity.Property(e => e.Traineroracleentityid).IsUnicode(false);

                entity.Property(e => e.Traineroracleentityname).IsUnicode(false);

                entity.Property(e => e.Trainerpkguid).IsUnicode(false);

                entity.Property(e => e.Trainerstatusentityguid)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.TrainingMagEmpNum)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.TrainingMagFullName).IsUnicode(false);

                entity.Property(e => e.TrainingMagId).IsUnicode(false);

                entity.Property(e => e.TrainingMagJobId)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.TrainingMagJobName).IsUnicode(false);

                entity.Property(e => e.TrainingMagNpwNum)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.TrainingMagOrgId)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.TrainingMagPerId)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.TrainingMagPerType)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.TrainingMagPositionId)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.TrainingMagPositionName).IsUnicode(false);

                entity.Property(e => e.Trainingattendeeguid).IsUnicode(false);

                entity.Property(e => e.Trainingattendeepkguid).IsUnicode(false);

                entity.Property(e => e.Trainingbatchmasterguid).IsUnicode(false);

                entity.Property(e => e.Trainingname).IsUnicode(false);

                entity.Property(e => e.Trainingresult).IsUnicode(false);

                entity.Property(e => e.Trainingstatusentityguid).IsUnicode(false);

                entity.Property(e => e.Trainingtopic).IsUnicode(false);

                entity.Property(e => e.Trainingtypecomments).IsUnicode(false);

                entity.Property(e => e.Trainingtypedescription).IsUnicode(false);

                entity.Property(e => e.Trainingtypedisabled).HasPrecision(1);

                entity.Property(e => e.Trainingtypemasterguid).IsUnicode(false);

                entity.Property(e => e.Trainingtypename).IsUnicode(false);

                entity.Property(e => e.Trainingtypeobjectversionno).HasPrecision(10);

                entity.Property(e => e.Trainingtypeoracleentityid).IsUnicode(false);

                entity.Property(e => e.Trainingtypeoracleentityname).IsUnicode(false);

                entity.Property(e => e.Trainingtypepkguid).IsUnicode(false);

                entity.Property(e => e.Trainingtypequickaccesscode).IsUnicode(false);
            });

            modelBuilder.Entity<TrainingPersonV>(entity =>
            {
                entity.ToView("TRAINING_PERSON_V");

                entity.Property(e => e.Attendeetype).IsUnicode(false);

                entity.Property(e => e.Attendeobjectversionno).HasPrecision(10);

                entity.Property(e => e.Attendeoracleentityid).IsUnicode(false);

                entity.Property(e => e.Attendeoracleentityname).IsUnicode(false);

                entity.Property(e => e.Batchdisabled).HasPrecision(1);

                entity.Property(e => e.Batchobjectversionno).HasPrecision(10);

                entity.Property(e => e.Batchoracleentityid).IsUnicode(false);

                entity.Property(e => e.Batchoracleentityname).IsUnicode(false);

                entity.Property(e => e.Batchpkguid).IsUnicode(false);

                entity.Property(e => e.EntityCode).IsUnicode(false);

                entity.Property(e => e.Isattended).IsUnicode(false);

                entity.Property(e => e.Obtainedmarks).IsUnicode(false);

                entity.Property(e => e.PersBioid).IsUnicode(false);

                entity.Property(e => e.PersDriverflag).HasPrecision(1);

                entity.Property(e => e.PersDseflag).HasPrecision(1);

                entity.Property(e => e.PersFname).IsUnicode(false);

                entity.Property(e => e.PersGender).IsUnicode(false);

                entity.Property(e => e.PersLname).IsUnicode(false);

                entity.Property(e => e.PersMname).IsUnicode(false);

                entity.Property(e => e.PersObjVerNo).HasPrecision(10);

                entity.Property(e => e.PersSpflag).HasPrecision(1);

                entity.Property(e => e.PersStatusCode).IsUnicode(false);

                entity.Property(e => e.PersTitle).IsUnicode(false);

                entity.Property(e => e.Personid).IsUnicode(false);

                entity.Property(e => e.Personmasterguid).IsUnicode(false);

                entity.Property(e => e.Remarks).IsUnicode(false);

                entity.Property(e => e.StatusCode).IsUnicode(false);

                entity.Property(e => e.StatusDesc).IsUnicode(false);

                entity.Property(e => e.StatusEntEntguid).IsUnicode(false);

                entity.Property(e => e.StatusEntObjVerNo).HasPrecision(10);

                entity.Property(e => e.StatusEntStsguid).IsUnicode(false);

                entity.Property(e => e.StatusName).IsUnicode(false);

                entity.Property(e => e.Trainerdisabled).HasPrecision(1);

                entity.Property(e => e.Trainermasterguid).IsUnicode(false);

                entity.Property(e => e.Trainerobjectversionno).HasPrecision(10);

                entity.Property(e => e.Traineroracleentityid).IsUnicode(false);

                entity.Property(e => e.Traineroracleentityname).IsUnicode(false);

                entity.Property(e => e.Trainerpkguid).IsUnicode(false);

                entity.Property(e => e.Trainerstatusentityguid)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.TrainingMagEmpNum)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.TrainingMagFullName).IsUnicode(false);

                entity.Property(e => e.TrainingMagId).IsUnicode(false);

                entity.Property(e => e.TrainingMagJobId)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.TrainingMagJobName).IsUnicode(false);

                entity.Property(e => e.TrainingMagNpwNum)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.TrainingMagOrgId)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.TrainingMagPerId)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.TrainingMagPerType)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.TrainingMagPositionId)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.TrainingMagPositionName).IsUnicode(false);

                entity.Property(e => e.Trainingattendeeguid).IsUnicode(false);

                entity.Property(e => e.Trainingattendeepkguid).IsUnicode(false);

                entity.Property(e => e.Trainingbatchmasterguid).IsUnicode(false);

                entity.Property(e => e.Trainingname).IsUnicode(false);

                entity.Property(e => e.Trainingresult).IsUnicode(false);

                entity.Property(e => e.Trainingstatusentityguid).IsUnicode(false);

                entity.Property(e => e.Trainingtopic).IsUnicode(false);

                entity.Property(e => e.Trainingtypecomments).IsUnicode(false);

                entity.Property(e => e.Trainingtypedescription).IsUnicode(false);

                entity.Property(e => e.Trainingtypedisabled).HasPrecision(1);

                entity.Property(e => e.Trainingtypemasterguid).IsUnicode(false);

                entity.Property(e => e.Trainingtypename).IsUnicode(false);

                entity.Property(e => e.Trainingtypeobjectversionno).HasPrecision(10);

                entity.Property(e => e.Trainingtypeoracleentityid).IsUnicode(false);

                entity.Property(e => e.Trainingtypeoracleentityname).IsUnicode(false);

                entity.Property(e => e.Trainingtypepkguid).IsUnicode(false);

                entity.Property(e => e.Trainingtypequickaccesscode).IsUnicode(false);
            });

            modelBuilder.Entity<TrainingPersonphoneV>(entity =>
            {
                entity.ToView("TRAINING_PERSONPHONE_V");

                entity.Property(e => e.Attendeetype).IsUnicode(false);

                entity.Property(e => e.Attendeobjectversionno).HasPrecision(10);

                entity.Property(e => e.Attendeoracleentityid).IsUnicode(false);

                entity.Property(e => e.Attendeoracleentityname).IsUnicode(false);

                entity.Property(e => e.Batchdisabled).HasPrecision(1);

                entity.Property(e => e.Batchobjectversionno).HasPrecision(10);

                entity.Property(e => e.Batchoracleentityid).IsUnicode(false);

                entity.Property(e => e.Batchoracleentityname).IsUnicode(false);

                entity.Property(e => e.Batchpkguid).IsUnicode(false);

                entity.Property(e => e.EntityCode).IsUnicode(false);

                entity.Property(e => e.Isattended).IsUnicode(false);

                entity.Property(e => e.Obtainedmarks).IsUnicode(false);

                entity.Property(e => e.PerPhone).IsUnicode(false);

                entity.Property(e => e.PersBioid).IsUnicode(false);

                entity.Property(e => e.PersDriverflag).HasPrecision(1);

                entity.Property(e => e.PersDseflag).HasPrecision(1);

                entity.Property(e => e.PersFname).IsUnicode(false);

                entity.Property(e => e.PersGender).IsUnicode(false);

                entity.Property(e => e.PersLname).IsUnicode(false);

                entity.Property(e => e.PersMname).IsUnicode(false);

                entity.Property(e => e.PersObjVerNo).HasPrecision(10);

                entity.Property(e => e.PersSpflag).HasPrecision(1);

                entity.Property(e => e.PersStatusCode).IsUnicode(false);

                entity.Property(e => e.PersTitle).IsUnicode(false);

                entity.Property(e => e.Personid).IsUnicode(false);

                entity.Property(e => e.Personmasterguid).IsUnicode(false);

                entity.Property(e => e.Remarks).IsUnicode(false);

                entity.Property(e => e.StatusCode).IsUnicode(false);

                entity.Property(e => e.StatusDesc).IsUnicode(false);

                entity.Property(e => e.StatusEntEntguid).IsUnicode(false);

                entity.Property(e => e.StatusEntObjVerNo).HasPrecision(10);

                entity.Property(e => e.StatusEntStsguid).IsUnicode(false);

                entity.Property(e => e.StatusName).IsUnicode(false);

                entity.Property(e => e.Trainerdisabled).HasPrecision(1);

                entity.Property(e => e.Trainermasterguid).IsUnicode(false);

                entity.Property(e => e.Trainerobjectversionno).HasPrecision(10);

                entity.Property(e => e.Traineroracleentityid).IsUnicode(false);

                entity.Property(e => e.Traineroracleentityname).IsUnicode(false);

                entity.Property(e => e.Trainerpkguid).IsUnicode(false);

                entity.Property(e => e.Trainerstatusentityguid)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.TrainingMagEmpNum)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.TrainingMagFullName).IsUnicode(false);

                entity.Property(e => e.TrainingMagId).IsUnicode(false);

                entity.Property(e => e.TrainingMagJobId)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.TrainingMagJobName).IsUnicode(false);

                entity.Property(e => e.TrainingMagNpwNum)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.TrainingMagOrgId)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.TrainingMagPerId)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.TrainingMagPerType)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.TrainingMagPositionId)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.TrainingMagPositionName).IsUnicode(false);

                entity.Property(e => e.Trainingattendeeguid).IsUnicode(false);

                entity.Property(e => e.Trainingattendeepkguid).IsUnicode(false);

                entity.Property(e => e.Trainingbatchmasterguid).IsUnicode(false);

                entity.Property(e => e.Trainingname).IsUnicode(false);

                entity.Property(e => e.Trainingresult).IsUnicode(false);

                entity.Property(e => e.Trainingstatusentityguid).IsUnicode(false);

                entity.Property(e => e.Trainingtopic).IsUnicode(false);

                entity.Property(e => e.Trainingtypecomments).IsUnicode(false);

                entity.Property(e => e.Trainingtypedescription).IsUnicode(false);

                entity.Property(e => e.Trainingtypedisabled).HasPrecision(1);

                entity.Property(e => e.Trainingtypemasterguid).IsUnicode(false);

                entity.Property(e => e.Trainingtypename).IsUnicode(false);

                entity.Property(e => e.Trainingtypeobjectversionno).HasPrecision(10);

                entity.Property(e => e.Trainingtypeoracleentityid).IsUnicode(false);

                entity.Property(e => e.Trainingtypeoracleentityname).IsUnicode(false);

                entity.Property(e => e.Trainingtypepkguid).IsUnicode(false);

                entity.Property(e => e.Trainingtypequickaccesscode).IsUnicode(false);
            });

            modelBuilder.Entity<Trainingattendee>(entity =>
            {
                entity.Property(e => e.Guid).IsUnicode(false);

                entity.Property(e => e.Isattended).IsUnicode(false);

                entity.Property(e => e.Objectversionno).HasPrecision(10);

                entity.Property(e => e.Obtainedmarks).IsUnicode(false);

                entity.Property(e => e.Oracleentityid).IsUnicode(false);

                entity.Property(e => e.Oracleentityname).IsUnicode(false);

                entity.Property(e => e.Personmasterguid).IsUnicode(false);

                entity.Property(e => e.Pkguid).IsUnicode(false);

                entity.Property(e => e.Remarks).IsUnicode(false);

                entity.Property(e => e.Trainingbatchmasterguid).IsUnicode(false);

                entity.Property(e => e.Trainingresult).IsUnicode(false);

                entity.Property(e => e.Userarchived).IsUnicode(false);

                entity.Property(e => e.Usercreated).IsUnicode(false);

                entity.Property(e => e.Userdeleted).IsUnicode(false);

                entity.Property(e => e.Userupdated).IsUnicode(false);
            });

            modelBuilder.Entity<Trainingbatchmaster>(entity =>
            {
                entity.Property(e => e.Attendeetype).IsUnicode(false);

                entity.Property(e => e.Disabled).HasPrecision(1);

                entity.Property(e => e.Guid).IsUnicode(false);

                entity.Property(e => e.Isattended)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Location).IsUnicode(false);

                entity.Property(e => e.Objectversionno).HasPrecision(10);

                entity.Property(e => e.Oracleentityid).IsUnicode(false);

                entity.Property(e => e.Oracleentityname).IsUnicode(false);

                entity.Property(e => e.Pkguid).IsUnicode(false);

                entity.Property(e => e.Remarks).IsUnicode(false);

                entity.Property(e => e.Statusentityguid).IsUnicode(false);

                entity.Property(e => e.Trainermasterguid).IsUnicode(false);

                entity.Property(e => e.Trainingname).IsUnicode(false);

                entity.Property(e => e.Trainingresult).IsUnicode(false);

                entity.Property(e => e.Trainingtopic).IsUnicode(false);

                entity.Property(e => e.Trainingtypemasterguid).IsUnicode(false);

                entity.Property(e => e.Userarchived).IsUnicode(false);

                entity.Property(e => e.Usercreated).IsUnicode(false);

                entity.Property(e => e.Userdeleted).IsUnicode(false);

                entity.Property(e => e.Userupdated).IsUnicode(false);
            });

            modelBuilder.Entity<Trainingmaster>(entity =>
            {
                entity.Property(e => e.Attendeetype).IsUnicode(false);

                entity.Property(e => e.Comments).IsUnicode(false);

                entity.Property(e => e.Description).IsUnicode(false);

                entity.Property(e => e.Disabled).HasPrecision(1);

                entity.Property(e => e.Guid).IsUnicode(false);

                entity.Property(e => e.Objectversionno).HasPrecision(3);

                entity.Property(e => e.Oracleentityid).IsUnicode(false);

                entity.Property(e => e.Oracleentityname).IsUnicode(false);

                entity.Property(e => e.Pkguid).IsUnicode(false);

                entity.Property(e => e.Quickaccesscode).IsUnicode(false);

                entity.Property(e => e.Statusentityguid).IsUnicode(false);

                entity.Property(e => e.Trainermasterguid).IsUnicode(false);

                entity.Property(e => e.Trainingtopic).IsUnicode(false);

                entity.Property(e => e.Trainingtypeguid).IsUnicode(false);

                entity.Property(e => e.Userarchived).IsUnicode(false);

                entity.Property(e => e.Usercreated).IsUnicode(false);

                entity.Property(e => e.Userdeleted).IsUnicode(false);

                entity.Property(e => e.Userupdated).IsUnicode(false);
            });

            modelBuilder.Entity<Trainingsubtype>(entity =>
            {
                entity.Property(e => e.Comments).IsUnicode(false);

                entity.Property(e => e.Description).IsUnicode(false);

                entity.Property(e => e.Disabled).HasPrecision(1);

                entity.Property(e => e.Guid).IsUnicode(false);

                entity.Property(e => e.Name).IsUnicode(false);

                entity.Property(e => e.Objectversionno).HasPrecision(10);

                entity.Property(e => e.Oracleentityid).IsUnicode(false);

                entity.Property(e => e.Oracleentityname).IsUnicode(false);

                entity.Property(e => e.Pkguid).IsUnicode(false);

                entity.Property(e => e.Quickaccesscode).IsUnicode(false);

                entity.Property(e => e.Trainingtypeguid).IsUnicode(false);

                entity.Property(e => e.Userarchived).IsUnicode(false);

                entity.Property(e => e.Usercreated).IsUnicode(false);

                entity.Property(e => e.Userdeleted).IsUnicode(false);

                entity.Property(e => e.Userupdated).IsUnicode(false);
            });

            modelBuilder.Entity<Trainingtypemaster>(entity =>
            {
                entity.Property(e => e.Comments).IsUnicode(false);

                entity.Property(e => e.Description).IsUnicode(false);

                entity.Property(e => e.Disabled).HasPrecision(1);

                entity.Property(e => e.Guid).IsUnicode(false);

                entity.Property(e => e.Name).IsUnicode(false);

                entity.Property(e => e.Objectversionno).HasPrecision(10);

                entity.Property(e => e.Oracleentityid).IsUnicode(false);

                entity.Property(e => e.Oracleentityname).IsUnicode(false);

                entity.Property(e => e.Pkguid).IsUnicode(false);

                entity.Property(e => e.Quickaccesscode).IsUnicode(false);

                entity.Property(e => e.Userarchived).IsUnicode(false);

                entity.Property(e => e.Usercreated).IsUnicode(false);

                entity.Property(e => e.Userdeleted).IsUnicode(false);

                entity.Property(e => e.Userupdated).IsUnicode(false);
            });

            modelBuilder.Entity<TransactionBaseV>(entity =>
            {
                entity.ToView("TRANSACTION_BASE_V");

                entity.Property(e => e.AdjTxnTypeGuid).IsUnicode(false);

                entity.Property(e => e.Avoidtransactiontype).HasPrecision(1);

                entity.Property(e => e.BrandCode).IsUnicode(false);

                entity.Property(e => e.BrandGuid).IsUnicode(false);

                entity.Property(e => e.BrandName).IsUnicode(false);

                entity.Property(e => e.Carmasterguid).IsUnicode(false);

                entity.Property(e => e.CityCode).IsUnicode(false);

                entity.Property(e => e.CityGuid).IsUnicode(false);

                entity.Property(e => e.CityName).IsUnicode(false);

                entity.Property(e => e.ContraTxnTypeGuid).IsUnicode(false);

                entity.Property(e => e.Groupvariantname).IsUnicode(false);

                entity.Property(e => e.GvQuickaccesscode).IsUnicode(false);

                entity.Property(e => e.Gvcomponentguid).IsUnicode(false);

                entity.Property(e => e.LeCode).IsUnicode(false);

                entity.Property(e => e.LeGuid).IsUnicode(false);

                entity.Property(e => e.LeName).IsUnicode(false);

                entity.Property(e => e.LebranchGuid).IsUnicode(false);

                entity.Property(e => e.ModelCode).IsUnicode(false);

                entity.Property(e => e.ModelGuid).IsUnicode(false);

                entity.Property(e => e.ModelName).IsUnicode(false);

                entity.Property(e => e.OrgId).HasPrecision(4);

                entity.Property(e => e.SecGuid).IsUnicode(false);

                entity.Property(e => e.Signindicator).IsUnicode(false);

                entity.Property(e => e.SiteGuid).IsUnicode(false);

                entity.Property(e => e.Sitename).IsUnicode(false);

                entity.Property(e => e.SitetypeDescription).IsUnicode(false);

                entity.Property(e => e.SitetypeName).IsUnicode(false);

                entity.Property(e => e.SitetypeQuickaccesscode).IsUnicode(false);

                entity.Property(e => e.Sitetypemasterguid).IsUnicode(false);

                entity.Property(e => e.Sourceentityguid).IsUnicode(false);

                entity.Property(e => e.Sourcetransactionid).IsUnicode(false);

                entity.Property(e => e.SpGuid).IsUnicode(false);

                entity.Property(e => e.SpId).IsUnicode(false);

                entity.Property(e => e.SpName).IsUnicode(false);

                entity.Property(e => e.Spservicechargeflag).IsUnicode(false);

                entity.Property(e => e.TxnClass).IsUnicode(false);

                entity.Property(e => e.TxnClassCode).IsUnicode(false);

                entity.Property(e => e.TxnClassDesc).IsUnicode(false);

                entity.Property(e => e.TxnComments).IsUnicode(false);

                entity.Property(e => e.TxnNo).IsUnicode(false);

                entity.Property(e => e.TxnObjVerNo).HasPrecision(10);

                entity.Property(e => e.TxnOracleentityid).IsUnicode(false);

                entity.Property(e => e.TxnOracleentityname).IsUnicode(false);

                entity.Property(e => e.TxnSourceCode).IsUnicode(false);

                entity.Property(e => e.TxnSourceGuid).IsUnicode(false);

                entity.Property(e => e.TxnSourceName).IsUnicode(false);

                entity.Property(e => e.TxnStatusCode).IsUnicode(false);

                entity.Property(e => e.TxnStatusName).IsUnicode(false);

                entity.Property(e => e.TxnType).IsUnicode(false);

                entity.Property(e => e.TxnTypeCode).IsUnicode(false);

                entity.Property(e => e.TxnTypeGuid).IsUnicode(false);

                entity.Property(e => e.Usercontactnumber).IsUnicode(false);

                entity.Property(e => e.Userdomainloginname).IsUnicode(false);

                entity.Property(e => e.Useremail).IsUnicode(false);

                entity.Property(e => e.Usermasterguid).IsUnicode(false);

                entity.Property(e => e.Username).IsUnicode(false);
            });

            modelBuilder.Entity<TransactionV>(entity =>
            {
                entity.ToView("TRANSACTION_V");

                entity.Property(e => e.AdjTxnTypeGuid).IsUnicode(false);

                entity.Property(e => e.Avoidtransactiontype).HasPrecision(1);

                entity.Property(e => e.BrandCode).IsUnicode(false);

                entity.Property(e => e.BrandGuid).IsUnicode(false);

                entity.Property(e => e.BrandName).IsUnicode(false);

                entity.Property(e => e.Carmasterguid).IsUnicode(false);

                entity.Property(e => e.CityCode).IsUnicode(false);

                entity.Property(e => e.CityGuid).IsUnicode(false);

                entity.Property(e => e.CityName).IsUnicode(false);

                entity.Property(e => e.ContraTxnTypeGuid).IsUnicode(false);

                entity.Property(e => e.Groupvariantname).IsUnicode(false);

                entity.Property(e => e.GvQuickaccesscode).IsUnicode(false);

                entity.Property(e => e.Gvcomponentguid).IsUnicode(false);

                entity.Property(e => e.LeCode).IsUnicode(false);

                entity.Property(e => e.LeGuid).IsUnicode(false);

                entity.Property(e => e.LeName).IsUnicode(false);

                entity.Property(e => e.LebranchGuid).IsUnicode(false);

                entity.Property(e => e.ModelCode).IsUnicode(false);

                entity.Property(e => e.ModelGuid).IsUnicode(false);

                entity.Property(e => e.ModelName).IsUnicode(false);

                entity.Property(e => e.OrgId).HasPrecision(4);

                entity.Property(e => e.SecGuid).IsUnicode(false);

                entity.Property(e => e.Signindicator).IsUnicode(false);

                entity.Property(e => e.SiteGuid).IsUnicode(false);

                entity.Property(e => e.Sitename).IsUnicode(false);

                entity.Property(e => e.SitetypeDescription).IsUnicode(false);

                entity.Property(e => e.SitetypeName).IsUnicode(false);

                entity.Property(e => e.SitetypeQuickaccesscode).IsUnicode(false);

                entity.Property(e => e.Sitetypemasterguid).IsUnicode(false);

                entity.Property(e => e.Sourceentityguid).IsUnicode(false);

                entity.Property(e => e.Sourcetransactionid).IsUnicode(false);

                entity.Property(e => e.SpGuid).IsUnicode(false);

                entity.Property(e => e.SpId).IsUnicode(false);

                entity.Property(e => e.SpName).IsUnicode(false);

                entity.Property(e => e.Spservicechargeflag).IsUnicode(false);

                entity.Property(e => e.TxnClass).IsUnicode(false);

                entity.Property(e => e.TxnClassCode).IsUnicode(false);

                entity.Property(e => e.TxnClassDesc).IsUnicode(false);

                entity.Property(e => e.TxnComments).IsUnicode(false);

                entity.Property(e => e.TxnNo).IsUnicode(false);

                entity.Property(e => e.TxnObjVerNo).HasPrecision(10);

                entity.Property(e => e.TxnOracleentityid).IsUnicode(false);

                entity.Property(e => e.TxnOracleentityname).IsUnicode(false);

                entity.Property(e => e.TxnSourceCode).IsUnicode(false);

                entity.Property(e => e.TxnSourceGuid).IsUnicode(false);

                entity.Property(e => e.TxnSourceName).IsUnicode(false);

                entity.Property(e => e.TxnStatusCode).IsUnicode(false);

                entity.Property(e => e.TxnStatusName).IsUnicode(false);

                entity.Property(e => e.TxnType).IsUnicode(false);

                entity.Property(e => e.TxnTypeCode).IsUnicode(false);

                entity.Property(e => e.TxnTypeGuid).IsUnicode(false);

                entity.Property(e => e.Usercontactnumber).IsUnicode(false);

                entity.Property(e => e.Userdomainloginname).IsUnicode(false);

                entity.Property(e => e.Useremail).IsUnicode(false);

                entity.Property(e => e.Usermasterguid).IsUnicode(false);

                entity.Property(e => e.Username).IsUnicode(false);
            });

            modelBuilder.Entity<TransactionarchiveBaseV>(entity =>
            {
                entity.ToView("TRANSACTIONARCHIVE_BASE_V");

                entity.Property(e => e.AdjTxnTypeGuid).IsUnicode(false);

                entity.Property(e => e.Avoidtransactiontype).HasPrecision(1);

                entity.Property(e => e.BrandCode).IsUnicode(false);

                entity.Property(e => e.BrandGuid).IsUnicode(false);

                entity.Property(e => e.BrandName).IsUnicode(false);

                entity.Property(e => e.Carmasterguid).IsUnicode(false);

                entity.Property(e => e.CityCode).IsUnicode(false);

                entity.Property(e => e.CityGuid).IsUnicode(false);

                entity.Property(e => e.CityName).IsUnicode(false);

                entity.Property(e => e.ContraTxnTypeGuid).IsUnicode(false);

                entity.Property(e => e.Groupvariantname).IsUnicode(false);

                entity.Property(e => e.GvQuickaccesscode).IsUnicode(false);

                entity.Property(e => e.Gvcomponentguid).IsUnicode(false);

                entity.Property(e => e.LeCode).IsUnicode(false);

                entity.Property(e => e.LeGuid).IsUnicode(false);

                entity.Property(e => e.LeName).IsUnicode(false);

                entity.Property(e => e.LebranchGuid).IsUnicode(false);

                entity.Property(e => e.ModelCode).IsUnicode(false);

                entity.Property(e => e.ModelGuid).IsUnicode(false);

                entity.Property(e => e.ModelName).IsUnicode(false);

                entity.Property(e => e.OrgId).HasPrecision(4);

                entity.Property(e => e.SecGuid).IsUnicode(false);

                entity.Property(e => e.Signindicator).IsUnicode(false);

                entity.Property(e => e.SiteGuid).IsUnicode(false);

                entity.Property(e => e.Sitename).IsUnicode(false);

                entity.Property(e => e.SitetypeDescription).IsUnicode(false);

                entity.Property(e => e.SitetypeName).IsUnicode(false);

                entity.Property(e => e.SitetypeQuickaccesscode).IsUnicode(false);

                entity.Property(e => e.Sitetypemasterguid).IsUnicode(false);

                entity.Property(e => e.Sourceentityguid).IsUnicode(false);

                entity.Property(e => e.Sourcetransactionid).IsUnicode(false);

                entity.Property(e => e.SpGuid).IsUnicode(false);

                entity.Property(e => e.SpId).IsUnicode(false);

                entity.Property(e => e.SpName).IsUnicode(false);

                entity.Property(e => e.Spservicechargeflag).IsUnicode(false);

                entity.Property(e => e.TxnClass).IsUnicode(false);

                entity.Property(e => e.TxnClassCode).IsUnicode(false);

                entity.Property(e => e.TxnClassDesc).IsUnicode(false);

                entity.Property(e => e.TxnComments).IsUnicode(false);

                entity.Property(e => e.TxnNo).IsUnicode(false);

                entity.Property(e => e.TxnObjVerNo).HasPrecision(10);

                entity.Property(e => e.TxnOracleentityid).IsUnicode(false);

                entity.Property(e => e.TxnOracleentityname).IsUnicode(false);

                entity.Property(e => e.TxnSourceCode).IsUnicode(false);

                entity.Property(e => e.TxnSourceGuid).IsUnicode(false);

                entity.Property(e => e.TxnSourceName).IsUnicode(false);

                entity.Property(e => e.TxnStatusCode).IsUnicode(false);

                entity.Property(e => e.TxnStatusName).IsUnicode(false);

                entity.Property(e => e.TxnType).IsUnicode(false);

                entity.Property(e => e.TxnTypeCode).IsUnicode(false);

                entity.Property(e => e.TxnTypeGuid).IsUnicode(false);

                entity.Property(e => e.Usercontactnumber).IsUnicode(false);

                entity.Property(e => e.Userdomainloginname).IsUnicode(false);

                entity.Property(e => e.Useremail).IsUnicode(false);

                entity.Property(e => e.Usermasterguid).IsUnicode(false);

                entity.Property(e => e.Username).IsUnicode(false);
            });

            modelBuilder.Entity<TransactionarchiveV>(entity =>
            {
                entity.ToView("TRANSACTIONARCHIVE_V");

                entity.Property(e => e.AdjTxnTypeGuid).IsUnicode(false);

                entity.Property(e => e.Avoidtransactiontype).HasPrecision(1);

                entity.Property(e => e.BrandCode).IsUnicode(false);

                entity.Property(e => e.BrandGuid).IsUnicode(false);

                entity.Property(e => e.BrandName).IsUnicode(false);

                entity.Property(e => e.Carmasterguid).IsUnicode(false);

                entity.Property(e => e.CityCode).IsUnicode(false);

                entity.Property(e => e.CityGuid).IsUnicode(false);

                entity.Property(e => e.CityName).IsUnicode(false);

                entity.Property(e => e.ContraTxnTypeGuid).IsUnicode(false);

                entity.Property(e => e.Groupvariantname).IsUnicode(false);

                entity.Property(e => e.GvQuickaccesscode).IsUnicode(false);

                entity.Property(e => e.Gvcomponentguid).IsUnicode(false);

                entity.Property(e => e.LeCode).IsUnicode(false);

                entity.Property(e => e.LeGuid).IsUnicode(false);

                entity.Property(e => e.LeName).IsUnicode(false);

                entity.Property(e => e.LebranchGuid).IsUnicode(false);

                entity.Property(e => e.ModelCode).IsUnicode(false);

                entity.Property(e => e.ModelGuid).IsUnicode(false);

                entity.Property(e => e.ModelName).IsUnicode(false);

                entity.Property(e => e.OrgId).HasPrecision(4);

                entity.Property(e => e.SecGuid).IsUnicode(false);

                entity.Property(e => e.Signindicator).IsUnicode(false);

                entity.Property(e => e.SiteGuid).IsUnicode(false);

                entity.Property(e => e.Sitename).IsUnicode(false);

                entity.Property(e => e.SitetypeDescription).IsUnicode(false);

                entity.Property(e => e.SitetypeName).IsUnicode(false);

                entity.Property(e => e.SitetypeQuickaccesscode).IsUnicode(false);

                entity.Property(e => e.Sitetypemasterguid).IsUnicode(false);

                entity.Property(e => e.Sourceentityguid).IsUnicode(false);

                entity.Property(e => e.Sourcetransactionid).IsUnicode(false);

                entity.Property(e => e.SpGuid).IsUnicode(false);

                entity.Property(e => e.SpId).IsUnicode(false);

                entity.Property(e => e.SpName).IsUnicode(false);

                entity.Property(e => e.Spservicechargeflag).IsUnicode(false);

                entity.Property(e => e.TxnClass).IsUnicode(false);

                entity.Property(e => e.TxnClassCode).IsUnicode(false);

                entity.Property(e => e.TxnClassDesc).IsUnicode(false);

                entity.Property(e => e.TxnComments).IsUnicode(false);

                entity.Property(e => e.TxnNo).IsUnicode(false);

                entity.Property(e => e.TxnObjVerNo).HasPrecision(10);

                entity.Property(e => e.TxnOracleentityid).IsUnicode(false);

                entity.Property(e => e.TxnOracleentityname).IsUnicode(false);

                entity.Property(e => e.TxnSourceCode).IsUnicode(false);

                entity.Property(e => e.TxnSourceGuid).IsUnicode(false);

                entity.Property(e => e.TxnSourceName).IsUnicode(false);

                entity.Property(e => e.TxnStatusCode).IsUnicode(false);

                entity.Property(e => e.TxnStatusName).IsUnicode(false);

                entity.Property(e => e.TxnType).IsUnicode(false);

                entity.Property(e => e.TxnTypeCode).IsUnicode(false);

                entity.Property(e => e.TxnTypeGuid).IsUnicode(false);

                entity.Property(e => e.Usercontactnumber).IsUnicode(false);

                entity.Property(e => e.Userdomainloginname).IsUnicode(false);

                entity.Property(e => e.Useremail).IsUnicode(false);

                entity.Property(e => e.Usermasterguid).IsUnicode(false);

                entity.Property(e => e.Username).IsUnicode(false);
            });

            modelBuilder.Entity<Transactioncategory>(entity =>
            {
                entity.HasKey(e => e.Guid)
                    .HasName("SYS_C0010858");

                entity.Property(e => e.Guid).IsUnicode(false);

                entity.Property(e => e.Disabled).HasPrecision(1);

                entity.Property(e => e.Includeininvoiceratiocal).IsUnicode(false);

                entity.Property(e => e.Name).IsUnicode(false);

                entity.Property(e => e.Quickaccesscode).IsUnicode(false);

                entity.Property(e => e.Usercreated).IsUnicode(false);

                entity.Property(e => e.Userdeleted).IsUnicode(false);

                entity.Property(e => e.Userupdated).IsUnicode(false);
            });

            modelBuilder.Entity<Transactionclass>(entity =>
            {
                entity.Property(e => e.Comments).IsUnicode(false);

                entity.Property(e => e.Description).IsUnicode(false);

                entity.Property(e => e.Disabled).HasPrecision(1);

                entity.Property(e => e.Guid).IsUnicode(false);

                entity.Property(e => e.Name).IsUnicode(false);

                entity.Property(e => e.Oracleentityid).IsUnicode(false);

                entity.Property(e => e.Oracleentityname).IsUnicode(false);

                entity.Property(e => e.Oracleentitytype).IsUnicode(false);

                entity.Property(e => e.Pkguid).IsUnicode(false);

                entity.Property(e => e.Quickaccesscode).IsUnicode(false);

                entity.Property(e => e.Signindicator).IsUnicode(false);

                entity.Property(e => e.Userarchived).IsUnicode(false);

                entity.Property(e => e.Usercreated).IsUnicode(false);

                entity.Property(e => e.Userdeleted).IsUnicode(false);

                entity.Property(e => e.Userupdated).IsUnicode(false);
            });

            modelBuilder.Entity<Transactionmaster>(entity =>
            {
                entity.Property(e => e.Avoidtransactiontype).HasPrecision(1);

                entity.Property(e => e.Carmasterguid).IsUnicode(false);

                entity.Property(e => e.Comments).IsUnicode(false);

                entity.Property(e => e.Completeflag).HasPrecision(1);

                entity.Property(e => e.Currencycode).IsUnicode(false);

                entity.Property(e => e.Entitymasterguid).IsUnicode(false);

                entity.Property(e => e.Fullyreversedflag).IsUnicode(false);

                entity.Property(e => e.Gvcomponentguid).IsUnicode(false);

                entity.Property(e => e.Immediatepaytermflag).IsUnicode(false);

                entity.Property(e => e.Objectversionno).HasPrecision(10);

                entity.Property(e => e.Oracleentityid).IsUnicode(false);

                entity.Property(e => e.Oracleentityname).IsUnicode(false);

                entity.Property(e => e.Pkguid).IsUnicode(false);

                entity.Property(e => e.Securitycombinationguid).IsUnicode(false);

                entity.Property(e => e.Sourceentityguid).IsUnicode(false);

                entity.Property(e => e.Sourcetransactionid).IsUnicode(false);

                entity.Property(e => e.Spsitemasterguid).IsUnicode(false);

                entity.Property(e => e.Statusentityguid).IsUnicode(false);

                entity.Property(e => e.Transactionno).IsUnicode(false);

                entity.Property(e => e.Transactionsourceguid).IsUnicode(false);

                entity.Property(e => e.Transactiontypeguid).IsUnicode(false);

                entity.Property(e => e.Userarchived).IsUnicode(false);

                entity.Property(e => e.Usercreated).IsUnicode(false);

                entity.Property(e => e.Userdeleted).IsUnicode(false);

                entity.Property(e => e.Userupdated).IsUnicode(false);
            });

            modelBuilder.Entity<Transactionmaster06042023>(entity =>
            {
                entity.Property(e => e.Avoidtransactiontype)
                    .HasPrecision(1)
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Carmasterguid).IsUnicode(false);

                entity.Property(e => e.Comments).IsUnicode(false);

                entity.Property(e => e.Completeflag).HasPrecision(1);

                entity.Property(e => e.Currencycode).IsUnicode(false);

                entity.Property(e => e.Entitymasterguid).IsUnicode(false);

                entity.Property(e => e.Fullyreversedflag)
                    .IsUnicode(false)
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Gvcomponentguid).IsUnicode(false);

                entity.Property(e => e.Immediatepaytermflag)
                    .IsUnicode(false)
                    .HasDefaultValueSql("1");

                entity.Property(e => e.Objectversionno).HasPrecision(10);

                entity.Property(e => e.Oracleentityid).IsUnicode(false);

                entity.Property(e => e.Oracleentityname).IsUnicode(false);

                entity.Property(e => e.Pkguid).IsUnicode(false);

                entity.Property(e => e.Securitycombinationguid).IsUnicode(false);

                entity.Property(e => e.Sourceentityguid).IsUnicode(false);

                entity.Property(e => e.Sourcetransactionid).IsUnicode(false);

                entity.Property(e => e.Spsitemasterguid).IsUnicode(false);

                entity.Property(e => e.Statusentityguid).IsUnicode(false);

                entity.Property(e => e.Transactionno).IsUnicode(false);

                entity.Property(e => e.Transactionsourceguid).IsUnicode(false);

                entity.Property(e => e.Transactiontypeguid).IsUnicode(false);

                entity.Property(e => e.Userarchived).IsUnicode(false);

                entity.Property(e => e.Usercreated).IsUnicode(false);

                entity.Property(e => e.Userdeleted).IsUnicode(false);

                entity.Property(e => e.Userupdated).IsUnicode(false);
            });

            modelBuilder.Entity<Transactionmasterarchive>(entity =>
            {
                entity.Property(e => e.Avoidtransactiontype)
                    .HasPrecision(1)
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Carmasterguid).IsUnicode(false);

                entity.Property(e => e.Comments).IsUnicode(false);

                entity.Property(e => e.Completeflag).HasPrecision(1);

                entity.Property(e => e.Currencycode).IsUnicode(false);

                entity.Property(e => e.Entitymasterguid).IsUnicode(false);

                entity.Property(e => e.Fullyreversedflag).IsUnicode(false);

                entity.Property(e => e.Gvcomponentguid).IsUnicode(false);

                entity.Property(e => e.Immediatepaytermflag).IsUnicode(false);

                entity.Property(e => e.Objectversionno).HasPrecision(10);

                entity.Property(e => e.Oracleentityid).IsUnicode(false);

                entity.Property(e => e.Oracleentityname).IsUnicode(false);

                entity.Property(e => e.Pkguid).IsUnicode(false);

                entity.Property(e => e.Securitycombinationguid).IsUnicode(false);

                entity.Property(e => e.Sourceentityguid).IsUnicode(false);

                entity.Property(e => e.Sourcetransactionid).IsUnicode(false);

                entity.Property(e => e.Spsitemasterguid).IsUnicode(false);

                entity.Property(e => e.Statusentityguid).IsUnicode(false);

                entity.Property(e => e.Transactionno).IsUnicode(false);

                entity.Property(e => e.Transactionsourceguid).IsUnicode(false);

                entity.Property(e => e.Transactiontypeguid).IsUnicode(false);

                entity.Property(e => e.Userarchived).IsUnicode(false);

                entity.Property(e => e.Usercreated).IsUnicode(false);

                entity.Property(e => e.Userdeleted).IsUnicode(false);

                entity.Property(e => e.Userupdated).IsUnicode(false);
            });

            modelBuilder.Entity<Transactionsource>(entity =>
            {
                entity.Property(e => e.Comments).IsUnicode(false);

                entity.Property(e => e.Description).IsUnicode(false);

                entity.Property(e => e.Disabled).HasPrecision(1);

                entity.Property(e => e.Guid).IsUnicode(false);

                entity.Property(e => e.Name).IsUnicode(false);

                entity.Property(e => e.Objectversionno).HasPrecision(3);

                entity.Property(e => e.Oracleentityid).IsUnicode(false);

                entity.Property(e => e.Oracleentityname).IsUnicode(false);

                entity.Property(e => e.Pkguid).IsUnicode(false);

                entity.Property(e => e.Quickaccesscode).IsUnicode(false);

                entity.Property(e => e.Userarchived).IsUnicode(false);

                entity.Property(e => e.Usercreated).IsUnicode(false);

                entity.Property(e => e.Userdeleted).IsUnicode(false);

                entity.Property(e => e.Userupdated).IsUnicode(false);
            });

            modelBuilder.Entity<Transactiontype>(entity =>
            {
                entity.Property(e => e.Adjustmenttranstypeguid).IsUnicode(false);

                entity.Property(e => e.Contratranstypeguid).IsUnicode(false);

                entity.Property(e => e.Description).IsUnicode(false);

                entity.Property(e => e.Disabled).HasPrecision(1);

                entity.Property(e => e.Documenttype).IsUnicode(false);

                entity.Property(e => e.Glcode).HasPrecision(10);

                entity.Property(e => e.Glname).IsUnicode(false);

                entity.Property(e => e.Guid).IsUnicode(false);

                entity.Property(e => e.Isbalancesheet).HasPrecision(1);

                entity.Property(e => e.Name).IsUnicode(false);

                entity.Property(e => e.Objectversionno).HasPrecision(3);

                entity.Property(e => e.Oracleentityid).IsUnicode(false);

                entity.Property(e => e.Oracleentityname).IsUnicode(false);

                entity.Property(e => e.Oracleentitytype).IsUnicode(false);

                entity.Property(e => e.Pkguid).IsUnicode(false);

                entity.Property(e => e.Quickaccesscode).IsUnicode(false);

                entity.Property(e => e.Revenuegroup).IsUnicode(false);

                entity.Property(e => e.Sapglcode).IsUnicode(false);

                entity.Property(e => e.Sapglname).IsUnicode(false);

                entity.Property(e => e.Showcostcenter).HasPrecision(1);

                entity.Property(e => e.Spservicechargeflag).IsUnicode(false);

                entity.Property(e => e.Tdstrxtypeguid).IsUnicode(false);

                entity.Property(e => e.Transactioncategoryguid).IsUnicode(false);

                entity.Property(e => e.Transactionclassguid).IsUnicode(false);

                entity.Property(e => e.Userarchived).IsUnicode(false);

                entity.Property(e => e.Usercreated).IsUnicode(false);

                entity.Property(e => e.Userdeleted).IsUnicode(false);

                entity.Property(e => e.Userupdated).IsUnicode(false);
            });

            modelBuilder.Entity<TransactiontypeBaseV>(entity =>
            {
                entity.ToView("TRANSACTIONTYPE_BASE_V");

                entity.Property(e => e.Classcomments).IsUnicode(false);

                entity.Property(e => e.Classdescription).IsUnicode(false);

                entity.Property(e => e.Classdisabled).HasPrecision(1);

                entity.Property(e => e.Classname).IsUnicode(false);

                entity.Property(e => e.Classoracleentityid).IsUnicode(false);

                entity.Property(e => e.Classoracleentityname).IsUnicode(false);

                entity.Property(e => e.Classoracleentitytype).IsUnicode(false);

                entity.Property(e => e.Classpkguid).IsUnicode(false);

                entity.Property(e => e.Classquickaccesscode).IsUnicode(false);

                entity.Property(e => e.Classsignindicator).IsUnicode(false);

                entity.Property(e => e.Transactiontypeguid).IsUnicode(false);

                entity.Property(e => e.Typeadjustmenttranstypeguid).IsUnicode(false);

                entity.Property(e => e.Typecontratranstypeguid).IsUnicode(false);

                entity.Property(e => e.Typedescription).IsUnicode(false);

                entity.Property(e => e.Typedisabled).HasPrecision(1);

                entity.Property(e => e.Typename).IsUnicode(false);

                entity.Property(e => e.Typeobjectversionno).HasPrecision(3);

                entity.Property(e => e.Typeoracleentityid).IsUnicode(false);

                entity.Property(e => e.Typeoracleentityname).IsUnicode(false);

                entity.Property(e => e.Typeoracleentitytype).IsUnicode(false);

                entity.Property(e => e.Typepkguid).IsUnicode(false);

                entity.Property(e => e.Typequickaccesscode).IsUnicode(false);

                entity.Property(e => e.Typetdstrxtypeguid).IsUnicode(false);

                entity.Property(e => e.Typetransactionclassguid).IsUnicode(false);
            });

            modelBuilder.Entity<TransactiontypeV>(entity =>
            {
                entity.ToView("TRANSACTIONTYPE_V");

                entity.Property(e => e.Classcomments).IsUnicode(false);

                entity.Property(e => e.Classdescription).IsUnicode(false);

                entity.Property(e => e.Classdisabled).HasPrecision(1);

                entity.Property(e => e.Classname).IsUnicode(false);

                entity.Property(e => e.Classoracleentityid).IsUnicode(false);

                entity.Property(e => e.Classoracleentityname).IsUnicode(false);

                entity.Property(e => e.Classoracleentitytype).IsUnicode(false);

                entity.Property(e => e.Classpkguid).IsUnicode(false);

                entity.Property(e => e.Classquickaccesscode).IsUnicode(false);

                entity.Property(e => e.Classsignindicator).IsUnicode(false);

                entity.Property(e => e.Transactiontypeguid).IsUnicode(false);

                entity.Property(e => e.Typeadjustmenttranstypeguid).IsUnicode(false);

                entity.Property(e => e.Typecontratranstypeguid).IsUnicode(false);

                entity.Property(e => e.Typedescription).IsUnicode(false);

                entity.Property(e => e.Typedisabled).HasPrecision(1);

                entity.Property(e => e.Typename).IsUnicode(false);

                entity.Property(e => e.Typeobjectversionno).HasPrecision(3);

                entity.Property(e => e.Typeoracleentityid).IsUnicode(false);

                entity.Property(e => e.Typeoracleentityname).IsUnicode(false);

                entity.Property(e => e.Typeoracleentitytype).IsUnicode(false);

                entity.Property(e => e.Typepkguid).IsUnicode(false);

                entity.Property(e => e.Typequickaccesscode).IsUnicode(false);

                entity.Property(e => e.Typetdstrxtypeguid).IsUnicode(false);

                entity.Property(e => e.Typetransactionclassguid).IsUnicode(false);
            });

            modelBuilder.Entity<TripAllocV>(entity =>
            {
                entity.ToView("TRIP_ALLOC_V");

                entity.Property(e => e.Carmasterguid).IsUnicode(false);

                entity.Property(e => e.Personid).IsUnicode(false);

                entity.Property(e => e.Registrationno).IsUnicode(false);

                entity.Property(e => e.Securitycombinationguid).IsUnicode(false);

                entity.Property(e => e.Serviceproviderguid).IsUnicode(false);

                entity.Property(e => e.Sppersonguid).IsUnicode(false);

                entity.Property(e => e.Spsitemasterguid).IsUnicode(false);
            });

            modelBuilder.Entity<TripDataBaseV>(entity =>
            {
                entity.ToView("TRIP_DATA_BASE_V");

                entity.Property(e => e.Bookingtype).IsUnicode(false);

                entity.Property(e => e.Cabbrand).IsUnicode(false);

                entity.Property(e => e.Cabregistration).IsUnicode(false);

                entity.Property(e => e.Carmasterguid).IsUnicode(false);

                entity.Property(e => e.Carregistrationno).IsUnicode(false);

                entity.Property(e => e.Channel).IsUnicode(false);

                entity.Property(e => e.Corporatecompanyname).IsUnicode(false);

                entity.Property(e => e.Customeremailid).IsUnicode(false);

                entity.Property(e => e.Customername).IsUnicode(false);

                entity.Property(e => e.Drivermasterguid).IsUnicode(false);

                entity.Property(e => e.Dropaddress).IsUnicode(false);

                entity.Property(e => e.Droplocation).IsUnicode(false);

                entity.Property(e => e.Fromstate).IsUnicode(false);

                entity.Property(e => e.Jobbrand).IsUnicode(false);

                entity.Property(e => e.Jobid).IsUnicode(false);

                entity.Property(e => e.Jobtype).IsUnicode(false);

                entity.Property(e => e.Matchedjobid).IsUnicode(false);

                entity.Property(e => e.Paymenttype).IsUnicode(false);

                entity.Property(e => e.Paymenttype2).IsUnicode(false);

                entity.Property(e => e.Pickupaddress).IsUnicode(false);

                entity.Property(e => e.Pickuplocation).IsUnicode(false);

                entity.Property(e => e.Rfidin).IsUnicode(false);

                entity.Property(e => e.Securitycombinationguid).IsUnicode(false);

                entity.Property(e => e.Serviceproviderguid).IsUnicode(false);

                entity.Property(e => e.Siteguid).IsUnicode(false);

                entity.Property(e => e.Status).IsUnicode(false);

                entity.Property(e => e.Tmpnoshowcar).IsUnicode(false);

                entity.Property(e => e.Tmpnoshowdriver).IsUnicode(false);

                entity.Property(e => e.TripGuid).IsUnicode(false);

                entity.Property(e => e.Tripid).IsUnicode(false);

                entity.Property(e => e.Tritype).IsUnicode(false);
            });

            modelBuilder.Entity<TripDataV>(entity =>
            {
                entity.ToView("TRIP_DATA_V");

                entity.Property(e => e.Bookingtype).IsUnicode(false);

                entity.Property(e => e.Cabbrand).IsUnicode(false);

                entity.Property(e => e.Cabregistration).IsUnicode(false);

                entity.Property(e => e.Carmasterguid).IsUnicode(false);

                entity.Property(e => e.Carregistrationno).IsUnicode(false);

                entity.Property(e => e.Channel).IsUnicode(false);

                entity.Property(e => e.Corporatecompanyname).IsUnicode(false);

                entity.Property(e => e.Customeremailid).IsUnicode(false);

                entity.Property(e => e.Customername).IsUnicode(false);

                entity.Property(e => e.Drivermasterguid).IsUnicode(false);

                entity.Property(e => e.Dropaddress).IsUnicode(false);

                entity.Property(e => e.Droplocation).IsUnicode(false);

                entity.Property(e => e.Fromstate).IsUnicode(false);

                entity.Property(e => e.Jobbrand).IsUnicode(false);

                entity.Property(e => e.Jobid).IsUnicode(false);

                entity.Property(e => e.Jobtype).IsUnicode(false);

                entity.Property(e => e.Matchedjobid).IsUnicode(false);

                entity.Property(e => e.Paymenttype).IsUnicode(false);

                entity.Property(e => e.Paymenttype2).IsUnicode(false);

                entity.Property(e => e.Pickupaddress).IsUnicode(false);

                entity.Property(e => e.Pickuplocation).IsUnicode(false);

                entity.Property(e => e.Rfidin).IsUnicode(false);

                entity.Property(e => e.Securitycombinationguid).IsUnicode(false);

                entity.Property(e => e.Serviceproviderguid).IsUnicode(false);

                entity.Property(e => e.Siteguid).IsUnicode(false);

                entity.Property(e => e.Status).IsUnicode(false);

                entity.Property(e => e.Tmpnoshowcar).IsUnicode(false);

                entity.Property(e => e.Tmpnoshowdriver).IsUnicode(false);

                entity.Property(e => e.TripGuid).IsUnicode(false);

                entity.Property(e => e.Tripid).IsUnicode(false);

                entity.Property(e => e.Tritype).IsUnicode(false);
            });

            modelBuilder.Entity<TripDriverV>(entity =>
            {
                entity.ToView("TRIP_DRIVER_V");

                entity.Property(e => e.Driverguid).IsUnicode(false);

                entity.Property(e => e.Driverid).IsUnicode(false);
            });

            modelBuilder.Entity<TripPhoneV>(entity =>
            {
                entity.ToView("TRIP_PHONE_V");

                entity.Property(e => e.Contactno).IsUnicode(false);

                entity.Property(e => e.Personcontactguid).IsUnicode(false);

                entity.Property(e => e.Personguid).IsUnicode(false);

                entity.Property(e => e.Personid).IsUnicode(false);

                entity.Property(e => e.Personstatus).IsUnicode(false);
            });

            modelBuilder.Entity<TripRevenueV>(entity =>
            {
                entity.ToView("TRIP_REVENUE_V");

                entity.Property(e => e.Brand).IsUnicode(false);

                entity.Property(e => e.CarNo).IsUnicode(false);

                entity.Property(e => e.City).IsUnicode(false);

                entity.Property(e => e.Le).IsUnicode(false);

                entity.Property(e => e.Model).IsUnicode(false);

                entity.Property(e => e.Reguid).IsUnicode(false);

                entity.Property(e => e.SpContactNo).IsUnicode(false);

                entity.Property(e => e.SpName).IsUnicode(false);

                entity.Property(e => e.TripSecGuid).IsUnicode(false);
            });

            modelBuilder.Entity<TripSummaryMv>(entity =>
            {
                entity.Property(e => e.BrandCode).IsUnicode(false);

                entity.Property(e => e.BrandName).IsUnicode(false);

                entity.Property(e => e.CityCode).IsUnicode(false);

                entity.Property(e => e.CityName).IsUnicode(false);

                entity.Property(e => e.LeCode).IsUnicode(false);

                entity.Property(e => e.LeName).IsUnicode(false);

                entity.Property(e => e.ModelCode).IsUnicode(false);

                entity.Property(e => e.ModelName).IsUnicode(false);
            });

            modelBuilder.Entity<TripSummaryV>(entity =>
            {
                entity.ToView("TRIP_SUMMARY_V");

                entity.Property(e => e.BrandCode).IsUnicode(false);

                entity.Property(e => e.BrandName).IsUnicode(false);

                entity.Property(e => e.CityCode).IsUnicode(false);

                entity.Property(e => e.CityName).IsUnicode(false);

                entity.Property(e => e.LeCode).IsUnicode(false);

                entity.Property(e => e.LeName).IsUnicode(false);

                entity.Property(e => e.ModelCode).IsUnicode(false);

                entity.Property(e => e.ModelName).IsUnicode(false);
            });

            modelBuilder.Entity<Tripdata1>(entity =>
            {
                entity.HasKey(e => e.Tripid)
                    .HasName("TRIP_TRIPID_IND");

                entity.Property(e => e.Tripid).IsUnicode(false);

                entity.Property(e => e.CalculatedPctFlag).IsUnicode(false);

                entity.Property(e => e.Carmasterguid).IsUnicode(false);

                entity.Property(e => e.Carregistrationno).IsUnicode(false);

                entity.Property(e => e.Drivermasterguid).IsUnicode(false);

                entity.Property(e => e.Guid).IsUnicode(false);

                entity.Property(e => e.Gvname).IsUnicode(false);

                entity.Property(e => e.Oracleentityid).IsUnicode(false);

                entity.Property(e => e.Oracleentityname).IsUnicode(false);

                entity.Property(e => e.Pkguid).IsUnicode(false);

                entity.Property(e => e.Securitycombinationguid).IsUnicode(false);

                entity.Property(e => e.Serviceproviderguid).IsUnicode(false);

                entity.Property(e => e.Siteguid).IsUnicode(false);

                entity.Property(e => e.Userarchived).IsUnicode(false);

                entity.Property(e => e.Usercreated).IsUnicode(false);

                entity.Property(e => e.Userdeleted).IsUnicode(false);

                entity.Property(e => e.Userupdated).IsUnicode(false);
            });

            modelBuilder.Entity<Tripdata1Archive>(entity =>
            {
                entity.Property(e => e.CalculatedPctFlag).IsUnicode(false);

                entity.Property(e => e.Carmasterguid).IsUnicode(false);

                entity.Property(e => e.Carregistrationno).IsUnicode(false);

                entity.Property(e => e.Drivermasterguid).IsUnicode(false);

                entity.Property(e => e.Guid).IsUnicode(false);

                entity.Property(e => e.Gvname).IsUnicode(false);

                entity.Property(e => e.Oracleentityid).IsUnicode(false);

                entity.Property(e => e.Oracleentityname).IsUnicode(false);

                entity.Property(e => e.Pkguid).IsUnicode(false);

                entity.Property(e => e.Securitycombinationguid).IsUnicode(false);

                entity.Property(e => e.Serviceproviderguid).IsUnicode(false);

                entity.Property(e => e.Siteguid).IsUnicode(false);

                entity.Property(e => e.Tripid).IsUnicode(false);

                entity.Property(e => e.Userarchived).IsUnicode(false);

                entity.Property(e => e.Usercreated).IsUnicode(false);

                entity.Property(e => e.Userdeleted).IsUnicode(false);

                entity.Property(e => e.Userupdated).IsUnicode(false);
            });

            modelBuilder.Entity<Tripdata1ArchiveNew>(entity =>
            {
                entity.Property(e => e.CalculatedPctFlag).IsUnicode(false);

                entity.Property(e => e.Carmasterguid).IsUnicode(false);

                entity.Property(e => e.Carregistrationno).IsUnicode(false);

                entity.Property(e => e.Drivermasterguid).IsUnicode(false);

                entity.Property(e => e.Guid).IsUnicode(false);

                entity.Property(e => e.Gvname).IsUnicode(false);

                entity.Property(e => e.Oracleentityid).IsUnicode(false);

                entity.Property(e => e.Oracleentityname).IsUnicode(false);

                entity.Property(e => e.Pkguid).IsUnicode(false);

                entity.Property(e => e.Securitycombinationguid).IsUnicode(false);

                entity.Property(e => e.Serviceproviderguid).IsUnicode(false);

                entity.Property(e => e.Siteguid).IsUnicode(false);

                entity.Property(e => e.Tripid).IsUnicode(false);

                entity.Property(e => e.Userarchived).IsUnicode(false);

                entity.Property(e => e.Usercreated).IsUnicode(false);

                entity.Property(e => e.Userdeleted).IsUnicode(false);

                entity.Property(e => e.Userupdated).IsUnicode(false);
            });

            modelBuilder.Entity<TripdataArchive>(entity =>
            {
                entity.Property(e => e.Bookingtype).IsUnicode(false);

                entity.Property(e => e.Cabbrand).IsUnicode(false);

                entity.Property(e => e.Cabregistration).IsUnicode(false);

                entity.Property(e => e.Callerid).IsUnicode(false);

                entity.Property(e => e.Channel).IsUnicode(false);

                entity.Property(e => e.Corporatecode).IsUnicode(false);

                entity.Property(e => e.Corporatecompanyname).IsUnicode(false);

                entity.Property(e => e.Customeremailid).IsUnicode(false);

                entity.Property(e => e.Customername).IsUnicode(false);

                entity.Property(e => e.Dropaddress).IsUnicode(false);

                entity.Property(e => e.Droplocation).IsUnicode(false);

                entity.Property(e => e.Dutyslipurl).IsUnicode(false);

                entity.Property(e => e.Empshift).IsUnicode(false);

                entity.Property(e => e.Fromstate).IsUnicode(false);

                entity.Property(e => e.Jobbrand).IsUnicode(false);

                entity.Property(e => e.Jobid).IsUnicode(false);

                entity.Property(e => e.Jobtype).IsUnicode(false);

                entity.Property(e => e.Matchedjobid).IsUnicode(false);

                entity.Property(e => e.Monroetriptype).IsUnicode(false);

                entity.Property(e => e.Paymenttype).IsUnicode(false);

                entity.Property(e => e.Paymenttype2).IsUnicode(false);

                entity.Property(e => e.Pickupaddress).IsUnicode(false);

                entity.Property(e => e.Pickuplocation).IsUnicode(false);

                entity.Property(e => e.Pickupmessage).IsUnicode(false);

                entity.Property(e => e.Rfidin).IsUnicode(false);

                entity.Property(e => e.Rsstatus).IsUnicode(false);

                entity.Property(e => e.Status).IsUnicode(false);

                entity.Property(e => e.Thirdpartyvendor).IsUnicode(false);

                entity.Property(e => e.Tmpnoshowcar).IsUnicode(false);

                entity.Property(e => e.Tmpnoshowdriver).IsUnicode(false);

                entity.Property(e => e.Tollurl).IsUnicode(false);

                entity.Property(e => e.Tripid).IsUnicode(false);

                entity.Property(e => e.Tritype).IsUnicode(false);

                entity.Property(e => e.Walletname).IsUnicode(false);

                entity.Property(e => e.Wallettransactionid).IsUnicode(false);
            });

            modelBuilder.Entity<TripdataArchiveNew>(entity =>
            {
                entity.Property(e => e.Bookingtype).IsUnicode(false);

                entity.Property(e => e.Cabbrand).IsUnicode(false);

                entity.Property(e => e.Cabregistration).IsUnicode(false);

                entity.Property(e => e.Callerid).IsUnicode(false);

                entity.Property(e => e.Channel).IsUnicode(false);

                entity.Property(e => e.Corporatecode).IsUnicode(false);

                entity.Property(e => e.Corporatecompanyname).IsUnicode(false);

                entity.Property(e => e.Customeremailid).IsUnicode(false);

                entity.Property(e => e.Customername).IsUnicode(false);

                entity.Property(e => e.Dropaddress).IsUnicode(false);

                entity.Property(e => e.Droplocation).IsUnicode(false);

                entity.Property(e => e.Dutyslipurl).IsUnicode(false);

                entity.Property(e => e.Empshift).IsUnicode(false);

                entity.Property(e => e.Fromstate).IsUnicode(false);

                entity.Property(e => e.Jobbrand).IsUnicode(false);

                entity.Property(e => e.Jobid).IsUnicode(false);

                entity.Property(e => e.Jobtype).IsUnicode(false);

                entity.Property(e => e.Matchedjobid).IsUnicode(false);

                entity.Property(e => e.Monroetriptype).IsUnicode(false);

                entity.Property(e => e.Paymenttype).IsUnicode(false);

                entity.Property(e => e.Paymenttype2).IsUnicode(false);

                entity.Property(e => e.Pickupaddress).IsUnicode(false);

                entity.Property(e => e.Pickuplocation).IsUnicode(false);

                entity.Property(e => e.Pickupmessage).IsUnicode(false);

                entity.Property(e => e.Rfidin).IsUnicode(false);

                entity.Property(e => e.Rsstatus).IsUnicode(false);

                entity.Property(e => e.Status).IsUnicode(false);

                entity.Property(e => e.Thirdpartyvendor).IsUnicode(false);

                entity.Property(e => e.Tmpnoshowcar).IsUnicode(false);

                entity.Property(e => e.Tmpnoshowdriver).IsUnicode(false);

                entity.Property(e => e.Tollurl).IsUnicode(false);

                entity.Property(e => e.Tripid).IsUnicode(false);

                entity.Property(e => e.Tritype).IsUnicode(false);

                entity.Property(e => e.Walletname).IsUnicode(false);

                entity.Property(e => e.Wallettransactionid).IsUnicode(false);
            });

            modelBuilder.Entity<Tripdatum>(entity =>
            {
                entity.HasKey(e => e.Tripid)
                    .HasName("TRIPID_IND");

                entity.Property(e => e.Tripid).IsUnicode(false);

                entity.Property(e => e.Bookingtype)
                    .IsUnicode(false)
                    .HasDefaultValueSql("'P2P'");

                entity.Property(e => e.Cabbrand).IsUnicode(false);

                entity.Property(e => e.Cabregistration).IsUnicode(false);

                entity.Property(e => e.Callerid).IsUnicode(false);

                entity.Property(e => e.Cashpaid).HasDefaultValueSql("0");

                entity.Property(e => e.Channel).IsUnicode(false);

                entity.Property(e => e.Corporatecode).IsUnicode(false);

                entity.Property(e => e.Corporatecompanyname).IsUnicode(false);

                entity.Property(e => e.Customeremailid).IsUnicode(false);

                entity.Property(e => e.Customername).IsUnicode(false);

                entity.Property(e => e.Customertoll).HasDefaultValueSql("0");

                entity.Property(e => e.Dropaddress).IsUnicode(false);

                entity.Property(e => e.Droplocation).IsUnicode(false);

                entity.Property(e => e.Dutyslipurl).IsUnicode(false);

                entity.Property(e => e.Empshift).IsUnicode(false);

                entity.Property(e => e.Fromstate).IsUnicode(false);

                entity.Property(e => e.Jobbrand).IsUnicode(false);

                entity.Property(e => e.Jobid).IsUnicode(false);

                entity.Property(e => e.Jobtype).IsUnicode(false);

                entity.Property(e => e.Matchedjobid).IsUnicode(false);

                entity.Property(e => e.Monroetriptype).IsUnicode(false);

                entity.Property(e => e.Packagebasehr).HasDefaultValueSql("0");

                entity.Property(e => e.Packagebasekm).HasDefaultValueSql("0");

                entity.Property(e => e.Paymenttype).IsUnicode(false);

                entity.Property(e => e.Paymenttype2).IsUnicode(false);

                entity.Property(e => e.Pickupaddress).IsUnicode(false);

                entity.Property(e => e.Pickuplocation).IsUnicode(false);

                entity.Property(e => e.Pickupmessage).IsUnicode(false);

                entity.Property(e => e.Rfidin).IsUnicode(false);

                entity.Property(e => e.Rsstatus).IsUnicode(false);

                entity.Property(e => e.Status).IsUnicode(false);

                entity.Property(e => e.Thirdpartyvendor).IsUnicode(false);

                entity.Property(e => e.Tmpnoshowcar).IsUnicode(false);

                entity.Property(e => e.Tmpnoshowdriver).IsUnicode(false);

                entity.Property(e => e.Tollurl).IsUnicode(false);

                entity.Property(e => e.Tripduration).HasDefaultValueSql("0");

                entity.Property(e => e.Tritype).IsUnicode(false);

                entity.Property(e => e.Waittime).HasDefaultValueSql("0");

                entity.Property(e => e.Walletname).IsUnicode(false);

                entity.Property(e => e.Wallettransactionid).IsUnicode(false);
            });

            modelBuilder.Entity<Triprating>(entity =>
            {
                entity.Property(e => e.Bookingreferenceno).IsUnicode(false);

                entity.Property(e => e.Complainttakenuser).IsUnicode(false);

                entity.Property(e => e.Feedbackdetails).IsUnicode(false);

                entity.Property(e => e.Remarks).IsUnicode(false);

                entity.Property(e => e.Statusentityguid).IsUnicode(false);

                entity.Property(e => e.Tripid).IsUnicode(false);
            });

            modelBuilder.Entity<TriprevanueMv>(entity =>
            {
                entity.Property(e => e.BrandName).IsUnicode(false);

                entity.Property(e => e.Carmasterguid).IsUnicode(false);

                entity.Property(e => e.Carregistrationno).IsUnicode(false);

                entity.Property(e => e.CityName).IsUnicode(false);

                entity.Property(e => e.LeName).IsUnicode(false);

                entity.Property(e => e.ModelName).IsUnicode(false);

                entity.Property(e => e.Securitycombinationguid).IsUnicode(false);

                entity.Property(e => e.Serviceproviderguid).IsUnicode(false);

                entity.Property(e => e.Siteguid).IsUnicode(false);
            });

            modelBuilder.Entity<Unitmaster>(entity =>
            {
                entity.Property(e => e.Comments).IsUnicode(false);

                entity.Property(e => e.Description).IsUnicode(false);

                entity.Property(e => e.Disabled).HasPrecision(1);

                entity.Property(e => e.Guid).IsUnicode(false);

                entity.Property(e => e.Name).IsUnicode(false);

                entity.Property(e => e.Objectversionno).HasPrecision(10);

                entity.Property(e => e.Oracleentityid).IsUnicode(false);

                entity.Property(e => e.Oracleentityname).IsUnicode(false);

                entity.Property(e => e.Pkguid).IsUnicode(false);

                entity.Property(e => e.Quickaccesscode).IsUnicode(false);

                entity.Property(e => e.Userarchived).IsUnicode(false);

                entity.Property(e => e.Usercreated).IsUnicode(false);

                entity.Property(e => e.Userdeleted).IsUnicode(false);

                entity.Property(e => e.Userupdated).IsUnicode(false);
            });

            modelBuilder.Entity<UpdatebalanceBaseV>(entity =>
            {
                entity.ToView("UPDATEBALANCE_BASE_V");

                entity.Property(e => e.Siteguid).IsUnicode(false);
            });

            modelBuilder.Entity<UpdatebalanceV>(entity =>
            {
                entity.ToView("UPDATEBALANCE_V");

                entity.Property(e => e.Siteguid).IsUnicode(false);
            });

            modelBuilder.Entity<UpiTxnFundtransfer>(entity =>
            {
                entity.HasKey(e => e.Guid)
                    .HasName("UPI_FUND_TRANSFER_PK");

                entity.Property(e => e.Guid).IsUnicode(false);

                entity.Property(e => e.Bankreferenceno).IsUnicode(false);

                entity.Property(e => e.Comments).IsUnicode(false);

                entity.Property(e => e.Fundtransferrequest).IsUnicode(false);

                entity.Property(e => e.Fundtransferresponse).IsUnicode(false);

                entity.Property(e => e.Fundtransferstatuscode).IsUnicode(false);

                entity.Property(e => e.Getstatusrequest).IsUnicode(false);

                entity.Property(e => e.Getstatusresponse).IsUnicode(false);

                entity.Property(e => e.Getstatusstatuscode).IsUnicode(false);

                entity.Property(e => e.Site).IsUnicode(false);

                entity.Property(e => e.Spid).IsUnicode(false);

                entity.Property(e => e.Substatuscode).IsUnicode(false);

                entity.Property(e => e.Substatustext).IsUnicode(false);

                entity.Property(e => e.Uniquerequestno).IsUnicode(false);

                entity.Property(e => e.Uniqueresponseno).IsUnicode(false);
            });

            modelBuilder.Entity<UpiTxnTable>(entity =>
            {
                entity.HasKey(e => e.Merchanttxnid)
                    .HasName("UPI_TXNID_PK");

                entity.Property(e => e.Merchanttxnid).IsUnicode(false);

                entity.Property(e => e.Apppragatirequest).IsUnicode(false);

                entity.Property(e => e.Apppragatiresponse).IsUnicode(false);

                entity.Property(e => e.Approvalcode).IsUnicode(false);

                entity.Property(e => e.Appupiserverresponse).IsUnicode(false);

                entity.Property(e => e.Banktxnid).IsUnicode(false);

                entity.Property(e => e.Payeraccname).IsUnicode(false);

                entity.Property(e => e.Payeraccountno).IsUnicode(false);

                entity.Property(e => e.Payerifsc).IsUnicode(false);

                entity.Property(e => e.Pragatistatus).IsUnicode(false);

                entity.Property(e => e.Responsecode).IsUnicode(false);

                entity.Property(e => e.Schedulerrequest).IsUnicode(false);

                entity.Property(e => e.Schedulerresponse).IsUnicode(false);

                entity.Property(e => e.Site).IsUnicode(false);

                entity.Property(e => e.Source).IsUnicode(false);

                entity.Property(e => e.Spid).IsUnicode(false);

                entity.Property(e => e.Spnpcitxnid).IsUnicode(false);

                entity.Property(e => e.Sppayermobilenumber).IsUnicode(false);

                entity.Property(e => e.Sppayervirtualaddress).IsUnicode(false);

                entity.Property(e => e.Spstatus).IsUnicode(false);

                entity.Property(e => e.Spstatusdescription).IsUnicode(false);

                entity.Property(e => e.Sptransactionauthdate).IsUnicode(false);

                entity.Property(e => e.Temprefid).IsUnicode(false);
            });

            modelBuilder.Entity<UpiTxnTableTest>(entity =>
            {
                entity.HasKey(e => e.Merchanttxnid)
                    .HasName("UPI_TXNID_PK_TEST");

                entity.Property(e => e.Merchanttxnid).IsUnicode(false);

                entity.Property(e => e.Apppragatirequest).IsUnicode(false);

                entity.Property(e => e.Apppragatiresponse).IsUnicode(false);

                entity.Property(e => e.Approvalcode).IsUnicode(false);

                entity.Property(e => e.Appupiserverresponse).IsUnicode(false);

                entity.Property(e => e.Banktxnid).IsUnicode(false);

                entity.Property(e => e.Payeraccname).IsUnicode(false);

                entity.Property(e => e.Payeraccountno).IsUnicode(false);

                entity.Property(e => e.Payerifsc).IsUnicode(false);

                entity.Property(e => e.Pragatistatus).IsUnicode(false);

                entity.Property(e => e.Responsecode).IsUnicode(false);

                entity.Property(e => e.Schedulerrequest).IsUnicode(false);

                entity.Property(e => e.Schedulerresponse).IsUnicode(false);

                entity.Property(e => e.Site).IsUnicode(false);

                entity.Property(e => e.Source).IsUnicode(false);

                entity.Property(e => e.Spid).IsUnicode(false);

                entity.Property(e => e.Spnpcitxnid).IsUnicode(false);

                entity.Property(e => e.Sppayermobilenumber).IsUnicode(false);

                entity.Property(e => e.Sppayervirtualaddress).IsUnicode(false);

                entity.Property(e => e.Spstatus).IsUnicode(false);

                entity.Property(e => e.Spstatusdescription).IsUnicode(false);

                entity.Property(e => e.Sptransactionauthdate).IsUnicode(false);

                entity.Property(e => e.Temprefid).IsUnicode(false);
            });

            modelBuilder.Entity<UserBaseV>(entity =>
            {
                entity.ToView("USER_BASE_V");

                entity.Property(e => e.EmailAddress).IsUnicode(false);

                entity.Property(e => e.EmployeeId)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.FullName).IsUnicode(false);

                entity.Property(e => e.Loginfullname).IsUnicode(false);

                entity.Property(e => e.UserId)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.UserName).IsUnicode(false);

                entity.Property(e => e.UserPkguid).IsUnicode(false);

                entity.Property(e => e.Useremail).IsUnicode(false);

                entity.Property(e => e.Userguid).IsUnicode(false);
            });

            modelBuilder.Entity<UserJobPositionV>(entity =>
            {
                entity.ToView("USER_JOB_POSITION_V");

                entity.Property(e => e.BranchCode).IsUnicode(false);

                entity.Property(e => e.BranchGuid).IsUnicode(false);

                entity.Property(e => e.BranchName).IsUnicode(false);

                entity.Property(e => e.Email).IsUnicode(false);

                entity.Property(e => e.EmailAddress).IsUnicode(false);

                entity.Property(e => e.EmployeeId)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.EmployeeNumber)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.FullName).IsUnicode(false);

                entity.Property(e => e.GlSegment1).IsUnicode(false);

                entity.Property(e => e.Id)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.JobId)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.JobName)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.LeCode).IsUnicode(false);

                entity.Property(e => e.LeGuid).IsUnicode(false);

                entity.Property(e => e.LeName).IsUnicode(false);

                entity.Property(e => e.LebObjVerNo).HasPrecision(10);

                entity.Property(e => e.LebranchGuid).IsUnicode(false);

                entity.Property(e => e.LoginFullname).IsUnicode(false);

                entity.Property(e => e.NpwNumber)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.OrgId).HasPrecision(4);

                entity.Property(e => e.OrganizationId)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.PersonFullName).IsUnicode(false);

                entity.Property(e => e.PersonType)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.PositionId)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.PositionName)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.UserId)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.UserName).IsUnicode(false);

                entity.Property(e => e.UserPkguid).IsUnicode(false);

                entity.Property(e => e.Userguid).IsUnicode(false);
            });

            modelBuilder.Entity<UserPositionV>(entity =>
            {
                entity.ToView("USER_POSITION_V");

                entity.Property(e => e.BranchCode).IsUnicode(false);

                entity.Property(e => e.BranchGuid).IsUnicode(false);

                entity.Property(e => e.BranchName).IsUnicode(false);

                entity.Property(e => e.Email).IsUnicode(false);

                entity.Property(e => e.EmailAddress).IsUnicode(false);

                entity.Property(e => e.EmployeeId)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.EmployeeNumber)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.FullName).IsUnicode(false);

                entity.Property(e => e.GlSegment1).IsUnicode(false);

                entity.Property(e => e.Id)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.JobId)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.JobName)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.LeCode).IsUnicode(false);

                entity.Property(e => e.LeGuid).IsUnicode(false);

                entity.Property(e => e.LeName).IsUnicode(false);

                entity.Property(e => e.LebObjVerNo).HasPrecision(10);

                entity.Property(e => e.LebranchGuid).IsUnicode(false);

                entity.Property(e => e.LoginFullname).IsUnicode(false);

                entity.Property(e => e.NpwNumber)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.OrgId).HasPrecision(4);

                entity.Property(e => e.OrganizationId)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.PersonFullName).IsUnicode(false);

                entity.Property(e => e.PersonType)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.PositionId)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.PositionName)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.UserId)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.UserName).IsUnicode(false);

                entity.Property(e => e.UserPkguid).IsUnicode(false);

                entity.Property(e => e.Userguid).IsUnicode(false);
            });

            modelBuilder.Entity<UserV>(entity =>
            {
                entity.ToView("USER_V");

                entity.Property(e => e.EmailAddress).IsUnicode(false);

                entity.Property(e => e.EmployeeId)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.FullName).IsUnicode(false);

                entity.Property(e => e.Loginfullname).IsUnicode(false);

                entity.Property(e => e.UserId)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.UserName).IsUnicode(false);

                entity.Property(e => e.UserPkguid).IsUnicode(false);

                entity.Property(e => e.Useremail).IsUnicode(false);

                entity.Property(e => e.Userguid).IsUnicode(false);
            });

            modelBuilder.Entity<UserassignedroleV>(entity =>
            {
                entity.ToView("USERASSIGNEDROLE_V");

                entity.Property(e => e.Disabled).HasPrecision(1);

                entity.Property(e => e.Guid).IsUnicode(false);

                entity.Property(e => e.Name).IsUnicode(false);

                entity.Property(e => e.Securitycombinationguid).IsUnicode(false);

                entity.Property(e => e.Usermasterguid).IsUnicode(false);

                entity.Property(e => e.Userroleguid).IsUnicode(false);
            });

            modelBuilder.Entity<Usercity>(entity =>
            {
                entity.Property(e => e.Cityguid)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Comments).IsUnicode(false);

                entity.Property(e => e.Description).IsUnicode(false);

                entity.Property(e => e.Disabled).HasPrecision(1);

                entity.Property(e => e.Guid)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Name).IsUnicode(false);

                entity.Property(e => e.Objectversionno)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Oracleentityid)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Oracleentityname)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Pkguid).IsUnicode(false);

                entity.Property(e => e.Quickaccesscode).IsUnicode(false);

                entity.Property(e => e.Userarchived)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Usercreated)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Userdeleted)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Userroleguid)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Userupdated)
                    .IsUnicode(false)
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<Userlocalisation>(entity =>
            {
                entity.Property(e => e.Comments).IsUnicode(false);

                entity.Property(e => e.Description).IsUnicode(false);

                entity.Property(e => e.Disabled).HasPrecision(1);

                entity.Property(e => e.Guid).IsUnicode(false);

                entity.Property(e => e.Name).IsUnicode(false);

                entity.Property(e => e.Objectversionno).HasPrecision(10);

                entity.Property(e => e.Oracleentityid).IsUnicode(false);

                entity.Property(e => e.Oracleentityname).IsUnicode(false);

                entity.Property(e => e.Pkguid).IsUnicode(false);

                entity.Property(e => e.Quickaccesscode).IsUnicode(false);

                entity.Property(e => e.Systemlocalisationguid).IsUnicode(false);

                entity.Property(e => e.Userarchived).IsUnicode(false);

                entity.Property(e => e.Usercreated).IsUnicode(false);

                entity.Property(e => e.Userdeleted).IsUnicode(false);

                entity.Property(e => e.Usermasterguid).IsUnicode(false);

                entity.Property(e => e.Userupdated).IsUnicode(false);

                entity.Property(e => e.Value).IsUnicode(false);
            });

            modelBuilder.Entity<Usermaster>(entity =>
            {
                entity.Property(e => e.Allowdomainlogin).IsUnicode(false);

                entity.Property(e => e.City).IsUnicode(false);

                entity.Property(e => e.Contactnumber).IsUnicode(false);

                entity.Property(e => e.Culture).IsUnicode(false);

                entity.Property(e => e.Disabled).HasPrecision(1);

                entity.Property(e => e.Domainloginname).IsUnicode(false);

                entity.Property(e => e.Email).IsUnicode(false);

                entity.Property(e => e.Failedloginattempts).IsUnicode(false);

                entity.Property(e => e.Firstname).IsUnicode(false);

                entity.Property(e => e.Guid).IsUnicode(false);

                entity.Property(e => e.Lastname).IsUnicode(false);

                entity.Property(e => e.Loginattempts).IsUnicode(false);

                entity.Property(e => e.Objectversionno).HasPrecision(10);

                entity.Property(e => e.Oracleentityid).IsUnicode(false);

                entity.Property(e => e.Oracleentityname).IsUnicode(false);

                entity.Property(e => e.Oracleuserid).IsUnicode(false);

                entity.Property(e => e.Pkguid).IsUnicode(false);

                entity.Property(e => e.State).IsUnicode(false);

                entity.Property(e => e.Theme).IsUnicode(false);

                entity.Property(e => e.Userarchived).IsUnicode(false);

                entity.Property(e => e.Usercreated).IsUnicode(false);

                entity.Property(e => e.Userdeleted).IsUnicode(false);

                entity.Property(e => e.Userupdated).IsUnicode(false);
            });

            modelBuilder.Entity<Userpassword>(entity =>
            {
                entity.Property(e => e.Disabled).HasPrecision(1);

                entity.Property(e => e.Guid).IsUnicode(false);

                entity.Property(e => e.Objectversionno).HasPrecision(3);

                entity.Property(e => e.Oracleentityid).IsUnicode(false);

                entity.Property(e => e.Oracleentityname).IsUnicode(false);

                entity.Property(e => e.Password).IsUnicode(false);

                entity.Property(e => e.Pkguid).IsUnicode(false);

                entity.Property(e => e.Userarchived).IsUnicode(false);

                entity.Property(e => e.Usercreated).IsUnicode(false);

                entity.Property(e => e.Userdeleted).IsUnicode(false);

                entity.Property(e => e.Usermasterguid).IsUnicode(false);

                entity.Property(e => e.Userupdated).IsUnicode(false);
            });

            modelBuilder.Entity<Userrole>(entity =>
            {
                entity.Property(e => e.Comments).IsUnicode(false);

                entity.Property(e => e.Description).IsUnicode(false);

                entity.Property(e => e.Disabled).HasPrecision(1);

                entity.Property(e => e.Guid).IsUnicode(false);

                entity.Property(e => e.Isdefault).IsUnicode(false);

                entity.Property(e => e.Name).IsUnicode(false);

                entity.Property(e => e.Objectversionno).HasPrecision(10);

                entity.Property(e => e.Oracleentityid).IsUnicode(false);

                entity.Property(e => e.Oracleentityname).IsUnicode(false);

                entity.Property(e => e.Pkguid).IsUnicode(false);

                entity.Property(e => e.Quickaccesscode).IsUnicode(false);

                entity.Property(e => e.Rolemasterguid).IsUnicode(false);

                entity.Property(e => e.Userarchived).IsUnicode(false);

                entity.Property(e => e.Usercreated).IsUnicode(false);

                entity.Property(e => e.Userdeleted).IsUnicode(false);

                entity.Property(e => e.Usermasterguid).IsUnicode(false);

                entity.Property(e => e.Userupdated).IsUnicode(false);
            });

            modelBuilder.Entity<Userroleexclusion>(entity =>
            {
                entity.Property(e => e.Applicationpageactionguid).IsUnicode(false);

                entity.Property(e => e.Comments).IsUnicode(false);

                entity.Property(e => e.Description).IsUnicode(false);

                entity.Property(e => e.Disabled).HasPrecision(1);

                entity.Property(e => e.Guid).IsUnicode(false);

                entity.Property(e => e.Menuguid).IsUnicode(false);

                entity.Property(e => e.Name).IsUnicode(false);

                entity.Property(e => e.Objectversionno).HasPrecision(10);

                entity.Property(e => e.Oracleentityid).IsUnicode(false);

                entity.Property(e => e.Oracleentityname).IsUnicode(false);

                entity.Property(e => e.Pkguid).IsUnicode(false);

                entity.Property(e => e.Quickaccesscode).IsUnicode(false);

                entity.Property(e => e.Userarchived).IsUnicode(false);

                entity.Property(e => e.Usercreated).IsUnicode(false);

                entity.Property(e => e.Userdeleted).IsUnicode(false);

                entity.Property(e => e.Userroleguid).IsUnicode(false);

                entity.Property(e => e.Userupdated).IsUnicode(false);
            });

            modelBuilder.Entity<UserrolesecurityV>(entity =>
            {
                entity.ToView("USERROLESECURITY_V");

                entity.Property(e => e.Loginname).IsUnicode(false);

                entity.Property(e => e.Rolemasterguid).IsUnicode(false);

                entity.Property(e => e.Rolename).IsUnicode(false);

                entity.Property(e => e.Securitycode).IsUnicode(false);

                entity.Property(e => e.Securitycombinationguid).IsUnicode(false);

                entity.Property(e => e.Usermasterguid).IsUnicode(false);
            });

            modelBuilder.Entity<Usersetting>(entity =>
            {
                entity.HasKey(e => e.Guid)
                    .HasName("PK_USERSETTINGGUID");

                entity.Property(e => e.Guid).IsUnicode(false);

                entity.Property(e => e.Comments).IsUnicode(false);

                entity.Property(e => e.Description).IsUnicode(false);

                entity.Property(e => e.Disabled).HasPrecision(1);

                entity.Property(e => e.Name).IsUnicode(false);

                entity.Property(e => e.Objectversionno).HasPrecision(10);

                entity.Property(e => e.Oracleentityid).IsUnicode(false);

                entity.Property(e => e.Oracleentityname).IsUnicode(false);

                entity.Property(e => e.Pkguid).IsUnicode(false);

                entity.Property(e => e.Quickaccesscode).IsUnicode(false);

                entity.Property(e => e.Systemsettingguid).IsUnicode(false);

                entity.Property(e => e.Userarchived).IsUnicode(false);

                entity.Property(e => e.Usercreated).IsUnicode(false);

                entity.Property(e => e.Userdeleted).IsUnicode(false);

                entity.Property(e => e.Usermasterguid).IsUnicode(false);

                entity.Property(e => e.Userupdated).IsUnicode(false);

                entity.Property(e => e.Value).IsUnicode(false);
            });

            modelBuilder.Entity<VBalancerefund>(entity =>
            {
                entity.ToView("V_BALANCEREFUND");

                entity.Property(e => e.Siteguid).IsUnicode(false);
            });

            modelBuilder.Entity<VehicleType>(entity =>
            {
                entity.Property(e => e.Guid).IsUnicode(false);

                entity.Property(e => e.Name).IsUnicode(false);
            });

            modelBuilder.Entity<View1>(entity =>
            {
                entity.ToView("VIEW1");

                entity.Property(e => e.FullName).IsUnicode(false);

                entity.Property(e => e.Guid).IsUnicode(false);

                entity.Property(e => e.PositionName).IsUnicode(false);
            });

            modelBuilder.Entity<View10>(entity =>
            {
                entity.ToView("VIEW10");

                entity.Property(e => e.AddrTypeCode).IsUnicode(false);

                entity.Property(e => e.AddrTypeName).IsUnicode(false);

                entity.Property(e => e.Addressguid).IsUnicode(false);

                entity.Property(e => e.Billsiteuseid).IsUnicode(false);

                entity.Property(e => e.BrandCode).IsUnicode(false);

                entity.Property(e => e.BrandGuid).IsUnicode(false);

                entity.Property(e => e.BrandName).IsUnicode(false);

                entity.Property(e => e.Carmasterguid).IsUnicode(false);

                entity.Property(e => e.CityCode).IsUnicode(false);

                entity.Property(e => e.CityGuid).IsUnicode(false);

                entity.Property(e => e.CityName).IsUnicode(false);

                entity.Property(e => e.CustId).IsUnicode(false);

                entity.Property(e => e.Disabled).HasPrecision(1);

                entity.Property(e => e.Driverflag).HasPrecision(1);

                entity.Property(e => e.Dseflag).HasPrecision(1);

                entity.Property(e => e.EntityCode).IsUnicode(false);

                entity.Property(e => e.FullAddress).IsUnicode(false);

                entity.Property(e => e.GlSegment1).IsUnicode(false);

                entity.Property(e => e.GlSement4).IsUnicode(false);

                entity.Property(e => e.GlSement6).IsUnicode(false);

                entity.Property(e => e.LeCode).IsUnicode(false);

                entity.Property(e => e.LeGuid).IsUnicode(false);

                entity.Property(e => e.LeName).IsUnicode(false);

                entity.Property(e => e.LebranchGuid).IsUnicode(false);

                entity.Property(e => e.Lebranchsecurityguid).IsUnicode(false);

                entity.Property(e => e.ModelCode).IsUnicode(false);

                entity.Property(e => e.ModelGuid).IsUnicode(false);

                entity.Property(e => e.ModelName).IsUnicode(false);

                entity.Property(e => e.Objectversionno).HasPrecision(10);

                entity.Property(e => e.Oracleentityid).IsUnicode(false);

                entity.Property(e => e.Oracleentityname).IsUnicode(false);

                entity.Property(e => e.OrgId).HasPrecision(4);

                entity.Property(e => e.PersStatus).IsUnicode(false);

                entity.Property(e => e.Personguid).IsUnicode(false);

                entity.Property(e => e.Pkguid).IsUnicode(false);

                entity.Property(e => e.SecObjVerNo).HasPrecision(10);

                entity.Property(e => e.Securitycombinationguid).IsUnicode(false);

                entity.Property(e => e.Siteguid).IsUnicode(false);

                entity.Property(e => e.Sitename).IsUnicode(false);

                entity.Property(e => e.SitetypeDescription).IsUnicode(false);

                entity.Property(e => e.SitetypeDisabled).HasPrecision(1);

                entity.Property(e => e.SitetypeName).IsUnicode(false);

                entity.Property(e => e.SitetypeObjectversionno).HasPrecision(3);

                entity.Property(e => e.SitetypeOracleentityid).IsUnicode(false);

                entity.Property(e => e.SitetypeOracleentityname).IsUnicode(false);

                entity.Property(e => e.SitetypePkguid).IsUnicode(false);

                entity.Property(e => e.SitetypeQuickaccesscode).IsUnicode(false);

                entity.Property(e => e.Sitetypemasterguid).IsUnicode(false);

                entity.Property(e => e.SpBioid).IsUnicode(false);

                entity.Property(e => e.SpFname).IsUnicode(false);

                entity.Property(e => e.SpLname).IsUnicode(false);

                entity.Property(e => e.SpMname).IsUnicode(false);

                entity.Property(e => e.SpObjVerNo).HasPrecision(10);

                entity.Property(e => e.SpPkguid).IsUnicode(false);

                entity.Property(e => e.SpStatus).IsUnicode(false);

                entity.Property(e => e.Spflag).HasPrecision(1);

                entity.Property(e => e.Spguid).IsUnicode(false);

                entity.Property(e => e.Spid).IsUnicode(false);

                entity.Property(e => e.StatusCode).IsUnicode(false);

                entity.Property(e => e.StatusDesc).IsUnicode(false);

                entity.Property(e => e.StatusEntEntguid).IsUnicode(false);

                entity.Property(e => e.StatusEntObjVerNo).HasPrecision(10);

                entity.Property(e => e.StatusEntStsguid).IsUnicode(false);

                entity.Property(e => e.StatusName).IsUnicode(false);

                entity.Property(e => e.Statusentityguid).IsUnicode(false);
            });

            modelBuilder.Entity<View11>(entity =>
            {
                entity.ToView("VIEW11");

                entity.Property(e => e.BrandName).IsUnicode(false);

                entity.Property(e => e.CityName).IsUnicode(false);

                entity.Property(e => e.Comments).IsUnicode(false);

                entity.Property(e => e.LegalentityName).IsUnicode(false);

                entity.Property(e => e.ModelName).IsUnicode(false);

                entity.Property(e => e.SecGuid).IsUnicode(false);

                entity.Property(e => e.ServiceproviderId).IsUnicode(false);

                entity.Property(e => e.ServiceproviderName).IsUnicode(false);

                entity.Property(e => e.Showninstatement).IsUnicode(false);

                entity.Property(e => e.SiteName).IsUnicode(false);

                entity.Property(e => e.SubType).IsUnicode(false);

                entity.Property(e => e.TransactionNo).IsUnicode(false);

                entity.Property(e => e.TransactionStatus).IsUnicode(false);

                entity.Property(e => e.TransactionType).IsUnicode(false);

                entity.Property(e => e.TripId).IsUnicode(false);

                entity.Property(e => e.UserName).IsUnicode(false);
            });

            modelBuilder.Entity<View12>(entity =>
            {
                entity.ToView("VIEW12");

                entity.Property(e => e.Carmasterguid).IsUnicode(false);
            });

            modelBuilder.Entity<View13>(entity =>
            {
                entity.ToView("VIEW13");

                entity.Property(e => e.Bookingtype).IsUnicode(false);

                entity.Property(e => e.Cabbrand).IsUnicode(false);

                entity.Property(e => e.Cabregistration).IsUnicode(false);

                entity.Property(e => e.Carmasterguid).IsUnicode(false);

                entity.Property(e => e.Carregistrationno).IsUnicode(false);

                entity.Property(e => e.Channel).IsUnicode(false);

                entity.Property(e => e.Corporatecompanyname).IsUnicode(false);

                entity.Property(e => e.Customeremailid).IsUnicode(false);

                entity.Property(e => e.Customername).IsUnicode(false);

                entity.Property(e => e.Drivermasterguid).IsUnicode(false);

                entity.Property(e => e.Dropaddress).IsUnicode(false);

                entity.Property(e => e.Droplocation).IsUnicode(false);

                entity.Property(e => e.Fromstate).IsUnicode(false);

                entity.Property(e => e.Jobbrand).IsUnicode(false);

                entity.Property(e => e.Jobid).IsUnicode(false);

                entity.Property(e => e.Jobtype).IsUnicode(false);

                entity.Property(e => e.Matchedjobid).IsUnicode(false);

                entity.Property(e => e.Paymenttype).IsUnicode(false);

                entity.Property(e => e.Paymenttype2).IsUnicode(false);

                entity.Property(e => e.Pickupaddress).IsUnicode(false);

                entity.Property(e => e.Pickuplocation).IsUnicode(false);

                entity.Property(e => e.Rfidin).IsUnicode(false);

                entity.Property(e => e.Securitycombinationguid).IsUnicode(false);

                entity.Property(e => e.Serviceproviderguid).IsUnicode(false);

                entity.Property(e => e.Siteguid).IsUnicode(false);

                entity.Property(e => e.Status).IsUnicode(false);

                entity.Property(e => e.Tmpnoshowcar).IsUnicode(false);

                entity.Property(e => e.Tmpnoshowdriver).IsUnicode(false);

                entity.Property(e => e.TripGuid).IsUnicode(false);

                entity.Property(e => e.Tripid).IsUnicode(false);

                entity.Property(e => e.Tritype).IsUnicode(false);
            });

            modelBuilder.Entity<View14>(entity =>
            {
                entity.ToView("VIEW14");

                entity.Property(e => e.Bookingtype).IsUnicode(false);

                entity.Property(e => e.Cabbrand).IsUnicode(false);

                entity.Property(e => e.Cabregistration).IsUnicode(false);

                entity.Property(e => e.Carmasterguid).IsUnicode(false);

                entity.Property(e => e.Carregistrationno).IsUnicode(false);

                entity.Property(e => e.Channel).IsUnicode(false);

                entity.Property(e => e.Corporatecompanyname).IsUnicode(false);

                entity.Property(e => e.Customeremailid).IsUnicode(false);

                entity.Property(e => e.Customername).IsUnicode(false);

                entity.Property(e => e.Drivermasterguid).IsUnicode(false);

                entity.Property(e => e.Dropaddress).IsUnicode(false);

                entity.Property(e => e.Droplocation).IsUnicode(false);

                entity.Property(e => e.Fromstate).IsUnicode(false);

                entity.Property(e => e.Jobbrand).IsUnicode(false);

                entity.Property(e => e.Jobid).IsUnicode(false);

                entity.Property(e => e.Jobtype).IsUnicode(false);

                entity.Property(e => e.Matchedjobid).IsUnicode(false);

                entity.Property(e => e.Paymenttype).IsUnicode(false);

                entity.Property(e => e.Paymenttype2).IsUnicode(false);

                entity.Property(e => e.Pickupaddress).IsUnicode(false);

                entity.Property(e => e.Pickuplocation).IsUnicode(false);

                entity.Property(e => e.Rfidin).IsUnicode(false);

                entity.Property(e => e.Securitycombinationguid).IsUnicode(false);

                entity.Property(e => e.Serviceproviderguid).IsUnicode(false);

                entity.Property(e => e.Siteguid).IsUnicode(false);

                entity.Property(e => e.Status).IsUnicode(false);

                entity.Property(e => e.Tmpnoshowcar).IsUnicode(false);

                entity.Property(e => e.Tmpnoshowdriver).IsUnicode(false);

                entity.Property(e => e.TripGuid).IsUnicode(false);

                entity.Property(e => e.Tripid).IsUnicode(false);

                entity.Property(e => e.Tritype).IsUnicode(false);
            });

            modelBuilder.Entity<View15>(entity =>
            {
                entity.ToView("VIEW15");

                entity.Property(e => e.Bookingtype).IsUnicode(false);

                entity.Property(e => e.Cabbrand).IsUnicode(false);

                entity.Property(e => e.Cabregistration).IsUnicode(false);

                entity.Property(e => e.Carmasterguid).IsUnicode(false);

                entity.Property(e => e.Carregistrationno).IsUnicode(false);

                entity.Property(e => e.Channel).IsUnicode(false);

                entity.Property(e => e.Corporatecompanyname).IsUnicode(false);

                entity.Property(e => e.Customeremailid).IsUnicode(false);

                entity.Property(e => e.Customername).IsUnicode(false);

                entity.Property(e => e.Drivermasterguid).IsUnicode(false);

                entity.Property(e => e.Dropaddress).IsUnicode(false);

                entity.Property(e => e.Droplocation).IsUnicode(false);

                entity.Property(e => e.Fromstate).IsUnicode(false);

                entity.Property(e => e.Jobbrand).IsUnicode(false);

                entity.Property(e => e.Jobid).IsUnicode(false);

                entity.Property(e => e.Jobtype).IsUnicode(false);

                entity.Property(e => e.Matchedjobid).IsUnicode(false);

                entity.Property(e => e.Paymenttype).IsUnicode(false);

                entity.Property(e => e.Paymenttype2).IsUnicode(false);

                entity.Property(e => e.Pickupaddress).IsUnicode(false);

                entity.Property(e => e.Pickuplocation).IsUnicode(false);

                entity.Property(e => e.Rfidin).IsUnicode(false);

                entity.Property(e => e.Securitycombinationguid).IsUnicode(false);

                entity.Property(e => e.Serviceproviderguid).IsUnicode(false);

                entity.Property(e => e.Siteguid).IsUnicode(false);

                entity.Property(e => e.Status).IsUnicode(false);

                entity.Property(e => e.Tmpnoshowcar).IsUnicode(false);

                entity.Property(e => e.Tmpnoshowdriver).IsUnicode(false);

                entity.Property(e => e.TripGuid).IsUnicode(false);

                entity.Property(e => e.Tripid).IsUnicode(false);

                entity.Property(e => e.Tritype).IsUnicode(false);
            });

            modelBuilder.Entity<View16>(entity =>
            {
                entity.ToView("VIEW16");

                entity.Property(e => e.Bookingtype).IsUnicode(false);

                entity.Property(e => e.Cabbrand).IsUnicode(false);

                entity.Property(e => e.Cabregistration).IsUnicode(false);

                entity.Property(e => e.Carmasterguid).IsUnicode(false);

                entity.Property(e => e.Carregistrationno).IsUnicode(false);

                entity.Property(e => e.Channel).IsUnicode(false);

                entity.Property(e => e.Corporatecompanyname).IsUnicode(false);

                entity.Property(e => e.Customeremailid).IsUnicode(false);

                entity.Property(e => e.Customername).IsUnicode(false);

                entity.Property(e => e.Drivermasterguid).IsUnicode(false);

                entity.Property(e => e.Dropaddress).IsUnicode(false);

                entity.Property(e => e.Droplocation).IsUnicode(false);

                entity.Property(e => e.Fromstate).IsUnicode(false);

                entity.Property(e => e.Jobbrand).IsUnicode(false);

                entity.Property(e => e.Jobid).IsUnicode(false);

                entity.Property(e => e.Jobtype).IsUnicode(false);

                entity.Property(e => e.Matchedjobid).IsUnicode(false);

                entity.Property(e => e.Paymenttype).IsUnicode(false);

                entity.Property(e => e.Paymenttype2).IsUnicode(false);

                entity.Property(e => e.Pickupaddress).IsUnicode(false);

                entity.Property(e => e.Pickuplocation).IsUnicode(false);

                entity.Property(e => e.Rfidin).IsUnicode(false);

                entity.Property(e => e.Securitycombinationguid).IsUnicode(false);

                entity.Property(e => e.Serviceproviderguid).IsUnicode(false);

                entity.Property(e => e.Siteguid).IsUnicode(false);

                entity.Property(e => e.Status).IsUnicode(false);

                entity.Property(e => e.Tmpnoshowcar).IsUnicode(false);

                entity.Property(e => e.Tmpnoshowdriver).IsUnicode(false);

                entity.Property(e => e.TripGuid).IsUnicode(false);

                entity.Property(e => e.Tripid).IsUnicode(false);

                entity.Property(e => e.Tritype).IsUnicode(false);
            });

            modelBuilder.Entity<View2>(entity =>
            {
                entity.ToView("VIEW2");

                entity.Property(e => e.FullName).IsUnicode(false);

                entity.Property(e => e.Guid).IsUnicode(false);

                entity.Property(e => e.PositionName).IsUnicode(false);
            });

            modelBuilder.Entity<View3>(entity =>
            {
                entity.ToView("VIEW3");

                entity.Property(e => e.EntityCode).IsUnicode(false);

                entity.Property(e => e.StatusCode).IsUnicode(false);

                entity.Property(e => e.StatusDesc).IsUnicode(false);

                entity.Property(e => e.StatusEntEntguid).IsUnicode(false);

                entity.Property(e => e.StatusEntGuid).IsUnicode(false);

                entity.Property(e => e.StatusEntObjVerNo).HasPrecision(10);

                entity.Property(e => e.StatusEntStsguid).IsUnicode(false);

                entity.Property(e => e.StatusName).IsUnicode(false);
            });

            modelBuilder.Entity<View4>(entity =>
            {
                entity.ToView("VIEW4");

                entity.Property(e => e.Carmasterguid).IsUnicode(false);
            });

            modelBuilder.Entity<View5>(entity =>
            {
                entity.ToView("VIEW5");

                entity.Property(e => e.Branchmasterguid).IsUnicode(false);

                entity.Property(e => e.CarBrandCode).IsUnicode(false);

                entity.Property(e => e.CarBrandGuid).IsUnicode(false);

                entity.Property(e => e.CarBrandName).IsUnicode(false);

                entity.Property(e => e.CarBusinesscategoryGuid).IsUnicode(false);

                entity.Property(e => e.CarBusinesscategoryName).IsUnicode(false);

                entity.Property(e => e.CarChassisno).IsUnicode(false);

                entity.Property(e => e.CarCityCode).IsUnicode(false);

                entity.Property(e => e.CarCityGuid).IsUnicode(false);

                entity.Property(e => e.CarCityName).IsUnicode(false);

                entity.Property(e => e.CarColorGuid).IsUnicode(false);

                entity.Property(e => e.CarColorName).IsUnicode(false);

                entity.Property(e => e.CarColorQuickaccesscode).IsUnicode(false);

                entity.Property(e => e.CarDefrredDocCheckFlag).IsUnicode(false);

                entity.Property(e => e.CarGuid).IsUnicode(false);

                entity.Property(e => e.CarGvguid).IsUnicode(false);

                entity.Property(e => e.CarGvname).IsUnicode(false);

                entity.Property(e => e.CarLeBranchGuid).IsUnicode(false);

                entity.Property(e => e.CarLeCode).IsUnicode(false);

                entity.Property(e => e.CarLeName).IsUnicode(false);

                entity.Property(e => e.CarMake).IsUnicode(false);

                entity.Property(e => e.CarMakeCode).IsUnicode(false);

                entity.Property(e => e.CarModel).IsUnicode(false);

                entity.Property(e => e.CarModelGuid).IsUnicode(false);

                entity.Property(e => e.CarModelcode).IsUnicode(false);

                entity.Property(e => e.CarObjVerNo).HasPrecision(3);

                entity.Property(e => e.CarOpModelCode).IsUnicode(false);

                entity.Property(e => e.CarOpModelName).IsUnicode(false);

                entity.Property(e => e.CarOwner).IsUnicode(false);

                entity.Property(e => e.CarOwnerSpStatus).IsUnicode(false);

                entity.Property(e => e.CarOwnerSpid).IsUnicode(false);

                entity.Property(e => e.CarOwnerSpname).IsUnicode(false);

                entity.Property(e => e.CarPkguid).IsUnicode(false);

                entity.Property(e => e.CarRegnNo).IsUnicode(false);

                entity.Property(e => e.CarSecGuid).IsUnicode(false);

                entity.Property(e => e.CarStatusCode).IsUnicode(false);

                entity.Property(e => e.CarStatusName).IsUnicode(false);

                entity.Property(e => e.Engineno).IsUnicode(false);

                entity.Property(e => e.Issendtomonroe).HasPrecision(5);

                entity.Property(e => e.Locationworkshopmasterguid).IsUnicode(false);

                entity.Property(e => e.Lockstatus).IsUnicode(false);

                entity.Property(e => e.OrgId).HasPrecision(4);

                entity.Property(e => e.Poolflag).IsUnicode(false);

                entity.Property(e => e.Readyflag).IsUnicode(false);

                entity.Property(e => e.Rfidflag).HasPrecision(1);

                entity.Property(e => e.SpDefrredDocCheckFlag).IsUnicode(false);

                entity.Property(e => e.SpPersonguid).IsUnicode(false);

                entity.Property(e => e.SpPkguid).IsUnicode(false);

                entity.Property(e => e.Spguid).IsUnicode(false);

                entity.Property(e => e.Workshopcomments).IsUnicode(false);

                entity.Property(e => e.Workshopdescription).IsUnicode(false);

                entity.Property(e => e.Workshopdisabled).HasPrecision(1);

                entity.Property(e => e.Workshoplocationtype).IsUnicode(false);

                entity.Property(e => e.Workshopmasterguid).IsUnicode(false);

                entity.Property(e => e.Workshopname).IsUnicode(false);

                entity.Property(e => e.Workshoppkguid).IsUnicode(false);

                entity.Property(e => e.Workshopquickaccesscode).IsUnicode(false);
            });

            modelBuilder.Entity<View6>(entity =>
            {
                entity.ToView("VIEW6");

                entity.Property(e => e.Branchmasterguid).IsUnicode(false);

                entity.Property(e => e.CarBrandCode).IsUnicode(false);

                entity.Property(e => e.CarBrandGuid).IsUnicode(false);

                entity.Property(e => e.CarBrandName).IsUnicode(false);

                entity.Property(e => e.CarBusinesscategoryGuid).IsUnicode(false);

                entity.Property(e => e.CarBusinesscategoryName).IsUnicode(false);

                entity.Property(e => e.CarChassisno).IsUnicode(false);

                entity.Property(e => e.CarCityCode).IsUnicode(false);

                entity.Property(e => e.CarCityGuid).IsUnicode(false);

                entity.Property(e => e.CarCityName).IsUnicode(false);

                entity.Property(e => e.CarColorGuid).IsUnicode(false);

                entity.Property(e => e.CarColorName).IsUnicode(false);

                entity.Property(e => e.CarColorQuickaccesscode).IsUnicode(false);

                entity.Property(e => e.CarDefrredDocCheckFlag).IsUnicode(false);

                entity.Property(e => e.CarGuid).IsUnicode(false);

                entity.Property(e => e.CarGvguid).IsUnicode(false);

                entity.Property(e => e.CarGvname).IsUnicode(false);

                entity.Property(e => e.CarLeBranchGuid).IsUnicode(false);

                entity.Property(e => e.CarLeCode).IsUnicode(false);

                entity.Property(e => e.CarLeName).IsUnicode(false);

                entity.Property(e => e.CarMake).IsUnicode(false);

                entity.Property(e => e.CarMakeCode).IsUnicode(false);

                entity.Property(e => e.CarModel).IsUnicode(false);

                entity.Property(e => e.CarModelGuid).IsUnicode(false);

                entity.Property(e => e.CarModelcode).IsUnicode(false);

                entity.Property(e => e.CarObjVerNo).HasPrecision(3);

                entity.Property(e => e.CarOpModelCode).IsUnicode(false);

                entity.Property(e => e.CarOpModelName).IsUnicode(false);

                entity.Property(e => e.CarOwner).IsUnicode(false);

                entity.Property(e => e.CarOwnerSpStatus).IsUnicode(false);

                entity.Property(e => e.CarOwnerSpid).IsUnicode(false);

                entity.Property(e => e.CarOwnerSpname).IsUnicode(false);

                entity.Property(e => e.CarPkguid).IsUnicode(false);

                entity.Property(e => e.CarRegnNo).IsUnicode(false);

                entity.Property(e => e.CarSecGuid).IsUnicode(false);

                entity.Property(e => e.CarStatusCode).IsUnicode(false);

                entity.Property(e => e.CarStatusName).IsUnicode(false);

                entity.Property(e => e.Engineno).IsUnicode(false);

                entity.Property(e => e.Issendtomonroe).HasPrecision(5);

                entity.Property(e => e.Locationworkshopmasterguid).IsUnicode(false);

                entity.Property(e => e.Lockstatus).IsUnicode(false);

                entity.Property(e => e.OrgId).HasPrecision(4);

                entity.Property(e => e.Poolflag).IsUnicode(false);

                entity.Property(e => e.Readyflag).IsUnicode(false);

                entity.Property(e => e.Rfidflag).HasPrecision(1);

                entity.Property(e => e.SpDefrredDocCheckFlag).IsUnicode(false);

                entity.Property(e => e.SpPersonguid).IsUnicode(false);

                entity.Property(e => e.SpPkguid).IsUnicode(false);

                entity.Property(e => e.Spguid).IsUnicode(false);

                entity.Property(e => e.Workshopcomments).IsUnicode(false);

                entity.Property(e => e.Workshopdescription).IsUnicode(false);

                entity.Property(e => e.Workshopdisabled).HasPrecision(1);

                entity.Property(e => e.Workshoplocationtype).IsUnicode(false);

                entity.Property(e => e.Workshopmasterguid).IsUnicode(false);

                entity.Property(e => e.Workshopname).IsUnicode(false);

                entity.Property(e => e.Workshoppkguid).IsUnicode(false);

                entity.Property(e => e.Workshopquickaccesscode).IsUnicode(false);
            });

            modelBuilder.Entity<View7>(entity =>
            {
                entity.ToView("VIEW7");

                entity.Property(e => e.Branchmasterguid).IsUnicode(false);

                entity.Property(e => e.CarBrandCode).IsUnicode(false);

                entity.Property(e => e.CarBrandGuid).IsUnicode(false);

                entity.Property(e => e.CarBrandName).IsUnicode(false);

                entity.Property(e => e.CarBusinesscategoryGuid).IsUnicode(false);

                entity.Property(e => e.CarBusinesscategoryName).IsUnicode(false);

                entity.Property(e => e.CarChassisno).IsUnicode(false);

                entity.Property(e => e.CarCityCode).IsUnicode(false);

                entity.Property(e => e.CarCityGuid).IsUnicode(false);

                entity.Property(e => e.CarCityName).IsUnicode(false);

                entity.Property(e => e.CarColorGuid).IsUnicode(false);

                entity.Property(e => e.CarColorName).IsUnicode(false);

                entity.Property(e => e.CarColorQuickaccesscode).IsUnicode(false);

                entity.Property(e => e.CarDefrredDocCheckFlag).IsUnicode(false);

                entity.Property(e => e.CarGuid).IsUnicode(false);

                entity.Property(e => e.CarGvguid).IsUnicode(false);

                entity.Property(e => e.CarGvname).IsUnicode(false);

                entity.Property(e => e.CarLeBranchGuid).IsUnicode(false);

                entity.Property(e => e.CarLeCode).IsUnicode(false);

                entity.Property(e => e.CarLeName).IsUnicode(false);

                entity.Property(e => e.CarMake).IsUnicode(false);

                entity.Property(e => e.CarMakeCode).IsUnicode(false);

                entity.Property(e => e.CarModel).IsUnicode(false);

                entity.Property(e => e.CarModelGuid).IsUnicode(false);

                entity.Property(e => e.CarModelcode).IsUnicode(false);

                entity.Property(e => e.CarObjVerNo).HasPrecision(3);

                entity.Property(e => e.CarOpModelCode).IsUnicode(false);

                entity.Property(e => e.CarOpModelName).IsUnicode(false);

                entity.Property(e => e.CarOwner).IsUnicode(false);

                entity.Property(e => e.CarOwnerSpStatus).IsUnicode(false);

                entity.Property(e => e.CarOwnerSpid).IsUnicode(false);

                entity.Property(e => e.CarOwnerSpname).IsUnicode(false);

                entity.Property(e => e.CarPkguid).IsUnicode(false);

                entity.Property(e => e.CarRegnNo).IsUnicode(false);

                entity.Property(e => e.CarSecGuid).IsUnicode(false);

                entity.Property(e => e.CarStatusCode).IsUnicode(false);

                entity.Property(e => e.CarStatusName).IsUnicode(false);

                entity.Property(e => e.Engineno).IsUnicode(false);

                entity.Property(e => e.Issendtomonroe).HasPrecision(5);

                entity.Property(e => e.Locationworkshopmasterguid).IsUnicode(false);

                entity.Property(e => e.Lockstatus).IsUnicode(false);

                entity.Property(e => e.OrgId).HasPrecision(4);

                entity.Property(e => e.Poolflag).IsUnicode(false);

                entity.Property(e => e.Readyflag).IsUnicode(false);

                entity.Property(e => e.Rfidflag).HasPrecision(1);

                entity.Property(e => e.SpDefrredDocCheckFlag).IsUnicode(false);

                entity.Property(e => e.SpPersonguid).IsUnicode(false);

                entity.Property(e => e.SpPkguid).IsUnicode(false);

                entity.Property(e => e.Spguid).IsUnicode(false);

                entity.Property(e => e.Workshopcomments).IsUnicode(false);

                entity.Property(e => e.Workshopdescription).IsUnicode(false);

                entity.Property(e => e.Workshopdisabled).HasPrecision(1);

                entity.Property(e => e.Workshoplocationtype).IsUnicode(false);

                entity.Property(e => e.Workshopmasterguid).IsUnicode(false);

                entity.Property(e => e.Workshopname).IsUnicode(false);

                entity.Property(e => e.Workshoppkguid).IsUnicode(false);

                entity.Property(e => e.Workshopquickaccesscode).IsUnicode(false);
            });

            modelBuilder.Entity<View8>(entity =>
            {
                entity.ToView("VIEW8");

                entity.Property(e => e.BaseTransactionDate).IsUnicode(false);

                entity.Property(e => e.BusinessPlace).IsUnicode(false);

                entity.Property(e => e.CityCode).IsUnicode(false);

                entity.Property(e => e.Costcenter).IsUnicode(false);

                entity.Property(e => e.Documenttype).IsUnicode(false);

                entity.Property(e => e.GlCode).IsUnicode(false);

                entity.Property(e => e.InernalOrder).IsUnicode(false);

                entity.Property(e => e.Profitcenter).IsUnicode(false);

                entity.Property(e => e.Showinstatement).IsUnicode(false);

                entity.Property(e => e.Total).IsUnicode(false);

                entity.Property(e => e.TransactionClass).IsUnicode(false);

                entity.Property(e => e.TransactionDate).IsUnicode(false);

                entity.Property(e => e.TransactionType).IsUnicode(false);
            });

            modelBuilder.Entity<View9>(entity =>
            {
                entity.ToView("VIEW9");

                entity.Property(e => e.BrandName).IsUnicode(false);

                entity.Property(e => e.CityName).IsUnicode(false);

                entity.Property(e => e.Comments).IsUnicode(false);

                entity.Property(e => e.LegalentityName).IsUnicode(false);

                entity.Property(e => e.ModelName).IsUnicode(false);

                entity.Property(e => e.SecGuid).IsUnicode(false);

                entity.Property(e => e.ServiceproviderId).IsUnicode(false);

                entity.Property(e => e.ServiceproviderName).IsUnicode(false);

                entity.Property(e => e.Showninstatement).IsUnicode(false);

                entity.Property(e => e.SiteName).IsUnicode(false);

                entity.Property(e => e.SubType).IsUnicode(false);

                entity.Property(e => e.TransactionNo).IsUnicode(false);

                entity.Property(e => e.TransactionStatus).IsUnicode(false);

                entity.Property(e => e.TransactionType).IsUnicode(false);

                entity.Property(e => e.TripId).IsUnicode(false);

                entity.Property(e => e.UserName).IsUnicode(false);
            });

            modelBuilder.Entity<WorkrequestBaseV>(entity =>
            {
                entity.ToView("WORKREQUEST_BASE_V");

                entity.Property(e => e.CarBrandCode).IsUnicode(false);

                entity.Property(e => e.CarBrandName).IsUnicode(false);

                entity.Property(e => e.CarChassisno).IsUnicode(false);

                entity.Property(e => e.CarCityCode).IsUnicode(false);

                entity.Property(e => e.CarCityName).IsUnicode(false);

                entity.Property(e => e.CarDefrredDocCheckFlag).IsUnicode(false);

                entity.Property(e => e.CarGvguid).IsUnicode(false);

                entity.Property(e => e.CarGvname).IsUnicode(false);

                entity.Property(e => e.CarLeBranchGuid).IsUnicode(false);

                entity.Property(e => e.CarLeCode).IsUnicode(false);

                entity.Property(e => e.CarLeName).IsUnicode(false);

                entity.Property(e => e.CarMake).IsUnicode(false);

                entity.Property(e => e.CarMakeCode).IsUnicode(false);

                entity.Property(e => e.CarModel).IsUnicode(false);

                entity.Property(e => e.CarModelcode).IsUnicode(false);

                entity.Property(e => e.CarObjVerNo).HasPrecision(3);

                entity.Property(e => e.CarOpModelCode).IsUnicode(false);

                entity.Property(e => e.CarOpModelName).IsUnicode(false);

                entity.Property(e => e.CarOwner).IsUnicode(false);

                entity.Property(e => e.CarOwnerSpStatus).IsUnicode(false);

                entity.Property(e => e.CarOwnerSpid).IsUnicode(false);

                entity.Property(e => e.CarOwnerSpname).IsUnicode(false);

                entity.Property(e => e.CarPkguid).IsUnicode(false);

                entity.Property(e => e.CarRegnNo).IsUnicode(false);

                entity.Property(e => e.CarSecGuid).IsUnicode(false);

                entity.Property(e => e.CarStatusCode).IsUnicode(false);

                entity.Property(e => e.CarStatusName).IsUnicode(false);

                entity.Property(e => e.Carguid).IsUnicode(false);

                entity.Property(e => e.Odometerreading).IsUnicode(false);

                entity.Property(e => e.Qcchecklistno).IsUnicode(false);

                entity.Property(e => e.Remarks).IsUnicode(false);

                entity.Property(e => e.RequestEntityCode).IsUnicode(false);

                entity.Property(e => e.RequestStatusCode).IsUnicode(false);

                entity.Property(e => e.RequestStatusDesc).IsUnicode(false);

                entity.Property(e => e.RequestStatusEntEntguid).IsUnicode(false);

                entity.Property(e => e.RequestStatusEntObjVerNo).HasPrecision(10);

                entity.Property(e => e.RequestStatusEntStsguid).IsUnicode(false);

                entity.Property(e => e.RequestStatusName).IsUnicode(false);

                entity.Property(e => e.Rono).IsUnicode(false);

                entity.Property(e => e.SpDefrredDocCheckFlag).IsUnicode(false);

                entity.Property(e => e.SpPkguid).IsUnicode(false);

                entity.Property(e => e.Spguid).IsUnicode(false);

                entity.Property(e => e.WorkrequestObjectversionno).HasPrecision(3);

                entity.Property(e => e.WorkrequestOracleentityid).IsUnicode(false);

                entity.Property(e => e.WorkrequestOracleentityname).IsUnicode(false);

                entity.Property(e => e.WorkrequestOracleentitytype).IsUnicode(false);

                entity.Property(e => e.WorkrequestPkguid).IsUnicode(false);

                entity.Property(e => e.WorkrequestStatusentityguid).IsUnicode(false);

                entity.Property(e => e.Workrequestmasterguid).IsUnicode(false);

                entity.Property(e => e.Workrequestno).IsUnicode(false);

                entity.Property(e => e.Workshopbranchmasterguid).IsUnicode(false);

                entity.Property(e => e.Workshopcomments).IsUnicode(false);

                entity.Property(e => e.Workshopdescription).IsUnicode(false);

                entity.Property(e => e.Workshopdisabled).HasPrecision(1);

                entity.Property(e => e.Workshopguid).IsUnicode(false);

                entity.Property(e => e.Workshopname).IsUnicode(false);

                entity.Property(e => e.Workshopobjectversionno).HasPrecision(10);

                entity.Property(e => e.Workshoporacleentityid).IsUnicode(false);

                entity.Property(e => e.Workshoporacleentityname).IsUnicode(false);

                entity.Property(e => e.Workshoppkguid).IsUnicode(false);

                entity.Property(e => e.Workshopquickaccesscode).IsUnicode(false);

                entity.Property(e => e.Worktypecomments).IsUnicode(false);

                entity.Property(e => e.Worktypedescription).IsUnicode(false);

                entity.Property(e => e.Worktypedisabled).HasPrecision(1);

                entity.Property(e => e.Worktypeguid).IsUnicode(false);

                entity.Property(e => e.Worktypename).IsUnicode(false);

                entity.Property(e => e.Worktypeobjectversionno).HasPrecision(4);

                entity.Property(e => e.Worktypeoracleentityid).IsUnicode(false);

                entity.Property(e => e.Worktypeoracleentityname).IsUnicode(false);

                entity.Property(e => e.Worktypepkguid).IsUnicode(false);

                entity.Property(e => e.Worktypequickaccesscode).IsUnicode(false);
            });

            modelBuilder.Entity<WorkrequestV>(entity =>
            {
                entity.ToView("WORKREQUEST_V");

                entity.Property(e => e.CarBrandCode).IsUnicode(false);

                entity.Property(e => e.CarBrandName).IsUnicode(false);

                entity.Property(e => e.CarChassisno).IsUnicode(false);

                entity.Property(e => e.CarCityCode).IsUnicode(false);

                entity.Property(e => e.CarCityName).IsUnicode(false);

                entity.Property(e => e.CarDefrredDocCheckFlag).IsUnicode(false);

                entity.Property(e => e.CarGvguid).IsUnicode(false);

                entity.Property(e => e.CarGvname).IsUnicode(false);

                entity.Property(e => e.CarLeBranchGuid).IsUnicode(false);

                entity.Property(e => e.CarLeCode).IsUnicode(false);

                entity.Property(e => e.CarLeName).IsUnicode(false);

                entity.Property(e => e.CarMake).IsUnicode(false);

                entity.Property(e => e.CarMakeCode).IsUnicode(false);

                entity.Property(e => e.CarModel).IsUnicode(false);

                entity.Property(e => e.CarModelcode).IsUnicode(false);

                entity.Property(e => e.CarObjVerNo).HasPrecision(3);

                entity.Property(e => e.CarOpModelCode).IsUnicode(false);

                entity.Property(e => e.CarOpModelName).IsUnicode(false);

                entity.Property(e => e.CarOwner).IsUnicode(false);

                entity.Property(e => e.CarOwnerSpStatus).IsUnicode(false);

                entity.Property(e => e.CarOwnerSpid).IsUnicode(false);

                entity.Property(e => e.CarOwnerSpname).IsUnicode(false);

                entity.Property(e => e.CarPkguid).IsUnicode(false);

                entity.Property(e => e.CarRegnNo).IsUnicode(false);

                entity.Property(e => e.CarSecGuid).IsUnicode(false);

                entity.Property(e => e.CarStatusCode).IsUnicode(false);

                entity.Property(e => e.CarStatusName).IsUnicode(false);

                entity.Property(e => e.Carguid).IsUnicode(false);

                entity.Property(e => e.Odometerreading).IsUnicode(false);

                entity.Property(e => e.Qcchecklistno).IsUnicode(false);

                entity.Property(e => e.Remarks).IsUnicode(false);

                entity.Property(e => e.RequestEntityCode).IsUnicode(false);

                entity.Property(e => e.RequestStatusCode).IsUnicode(false);

                entity.Property(e => e.RequestStatusDesc).IsUnicode(false);

                entity.Property(e => e.RequestStatusEntEntguid).IsUnicode(false);

                entity.Property(e => e.RequestStatusEntObjVerNo).HasPrecision(10);

                entity.Property(e => e.RequestStatusEntStsguid).IsUnicode(false);

                entity.Property(e => e.RequestStatusName).IsUnicode(false);

                entity.Property(e => e.Rono).IsUnicode(false);

                entity.Property(e => e.SpDefrredDocCheckFlag).IsUnicode(false);

                entity.Property(e => e.SpPkguid).IsUnicode(false);

                entity.Property(e => e.Spguid).IsUnicode(false);

                entity.Property(e => e.WorkrequestObjectversionno).HasPrecision(3);

                entity.Property(e => e.WorkrequestOracleentityid).IsUnicode(false);

                entity.Property(e => e.WorkrequestOracleentityname).IsUnicode(false);

                entity.Property(e => e.WorkrequestOracleentitytype).IsUnicode(false);

                entity.Property(e => e.WorkrequestPkguid).IsUnicode(false);

                entity.Property(e => e.WorkrequestStatusentityguid).IsUnicode(false);

                entity.Property(e => e.Workrequestmasterguid).IsUnicode(false);

                entity.Property(e => e.Workrequestno).IsUnicode(false);

                entity.Property(e => e.Workshopbranchmasterguid).IsUnicode(false);

                entity.Property(e => e.Workshopcomments).IsUnicode(false);

                entity.Property(e => e.Workshopdescription).IsUnicode(false);

                entity.Property(e => e.Workshopdisabled).HasPrecision(1);

                entity.Property(e => e.Workshopguid).IsUnicode(false);

                entity.Property(e => e.Workshopname).IsUnicode(false);

                entity.Property(e => e.Workshopobjectversionno).HasPrecision(10);

                entity.Property(e => e.Workshoporacleentityid).IsUnicode(false);

                entity.Property(e => e.Workshoporacleentityname).IsUnicode(false);

                entity.Property(e => e.Workshoppkguid).IsUnicode(false);

                entity.Property(e => e.Workshopquickaccesscode).IsUnicode(false);

                entity.Property(e => e.Worktypecomments).IsUnicode(false);

                entity.Property(e => e.Worktypedescription).IsUnicode(false);

                entity.Property(e => e.Worktypedisabled).HasPrecision(1);

                entity.Property(e => e.Worktypeguid).IsUnicode(false);

                entity.Property(e => e.Worktypename).IsUnicode(false);

                entity.Property(e => e.Worktypeobjectversionno).HasPrecision(4);

                entity.Property(e => e.Worktypeoracleentityid).IsUnicode(false);

                entity.Property(e => e.Worktypeoracleentityname).IsUnicode(false);

                entity.Property(e => e.Worktypepkguid).IsUnicode(false);

                entity.Property(e => e.Worktypequickaccesscode).IsUnicode(false);
            });

            modelBuilder.Entity<Workrequestmaster>(entity =>
            {
                entity.Property(e => e.Carguid).IsUnicode(false);

                entity.Property(e => e.Guid).IsUnicode(false);

                entity.Property(e => e.Objectversionno).HasPrecision(3);

                entity.Property(e => e.Odometerreading).IsUnicode(false);

                entity.Property(e => e.Oracleentityid).IsUnicode(false);

                entity.Property(e => e.Oracleentityname).IsUnicode(false);

                entity.Property(e => e.Oracleentitytype).IsUnicode(false);

                entity.Property(e => e.Pkguid).IsUnicode(false);

                entity.Property(e => e.Qcchecklistno).IsUnicode(false);

                entity.Property(e => e.Remarks).IsUnicode(false);

                entity.Property(e => e.Rono).IsUnicode(false);

                entity.Property(e => e.Statusentityguid).IsUnicode(false);

                entity.Property(e => e.Userarchived).IsUnicode(false);

                entity.Property(e => e.Usercreated).IsUnicode(false);

                entity.Property(e => e.Userdeleted).IsUnicode(false);

                entity.Property(e => e.Userupdated).IsUnicode(false);

                entity.Property(e => e.Workrequestno).IsUnicode(false);

                entity.Property(e => e.Workshopguid).IsUnicode(false);

                entity.Property(e => e.Worktypeguid).IsUnicode(false);
            });

            modelBuilder.Entity<Workshopmaster>(entity =>
            {
                entity.Property(e => e.Branchmasterguid).IsUnicode(false);

                entity.Property(e => e.Capacity).HasPrecision(3);

                entity.Property(e => e.Comments).IsUnicode(false);

                entity.Property(e => e.Description).IsUnicode(false);

                entity.Property(e => e.Disabled).HasPrecision(1);

                entity.Property(e => e.Guid).IsUnicode(false);

                entity.Property(e => e.Locationtype).IsUnicode(false);

                entity.Property(e => e.Name).IsUnicode(false);

                entity.Property(e => e.Objectversionno).HasPrecision(10);

                entity.Property(e => e.Oracleentityid).IsUnicode(false);

                entity.Property(e => e.Oracleentityname).IsUnicode(false);

                entity.Property(e => e.Pkguid).IsUnicode(false);

                entity.Property(e => e.Quickaccesscode).IsUnicode(false);

                entity.Property(e => e.Userarchived).IsUnicode(false);

                entity.Property(e => e.Usercreated).IsUnicode(false);

                entity.Property(e => e.Userdeleted).IsUnicode(false);

                entity.Property(e => e.Userupdated).IsUnicode(false);
            });

            modelBuilder.Entity<Worktypemaster>(entity =>
            {
                entity.Property(e => e.Comments).IsUnicode(false);

                entity.Property(e => e.Description).IsUnicode(false);

                entity.Property(e => e.Disabled).HasPrecision(1);

                entity.Property(e => e.Guid).IsUnicode(false);

                entity.Property(e => e.Mappedcarstatus).IsUnicode(false);

                entity.Property(e => e.Name).IsUnicode(false);

                entity.Property(e => e.Objectversionno).HasPrecision(4);

                entity.Property(e => e.Oracleentityid).IsUnicode(false);

                entity.Property(e => e.Oracleentityname).IsUnicode(false);

                entity.Property(e => e.Pkguid).IsUnicode(false);

                entity.Property(e => e.Quickaccesscode).IsUnicode(false);

                entity.Property(e => e.Userarchived).IsUnicode(false);

                entity.Property(e => e.Usercreated).IsUnicode(false);

                entity.Property(e => e.Userdeleted).IsUnicode(false);

                entity.Property(e => e.Userupdated).IsUnicode(false);
            });

            modelBuilder.Entity<XmeruArSubsPer>(entity =>
            {
                entity.Property(e => e.AccountNumber).IsUnicode(false);

                entity.Property(e => e.Address1).IsUnicode(false);

                entity.Property(e => e.Address2).IsUnicode(false);

                entity.Property(e => e.Bioid).IsUnicode(false);

                entity.Property(e => e.Biometricid).IsUnicode(false);

                entity.Property(e => e.CarStatus).IsUnicode(false);

                entity.Property(e => e.ConvStatus).IsUnicode(false);

                entity.Property(e => e.Country).IsUnicode(false);

                entity.Property(e => e.CurrentSubsRate).IsUnicode(false);

                entity.Property(e => e.CustAccountId).HasPrecision(15);

                entity.Property(e => e.CustAcctSiteId).HasPrecision(15);

                entity.Property(e => e.DateOfJoin).IsUnicode(false);

                entity.Property(e => e.DateOfLeaving).IsUnicode(false);

                entity.Property(e => e.DateOfRejoin).IsUnicode(false);

                entity.Property(e => e.DepositAmount).IsUnicode(false);

                entity.Property(e => e.DriverStatus).IsUnicode(false);

                entity.Property(e => e.Errormsg).IsUnicode(false);

                entity.Property(e => e.Gender).IsUnicode(false);

                entity.Property(e => e.MentorRefId).IsUnicode(false);

                entity.Property(e => e.OrgId).HasPrecision(15);

                entity.Property(e => e.PartyId).HasPrecision(15);

                entity.Property(e => e.PartyName).IsUnicode(false);

                entity.Property(e => e.PartySiteId).HasPrecision(15);

                entity.Property(e => e.PkGuid).IsUnicode(false);

                entity.Property(e => e.PostalCode).IsUnicode(false);

                entity.Property(e => e.PrimaryPhoneNumber).IsUnicode(false);

                entity.Property(e => e.Resonmasterguid).IsUnicode(false);

                entity.Property(e => e.SendToSiebel).IsUnicode(false);

                entity.Property(e => e.SiteUseId).HasPrecision(15);

                entity.Property(e => e.SpStatus).IsUnicode(false);

                entity.Property(e => e.SpsiteStatus).IsUnicode(false);

                entity.Property(e => e.State).IsUnicode(false);

                entity.Property(e => e.Status).IsUnicode(false);

                entity.Property(e => e.Statusentityguid).IsUnicode(false);

                entity.Property(e => e.SubsTdsPct).IsUnicode(false);
            });

            modelBuilder.Entity<XmeruArSubsPerBkp>(entity =>
            {
                entity.Property(e => e.AccountNumber).IsUnicode(false);

                entity.Property(e => e.Address1).IsUnicode(false);

                entity.Property(e => e.Address2).IsUnicode(false);

                entity.Property(e => e.Bioid).IsUnicode(false);

                entity.Property(e => e.Biometricid).IsUnicode(false);

                entity.Property(e => e.CarStatus).IsUnicode(false);

                entity.Property(e => e.ConvStatus).IsUnicode(false);

                entity.Property(e => e.Country).IsUnicode(false);

                entity.Property(e => e.CurrentSubsRate).IsUnicode(false);

                entity.Property(e => e.CustAccountId).HasPrecision(15);

                entity.Property(e => e.CustAcctSiteId).HasPrecision(15);

                entity.Property(e => e.DateOfJoin).IsUnicode(false);

                entity.Property(e => e.DateOfLeaving).IsUnicode(false);

                entity.Property(e => e.DateOfRejoin).IsUnicode(false);

                entity.Property(e => e.DepositAmount).IsUnicode(false);

                entity.Property(e => e.DriverStatus).IsUnicode(false);

                entity.Property(e => e.Errormsg).IsUnicode(false);

                entity.Property(e => e.Gender).IsUnicode(false);

                entity.Property(e => e.MentorRefId).IsUnicode(false);

                entity.Property(e => e.OrgId).HasPrecision(15);

                entity.Property(e => e.PartyId).HasPrecision(15);

                entity.Property(e => e.PartyName).IsUnicode(false);

                entity.Property(e => e.PartySiteId).HasPrecision(15);

                entity.Property(e => e.PkGuid).IsUnicode(false);

                entity.Property(e => e.PostalCode).IsUnicode(false);

                entity.Property(e => e.PrimaryPhoneNumber).IsUnicode(false);

                entity.Property(e => e.Resonmasterguid).IsUnicode(false);

                entity.Property(e => e.SendToSiebel).IsUnicode(false);

                entity.Property(e => e.SiteUseId).HasPrecision(15);

                entity.Property(e => e.SpStatus).IsUnicode(false);

                entity.Property(e => e.SpsiteStatus).IsUnicode(false);

                entity.Property(e => e.State).IsUnicode(false);

                entity.Property(e => e.Status).IsUnicode(false);

                entity.Property(e => e.Statusentityguid).IsUnicode(false);

                entity.Property(e => e.SubsTdsPct).IsUnicode(false);
            });

            modelBuilder.Entity<XmeruBalCorrectionLog>(entity =>
            {
                entity.Property(e => e.CreatedBy).IsUnicode(false);

                entity.Property(e => e.ProcessingType).IsUnicode(false);

                entity.Property(e => e.RecordStatus).IsUnicode(false);

                entity.Property(e => e.SiteName).IsUnicode(false);

                entity.Property(e => e.SpGuid).IsUnicode(false);

                entity.Property(e => e.SpPersonId).IsUnicode(false);

                entity.Property(e => e.SpsiteGuid).IsUnicode(false);

                entity.Property(e => e.UpdatedBy).IsUnicode(false);
            });

            modelBuilder.Entity<XmeruBalCorrectionLogDtl>(entity =>
            {
                entity.HasKey(e => e.LogCorrDtlId)
                    .HasName("SYS_C0010857");

                entity.Property(e => e.ActionOn).IsUnicode(false);

                entity.Property(e => e.SiteName).IsUnicode(false);

                entity.Property(e => e.Siteguid).IsUnicode(false);

                entity.Property(e => e.SpPersonId).IsUnicode(false);
            });

            modelBuilder.Entity<XmeruCustLogTable>(entity =>
            {
                entity.Property(e => e.ApiMsg).IsUnicode(false);

                entity.Property(e => e.ApiStatus).IsUnicode(false);

                entity.Property(e => e.Loc).IsUnicode(false);

                entity.Property(e => e.Message).IsUnicode(false);

                entity.Property(e => e.PkgName).IsUnicode(false);

                entity.Property(e => e.ProcName).IsUnicode(false);
            });

            modelBuilder.Entity<XmeruDataLog>(entity =>
            {
                entity.Property(e => e.Loc).HasPrecision(15);

                entity.Property(e => e.Message).IsUnicode(false);

                entity.Property(e => e.Pkg).IsUnicode(false);

                entity.Property(e => e.Proc).IsUnicode(false);

                entity.Property(e => e.SeqId).HasPrecision(15);
            });

            modelBuilder.Entity<XmeruEamCasset>(entity =>
            {
                entity.Property(e => e.AssetNo).IsUnicode(false);

                entity.Property(e => e.CardeviceStatus).IsUnicode(false);

                entity.Property(e => e.Description).IsUnicode(false);

                entity.Property(e => e.Errormsg).IsUnicode(false);

                entity.Property(e => e.EventDate).IsUnicode(false);

                entity.Property(e => e.Make).IsUnicode(false);

                entity.Property(e => e.MdtDeviceId).IsUnicode(false);

                entity.Property(e => e.MobileNumber).IsUnicode(false);

                entity.Property(e => e.Model).IsUnicode(false);

                entity.Property(e => e.OrgName).IsUnicode(false);

                entity.Property(e => e.ParentInstance).IsUnicode(false);

                entity.Property(e => e.ParentSerial).IsUnicode(false);

                entity.Property(e => e.Segment1).IsUnicode(false);

                entity.Property(e => e.SerialNumber).IsUnicode(false);

                entity.Property(e => e.ServiceProvider).IsUnicode(false);

                entity.Property(e => e.SimNumber).IsUnicode(false);

                entity.Property(e => e.Status).IsUnicode(false);

                entity.Property(e => e.TimeStamp).IsUnicode(false);

                entity.Property(e => e.Type).IsUnicode(false);

                entity.Property(e => e.VehicleStatus).IsUnicode(false);
            });

            modelBuilder.Entity<XmeruEmiBalUpdateTracking>(entity =>
            {
                entity.HasKey(e => e.Guid)
                    .HasName("SYS_C0010848");

                entity.Property(e => e.Guid).IsUnicode(false);

                entity.Property(e => e.Siteguid).IsUnicode(false);
            });

            modelBuilder.Entity<XmeruFtrReport>(entity =>
            {
                entity.ToView("XMERU_FTR_REPORT");

                entity.Property(e => e.BrandName).IsUnicode(false);

                entity.Property(e => e.CityName).IsUnicode(false);

                entity.Property(e => e.Comments).IsUnicode(false);

                entity.Property(e => e.LegalentityName).IsUnicode(false);

                entity.Property(e => e.ModelName).IsUnicode(false);

                entity.Property(e => e.SecGuid).IsUnicode(false);

                entity.Property(e => e.ServiceproviderId).IsUnicode(false);

                entity.Property(e => e.ServiceproviderName).IsUnicode(false);

                entity.Property(e => e.Showninstatement).IsUnicode(false);

                entity.Property(e => e.SiteName).IsUnicode(false);

                entity.Property(e => e.SubType).IsUnicode(false);

                entity.Property(e => e.TransactionNo).IsUnicode(false);

                entity.Property(e => e.TransactionStatus).IsUnicode(false);

                entity.Property(e => e.TransactionType).IsUnicode(false);

                entity.Property(e => e.TripId).IsUnicode(false);

                entity.Property(e => e.UserName).IsUnicode(false);
            });

            modelBuilder.Entity<XmeruGvuploadTbl>(entity =>
            {
                entity.Property(e => e.CarSecguid).IsUnicode(false);

                entity.Property(e => e.Carguid).IsUnicode(false);

                entity.Property(e => e.Errormsg).IsUnicode(false);

                entity.Property(e => e.Executionguid).IsUnicode(false);

                entity.Property(e => e.Newgvguid).IsUnicode(false);

                entity.Property(e => e.Newgvname).IsUnicode(false);

                entity.Property(e => e.Newgvsecurity).IsUnicode(false);

                entity.Property(e => e.Oldgvguid).IsUnicode(false);

                entity.Property(e => e.Roleguid).IsUnicode(false);

                entity.Property(e => e.Siteguid).IsUnicode(false);

                entity.Property(e => e.Sitename).IsUnicode(false);

                entity.Property(e => e.Spguid).IsUnicode(false);

                entity.Property(e => e.Spid).IsUnicode(false);

                entity.Property(e => e.Status).IsUnicode(false);

                entity.Property(e => e.UserSecGuid).IsUnicode(false);

                entity.Property(e => e.Userguid).IsUnicode(false);
            });

            modelBuilder.Entity<XmeruInvoiceImportStg>(entity =>
            {
                entity.Property(e => e.Description).IsUnicode(false);

                entity.Property(e => e.DisDeescription).IsUnicode(false);

                entity.Property(e => e.ErrorMessage).IsUnicode(false);

                entity.Property(e => e.InsertFlag)
                    .IsUnicode(false)
                    .HasDefaultValueSql("'IP'");

                entity.Property(e => e.InvoiceCurr).IsUnicode(false);

                entity.Property(e => e.InvoiceNum).IsUnicode(false);

                entity.Property(e => e.InvoiceType).IsUnicode(false);

                entity.Property(e => e.LiabilityAcco).IsUnicode(false);

                entity.Property(e => e.LineType).IsUnicode(false);

                entity.Property(e => e.OperatingUnit).IsUnicode(false);

                entity.Property(e => e.PaymentCurr).IsUnicode(false);

                entity.Property(e => e.PaymentMethod).IsUnicode(false);

                entity.Property(e => e.PaymentTerms).IsUnicode(false);

                entity.Property(e => e.ProcessFlag)
                    .IsUnicode(false)
                    .HasDefaultValueSql("'IP'");

                entity.Property(e => e.Source).IsUnicode(false);

                entity.Property(e => e.TradingPartnerName).IsUnicode(false);
            });

            modelBuilder.Entity<XmeruLogTable>(entity =>
            {
                entity.Property(e => e.ApiMsg).IsUnicode(false);

                entity.Property(e => e.ApiStatus).IsUnicode(false);

                entity.Property(e => e.Message).IsUnicode(false);

                entity.Property(e => e.PkgName).IsUnicode(false);

                entity.Property(e => e.ProcName).IsUnicode(false);
            });

            modelBuilder.Entity<XmeruLogTblBkp1>(entity =>
            {
                entity.Property(e => e.ApiMsg).IsUnicode(false);

                entity.Property(e => e.ApiStatus).IsUnicode(false);

                entity.Property(e => e.Message).IsUnicode(false);

                entity.Property(e => e.PkgName).IsUnicode(false);

                entity.Property(e => e.ProcName).IsUnicode(false);
            });

            modelBuilder.Entity<XmeruLogTblBkp2>(entity =>
            {
                entity.Property(e => e.ApiMsg).IsUnicode(false);

                entity.Property(e => e.ApiStatus).IsUnicode(false);

                entity.Property(e => e.Message).IsUnicode(false);

                entity.Property(e => e.PkgName).IsUnicode(false);

                entity.Property(e => e.ProcName).IsUnicode(false);
            });

            modelBuilder.Entity<XmeruLogTblBkp3>(entity =>
            {
                entity.Property(e => e.ApiMsg).IsUnicode(false);

                entity.Property(e => e.ApiStatus).IsUnicode(false);

                entity.Property(e => e.Message).IsUnicode(false);

                entity.Property(e => e.PkgName).IsUnicode(false);

                entity.Property(e => e.ProcName).IsUnicode(false);
            });

            modelBuilder.Entity<XmeruMaxEmpNo>(entity =>
            {
                entity.Property(e => e.HrLegalEntity).IsUnicode(false);
            });

            modelBuilder.Entity<XmeruNlsLogTbl>(entity =>
            {
                entity.Property(e => e.ApiMsg).IsUnicode(false);

                entity.Property(e => e.ApiStatus).IsUnicode(false);

                entity.Property(e => e.Message).IsUnicode(false);

                entity.Property(e => e.PkgName).IsUnicode(false);

                entity.Property(e => e.ProcName).IsUnicode(false);
            });

            modelBuilder.Entity<XmeruOutstandingHistV>(entity =>
            {
                entity.ToView("XMERU_OUTSTANDING_HIST_V");

                entity.Property(e => e.BrandName).IsUnicode(false);

                entity.Property(e => e.CarStatus).IsUnicode(false);

                entity.Property(e => e.CityName).IsUnicode(false);

                entity.Property(e => e.CmSecuritycombinationguid).IsUnicode(false);

                entity.Property(e => e.Driver)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Dse)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.LeName).IsUnicode(false);

                entity.Property(e => e.LockStatus).IsUnicode(false);

                entity.Property(e => e.MobileNo).IsUnicode(false);

                entity.Property(e => e.ModelName).IsUnicode(false);

                entity.Property(e => e.NameOfDse).IsUnicode(false);

                entity.Property(e => e.Sitename).IsUnicode(false);

                entity.Property(e => e.Sp)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Spid).IsUnicode(false);

                entity.Property(e => e.StatusOfSite).IsUnicode(false);
            });

            modelBuilder.Entity<XmeruPerAllPeoplePhoneV>(entity =>
            {
                entity.ToView("XMERU_PER_ALL_PEOPLE_PHONE_V");

                entity.Property(e => e.EmployeeNumber)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.FullName).IsUnicode(false);

                entity.Property(e => e.NpwNumber)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.PhoneNumber).IsUnicode(false);
            });

            modelBuilder.Entity<XmeruSmsRecipent>(entity =>
            {
                entity.Property(e => e.ConstPostText).IsUnicode(false);

                entity.Property(e => e.ConstPreText).IsUnicode(false);

                entity.Property(e => e.EnabledFlag).HasPrecision(1);

                entity.Property(e => e.PhoneNo).IsUnicode(false);

                entity.Property(e => e.Recipentstype).IsUnicode(false);

                entity.Property(e => e.RecipientName).IsUnicode(false);
            });

            modelBuilder.Entity<XmeruTempTbl>(entity =>
            {
                entity.Property(e => e.F1).IsUnicode(false);
            });

            modelBuilder.Entity<XmeruTxnTbl>(entity =>
            {
                entity.Property(e => e.Carguid).IsUnicode(false);

                entity.Property(e => e.Clientid).IsUnicode(false);

                entity.Property(e => e.Comments).IsUnicode(false);

                entity.Property(e => e.Errormsg).IsUnicode(false);

                entity.Property(e => e.ExecutionGuid).IsUnicode(false);

                entity.Property(e => e.Requestid).HasPrecision(10);

                entity.Property(e => e.Roleguid).IsUnicode(false);

                entity.Property(e => e.SecGuid).IsUnicode(false);

                entity.Property(e => e.Siteguid).IsUnicode(false);

                entity.Property(e => e.Sitename).IsUnicode(false);

                entity.Property(e => e.Spguid).IsUnicode(false);

                entity.Property(e => e.Spid).IsUnicode(false);

                entity.Property(e => e.Status).IsUnicode(false);

                entity.Property(e => e.Tripid).IsUnicode(false);

                entity.Property(e => e.TxnType).IsUnicode(false);

                entity.Property(e => e.TxnTypeName).IsUnicode(false);

                entity.Property(e => e.Usercreated).IsUnicode(false);

                entity.Property(e => e.Userguid).IsUnicode(false);
            });

            modelBuilder.Entity<XmeruWflTransaction>(entity =>
            {
                entity.Property(e => e.ApprLevel).IsUnicode(false);

                entity.Property(e => e.ApprovalReq).IsUnicode(false);

                entity.Property(e => e.Attribute1).IsUnicode(false);

                entity.Property(e => e.Attribute2).IsUnicode(false);

                entity.Property(e => e.ForwardedTo).IsUnicode(false);

                entity.Property(e => e.LastUpdateLogin).HasPrecision(15);

                entity.Property(e => e.Narration).IsUnicode(false);

                entity.Property(e => e.Status).IsUnicode(false);

                entity.Property(e => e.StatusCode).IsUnicode(false);

                entity.Property(e => e.TransactionNum).IsUnicode(false);

                entity.Property(e => e.TransactionSource).IsUnicode(false);

                entity.Property(e => e.TransactionSourceRefe).IsUnicode(false);

                entity.Property(e => e.TransactionType).IsUnicode(false);

                entity.Property(e => e.Url).IsUnicode(false);

                entity.Property(e => e.WfItemKey).IsUnicode(false);

                entity.Property(e => e.WfItemType).IsUnicode(false);
            });

            modelBuilder.Entity<XmeruWorkshopInspSlot>(entity =>
            {
                entity.Property(e => e.Branchmasterguid).IsUnicode(false);

                entity.Property(e => e.Carmasterguid).IsUnicode(false);

                entity.Property(e => e.Guid).IsUnicode(false);

                entity.Property(e => e.Inspectionresultguid).IsUnicode(false);

                entity.Property(e => e.Inspecttype).IsUnicode(false);

                entity.Property(e => e.Pkguid).IsUnicode(false);

                entity.Property(e => e.Schedulestatusentityguid).IsUnicode(false);

                entity.Property(e => e.Slotno).HasPrecision(3);

                entity.Property(e => e.Workshopmasterguid).IsUnicode(false);
            });

            modelBuilder.Entity<XmeruWrVouchersStage>(entity =>
            {
                entity.HasKey(e => e.EstimationId)
                    .HasName("ESTIMATION_ID_PK");

                entity.Property(e => e.EstimationId)
                    .HasPrecision(15)
                    .ValueGeneratedNever();

                entity.Property(e => e.ApproverComments).IsUnicode(false);

                entity.Property(e => e.CreationDate).HasDefaultValueSql("sysdate ");

                entity.Property(e => e.DocumentReady)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.ErrMsg).IsUnicode(false);

                entity.Property(e => e.FinalApprPersId).HasPrecision(15);

                entity.Property(e => e.ForwardedTo).IsUnicode(false);

                entity.Property(e => e.LastUpdateDate).HasDefaultValueSql("sysdate ");

                entity.Property(e => e.LastUpdateLogin).HasPrecision(15);

                entity.Property(e => e.OrigSysAttachFileName).IsUnicode(false);

                entity.Property(e => e.OrigSysAttachFileType).IsUnicode(false);

                entity.Property(e => e.OrigSystem).IsUnicode(false);

                entity.Property(e => e.OrigSystemRef).IsUnicode(false);

                entity.Property(e => e.RequestorComments).IsUnicode(false);

                entity.Property(e => e.Status).IsUnicode(false);

                entity.Property(e => e.StatusCode).HasDefaultValueSql("0");

                entity.Property(e => e.VehicleNum).IsUnicode(false);

                entity.Property(e => e.VoucherCategory).IsUnicode(false);

                entity.Property(e => e.VoucherNum).IsUnicode(false);

                entity.Property(e => e.WfItemKey).IsUnicode(false);

                entity.Property(e => e.WfItemType).IsUnicode(false);

                entity.Property(e => e.WorkShop).IsUnicode(false);

                entity.Property(e => e.WrType).IsUnicode(false);
            });

            modelBuilder.Entity<ZipdialInterface>(entity =>
            {
                entity.Property(e => e.Circlename).IsUnicode(false);

                entity.Property(e => e.Comments).IsUnicode(false);

                entity.Property(e => e.Interested).IsUnicode(false);

                entity.Property(e => e.Lastupdatedby).HasPrecision(4);

                entity.Property(e => e.Leadname).IsUnicode(false);

                entity.Property(e => e.Leadstatus).IsUnicode(false);

                entity.Property(e => e.Operatorname).IsUnicode(false);

                entity.Property(e => e.Outcalldone).IsUnicode(false);

                entity.Property(e => e.SrNo).HasPrecision(4);
            });

            modelBuilder.Entity<ZipdialMapping>(entity =>
            {
                entity.Property(e => e.CityName1).IsUnicode(false);

                entity.Property(e => e.Cityname).IsUnicode(false);

                entity.Property(e => e.Operator).IsUnicode(false);
            });

            modelBuilder.HasSequence("AP_INVOICE_INTERFACE_S");

            modelBuilder.HasSequence("AP_INVOICE_LINES_INTERFACE_S");

            modelBuilder.HasSequence("CLEINTMAPEVENTID_SEQ").IsCyclic();

            modelBuilder.HasSequence("COMPLAINT_ID_SEQ");

            modelBuilder.HasSequence("COMPLAINT_NUM_SEQ");

            modelBuilder.HasSequence("DEVICE_ID_SEQ");

            modelBuilder.HasSequence("DOCUMNETSRNO");

            modelBuilder.HasSequence("DRIVERMOBILENO_SEQ");

            modelBuilder.HasSequence("EMI_TXN_NO_S");

            modelBuilder.HasSequence("ESTIMATION_ID_SEQ");

            modelBuilder.HasSequence("EVENT_ID_SEQ");

            modelBuilder.HasSequence("EXTERNAL_PAYMENTS_SEQ");

            modelBuilder.HasSequence("FUNDTRANSFER_SEQ");

            modelBuilder.HasSequence("GL_GROUPID");

            modelBuilder.HasSequence("LOCK_LOG_SEQ_NO");

            modelBuilder.HasSequence("LOCKEXCEPTIONID_SEQ");

            modelBuilder.HasSequence("LOCKID_SEQ");

            modelBuilder.HasSequence("LOG_SEC");

            modelBuilder.HasSequence("MENTOR_SEQ");

            modelBuilder.HasSequence("MERCHANTTXNID_SEQ");

            modelBuilder.HasSequence("NLS_LOG_SEQ");

            modelBuilder.HasSequence("ORACLE_PROG_ID_S");

            modelBuilder.HasSequence("OWNERMOBILENO_SEQ");

            modelBuilder.HasSequence("PERSONDOCS_SEQ");

            modelBuilder.HasSequence("RA_CUSTOMER_TRX_LINES_S2");

            modelBuilder.HasSequence("RA_CUSTOMER_TRX_S2");

            modelBuilder.HasSequence("RCPT_NUM");

            modelBuilder.HasSequence("RCPT_NUM1");

            modelBuilder.HasSequence("RET_LOG_SEQ");

            modelBuilder.HasSequence("SERVICEREQUESTNO");

            modelBuilder.HasSequence("SMS_SEQ");

            modelBuilder.HasSequence("TRANSACTION_NO_S");

            modelBuilder.HasSequence("TRANSACTION_S");

            modelBuilder.HasSequence("TRX_ID");

            modelBuilder.HasSequence("TRX_NUM");

            modelBuilder.HasSequence("TRX_NUMBER");

            modelBuilder.HasSequence("TRX_SEQ");

            modelBuilder.HasSequence("VOUCHER_NUM_SEQ");

            modelBuilder.HasSequence("WFSTARTPROCSEQ");

            modelBuilder.HasSequence("XMERU_BAL_CORR_LOG_DTL_ID");

            modelBuilder.HasSequence("XMERU_BAL_CORRECTION_LOG_SEQ");

            modelBuilder.HasSequence("XMERU_DATA_LOG_SEQ");

            modelBuilder.HasSequence("XMERU_PERSON_SEQ_ID_S");

            modelBuilder.HasSequence("XMERU_POSTCARD_ID_S");

            modelBuilder.HasSequence("XMERU_TERMINATION_SEQ");

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
