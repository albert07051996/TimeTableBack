using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class ActivityNotification
{
    public Guid Id { get; set; }

    public Guid SenderId { get; set; }

    public Guid ReceiverId { get; set; }

    public int Type { get; set; }

    public DateTime ActionDate { get; set; }

    public string ReferenceObject { get; set; } = null!;

    public bool Seen { get; set; }

    public string? Description { get; set; }

    public Guid? OwnerId { get; set; }
}
