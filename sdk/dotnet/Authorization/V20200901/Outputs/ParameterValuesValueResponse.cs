// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Authorization.V20200901.Outputs
{

    [OutputType]
    public sealed class ParameterValuesValueResponse
    {
        /// <summary>
        /// The value of the parameter.
        /// </summary>
        public readonly object? Value;

        [OutputConstructor]
        private ParameterValuesValueResponse(object? value)
        {
            Value = value;
        }
    }
}
