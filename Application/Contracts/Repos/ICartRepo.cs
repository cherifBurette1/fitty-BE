using Application.Features.Cart.Queries.GetCartItems;
using Application.Features.Cart.Queries.GetShippingProviders;
using Application.Features.Cart.Queries.GetUserLocations;
using Domain.Entities;

namespace Application.Contracts.Repos
{
    public interface ICartRepo : IBaseRepo<CartItem>
    {
        Task<List<GetCartItemsQueryResponse>> GetCartItemList(Guid userId);
        Task<List<GetPaymentOptionsQueryResponse>> GetPaymentOptions();
        Task<List<GetShippingProviderQueryResponse>> GetShippingProviders();
        Task<List<GetUserLocationsQueryResponse>> GetUserAddress(Guid userId);
        Task<CartItem> IsExistingCartItem(Guid userId, Guid dishId);
        Task RemoveCartItems(Guid userId);
    }
}
