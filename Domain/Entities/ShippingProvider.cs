using Domain.Common;

namespace Domain.Entities
{
    public class ShippingProvider : BaseEntity
    {
        public string Name { get; set; }
        public int Price { get; set; }
    }
}
