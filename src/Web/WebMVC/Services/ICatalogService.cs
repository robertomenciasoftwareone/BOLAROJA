﻿using Microsoft.AspNetCore.Mvc.Rendering;
using BolaRoja.WebMVC.ViewModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BolaRoja.WebMVC.Services
{
    public interface ICatalogService
    {
        Task<Catalog> GetCatalogItems(int page, int take, int? brand, int? type);
        Task<IEnumerable<SelectListItem>> GetBrands();
        Task<IEnumerable<SelectListItem>> GetTypes();
    }
}
