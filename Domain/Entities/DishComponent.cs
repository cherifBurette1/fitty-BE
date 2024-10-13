using Domain.Common;
using Domain.Enums;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{
    public class DishComponent : BaseEntity
    {
        public string Name { get; set; }

        [ForeignKey(nameof(Dish))]
        public Guid DishId { get; set; }
        public virtual Dish Dish { get; set; }
    }
}
