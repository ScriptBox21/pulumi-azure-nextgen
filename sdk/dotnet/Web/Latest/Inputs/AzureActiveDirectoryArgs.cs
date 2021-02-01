// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Web.Latest.Inputs
{

    public sealed class AzureActiveDirectoryArgs : Pulumi.ResourceArgs
    {
        [Input("enabled")]
        public Input<bool>? Enabled { get; set; }

        [Input("isAutoProvisioned")]
        public Input<bool>? IsAutoProvisioned { get; set; }

        /// <summary>
        /// Kind of resource.
        /// </summary>
        [Input("kind")]
        public Input<string>? Kind { get; set; }

        [Input("login")]
        public Input<Inputs.AzureActiveDirectoryLoginArgs>? Login { get; set; }

        [Input("registration")]
        public Input<Inputs.AzureActiveDirectoryRegistrationArgs>? Registration { get; set; }

        [Input("validation")]
        public Input<Inputs.AzureActiveDirectoryValidationArgs>? Validation { get; set; }

        public AzureActiveDirectoryArgs()
        {
        }
    }
}
