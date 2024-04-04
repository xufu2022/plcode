namespace Pluralsight.CShPlaybook.MethodsProps;

public class CookieCustomer
{
	public int Id { get; } // must be > 0

	public string Name { get; } // must contain something
	
	public string? Notes { get; set; }

	public char NameFirstChar => Name[0];

	public CookieCustomer(int id, string name, string? notes=null)
	{
        Id = id;
		Name = name;
		Notes = notes;
	}

	public override string ToString() => $"Customer Id={Id}, Name={Name}";


}
