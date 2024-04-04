namespace ConsoleApp1;

internal class Customer
{
    public string FirstName { get; set; } = "";
    public string LastName { get; set; } = "";

    public void WriteCustomer(string message)
    {
        Console.WriteLine($"{message} {FirstName}, {LastName}");
    }
}
