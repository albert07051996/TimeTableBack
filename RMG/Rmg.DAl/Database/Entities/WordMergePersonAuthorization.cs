using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class WordMergePersonAuthorization
{
    public Guid Id { get; set; }

    public Guid ItemId { get; set; }

    public int? ResId { get; set; }

    public string? Divisions { get; set; }

    public DateTime Syscreated { get; set; }

    public int Syscreator { get; set; }

    public DateTime Sysmodified { get; set; }

    public int Sysmodifier { get; set; }
}
