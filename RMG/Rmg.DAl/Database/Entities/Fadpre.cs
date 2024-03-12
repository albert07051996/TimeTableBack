using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class Fadpre
{
    public int Id { get; set; }

    public string? Assetcode { get; set; }

    public string? Assetpartnum { get; set; }

    public string? Valuation { get; set; }

    public string? Seqnum { get; set; }

    public string? Yearstart { get; set; }

    public string? Periodstart { get; set; }

    public string? Yearend { get; set; }

    public string? Periodend { get; set; }

    public string? Deprmeth { get; set; }

    public DateTime? Datestart { get; set; }

    public DateTime? Dateend { get; set; }

    public string? Valcode { get; set; }

    public double Exchrate { get; set; }

    public string? Yearlastdepr { get; set; }

    public string? Periodlastdepr { get; set; }

    public double Salvagevalue { get; set; }

    public double Salvagevaluefc { get; set; }

    public double Deprfactor { get; set; }

    public double Switchacclevel { get; set; }

    public double Cumdepr { get; set; }

    public double Cumdeprfc { get; set; }

    public double Firstdepramt { get; set; }

    public double Firstdepramtfc { get; set; }

    public double Origcumdepr { get; set; }

    public double Origcumdeprfc { get; set; }

    public string? Numdeprpers { get; set; }

    public double Purchamtstart { get; set; }

    public double Purchamtstartfc { get; set; }

    public double Purchamtend { get; set; }

    public double Purchamtendfc { get; set; }

    public double Bkvaluestart { get; set; }

    public double Bkvaluestartfc { get; set; }

    public double Bkvalueend { get; set; }

    public double Bkvalueendfc { get; set; }

    public string? Hghrchgmethadj { get; set; }

    public string? Lwrchgmethadj { get; set; }

    public double Currbkvalue { get; set; }

    public double Currbkvaluefc { get; set; }

    public string? Artcode { get; set; }

    public short? Division { get; set; }

    public DateTime Syscreated { get; set; }

    public int Syscreator { get; set; }

    public DateTime Sysmodified { get; set; }

    public int Sysmodifier { get; set; }

    public Guid Sysguid { get; set; }

    public byte[] Timestamp { get; set; } = null!;
}
