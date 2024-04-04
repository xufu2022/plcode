using System.Dynamic;

namespace CustomDynamic;

public class HtmlElement : DynamicObject
{
    public string TagName { get; }

    public HtmlElement(string tagName) => TagName = tagName;
}
