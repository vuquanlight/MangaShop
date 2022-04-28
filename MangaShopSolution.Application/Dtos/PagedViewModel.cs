using System;
using System.Collections.Generic;
using System.Text;

namespace MangaShopSolution.Application.Dtos
{
    class PagedViewModel<T>
    {
        List<T> Items { set; get; }
        public int Totalecord { set; get; }

    }
}
