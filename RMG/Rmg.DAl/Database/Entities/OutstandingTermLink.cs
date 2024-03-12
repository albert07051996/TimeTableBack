using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class OutstandingTermLink
{
    public Guid Id { get; set; }

    public Guid? TermGuid { get; set; }

    public Guid? RequestGuid { get; set; }

    public byte[] Bttimestamp { get; set; } = null!;

    public byte[] Gbtimestamp { get; set; } = null!;
}
