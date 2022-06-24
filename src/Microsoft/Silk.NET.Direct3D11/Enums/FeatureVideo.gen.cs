// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D11
{
    [NativeName("Name", "D3D11_FEATURE_VIDEO")]
    public enum FeatureVideo : int
    {
        [Obsolete("Deprecated in favour of \"DecoderHistogram\"")]
        [NativeName("Name", "D3D11_FEATURE_VIDEO_DECODER_HISTOGRAM")]
        FeatureVideoDecoderHistogram = 0x0,
        [NativeName("Name", "D3D11_FEATURE_VIDEO_DECODER_HISTOGRAM")]
        DecoderHistogram = 0x0,
    }
}
