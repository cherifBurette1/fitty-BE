using Application.Features.Brands.Commands.CreateDish;
using Application.Features.Category.Queries.GetAllCategories;
using Application.Features.Reservations.Queries.GetDish;
using Domain.Entities;

namespace Application.Contracts.Repos
{
    public interface IDishRepo : IBaseRepo<Dish>
    {
        Task<Guid> AddDish(CreateDishCommand createDishCommand);
        Task<List<GetAllCategoriesQueryResponse>> GetAllCategories();
        Task<(List<Dish> Dishes, int TotalCount)> GetAllDishesPaginated(int page, int pageSize);
        Task<GetDishQueryResponse> GetDish(Guid dishId);
    }
}
