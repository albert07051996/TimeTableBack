using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class BacoAccessServer
{
    public int Id { get; set; }

    public string? Ipaddress { get; set; }

    public bool CheckIpaddress { get; set; }

    public string? MachineName { get; set; }

    public bool CheckMachineName { get; set; }

    public string? MacAddress { get; set; }

    public bool CheckMacAddress { get; set; }

    public short? Division { get; set; }
}
