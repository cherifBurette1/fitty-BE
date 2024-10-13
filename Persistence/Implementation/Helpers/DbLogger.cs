using Application.Contracts.Helpers;
using Domain.LogEntities;

namespace Persistence.Implementation.Helpers
{
    internal class DbLogger : IDbLogger
    {
        private readonly AppDbContext _context;

        public DbLogger(AppDbContext context)
        {
            _context = context;
        }

        public async Task Log(int statusCode, string requestMethod, string requestBody, string requestQuery, string responseBody)
        {
            await _context.AddAsync(new ApiResponseLog
            {
                StatusCode = statusCode,
                RequestName = requestMethod,
                RequestBody = requestBody,
                ResponseBody = responseBody,
                RequestQuery = requestQuery
            });

            await _context.SaveChangesAsync();
        }
    }
}
