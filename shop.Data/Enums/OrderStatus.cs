namespace shop.Data.Enums;

public enum OrderStatus
{
    Pending,
    AwaitingShipment,
    AWaitingPickup,
    Completed,
    Cancelled,
    Refunded,
    Disputed,
    ManualVerificationRequired
}
