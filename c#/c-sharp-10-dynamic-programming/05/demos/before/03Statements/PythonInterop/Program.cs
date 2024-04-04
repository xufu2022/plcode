using IronPython.Hosting;
using Microsoft.Scripting;
using Microsoft.Scripting.Hosting;
using static System.Console;

ScriptEngine engine = Python.CreateEngine();

int customerAge = 42;

WriteLine("Please enter an expression (use token 'a' for customer age) and press enter");
string simpleExpression = ReadLine()!;

ScriptScope scope = engine.CreateScope();
scope.SetVariable("a", customerAge);

ScriptSource scriptSource =
    engine.CreateScriptSourceFromString(simpleExpression,
                                        SourceCodeKind.Expression);

dynamic dynamicResult = scriptSource.Execute(scope);

WriteLine($"Expression result (dyn): {dynamicResult}");


WriteLine("Press enter to exit");
ReadLine();