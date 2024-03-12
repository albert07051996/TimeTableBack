﻿using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class Humre
{
    public int Id { get; set; }

    public int ResId { get; set; }

    public string? Fullname { get; set; }

    public string? SurName { get; set; }

    public string? FirstName { get; set; }

    public string? MiddleName { get; set; }

    public string? Initialen { get; set; }

    public string? Mv1 { get; set; }

    public string? Adres1 { get; set; }

    public string? Adres2 { get; set; }

    public string? Woonpl { get; set; }

    public string? Postcode { get; set; }

    public string? LandIso { get; set; }

    public string? IsoTaalcd { get; set; }

    public string? Mail { get; set; }

    public string? TelnrPrv { get; set; }

    public string? TelnrPrv2 { get; set; }

    public string? TelnrWerk { get; set; }

    public string? TelnrWerk2 { get; set; }

    public string? Faxnr { get; set; }

    public string? Kamer { get; set; }

    public string? Toestel { get; set; }

    public string? Funcnivo { get; set; }

    public string? SocsecNr { get; set; }

    public DateTime? GebLdat { get; set; }

    public string? GebPl { get; set; }

    public DateTime? Ldatindienst { get; set; }

    public DateTime? Ldatuitdienst { get; set; }

    public DateTime? DateOfDead { get; set; }

    public string OfficialName { get; set; } = null!;

    public string? UsrId { get; set; }

    public byte Blocked { get; set; }

    public int ReptoId { get; set; }

    public string? Nat { get; set; }

    public string? MarStat { get; set; }

    public DateTime? MarDate { get; set; }

    public string? AddrNo { get; set; }

    public string? Email { get; set; }

    public string? JobTitle { get; set; }

    public string? Loc { get; set; }

    public string? Comp { get; set; }

    public string? Task { get; set; }

    public string? EmpType { get; set; }

    public DateTime? EmpStatd { get; set; }

    public string? ProbPer { get; set; }

    public string? ProbPert { get; set; }

    public DateTime? ProbEndd { get; set; }

    public int? Notes { get; set; }

    public string? ReasonResign { get; set; }

    public string? CrcardType { get; set; }

    public string? CrcardNo { get; set; }

    public DateTime? CrcardExpd { get; set; }

    public string? AddrXtra { get; set; }

    public DateTime? ContEndDate { get; set; }

    public string? Workstat { get; set; }

    public string? WorkstatAddr { get; set; }

    public byte Buyer { get; set; }

    public byte Representative { get; set; }

    public byte Projempl { get; set; }

    public string? MaidenName { get; set; }

    public string? PrafdCode { get; set; }

    public double Inttar { get; set; }

    public double Exttar { get; set; }

    public int JobLevel { get; set; }

    public byte Payempl { get; set; }

    public string? Identiteit { get; set; }

    public string? KstdrCode { get; set; }

    public string? UitkCode { get; set; }

    public string? ExtraText { get; set; }

    public string? ExtraCode { get; set; }

    public string? AdvCode { get; set; }

    public string? SlipTekst { get; set; }

    public string? Predcode { get; set; }

    public string? Costcenter { get; set; }

    public string? Crdnr { get; set; }

    public string? Bankac0 { get; set; }

    public string? Bankac1 { get; set; }

    public string? Valcode { get; set; }

    public double PurLimit { get; set; }

    public double Fte { get; set; }

    public string? Picturefilename { get; set; }

    public string? PictureThumbnailFilename { get; set; }

    public string? Freefield1 { get; set; }

    public string? Freefield2 { get; set; }

    public string? Freefield3 { get; set; }

    public string? Freefield4 { get; set; }

    public string? Freefield5 { get; set; }

    public DateTime? Freefield6 { get; set; }

    public DateTime? Freefield7 { get; set; }

    public DateTime? Freefield8 { get; set; }

    public DateTime? Freefield9 { get; set; }

    public DateTime? Freefield10 { get; set; }

    public double Freefield11 { get; set; }

    public double Freefield12 { get; set; }

    public double Freefield13 { get; set; }

    public double Freefield14 { get; set; }

    public double Freefield15 { get; set; }

    public byte Freefield16 { get; set; }

    public byte Freefield17 { get; set; }

    public byte Freefield18 { get; set; }

    public byte Freefield19 { get; set; }

    public byte Freefield20 { get; set; }

    public string? EmpStat { get; set; }

    public int Absent { get; set; }

    public int Assistant { get; set; }

    public Guid? CmpWwn { get; set; }

    public string? Internetac { get; set; }

    public string? MobileShort { get; set; }

    public string? Rating { get; set; }

    public string? UserGroup { get; set; }

    public byte[]? Picture { get; set; }

    public byte[]? PictureThumbnail { get; set; }

    public string? BtwNummer { get; set; }

    public byte? IsPersonalAccount { get; set; }

    public int Scale { get; set; }

    public byte[]? Signature { get; set; }

    public string? SignatureFile { get; set; }

    public double BankingLimit { get; set; }

    public string? OldNtfullName { get; set; }

    public int? TimeZone { get; set; }

    public bool SynchronizeExchange { get; set; }

    public string? StateCode { get; set; }

    public string? ChildName1 { get; set; }

    public DateTime? ChildBirthDate1 { get; set; }

    public string? ChildName2 { get; set; }

    public DateTime? ChildBirthDate2 { get; set; }

    public string? ChildName3 { get; set; }

    public DateTime? ChildBirthDate3 { get; set; }

    public string? ChildName4 { get; set; }

    public DateTime? ChildBirthDate4 { get; set; }

    public string? ChildName5 { get; set; }

    public DateTime? ChildBirthDate5 { get; set; }

    public string? Partner { get; set; }

    public DateTime? PartnerBirthDate { get; set; }

    public string? ItemCode { get; set; }

    public string? UsrId2 { get; set; }

    public string? MainLoc { get; set; }

    public string? Prefix { get; set; }

    public string? Affix { get; set; }

    public string? BirthPrefix { get; set; }

    public string? BirthAffix { get; set; }

    public string? Predcode2 { get; set; }

    public string? LandIso2 { get; set; }

    public string? Race { get; set; }

    public double SalesLimit { get; set; }

    public double InvoiceLimit { get; set; }

    public double Rmalimit { get; set; }

    public string? SkypeId { get; set; }

    public string? MsnId { get; set; }

    public DateTime? VacancyStartDate { get; set; }

    public string? ApplicationStage { get; set; }

    public byte BackOfficeBlocked { get; set; }

    public short ProcessedByBackgroundJob { get; set; }

    public string VacancyType { get; set; } = null!;

    public string? Classification { get; set; }

    public string? JobCategory { get; set; }

    public DateTime? AdjustedHireDate { get; set; }

    public int PortalCreator { get; set; }

    public string? HomePageUrl { get; set; }

    public string? InternetUrl { get; set; }

    public string? AttachmentType { get; set; }

    public Guid? AttachmentId { get; set; }

    public int VacancyQuantity { get; set; }

    public int ParentId { get; set; }

    public short? Division { get; set; }

    public byte UserLicenseType { get; set; }

    public string? SipUri { get; set; }

    public double AnnualSalary { get; set; }

    public DateTime Syscreated { get; set; }

    public int Syscreator { get; set; }

    public DateTime Sysmodified { get; set; }

    public int Sysmodifier { get; set; }

    public Guid Sysguid { get; set; }

    public byte[] Timestamp { get; set; } = null!;

    public string? OldBu { get; set; }

    public string? OldPhP { get; set; }

    public string? OldReferenceN { get; set; }

    public string? OldTabN { get; set; }

    public string? OldJobCode { get; set; }
}
