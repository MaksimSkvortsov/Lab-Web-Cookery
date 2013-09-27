using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

using Cookery.Domain.Entities;

namespace Cookery.Domain.Concrete
{
    class EFContext : DbContext
    {
        public DbSet<CategoryRecipe> CategoriesRecipe { get; set; }

        public DbSet<Image> Images { get; set; }

        public DbSet<ImageFinisedRecipe> ImageFinisedRecipes { get; set; }

        public DbSet<Product> Products { get; set; }

        public DbSet<Recipe> Recipes { get; set; }

        public DbSet<RecipeProduct> RecipeProducts { get; set; }

        public DbSet<RelationshipUserRecipe> RelationshipsUserRecipe { get; set; }

        public DbSet<User> Users { get; set; }

        public DbSet<UseRecipe> UseRecipes { get; set; }

        public DbSet<UserRecipe> UserRecipes { get; set; }
        
    }
}
