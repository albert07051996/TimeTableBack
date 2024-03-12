using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class EbcPropType
{
    public Guid PropTypeId { get; set; }

    public int GroupId { get; set; }

    public int BasicTypeId { get; set; }

    public string TypeName { get; set; } = null!;

    public int PropPrecision { get; set; }

    public string? PrecisionQuery { get; set; }

    public int PropScale { get; set; }

    public bool PropUppercase { get; set; }

    public bool PropUnsigned { get; set; }

    public bool ExactMatch { get; set; }

    public bool LanguageDependent { get; set; }

    public bool NumericString { get; set; }

    public bool RightAligned { get; set; }

    public bool ZeroFill { get; set; }

    public bool AutoIncrement { get; set; }

    public bool ZeroIsNull { get; set; }

    public string? DefaultValue { get; set; }

    public string? LowerRange { get; set; }

    public string? UpperRange { get; set; }

    public string? SelectionValues { get; set; }

    public string? AllowedChars { get; set; }

    public string? AllowedCharsQuery { get; set; }

    public virtual EbcBasicType BasicType { get; set; } = null!;

    public virtual ICollection<EbcProp> EbcProps { get; set; } = new List<EbcProp>();

    public virtual EbcGroup Group { get; set; } = null!;
}
