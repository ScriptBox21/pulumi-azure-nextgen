// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Network.V20190701.Inputs
{

    /// <summary>
    /// IP configuration of an application gateway. Currently 1 public and 1 private IP configuration is allowed.
    /// </summary>
    public sealed class ApplicationGatewayIPConfigurationArgs : Pulumi.ResourceArgs
    {
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
        /// Name of the IP configuration that is unique within an Application Gateway.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// Reference of the subnet resource. A subnet from where application gateway gets its private address.
        /// </summary>
        [Input("subnet")]
        public Input<Inputs.SubResourceArgs>? Subnet { get; set; }

        /// <summary>
        /// Type of the resource.
        /// </summary>
        [Input("type")]
        public Input<string>? Type { get; set; }

        public ApplicationGatewayIPConfigurationArgs()
        {
        }
    }
}
