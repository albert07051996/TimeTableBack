using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class ItemCountryTranslation
{
    public Guid Id { get; set; }

    public Guid ItemCountryId { get; set; }

    public string LanguageCode { get; set; } = null!;

    public string? Description { get; set; }

    public string? Note { get; set; }

    public short? Division { get; set; }

    public int Modifier { get; set; }

    public DateTime Modified { get; set; }

    public byte[] Timestamp { get; set; } = null!;
}
