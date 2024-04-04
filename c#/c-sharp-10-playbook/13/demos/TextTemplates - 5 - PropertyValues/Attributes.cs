﻿namespace Pluralsight.CShPlaybook.AttribsReflection;

// Types can only be used to generate sales text
// if they have been marked with this attribute
// and CanUseInTemplate is true
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct)]
public sealed class ActualProductAttribute : Attribute
{
	public bool CanUseInTemplate { get; set; }
}

[AttributeUsage(AttributeTargets.Field)]
public sealed class FriendlyTextAttribute : Attribute
{
    public string FriendlyText { get; }

    public FriendlyTextAttribute(string friendlyText)
    {
        FriendlyText = friendlyText;
    }
}



