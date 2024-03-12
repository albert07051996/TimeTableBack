using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class Staffl
{
    public int Id { get; set; }

    public string? Prijslijst { get; set; }

    public string? Artcode { get; set; }

    public string? KortPbn { get; set; }

    public double Prijs83 { get; set; }

    public double Aantal1 { get; set; }

    public double Bedr1 { get; set; }

    public double Aantal2 { get; set; }

    public double Bedr2 { get; set; }

    public double Aantal3 { get; set; }

    public double Bedr3 { get; set; }

    public double Aantal4 { get; set; }

    public double Bedr4 { get; set; }

    public double Aantal5 { get; set; }

    public double Bedrag5 { get; set; }

    public double Quantity6 { get; set; }

    public double Price6 { get; set; }

    public double Quantity7 { get; set; }

    public double Price7 { get; set; }

    public double Quantity8 { get; set; }

    public double Price8 { get; set; }

    public double Quantity9 { get; set; }

    public double Price9 { get; set; }

    public double Quantity10 { get; set; }

    public double Price10 { get; set; }

    public Guid? AccountId { get; set; }

    public string? Unitcode { get; set; }

    public double Unitfactor { get; set; }

    public DateTime? Validfrom { get; set; }

    public DateTime? Validto { get; set; }

    public string? Project { get; set; }

    public string LineType { get; set; } = null!;

    public short? Division { get; set; }

    public DateTime Syscreated { get; set; }

    public int Syscreator { get; set; }

    public DateTime Sysmodified { get; set; }

    public int Sysmodifier { get; set; }

    public Guid Sysguid { get; set; }

    public byte[] Timestamp { get; set; } = null!;
}
