using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class ClientFile
{
    public int Id { get; set; }

    public Guid AddonId { get; set; }

    public string Filename { get; set; } = null!;

    public byte[] Binary { get; set; } = null!;

    public Guid ActivationId { get; set; }

    public int ServerId { get; set; }
}
