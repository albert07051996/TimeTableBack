using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class EntityFinancialTransaction
{
    public Guid TableKey { get; set; }

    public Guid TransactionKey { get; set; }

    public string? EntityName { get; set; }

    public string? Xmldata { get; set; }

    public byte? Status { get; set; }

    public string? LogText { get; set; }

    public string? Division { get; set; }

    public DateTime SysCreated { get; set; }

    public int SysCreator { get; set; }
}
