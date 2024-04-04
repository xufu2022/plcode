using System.Dynamic;
using System.Text;

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

        return _attributes.TryGetValue(attributeName, out result);
    }

    public override IEnumerable<string> GetDynamicMemberNames()
    {
        return _attributes.Keys.ToList().AsReadOnly();
    }

    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append($"<{TagName} ");

        foreach (KeyValuePair<string, object?> attribute in _attributes)
        {
            sb.Append($"{attribute.Key}=\"{attribute.Value}\" ");
        }

        sb.Append("/>");

        return sb.ToString();
    }
}
