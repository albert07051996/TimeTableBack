using System;
using System.Collections.Generic;

namespace Rmg.DAL.DataBase.Entities;

public partial class ItemRelease
{
    public Guid Id { get; set; }

    public string ProductLine { get; set; } = null!;

    public string ProductRelease { get; set; } = null!;

    public int Assortment { get; set; }

    public string Release { get; set; } = null!;

    public int Status { get; set; }

    public int DownloadSecurityLevel { get; set; }

    public bool DownloadSecurityLevelCombine { get; set; }

    public bool UploadItemOwner { get; set; }

    public bool UploadItemOwnerManager { get; set; }

    public int UploadRole { get; set; }

    public int UploadRoleLevel { get; set; }

    public bool AllowUpload { get; set; }

    public bool AllowCheckout { get; set; }

    public bool AllowTouch { get; set; }

    public bool AllowArchive { get; set; }

    public bool AllowArchiveChildren { get; set; }

    public int? DownloadRole { get; set; }

    public int? DownloadRoleLevel { get; set; }

    public short? Division { get; set; }

    public byte[] Timestamp { get; set; } = null!;
}
