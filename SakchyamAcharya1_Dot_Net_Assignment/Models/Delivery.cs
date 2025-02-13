namespace SakchyamAcharya1_Dot_Net_Assignment.Models
{
    public class Delivery
    {


    public required int Id { get; set; }

    // Properties
    public required string CuisineType { get; set; } // Foreign key to associate with an Order
    public required string DeliveryAddress { get; set; }
    public required string DeliveryStatus { get; set; } // e.g., Pending, In Transit, Delivered
    public required DateTime DeliveryDate { get; set; }
    public required string DeliveryPersonName { get; set; } // Name of the delivery person
    public required string ContactNumber { get; set; }
}
}
