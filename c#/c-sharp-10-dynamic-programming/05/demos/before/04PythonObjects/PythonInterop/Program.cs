using IronPython.Hosting;
using Microsoft.Scripting;
using Microsoft.Scripting.Hosting;
using static System.Console;

ScriptEngine engine = Python.CreateEngine();

int customerAge = 42;

WriteLine("Please enter a statement");
string singleStatement = ReadLine()!;

ScriptScope scope = engine.CreateScope();
scope.SetVariable("a", customerAge);

ScriptSource scriptSource =
    engine.CreateScriptSourceFromString(singleStatement,
                                        SourceCodeKind.SingleStatement);

scriptSource.Execute(scope);

dynamic dynamicResult = scope.GetVariable("result");

WriteLine($"Statement result: {dynamicResult}");


WriteLine("Press enter to exit");
ReadLine();