using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class Fagrp
{
    public int Id { get; set; }

    public string? Assetgroup { get; set; }

    public string? Descr500 { get; set; }

    public string? Descr501 { get; set; }

    public string? Descr502 { get; set; }

    public string? Descr503 { get; set; }

    public string? Descr504 { get; set; }

    public string? Primarymeth { get; set; }

    public string? Secondarymeth { get; set; }

    public string? Kstdrcode { get; set; }

    public string? Kstplcode { get; set; }

    public string? Reference1 { get; set; }

    public string? Reference2 { get; set; }

    public double Valuelimit { get; set; }

    public string? Fiscalgroup { get; set; }

    public string? AssetAc { get; set; }

    public string? DeprBs { get; set; }

    public string? DeprPl { get; set; }

    public string? Extra { get; set; }

    public string? SpecialDeprBs { get; set; }

    public string? SpecialDeprPl { get; set; }

    public string? WriteOffBalanceSheet { get; set; }

    public string? WriteOffProfitLoss { get; set; }

    public string? VatcorrectionJournal { get; set; }

    public string? VatcorrectionExpenseGl { get; set; }

    public string? VatcorrectionRevenueGl { get; set; }

    public short? Division { get; set; }

    public DateTime Syscreated { get; set; }

    public int Syscreator { get; set; }

    public DateTime Sysmodified { get; set; }

    public int Sysmodifier { get; set; }

    public Guid Sysguid { get; set; }

    public byte[] Timestamp { get; set; } = null!;
}
