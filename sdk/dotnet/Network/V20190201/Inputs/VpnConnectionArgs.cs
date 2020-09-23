// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Network.V20190201.Inputs
{

    /// <summary>
    /// VpnConnection Resource.
    /// </summary>
    public sealed class VpnConnectionArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Expected bandwidth in MBPS.
        /// </summary>
        [Input("connectionBandwidth")]
        public Input<int>? ConnectionBandwidth { get; set; }

        /// <summary>
        /// EnableBgp flag
        /// </summary>
        [Input("enableBgp")]
        public Input<bool>? EnableBgp { get; set; }

        /// <summary>
        /// Enable internet security
        /// </summary>
        [Input("enableInternetSecurity")]
        public Input<bool>? EnableInternetSecurity { get; set; }

        /// <summary>
        /// EnableBgp flag
        /// </summary>
        [Input("enableRateLimiting")]
        public Input<bool>? EnableRateLimiting { get; set; }

        /// <summary>
        /// Resource ID.
        /// </summary>
        [Input("id")]
        public Input<string>? Id { get; set; }

        [Input("ipsecPolicies")]
        private InputList<Inputs.IpsecPolicyArgs>? _ipsecPolicies;

        /// <summary>
        /// The IPSec Policies to be considered by this connection.
        /// </summary>
        public InputList<Inputs.IpsecPolicyArgs> IpsecPolicies
        {
            get => _ipsecPolicies ?? (_ipsecPolicies = new InputList<Inputs.IpsecPolicyArgs>());
            set => _ipsecPolicies = value;
        }

        /// <summary>
        /// The name of the resource that is unique within a resource group. This name can be used to access the resource.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// Id of the connected vpn site.
        /// </summary>
        [Input("remoteVpnSite")]
        public Input<Inputs.SubResourceArgs>? RemoteVpnSite { get; set; }

        /// <summary>
        /// Routing weight for vpn connection.
        /// </summary>
        [Input("routingWeight")]
        public Input<int>? RoutingWeight { get; set; }

        /// <summary>
        /// SharedKey for the vpn connection.
        /// </summary>
        [Input("sharedKey")]
        public Input<string>? SharedKey { get; set; }

        /// <summary>
        /// Use local azure ip to initiate connection
        /// </summary>
        [Input("useLocalAzureIpAddress")]
        public Input<bool>? UseLocalAzureIpAddress { get; set; }

        /// <summary>
        /// Connection protocol used for this connection
        /// </summary>
        [Input("vpnConnectionProtocolType")]
        public Input<string>? VpnConnectionProtocolType { get; set; }

        public VpnConnectionArgs()
        {
        }
    }
}
