using ConsoleApp1;
using System.Reflection;
using static System.Console;

object customer = new Customer
{
    FirstName = "Gentry",
    LastName = "Jones"
};

InvokeMethodUsingReflection(customer);
InvokeMethodUsingDynamic(customer);

GetPropertyValueUsingReflection(customer);
GetPropertyValueUsingDynamic(customer);


WriteLine("\n\nPress enter to exit...");
ReadLine();

void InvokeMethodUsingReflection(object o)
{
    Type t = o.GetType();

    t.InvokeMember("WriteCustomer",
                   BindingFlags.InvokeMethod,
                   null,
                   o,
                   new object[] { "Customer data (reflection): " });
}


void InvokeMethodUsingDynamic(object o)
{
    dynamic c = o;
    c.WriteCustomer("Customer data (dynamic): ");
}

void GetPropertyValueUsingReflection(object o)
{
    Type t = o.GetType();

    object? result = t.InvokeMember("FirstName",
                                    BindingFlags.GetProperty,
                                    null,
                                    o,
                                    null);

    WriteLine($"Property value (reflection): {result}");
}

void GetPropertyValueUsingDynamic(object o)
{
    dynamic c = o;
    WriteLine($"Property value (dynamic): {c.FirstName}");
}
