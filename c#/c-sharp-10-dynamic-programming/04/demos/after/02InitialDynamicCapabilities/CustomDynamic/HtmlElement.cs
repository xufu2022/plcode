using System.Dynamic;

namespace CustomDynamic;

public class HtmlElement : DynamicObject
{
    private readonly Dictionary<string, object?> _attributes = new();
    public string TagName { get; }

    public HtmlElement(string tagName) => TagName = tagName;

    public override bool TrySetMember(SetMemberBinder binder, object? value)
    {
        string attributeName = binder.Name;

        _attributes.Add(attributeName, value);

        return true;
    }

    public override bool TryGetMember(GetMemberBinder binder, out object? result)
    {
        string attributeName = binder.Name;

        result = _attributes[attributeName];

        return true;
    }
}
