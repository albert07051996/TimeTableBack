using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class Subledgermasterview
{
    public string? SubledgerNo { get; set; }

    public string? Naam { get; set; }

    public string? Adres1 { get; set; }

    public string? Postcode { get; set; }

    public string? Woonpl { get; set; }

    public string? Landcode { get; set; }

    public string? SearchCode { get; set; }

    public string? Telnr { get; set; }

    public string? Cntpers1 { get; set; }

    public string? Mv1 { get; set; }

    public string? Functie1 { get; set; }

    public string? Telnrcp1 { get; set; }

    public double Kredlimiet { get; set; }

    public string? Tegreknr { get; set; }

    public string SubledgerType { get; set; } = null!;
}
