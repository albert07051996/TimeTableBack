using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class SmsdefaultContractRatesHeader
{
    public Guid Id { get; set; }

    public Guid? Assortment { get; set; }

    public Guid? Item { get; set; }

    public string? AgreementType { get; set; }

    public Guid? AgreementSet { get; set; }

    public Guid? ResponseTime { get; set; }

    public Guid? Pmtype { get; set; }

    public Guid? AgreementDocument { get; set; }

    public Guid? Account { get; set; }

    public string? Currency { get; set; }

    public DateTime? StartDate { get; set; }

    public DateTime? EndDate { get; set; }

    public string? ItemCode { get; set; }

    public DateTime Syscreated { get; set; }

    public int Syscreator { get; set; }

    public DateTime Sysmodified { get; set; }

    public int Sysmodifier { get; set; }
}
