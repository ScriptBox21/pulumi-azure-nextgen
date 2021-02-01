// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Web.Latest.Inputs
{

    public sealed class AuthPlatformArgs : Pulumi.ResourceArgs
    {
        [Input("configFilePath")]
        public Input<string>? ConfigFilePath { get; set; }

        [Input("enabled")]
        public Input<bool>? Enabled { get; set; }

        /// <summary>
        /// Kind of resource.
        /// </summary>
        [Input("kind")]
        public Input<string>? Kind { get; set; }

        [Input("runtimeVersion")]
        public Input<string>? RuntimeVersion { get; set; }

        public AuthPlatformArgs()
        {
        }
    }
}
