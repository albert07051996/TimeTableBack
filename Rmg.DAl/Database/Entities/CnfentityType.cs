using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class CnfentityType
{
    public Guid Id { get; set; }

    public string EntityCode { get; set; } = null!;

    public string? Code { get; set; }

    public string Name { get; set; } = null!;

    public int? TermId { get; set; }

    public string? PluralName { get; set; }

    public int? PluralTermId { get; set; }

    public string? IconFilename { get; set; }

    public byte[]? IconImage { get; set; }

    public bool? IsDeployed { get; set; }

    public DateTime Syscreated { get; set; }

    public int Syscreator { get; set; }

    public DateTime Sysmodified { get; set; }

    public int Sysmodifier { get; set; }
}
