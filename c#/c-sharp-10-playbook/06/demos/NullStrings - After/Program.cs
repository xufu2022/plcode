﻿
Console.WriteLine("What do you want to buy?");
string? value = Console.ReadLine();

if (string.IsNullOrEmpty(value))
	Console.WriteLine("You don't want to buy anything");
else
	Console.WriteLine("You want to purchase " + value);

