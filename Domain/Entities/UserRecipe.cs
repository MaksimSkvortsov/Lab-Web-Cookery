using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cookery.Domain.Entities
{
    public class UserRecipe
    {
        public Int32 Id { get; set; }
        public virtual User User { get; set; }
        public virtual Recipe Recipe { get; set; }
        public virtual RelationshipUserRecipe Relationship { get; set; }
    }
}
