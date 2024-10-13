namespace Application.Contracts.Helpers
{
    public interface IDbLogger
    {
        Task Log(int statusCode, string requestMethod, string requestBody, string requestQuery, string responseBody);
    }
}
