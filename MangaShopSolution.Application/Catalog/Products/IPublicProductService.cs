using MangaShopSolution.Application.Catalog.Products.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace MangaShopSolution.Application.Catalog.Products
{
    public class IPublicProductService
    {
        PagedViewMode<ProductViewModel> GetAllByCategoryId(int categoryId, int pageIndex, int pageSize);
    }
}
