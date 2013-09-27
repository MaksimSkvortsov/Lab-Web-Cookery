﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cookery.Domain.Entities
{
    public class User
    {
        public Int32 Id { get; set; }
        public string EMail { get; set; }
        public virtual ICollection<UserRecipe> AllUserRecipes { get; set; }
    }
}
