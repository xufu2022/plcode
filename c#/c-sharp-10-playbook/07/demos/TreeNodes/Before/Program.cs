using Pluralsight.CShPlaybook.Generics;

TreeNode<string> ceo = new("Simon");
var financeHead = ceo.AddChild("Ramdevi");
var cto = ceo.AddChild("Deborah");
financeHead.AddChild("Mohammed");
financeHead.AddChild("PingPing");
var teamLeader = cto.AddChild("Jenifer");
teamLeader.AddChild("Volodymyr");
teamLeader.AddChild("Aruna");
cto.AddChild("Femi");

foreach (var employee in ceo.EnumerateSelfAndDescendants())
	Console.WriteLine(employee);

