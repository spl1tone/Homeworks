namespace Homeworks;

internal class Shop : IShop
{
    public string ShopName { get; set; } = "Shop Name";
    public string ShopLocation { get; set; } = "Shop Location";

    public List<Product> products;
    public List<Buyer> buyers;
    public List<Receipt> receipts;

    public Shop ()
    {
        products = new List<Product>();
        buyers = new List<Buyer>();
        receipts = new List<Receipt>();
    }

    public void RegisterProduct (string name, float price, int quantity, string desctiption)
    {
        Product product = new Product {
            Name = name,
            Price = price,
            Quantity = quantity,
            Description = desctiption
        };

        products.Add(product);
        Console.WriteLine("Product registered");
    }

    public void AddQuantity (string productName, int quantity)
    {
        Product product = products.Find(x => x.Name == productName);

        if (product != null) {
            product.Quantity += quantity;
            Console.WriteLine("Quantity added");
        }
        else {
            Console.WriteLine("Product not found");
        }
    }

    public void SellProduct (int id, string productName, string buyerName, string buyerAddress, string buyerEmail)
    {
        Product product = products.Find(x => x.Name == productName);

        if (product != null && product.Quantity > 0) {
            Buyer buyer = buyers.Find(x => x.Name == buyerName);

            if (buyer == null) {
                buyer = new Buyer {
                    Id = id,
                    Name = buyerName,
                    Address = buyerAddress,
                    Email = buyerEmail
                };

                buyers.Add(buyer);
            }

            Receipt receipt = new Receipt {
                Product = product,
                Buyer = buyer,
                date = DateTime.Now
            };

            receipts.Add(receipt);
            receipt.PrintReceipt();
            product.Quantity--;

            Console.WriteLine("Product sold");
        }
        else {
            Console.WriteLine("Product not available");
        }
    }

    public void RegisterBuyer (int id, string name, string address, string email)
    {
        Buyer buyer = new Buyer {
            Id = id,
            Name = name,
            Address = address,
            Email = email
        };

        buyers.Add(buyer);
        Console.WriteLine("Buyer registered");
    }
}
