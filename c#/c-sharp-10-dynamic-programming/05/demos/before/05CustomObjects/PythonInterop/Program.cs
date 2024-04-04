using IronPython.Hosting;
using Microsoft.Scripting;
using Microsoft.Scripting.Hosting;
using static System.Console;

ScriptEngine engine = Python.CreateEngine();

string tupleStatement = "customer = ('Sarah', 42 , 200)";

ScriptScope scope = engine.CreateScope();

ScriptSource source =
    engine.CreateScriptSourceFromString(tupleStatement,
                                        SourceCodeKind.SingleStatement);

source.Execute(scope);

dynamic pythonTuple = scope.GetVariable("customer");

WriteLine(
    $"Name = {pythonTuple[0]} Age = {pythonTuple[1]} Height = {pythonTuple[2]}");


WriteLine("Press enter to exit");
ReadLine();