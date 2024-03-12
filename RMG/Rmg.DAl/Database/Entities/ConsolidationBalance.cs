using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class ConsolidationBalance
{
    public int Id { get; set; }

    public string? Parent { get; set; }

    public string Division { get; set; } = null!;

    public string PresentationCurrency { get; set; } = null!;

    public string DivisionGl { get; set; } = null!;

    public short DivisionYear { get; set; }

    public string DivisionPeriod { get; set; } = null!;

    public double AmountDebit { get; set; }

    public double AmountCredit { get; set; }

    public string? DivisionCurrency { get; set; }

    public double DivisionAmountOriginal { get; set; }

    public double? ExchangeRate { get; set; }

    public int? ExchangeRateType { get; set; }

    public string? RecordType { get; set; }

    public string? ProcessOrigin { get; set; }

    public DateTime Created { get; set; }

    public int Creator { get; set; }

    public DateTime Modified { get; set; }

    public int Modifier { get; set; }
}
