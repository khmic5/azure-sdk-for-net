// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

#nullable disable

using System;

namespace Azure.AI.OpenAI;

// CUSTOM CODE NOTE:
//   This manages the intended internal visibility of the response format, which is instead handled by separate
//   methods in .NET.

internal readonly partial struct ImageGenerationResponseFormat : IEquatable<ImageGenerationResponseFormat>
{
}
