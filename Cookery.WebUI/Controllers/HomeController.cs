using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using Cookery.Domain.Abstract;
using Cookery.Domain.Entities;
using Cookery.WebUI.Models;

namespace Cookery.WebUI.Controllers
{
    public class HomeController : Controller
    {
        private IRepository repository;
        private const int countRecipesInPage = 8;

        public HomeController(IRepository repository)
        {
            this.repository = repository;
        }

        public ActionResult Index()
        {
            ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public PartialViewResult GetPresentationPopularRecipes()
        {
            IQueryable<PresentationRecipe> recipes = repository.Recipes
                .OrderByDescending(r => r.CreationDate)
                .Take(countRecipesInPage)
                .Select(r => new PresentationRecipe() { Name = r.Name, Id = r.Id });

            return PartialView("PresentationRecipes", recipes);
        }

        public PartialViewResult GetPresentationNewRecipes()
        {
            IQueryable<PresentationRecipe> recipes = repository.Recipes
                .OrderByDescending(r => r.CreationDate)
                .Take(countRecipesInPage)
                .Select(r => new PresentationRecipe() { Name = r.Name, Id = r.Id });

            return PartialView("PresentationRecipes", recipes);
        }
    }
}
