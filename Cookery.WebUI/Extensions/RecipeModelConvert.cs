using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;
using System.Xml.Linq;

using Cookery.Domain.Entities;
using Cookery.WebUI.Models;

namespace Cookery.WebUI.Extensions
{
    public static class RecipeModelConvert
    {
        const string xmlRecipes = "StagesOfCooking";
        const string xmlRecipe = "Stage";
        const string xmlImageId = "ImageId";
        const string xmlText = "Text";

        public static RecipeEditing ToRecipeEditing(this Recipe recipe)
        {
            RecipeEditing newRecipe = (RecipeEditing)recipe;
            XDocument xml = new XDocument();

            XDocument doc = XDocument.Parse(recipe.StagesOfCooking);

            int tempImageId;

            foreach (XElement elem in doc.Root.Elements())
            {
                var item = new CookingItem();

                if (Int32.TryParse(elem.Element(xmlImageId).Value, out tempImageId))
                {
                    item.ImageId = tempImageId;
                }

                item.Text = elem.Element(xmlText).Value;

                newRecipe.CookingItems.Add(item);
            }

            return newRecipe;
        }

        public static Recipe ToRecipe(this RecipeEditing recipe)
        {
            Recipe newRecipe = (Recipe)recipe;
            StringBuilder textForRecipe = new StringBuilder();

            XDocument doc = new XDocument();
            XElement elem = new XElement(xmlRecipes);
            doc.Add(elem);

            foreach (var item in recipe.CookingItems)
            {
                XElement stage = new XElement(xmlRecipe);

                XElement imageId = new XElement("ImageId");
                imageId.Value = item.ImageId.ToString();
                stage.Add(imageId);

                XElement text = new XElement("Text");
                text.Value = item.Text;
                stage.Add(text);

                elem.Add(stage);
            }

            newRecipe.StagesOfCooking = doc.ToString();            

            return newRecipe;
        }
    }
}