using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class Blob
{
    public string BlobKey { get; set; } = null!;

    public string? Description { get; set; }

    public DateTime? Created { get; set; }

    public byte[]? BlobData { get; set; }

    public short? Division { get; set; }

    public byte[] Timestamp { get; set; } = null!;
}
