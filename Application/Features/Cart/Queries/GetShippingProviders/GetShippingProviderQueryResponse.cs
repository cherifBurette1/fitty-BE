namespace Application.Features.Cart.Queries.GetShippingProviders
{
    public class GetShippingProviderQueryResponse
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
    }
}   