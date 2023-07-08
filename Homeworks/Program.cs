namespace Homeworks;

internal class Program
{
    // Homework Text


    static void Main (string[] args)
    {
        string path = @"PhoneBook.txt";

              if (File.Exists(path)) {

                  Console.WriteLine("PhoneBook: \n{0}",File.ReadAllText(path));

                  Console.WriteLine(new String('-',30));

                  try {
                      string[] lines = File.ReadAllLines(path);

                      Console.Write("Search Contact:");
                      string SearchContact = Console.ReadLine();

                      bool IsFound = false;

                      foreach (string line in lines) {
                          string[] parts = line.Split(' ');

                          if (parts.Length == 3) {
                              string Name = parts[0];
                              string LastName = parts[1];
                              string PhoneNumber = parts[2];

                        if (Name.Contains(SearchContact, StringComparison.OrdinalIgnoreCase) ||
                            LastName.Contains(SearchContact, StringComparison.OrdinalIgnoreCase) ||
                            PhoneNumber.Contains(SearchContact, StringComparison.OrdinalIgnoreCase))  
                            {
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
            Sort(path);
        }
        
    }  

    static void Sort(string path)
    {
        string[] inputArray = File.ReadAllLines(path);
        string[] Names = new string[0];
        string[] LastNames = new string[0];
        string[] Phones = new string[0];
        for (int i = 0; i < inputArray.Length; i++) {
            string[] split = inputArray[i].Split(' ');
            Array.Resize(ref Names, i + 1);
            Array.Resize(ref LastNames, i + 1);
            Array.Resize(ref Phones, i + 1);

            if (split.Length >= 1) {
                Names[i] = split[0];           
            }

            if (split.Length >= 2) {
                LastNames[i] = split[1];                  
            }

            if (split.Length >= 3) {
                Phones[i] = split[2];     
            }
        }

        Console.Write("Choose Sort Criteria (1-Name,2-LastName,3-Phone): ");
        SortCriteria(path, Names, LastNames,Phones,Convert.ToInt32(Console.ReadLine()));
    }

    static void SortCriteria (string path, string[] Names, string[] LastNames, string[] Phones, int criteriaNum)
    {
        Console.WriteLine(new String('-', 30));

        string[] inputArray = File.ReadAllLines(path);
        string line = string.Empty;

        string[] SortPhoneBook = new string[0];
        switch (criteriaNum) {
            case 1:

            Array.Sort(Names);
            for(int i = 0; i < Names.Length; i++) {
                Array.Resize(ref SortPhoneBook, i + 1);
                foreach (string str in inputArray) {
                    if (str.Contains(Names[i])) {
                        line = str.Replace(Names[i], "");
                        SortPhoneBook[i] = $"{Names[i]}{line}";
                    }
                }
            }
                foreach(var c in SortPhoneBook) Console.WriteLine(c);
                break;

            case 2:
            Array.Sort(LastNames);
            for (int i = 0; i < LastNames.Length; i++) {
                Array.Resize(ref SortPhoneBook, i + 1);
                foreach (string str in inputArray) {
                    if (str.Contains(LastNames[i])) {
                        line = str.Replace(LastNames[i], LastNames[i]);
                        SortPhoneBook[i] = $"{line}";
                    }
                }
            }
            foreach (var c in SortPhoneBook) Console.WriteLine(c);
                break;

            case 3:
                   Array.Sort(Phones);
                   for (int i = 0; i < Phones.Length; i++) {
                       Array.Resize(ref SortPhoneBook, i + 1);
                       foreach (string str in inputArray) {
                           if (str.Contains(Phones[i])) {
                               line = str.Replace(Phones[i], "");
                               SortPhoneBook[i] = $"{line}{Phones[i]}";
                           }
                       }
                   }
                   foreach (var c in SortPhoneBook) Console.WriteLine(c);
                       break;

                   default:
                       Console.WriteLine("Wrong Input"); 
                break;
        }
    }    
}
   
    
