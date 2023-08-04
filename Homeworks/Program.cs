using System.Reflection;
namespace Homeworks;

internal class Program
{
    static void Main ()
    {
        Console.WriteLine("Enter the path to the assembly file:");
        string path = Console.ReadLine(); // .dll

        try {
            Assembly targetAssembly = Assembly.LoadFrom(path);

            var types = targetAssembly.GetTypes();

            foreach (var type in types) {
                Console.WriteLine($"NameSpace: {type.Namespace}");
                Console.WriteLine($"Class Name: {type.Name}");

                var methods = type.GetMethods();

                foreach (var method in methods) {
                    Console.WriteLine($"  Method Name: {method.Name}");

                    var parameters = method.GetParameters();
                    foreach (var parameter in parameters) {
                        Console.WriteLine($"Param Name: {parameter.Name} - Type: {parameter.ParameterType}");
                    }

                    Console.WriteLine($"Return Type: {method.ReturnType}");
                }
                Console.WriteLine();
            }
        }
        catch (Exception e) {
            Console.WriteLine($"Error loading: {e.Message}");
        }

        Console.ReadLine();
    }
}