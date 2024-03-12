using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class Dnbdunsaggregate
{
    public int Id { get; set; }

    public int ParentId { get; set; }

    public string Aggregatetype { get; set; } = null!;

    public byte Scoregroup { get; set; }

    public string? AlgmId { get; set; }

    public DateTime? AsmtDt { get; set; }

    public double DefuIndn { get; set; }

    public string? DelqScrEntr { get; set; }

    public string? FailScrEntr { get; set; }

    public string? GlblFailScrEntr { get; set; }

    public string? IndsDefuIndn { get; set; }

    public string? IndsNorm { get; set; }

    public double IndsPctl { get; set; }

    public string? NatlPctl { get; set; }

    public double Scr { get; set; }

    public double ScrAge { get; set; }

    public double ScrClas { get; set; }

    public string? ScrCmtyCd { get; set; }

    public double ScrGrp { get; set; }

    public string? ScrOvrdCd { get; set; }

    public DateTime Syscreated { get; set; }

    public int Syscreator { get; set; }

    public DateTime Sysmodified { get; set; }

    public int Sysmodifier { get; set; }

    public Guid Sysguid { get; set; }

    public byte[] Timestamp { get; set; } = null!;
}
