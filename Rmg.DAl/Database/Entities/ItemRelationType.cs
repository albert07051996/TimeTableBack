using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class ItemRelationType
{
    public int Type { get; set; }

    public string? Description { get; set; }

    public int State { get; set; }

    public bool ValidateForContract { get; set; }

    public bool SuggestInShop { get; set; }

    public int SecurityLevel { get; set; }

    public short? Division { get; set; }

    public byte[] Timestamp { get; set; } = null!;
}
