using System.Dynamic;
using System.Text;
using static System.Console;

namespace ConsoleApp;

class Program
{
    static void Main(string[] args)
    {
        dynamic customer = new ExpandoObject();

        customer.ID = 42;
        customer.sb = new StringBuilder("a string builder");

        WriteLine("(enter 'done' to complete adding properties)");

        string propertyName = GetPropertyName();
        while (propertyName != "done")
        {
            string propertyValue = GetPropertyValue();

            var c = (IDictionary<string, object?>)customer;

            c.Add(propertyName, propertyValue);

            propertyName = GetPropertyName();
        }

        WriteLine("\nCUSTOMER PROPERTIES");
        foreach (KeyValuePair<string, object?> item in customer)
        {
            WriteLine($"{item.Key} : {item.Value}");
        }

        WriteLine(customer.FirstName);

        WriteLine("\n\nPress enter to exit...");
        ReadLine();
    }


    private static string GetPropertyName()
    {
        Write("Please enter property Name: ");
        return ReadLine()!;
    }

    private static string GetPropertyValue()
    {
        Write("Please enter property value: ");
        return ReadLine()!;
    }
}

