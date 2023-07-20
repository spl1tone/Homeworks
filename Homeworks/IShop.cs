namespace Homeworks;

internal interface IShop
{
    void RegisterProduct (string name, float price, int quantity, string description);
    void AddQuantity (string productName, int quantity);
    void SellProduct (int id, string productName, string buyerName, string buyerAddress, string buyerEmail);
    void RegisterBuyer (int id, string name, string address, string email);
}
