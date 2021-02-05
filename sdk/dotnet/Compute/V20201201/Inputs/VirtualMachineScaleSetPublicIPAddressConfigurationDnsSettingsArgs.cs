// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Compute.V20201201.Inputs
{

    /// <summary>
    /// Describes a virtual machines scale sets network configuration's DNS settings.
    /// </summary>
    public sealed class VirtualMachineScaleSetPublicIPAddressConfigurationDnsSettingsArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The Domain name label.The concatenation of the domain name label and vm index will be the domain name labels of the PublicIPAddress resources that will be created
        /// </summary>
        [Input("domainNameLabel", required: true)]
        public Input<string> DomainNameLabel { get; set; } = null!;

        public VirtualMachineScaleSetPublicIPAddressConfigurationDnsSettingsArgs()
        {
        }
    }
}
