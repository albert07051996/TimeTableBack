using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class AccountConversionType
{
    public int AccountConversionType1 { get; set; }

    public string? Description { get; set; }

    public int DescriptionTermId { get; set; }

    public short? Division { get; set; }

    public byte[] Timestamp { get; set; } = null!;
}
