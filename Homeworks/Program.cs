namespace Homeworks;

public class Program
{
    static void Main ()
    {
        using (var db = new ShopDbContext()) {
            var customer1 = new Customer {
                FirstName = "Name1",
                LastName = "Last Name",
                Email = "email@gmail.com"
            };
            db.Customers.Add(customer1);
            var customer2 = new Customer {
                FirstName = "Name2",
                LastName = "Last Name",
                Email = "email@gmail.com"
            };
            db.Customers.Add(customer2);
            var customer3 = new Customer {
                FirstName = "Name3",
                LastName = "Last Name",
                Email = "email@gmail.com"
            };
            db.Customers.Add(customer3);
            var customer4 = new Customer {
                FirstName = "Name4",
                LastName = "Last Name",
                Email = "email@gmail.com"
            };
            db.Customers.Add(customer4);

            db.SaveChanges();

            var criteria = db.Customers
                .OrderBy(firstName => firstName.FirstName)
                .Select(firstName => firstName)
                .ToList();

            Console.WriteLine("All First Names in the database:");
            foreach (var c in criteria) {
                Console.WriteLine(c.FirstName);
            }
            Console.ReadLine();
        }
    }


}