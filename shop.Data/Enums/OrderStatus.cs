namespace shop.Data.Enums;

public enum OrderStatus
{
    None,
    Pending,
    AwaitingShipment,
    AWaitingPickup,
    Completed,
    Cancelled,
    Refunded
}
