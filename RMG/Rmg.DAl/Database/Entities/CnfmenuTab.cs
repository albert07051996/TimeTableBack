using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class CnfmenuTab
{
    public Guid Id { get; set; }

    public string ConfigurationCode { get; set; } = null!;

    public string Title { get; set; } = null!;

    public int? TitleTermId { get; set; }

    public int? Position { get; set; }

    public DateTime Syscreated { get; set; }

    public int Syscreator { get; set; }

    public DateTime Sysmodified { get; set; }

    public int Sysmodifier { get; set; }
}
