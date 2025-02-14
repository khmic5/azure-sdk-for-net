// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Compute.Models
{
    /// <summary> Describes the network profile for the role instance. </summary>
    internal partial class RoleInstanceNetworkProfile
    {
        /// <summary> Initializes a new instance of <see cref="RoleInstanceNetworkProfile"/>. </summary>
        internal RoleInstanceNetworkProfile()
        {
            NetworkInterfaces = new ChangeTrackingList<WritableSubResource>();
        }

        /// <summary> Initializes a new instance of <see cref="RoleInstanceNetworkProfile"/>. </summary>
        /// <param name="networkInterfaces"> Specifies the list of resource Ids for the network interfaces associated with the role instance. </param>
        internal RoleInstanceNetworkProfile(IReadOnlyList<WritableSubResource> networkInterfaces)
        {
            NetworkInterfaces = networkInterfaces;
        }

        /// <summary> Specifies the list of resource Ids for the network interfaces associated with the role instance. </summary>
        public IReadOnlyList<WritableSubResource> NetworkInterfaces { get; }
    }
}
