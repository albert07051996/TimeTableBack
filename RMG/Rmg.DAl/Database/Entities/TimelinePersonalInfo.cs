using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class TimelinePersonalInfo
{
    public int Id { get; set; }

    public int ResourceId { get; set; }

    public string? PersonalInfoXml { get; set; }
}
