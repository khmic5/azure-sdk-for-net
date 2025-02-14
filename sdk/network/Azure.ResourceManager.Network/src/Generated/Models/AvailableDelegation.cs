// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> The serviceName of an AvailableDelegation indicates a possible delegation for a subnet. </summary>
    public partial class AvailableDelegation : ResourceData
    {
        /// <summary> Initializes a new instance of <see cref="AvailableDelegation"/>. </summary>
        internal AvailableDelegation()
        {
            Actions = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="AvailableDelegation"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="serviceName"> The name of the service and resource. </param>
        /// <param name="actions"> The actions permitted to the service upon delegation. </param>
        internal AvailableDelegation(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, string serviceName, IReadOnlyList<string> actions) : base(id, name, resourceType, systemData)
        {
            ServiceName = serviceName;
            Actions = actions;
        }

        /// <summary> The name of the service and resource. </summary>
        public string ServiceName { get; }
        /// <summary> The actions permitted to the service upon delegation. </summary>
        public IReadOnlyList<string> Actions { get; }
    }
}
