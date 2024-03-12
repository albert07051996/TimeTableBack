using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class XmlreplicationSource
{
    public Guid Id { get; set; }

    public string Name { get; set; } = null!;

    public string WebSite { get; set; } = null!;

    public short? Division { get; set; }

    public DateTime Syscreated { get; set; }

    public int Syscreator { get; set; }

    public DateTime Sysmodified { get; set; }

    public int Sysmodifier { get; set; }
}
