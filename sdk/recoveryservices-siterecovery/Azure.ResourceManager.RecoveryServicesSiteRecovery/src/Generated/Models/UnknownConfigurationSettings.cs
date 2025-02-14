// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary> The UnknownConfigurationSettings. </summary>
    internal partial class UnknownConfigurationSettings : SiteRecoveryReplicationProviderSettings
    {
        /// <summary> Initializes a new instance of <see cref="UnknownConfigurationSettings"/>. </summary>
        /// <param name="instanceType"> Gets the class type. Overridden in derived classes. </param>
        internal UnknownConfigurationSettings(string instanceType) : base(instanceType)
        {
            InstanceType = instanceType ?? "Unknown";
        }
    }
}
