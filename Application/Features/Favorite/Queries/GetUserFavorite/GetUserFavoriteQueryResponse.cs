namespace Application.Features.Favorite.Queries.GetUserFavorite
{
    public class GetUserFavoriteQueryResponse
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public decimal Rating { get; set; }
        public string ImageURL { get; set; }
    }
}   