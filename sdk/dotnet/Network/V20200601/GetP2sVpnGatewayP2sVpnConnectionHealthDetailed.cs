// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Network.V20200601
{
    public static class GetP2sVpnGatewayP2sVpnConnectionHealthDetailed
    {
        public static Task<GetP2sVpnGatewayP2sVpnConnectionHealthDetailedResult> InvokeAsync(GetP2sVpnGatewayP2sVpnConnectionHealthDetailedArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetP2sVpnGatewayP2sVpnConnectionHealthDetailedResult>("azure-nextgen:network/v20200601:getP2sVpnGatewayP2sVpnConnectionHealthDetailed", args ?? new GetP2sVpnGatewayP2sVpnConnectionHealthDetailedArgs(), options.WithVersion());
    }


    public sealed class GetP2sVpnGatewayP2sVpnConnectionHealthDetailedArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// The name of the P2SVpnGateway.
        /// </summary>
        [Input("gatewayName", required: true)]
        public string GatewayName { get; set; } = null!;

        /// <summary>
        /// The sas-url to download the P2S Vpn connection health detail.
        /// </summary>
        [Input("outputBlobSasUrl")]
        public string? OutputBlobSasUrl { get; set; }

        /// <summary>
        /// The name of the resource group.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public string ResourceGroupName { get; set; } = null!;

        [Input("vpnUserNamesFilter")]
        private List<string>? _vpnUserNamesFilter;

        /// <summary>
        /// The list of p2s vpn user names whose p2s vpn connection detailed health to retrieve for.
        /// </summary>
        public List<string> VpnUserNamesFilter
        {
            get => _vpnUserNamesFilter ?? (_vpnUserNamesFilter = new List<string>());
            set => _vpnUserNamesFilter = value;
        }

        public GetP2sVpnGatewayP2sVpnConnectionHealthDetailedArgs()
        {
        }
    }


    [OutputType]
    public sealed class GetP2sVpnGatewayP2sVpnConnectionHealthDetailedResult
    {
        /// <summary>
        /// Returned sas url of the blob to which the p2s vpn connection detailed health will be written.
        /// </summary>
        public readonly string? SasUrl;

        [OutputConstructor]
        private GetP2sVpnGatewayP2sVpnConnectionHealthDetailedResult(string? sasUrl)
        {
            SasUrl = sasUrl;
        }
    }
}
