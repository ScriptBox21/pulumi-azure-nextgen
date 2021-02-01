// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Web.Latest.Inputs
{

    public sealed class AllowedAudiencesValidationArgs : Pulumi.ResourceArgs
    {
        [Input("allowedAudiences")]
        private InputList<string>? _allowedAudiences;
        public InputList<string> AllowedAudiences
        {
            get => _allowedAudiences ?? (_allowedAudiences = new InputList<string>());
            set => _allowedAudiences = value;
        }

        /// <summary>
        /// Kind of resource.
        /// </summary>
        [Input("kind")]
        public Input<string>? Kind { get; set; }

        public AllowedAudiencesValidationArgs()
        {
        }
    }
}
