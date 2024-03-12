using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class BankAccountsView
{
    public string BankAccount { get; set; } = null!;

    public int? HumanResourceId { get; set; }

    public string BankAccountIncludingMask { get; set; } = null!;

    public string CurrencyCode { get; set; } = null!;

    public string? Swiftcode { get; set; }

    public string? Biccode { get; set; }

    public string Description { get; set; } = null!;

    public double CurrentBalance { get; set; }

    public DateTime? ExpiryDate { get; set; }

    public string? IdentificationNumberBank { get; set; }

    public string? IdentificationNumberBankOffice { get; set; }

    public string? InternetAddress { get; set; }

    public DateTime? StartDate { get; set; }

    public string BankAccountType { get; set; } = null!;

    public double CreditLine { get; set; }

    public string? Notes { get; set; }

    public Guid? NameAddressDateBank { get; set; }

    public string? LedgerAccount { get; set; }

    public string? PaymentInTransitAccount { get; set; }

    public string? Bedrnr { get; set; }

    public DateTime Syscreated { get; set; }

    public int Syscreator { get; set; }

    public DateTime Sysmodified { get; set; }

    public int Sysmodifier { get; set; }

    public Guid Sysguid { get; set; }

    public int Id { get; set; }

    public string? Creditor { get; set; }

    public string? AccountNumberBank { get; set; }

    public string? ShortDescription { get; set; }

    public string? BankAddress1 { get; set; }

    public string? BankAddress2 { get; set; }

    public string? BankCity { get; set; }

    public string? BankCountryCode { get; set; }

    public string? BankCountry0 { get; set; }

    public string? BankName { get; set; }

    public string? BankPostCode { get; set; }

    public Guid? ContactId { get; set; }

    public string? ContactEmail { get; set; }

    public string? ContactFaxNumber { get; set; }

    public string? ContactJobDescription { get; set; }

    public string? ContactName { get; set; }

    public string? ContactPhoneExtension { get; set; }

    public string? ContactPhoneNumber { get; set; }

    public string? CurrencyDescription0 { get; set; }

    public string? CurrencyDescription1 { get; set; }

    public string? CurrencyDescription2 { get; set; }

    public string? CurrencyDescription3 { get; set; }

    public string? CurrencyDescription4 { get; set; }

    public string? HumanResourceFullName { get; set; }

    public string? BankCountry1 { get; set; }

    public string? BankCountry2 { get; set; }

    public string? BankCountry3 { get; set; }

    public string? BankCountry4 { get; set; }

    public int LandId { get; set; }
}
