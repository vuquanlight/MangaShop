using MangaShopSolution.ViewModels.System.Roles;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MangaShopSolution.Application.System.Roles
{
    public interface IRoleService
    {
        Task<List<RoleVm>> GetAll();
    }
}