using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class Layout
{
    public int Id { get; set; }

    public int Laytype { get; set; }

    public string Name { get; set; } = null!;

    public string Descr39 { get; set; } = null!;

    public int Descr39Termid { get; set; }

    public byte StdLayout { get; set; }

    public string StdCountry { get; set; } = null!;

    public byte[]? Layout1 { get; set; }

    public byte TntpostLayout { get; set; }

    public short? Division { get; set; }

    public DateTime Syscreated { get; set; }

    public int Syscreator { get; set; }

    public DateTime Sysmodified { get; set; }

    public int Sysmodifier { get; set; }

    public Guid Sysguid { get; set; }
}
