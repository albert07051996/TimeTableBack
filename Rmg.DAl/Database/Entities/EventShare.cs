using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class EventShare
{
    public Guid Id { get; set; }

    public Guid EventId { get; set; }

    public Guid ShareToId { get; set; }

    public int Status { get; set; }

    public bool IsCoOrganizer { get; set; }

    public bool IsInvited { get; set; }
}
