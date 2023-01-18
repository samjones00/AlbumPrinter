namespace AlbumPrinter.Domain.Commands;
public class CreateOrderCommand
{
    public string? OrderId { get; init; }
    public string? ProductType { get; init; }
    public int Quantity { get; init; }

    public static CreateOrderCommand Create(string orderId, string productType, int quantity)
    {
        if (string.IsNullOrWhiteSpace(orderId)) throw new ArgumentNullException(nameof(orderId));

        if (productType == null) throw new ArgumentNullException(nameof(productType));

        if (quantity <= 0) throw new ArgumentOutOfRangeException(nameof(quantity));

        return new CreateOrderCommand
        {
            OrderId = orderId,
            ProductType = productType,
            Quantity = quantity
        };
    }
}
