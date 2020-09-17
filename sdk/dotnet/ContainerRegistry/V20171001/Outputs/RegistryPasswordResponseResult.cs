// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.ContainerRegistry.V20171001.Outputs
{

    [OutputType]
    public sealed class RegistryPasswordResponseResult
    {
        /// <summary>
        /// The password name.
        /// </summary>
        public readonly string? Name;
        /// <summary>
        /// The password value.
        /// </summary>
        public readonly string? Value;

        [OutputConstructor]
        private RegistryPasswordResponseResult(
            string? name,

            string? value)
        {
            Name = name;
            Value = value;
        }
    }
}