using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cookery.Domain.Entities
{
    public class CategoryRecipe
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual CategoryRecipe ParentCategory { get; set; }
        public virtual ICollection<CategoryRecipe> ChildCategory { get; set; }
        public virtual ICollection<Recipe> Recipes { get; set; }
    }
}
