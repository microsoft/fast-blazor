﻿using Microsoft.Extensions.Configuration;
using Microsoft.JSInterop;

namespace Microsoft.Fast.Components.FluentUI.DesignTokens;

/// <summary>
/// The NeutralFillStrongRest design token
/// </summary>
public sealed class NeutralFillStrongRest : DesignToken<int?>
{
    public NeutralFillStrongRest()
    {
        Name = Constants.NeutralFillStrongRest;
    }

    /// <summary>
    /// Constructs an instance of the NeutralFillStrongRest design token
    /// </summary>
    /// <param name="jsRuntime">IJSRuntime reference (from DI)</param>
    /// <param name="configuration">IConfiguration reference (from DI)</param>
    public NeutralFillStrongRest(IJSRuntime jsRuntime, IConfiguration configuration) : base(jsRuntime, configuration)
    {
        Name = Constants.NeutralFillStrongRest;
    }
}
