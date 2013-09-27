using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

using Cookery.Domain.Entities;
using Cookery.Domain.Abstract;

namespace Cookery.Domain.Concrete
{
    public class EFRepository : IRepository
    {
        private EFContext context = new EFContext();

        public IQueryable<CategoryRecipe> CategoriesRecipe
        {
            get { return context.CategoriesRecipe; }
        }

        public IQueryable<Image> Images
        {
            get { return context.Images; }
        }

        public IQueryable<ImageFinisedRecipe> ImageFinisedRecipes
        {
            get { return context.ImageFinisedRecipes; }
        }

        public IQueryable<Product> Products
        {
            get { return context.Products; }
        }

        public IQueryable<Recipe> Recipes
        {
            get { return context.Recipes; }
        }

        public IQueryable<RecipeProduct> RecipeProducts
        {
            get { return context.RecipeProducts; }
        }

        public IQueryable<RelationshipUserRecipe> RelationshipsUserRecipe
        {
            get { return context.RelationshipsUserRecipe; }
        }

        public IQueryable<User> Users
        {
            get { return context.Users; }
        }

        public IQueryable<UseRecipe> UseRecipes
        {
            get { return context.UseRecipes; }
        }

        IQueryable<UserRecipe> IRepository.UserRecipes
        {
            get { return context.UserRecipes; }
        }

        public void SaveCategoriesRecipe(CategoryRecipe categoriesRecipe)
        {
            throw new NotImplementedException();
        }

        public void DeleteCategoriesRecipe(CategoryRecipe categoriesRecipe)
        {
            throw new NotImplementedException();
        }

        public void SaveImage(Image image)
        {
            throw new NotImplementedException();
        }

        public void DeleteImage(Image image)
        {
            throw new NotImplementedException();
        }

        public void SaveImageFinishedRecipe(ImageFinisedRecipe image)
        {
            throw new NotImplementedException();
        }

        public void DeleteImageFinishedRecipe(ImageFinisedRecipe image)
        {
            throw new NotImplementedException();
        }

        public void SaveProduct(Product product)
        {
            throw new NotImplementedException();
        }

        public void DeleteProduct(Product product)
        {
            throw new NotImplementedException();
        }

        public void SaveRecipe(Recipe product)
        {
            throw new NotImplementedException();
        }

        public void DeleteRecipe(Recipe product)
        {
            throw new NotImplementedException();
        }

        public void SaveRecipeProduct(RecipeProduct recipeProduct)
        {
            throw new NotImplementedException();
        }

        public void DeleteRecipeProduct(RecipeProduct recipeProduct)
        {
            throw new NotImplementedException();
        }

        public void SaveRelationshipUserRecipe(RelationshipUserRecipe relationshipUserRecipe)
        {
            throw new NotImplementedException();
        }

        public void DeleteRelationshipUserRecipe(RelationshipUserRecipe relationshipUserRecipe)
        {
            throw new NotImplementedException();
        }

        public void SaveUser(User user)
        {
            throw new NotImplementedException();
        }

        public void DeleteUser(User user)
        {
            throw new NotImplementedException();
        }

        public void SaveUseRecipe(UseRecipe useRecipe)
        {
            throw new NotImplementedException();
        }

        public void DeleteUseRecipe(UseRecipe useRecipe)
        {
            throw new NotImplementedException();
        }

        public void SaveUserRecipe(UserRecipe userRecipe)
        {
            throw new NotImplementedException();
        }

        public void DeleteUserRecipe(UserRecipe userRecipe)
        {
            throw new NotImplementedException();
        }
    }
}
