using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cookery.Domain.Entities
{
    public class RelationshipUserRecipe
    {
        public Int32 Id { get; set; }
        public String Relationshop { get; set; }
        public virtual ICollection<UserRecipe> UserRecipe { get; set; }
    }
}
