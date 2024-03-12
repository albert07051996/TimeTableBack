using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class BacoDiscussionGrole
{
    public Guid Id { get; set; }

    public int RoleId { get; set; }

    public Guid? SubCategoryId { get; set; }

    public short? Division { get; set; }

    public int DocumentTypeId { get; set; }

    public int? ApprovalRoleLevel { get; set; }

    public string? ApprovalRefPoint { get; set; }
}
