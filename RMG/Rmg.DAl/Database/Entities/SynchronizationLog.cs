using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class SynchronizationLog
{
    public int Id { get; set; }

    public DateTime? LogDate { get; set; }

    public Guid? TransactionId { get; set; }

    public Guid? MessageId { get; set; }

    public string? Destination { get; set; }

    public string? Message { get; set; }

    public string? EntityName { get; set; }

    public string? Action { get; set; }

    public string? LogicalKey { get; set; }
}
