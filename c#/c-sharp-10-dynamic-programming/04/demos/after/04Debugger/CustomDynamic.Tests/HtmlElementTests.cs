﻿using Microsoft.CSharp.RuntimeBinder;

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
}
