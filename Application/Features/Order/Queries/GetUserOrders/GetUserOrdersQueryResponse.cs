namespace Application.Features.Order.Queries.GetUserOrders
{
    public class GetUserOrdersQueryResponse
    {
        public Guid Id { get; set; }
        public string ShippingName { get; set; }
        public string CookingInstructions { get; set; }
        public string DeliveryInstructions { get; set; }
        public string PaymentName { get; set; }
        public string LocationName { get; set; }
        public double TotalPrice { get; set; }
        public string Status {  get; set; }
        public string Date {  get; set; }
    }
}   