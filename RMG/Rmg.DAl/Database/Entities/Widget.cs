using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class Widget
{
    public Guid Id { get; set; }

    public int? WidgetType { get; set; }

    public int? EntityType { get; set; }

    public string? EntityKey { get; set; }

    public string? Widgets { get; set; }

    public DateTime? Syscreated { get; set; }

    public int? Syscreator { get; set; }

    public DateTime? Sysmodified { get; set; }

    public int? Sysmodifier { get; set; }
}
