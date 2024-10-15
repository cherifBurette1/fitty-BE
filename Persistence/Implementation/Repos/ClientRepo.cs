using Application.Contracts.Repos;
using Domain.Entities;

namespace Persistence.Implementation.Repos
{
    internal class ClientRepo : BaseRepo<Client>, IClientRepo
    {
        public ClientRepo(AppDbContext context) : base(context)
        {
        }
    }
}