namespace Pluralsight.CShPlaybook.ControlFlow;


public static class Sequences
{
	public static void DisplaySequence_ForEach(IEnumerable<string> strings)
	{
		foreach (string s in strings)
			Console.WriteLine(s);
	}
}
