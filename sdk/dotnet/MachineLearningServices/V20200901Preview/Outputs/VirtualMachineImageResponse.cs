// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.MachineLearningServices.V20200901Preview.Outputs
{

    [OutputType]
    public sealed class VirtualMachineImageResponse
    {
        /// <summary>
        /// Virtual Machine image path
        /// </summary>
        public readonly string Id;

        [OutputConstructor]
        private VirtualMachineImageResponse(string id)
        {
            Id = id;
        }
    }
}