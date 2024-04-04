﻿using ConsoleCalculator;
using static System.Console;

// Note: Additional input validation omitted for brevity

WriteLine("Enter first number");
int number1 = int.Parse(ReadLine()!);

WriteLine("Enter second number");
int number2 = int.Parse(ReadLine()!);

WriteLine("Enter operation");
string operation = ReadLine()!.ToUpperInvariant();


var calculator = new Calculator();
int result = calculator.Calculate(number1, number2, operation);
DisplayResult(result);


WriteLine("\nPress enter to exit.");
ReadLine();
    

static void DisplayResult(int result) => WriteLine($"Result is: {result}");