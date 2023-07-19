namespace Homeworks;

internal class Receipt : Shop
{
    public Product Product { get; set; }
    public Buyer Buyer { get; set; }
    public DateTime date { get; set; }

    public void PrintReceipt ()
    {
        Console.WriteLine($"Product: {Product.Name}, Price: {Product.Price}, Buyer_Name: {Buyer.Name}, Buyer_Id: {Buyer.Id}" +
            $"\nDate: {date}, Shop Name: {ShopName}, Shop Location: {ShopLocation}");
    }

}
