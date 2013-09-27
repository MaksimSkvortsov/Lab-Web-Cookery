using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cookery.Domain.Entities
{
    public class UseRecipe
    {
        public Int32 Id { get; set; }
        public string Use { get; set; }
        public virtual ICollection<Recipe> Recipe { get; set; }
    }
}
