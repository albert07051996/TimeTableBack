using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class TimesheetInternalRate
{
    public Guid Id { get; set; }

    public int ResId { get; set; }

    public DateTime StartDate { get; set; }

    public DateTime EndDate { get; set; }

    public double Rate { get; set; }

    public byte? RateType { get; set; }

    public string? ItemCode { get; set; }

    public double SalesPrice { get; set; }

    public string? CurrencySalesPrice { get; set; }

    public string? CurrencyCost { get; set; }

    public double? IntercompanyRate { get; set; }

    public string? CurrencyIntercompany { get; set; }

    public bool UseSalesRate { get; set; }

    public bool UseCostRate { get; set; }

    public DateTime Syscreated { get; set; }

    public int Syscreator { get; set; }

    public DateTime Sysmodified { get; set; }

    public int Sysmodifier { get; set; }

    public Guid Sysguid { get; set; }
}
