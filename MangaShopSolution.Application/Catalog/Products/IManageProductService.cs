using MangaShopSolution.Application.Catalog.Products.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace MangaShopSolution.Application.Catalog.Products
{
        public class IManageProductService
        {
             int Ceate(ProductsCreateRequest request);

             int Update(ProductsEditRequest request);

             int Delete(int productId);

             List<ProductViewModel> GetAll();

             PagedViewModel<ProductViewModer> GetAllPageing(string keyword, int pageIndex, int pageSize);
        
        }

    
}
