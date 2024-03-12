using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class Pospreset
{
    public int Id { get; set; }

    public string Type { get; set; } = null!;

    public string? Code { get; set; }

    public string? Line { get; set; }

    public string? Oms300 { get; set; }

    public string? Oms301 { get; set; }

    public string? Oms302 { get; set; }

    public string? Oms303 { get; set; }

    public string? Oms304 { get; set; }

    public byte Shiftkeys { get; set; }

    public short Vbkey { get; set; }

    public short Shift { get; set; }

    public short Posfunction { get; set; }

    public string? Fixedval { get; set; }

    public Guid? Account { get; set; }

    public string? Valcode { get; set; }

    public double RoundFact { get; set; }

    public byte OpenDrawer { get; set; }

    public byte PrintRcp { get; set; }

    public short InvoiceCopies { get; set; }

    public string? Layout { get; set; }

    public int Change { get; set; }

    public string LimitType { get; set; } = null!;

    public double Limit { get; set; }

    public string? BankAccount { get; set; }

    public string PaymentType { get; set; } = null!;

    public string? LedgerAccount { get; set; }

    public int RoleId { get; set; }

    public string CashCount { get; set; } = null!;

    public Guid? GroupBy { get; set; }

    public string? Coin { get; set; }

    public short? Division { get; set; }

    public DateTime Syscreated { get; set; }

    public int Syscreator { get; set; }

    public DateTime Sysmodified { get; set; }

    public int Sysmodifier { get; set; }

    public Guid Sysguid { get; set; }
}
