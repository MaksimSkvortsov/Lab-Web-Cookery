using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using Cookery.Domain.Entities;

namespace Cookery.WebUI.Extensions
{
    public enum TypeOfSort { Alphabet, TimeCooking, Newness, Popularity };

    public static class LinqSortRecipesExtension
    {        
            static IDictionary<TypeOfSort, Func<Recipe, object>> functions;

            static LinqSortRecipesExtension()
            {
                functions = new Dictionary<TypeOfSort, Func<Recipe, object>>();
                functions.Add(TypeOfSort.Alphabet, p => p.Name);
                functions.Add(TypeOfSort.TimeCooking, p => p.MinTimeForCooking);
                functions.Add(TypeOfSort.Newness, p => p.CreationDate);
                functions.Add(TypeOfSort.Popularity, p => p.Rating); //испраить на кол-во просмотров или добавлений
            }

            public static IEnumerable<Recipe> Sort(this IEnumerable<Recipe> recipes, TypeOfSort sort)
            {
                return recipes.OrderBy(functions[sort]);
            }
        }
    }