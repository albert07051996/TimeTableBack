using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class Word
{
    public int Id { get; set; }

    public string Word1 { get; set; } = null!;

    public int? UsedCount { get; set; }

    public int UsedCountDocuments { get; set; }

    public int UsedCountRequests { get; set; }

    public int UsedCountAttachments { get; set; }
}
