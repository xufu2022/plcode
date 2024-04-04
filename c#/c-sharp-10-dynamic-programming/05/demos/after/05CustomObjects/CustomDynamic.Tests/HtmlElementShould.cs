using Microsoft.CSharp.RuntimeBinder;
using System.Linq;

namespace CustomDynamic.Tests;

public class HtmlElementTests
{
    [Fact]
    public void ShouldStoreTagName()
    {
        var image = new HtmlElement("img");

        Assert.Equal("img", image.TagName);
    }

    [Fact]
    public void ShouldAddAttributeNameAndValueDynamically()
    {
        dynamic image = new HtmlElement("img");

        image.src = "car.png";

        Assert.Equal("car.png", image.src);
    }

    [Fact]
    public void ShouldErrorIfAttributeNotSet()
    {
        dynamic image = new HtmlElement("img");

        Assert.Throws<RuntimeBinderException>(() => image.src);
    }

    [Fact]
    public void ShouldReturnDynamicMemberNames()
    {
        dynamic image = new HtmlElement("img");

        image.src = "car.png";
        image.alt = "a blue car";

        IReadOnlyList<string> members = image.GetDynamicMemberNames();

        Assert.Equal(2, members.Count);

        Assert.Equal("src", members[0]);
        Assert.Equal("alt", members[1]);
    }

    [Fact]
    public void ShouldOutputTagHtml()
    {
        dynamic image = new HtmlElement("img");

        image.src = "car.png";
        image.alt = "a blue car";

        var html = image.ToString();

        Assert.Equal("<img src=\"car.png\" alt=\"a blue car\"></img>", html);
    }


    [Fact]
    public void ShouldBeCastableToDictionary()
    {
        dynamic image = new HtmlElement("img");

        var attributes = (IDictionary<string, object?>) image;

        attributes["src"] = "car.png";

        Assert.Equal("car.png", image["src"]);
    }


    [Fact]
    public void ShouldBeEnumerable()
    {
        dynamic image = new HtmlElement("img");

        image.src = "car.png";

        var count = 0;
        foreach (KeyValuePair<string, object?> attribute in image)
        {
            Assert.Equal("src", attribute.Key);
            Assert.Equal("car.png", attribute.Value);
            count++;
        }

        Assert.Equal(1, count);
    }

    [Fact]
    public void ShouldRenderHtml()
    {
        dynamic image = new HtmlElement("img");

        image.src = "car.png";
        image.alt = "a blue car";

        var html = image.Render();

        Assert.Equal("<img src=\"car.png\" alt=\"a blue car\"></img>", html);
    }

    [Fact]
    public void ShouldRenderHtmlOnInvoke()
    {
        dynamic image = new HtmlElement("img");

        image.src = "car.png";
        image.alt = "a blue car";

        var html = image();

        Assert.Equal("<img src=\"car.png\" alt=\"a blue car\"></img>", html);
    }
}
