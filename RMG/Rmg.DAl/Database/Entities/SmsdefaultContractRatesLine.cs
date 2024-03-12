using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class SmsdefaultContractRatesLine
{
    public Guid Id { get; set; }

    public Guid? DefaultContractRateHeader { get; set; }

    public string? Frequency { get; set; }

    public double? Rate { get; set; }
}
