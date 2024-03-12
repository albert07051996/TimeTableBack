using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class TagReference
{
    public int Id { get; set; }

    public int TagId { get; set; }

    public string Tag { get; set; } = null!;

    public Guid Entity { get; set; }

    public int EntityType { get; set; }

    public int CreatedBy { get; set; }

    public DateTime CreatedDate { get; set; }

    public byte[] TimeStamp { get; set; } = null!;

    public bool Deleted { get; set; }

    public short? Division { get; set; }
}
