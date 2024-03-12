using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class WordReference
{
    public int Word { get; set; }

    public Guid Entity { get; set; }

    public int EntityType { get; set; }

    public int SecurityLevel { get; set; }

    public string? Language { get; set; }

    public int? Score { get; set; }

    public bool? InSubject { get; set; }

    public bool? InSummary { get; set; }

    public int? InDocCount { get; set; }

    public int? InAttachmentCount { get; set; }

    public Guid? SubEntity { get; set; }
}
