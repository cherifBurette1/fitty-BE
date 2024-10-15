namespace Application.Features.Reservations.Queries.GetDish
{
    public class GetDishQueryResponse
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImageURL { get; set; }
        public decimal Price { get; set; }
        public decimal Rating { get; set; }
        public int Calories { get; set; }
        public int Weight { get; set; }
        public int PreparationTime { get; set; }
        public string Nature { get; set; }
        public List<string> DishComponents { get; set; }
        public List<string> Categories { get; set; }
    }
}
