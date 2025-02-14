// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Automanage.Models
{
    /// <summary> The list of ServicePrincipals. </summary>
    internal partial class ServicePrincipalListResult
    {
        /// <summary> Initializes a new instance of <see cref="ServicePrincipalListResult"/>. </summary>
        internal ServicePrincipalListResult()
        {
            Value = new ChangeTrackingList<AutomanageServicePrincipalData>();
        }

        /// <summary> Initializes a new instance of <see cref="ServicePrincipalListResult"/>. </summary>
        /// <param name="value"> The list of servicePrincipals. </param>
        internal ServicePrincipalListResult(IReadOnlyList<AutomanageServicePrincipalData> value)
        {
            Value = value;
        }

        /// <summary> The list of servicePrincipals. </summary>
        public IReadOnlyList<AutomanageServicePrincipalData> Value { get; }
    }
}
