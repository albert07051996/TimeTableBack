using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class Sysmnuusr
{
    public int MnuId { get; set; }

    public byte Checked { get; set; }

    public DateTime? Lastrun { get; set; }

    public string? Note { get; set; }

    public string? Syscommand { get; set; }

    public string? Arguments { get; set; }

    public string? Iconpath { get; set; }

    public short Iconindex { get; set; }

    public string? Icon { get; set; }

    public string? Emailto { get; set; }

    public string? Emailcc { get; set; }

    public string? Emailsubject { get; set; }

    public string? Emailmessage { get; set; }

    public byte Emailnotify { get; set; }

    public short? Division { get; set; }
}
