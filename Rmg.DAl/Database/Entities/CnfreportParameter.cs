using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class CnfreportParameter
{
    public Guid Id { get; set; }

    public string EntityCode { get; set; } = null!;

    public string TabCode { get; set; } = null!;

    public Guid Idreport { get; set; }

    public Guid? Idparameter { get; set; }

    public string Name { get; set; } = null!;

    public string? DefaultValue { get; set; }

    public DateTime Syscreated { get; set; }

    public int Syscreator { get; set; }

    public DateTime Sysmodified { get; set; }

    public int Sysmodifier { get; set; }
}
