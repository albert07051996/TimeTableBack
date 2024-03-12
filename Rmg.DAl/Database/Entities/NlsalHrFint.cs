using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class NlsalHrFint
{
    public int Id { get; set; }

    public string CompType { get; set; } = null!;

    public string? Kol18B { get; set; }

    public int? Frch { get; set; }

    public string? TypeSpln { get; set; }

    public double? BdrOnb { get; set; }

    public bool DgtoeZiek { get; set; }

    public bool DgtoeVak { get; set; }

    public bool DgtoeAtv { get; set; }

    public bool ResVak { get; set; }

    public bool Res13eM { get; set; }

    public bool PensmeeJn { get; set; }

    public bool VutmeeJn { get; set; }

    public bool WgatmeeJn { get; set; }

    public string? LbkTypen { get; set; }

    public string? ToeSrt { get; set; }

    public string? Gbknr { get; set; }

    public bool? UseInTaxReduction { get; set; }

    public short? Division { get; set; }
}
