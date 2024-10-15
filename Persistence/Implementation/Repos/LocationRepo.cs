using Application.Contracts.Repos;
using Application.Features.Favorite.Queries.GetUserFavorite;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Persistence.Implementation.Repos
{
    internal class LocationRepo : BaseRepo<Location>, ILocationRepo
    {
        public LocationRepo(AppDbContext context) : base(context)
        {
        }

    }
}
