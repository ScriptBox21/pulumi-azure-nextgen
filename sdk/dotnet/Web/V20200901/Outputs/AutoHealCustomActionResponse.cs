// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Web.V20200901.Outputs
{

    [OutputType]
    public sealed class AutoHealCustomActionResponse
    {
        /// <summary>
        /// Executable to be run.
        /// </summary>
        public readonly string? Exe;
        /// <summary>
        /// Parameters for the executable.
        /// </summary>
        public readonly string? Parameters;

        [OutputConstructor]
        private AutoHealCustomActionResponse(
            string? exe,

            string? parameters)
        {
            Exe = exe;
            Parameters = parameters;
        }
    }
}
