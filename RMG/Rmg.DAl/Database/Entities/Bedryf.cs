using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class Bedryf
{
    public int Id { get; set; }

    public string? Bedrnr { get; set; }

    public string? Bedrzk { get; set; }

    public string? Bedrnm { get; set; }

    public string? BestDirs0 { get; set; }

    public string? BestDirs1 { get; set; }

    public string? BestDirs2 { get; set; }

    public string? BestDirs3 { get; set; }

    public string? BestDirs4 { get; set; }

    public string? BestDirs5 { get; set; }

    public string? BestDirs6 { get; set; }

    public string? BestDirs7 { get; set; }

    public string? Status { get; set; }

    public byte ConvSuc { get; set; }

    public byte ConvOrg { get; set; }

    public string? Dbengine0 { get; set; }

    public string? Dbengine1 { get; set; }

    public string? Dbengine2 { get; set; }

    public string? Dbengine3 { get; set; }

    public string? Dbengine4 { get; set; }

    public string? Dbengine5 { get; set; }

    public string? Dbengine6 { get; set; }

    public string? Dbengine7 { get; set; }

    public string? ParCompany { get; set; }

    public string? DelCat1Id { get; set; }

    public string? DelCat2Id { get; set; }

    public string? HrCompany { get; set; }

    public string? AdmAdrnr { get; set; }

    public string? CorrAdrnr { get; set; }

    public string? Xinterface { get; set; }

    public string? Mailbox { get; set; }

    public string? BankRek { get; set; }

    public string? Pstbanknr { get; set; }

    public string? KvkNummer { get; set; }

    public string? KvkWoonpl { get; set; }

    public string? BtwNummer { get; set; }

    public string? LbNummer { get; set; }

    public string? Fiscnr { get; set; }

    public string? Valcode { get; set; }

    public string? BgcAdmnr { get; set; }

    public int Batchlevel { get; set; }

    public string? Achternaam { get; set; }

    public string? Adr { get; set; }

    public string? Adres2 { get; set; }

    public string? Adres3 { get; set; }

    public string? Pstcd { get; set; }

    public string? Woonpl { get; set; }

    public string? Landcode { get; set; }

    public string? Cpers { get; set; }

    public string? Telnr { get; set; }

    public string? Faxnr { get; set; }

    public string? Telex { get; set; }

    public string? CorrAdres { get; set; }

    public string? CorrAdr2 { get; set; }

    public string? CorrAdr3 { get; set; }

    public string? CorrPcode { get; set; }

    public string? CorrWplts { get; set; }

    public string? CorrLndcd { get; set; }

    public string? Fiscode { get; set; }

    public string? Region { get; set; }

    public Guid? Guid { get; set; }

    public byte Active { get; set; }

    public short VersionMajor { get; set; }

    public short VersionMinor { get; set; }

    public short Revision { get; set; }

    public int Build { get; set; }

    public string? Class01 { get; set; }

    public string? Class02 { get; set; }

    public string? Class03 { get; set; }

    public string? Class04 { get; set; }

    public string? Class05 { get; set; }

    public string? Class06 { get; set; }

    public string? Class07 { get; set; }

    public string? Class08 { get; set; }

    public string? Class09 { get; set; }

    public string? Website { get; set; }

    public double WorkingHours { get; set; }

    public DateTime? StartDate { get; set; }

    public int CompanyType { get; set; }

    public string? CompanyNumber { get; set; }

    public string? CompanyPath { get; set; }

    public string? LastImportTransactionCode { get; set; }

    public DateTime? LastImportDate { get; set; }

    public DateTime? DateStart { get; set; }

    public DateTime? DateEnd { get; set; }

    public DateTime? LastReplicationDate { get; set; }

    public int ImportFirstYear { get; set; }

    public byte Hide { get; set; }

    public int Contact1PeopleId { get; set; }

    public int Contact2PeopleId { get; set; }

    public int Contact3PeopleId { get; set; }

    public int CompanyImportType { get; set; }

    public Guid? HrcmpWwn { get; set; }

    public string? CostcenterCode { get; set; }

    public byte Esalaris { get; set; }

    public byte DefForCountry { get; set; }

    public bool ResellerPort { get; set; }

    public bool CustomerPort { get; set; }

    public int? PeriodCloseFlag { get; set; }

    public string? FaktCode { get; set; }

    public int? MailBoxOption { get; set; }

    public string? MailBoxServer { get; set; }

    public int SecurityLevel { get; set; }

    public byte MaintCrmbackOffice { get; set; }

    public string? Url { get; set; }

    public bool ReportingEntity { get; set; }

    public string? PresentationCurrency { get; set; }

    public string? Ctagl { get; set; }

    public string? BackOfficeServerPath { get; set; }

    public string? BackOfficeWebService { get; set; }

    public string? BackOfficeDbname { get; set; }

    public int? BackOfficeType { get; set; }

    public bool BackOfficeEnabled { get; set; }

    public string? BackOfficeUser { get; set; }

    public string? BackOfficePwd { get; set; }

    public bool? BackOfficeEnableFixedCredentials { get; set; }

    public string? BudgetScenario { get; set; }

    public short? Division { get; set; }

    public DateTime Syscreated { get; set; }

    public int Syscreator { get; set; }

    public DateTime Sysmodified { get; set; }

    public int Sysmodifier { get; set; }

    public Guid Sysguid { get; set; }

    public byte[] Timestamp { get; set; } = null!;

    public string? SecurityToken { get; set; }

    public string? RefreshSecurityToken { get; set; }

    public string? Sqluser { get; set; }

    public string? Sqlpassword { get; set; }

    public DateTime? Expiration { get; set; }

    public int? NoOfDay { get; set; }

    public int? NoOfReminder { get; set; }

    public double? OutStandingAmount { get; set; }

    public string? FreePerson { get; set; }

    public string? IdentificationSender { get; set; }

    public string? IdentificationReceiver { get; set; }

    public int? ChamberOfCommerceNo { get; set; }

    public string? IdentificationEmpAtArbo { get; set; }

    public string? ConnNoEmpAtArbo { get; set; }

    public string? IdentificationEmpAtUwv { get; set; }

    public int SyncEmployeeToArbo { get; set; }
}
