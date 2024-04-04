using System.Runtime.Versioning;

namespace ConsoleApp1;

internal class Program
{
    [SupportedOSPlatform("windows")]
    static void Main(string[] args)
    {
        Console.WriteLine("Please enter a customer name");
        var name = Console.ReadLine()!;

        Type excelType = Type.GetTypeFromProgID("Excel.Application")!;

        dynamic excel = Activator.CreateInstance(excelType)!;

        excel.Visible = true;
        excel.Workbooks.Add();

        dynamic defaultWorksheet = excel.ActiveSheet;

        defaultWorksheet.Cells[1, "A"] = "Customer name";
        defaultWorksheet.Columns[1].AutoFit();

        defaultWorksheet.Cells[1, "B"] = name;
        defaultWorksheet.Columns[2].AutoFit();

        Console.WriteLine("\n\nPress enter to exit...");
        Console.ReadLine();
    }
}
