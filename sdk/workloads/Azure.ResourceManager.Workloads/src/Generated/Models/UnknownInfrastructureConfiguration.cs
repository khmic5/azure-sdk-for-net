// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Workloads.Models
{
    /// <summary> The UnknownInfrastructureConfiguration. </summary>
    internal partial class UnknownInfrastructureConfiguration : InfrastructureConfiguration
    {
        /// <summary> Initializes a new instance of <see cref="UnknownInfrastructureConfiguration"/>. </summary>
        /// <param name="deploymentType"> The type of SAP deployment, single server or Three tier. </param>
        /// <param name="appResourceGroup"> The application resource group where SAP system resources will be deployed. </param>
        internal UnknownInfrastructureConfiguration(SapDeploymentType deploymentType, string appResourceGroup) : base(deploymentType, appResourceGroup)
        {
            DeploymentType = deploymentType;
        }
    }
}
