using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class WorkspaceNotification
{
    public int Id { get; set; }

    public int? WorkspaceSharingId { get; set; }

    public byte? WorkspaceSharingType { get; set; }

    public byte? NotificationType { get; set; }

    public string? NotificationRemarks { get; set; }
}
