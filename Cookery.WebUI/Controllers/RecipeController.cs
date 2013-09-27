using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using Cookery.Domain.Entities;
using Cookery.WebUI.Models;
using Cookery.WebUI.Extensions;

using Cookery.Domain.Abstract;

namespace Cookery.WebUI.Controllers
{
    public class RecipeController : Controller
    {
        private IRepository repository;

        public RecipeController(IRepository repository)
        {
            this.repository = repository;
        }

        [HttpGet]//просмотр
        public ActionResult Recipe(Int32? id)
        {
            if (id != null)
            {
                var recipe = repository.Recipes.FirstOrDefault(r => r.Id == id);

                if (recipe != null)
                {
                    return View(recipe);
                }
            }

            return RedirectToAction("Index");
        }

        [HttpGet]//просмотр для редактирования или создания
        public ActionResult Edit(Int32? id)
        {
            if (id == null || id < 0)
            {
                return View(new RecipeEditing());
            }
            else
            {
                var recipe = repository.Recipes.FirstOrDefault(r => r.Id == id).ToRecipeEditing();
                if (recipe == null)
                {
                    return RedirectToAction("New");
                }
                else
                {
                    return View(recipe);
                }
            }
        }

        [HttpPost]//создание
        public ActionResult Recipe(RecipeEditing recipe)
        {
            recipe.Id = 0;
            return Save(recipe);
        }

        [HttpPut]//редактирование
        [ActionName("Recipe")]
        public ActionResult EditRecipe(RecipeEditing recipe)
        {
            return Save(recipe);
        }

        [HttpDelete]//удаление
        [ActionName("Recipe")]
        public ActionResult DeleteRecipe(Int32? id)
        {
            return View();
        }        


        private ActionResult Save(RecipeEditing recipeEdited)
        {
            if (ModelState.IsValid)
            {
                Recipe recipe = recipeEdited.ToRecipe();

                repository.SaveRecipe(recipe);

                //сохраняем и направляем в профиль
                return RedirectToAction("", "");
            }
            else
            {
                return View(recipeEdited);
            }

        }

        private void DropDownListForCategories()
        {
            SetDropDownList<CategoryRecipe>("Categories", "Name", repository.CategoriesRecipe.Where(c => c.ParentCategory == null));
        }

        private void DropDownListForSubCategories(CategoryRecipe category)
        {
            SetDropDownList<CategoryRecipe>("SubCategories", "Name", repository.CategoriesRecipe.Where(c => c.ParentCategory == category));
        }

        private void DropDownListForUses()
        {
            SetDropDownList<UseRecipe>("Uses", "Use", repository.UseRecipes);
        }

        private void SetDropDownList<T>(string viewBagPropertyName, string dataTextField, IEnumerable<T> list) where T : class
        {
            if (viewBagPropertyName == null)
                throw new ArgumentNullException("viewBagPropertyName");
            if(dataTextField == null)
                throw new ArgumentNullException("dataTextField");

            IList<T> collection = new List<T>();
            collection.Add(null);
            IEnumerable<SelectListItem> selectList = new SelectList((IEnumerable<T>)collection.Concat(list), "Id", dataTextField, 0);
            ViewBag[viewBagPropertyName] = selectList;
        }
    }
}
