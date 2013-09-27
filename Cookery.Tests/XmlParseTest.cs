using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Cookery.Domain.Entities;
using Cookery.WebUI.Models;
using Cookery.WebUI.Extensions;

namespace Cookery.Tests
{
    [TestClass]
    public class XmlParseTest
    {
        [TestMethod]
        public void Reading()
        {
            RecipeEditing recipeEdit = new RecipeEditing();
            List<CookingItem> stages = new List<CookingItem>();
            stages.Add(new CookingItem(){ ImageId = 1, Text = "Text1"});
            stages.Add(new CookingItem(){ ImageId = null, Text = "Text2"});
            recipeEdit.CookingItems = stages;

            Recipe recipe = recipeEdit.ToRecipe();
            RecipeEditing newRecipeEdit = recipe.ToRecipeEditing();

            bool result = true;

            for (int i = 0; i < recipeEdit.CookingItems.Count; i++)
            {
                if ((newRecipeEdit.CookingItems[i].Text != recipeEdit.CookingItems[i].Text || newRecipeEdit.CookingItems[i].ImageId != recipeEdit.CookingItems[i].ImageId))
                {
                    result = false;
                }
            }

            Assert.IsTrue(result);
        }
    }
}
