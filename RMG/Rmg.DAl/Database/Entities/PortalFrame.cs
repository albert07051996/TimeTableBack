using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class PortalFrame
{
    public Guid Id { get; set; }

    public string? Name { get; set; }

    public Guid Portal { get; set; }

    public int Position { get; set; }

    public int? Width { get; set; }

    public int? Height { get; set; }

    public Guid? Document { get; set; }

    public string? NewsLayout { get; set; }

    public string? Url { get; set; }

    public short? Division { get; set; }

    public DateTime Syscreated { get; set; }

    public int? Syscreator { get; set; }

    public DateTime Sysmodified { get; set; }

    public int? Sysmodifier { get; set; }
}
