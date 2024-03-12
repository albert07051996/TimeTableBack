using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class AddressType
{
    public string Id { get; set; } = null!;

    public int Idcol { get; set; }

    public string Description { get; set; } = null!;

    public byte IsUserDefined { get; set; }

    public int? TermId { get; set; }

    public short? Division { get; set; }

    public DateTime Syscreated { get; set; }

    public int Syscreator { get; set; }

    public DateTime Sysmodified { get; set; }

    public int Sysmodifier { get; set; }

    public Guid Sysguid { get; set; }
}
