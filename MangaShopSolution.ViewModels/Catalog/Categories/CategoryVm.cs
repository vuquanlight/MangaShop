﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MangaShopSolution.ViewModels.Catalog.Categories
{
    public class CategoryVm
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int? ParentId { get; set; }
    }
}