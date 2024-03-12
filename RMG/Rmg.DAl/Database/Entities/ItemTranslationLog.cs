using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class ItemTranslationLog
{
    public int Id { get; set; }

    public string ItemCode { get; set; } = null!;

    public string LanguageCode { get; set; } = null!;

    public int Action { get; set; }

    public string? OldValue { get; set; }

    public string? NewValue { get; set; }

    public DateTime LogDate { get; set; }

    public int ResourceId { get; set; }

    public short? Division { get; set; }
}
