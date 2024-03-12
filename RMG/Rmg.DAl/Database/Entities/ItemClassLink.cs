using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class ItemClassLink
{
    public Guid Id { get; set; }

    public int Assortment { get; set; }

    public int ClassId { get; set; }

    public string ItemClassCode { get; set; } = null!;

    public short? Division { get; set; }

    public DateTime Syscreated { get; set; }

    public int Syscreator { get; set; }

    public DateTime Sysmodified { get; set; }

    public int Sysmodifier { get; set; }
}
