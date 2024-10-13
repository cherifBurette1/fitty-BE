using Application.Contracts.Helpers;
using MediatR;
using Newtonsoft.Json;

namespace Application.Behaviours
{
    public class LoggingBehavior<TRequest, TResponse> : IPipelineBehavior<TRequest, TResponse>
    {
        private readonly IDbLogger _logger;

        public LoggingBehavior(IDbLogger logger)
        {
            _logger = logger;
        }

        public async Task<TResponse> Handle(TRequest request, RequestHandlerDelegate<TResponse> next, CancellationToken cancellationToken)
        {
            await _logger.Log(0, typeof(TRequest).Name, JsonConvert.SerializeObject(request), "", "");

            var response = await next();

            return response;
        }
    }
}
