using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class Nlhrpayroll
{
    public int Id { get; set; }

    public string Type { get; set; } = null!;

    public short Contract { get; set; }

    public DateTime Startdate { get; set; }

    public DateTime? Enddate { get; set; }

    public string? Description { get; set; }

    public string? JobTitle { get; set; }

    public Guid? DocAttachmentId { get; set; }

    public short? PayrollYear { get; set; }

    public int ResId { get; set; }

    public short Period { get; set; }

    public byte TaxPayment { get; set; }

    public string? TaxTableColor { get; set; }

    public string? TaxExtraType { get; set; }

    public double TaxExtraAmount { get; set; }

    public string? TaxRebateType { get; set; }

    public DateTime? TaxRebateLdate { get; set; }

    public byte TaxRebateElderly { get; set; }

    public byte TaxRebateYoungDisab { get; set; }

    public double TaxSpecialYearlywage { get; set; }

    public double TaxSpecialPercentage { get; set; }

    public byte TaxVoordeelregel { get; set; }

    public string? TaxLagelonenType { get; set; }

    public string? TaxVerminderingType { get; set; }

    public double TaxVerminderingUren { get; set; }

    public double TaxVerminderingVastbedrag { get; set; }

    public short? TaxIncomeCode { get; set; }

    public string? TaxReductionType { get; set; }

    public string? TaxExceptionType { get; set; }

    public double TaxBeschikkingAmount { get; set; }

    public double TaxPercentageRule { get; set; }

    public string? TaxFranchise { get; set; }

    public string? SocWwType { get; set; }

    public string? SocZwType { get; set; }

    public string? SocWaoType { get; set; }

    public string? SocZfwType { get; set; }

    public byte MsvPrint { get; set; }

    public string? MsvDeclarationType { get; set; }

    public string? MsvResignCode { get; set; }

    public DateTime? MsvChangeLdate { get; set; }

    public short? MsvCaoCode { get; set; }

    public byte MsvLabourAgreement { get; set; }

    public string? MsvLabourCode { get; set; }

    public string? MsvLabourException { get; set; }

    public byte MsvLabourRegular { get; set; }

    public double MsvHoursWeek { get; set; }

    public short? MsvWaoPercentage { get; set; }

    public string? MsvReductionWaCode { get; set; }

    public string? MsvPremiumgrpCode { get; set; }

    public string? MsvOwnRiskCode { get; set; }

    public double MsvLoonsom { get; set; }

    public byte MsvPartVnps { get; set; }

    public byte MsvPartObf { get; set; }

    public byte MsvPartStein { get; set; }

    public byte MsvPartBps { get; set; }

    public int? YdecPaymentAmt { get; set; }

    public short? YdecPaymentDays { get; set; }

    public int? YdecPaymentWao { get; set; }

    public int? YdecBAmount { get; set; }

    public short? YdecYearHours { get; set; }

    public short? YdecSpecialSvCode { get; set; }

    public short? YdecBpfCode { get; set; }

    public short? YdecVutCode { get; set; }

    public string? YdecVrijstCode { get; set; }

    public byte YdecGovernment { get; set; }

    public byte YdecCompCar { get; set; }

    public short? YdecSpecialCode1 { get; set; }

    public double YdecSpecialAmount1 { get; set; }

    public short? YdecSpecialCode2 { get; set; }

    public double YdecSpecialAmount2 { get; set; }

    public short? YdecSpecialCode3 { get; set; }

    public double YdecSpecialAmount3 { get; set; }

    public string? Sliptext1 { get; set; }

    public string? Sliptext2 { get; set; }

    public string? Sliptext3 { get; set; }

    public string? PaymentPeriod { get; set; }

    public string? Country { get; set; }

    public double AnnualWage { get; set; }

    public double AfwBterPf { get; set; }

    public double SocBterDays { get; set; }

    public string? SocTypeLine { get; set; }

    public byte PloRisFonds { get; set; }

    public string? SocLeerling { get; set; }

    public byte SocUta { get; set; }

    public double DaysPeriod { get; set; }

    public string? Sector { get; set; }

    public string? Subsector { get; set; }

    public short? AbuWeeksNotWorked { get; set; }

    public DateTime? AbuStartdate { get; set; }

    public DateTime? AbuEnddate { get; set; }

    public short? AbpDvVolgnr { get; set; }

    public DateTime? AbpDvStartdate { get; set; }

    public DateTime? AbpDvEnddate { get; set; }

    public string? AbpDvAard { get; set; }

    public string? AbpDvWaarde { get; set; }

    public double AbpPtfAfw { get; set; }

    public string? DeclarationNumber { get; set; }

    public double ReferencePeriod { get; set; }

    public string? ComponentGroup { get; set; }

    public short? DeclarationPeriod { get; set; }

    public short? DeclarationSequence { get; set; }

    public string? DeclarationType { get; set; }

    public string? DeclarationMade { get; set; }

    public DateTime? DeclarationDate { get; set; }

    public string? DeclarationReference { get; set; }

    public short? DeclarationLastaction { get; set; }

    public string? CdInkVermindering { get; set; }

    public string? CalcSvdaysMethod { get; set; }

    public double CalcDaysWeek { get; set; }

    public double CalcHoursWeek { get; set; }

    public string? CalcPtfMethod { get; set; }

    public double CalcPtf { get; set; }

    public string? SlipNameMethod { get; set; }

    public double ReferenceYear { get; set; }

    public string? TaxUseDaily { get; set; }

    public short? IvNummer { get; set; }

    public short? IvIndication { get; set; }

    public DateTime? IvStartdate { get; set; }

    public DateTime? IvEnddate { get; set; }

    public byte IvDevDate { get; set; }

    public string? CdContract { get; set; }

    public string? CdFaseFz { get; set; }

    public double CdCao { get; set; }

    public string? CdAgh { get; set; }

    public string? CdZvw { get; set; }

    public double CvzWoonlandfactor { get; set; }

    public double KortingLevensloop { get; set; }

    public string? CdRedengeenbijtelling { get; set; }

    public string? CorrArbVerh { get; set; }

    public double BterUurloon { get; set; }

    public double TsfDagenOpg { get; set; }

    public short? Division { get; set; }

    public DateTime Syscreated { get; set; }

    public int Syscreator { get; set; }

    public DateTime Sysmodified { get; set; }

    public int Sysmodifier { get; set; }

    public Guid Sysguid { get; set; }

    public byte[] Timestamp { get; set; } = null!;
}
