using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class BacoDiscussionSubCategory
{
    public Guid Id { get; set; }

    public int GroupId { get; set; }

    public Guid? CategoryId { get; set; }

    public string Category { get; set; } = null!;

    public string SubCategory { get; set; } = null!;

    public bool NeedsApproval { get; set; }

    public int SecurityLevel { get; set; }

    public bool FullText { get; set; }

    public bool ForumCustomer { get; set; }

    public bool ForumReseller { get; set; }

    public bool ForumEmployee { get; set; }

    public string? ForumDescription { get; set; }

    public short? Division { get; set; }

    public int? DocumentTypeId { get; set; }

    public int? CheckField { get; set; }
}
