using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class Cicntp
{
    public int Id { get; set; }

    public Guid CntId { get; set; }

    public Guid? CmpWwn { get; set; }

    public string? CntFName { get; set; }

    public string? CntLName { get; set; }

    public string? CntMName { get; set; }

    public string? FullName { get; set; }

    public string? Initials { get; set; }

    public string? Gender { get; set; }

    public string? Predcode { get; set; }

    public string? CntJobDesc { get; set; }

    public string? CntDept { get; set; }

    public string? Taalcode { get; set; }

    public string? CntFExt { get; set; }

    public string? CntFFax { get; set; }

    public string? CntFTel { get; set; }

    public string? CntFMobile { get; set; }

    public string? CntEmail { get; set; }

    public int CntAccMan { get; set; }

    public string? CntNote { get; set; }

    public byte ActiveY { get; set; }

    public string Administration { get; set; } = null!;

    public int ResId { get; set; }

    public byte WebAccess { get; set; }

    public byte[]? Picture { get; set; }

    public string? PictureFileName { get; set; }

    public DateTime Syscreated { get; set; }

    public int Syscreator { get; set; }

    public DateTime Sysmodified { get; set; }

    public int Sysmodifier { get; set; }

    public Guid Sysguid { get; set; }

    public byte[] Timestamp { get; set; } = null!;

    public DateTime? Datefield1 { get; set; }

    public DateTime? Datefield2 { get; set; }

    public DateTime? Datefield3 { get; set; }

    public DateTime? Datefield4 { get; set; }

    public DateTime? Datefield5 { get; set; }

    public double? Numberfield1 { get; set; }

    public double? Numberfield2 { get; set; }

    public double? Numberfield3 { get; set; }

    public double? Numberfield4 { get; set; }

    public double? Numberfield5 { get; set; }

    public byte YesNoField1 { get; set; }

    public byte YesNoField2 { get; set; }

    public byte YesNoField3 { get; set; }

    public byte YesNoField4 { get; set; }

    public byte YesNoField5 { get; set; }

    public string? Textfield1 { get; set; }

    public string? Textfield2 { get; set; }

    public string? Textfield3 { get; set; }

    public string? Textfield4 { get; set; }

    public string? Textfield5 { get; set; }

    public string? CntpDirectory { get; set; }

    public short? Division { get; set; }

    public bool? ContactChange { get; set; }

    public string? OldFileName { get; set; }

    public bool EmailPermission { get; set; }

    public bool EmailValid { get; set; }

    public DateTime? Datefield6 { get; set; }

    public DateTime? Datefield7 { get; set; }

    public DateTime? Datefield8 { get; set; }

    public DateTime? Datefield9 { get; set; }

    public DateTime? Datefield10 { get; set; }

    public string? Textfield6 { get; set; }

    public string? Textfield7 { get; set; }

    public string? Textfield8 { get; set; }

    public string? Textfield9 { get; set; }

    public string? Textfield10 { get; set; }

    public string? Textfield11 { get; set; }

    public string? Textfield12 { get; set; }

    public string? Textfield13 { get; set; }

    public string? Textfield14 { get; set; }

    public string? Textfield15 { get; set; }

    public string? Textfield16 { get; set; }

    public string? Textfield17 { get; set; }

    public string? Textfield18 { get; set; }

    public string? Textfield19 { get; set; }

    public string? Textfield20 { get; set; }

    public string? Textfield21 { get; set; }

    public string? Textfield22 { get; set; }

    public string? Textfield23 { get; set; }

    public string? Textfield24 { get; set; }

    public string? Textfield25 { get; set; }

    public string? Textfield26 { get; set; }

    public string? Textfield27 { get; set; }

    public string? Textfield28 { get; set; }

    public string? Textfield29 { get; set; }

    public string? Textfield30 { get; set; }

    public double? Numberfield6 { get; set; }

    public double? Numberfield7 { get; set; }

    public double? Numberfield8 { get; set; }

    public double? Numberfield9 { get; set; }

    public double? Numberfield10 { get; set; }

    public byte? YesNoField6 { get; set; }

    public byte? YesNoField7 { get; set; }

    public byte? YesNoField8 { get; set; }

    public byte? YesNoField9 { get; set; }

    public byte? YesNoField10 { get; set; }

    public Guid? Guidfield1 { get; set; }

    public Guid? Guidfield2 { get; set; }

    public Guid? Guidfield3 { get; set; }

    public Guid? Guidfield4 { get; set; }

    public Guid? Guidfield5 { get; set; }

    public Guid? Guidfield6 { get; set; }

    public Guid? Guidfield7 { get; set; }

    public Guid? Guidfield8 { get; set; }

    public Guid? Guidfield9 { get; set; }

    public Guid? Guidfield10 { get; set; }

    public int? NumIntField1 { get; set; }

    public int? NumIntField2 { get; set; }

    public int? NumIntField3 { get; set; }

    public int? NumIntField4 { get; set; }

    public int? NumIntField5 { get; set; }

    public int? NumIntField6 { get; set; }

    public int? NumIntField7 { get; set; }

    public int? NumIntField8 { get; set; }

    public int? NumIntField9 { get; set; }

    public int? NumIntField10 { get; set; }

    public string? Suffix { get; set; }

    public Guid? PersonId { get; set; }

    public DateTime? StartDate { get; set; }

    public DateTime? EndDate { get; set; }

    public byte FinancialContactPerson { get; set; }

    public DateTime? StatusSince { get; set; }

    public bool AllowCustomerSpecificDoc { get; set; }

    public byte DownloadOption { get; set; }

    public virtual ICollection<ScpfavoriteItem> ScpfavoriteItems { get; set; } = new List<ScpfavoriteItem>();

    public virtual ICollection<ScpportalsEditRight> ScpportalsEditRights { get; set; } = new List<ScpportalsEditRight>();

    public virtual ICollection<ScpshoppingCart> ScpshoppingCarts { get; set; } = new List<ScpshoppingCart>();
}
