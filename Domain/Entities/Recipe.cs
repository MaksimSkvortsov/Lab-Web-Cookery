using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cookery.Domain.Entities
{
    public class Recipe
    {
        public Int32 Id { get; set; }
        [Display(Name="Название")]
        public string Name { get; set; }
        [Column(TypeName="Xml")]
        public virtual string StagesOfCooking { get; set; }

        [NotMapped]
        public XElement XmlValue
        {
            get { return XElement.Parse(StagesOfCooking); }
            set { StagesOfCooking = value.ToString(); }
        }

        public Int32 CategoryId { get; set; }
        [Display(Name = "Категория")]
        public virtual CategoryRecipe Category { get; set; }
        public Int32 UseId { get; set; }
        [Display(Name = "Назначение")]
        public virtual UseRecipe Use { get; set; }
        public virtual ICollection<RecipeProduct> Consist { get; set; }
        public virtual ICollection<UserRecipe> Users { get; set; }
        [Display(Name = "Изображение")]
        public virtual ImageFinisedRecipe ImageByAuhor { get; set; }
        public virtual ICollection<ImageFinisedRecipe> ImagesAnotherUsers { get; set; }
        
        //Временные метки
        public DateTime CreationDate { get; set; }
        public DateTime LastModifyDate { get; set; }

        //Рейтинг
        public int Rating { get; set; }
        public int NumberOfVotes { get; set; }

        //Время приготовления
        [Display(Name = "Минимальное время приготовления")]
        public int MinTimeForCooking { get; set; }
        [Display(Name = "Максимальное время приготовления")]
        public int MaxTimeForCooking { get; set; }
    }
}
