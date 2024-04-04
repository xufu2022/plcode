namespace CustomDynamic.Tests;

public class HtmlElementTests
{
    [Fact]
    public void ShouldStoreTagName()
    {
        dynamic image = new HtmlElement("img");

        Assert.Equal("img", image.TagName);
    }
}
