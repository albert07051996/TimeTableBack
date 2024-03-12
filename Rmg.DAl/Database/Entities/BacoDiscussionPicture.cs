using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class BacoDiscussionPicture
{
    public Guid Id { get; set; }

    public string? Filename { get; set; }

    public short? Division { get; set; }

    public DateTime CreatedDate { get; set; }

    public byte[]? Picture { get; set; }
}
