using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Cookery.Domain.Entities;

namespace Cookery.Domain.Abstract
{
    public interface IRepository
    {
        IQueryable<CategoryRecipe> CategoriesRecipe { get; }

        IQueryable<Image> Images { get; }

        IQueryable<ImageFinisedRecipe> ImageFinisedRecipes { get; }

        IQueryable<Product> Products { get; }

        IQueryable<Recipe> Recipes { get; }

        IQueryable<RecipeProduct> RecipeProducts { get; }

        IQueryable<RelationshipUserRecipe> RelationshipsUserRecipe { get; }

        IQueryable<User> Users { get; }

        IQueryable<UseRecipe> UseRecipes { get; }

        IQueryable<UserRecipe> UserRecipes { get; }

        void SaveCategoriesRecipe(CategoryRecipe categoriesRecipe);

        void DeleteCategoriesRecipe(CategoryRecipe categoriesRecipe);

        void SaveImage(Image image);

        void DeleteImage(Image image);

        void SaveImageFinishedRecipe(ImageFinisedRecipe image);

        void DeleteImageFinishedRecipe(ImageFinisedRecipe image);

        void SaveProduct(Product product);

        void DeleteProduct(Product product);

        void SaveRecipe(Recipe product);

        void DeleteRecipe(Recipe product);

        void SaveRecipeProduct(RecipeProduct recipeProduct);

        void DeleteRecipeProduct(RecipeProduct recipeProduct);

        void SaveRelationshipUserRecipe(RelationshipUserRecipe relationshipUserRecipe);

        void DeleteRelationshipUserRecipe(RelationshipUserRecipe relationshipUserRecipe);

        void SaveUser(User user);

        void DeleteUser(User user);

        void SaveUseRecipe(UseRecipe useRecipe);

        void DeleteUseRecipe(UseRecipe useRecipe);

        void SaveUserRecipe(UserRecipe userRecipe);

        void DeleteUserRecipe(UserRecipe userRecipe);
    }
}
