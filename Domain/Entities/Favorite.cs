using Domain.Common;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{
    public class Favorite : BaseEntity
    {
        [ForeignKey(nameof(Dish))]
        public Guid DishId {  get; set; }
        public virtual Dish Dish {  get; set; }
        [ForeignKey(nameof(Client))]
        public Guid ClientId { get; set; }
        public virtual Client Client { get; set; }
    }
}
