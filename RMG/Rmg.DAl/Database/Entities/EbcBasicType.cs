using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class EbcBasicType
{
    public int BasicTypeId { get; set; }

    public string BasicTypeName { get; set; } = null!;

    public virtual ICollection<EbcPropType> EbcPropTypes { get; set; } = new List<EbcPropType>();
}
