namespace shop.Data.Enums;

public enum OrderStatus
{
    Pending,
    AwaitingShipment,
    AWaitingPickup,
    Completed,
    Canceled,
    Refunded,
    Disputed,
    ManualVerificationRequired
}
