using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class TimelineCoverPhoto
{
    public int Id { get; set; }

    public int ResourceId { get; set; }

    public string? Picturefilename { get; set; }

    public byte[]? Picture { get; set; }
}
