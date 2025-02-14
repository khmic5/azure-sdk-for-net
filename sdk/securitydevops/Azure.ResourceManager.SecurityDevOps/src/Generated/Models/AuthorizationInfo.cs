// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.SecurityDevOps.Models
{
    /// <summary> The AuthorizationInfo. </summary>
    internal partial class AuthorizationInfo
    {
        /// <summary> Initializes a new instance of <see cref="AuthorizationInfo"/>. </summary>
        public AuthorizationInfo()
        {
        }

        /// <summary> Initializes a new instance of <see cref="AuthorizationInfo"/>. </summary>
        /// <param name="code"> Gets or sets one-time OAuth code to exchange for refresh and access tokens. </param>
        internal AuthorizationInfo(string code)
        {
            Code = code;
        }

        /// <summary> Gets or sets one-time OAuth code to exchange for refresh and access tokens. </summary>
        public string Code { get; set; }
    }
}
