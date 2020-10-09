// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.ContainerService.Latest.Inputs
{

    public sealed class ContainerServiceDiagnosticsProfileArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Profile for the container service VM diagnostic agent.
        /// </summary>
        [Input("vmDiagnostics", required: true)]
        public Input<Inputs.ContainerServiceVMDiagnosticsArgs> VmDiagnostics { get; set; } = null!;

        public ContainerServiceDiagnosticsProfileArgs()
        {
        }
    }
}
