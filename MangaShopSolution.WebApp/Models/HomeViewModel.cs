using MangaShopSolution.ViewModels.Catalog.Products;
using MangaShopSolution.ViewModels.Common;
using MangaShopSolution.ViewModels.Utilities.Slides;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MangaShopSolution.WebApp.Models
{
    public class HomeViewModel
    {
        public List<SlideVm> Slides { get; set; }

        public List<ProductVm> FeaturedProducts { get; set; }

        public List<ProductVm> LatestProducts { get; set; }

        public PagedResult<ProductVm> Products { get; set; }
    }
}