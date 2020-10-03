// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.MachineLearningServices.V20200801.Inputs
{

    public sealed class VirtualMachinePropertiesArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Public IP address of the virtual machine.
        /// </summary>
        [Input("address")]
        public Input<string>? Address { get; set; }

        /// <summary>
        /// Admin credentials for virtual machine
        /// </summary>
        [Input("administratorAccount")]
        public Input<Inputs.VirtualMachineSshCredentialsArgs>? AdministratorAccount { get; set; }

        /// <summary>
        /// Port open for ssh connections.
        /// </summary>
        [Input("sshPort")]
        public Input<int>? SshPort { get; set; }

        /// <summary>
        /// Virtual Machine size
        /// </summary>
        [Input("virtualMachineSize")]
        public Input<string>? VirtualMachineSize { get; set; }

        public VirtualMachinePropertiesArgs()
        {
        }
    }
}
