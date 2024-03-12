using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class Hrfree
{
    public int Id { get; set; }

    public string? Filetype { get; set; }

    public string? Reckey { get; set; }

    public string? Descr60 { get; set; }

    public string? Hrgroup { get; set; }

    public int? Notes { get; set; }

    public Guid? DocId { get; set; }

    public string? JobGroup { get; set; }

    public bool Competency1 { get; set; }

    public bool Competency2 { get; set; }

    public bool Competency3 { get; set; }

    public bool Competency4 { get; set; }

    public bool Competency5 { get; set; }

    public bool Competency6 { get; set; }

    public bool Competency7 { get; set; }

    public bool Competency8 { get; set; }

    public bool Competency9 { get; set; }

    public bool Competency10 { get; set; }

    public bool Competency11 { get; set; }

    public bool Competency12 { get; set; }

    public bool Competency13 { get; set; }

    public short? Division { get; set; }

    public DateTime Syscreated { get; set; }

    public int Syscreator { get; set; }

    public DateTime Sysmodified { get; set; }

    public int Sysmodifier { get; set; }

    public Guid Sysguid { get; set; }

    public byte[] Timestamp { get; set; } = null!;
}
