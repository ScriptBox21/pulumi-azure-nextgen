// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Network.V20180801.Inputs
{

    /// <summary>
    /// Trusted Root certificates of an application gateway.
    /// </summary>
    public sealed class ApplicationGatewayTrustedRootCertificateArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Certificate public data.
        /// </summary>
        [Input("data")]
        public Input<string>? Data { get; set; }

        /// <summary>
        /// A unique read-only string that changes whenever the resource is updated.
        /// </summary>
        [Input("etag")]
        public Input<string>? Etag { get; set; }

        /// <summary>
        /// Resource ID.
        /// </summary>
        [Input("id")]
        public Input<string>? Id { get; set; }

        /// <summary>
        /// KeyVault Secret Id for certificate.
        /// </summary>
        [Input("keyvaultSecretId")]
        public Input<string>? KeyvaultSecretId { get; set; }

        /// <summary>
        /// Name of the trusted root certificate that is unique within an Application Gateway.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// Provisioning state of the trusted root certificate resource. Possible values are: 'Updating', 'Deleting', and 'Failed'.
        /// </summary>
        [Input("provisioningState")]
        public Input<string>? ProvisioningState { get; set; }

        /// <summary>
        /// Type of the resource.
        /// </summary>
        [Input("type")]
        public Input<string>? Type { get; set; }

        public ApplicationGatewayTrustedRootCertificateArgs()
        {
        }
    }
}