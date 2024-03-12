using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class PublicHoliday
{
    public Guid Id { get; set; }

    public DateTime Date { get; set; }

    public string? Country { get; set; }

    public string? Description { get; set; }

    public bool Deduct { get; set; }

    public string? Division { get; set; }

    public string? MainLoc { get; set; }

    public short? DivisionX { get; set; }

    public DateTime Syscreated { get; set; }

    public int Syscreator { get; set; }

    public DateTime Sysmodified { get; set; }

    public int Sysmodifier { get; set; }
}
