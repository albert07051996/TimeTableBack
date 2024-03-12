﻿using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class Btwtr
{
    public int Id { get; set; }

    public string? Btwtrans { get; set; }

    public string? CompanyCode { get; set; }

    public string? Oms300 { get; set; }

    public string? Oms301 { get; set; }

    public string? Oms302 { get; set; }

    public string? Oms303 { get; set; }

    public string? Oms304 { get; set; }

    public string? CodeIv { get; set; }

    public byte Verlegdbtw { get; set; }

    public double Btwper { get; set; }

    public string? Btwoms { get; set; }

    public string? Exclus { get; set; }

    public string? Landcode { get; set; }

    public string? Btwlist { get; set; }

    public string? Reknr { get; set; }

    public string? RekBtwVk { get; set; }

    public string? Tegreknr { get; set; }

    public string? Crednota { get; set; }

    public string? CredBtwcd { get; set; }

    public byte BtwVt { get; set; }

    public byte BtwVrij { get; set; }

    public byte BtwReg { get; set; }

    public double LevyPer { get; set; }

    public double InvestPer { get; set; }

    public string? AccInvtax { get; set; }

    public string? AccInvtdb { get; set; }

    public string? AccInvtcr { get; set; }

    public string? Creditor { get; set; }

    public string? PayPeriod { get; set; }

    public string? PurchaseType { get; set; }

    public double NonDeductiblePercentage { get; set; }

    public string? NonDeductibleAccount { get; set; }

    public string Taxtype { get; set; } = null!;

    public string Calculationbasis { get; set; } = null!;

    public string? AutofatturaCode { get; set; }

    public double? AmountMinimum { get; set; }

    public double? AmountMaximum { get; set; }

    public string? Taxkey { get; set; }

    public string? Taxsubkey { get; set; }

    public string? Rent { get; set; }

    public short? Division { get; set; }

    public string? VattoBeClaimed { get; set; }

    public bool PerpertualService { get; set; }

    public DateTime Syscreated { get; set; }

    public int Syscreator { get; set; }

    public DateTime Sysmodified { get; set; }

    public int Sysmodifier { get; set; }

    public Guid Sysguid { get; set; }

    public byte[] Timestamp { get; set; } = null!;
}
