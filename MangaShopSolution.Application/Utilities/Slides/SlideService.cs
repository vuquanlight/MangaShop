using MangaShopSolution.Application.System.Roles;
using MangaShopSolution.Data.EF;
using MangaShopSolution.Data.Entities;
using MangaShopSolution.ViewModels.System.Roles;
using MangaShopSolution.ViewModels.Utilities.Slides;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MangaShopSolution.Application.Utilities.Slides
{
    public class SlideService : ISlideService
    {
        private readonly MangaShopDbContext _context;

        public SlideService(MangaShopDbContext context)
        {
            _context = context;
        }

        public async Task<List<SlideVm>> GetAll()
        {
            var slides = await _context.Slides.OrderBy(x => x.SortOrder)
                .Select(x => new SlideVm()
                {
                    Id = x.Id,
                    Name = x.Name,
                    Description = x.Description,
                    Url = x.Url,
                    Image = x.Image
                }).ToListAsync();

            return slides;
        }
    }
}