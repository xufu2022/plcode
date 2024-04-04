using Models.Types.Common;
using Models.Types.Components;

namespace Models.Types.Products;

public class AssemblySpecification
{
    public AssemblySpecification(Guid id, string name, string description) =>
        (Id, Name, Description) = (id, name, description);
    
    public AssemblySpecification(AssemblySpecification other)
        : this(other.Id, other.Name, other.Description) { }

    public Guid Id { get; init; }
    public string Name { get; init; }
    public string Description { get; init; }

    public IEnumerable<(Part part, DiscreteMeasure quantity)> Components { get; init; }
        = Enumerable.Empty<(Part, DiscreteMeasure)>();
    public IEnumerable<(InventoryItem item, Measure quantity)> Consumables { get; init; }
        = Enumerable.Empty<(InventoryItem, Measure)>();
}