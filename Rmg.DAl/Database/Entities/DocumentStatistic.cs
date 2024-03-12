using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class DocumentStatistic
{
    public Guid Document { get; set; }

    public int ReferencesOut { get; set; }

    public int ReferencesIn { get; set; }

    public byte[] Timestamp { get; set; } = null!;
}
