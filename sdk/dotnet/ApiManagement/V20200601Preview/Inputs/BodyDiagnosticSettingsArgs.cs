// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.ApiManagement.V20200601Preview.Inputs
{

    /// <summary>
    /// Body logging settings.
    /// </summary>
    public sealed class BodyDiagnosticSettingsArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Number of request body bytes to log.
        /// </summary>
        [Input("bytes")]
        public Input<int>? Bytes { get; set; }

        public BodyDiagnosticSettingsArgs()
        {
        }
    }
}