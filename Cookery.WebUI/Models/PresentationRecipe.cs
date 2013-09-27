using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using Cookery.Domain.Entities;

namespace Cookery.WebUI.Models
{
    public class PresentationRecipe
    {
        public Int32 Id { get; set; }
        public string Name { get; set; }
        public IEnumerable<RecipeProduct> Consist { get; set; }
    }
}