using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class Betcd
{
    public int Id { get; set; }

    public string? Betcond { get; set; }

    public string? Oms300 { get; set; }

    public string? Oms301 { get; set; }

    public string? Oms302 { get; set; }

    public string? Oms303 { get; set; }

    public string? Oms304 { get; set; }

    public string? Kredbep { get; set; }

    public short Kbdagen { get; set; }

    public short Kbdagen2 { get; set; }

    public double Percentag { get; set; }

    public double Percentag2 { get; set; }

    public short Termijn { get; set; }

    public short Dagvmnd { get; set; }

    public short Maanden { get; set; }

    public string? TypeVerv { get; set; }

    public string? BrutNetF { get; set; }

    public byte Termijnen { get; set; }

    public string? TypeVerv1 { get; set; }

    public string? TypeVerv2 { get; set; }

    public string? TypeVerv3 { get; set; }

    public string? TypeVerv4 { get; set; }

    public string? TypeVerv5 { get; set; }

    public short Termijn1 { get; set; }

    public short Termijn2 { get; set; }

    public short Termijn3 { get; set; }

    public short Termijn4 { get; set; }

    public short Termijn5 { get; set; }

    public double IntPerc { get; set; }

    public string? BrutNetP { get; set; }

    public short? Division { get; set; }

    public DateTime Syscreated { get; set; }

    public int Syscreator { get; set; }

    public DateTime Sysmodified { get; set; }

    public int Sysmodifier { get; set; }

    public Guid Sysguid { get; set; }

    public byte[] Timestamp { get; set; } = null!;
}
