using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using Cookery.Domain.Entities;

namespace Cookery.WebUI.Models
{
    public enum Sort
    {
        Popularity,
        Rating
    }

    public class ParametresShowRecipesModel
    {
        public IEnumerable<CategoryRecipe> Categories { get; set; }
        public IEnumerable<UseRecipe> Uses { get; set; }
        public Sort TypeOfSort { get; set; }
    }
}