using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ComplexModelBinderBug.Models;

namespace ComplexModelBinderBug.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            MenuModel model = new MenuModel();

            model.Id = 1;
            model.Name = "Camillo";
            model.CssClass = "";
            model.Enabled = false;
            model.WidgetZone = "content_before";
            model.ShowDropdownsOnClick = false;

            model.Items = new List<MenuItemModel>
            {
                new MenuItemModel
                {
                    Id = 100,
                    MenuId = 62,
                    Type = MenuItemType.HomePage,
                    Title = "Home Page",
                    Url = string.Empty,
                    OpenInNewWindow = false,
                    CssClass = "",
                    DisplayOrder = 1,
                    EntityId = -1,
                    CatalogTemplate = CatalogTemplate.Simple,
                    ParentMenuItemId = 0
                },
                new MenuItemModel
                {
                    Id = 200,
                    MenuId = 63,
                    Type = MenuItemType.Login,
                    Title = "Login",
                    Url = string.Empty,
                    OpenInNewWindow = false,
                    CssClass = "",
                    DisplayOrder = 2,
                    EntityId = -1,
                    CatalogTemplate = CatalogTemplate.Simple,
                    ParentMenuItemId = 0
                }
            };
            
            return View(model);
        }

        [HttpPost]
        public IActionResult Index(MenuModel model)
        {
            return View(model);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
