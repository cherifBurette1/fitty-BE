namespace Application.Features.Reservations.Queries.GetAllDishes
{
    // Response model for each dish
    public class GetAllDishesQueryResponse
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public decimal Rating { get; set; }
        public string ImageURL { get; set; }
    }

    // Response for paginated dishes including pagination details
    public class PaginatedDishesResponse
    {
        public List<GetAllDishesQueryResponse> Dishes { get; set; } = new List<GetAllDishesQueryResponse>(); // List of dishes
        public int TotalPages { get; set; }    // Total number of pages
        public int CurrentPage { get; set; }   // Current page number
    }
}
