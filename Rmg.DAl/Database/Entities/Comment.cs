using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class Comment
{
    public Guid Id { get; set; }

    public Guid OwnerId { get; set; }

    public Guid CreatorId { get; set; }

    public Guid? ParentCommentId { get; set; }

    public DateTime CreatedDate { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public string CommentText { get; set; } = null!;

    public string? Metadata { get; set; }

    public short OwnerType { get; set; }

    public string? AttachedObject { get; set; }
}
