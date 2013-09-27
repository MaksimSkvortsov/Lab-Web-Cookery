using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cookery.Domain.Entities
{
    public class RecipeProduct
    {
        public Int32 Id { get; set; }
        public virtual Recipe Recipe { get; set; }
        public virtual Product Product { get; set; }
        public string Volume { get; set; }
    }
}
