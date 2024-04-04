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

}


void InvokeMethodUsingDynamic(object o)
{

}

void GetPropertyValueUsingReflection(object o)
{

}

void GetPropertyValueUsingDynamic(object o)
{

}
