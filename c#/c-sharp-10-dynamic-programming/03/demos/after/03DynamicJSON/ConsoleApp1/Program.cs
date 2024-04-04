using Newtonsoft.Json;

const string customerJson = "{'FirstName': 'Sarah','SecondName': 'Smith'}";

dynamic? customer = JsonConvert.DeserializeObject(customerJson);
Console.WriteLine($"Customer name is: {customer?.FirstName} {customer?.SecondName}");

Console.WriteLine("\n\nPress enter to exit...");
Console.ReadLine();