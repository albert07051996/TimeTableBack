using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class CnfmenuApplication
{
    public Guid Id { get; set; }

    public string Code { get; set; } = null!;

    public string ConfigurationCode { get; set; } = null!;

    public Guid MenuTabId { get; set; }

    public Guid MenuSectionId { get; set; }

    public string Title { get; set; } = null!;

    public int? TitleTermId { get; set; }

    public string? Link { get; set; }

    public int? LinkType { get; set; }

    public string? LinkEntityCode { get; set; }

    public string? EntityType { get; set; }

    public int? Position { get; set; }

    public DateTime Syscreated { get; set; }

    public int Syscreator { get; set; }

    public DateTime Sysmodified { get; set; }

    public int Sysmodifier { get; set; }
}
