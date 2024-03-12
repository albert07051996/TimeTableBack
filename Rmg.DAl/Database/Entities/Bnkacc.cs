using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class Bnkacc
{
    public int Id { get; set; }

    public string? Banknr { get; set; }

    public Guid? AccountId { get; set; }

    public string? Accncd { get; set; }

    public string? Bnkaccmsk { get; set; }

    public string? Naam { get; set; }

    public string? Adres1 { get; set; }

    public string? Adres2 { get; set; }

    public string? Adres3 { get; set; }

    public string? Postcode { get; set; }

    public string? Woonpl { get; set; }

    public string? Landcode { get; set; }

    public string? Telnr { get; set; }

    public string? Faxnr { get; set; }

    public string? Cntpers1 { get; set; }

    public string? Mv1 { get; set; }

    public string? Prdcode1 { get; set; }

    public string? Vrlttrs1 { get; set; }

    public string? Functie1 { get; set; }

    public string? Telnrcp1 { get; set; }

    public string? Pstbanknrb { get; set; }

    public string? BankRek { get; set; }

    public string? Swiftadres { get; set; }

    public string? Bankcode { get; set; }

    public string? Valcode { get; set; }

    public string? Natbnc { get; set; }

    public string? ContVeld { get; set; }

    public string? Branchcode { get; set; }

    public string? BranchName { get; set; }

    public string? CreditCardName { get; set; }

    public string? CreditCardType { get; set; }

    public string? CreditCardSecurityCode { get; set; }

    public DateTime? CreditCardExpiryDate { get; set; }

    public short? Division { get; set; }

    public string? Iban { get; set; }

    public string? Biccode { get; set; }

    public DateTime Syscreated { get; set; }

    public int Syscreator { get; set; }

    public DateTime Sysmodified { get; set; }

    public int Sysmodifier { get; set; }

    public Guid Sysguid { get; set; }

    public byte[] Timestamp { get; set; } = null!;
}
