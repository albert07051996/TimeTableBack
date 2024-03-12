using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class Scptranslation
{
    public Guid Id { get; set; }

    public string Entity { get; set; } = null!;

    public string Code { get; set; } = null!;

    public string Language { get; set; } = null!;

    public string? Translation { get; set; }

    public DateTime Syscreated { get; set; }

    public int Syscreator { get; set; }

    public DateTime Sysmodified { get; set; }

    public int Sysmodifier { get; set; }
}
