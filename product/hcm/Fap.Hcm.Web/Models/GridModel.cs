﻿using Fap.Core.Infrastructure.Metadata;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Fap.Hcm.Web.Models
{
    [ModelBinder(BinderType = typeof(GridModelBinder))]
    public class GridModel
    {
        [Required]
        public string TableName { get; set; }
        public IEnumerable<FapDynamicObject> Rows { get; set; }
    }
}
