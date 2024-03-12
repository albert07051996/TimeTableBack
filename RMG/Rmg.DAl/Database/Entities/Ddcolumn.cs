using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class Ddcolumn
{
    public int Id { get; set; }

    public string Tablename { get; set; } = null!;

    public string ColumnName { get; set; } = null!;

    public string? Description { get; set; }

    public int Type { get; set; }

    public int Length { get; set; }

    public int Scale { get; set; }

    public int Dimensions { get; set; }

    public int TermId { get; set; }

    public int SeqNr { get; set; }

    public int Flags { get; set; }

    public int GroupId { get; set; }

    public int UserLevel { get; set; }

    public string? Suffix { get; set; }

    public int? SuffixId { get; set; }

    public int DefinitionMeasure { get; set; }

    public bool AllowAnonymize { get; set; }
}
