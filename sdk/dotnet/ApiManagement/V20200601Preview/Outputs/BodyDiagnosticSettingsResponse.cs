// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.ApiManagement.V20200601Preview.Outputs
{

    [OutputType]
    public sealed class BodyDiagnosticSettingsResponse
    {
        /// <summary>
        /// Number of request body bytes to log.
        /// </summary>
        public readonly int? Bytes;

        [OutputConstructor]
        private BodyDiagnosticSettingsResponse(int? bytes)
        {
            Bytes = bytes;
        }
    }
}
