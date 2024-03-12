using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class Workspace
{
    public int Id { get; set; }

    public int OwnerId { get; set; }

    public string Name { get; set; } = null!;

    public int WorkspaceType { get; set; }

    public string? InitialContent { get; set; }

    public string? CurrentContent { get; set; }

    public DateTime Syscreated { get; set; }

    public int Syscreator { get; set; }

    public DateTime Sysmodified { get; set; }

    public int Sysmodifier { get; set; }

    public string? Description { get; set; }

    public DateTime? CheckedOut { get; set; }

    public int? CheckedOutBy { get; set; }

    public string? CheckedOutContent { get; set; }

    public DateTime? ThumbnailModifiedDate { get; set; }

    public byte? ThumbnailNumRetries { get; set; }
}
