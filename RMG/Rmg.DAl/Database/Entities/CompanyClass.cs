using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class CompanyClass
{
    public Guid Id { get; set; }

    public int ClassId { get; set; }

    public string CompanyClassCode { get; set; } = null!;

    public string? Description { get; set; }

    public string? ParentClassCode { get; set; }

    public int Level { get; set; }

    public short? Division { get; set; }

    public byte[] Timestamp { get; set; } = null!;
}
