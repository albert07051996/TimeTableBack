using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class BacoDiscussionLayoutLanguage
{
    public Guid Id { get; set; }

    public string BdlayoutId { get; set; } = null!;

    public short? Division { get; set; }

    public string? Taalcode { get; set; }
}
