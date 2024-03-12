using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class BinaryIncomingChunks2
{
    public Guid MessageId { get; set; }

    public int Sequence { get; set; }

    public byte[] Data { get; set; } = null!;

    public DateTime CreatedDate { get; set; }
}
