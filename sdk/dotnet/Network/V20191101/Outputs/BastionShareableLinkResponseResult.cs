// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Network.V20191101.Outputs
{

    [OutputType]
    public sealed class BastionShareableLinkResponseResult
    {
        /// <summary>
        /// The unique Bastion Shareable Link to the virtual machine.
        /// </summary>
        public readonly string Bsl;
        /// <summary>
        /// The time when the link was created.
        /// </summary>
        public readonly string CreatedAt;
        /// <summary>
        /// Optional field indicating the warning or error message related to the vm in case of partial failure.
        /// </summary>
        public readonly string Message;
        /// <summary>
        /// Reference of the virtual machine resource.
        /// </summary>
        public readonly Outputs.VMResponseResult Vm;

        [OutputConstructor]
        private BastionShareableLinkResponseResult(
            string bsl,

            string createdAt,

            string message,

            Outputs.VMResponseResult vm)
        {
            Bsl = bsl;
            CreatedAt = createdAt;
            Message = message;
            Vm = vm;
        }
    }
}
