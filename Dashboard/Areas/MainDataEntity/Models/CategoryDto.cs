﻿using Entities.CoreServicesModels.MainDataModels;
using System.ComponentModel;

namespace Dashboard.Areas.MainDataEntity.Models;

public class CategoryFilter : DtParameters
{
    public int Id { get; set; }
}

public class CategoryDto : CategoryModel
{
    [DisplayName(nameof(CreatedAt))]
    public new string CreatedAt { get; set; }

    [DisplayName(nameof(LastModifiedAt))]
    public string LastModifiedAt { get; set; }
}