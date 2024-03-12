using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class Event
{
    public Guid Id { get; set; }

    public Guid OwnerId { get; set; }

    public int Type { get; set; }

    public DateTime Start { get; set; }

    public DateTime End { get; set; }

    public string Name { get; set; } = null!;

    public string? Description { get; set; }

    public string? Venue { get; set; }

    public int Scope { get; set; }

    public bool WholeDay { get; set; }

    public Guid CreatorId { get; set; }

    public DateTime CreatedDate { get; set; }

    public Guid? ModifierId { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public string? Metadata { get; set; }
}
