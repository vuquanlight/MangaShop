using MangaShopSolution.ViewModels.Common;
using MangaShopSolution.ViewModels.System.Languages;
using MangaShopSolution.ViewModels.System.Users;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MangaShopSolution.Application.System.Languages
{
    public interface ILanguageService
    {
        Task<ApiResult<List<LanguageVm>>> GetAll();
    }
}