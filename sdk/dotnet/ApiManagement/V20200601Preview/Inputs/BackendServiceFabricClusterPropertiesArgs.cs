// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.ApiManagement.V20200601Preview.Inputs
{

    /// <summary>
    /// Properties of the Service Fabric Type Backend.
    /// </summary>
    public sealed class BackendServiceFabricClusterPropertiesArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The client certificate thumbprint for the management endpoint.
        /// </summary>
        [Input("clientCertificatethumbprint", required: true)]
        public Input<string> ClientCertificatethumbprint { get; set; } = null!;

        [Input("managementEndpoints", required: true)]
        private InputList<string>? _managementEndpoints;

        /// <summary>
        /// The cluster management endpoint.
        /// </summary>
        public InputList<string> ManagementEndpoints
        {
            get => _managementEndpoints ?? (_managementEndpoints = new InputList<string>());
            set => _managementEndpoints = value;
        }

        /// <summary>
        /// Maximum number of retries while attempting resolve the partition.
        /// </summary>
        [Input("maxPartitionResolutionRetries")]
        public Input<int>? MaxPartitionResolutionRetries { get; set; }

        [Input("serverCertificateThumbprints")]
        private InputList<string>? _serverCertificateThumbprints;

        /// <summary>
        /// Thumbprints of certificates cluster management service uses for tls communication
        /// </summary>
        public InputList<string> ServerCertificateThumbprints
        {
            get => _serverCertificateThumbprints ?? (_serverCertificateThumbprints = new InputList<string>());
            set => _serverCertificateThumbprints = value;
        }

        [Input("serverX509Names")]
        private InputList<Inputs.X509CertificateNameArgs>? _serverX509Names;

        /// <summary>
        /// Server X509 Certificate Names Collection
        /// </summary>
        public InputList<Inputs.X509CertificateNameArgs> ServerX509Names
        {
            get => _serverX509Names ?? (_serverX509Names = new InputList<Inputs.X509CertificateNameArgs>());
            set => _serverX509Names = value;
        }

        public BackendServiceFabricClusterPropertiesArgs()
        {
        }
    }
}
