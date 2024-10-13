using Domain.Common;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{
    public class DishNutrient : BaseEntity
    {
        [ForeignKey(nameof(Dish))]
        public Guid DishId {  get; set; }
        public virtual Dish Dish { get; set; }
        public int Calories { get; set; }
        public double Weight { get; set; }
        public string Nature { get; set; }
        public int PreparationTime { get; set; }
    }
}