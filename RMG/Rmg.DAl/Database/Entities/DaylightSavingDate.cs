using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class DaylightSavingDate
{
    public Guid Id { get; set; }

    public int TimeZoneId { get; set; }

    public DateTime StartDate { get; set; }

    public DateTime EndDate { get; set; }

    public int Bias { get; set; }

    public short? Division { get; set; }
}
