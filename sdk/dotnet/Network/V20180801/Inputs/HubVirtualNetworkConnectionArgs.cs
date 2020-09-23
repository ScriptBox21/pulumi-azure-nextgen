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
    /// HubVirtualNetworkConnection Resource.
    /// </summary>
    public sealed class HubVirtualNetworkConnectionArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// VirtualHub to RemoteVnet transit to enabled or not.
        /// </summary>
        [Input("allowHubToRemoteVnetTransit")]
        public Input<bool>? AllowHubToRemoteVnetTransit { get; set; }

        /// <summary>
        /// Allow RemoteVnet to use Virtual Hub's gateways.
        /// </summary>
        [Input("allowRemoteVnetToUseHubVnetGateways")]
        public Input<bool>? AllowRemoteVnetToUseHubVnetGateways { get; set; }

        /// <summary>
        /// Enable internet security
        /// </summary>
        [Input("enableInternetSecurity")]
        public Input<bool>? EnableInternetSecurity { get; set; }

        /// <summary>
        /// Resource ID.
        /// </summary>
        [Input("id")]
        public Input<string>? Id { get; set; }

        /// <summary>
        /// The name of the resource that is unique within a resource group. This name can be used to access the resource.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// Reference to the remote virtual network.
        /// </summary>
        [Input("remoteVirtualNetwork")]
        public Input<Inputs.SubResourceArgs>? RemoteVirtualNetwork { get; set; }

        public HubVirtualNetworkConnectionArgs()
        {
        }
    }
}
