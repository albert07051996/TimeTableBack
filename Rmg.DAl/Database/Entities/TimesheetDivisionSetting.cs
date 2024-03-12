using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class TimesheetDivisionSetting
{
    public Guid Id { get; set; }

    public string? Division { get; set; }

    public string? PurchaseJournal { get; set; }

    public string? GeneralJournal { get; set; }

    public string? Wipjournal { get; set; }

    public string? LedgerWip { get; set; }

    public string? LedgerWipchange { get; set; }

    public int Creator { get; set; }

    public DateTime Created { get; set; }

    public int Modifier { get; set; }

    public DateTime Modified { get; set; }

    public Guid Sysguid { get; set; }
}
