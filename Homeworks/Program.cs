namespace Homeworks
{
    internal class Program
    {
        // Homework Text


        static void Main (string[] args)
        {
            string path = @"PhoneBook.txt";

            if (File.Exists(path)) {

                Console.WriteLine("PhoneBook: \n{0}",File.ReadAllText(path));

                Console.WriteLine(new String('-',25));

                try {
                    string[] lines = File.ReadAllLines(path);

                    Console.WriteLine("Choose Criteria:");
                    string searchCriteria = Console.ReadLine();

                    bool IsFound = false;

                    foreach (string line in lines) {
                        string[] parts = line.Split(' ');

                        if (parts.Length == 3) {
                            string Name = parts[0];
                            string LastName = parts[1];
                            string PhoneNumber = parts[2];

                            if (Name.Contains(searchCriteria, StringComparison.OrdinalIgnoreCase) ||
                                LastName.Contains(searchCriteria, StringComparison.OrdinalIgnoreCase) ||
                                PhoneNumber.Contains(searchCriteria, StringComparison.OrdinalIgnoreCase)) {
                                Console.WriteLine("FirstName: " + Name);
                                Console.WriteLine("LastName: " + LastName);
                                Console.WriteLine("Phone: " + PhoneNumber);
                                Console.WriteLine();

                                IsFound = true;
                            }
                        }
                    }

                    if (!IsFound) {
                        Console.WriteLine("Wrong Criteria");
                    }
                }
                catch (IOException e) {
                    Console.WriteLine(e.Message);
                }

            } 

        }  

        }
        
}