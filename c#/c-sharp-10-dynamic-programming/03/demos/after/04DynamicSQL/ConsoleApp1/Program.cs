using Dapper;
using System.Data.SqlClient;

const string connectionString = @"Data Source=(localdb)\ProjectModels;Initial Catalog=PSDynamicCS;Integrated Security=True;";

using var cn = new SqlConnection(connectionString);

IEnumerable<dynamic> allCustomers = cn.Query("SELECT * FROM CUSTOMER");

foreach (dynamic customer in allCustomers)
{
    Console.WriteLine($"{customer.FirstName}  {customer.SecondName} {customer.Height} {customer.Age}");
}


Console.WriteLine("\n\nPress enter to exit...");
Console.ReadLine();
