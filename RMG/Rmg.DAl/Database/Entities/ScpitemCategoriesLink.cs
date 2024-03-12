using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class ScpitemCategoriesLink
{
    public Guid Id { get; set; }

    public string ItemCategoryCode { get; set; } = null!;

    public string ItemCode { get; set; } = null!;

    public DateTime? DateFrom { get; set; }

    public DateTime? DateTo { get; set; }
}
