﻿using System.ComponentModel;
using Entities.CoreServicesModels.MainDataModels;

namespace Dashboard.Areas.MainDataEntity.Models;

public class SizeFilter : DtParameters
{
    public int Id { get; set; }
}

public class SizeDto : SizeModel
{
    [DisplayName(nameof(CreatedAt))]
    public new string CreatedAt { get; set; }

    [DisplayName(nameof(LastModifiedAt))]
    public string LastModifiedAt { get; set; }
}