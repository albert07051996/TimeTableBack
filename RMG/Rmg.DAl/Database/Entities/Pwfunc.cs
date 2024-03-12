using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class Pwfunc
{
    public int Id { get; set; }

    public string? FncId { get; set; }

    public string? Descr30 { get; set; }

    public int TermId { get; set; }

    public string? Exename { get; set; }

    public string? Param { get; set; }

    public string? AppType { get; set; }

    public string? OptionExp { get; set; }

    public string? Settings { get; set; }

    public byte Mpackage0 { get; set; }

    public byte Mpackage1 { get; set; }

    public byte Mpackage2 { get; set; }

    public byte Mpackage3 { get; set; }

    public byte Mpackage4 { get; set; }

    public byte Mpackage5 { get; set; }

    public byte Mpackage6 { get; set; }

    public byte Mpackage7 { get; set; }

    public string? Slic { get; set; }

    public string? Sparam { get; set; }

    public string? Origin { get; set; }

    public int Icon { get; set; }

    public byte Pwreg { get; set; }

    public string? Rtype { get; set; }

    public string? Descr64 { get; set; }

    public string? Helpcontext { get; set; }

    public short? Division { get; set; }

    public DateTime Syscreated { get; set; }

    public int Syscreator { get; set; }

    public DateTime Sysmodified { get; set; }

    public int Sysmodifier { get; set; }

    public Guid Sysguid { get; set; }

    public byte[] Timestamp { get; set; } = null!;
}
