using MangaShopSolution.Viewmodel.Catalog.Products;
using MangaShopSolution.Viewmodel.Common;
using MangaShopSolution.Viewmodels.Catalog.Products;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MangaShopSolution.Application.Catalog.Products
{
    public interface IPublicProductService
    {
        Task<PagedResult<ProductViewModel>> GetAllByCategoryId(GetPublicProductPagingRequest request);

        Task<List<ProductViewModel>> GetAll();
    }
}
