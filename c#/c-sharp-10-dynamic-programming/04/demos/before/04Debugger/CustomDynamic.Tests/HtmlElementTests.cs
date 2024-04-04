using Microsoft.CSharp.RuntimeBinder;

namespace CustomDynamic.Tests;

public class HtmlElementTests
{
    [Fact]
    public void ShouldStoreTagName()
    {
        dynamic image = new HtmlElement("img");

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
}
