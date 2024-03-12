using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class Note
{
    public int Id { get; set; }

    public string? Note1 { get; set; }

    public Guid? Guid { get; set; }

    public short? Division { get; set; }

    public byte[] Timestamp { get; set; } = null!;
}
