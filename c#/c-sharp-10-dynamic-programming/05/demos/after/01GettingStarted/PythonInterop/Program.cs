using IronPython.Hosting;
using Microsoft.Scripting;
using Microsoft.Scripting.Hosting;
using static System.Console;

ScriptEngine engine = Python.CreateEngine();

string simpleExpression = "2 + 2";

dynamic dynamicResult = engine.Execute(simpleExpression);
int typedResult = engine.Execute<int>(simpleExpression);

WriteLine($"Expression result (dyn): {dynamicResult}");
WriteLine($"Expression result (int): {typedResult}");

WriteLine("Press enter to exit");
ReadLine();