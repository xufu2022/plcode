using System.Collections;
using System.Diagnostics.CodeAnalysis;
using System.Dynamic;
using System.Text;

namespace CustomDynamic;

public class HtmlElement : DynamicObject, IDictionary<string, object?>
{
    private readonly Dictionary<string, object?> _attributes = new();
    public string TagName { get; }

    public ICollection<string> Keys => throw new NotImplementedException();

    public ICollection<object?> Values => throw new NotImplementedException();

    public int Count => throw new NotImplementedException();

    public bool IsReadOnly => throw new NotImplementedException();

    public object? this[string key] 
    {
        get => _attributes[key];
        set => _attributes[key] = value;
    }

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

    public override bool TryInvokeMember(InvokeMemberBinder binder,
                                         object?[]? args,
                                         out object? result)
    {
        if (binder.Name is "Render")
        {
            result = ToString();
            return true;
        }

        result = null;
        return false;
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

    public void Add(string key, object? value)
    {
        throw new NotImplementedException();
    }

    public bool ContainsKey(string key)
    {
        throw new NotImplementedException();
    }

    public bool Remove(string key)
    {
        throw new NotImplementedException();
    }

    public bool TryGetValue(string key, [MaybeNullWhen(false)] out object? value)
    {
        throw new NotImplementedException();
    }

    public void Add(KeyValuePair<string, object?> item)
    {
        throw new NotImplementedException();
    }

    public void Clear()
    {
        throw new NotImplementedException();
    }

    public bool Contains(KeyValuePair<string, object?> item)
    {
        throw new NotImplementedException();
    }

    public void CopyTo(KeyValuePair<string, object?>[] array, int arrayIndex)
    {
        throw new NotImplementedException();
    }

    public bool Remove(KeyValuePair<string, object?> item)
    {
        throw new NotImplementedException();
    }

    public IEnumerator<KeyValuePair<string, object?>> GetEnumerator()
    {
        return _attributes.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return _attributes.GetEnumerator();
    }
}
