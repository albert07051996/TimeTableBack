using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class BdpictureRef
{
    public Guid DocId { get; set; }

    public Guid PictureId { get; set; }

    public Guid? AttachmentId { get; set; }

    public string? Version { get; set; }

    public short? Division { get; set; }
}
