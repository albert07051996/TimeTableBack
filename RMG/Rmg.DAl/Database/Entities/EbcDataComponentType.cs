﻿using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class EbcDataComponentType
{
    public int DataComponentTypeId { get; set; }

    public string? Description { get; set; }

    public virtual ICollection<EbcComponent> EbcComponents { get; set; } = new List<EbcComponent>();
}
