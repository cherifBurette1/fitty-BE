namespace Application.Features.Cart.Queries.GetCartItems
{
    public class GetCartItemsQueryResponse
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public string ImageURL { get; set; }
        public int Quantity { get; set; }
    }
}   