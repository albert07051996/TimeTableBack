using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class PartnerActivation
{
    public Guid ActivationId { get; set; }

    public string ActivationId2 { get; set; } = null!;

    public int LogId { get; set; }

    public DateTime ActDate { get; set; }

    public string ActKey { get; set; } = null!;

    public bool ActIsNew { get; set; }

    public short TotalRequest { get; set; }

    public short TotalLog { get; set; }

    public short ActStatus { get; set; }

    public Guid? PrevActivationId { get; set; }

    public DateTime Syscreated { get; set; }

    public int Syscreator { get; set; }

    public DateTime? Sysmodified { get; set; }

    public int? Sysmodifier { get; set; }
}
