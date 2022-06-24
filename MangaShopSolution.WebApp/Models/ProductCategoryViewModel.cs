using MangaShopSolution.ViewModels.Catalog.Categories;
using MangaShopSolution.ViewModels.Catalog.Products;
using MangaShopSolution.ViewModels.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MangaShopSolution.WebApp.Models
{
    public class ProductCategoryViewModel
    {
        public CategoryVm Category { get; set; }

        public PagedResult<ProductVm> Products { get; set; }
        
    }
}