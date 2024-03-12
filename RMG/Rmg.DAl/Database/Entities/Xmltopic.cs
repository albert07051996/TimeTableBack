using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class Xmltopic
{
    public Guid Id { get; set; }

    public string CompanyCode { get; set; } = null!;

    public string Topic { get; set; } = null!;

    public byte[] TopicTs { get; set; } = null!;

    public DateTime? TopicSm { get; set; }

    public short? Division { get; set; }
}
