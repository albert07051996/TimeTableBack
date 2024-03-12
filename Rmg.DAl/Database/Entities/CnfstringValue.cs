using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class CnfstringValue
{
    public int Id { get; set; }

    public string DatabaseChar { get; set; } = null!;

    public string Tablename { get; set; } = null!;

    public string FieldName { get; set; } = null!;

    public string DisplayChar { get; set; } = null!;

    public string Description { get; set; } = null!;

    public int TermId { get; set; }

    public string? Options { get; set; }

    public int SeqNr { get; set; }

    public DateTime Syscreated { get; set; }

    public int Syscreator { get; set; }

    public DateTime Sysmodified { get; set; }

    public int Sysmodifier { get; set; }
}
