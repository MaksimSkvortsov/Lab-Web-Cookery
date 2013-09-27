using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml;

using Cookery.Domain.Entities;

namespace Cookery.WebUI.Models
{
    public class RecipeEditing : Recipe
    {
        public IList<CookingItem> CookingItems { get; set; }
        public override string StagesOfCooking 
        {
            get { return base.StagesOfCooking; }
        }
    }

    public class CookingItem
    {
        public Int32? ImageId { get; set; }
        public string Text { get; set; }
    }
}