using Domain.Common;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{
    public class Dish : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImageURL { get; set; }
        public decimal Price { get; set; }
        public decimal Rating { get; set; }
        public ICollection<DishComponent> DishComponents { get; set; }
        public virtual DishNutrient DishNutrient { get; set; }
        public ICollection<Category> Categories { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
    }
}
