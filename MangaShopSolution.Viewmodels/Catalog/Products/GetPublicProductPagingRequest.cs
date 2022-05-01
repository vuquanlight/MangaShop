using MangaShopSolution.Viewmodel.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace MangaShopSolution.Viewmodels.Catalog.Products
{
    public class GetPublicProductPagingRequest : PagingRequestBase
    {
        public int? CategoryId { get; set; }
    }
}
