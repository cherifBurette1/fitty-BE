using Domain.Common;

namespace Domain.Entities
{
    public class Client : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public DateTime Birthday { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public bool RememberMe { get; set; }
        public string MobileNumber { get; set; }
        public ICollection<Location> Locations { get; set; }
        public ICollection<Order> Orders { get; set; }
        public ICollection<Favorite> Favorites { get; set; }
        public ICollection<CartItem> CartItems { get; set; }
    }
}
