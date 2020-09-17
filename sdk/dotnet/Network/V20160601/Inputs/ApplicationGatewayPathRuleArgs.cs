// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Network.V20160601.Inputs
{

    /// <summary>
    /// Path rule of URL path map of application gateway
    /// </summary>
    public sealed class ApplicationGatewayPathRuleArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Backend address pool resource of URL path map 
        /// </summary>
        [Input("backendAddressPool")]
        public Input<Inputs.SubResourceArgs>? BackendAddressPool { get; set; }

        /// <summary>
        /// Backend http settings resource of URL path map 
        /// </summary>
        [Input("backendHttpSettings")]
        public Input<Inputs.SubResourceArgs>? BackendHttpSettings { get; set; }

        /// <summary>
        /// A unique read-only string that changes whenever the resource is updated
        /// </summary>
        [Input("etag")]
        public Input<string>? Etag { get; set; }

        /// <summary>
        /// Resource Id
        /// </summary>
        [Input("id")]
        public Input<string>? Id { get; set; }

        /// <summary>
        /// Name of the resource that is unique within a resource group. This name can be used to access the resource
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        [Input("paths")]
        private InputList<string>? _paths;

        /// <summary>
        /// Path rules of URL path map
        /// </summary>
        public InputList<string> Paths
        {
            get => _paths ?? (_paths = new InputList<string>());
            set => _paths = value;
        }

        /// <summary>
        /// Path rule of URL path map resource Updating/Deleting/Failed
        /// </summary>
        [Input("provisioningState")]
        public Input<string>? ProvisioningState { get; set; }

        public ApplicationGatewayPathRuleArgs()
        {
        }
    }
}