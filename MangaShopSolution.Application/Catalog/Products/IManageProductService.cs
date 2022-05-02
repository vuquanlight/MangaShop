
using MangaShopSolution.Viewmodel.Catalog.Products;
using MangaShopSolution.Viewmodel.Common;
using MangaShopSolution.Viewmodels.Catalog.Products;
using MangaShopSolution.ViewModels.Catalog.ProductImages;
using MangaShopSolution.ViewModels.Catalog.Products;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MangaShopSolution.Application.Catalog.Products
{
    public interface IManageProductService
    {
        Task<int> Create(ProductCreateRequest request);

        Task<int> Update(ProductUpdateRequest request);

        Task<int> Delete(int productId);

        Task<ProductViewModel> GetById(int productId, string languageId);

        Task<bool> UpdatePrice(int poductId, decimal newPrice);
        Task AddViewcount(int productId);



        Task<PagedResult<ProductViewModel>> GetAllByCategoryId(string languageId, GetPublicProductPagingRequest request);

        Task<int> AddImage(int productId, ProductImageCreateRequest request);

        Task<int> RemoveImage(int imageId);

        Task<int> UpdateImage(int imageId, ProductImageUpdateRequest request);
        Task<List<ProductImageViewModel>> GetListImages(int productId);

        Task<ProductImageViewModel> GetImageById(int imageId);

        

    }


}
