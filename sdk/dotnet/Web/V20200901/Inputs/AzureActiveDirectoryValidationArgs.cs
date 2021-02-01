// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Web.V20200901.Inputs
{

    public sealed class AzureActiveDirectoryValidationArgs : Pulumi.ResourceArgs
    {
        [Input("allowedAudiences")]
        private InputList<string>? _allowedAudiences;
        public InputList<string> AllowedAudiences
        {
            get => _allowedAudiences ?? (_allowedAudiences = new InputList<string>());
            set => _allowedAudiences = value;
        }

        [Input("jwtClaimChecks")]
        public Input<Inputs.JwtClaimChecksArgs>? JwtClaimChecks { get; set; }

        /// <summary>
        /// Kind of resource.
        /// </summary>
        [Input("kind")]
        public Input<string>? Kind { get; set; }

        public AzureActiveDirectoryValidationArgs()
        {
        }
    }
}
