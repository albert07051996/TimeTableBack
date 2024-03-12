using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class SocialMediaReference
{
    public Guid Id { get; set; }

    public int Division { get; set; }

    public Guid Person { get; set; }

    public string Link { get; set; } = null!;

    public Guid? Type { get; set; }

    public byte EntityType { get; set; }

    public DateTime Syscreated { get; set; }

    public int Syscreator { get; set; }

    public DateTime Sysmodified { get; set; }

    public int Sysmodifier { get; set; }
}
