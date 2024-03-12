using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class SocialMediaType
{
    public Guid Id { get; set; }

    public string Code { get; set; } = null!;

    public string Description { get; set; } = null!;

    public int? DescriptionTermId { get; set; }

    public string FileName { get; set; } = null!;

    public string Format { get; set; } = null!;

    public DateTime Syscreated { get; set; }

    public int Syscreator { get; set; }

    public DateTime Sysmodified { get; set; }

    public int Sysmodifier { get; set; }
}
