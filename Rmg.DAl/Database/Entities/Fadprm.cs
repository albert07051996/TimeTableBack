using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class Fadprm
{
    public int Id { get; set; }

    public string? Deprmeth { get; set; }

    public string? Entrymeth { get; set; }

    public string? Descr500 { get; set; }

    public string? Descr501 { get; set; }

    public string? Descr502 { get; set; }

    public string? Descr503 { get; set; }

    public string? Descr504 { get; set; }

    public string? Deprcode { get; set; }

    public string? Numyears { get; set; }

    public string? Numperiods { get; set; }

    public string? Calcbasis { get; set; }

    public double Fixedamtper { get; set; }

    public double Percper { get; set; }

    public double Percper2 { get; set; }

    public short Prec { get; set; }

    public string? Roundcase { get; set; }

    public string? Roundtype { get; set; }

    public string? Startdeprcase { get; set; }

    public string? Changetolnr { get; set; }

    public string? Lnrcalctype { get; set; }

    public double Perfamt { get; set; }

    public byte Deprfulldisp { get; set; }

    public string? Depryearactv { get; set; }

    public string? Hghrdepradj { get; set; }

    public string? Lwrdepradj { get; set; }

    public string? Fiscaltype { get; set; }

    public string? DeprInPerDisp { get; set; }

    public byte ProRataCalc { get; set; }

    public string? Country { get; set; }

    public byte UseNbv { get; set; }

    public DateTime? Nbvdate { get; set; }

    public string? NewPeriods { get; set; }

    public short? Division { get; set; }

    public DateTime Syscreated { get; set; }

    public int Syscreator { get; set; }

    public DateTime Sysmodified { get; set; }

    public int Sysmodifier { get; set; }

    public Guid Sysguid { get; set; }

    public byte[] Timestamp { get; set; } = null!;
}
