// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.ApiManagement.V20191201.Inputs
{

    /// <summary>
    /// Control Plane Apis version constraint for the API Management service.
    /// </summary>
    public sealed class ApiVersionConstraintArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Limit control plane API calls to API Management service with version equal to or newer than this value.
        /// </summary>
        [Input("minApiVersion")]
        public Input<string>? MinApiVersion { get; set; }

        public ApiVersionConstraintArgs()
        {
        }
    }
}