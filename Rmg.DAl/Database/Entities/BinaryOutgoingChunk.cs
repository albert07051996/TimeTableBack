using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class BinaryOutgoingChunk
{
    public Guid MessageId { get; set; }

    public int Sequence { get; set; }

    public byte[] Data { get; set; } = null!;

    public DateTime CreatedDate { get; set; }
}
