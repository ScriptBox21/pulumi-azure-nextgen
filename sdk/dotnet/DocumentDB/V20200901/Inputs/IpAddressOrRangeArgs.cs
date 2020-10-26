// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.DocumentDB.V20200901.Inputs
{

    /// <summary>
    /// IpAddressOrRange object
    /// </summary>
    public sealed class IpAddressOrRangeArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// A single IPv4 address or a single IPv4 address range in CIDR format. Provided IPs must be well-formatted and cannot be contained in one of the following ranges: 10.0.0.0/8, 100.64.0.0/10, 172.16.0.0/12, 192.168.0.0/16, since these are not enforceable by the IP address filter. Example of valid inputs: “23.40.210.245” or “23.40.210.0/8”.
        /// </summary>
        [Input("ipAddressOrRange")]
        public Input<string>? IpAddressOrRange { get; set; }

        public IpAddressOrRangeArgs()
        {
        }
    }
}
