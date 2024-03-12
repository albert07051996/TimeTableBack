using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class EbcEnabledState
{
    public int EnabledStateId { get; set; }

    public string? Description { get; set; }

    public virtual ICollection<EbcProp> EbcProps { get; set; } = new List<EbcProp>();
}
