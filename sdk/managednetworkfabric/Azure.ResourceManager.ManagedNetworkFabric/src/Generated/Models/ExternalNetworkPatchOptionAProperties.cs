// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;

namespace Azure.ResourceManager.ManagedNetworkFabric.Models
{
    /// <summary> option A properties object. </summary>
    public partial class ExternalNetworkPatchOptionAProperties : Layer3IPPrefixProperties
    {
        /// <summary> Initializes a new instance of <see cref="ExternalNetworkPatchOptionAProperties"/>. </summary>
        public ExternalNetworkPatchOptionAProperties()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ExternalNetworkPatchOptionAProperties"/>. </summary>
        /// <param name="primaryIPv4Prefix"> IPv4 Address Prefix. </param>
        /// <param name="primaryIPv6Prefix"> IPv6 Address Prefix. </param>
        /// <param name="secondaryIPv4Prefix"> Secondary IPv4 Address Prefix. </param>
        /// <param name="secondaryIPv6Prefix"> Secondary IPv6 Address Prefix. </param>
        /// <param name="mtu"> MTU to use for option A peering. </param>
        /// <param name="vlanId"> Vlan identifier. Example : 501. </param>
        /// <param name="fabricAsn"> Fabric ASN number. Example 65001. </param>
        /// <param name="peerAsn"> Peer ASN number.Example : 28. </param>
        /// <param name="bfdConfiguration"> BFD configuration properties. </param>
        /// <param name="ingressAclId"> Ingress Acl. ARM resource ID of Access Control Lists. </param>
        /// <param name="egressAclId"> Egress Acl. ARM resource ID of Access Control Lists. </param>
        internal ExternalNetworkPatchOptionAProperties(string primaryIPv4Prefix, string primaryIPv6Prefix, string secondaryIPv4Prefix, string secondaryIPv6Prefix, int? mtu, int? vlanId, long? fabricAsn, long? peerAsn, BfdConfiguration bfdConfiguration, ResourceIdentifier ingressAclId, ResourceIdentifier egressAclId) : base(primaryIPv4Prefix, primaryIPv6Prefix, secondaryIPv4Prefix, secondaryIPv6Prefix)
        {
            Mtu = mtu;
            VlanId = vlanId;
            FabricAsn = fabricAsn;
            PeerAsn = peerAsn;
            BfdConfiguration = bfdConfiguration;
            IngressAclId = ingressAclId;
            EgressAclId = egressAclId;
        }

        /// <summary> MTU to use for option A peering. </summary>
        public int? Mtu { get; set; }
        /// <summary> Vlan identifier. Example : 501. </summary>
        public int? VlanId { get; set; }
        /// <summary> Fabric ASN number. Example 65001. </summary>
        public long? FabricAsn { get; }
        /// <summary> Peer ASN number.Example : 28. </summary>
        public long? PeerAsn { get; set; }
        /// <summary> BFD configuration properties. </summary>
        public BfdConfiguration BfdConfiguration { get; set; }
        /// <summary> Ingress Acl. ARM resource ID of Access Control Lists. </summary>
        public ResourceIdentifier IngressAclId { get; set; }
        /// <summary> Egress Acl. ARM resource ID of Access Control Lists. </summary>
        public ResourceIdentifier EgressAclId { get; set; }
    }
}
