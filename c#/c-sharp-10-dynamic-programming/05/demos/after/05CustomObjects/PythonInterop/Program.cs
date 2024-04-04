using CustomDynamic;
using IronPython.Hosting;
using Microsoft.Scripting.Hosting;
using static System.Console;


ScriptEngine engine = Python.CreateEngine();

HtmlElement image = new HtmlElement("img");

ScriptScope scope = engine.CreateScope();
scope.SetVariable("image", image);

ScriptSource source = engine.CreateScriptSourceFromFile("SetImageAttributes.py");

WriteLine($"image before Python execution: {image}");

source.Execute(scope);

WriteLine($"image after Python execution: {image}");

WriteLine("Press enter to exit");
ReadLine();