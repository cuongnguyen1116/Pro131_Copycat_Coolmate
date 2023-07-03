namespace shop.Data.Enums;

public enum OrderStatus
{
    Pending,
    Confirmed,
    AwaitingShipment,
    AWaitingPickup,
    Completed,
    Canceled,
    Refunded,
    PartiallyRefunded,
    Disputed,
    ManualVerificationRequired
}
