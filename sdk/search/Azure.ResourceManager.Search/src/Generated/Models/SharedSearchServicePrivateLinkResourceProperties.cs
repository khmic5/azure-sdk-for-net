// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;

namespace Azure.ResourceManager.Search.Models
{
    /// <summary> Describes the properties of an existing Shared Private Link Resource managed by the Azure Cognitive Search service. </summary>
    public partial class SharedSearchServicePrivateLinkResourceProperties
    {
        /// <summary> Initializes a new instance of <see cref="SharedSearchServicePrivateLinkResourceProperties"/>. </summary>
        public SharedSearchServicePrivateLinkResourceProperties()
        {
        }

        /// <summary> Initializes a new instance of <see cref="SharedSearchServicePrivateLinkResourceProperties"/>. </summary>
        /// <param name="privateLinkResourceId"> The resource id of the resource the shared private link resource is for. </param>
        /// <param name="groupId"> The group id from the provider of resource the shared private link resource is for. </param>
        /// <param name="requestMessage"> The request message for requesting approval of the shared private link resource. </param>
        /// <param name="resourceRegion"> Optional. Can be used to specify the Azure Resource Manager location of the resource to which a shared private link is to be created. This is only required for those resources whose DNS configuration are regional (such as Azure Kubernetes Service). </param>
        /// <param name="status"> Status of the shared private link resource. Can be Pending, Approved, Rejected or Disconnected. </param>
        /// <param name="provisioningState"> The provisioning state of the shared private link resource. Can be Updating, Deleting, Failed, Succeeded or Incomplete. </param>
        internal SharedSearchServicePrivateLinkResourceProperties(ResourceIdentifier privateLinkResourceId, string groupId, string requestMessage, AzureLocation? resourceRegion, SharedSearchServicePrivateLinkResourceStatus? status, SharedSearchServicePrivateLinkResourceProvisioningState? provisioningState)
        {
            PrivateLinkResourceId = privateLinkResourceId;
            GroupId = groupId;
            RequestMessage = requestMessage;
            ResourceRegion = resourceRegion;
            Status = status;
            ProvisioningState = provisioningState;
        }

        /// <summary> The resource id of the resource the shared private link resource is for. </summary>
        public ResourceIdentifier PrivateLinkResourceId { get; set; }
        /// <summary> The group id from the provider of resource the shared private link resource is for. </summary>
        public string GroupId { get; set; }
        /// <summary> The request message for requesting approval of the shared private link resource. </summary>
        public string RequestMessage { get; set; }
        /// <summary> Optional. Can be used to specify the Azure Resource Manager location of the resource to which a shared private link is to be created. This is only required for those resources whose DNS configuration are regional (such as Azure Kubernetes Service). </summary>
        public AzureLocation? ResourceRegion { get; set; }
        /// <summary> Status of the shared private link resource. Can be Pending, Approved, Rejected or Disconnected. </summary>
        public SharedSearchServicePrivateLinkResourceStatus? Status { get; set; }
        /// <summary> The provisioning state of the shared private link resource. Can be Updating, Deleting, Failed, Succeeded or Incomplete. </summary>
        public SharedSearchServicePrivateLinkResourceProvisioningState? ProvisioningState { get; set; }
    }
}
