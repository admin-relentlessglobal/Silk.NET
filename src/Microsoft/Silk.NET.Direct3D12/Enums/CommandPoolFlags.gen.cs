// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [NativeName("Name", "D3D12_COMMAND_POOL_FLAGS")]
    public enum CommandPoolFlags : int
    {
        [Obsolete("Deprecated in favour of \"None\"")]
        [NativeName("Name", "D3D12_COMMAND_POOL_FLAG_NONE")]
        CommandPoolFlagNone = 0x0,
        [NativeName("Name", "D3D12_COMMAND_POOL_FLAG_NONE")]
        None = 0x0,
    }
}
