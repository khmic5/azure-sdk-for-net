// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.EventGrid.Models
{
    /// <summary> The Authentication properties for the client. </summary>
    public partial class EventGridNamespaceClientAuthentication
    {
        /// <summary> Initializes a new instance of <see cref="EventGridNamespaceClientAuthentication"/>. </summary>
        public EventGridNamespaceClientAuthentication()
        {
        }

        /// <summary> Initializes a new instance of <see cref="EventGridNamespaceClientAuthentication"/>. </summary>
        /// <param name="certificateThumbprint"> The self signed certificate's thumbprints data used for authentication. </param>
        /// <param name="certificateSubject"> The CA certificate subject name used for authentication. </param>
        internal EventGridNamespaceClientAuthentication(ClientCertificateThumbprint certificateThumbprint, ClientCertificateSubjectDistinguishedName certificateSubject)
        {
            CertificateThumbprint = certificateThumbprint;
            CertificateSubject = certificateSubject;
        }

        /// <summary> The self signed certificate's thumbprints data used for authentication. </summary>
        public ClientCertificateThumbprint CertificateThumbprint { get; set; }
        /// <summary> The CA certificate subject name used for authentication. </summary>
        public ClientCertificateSubjectDistinguishedName CertificateSubject { get; set; }
    }
}
