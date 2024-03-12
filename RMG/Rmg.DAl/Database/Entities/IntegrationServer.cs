using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class IntegrationServer
{
    public int Id { get; set; }

    public string InstanceName { get; set; } = null!;

    public string EndPoint { get; set; } = null!;

    public Guid ClientId { get; set; }

    public string? ListenerEndPoint { get; set; }

    public string? Provider { get; set; }
}
