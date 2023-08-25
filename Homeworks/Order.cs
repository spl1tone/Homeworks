namespace Homeworks;

public class Order
{
    public int orderId { get; set; }
    public DateTime OrderDate { get; set; }
    public virtual List<Product> Products { get; set; }
    public virtual Customer Customer { get; set; }
}
