using Domain.Common;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{
    public class Order : BaseEntity
    {
        public DateTime OrderDate { get; set; }
        public string OrderStatus { get; set; }
        public string CookingInstructions { get; set; }
        public string DeliveryInstructions { get; set; }
        public string PromoCode { get; set; }
        [ForeignKey(nameof(Location))]
        public Guid LocationId { get; set; }
        public virtual Location Location { get; set; }
        [ForeignKey(nameof(ShippingProvider))]
        public Guid ShippingProviderId { get; set; }
        public virtual ShippingProvider ShippingProvider { get; set; }

        [ForeignKey(nameof(PaymentOption))]
        public Guid PaymentOptionId { get; set; }
        public virtual PaymentOption PaymentOption { get; set; }
        public virtual ICollection<Dish> Dishes { get; set; }
        public double TotalPrice { get; set; }
    }
}
