namespace Homeworks;

public class Program
{
    public static void Main (string[] args)
    {
        Shop shop = new Shop();

        while (true) {
            Console.WriteLine("1. Register Product");
            Console.WriteLine("2. Add Quantity");
            Console.WriteLine("3. Sell Product");
            Console.WriteLine("4. Register Buyer");
            Console.WriteLine("5. Exit");

            Console.Write("Enter your choice: ");
            string choice = Console.ReadLine();

            switch (choice) {
                case "1":
                Console.Write("Product name: ");
                string productName = Console.ReadLine();

                Console.Write("Product description: ");
                string productDescription = Console.ReadLine();

                Console.Write("Product price: ");
                float productPrice = float.Parse(Console.ReadLine());

                Console.Write("Product quantity: ");
                int productQuantity = int.Parse(Console.ReadLine());

                shop.RegisterProduct(productName, productPrice, productQuantity, productDescription);

                break;

                case "2":
                Console.Write("Product name: ");
                string existProductName = Console.ReadLine();

                Console.Write("Quantity to add: ");
                int quantityAdd = int.Parse(Console.ReadLine());

                shop.AddQuantity(existProductName, quantityAdd);

                break;

                case "3":
                Console.Write("Product name: ");
                string productToSell = Console.ReadLine();

                Console.Write("Buyer id: ");
                int buyerId = int.Parse(Console.ReadLine());

                Console.Write("Buyer name: ");
                string buyerName = Console.ReadLine();

                Console.Write("Buyer address: ");
                string buyerAddress = Console.ReadLine();

                Console.Write("Buyer email: ");
                string buyerEmail = Console.ReadLine();

                shop.SellProduct(buyerId, productToSell, buyerName, buyerAddress, buyerEmail);

                break;

                case "4":
                Console.Write("Buyer id: ");
                int buyerIdRegister = int.Parse(Console.ReadLine());

                Console.Write("Buyer name: ");
                string buyerNameRegister = Console.ReadLine();

                Console.Write("Buyer address: ");
                string buyerAddressRegister = Console.ReadLine();

                Console.Write("Buyer email: ");
                string buyerEmailRegister = Console.ReadLine();

                shop.RegisterBuyer(buyerIdRegister, buyerNameRegister, buyerAddressRegister, buyerEmailRegister);
                break;

                case "5":
                Console.WriteLine("Goodbye");
                return;

                default:
                Console.WriteLine("Wrrong input");
                break;
            }

            Console.WriteLine();
        }
    }
}
