using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class BankAccount
{
    public string BankAccount1 { get; set; } = null!;

    public int Id { get; set; }

    public int? HumanResourceId { get; set; }

    public Guid? NameAddressDateBank { get; set; }

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

    public string? LedgerAccount { get; set; }

    public string? PaymentInTransitAccount { get; set; }

    public string? Bedrnr { get; set; }

    public string? Creditor { get; set; }

    public string? AccountNumberBank { get; set; }

    public string? LandIsonr { get; set; }

    public string? BankName { get; set; }

    public double CostsPayments { get; set; }

    public double CostsReceipts { get; set; }

    public double DebitInterest { get; set; }

    public double CreditInterest { get; set; }

    public int? MaxLines { get; set; }

    public double? MaxAmount { get; set; }

    public string Purpose { get; set; } = null!;

    public string? DocumentNumber { get; set; }

    public double FixedCostsYr { get; set; }

    public Guid? DocAttachmentId { get; set; }

    public byte Blocked { get; set; }

    public double CostsPaymentRun { get; set; }

    public string? CreditCardType { get; set; }

    public string? PresetCode { get; set; }

    public string? MenuBar { get; set; }

    public string? Eftterminal { get; set; }

    public string? Eftport { get; set; }

    public string? Cardreader { get; set; }

    public string? CrdrPort { get; set; }

    public short Fontsize { get; set; }

    public string? Colfield0 { get; set; }

    public int Colwidth0 { get; set; }

    public string? Colfield1 { get; set; }

    public int Colwidth1 { get; set; }

    public string? Colfield2 { get; set; }

    public int Colwidth2 { get; set; }

    public string? Colfield3 { get; set; }

    public int Colwidth3 { get; set; }

    public string? Colfield4 { get; set; }

    public int Colwidth4 { get; set; }

    public string? Colfield5 { get; set; }

    public int Colwidth5 { get; set; }

    public string? Colfield6 { get; set; }

    public int Colwidth6 { get; set; }

    public string? Colfield7 { get; set; }

    public int Colwidth7 { get; set; }

    public string? Colfield8 { get; set; }

    public int Colwidth8 { get; set; }

    public string? Colfield9 { get; set; }

    public int Colwidth9 { get; set; }

    public string? Colfield10 { get; set; }

    public int Colwidth10 { get; set; }

    public string? InvoiceLayout { get; set; }

    public byte PrintLayout { get; set; }

    public string? Magcode { get; set; }

    public byte CountMandatory { get; set; }

    public double LimitAmount { get; set; }

    public byte CashierMandatory { get; set; }

    public string? Journal { get; set; }

    public byte Excluding { get; set; }

    public string? Header1 { get; set; }

    public string? Header2 { get; set; }

    public string? Header3 { get; set; }

    public string? Header4 { get; set; }

    public string? Trailer1 { get; set; }

    public string? Trailer2 { get; set; }

    public string? Trailer3 { get; set; }

    public string? Trailer4 { get; set; }

    public string? AccountSequenceNumber { get; set; }

    public string Cashier { get; set; } = null!;

    public byte? DebtorMandatory { get; set; }

    public string BankAccountRef { get; set; } = null!;

    public string? ProcessorCode { get; set; }

    public string? MerchantNumber { get; set; }

    public string? PcchargeDirectory { get; set; }

    public string? ActiveLdpcode { get; set; }

    public string? InActiveLdpcode { get; set; }

    public string? Officenumber { get; set; }

    public string? Contractnumber { get; set; }

    public string? Suffix { get; set; }

    public short? Division { get; set; }

    public DateTime Syscreated { get; set; }

    public int Syscreator { get; set; }

    public DateTime Sysmodified { get; set; }

    public int Sysmodifier { get; set; }

    public Guid Sysguid { get; set; }

    public string? Iban { get; set; }
}
